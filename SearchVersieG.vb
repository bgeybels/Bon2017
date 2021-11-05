Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchVersieG
    Private ordDGREC As String = "VERSIEG"
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

        nofilter = False

        hkey = keyversiegnrq
        SetGrids()
        keypernrq = hkey
        Fill_DGREC()
        keyversiegnrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyversiegnrq = 0 Then keypernrq = 1
        hkey = keypernrq
        Fill_DGREC()
        keyversiegnrq = hkey
        SetRECrow()
        keyversiegnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("VERSIEGNRQ").Value = keyversiegnrq Then
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
        records = From versieg In db.VERSIEGs


        If Me.ordDGREC = Nothing Then ordDGREC = "VERSIEG"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"VERSIEGNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        'Dim dgautos = New String() {"Naam", "Telefoon", "GSMPrive", "GSMWerk", "Sortering", "InDienst", "Wie"}
        'For index = 0 To dgautos.GetUpperBound(0)
        'DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'Next index
        DGREC.Columns("VERSIEG").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyversiegnrq = DGREC.CurrentRow.Cells("VERSIEGNRQ").Value
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
        IsNewRecord = True
        EditVERSIEG.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyversiegnrq = DGREC.CurrentRow.Cells("VERSIEGNRQ").Value
        EditVERSIEG.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        MsgBox(keyversiegnrq)
        Try
            Dim deleterec = (From versieg In db.VERSIEGs
                             Where versieg.VERSIEGNRQ = keyversiegnrq).ToList()(0)

            db.VERSIEGs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            keyversiegnrq = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs)
        nofilter = True
        For Each a In GrBFilters.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                'If (Mid(a.name, 1, 5) = "FltCB") Then
                'a.selectedindex = 0
                'End If
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
        If MsgBox("Verwijder Versiegroep?", MsgBoxStyle.YesNoCancel, "Wil je deze versiegroep echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    '****Filters
    Private Sub DGFILTER()
        ' Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("VERSIEG.Contains(@0)", Fltversieg.Text)

        'Select Case FltCBdienst.SelectedItem
        'Case "Aan"
        'chval = "true"
        'Case "Uit"
        'chval = "false"
        'Case Else
        'chval = ""
        'End Select
        'If chval <> "" Then records = records.Where("InDienst == " & chval)
    End Sub

    Private Sub Fltversieg_TextChanged(sender As Object, e As EventArgs) Handles Fltversieg.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub DGREC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGREC.CellContentClick

    End Sub

    Private Sub DGREC_DoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        UpdateRec()
    End Sub
End Class