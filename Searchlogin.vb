Imports System.Linq.Dynamic
Imports System.Linq

Public Class Searchlogin
    Private ordDGREC As String = "naam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If DGREC.Rows(lp).Cells("nrq").Value = keyloginnrq Then
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
            From login In db.Logins
            Let Systeemgebruiker = login.CurrentLogon
            Select login.nrq,
                Systeemgebruiker, login.upd, login.del, login.[new],
                login.naam,
                login.pwd

        If Me.ordDGREC = Nothing Then ordDGREC = "naam"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"nrq"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"upd", "del", "Systeemgebruiker", "new", "naam", "pwd"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGREC.Columns("nrq").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyloginnrq = DGREC.CurrentRow.Cells("nrq").Value
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
        Editlogin.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyloginnrq = DGREC.CurrentRow.Cells("nrq").Value
        Editlogin.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Try
            Dim deleterec = (From login In db.Logins
                             Where login.nrq = keyloginnrq).ToList()(0)

            db.Logins.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("LOGIN_D", Str(keyloginnrq), deleterec.naam)
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
        MsgBox("Exporteer naar excel")
    End Sub


    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("naam.Contains(@0)", Fltnaam.Text)

        Select Case FltCBupd.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("upd == " & chval)
        Select Case FltCBnew.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("login.new == " & chval)
        Select Case FltCBdel.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("del == " & chval)
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
End Class