Imports System.Linq.Dynamic

Public Class SearchCode
    Private ordDGREC As String = "Code"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'zet bepaalde knoppen aan/uit
        TSBDeleteSelected.Enabled = False

        If frompopup = False Then
            TSBexit.Image = Bon2017.My.Resources.Resources.home
        Else
            TSBexit.Image = Bon2017.My.Resources.Resources.homered
        End If

        If LoginSysAdmin = True Then
            TSBDeleteSelected.Enabled = True
        End If

        If plook = True Then
            FormBorderStyle = FormBorderStyle.Sizable
            Me.Width = 1700
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(NieuwToolStripMenuItem)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        nofilter = True
        '    FillCMBcodgp(CMBcodgp)
        'For Each a In GrBFilters.Controls
        'If (TypeOf a Is ComboBox) Then
        'If (Mid(a.name, 1, 5) = "FltCB") Then
        'FillCMBeau(a)
        'a.selectedindex = 0
        'End If
        'End If
        'Next
        nofilter = False

        Fltcode.Text = filtercode
        Fltomsgroep.Text = ""
        Fltomscode.Text = ""
        'codfrombon = False
        nofilter = True
        If codfrombon = True Then
            If filtercode = "" Then
                Dim found As String = ""
                codgprecs = From codgp In db.CODGPs
                            Where codgp.CGNRQ = keycgnrq
                            Select codgp.CGNRQ, codgp.OmsGroep
                For Each codgprec In codgprecs
                    found = codgprec.OmsGroep
                Next
                Fltomsgroep.Text = found
                Fltomsgroep.SelectionStart = 0
                Fltomsgroep.SelectionLength = Fltomsgroep.Text.Length
            End If
        End If
        nofilter = False

        hkey = keycnrq
        SetGrids()
        keycnrq = hkey
        Fill_DGREC()
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
        TBresultCode.Text = GetvalcodeSearch(keycnrq)
    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
            From cod In db.CODs
            Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
            Join aoms In db.AOms On cod.ANRQ Equals aoms.ANRQ
            Let Wie = cod.usernrq & " (" & cod.ChDate & ")"
            Let Gebruikt = cod.USDate
            Let Eenheid = aoms.Oms
            Let KMHef = cod.KMHEFFING
            Select cod.CNRQ, cod.CGNRQ,
                cod.sort,
                Eenheid,
                KMHef,
                GeenStock = cod.notstock,
                Gratis = cod.gratis,
                Besteld = cod.Besteld,
                VP = cod.Eenhp, AP = cod.Aankp, STOCK = cod.Stock,
                codgp.OmsGroep,
                cod.Code, cod.OmsCode, cod.Plmagazijn,
                Wie, Gebruikt, cod.ANRQ, codgp.INRESULT

        If Me.ordDGREC = Nothing Then ordDGREC = "Code"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGCODFILTER()
        Me.DGREC.DataSource = records
        FillInfo()

        'set numbermode
        Dim dgnums = New String() {"AP", "VP"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'DGREC.Columns(dgnums(index)).SortMode = DataGridViewColumnSortMode.NotSortable
            'DGREC.Columns(dgnums(index)).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            'DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        'set invisible
        Dim dginvisible = New String() {"CNRQ", "CGNRQ", "ANRQ", "INRESULT"}
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
        Dim dgautoh = New String() {"Eenheid", "Sort", "Gebruikt", "Besteld", "KMHef", "Gratis", "GeenStock", "Plmagazijn"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        DGREC.Columns("OmsCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' If CBFltGrp.Checked = True Then
        '   SetUnusedCell()
        ' End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value

        FillInfo()
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs)
        UpdateRec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewCode = True
        EditCode.ShowDialog()
        IsNewCode = False
        Refresh_data()
        FillInfo()
    End Sub

    Private Sub UpdateRec()
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value

        ' test lock
        Dim lockedby = isLocked("CODE", keycnrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("CODE", keycnrq)

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

    Private Sub MoveRecMulti()
        transgrid = Me.DGREC
        'MoveCode.StartPosition = FormStartPosition.CenterParent
        'MoveCode.ShowDialog()

        '' CENTER
        'Dim vleft As Integer = CInt((Me.Left + (Me.Width - MoveCode.Width) / 2))
        'Dim vtop As Integer = CInt((Me.Top + (Me.Height - MoveCode.Height) / 2))
        'MsgBox("top: " & Me.Top & " bottom: " & Me.Bottom & " heigth: " & Me.Height & " left: " & Me.Left)
        'MsgBox("top: " & MoveCode.Top & " bottom: " & MoveCode.Bottom & " heigth: " & MoveCode.Height & " left: " & MoveCode.Left)
        Dim vleft As Integer = CInt(Me.Left + (Me.Width - MoveCode.Width))
        Dim vtop As Integer = CInt(Me.Top + 100)

        MoveCode.StartPosition = FormStartPosition.Manual
        MoveCode.Location = New Point(vleft, vtop)
        MoveCode.ShowDialog()

        Refresh_data()
    End Sub

    Private Sub DeleteRecMulti()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.SelectedRows
            keycnrq = row.Cells("CNRQ").Value
            checkrec = From bon In db.BONLs
                       Where bon.CNRQ = keycnrq
            If checkrec.Count > 0 Then
                Continue For
            End If

            Try
                Dim deleterec = (From cod In db.CODs
                                 Where cod.CNRQ = keycnrq).ToList()(0)

                db.CODs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
                Archive("CODE_D", Str(keycnrq), deleterec.Code & " - " & deleterec.OmsCode & " - " & deleterec.Aankp & "/" & deleterec.Perc & "/" & deleterec.Eenhp & deleterec.Stock)
                keycnrq = 0
            Catch
            End Try
        Next

        Refresh_data()
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
            If TypeOf a Is CheckBox Then
                a.checked = False
            End If
        Next
        CBFltGrp.Checked = True
        nofilter = False
        Fill_DGREC()
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

    Private Sub TSBDeleteSelected_Click(sender As Object, e As EventArgs) Handles TSBDeleteSelected.Click
        If MsgBox("Verwijder geselecteerde codes als ze niet meer gebruikt worden in een bon?", MsgBoxStyle.YesNoCancel, "Geselecteerde code verwijderen.") = MsgBoxResult.Yes Then
            DeleteRecMulti()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "COD")
        'ExportToExcel(DGREC, "COD")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBverplaats_Click(sender As Object, e As EventArgs) Handles TSBverplaats.Click
        'MsgBox("TODO: Verplaats de geselecteerde CODES")
        transgrp = 0
        MoveRecMulti()
    End Sub

    Private Sub TSBverplaatsX_Click(sender As Object, e As EventArgs) Handles TSBverplaatsX.Click
        transgrp = My.Settings.XCode
        MoveRecMulti()
        'codgprecs = From codgp In db.CODGPs
        '            Where codgp.CGNRQ = My.Settings.XCode
        '            Select codgp.OmsGroep, codgp.CGNRQ
        '            Take 1
        'Dim found As String
        'found = ""
        'For Each codgprec In codgprecs
        '    found = codgprec.omsgroep
        'Next
        'If found = "" Then Exit Sub

        'If MessageBox.Show("Geselecteerde codes verplaatsen naar " & found & "?", "Verplaats codes", MessageBoxButtons.YesNo) = DialogResult.No Then
        '    Exit Sub
        'End If
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'For Each row As DataGridViewRow In DGREC.SelectedRows
        '    keycnrq = row.Cells("CNRQ").Value
        '    Dim updaterec = (From code In db.CODs
        '                     Where code.CNRQ = keycnrq).ToList()(0)
        '    updaterec.CGNRQ = My.Settings.XCode

        '    Try
        '        db.SubmitChanges()
        '    Catch ex As Exception
        '        PositionMsgbox.CenterMsgBox(Me)
        '        MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        '    End Try
        'Next
        'Refresh_data()

        'Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '****Filters
    Private Sub DGCODFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        '' If CBFltGrp.Checked = True Then records = records.Where("CGNRQ.Equals(@0)", keycgnrq)
        records = records.Where("OmsGroep.Contains(@0)", Fltomsgroep.Text)
        records = records.Where("Code.Contains(@0)", Fltcode.Text)
        records = records.Where("OmsCode.Contains(@0)", Fltomscode.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)

        chval = ""
        If (CBstockknulJ.Checked = True) And (CBstockknulN.Checked = False) Then chval = "<"
        If (CBstockknulN.Checked = True) And (CBstockknulJ.Checked = False) Then chval = ">"
        If chval <> "" Then records = records.Where("STOCK " & chval & " 0")

        chval = ""
        If (CBstockisnulJ.Checked = True) And (CBstockisnulN.Checked = False) Then chval = "="
        If (CBstockisnulN.Checked = True) And (CBstockisnulJ.Checked = False) Then chval = "<>"
        If chval <> "" Then records = records.Where("STOCK " & chval & " 0")

        chval = ""
        If (CBnotstockJ.Checked = True) And (CBnotstockN.Checked = False) Then chval = "true"
        If (CBnotstockN.Checked = True) And (CBnotstockJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("Geenstock == " & chval)

        chval = ""
        If (CBgratisJ.Checked = True) And (CBgratisN.Checked = False) Then chval = "true"
        If (CBgratisN.Checked = True) And (CBgratisJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("gratis == " & chval)

        chval = ""
        If (CBkmheffingJ.Checked = True) And (CBkmheffingN.Checked = False) Then chval = "true"
        If (CBkmheffingN.Checked = True) And (CBkmheffingJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("KMHef == " & chval)

        chval = ""
        If (CBbesteldJ.Checked = True) And (CBbesteldN.Checked = False) Then chval = "true"
        If (CBbesteldN.Checked = True) And (CBbesteldJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("besteld == " & chval)
        records = records.Where("inresult == " & CBFltinresult.Checked)
    End Sub
    Public Sub Fltcode_TextChanged(sender As Object, e As EventArgs) Handles Fltcode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltomscode_TextChanged(sender As Object, e As EventArgs) Handles Fltomscode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltomsgroep_TextChanged(sender As Object, e As EventArgs) Handles Fltomsgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
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

    Private Sub CBFltinresult_CheckedChanged(sender As Object, e As EventArgs) Handles CBFltinresult.CheckedChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

    Private Sub DGREC_DoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        TSBedit.PerformClick()
    End Sub

    Private Sub FltCBkmheffing_SelectedIndexChanged(sender As Object, e As EventArgs)
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

    Private Sub CBnotstockJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBnotstockJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBnotstockN_CheckedChanged(sender As Object, e As EventArgs) Handles CBnotstockN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBstockknulJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBstockknulJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBstockknulN_CheckedChanged(sender As Object, e As EventArgs) Handles CBstockknulN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBstockisnulJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBstockisnulJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBstockisnulN_CheckedChanged(sender As Object, e As EventArgs) Handles CBstockisnulN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBbesteldJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBbesteldJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBbesteldN_CheckedChanged(sender As Object, e As EventArgs) Handles CBbesteldN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBgratisJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBgratisJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBgratisN_CheckedChanged(sender As Object, e As EventArgs) Handles CBgratisN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBkmheffingJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBkmheffingJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBkmheffingN_CheckedChanged(sender As Object, e As EventArgs) Handles CBkmheffingN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class