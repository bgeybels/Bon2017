Imports System.Linq.Dynamic
Imports System.Linq
Public Class SearchPersStock
    Private ordDGRECP As String = "Naam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchPersStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Sizable

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(NieuwToolStripMenuItem)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        nofilter = True
        nofilter = False

        hkey = keypernrq
        SetGrids()
        keypernrq = hkey
        Fill_DGREC()
        keypernrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGRECP)
        SetGridRows(DGRECC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keypernrq = 0 Then keypernrq = 1
        hkey = keypernrq
        Fill_DGREC()
        keypernrq = hkey
        SetRECrow()
        keypernrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGRECP.Rows.Count - 1
            If DGRECP.Rows(lp).Cells("PERNRQ").Value = keypernrq Then
                DGRECP.ClearSelection()
                DGRECP.Rows(lp).Selected = True
                DGRECP.FirstDisplayedScrollingRowIndex = lp

                DGRECP.CurrentCell = DGRECP.Rows(lp).Cells(1)
            End If
        Next
    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
            From per In db.PERs
            Select per.PERNRQ,
                InDienst = per.DIENST,
                Sortering = per.PERSORT,
                Naam = per.PERNM

        If Me.ordDGRECP = Nothing Then ordDGRECP = "Naam"
        records = records.OrderBy(Me.ordDGRECP, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGRECP.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"PERNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGRECP.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Naam", "InDienst", "Sortering"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGRECP.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGRECP.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGRECP_SelectionChanged(sender As Object, e As EventArgs)
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypernrq = DGRECP.CurrentRow.Cells("PERNRQ").Value
NoRecords:
    End Sub

    Private Sub DGRECP_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            DGRECP.CurrentCell = DGRECP(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub


    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Naam.Contains(@0)", Fltpernm.Text)

        chval = ""
        If (CBdienstJ.Checked = True) And (CBdienstN.Checked = False) Then chval = "true"
        If (CBdienstN.Checked = True) And (CBdienstJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("InDienst == " & chval)
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltpernm_TextChanged(sender As Object, e As EventArgs) Handles Fltpernm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBdienstJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBdienstN_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class