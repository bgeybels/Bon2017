Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchPER
    Private ordDGREC As String = "Naam"
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
        For Each a In GrBFilters.Controls
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        nofilter = False

        hkey = keypernrq
        SetGrids()
        keypernrq = hkey
        Fill_DGREC()
        keypernrq = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
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
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("PERNRQ").Value = keypernrq Then
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
            From per In db.PERs
            Let Wie = per.usernrq & " (" & per.chdate & ")"
            Select per.PERNRQ,
                InDienst = per.DIENST,
                Bediende = per.BEDIENDE,
                Sortering = per.PERSORTLONG,
                Naam = per.PERNM,
                DT_InDienst = per.PERDTID,
                DT_Contract = per.PERDTCT,
                DT_UitDienst = per.PERDTUD,
                GSMWerk = per.PERGSMW,
                Telefoon = per.PERTEL,
                ICE = per.PERICE,
                GSMPrive = per.PERGSM,
                Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "Naam"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"PERNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Bediende", "DT_InDienst", "DT_Contract", "DT_UitDienst", "ICE", "Naam", "Telefoon", "GSMPrive", "GSMWerk", "Sortering", "InDienst", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypernrq = DGREC.CurrentRow.Cells("PERNRQ").Value
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
        EditPER.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keypernrq = DGREC.CurrentRow.Cells("PERNRQ").Value

        ' test lock
        Dim lockedby = isLocked("PER", keypernrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("PER", keypernrq)

        EditPER.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Try
            Dim deleterec = (From per In db.PERs
                             Where per.PERNRQ = keypernrq).ToList()(0)

            db.PERs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("PER_D", Str(keypernrq), deleterec.PERNM & " - " & deleterec.PERTEL & " - " & deleterec.PERGSM)
            keypernrq = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub
    Private Sub DeleteRecMulti()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.SelectedRows
            keypernrq = row.Cells("PERNRQ").Value
            Try
                Dim deleterec = (From per In db.PERs
                                 Where per.PERNRQ = keypernrq).ToList()(0)

                db.PERs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
                Archive("PER_D", Str(keypernrq), deleterec.PERNM & " - " & deleterec.PERTEL & " - " & deleterec.PERGSM)
                keypernrq = 0
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
        If MsgBox("Verwijder personeel?", MsgBoxStyle.YesNoCancel, "Wil je dit personeelslid echt verwijderen?") <> MsgBoxResult.Yes Then
            Return
        End If
        DeleteRec()
    End Sub


    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Cursor = Cursors.WaitCursor
        ExportToCSV(DGREC, "PERSONEEL")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Naam.Contains(@0)", Fltpernm.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)

        chval = ""
        If (CBdienstJ.Checked = True) And (CBdienstN.Checked = False) Then chval = "true"
        If (CBdienstN.Checked = True) And (CBdienstJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("InDienst == " & chval)

        chval = ""
        If (CBbediendeJ.Checked = True) And (CBbediendeN.Checked = False) Then chval = "true"
        If (CBbediendeN.Checked = True) And (CBbediendeJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("BEDIENDE == " & chval)
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltpernm_TextChanged(sender As Object, e As EventArgs) Handles Fltpernm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub SelecteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecteerToolStripMenuItem.Click
        ' Loop over geselecteerde lijnen en zet DIENST = true
        UpdateSelect(1)
        Refresh_data()
    End Sub

    Private Sub DeSelecteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselecteerToolStripMenuItem.Click
        ' Loop over geselecteerde lijnen en zet DIENST = false
        UpdateSelect(0)
        Refresh_data()
    End Sub

    Private Sub UpdateSelect(setting As Integer)
        Dim skeyper As Integer

        For Each row As DataGridViewRow In DGREC.SelectedRows
            skeyper = row.Cells("PERNRQ").Value
            Dim updaterecs = (From per In db.PERs
                              Where per.PERNRQ = skeyper).ToList()(0)
            updaterecs.DIENST = setting
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
    End Sub

    Private Sub DGREC_DoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        UpdateRec()
    End Sub

    Private Sub CBdienstJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBdienstN_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBbediendeJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBbediendeJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub CBbediendeN_CheckedChanged(sender As Object, e As EventArgs) Handles CBbediendeN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub VerwijderGeselecteerdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderGeselecteerdeToolStripMenuItem.Click

        If MsgBox("Wil je deze personeelsleden echt verwijderen?", MsgBoxStyle.YesNoCancel, "Verwijder geselecteerde personeel?") <> MsgBoxResult.Yes Then
            Return
        End If
        DeleteRecMulti()

    End Sub
End Class