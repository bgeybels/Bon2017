Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchStock
    Private ordDGREC As String = "Code"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        stocklogon = False
    End Sub

    Private Sub SearchCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        TSButtonPermissions(TSBnew)

        nofilter = True
        FillCMBcodgp(CMBcodgp)
        For Each a In GrBFilters.Controls
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        CMBcodgp.SelectedIndex = 0
        keycgnrq = CMBcodgp.SelectedValue
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

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If stocklogon = True Then
            CBFltGrp.Checked = False
            CBminstockJ.Checked = True
            CBminstockN.Checked = False
        End If

        records =
            From cod In db.CODs
            Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
            Join aoms In db.AOms On cod.ANRQ Equals aoms.ANRQ
            Where codgp.INRESULT = True
            Let laatste_update = cod.lupdate
            Let volume = aoms.Oms
            Select cod.CNRQ,
                cod.CGNRQ,
                cod.Besteld, cod.notstock,
                cod.Aankp, cod.Eenhp, cod.Stock, cod.OStock, cod.Minstock, cod.Maxstock,
                volume,
                cod.Plmagazijn,
                cod.LEV,
                codgp.OmsGroep, cod.Code, cod.OmsCode, laatste_update

        If Me.ordDGREC = Nothing Then ordDGREC = "Code"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGCODFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"CNRQ", "CGNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Besteld", "notstock", "Aankp", "Eenhp", "Stock", "OStock", "Minstock", "Maxstock", "Volume", "Plmagazijn", "LEV", "Code", "OmsCode", "OmsGroep"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        DGREC.Columns("laatste_update").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        Addrec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGREC.ColumnHeaderMouseClick
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        EditStock.ShowDialog()
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

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "STOCK")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '****Filters
    Private Sub DGCODFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        If CBFltGrp.Checked = True Then records = records.Where("CGNRQ.Equals(@0)", keycgnrq)
        records = records.Where("OmsGroep.Contains(@0)", Fltomsgroep.Text)
        records = records.Where("Code.Contains(@0)", Fltcode.Text)
        records = records.Where("OmsCode.Contains(@0)", Fltomscode.Text)
        records = records.Where("laatste_update.Contains(@0)", Fltusernrq.Text)
        records = records.Where("plmagazijn.Contains(@0)", Fltplmagazijn.Text)
        records = records.Where("lev.Contains(@0)", Fltlev.Text)

        chval = ""
        If (CBnotstockJ.Checked = True) And (CBnotstockN.Checked = False) Then chval = "true"
        If (CBnotstockN.Checked = True) And (CBnotstockJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("notstock == " & chval)
        chval = ""
        If (CBbesteldJ.Checked = True) And (CBbesteldN.Checked = False) Then chval = "true"
        If (CBbesteldN.Checked = True) And (CBbesteldJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("besteld == " & chval)

        chval = ""
        If (CBminstockJ.Checked = True) And (CBminstockN.Checked = False) Then chval = "<"
        If (CBminstockN.Checked = True) And (CBminstockJ.Checked = False) Then chval = ">"
        If chval <> "" Then records = records.Where("Stock" & chval & " Minstock")
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
            Fill_DGREC()
        End If
Troubles:
    End Sub

    Private Sub Fltlev_TextChanged(sender As Object, e As EventArgs) Handles Fltlev.TextChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

    Private Sub Fltplmagazijn_TextChanged(sender As Object, e As EventArgs) Handles Fltplmagazijn.TextChanged
        If nofilter = True Then Exit Sub
        Fill_DGREC()
    End Sub

    Private Sub BewerkCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkCodeToolStripMenuItem.Click

        ' test lock
        Dim lockedby = isLocked("CODE", keycnrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("CODE", keycnrq)

        EditCode.ShowDialog()
        nofilter = True
        Refresh_data()
        nofilter = False
    End Sub

    Private Sub CBminstockJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBminstockJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBminstockN_CheckedChanged(sender As Object, e As EventArgs) Handles CBminstockN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBbesteldJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBbesteldJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBbesteldN_CheckedChanged(sender As Object, e As EventArgs) Handles CBbesteldN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBnotstockJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBnotstockJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBnotstockN_CheckedChanged(sender As Object, e As EventArgs) Handles CBnotstockN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class