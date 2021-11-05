Imports System.Linq.Dynamic
Imports System.Linq
Public Class SearchAFT
    Private ordDGREC As String = "Verwoording"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchAft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        hkey = keyaftid
        SetGrids()
        keyaftid = hkey
        Fill_DGREC()
        keyaftid = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyaftid = 0 Then keyaftid = 1
        hkey = keyaftid
        Fill_DGREC()
        keyaftid = hkey
        SetRECrow()
        keyaftid = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("AFTID").Value = keyaftid Then
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
            From aft In db.AFTs
            Let Wie = aft.USERNRQ & " (" & aft.CHDATE & ")"
            Let Verwoording = aft.AFTVERW
            Select aft.AFTID,
                Verwoording,
                Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "Verwoording"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"AFTID"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Verwoording", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Verwoording").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keycnrq = DGREC.CurrentRow.Cells("AFTID").Value
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
        Editaft.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyaftid = DGREC.CurrentRow.Cells("AFTID").Value

        ' test lock
        Dim lockedby = isLocked("AFT", keyaftid)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("AFT", keyaftid)

        EditAft.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From af In db.AFs
                       Where af.AFT = keyaftid
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Code " & keyaftid & " nog gebruikt in af-te-handelen!")
            Exit Sub
        End If

        Try
            Dim deleterec = (From aft In db.AFTs
                             Where aft.AFTID = keyaftid).ToList()(0)

            db.AFTs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("AFT_D", Str(keyaftid), deleterec.AFTVERW)
            keyaftid = 0
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
        If MsgBox("Verwijder record?", MsgBoxStyle.YesNoCancel, "Wil je dit record echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Verwoording.Contains(@0)", Fltverw.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub

    Private Sub Fltomsgroep_TextChanged(sender As Object, e As EventArgs) Handles Fltverw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class