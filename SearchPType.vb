Imports System.Linq.Dynamic
Imports System.Linq
Public Class SearchPType
    Private ordDGREC As String = "Type"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchPType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        hkey = keyptid
        SetGrids()
        keyptid = hkey
        Fill_DGREC()
        keyptid = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyptid = 0 Then keyptid = 1
        hkey = keyptid
        Fill_DGREC()
        keyptid = hkey
        SetRECrow()
        keyptid = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("PTID").Value = keyptid Then
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
            From ptype In db.PTYPEs
            Let Wie = ptype.USERNRQ & " (" & ptype.CHDATE & ")"
            Let Totaliseer = ptype.PTTOT
            Let Type = ptype.PTVERW
            Select ptype.PTID, Totaliseer, Type, Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "Type"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"PTID"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Type", "Totaliseer"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Type").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGREC.Columns("PTID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keycnrq = DGREC.CurrentRow.Cells("PTID").Value
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
        End If
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
        EditPType.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyptid = DGREC.CurrentRow.Cells("PTID").Value

        ' test lock
        Dim lockedby = isLocked("PTYPE", keyptid)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("PTYPE", keyptid)

        EditPType.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From prest In db.PRESTs
                       Where prest.PRPTID = keyptid
        Dim deleterec = (From ptype In db.PTYPEs
                         Where ptype.PTID = keyptid).ToList()(0)
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Prestatietype " & deleterec.PTVERW & " nog gebruikt in prestaties!")
            Exit Sub
        End If

        Try
            db.PTYPEs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("TYPE_D", Str(keyptid), deleterec.PTVERW)
            keyptid = 0
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
        Next
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
        If MsgBox("Verwijder groepscode?", MsgBoxStyle.YesNoCancel, "Wil je deze groepscode echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Type.Contains(@0)", Flttype.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub

    Private Sub Flttype_TextChanged(sender As Object, e As EventArgs) Handles Flttype.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class