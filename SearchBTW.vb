Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchBTW
    Private ordDGREC As String = "BTW"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchBTW_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
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

        nofilter = False
        hkey = keybtwnrq
        SetGrids()
        Fill_DGREC()
        keybtwnrq = hkey
        SetRECrow()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keybtwnrq = 0 Then keybtwnrq = 1
        hkey = keybtwnrq
        Fill_DGREC()
        keybtwnrq = hkey
        SetRECrow()
        keybtwnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("BNRQ").Value = keybtwnrq Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(1)
            End If
        Next
    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
        From btw In db.BTWs
        Let Wie = btw.usernrq & " (" & btw.chdate & ")"
        Select btw.BNRQ, NieuweBon = btw.nieuwbon, btw.BTW, btw.OmsBTW,
            btw.chdate, btw.usernrq,
            Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "OmsBTW"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible As Object = New String() {"BNRQ", "usernrq", "chdate"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos As Object = New String() {"BTW", "OmsBTW", "NieuweBon", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("BNRQ").AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DGREC.Columns("OmsBTW").AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As System.EventArgs)
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keybtwnrq = DGREC.CurrentRow.Cells("BNRQ").Value
NoRecords:
    End Sub

    Private Sub DGREC_DoubleClick(sender As Object, e As System.EventArgs)
        UpdateRec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        EditBTW.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keybtwnrq = DGREC.CurrentRow.Cells("BNRQ").Value
        EditBTW.ShowDialog()

        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From bonl In db.BONLs
                       Where bonl.BNRQ = keybtwnrq
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("BTW " & DGREC.CurrentRow.Cells("OmsBTW").Value & " nog gebruikt in bonnen!")
            Exit Sub
        End If

        Try
            Dim deleterec = (From btw In db.BTWs
                             Where btw.BNRQ = keybtwnrq).ToList()(0)
            db.BTWs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("BTW_D", Str(keybtwnrq), deleterec.BTW & " - " & deleterec.OmsBTW)
            keybtwnrq = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As System.EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
        Next
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles NieuwToolStripMenuItem.Click
        TSBnew.PerformClick()
    End Sub

    Private Sub TSBnew_Click(sender As Object, e As System.EventArgs) Handles TSBnew.Click
        Addrec()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As System.EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub BewerkToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles BewerkToolStripMenuItem.Click
        TSBedit.PerformClick()
    End Sub


    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDoubleClick
        TSBedit.PerformClick()
    End Sub

    Private Sub TSBedit_Click(sender As Object, e As System.EventArgs) Handles TSBedit.Click
        UpdateRec()
    End Sub

    Private Sub VerwijderToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles VerwijderToolStripMenuItem.Click
        TSBdelete.PerformClick()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As System.EventArgs) Handles TSBdelete.Click

        If MsgBox("Verwijder btw?", MsgBoxStyle.YesNoCancel, "Wil je dit BTW-record echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As System.EventArgs) Handles TSBexport.Click
        MsgBox("Exporteer naar CSV")
    End Sub

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("OmsBTW.Contains(@0)", Fltomsbtw.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub

    Private Sub Fltomsbtw_TextChanged(sender As Object, e As System.EventArgs) Handles Fltomsbtw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As System.EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

End Class