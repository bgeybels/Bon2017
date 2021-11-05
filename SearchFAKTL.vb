Imports System.Linq.Dynamic
Imports System.Linq
Imports System.ComponentModel

Public Class SearchFAKTL
    Private ordDGREC As String = "FaktL"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchFAKTL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'My.Settings.fltbontbw = FltCBtbw.SelectedIndex
    End Sub

    Private Sub SearchFAKTL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        For Each a In GroupFilter.Controls
            If TypeOf a Is ComboBox Then
                If a.name Like "Flt*" Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        'TSButtonPermissions(TSBnew)
        'TSButtonPermissions(TSBdelete)
        'CMButtonPermissions(NieuwToolStripMenuItem)
        'CMButtonPermissions(VerwijderToolStripMenuItem)

        ' get values from settings
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw

        'Info
        FillInfo()

        nofilter = False
        hkey = keyfaktjr
        hkey2 = keyfaktnr
        hkeystr = keyfaktdc
        SetGrids()
        Fill_DGREC()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkeystr
        SetRECrow()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        hkey = keyfaktjr
        hkey2 = keybonnr
        hkeystr = keybonlvnr
        Fill_DGREC()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkeystr
        SetRECrow()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkeystr
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("JR").Value = keyfaktjr And DGREC.Rows(lp).Cells("NR").Value = keyfaktnr And DGREC.Rows(lp).Cells("DC").Value = keyfaktdc Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(4)
            End If
        Next
    End Sub

    Private Sub FillInfoRow()
        If nofilter = True Then Exit Sub
        TBResultTelL.Text = ""
        'Dim codrec = From cod In db.CODs
        '             Where cod.CNRQ = keycnrq
        '             Select cod.Stock, cod.Minstock, cod.Eenhp, cod.Aankp, cod.Plmagazijn, cod.Besteld, cod.notstock, cod.gratis
        '             Take 1

        'Dim extra As String = ""
        'For Each rec In codrec
        '    TBResultTelL.Text = TBResultTelL.Text & "Stock: " & rec.Stock & "    Minimum Stock: " & rec.Minstock & "   (" & rec.Plmagazijn & ")"
        '    TBResultTelL.Text = TBResultTelL.Text & Environment.NewLine & " AP: " & rec.Aankp & "  VP: " & rec.Eenhp
        '    If rec.gratis = True Then extra = extra & "Gratis "
        '    If rec.notstock = True Then extra = extra & "Niet_opgenomen_in_Stock "
        '    If rec.Besteld = True Then extra = extra & "In_Bestelling"
        '    TBResultTelL.Text = TBResultTelL.Text & Environment.NewLine & extra
        'Next

    End Sub

    Private Sub FillInfo()
        'TBresultBONL
        TBResultBONL.Text = keyfaktjr & "/" & keyfaktnr & "-" & keyfaktdc
        'Dim klantrec = From bon In db.BONs
        '               Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
        '               Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr
        '               Select bon.BONJR, klant.KNRQ
        'For Each klantr In klantrec
        '    TBResultBONL.Text = TBResultBONL.Text & GetKlantNaam(klantr.KNRQ)
        'Next

        ''TBresultTELa
        'TBResultTelA.Text = GetBonlFigures(keybonjr, keybonnr)

    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        records =
            From faktl In db.FAKTLs
            Where faktl.FJAAR = keyfaktjr AndAlso faktl.FNR = keyfaktnr AndAlso faktl.DC = keyfaktdc
            Let Werf = faktl.BWSTRAAT & " " & faktl.BWADRES
            Select JR = faktl.FJAAR, NR = faktl.FNR, DC = faktl.DC,
                FaktL = faktl.FAKTL, faktl.DATUM,
                Werf,
                faktl.AANTAL, faktl.EENHP, faktl.BTW,
                faktl.AOMS, faktl.CODE, faktl.OMSCODE, faktl.GROEP

        If Me.ordDGREC = Nothing Then ordDGREC = "FaktL"
        records = records.OrderBy(ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        'Dim dginvisible = New String() {"JR", "NR", "VLNR", "CNRQ"}
        'For index = 0 To dginvisible.GetUpperBound(0)
        '    DGREC.Columns(dginvisible(index)).Visible = False
        'Next
        'set numbermode
        Dim dgnums = New String() {"AANTAL", "EENHP"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
        'set autosizemode
        Dim dgautos = New String() {"NR", "FaktL", "Werf", "Aantal", "Eenhp", "BTW", "AOMS", "CODE", "OMSCODE", "GROEP"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautod = New String() {"JR", "DC", "DATUM"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index

        DGREC.Columns("OMSCODE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DGREC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If DGREC.RowCount < 1 Then
            keybonlvnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs)
        keybonlvnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyfaktl = DGREC.CurrentRow.Cells("FaktL").Value
        FillInfoRow()

NoRecords:
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions

    Private Sub DeleteRec()
        If keyfaktl < 1 Then
            MsgBox("Geen faktuurlijn beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder faktuurlijn?", MsgBoxStyle.YesNoCancel, "Wil je deze faktuurlijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim deleterec = (From faktl In db.FAKTLs
                             Where faktl.FJAAR = keyfaktjr AndAlso faktl.FNR = keyfaktnr AndAlso faktl.DC = keyfaktdc AndAlso faktl.FAKTL = keyfaktl).ToList()(0)

            db.FAKTLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keyfaktjr & "/" & keyfaktnr.ToString("0000") & "-" & keyfaktdc & "_" & keyfaktl.ToString("0000")
            Archive("FAKTL_D", key, "ToDo")
            keybonlvnr = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    a.selectedindex = 0
                End If
            End If
        Next
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs)
        'MsgBox("Todo: Export")
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs)
        'MsgBox("Todo: Print")
    End Sub

    Private Sub GroepsbewerkingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'MsgBox("ToDo: Groepsbewerking op bonlijnen.")
    End Sub

    '****Filters
    Private Sub DGFILTER()
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        records = records.Where("groep.Contains(@0)", Fltgroep.Text)
        records = records.Where("Code.Contains(@0)", FltCode.Text)
        records = records.Where("Omscode.Contains(@0)", Fltomscode.Text)
    End Sub

    Private Sub Fltwerf_TextChanged_1(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltgroep_TextChanged(sender As Object, e As EventArgs) Handles Fltgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCode_TextChanged(sender As Object, e As EventArgs) Handles FltCode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltomscode_TextChanged(sender As Object, e As EventArgs) Handles Fltomscode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

End Class