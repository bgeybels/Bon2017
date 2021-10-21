Imports System.Linq.Dynamic

Public Class SearchCode
    Private ordDGREC As String = "Code"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(NieuwToolStripMenuItem)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        nofilter = True
        fillCMBcodgp(CMBcodgp)
        For Each a In GrBFilters.Controls
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    fillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        'CMBcodgp.SelectedIndex = SelCGNRQ
        If SelCGNRQ <> 0 Then
            CMBcodgp.SelectedValue = SelCGNRQ
            keycgnrq = CMBcodgp.SelectedValue
        Else
            CMBcodgp.SelectedIndex = 0
        End If
        If keycgnrq = 0 Then keycgnrq = CMBcodgp.SelectedValue

        nofilter = False

        hkey = keycnrq
        SetGrids()
        keycnrq = hkey
        fill_DGREC()
        keycnrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keycnrq = 0 Then keycnrq = 1
        hkey = keycnrq
        Fill_DGREC()
        keycnrq = hkey
        SetRECrow()
        keycnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("CNRQ").Value = keycnrq Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(3)
            End If
        Next
    End Sub

    Private Sub SetUnusedCell()
        Dim keys As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i As Integer = 0 To DGREC.Rows.Count - 1
            '            DGREC.Rows(row).Cells(1).style.backcolor = dgcelcolor
            keys = DGREC.Rows(i).Cells("CNRQ").Value
            checkrec = From bon In db.BONLs Where bon.CNRQ = keys

            If checkrec.Count < 1 Then
                DGREC.Rows(i).Cells("Code").Style.BackColor = dgcelcolor
            End If


        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FillInfo()

        'TBResultBONL
        TBresultCode.Text = GetvalcodeSearch(keycnrq)

    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
            From cod In db.CODs
            Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
            Let Wie = cod.usernrq & " (" & cod.ChDate & ")"
            Let Gebruikt = cod.USDate
            Select cod.CNRQ, cod.CGNRQ,
                cod.sort,
                GeenStock = cod.notstock,
                Gratis = cod.gratis,
                Besteld = cod.Besteld,
                VP = cod.Eenhp, AP = cod.Aankp, STOCK = cod.Stock,
                codgp.OmsGroep,
                cod.Code, cod.OmsCode, cod.Plmagazijn,
                Wie, Gebruikt, cod.ANRQ

        If Me.ordDGREC = Nothing Then ordDGREC = "Code"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGCODFILTER()
        Me.DGREC.DataSource = records
        FillInfo()

        'set invisible
        Dim dginvisible = New String() {"CNRQ", "CGNRQ", "ANRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        DGREC.Columns("Gebruikt").HeaderText = "LaatstGebruikt"
        DGREC.Columns("Plmagazijn").HeaderText = "PlaatsMagazijn"
        'set autosizemode
        Dim dgautos = New String() {"Code", "OmsGroep"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautosd = New String() {"AP", "VP", "STOCK", "Wie"}
        For index = 0 To dgautosd.GetUpperBound(0)
            DGREC.Columns(dgautosd(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautoh = New String() {"Sort", "Gebruikt", "Besteld", "Gratis", "GeenStock", "Plmagazijn"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        DGREC.Columns("OmsCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        If CBFltGrp.Checked = True Then
            SetUnusedCell()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value

        FillInfo()
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        UpdateRec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGREC.ColumnHeaderMouseClick
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        EditCode.ShowDialog()
        IsNewRecord = False
        Refresh_data()
        FillInfo()
    End Sub

    Private Sub UpdateRec()
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
        EditCode.ShowDialog()
        Refresh_data()
        FillInfo()
    End Sub

    Private Sub DeleteRec()
        If keycnrq < 1 Then
            MsgBox("Geen code beschikbaar om te verwijderen.")
            Exit Sub
        End If
        checkrec = From bon In db.BONLs
                   Where bon.CNRQ = keycnrq
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Code " & DGREC.CurrentRow.Cells("Code").Value & " (" & DGREC.CurrentRow.Cells("OmsCode").Value & ") nog gebruikt in bonnen!")
            Exit Sub
        End If

        Try
            Dim deleterec = (From cod In db.CODs
                             Where cod.CNRQ = keycnrq).ToList()(0)

            db.CODs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("CODE_D", Str(keycnrq), deleterec.Code & " - " & deleterec.OmsCode & " - " & deleterec.Aankp & "/" & deleterec.Perc & "/" & deleterec.Eenhp & deleterec.Stock)
            keycnrq = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GrBFilters.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    a.selectedindex = 0
                End If
            End If
        Next
        CBFltGrp.Checked = True
        nofilter = False
        fill_DGREC()
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuwToolStripMenuItem.Click
        TSBnew.PerformClick()
    End Sub
    Private Sub TSBnew_Click(sender As Object, e As EventArgs) Handles TSBnew.Click
        Addrec()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub BewerkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkToolStripMenuItem.Click
        TSBedit.PerformClick()
    End Sub

    Private Sub TSBedit_Click(sender As Object, e As EventArgs) Handles TSBedit.Click
        UpdateRec()
    End Sub

    Private Sub VerwijderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderToolStripMenuItem.Click
        TSBdelete.PerformClick()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        If MsgBox("Verwijder code?", MsgBoxStyle.YesNoCancel, "Wil je deze code echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        MsgBox("Exporteer naar excel")
    End Sub

    Private Sub TSBverplaats_Click(sender As Object, e As EventArgs) Handles TSBverplaats.Click
        MsgBox("TODO: Verplaats de geselecteerde CODES")
    End Sub

    Private Sub TSBcopieer_Click(sender As Object, e As EventArgs) Handles TSBcopieer.Click
        MsgBox("TODO: Copieer de geselecteerde CODES")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' 'FilterKlant.ShowDialog()
        ' Dim f As New FilterKlant
        ' Try
        ' f.Owner = Me
        ' f.ShowDialog()
        ' Finally
        ' f.Dispose()
        ' End Try
    End Sub


    '****Filters
    Private Sub DGCODFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        If CBFltGrp.Checked = True Then records = records.Where("CGNRQ.Equals(@0)", keycgnrq)
        records = records.Where("OmsGroep.Contains(@0)", Fltomsgroep.Text)
        records = records.Where("Code.Contains(@0)", Fltcode.Text)
        records = records.Where("OmsCode.Contains(@0)", Fltomscode.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)

        Select Case FltCBnotstock.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("geenstock == " & chval)
        Select Case FltCBgratis.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("gratis == " & chval)
        Select Case FltCBbesteld.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("besteld == " & chval)
    End Sub
    Public Sub Fltcode_TextChanged(sender As Object, e As EventArgs) Handles Fltcode.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltomscode_TextChanged(sender As Object, e As EventArgs) Handles Fltomscode.TextChanged, Fltomscode.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltomsgroep_TextChanged(sender As Object, e As EventArgs) Handles Fltomsgroep.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub CBFltGrp_CheckedChanged(sender As Object, e As EventArgs) Handles CBFltGrp.CheckedChanged
        If nofilter = False Then
            Fill_DGREC()
        End If
    End Sub
    Private Sub CMBcodgp_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMBcodgp.SelectedValueChanged
        On Error GoTo Troubles
        If nofilter = False Then
            keycgnrq = CMBcodgp.SelectedValue
            'MsgBox("value: " & CMBcodgp.SelectedValue)
            'MsgBox("index: " & CMBcodgp.SelectedIndex)
            'MsgBox("text :" & CMBcodgp.SelectedText)
            'MsgBox("item: " & CMBcodgp.SelectedItem)
            Fill_DGREC()
        End If
Troubles:
    End Sub
    Private Sub FltCBbesteld_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBbesteld.SelectedIndexChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub
    Private Sub FltCBnotstock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBnotstock.SelectedIndexChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

    Private Sub FltCBgratis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBgratis.SelectedIndexChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

End Class