Imports System.Linq.Dynamic

Public Class Searchusers
    Private ordDGREC As String = "Naam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub Searchusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        For Each a In GrBFilters.Controls
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next
        nofilter = False

        hkey = keyloginnrq
        SetGrids()
        keyloginnrq = hkey
        Fill_DGREC()
        keyloginnrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyloginnrq = 0 Then keyloginnrq = 1
        hkey = keyloginnrq
        Fill_DGREC()
        keyloginnrq = hkey
        SetRECrow()
        keyloginnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("UNRQ").Value = keyloginnrq Then
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
            From users In db.USERS
            Let Systeemgebruiker = users.USYSUSER
            Let Stockgebruiker = users.USTOCKUSER
            Let StockPersgebruiker = users.UPERSUSER
            Let FactNrOphalen = users.GETFAKTNR
            Let Update = users.UUPD
            Let Delete = users.UDEL
            Let Nieuw = users.UNEW
            Let Totalen = users.TOTALS
            Let TotalenSys = users.TOTALSSYS
            Let Naam = users.UNAAM
            Let Paswoord = users.UPWD
            Select users.UNRQ,
                Naam, Paswoord,
                Systeemgebruiker, Stockgebruiker, StockPersgebruiker, FactNrOphalen, Update, Delete, Nieuw, Totalen, TotalenSys, users.UCURLOGON

        If Me.ordDGREC = Nothing Then ordDGREC = "Naam"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"UNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"FactNrOphalen", "Update", "Delete", "Nieuw", "Systeemgebruiker", "Stockgebruiker", "StockPersgebruiker", "Totalen", "TotalenSys", "Naam", "Paswoord", "UCURLOGON"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGREC.Columns("UNRQ").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyloginnrq = DGREC.CurrentRow.Cells("UNRQ").Value
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
        EditUser.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyloginnrq = DGREC.CurrentRow.Cells("UNRQ").Value
        EditUser.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Try
            Dim deleterec = (From users In db.USERS
                             Where users.UNRQ = keyloginnrq).ToList()(0)

            db.USERS.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("USERS_D", Str(keyloginnrq), deleterec.UNAAM)
            keyloginnrq = 0
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
        If MsgBox("Verwijder gebruiker?", MsgBoxStyle.YesNoCancel, "Wil je deze gebruiker echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "GEBRUIKERS")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Naam.Contains(@0)", Fltnaam.Text)

        Select Case FltCBupd.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("Update == " & chval)
        Select Case FltCBnew.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("Niuew == " & chval)
        Select Case FltCBdel.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("Delete == " & chval)
        Select Case FltCBtotals.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("TOTALS == " & chval)
    End Sub

    Private Sub Fltnaam_TextChanged(sender As Object, e As EventArgs) Handles Fltnaam.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub FltCBupd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBupd.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub FltCBnew_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBnew.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub FltCBdel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBdel.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBtotals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBtotals.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class