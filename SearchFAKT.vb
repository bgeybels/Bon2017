Imports System.Linq.Dynamic
Imports System.ComponentModel

Public Class searchfakt
    Private ordDGREC As String = "NR"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchFAKT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        'e.Cancel = True
    End Sub

    Private Sub SearchFAKT_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'My.Settings.fltbonjr = Fltbonjr.Value
        'My.Settings.fltbontbw = FltCBtbw.SelectedIndex
    End Sub

    Private Sub SearchFAKT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        ' get values from settings
        Fltbonjr.Value = My.Settings.fltbonjr
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw

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
        If keyfaktjr = 0 Then keyfaktjr = My.Settings.fltbonjr
        hkey = keyfaktjr
        hkey2 = keyfaktnr
        hkey3 = keyfaktdc
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        keyfaktdc = hkey3
        SetRECrow()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkey3
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("JR").Value = keyfaktjr And DGREC.Rows(lp).Cells("NR").Value = keyfaktnr And DGREC.Rows(lp).Cells("DC").Value = keyfaktdc Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(1)
            End If
        Next
    End Sub

    Private Sub FillInfo()
        '  'TBResultFAKT
        ' TBResultBON.Text = ""
        'TBResultBON.Text = TBResultBON.Text & " Bon: " & keybonjr & "/" & keybonnr.ToString("0000") & "  (Totaal aantal bonnen: " & DGREC.RowCount & ")"
        'TBResultBON.Text = TBResultBON.Text & Environment.NewLine & GetKlantNaam(keyknrq)
        'Next

        'TBResultFAKTL
        'TBResultBONL.Text = GetBonlFigures(keybonjr, keybonnr)

    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If CBfilteryear.Checked = True Then
            records =
                    From fakt In db.FAKTs
                    Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                    Where fakt.JAAR = Fltbonjr.Value
                    Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                    Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
                        fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
                        Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
                        fakt.KNaam, fakt.Werf,
                        EIGENAAR = eigenaar.ENaam, Wie
        Else
            records =
                From fakt In db.FAKTs
                Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
                        fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
                        Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
                        fakt.KNaam, fakt.Werf,
                        EIGENAAR = eigenaar.ENaam, Wie
        End If

        If Me.ordDGREC = Nothing Then ordDGREC = "NR"
        records = records.OrderBy(ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records
        FillInfo()

        'set invisible
        'Dim dginvisible = New String() {"KNRQ", "fok", "cok", "printed"}
        'For index = 0 To dginvisible.GetUpperBound(0)
        'DGREC.Columns(dginvisible(index)).Visible = False
        'Next
        'set autosizemode
        Dim dgautos = New String() {"FNR", "WJR", "Datin", "Start", "Einde", "Inclusief", "Exclusief", "BTW", "NACalc", "KNaam", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautod = New String() {"JR", "NR", "DC", "Type", "EIGENAAR"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        DGREC.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DGREC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If DGREC.RowCount < 1 Then
            keyfaktjr = Fltbonjr.Value
            keyfaktnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keyfaktjr = Fltbonjr.Value
        keyfaktnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        'If CBfilteryear.Checked = False Then keybonjr = DGREC.CurrentRow.Cells("JR").Value
        keyfaktjr = DGREC.CurrentRow.Cells("JR").Value
        keyfaktnr = DGREC.CurrentRow.Cells("NR").Value
        keyfaktdc = DGREC.CurrentRow.Cells("DC").Value

        FillInfo()

NoRecords:
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub DeleteRec()
        If keyfaktnr < 1 Then
            MsgBox("Geen faktuur beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder faktuur?", MsgBoxStyle.YesNoCancel, "Wil je deze faktuur echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim checkrec = From faktl In db.FAKTLs
                       Where faktl.FJAAR = keyfaktjr AndAlso faktl.FNR = keyfaktnr AndAlso faktl.DC = keyfaktdc
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Faktuur " & keyfaktjr & "/" & keyfaktnr & " bevat nog faktuurlijnen!")
            Exit Sub
        End If

        Try
            Dim deleterec = (From fakt In db.FAKTs
                             Where fakt.JAAR = keyfaktjr AndAlso fakt.NR = keyfaktnr AndAlso fakt.DC = keyfaktdc).ToList()(0)

            db.FAKTs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keyfaktjr & "/" & keyfaktnr.ToString("0000") & "-" & keyfaktdc
            Archive("FAKT_D", key, deleterec.KNaam)
            keyfaktjr = Fltbonjr.Value
            keyfaktnr = 0
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

    Private Sub VerwijderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderToolStripMenuItem.Click
        TSBdelete.PerformClick()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        DeleteRec()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        MsgBox("Todo: Export")
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs) Handles TSBprint.Click
        MsgBox("Todo: Print")
    End Sub


    '****Filters
    Private Sub DGFILTER()

        If Fltnr.Text <> "" Then
            records = records.Where("NR == " & Fltnr.Text)
            Exit Sub
        End If

        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("KNaam.Contains(@0)", Fltknaam.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        If CBfilterwyear.Checked = True Then
            records = records.Where("WJR.equals(@0)", Convert.ToInt32(FltWJR.Value))
        End If

        '  Select Case FltCBdel.SelectedItem
        '  Case "Aan"
        '  chval = "true"
        '  Case "Uit"
        '  chval = "false"
        '  Case Else
        '  chval = ""
        '  End Select
        '  If chval <> "" Then records = records.Where("del == " & chval)

        ' Select Case FltCBcnr.SelectedItem
        ' Case "Aan"
        ' records = records.Where("cnr <> 0")
        ' Case "Uit"
        ' records = records.Where("cnr == 0")
        ' Case Else
        ' End Select
    End Sub

    Private Sub CBfilteryear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub CBfilterwyear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilterwyear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        keybonjr = Fltbonjr.Value
        keybonnr = 0
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltwjr_ValueChanged(sender As Object, e As EventArgs) Handles FltWJR.ValueChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltknaam_TextChanged(sender As Object, e As EventArgs) Handles Fltknaam.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltwerf_TextChanged(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnr_TextChanged(sender As Object, e As EventArgs) Handles Fltnr.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub ToonFaktuurlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToonFaktuurlijnenToolStripMenuItem.Click
        plook = False
        SearchFAKTL.MdiParent = MDIbon
        SearchFAKTL.WindowState = FormWindowState.Maximized
        SearchFAKTL.Show()
    End Sub

    Private Sub DGREC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGREC.CellContentClick

    End Sub

End Class