Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchDies
    Private ordDGREC As String = "Omschrijving"
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
        'For Each a In GrBFilters.Controls
        'If (TypeOf a Is ComboBox) Then
        'If (Mid(a.name, 1, 5) = "FltCB") Then
        'FillCMBeau(a)
        'a.selectedindex = 0
        'End If
        'End If
        'Next
        nofilter = False

        hkey = keydiesnrq
        SetGrids()
        keydiesnrq = hkey
        Fill_DGREC()
        keydiesnrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keydiesnrq = 0 Then keydiesnrq = 1
        hkey = keydiesnrq
        Fill_DGREC()
        keydiesnrq = hkey
        SetRECrow()
        keydiesnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("DNRQ").Value = keydiesnrq Then
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
            From dies In db.DIES
            Let Wie = dies.usernrq & " (" & dies.chdate & ")"
            Select dies.DNRQ,
                Actief = dies.actief, Percentage = dies.DIES, Omschrijving = dies.OmsDIES,
                Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "Omschrijving"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"DNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Percentage", "Omschrijving", "Actief", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Omschrijving").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keydiesnrq = DGREC.CurrentRow.Cells("DNRQ").Value
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
        EditDIES.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keydiesnrq = DGREC.CurrentRow.Cells("DNRQ").Value

        ' test lock
        Dim lockedby = isLocked("DIES", keydiesnrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("DIES", keydiesnrq)

        EditDIES.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Try
            Dim deleterec = (From dies In db.DIES
                             Where dies.DNRQ = keydiesnrq).ToList()(0)

            db.DIES.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("DIES_D", Str(keydiesnrq), deleterec.DIES & " - " & deleterec.OmsDIES)
            keypernrq = 0
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
            If TypeOf a Is CheckBox Then
                a.checked = False
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
        If MsgBox("Verwijder Diesel%?", MsgBoxStyle.YesNoCancel, "Wil je dit dieselpercentage echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "DIESEL")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Omschrijving.Contains(@0)", Fltomsdies.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)

        chval = ""
        If (CBactiefJ.Checked = True) And (CBactiefN.Checked = False) Then chval = "true"
        If (CBactiefN.Checked = True) And (CBactiefJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("actief == " & chval)
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltomsdies_TextChanged(sender As Object, e As EventArgs) Handles Fltomsdies.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBactiefJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBactiefJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBactiefN_CheckedChanged(sender As Object, e As EventArgs) Handles CBactiefN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class