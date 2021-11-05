Imports System.Linq.Dynamic
Imports System.Linq
    Imports System.ComponentModel

Public Class SearchPERL
    Private ordDGREC As String = "Datum"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchPERL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub

    Private Sub SearchPERL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        For Each a In GroupFilter.Controls
            If TypeOf a Is ComboBox Then
                If a.name Like "Flt*" Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(NieuwToolStripMenuItem)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        If HasFnr = True Then
            TSBnew.Enabled = False
            TSBdelete.Enabled = False
            TSBedit.Enabled = False
            ContextMenuStrip1.Enabled = False
        End If

        nofilter = False
        ' get values from settings
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw

        FillInfo()

        hkey = keypernrq
        hkey2 = keypervnr
        SetGrids()
        Fill_DGREC()
        keypernrq = hkey
        keypervnr = hkey2
        SetRECrow()

        FltOmsgroep.Focus()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        hkey = keypernrq
        hkey2 = keypervnr
        Fill_DGREC()
        keypernrq = hkey
        keypervnr = hkey2
        SetRECrow()
        keypernrq = hkey
        keypervnr = hkey2
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("ID").Value = keypernrq And DGREC.Rows(lp).Cells("VNR").Value = keypervnr Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(4)
            End If
        Next
    End Sub

    Private Sub FillInfo()
        'TBresultBONL

        TBResult.Text = ""
        Dim perrec = From per In db.PERs
                     Where per.PERNRQ = keypernrq
                     Select per.PERNM, per.PERGSM, per.PERGSMW
        For Each perr In perrec
            TBResult.Text = TBResult.Text & " " & perr.PERNM & " GSM/W: " & perr.PERGSM & " " & perr.PERGSMW
        Next
        TBResult.BackColor = System.Drawing.SystemColors.ControlLight

    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        records =
            From perl In db.PERLs
            Join code In db.CODs On perl.CNRQ Equals code.CNRQ
            Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
            Where perl.PERL_NRQ = keypernrq
            Let Code_ = code.Code & " (" & code.OmsCode & ")"
            Let Wie = perl.USERNRQ & " (" & perl.CHDATE & ")"
            Let Nieuw = perl.USERCRE & " (" & perl.DATECRE & ")"
            Select ID = perl.PERL_NRQ, VNR = perl.PERL_VNR,
                SEL = perl.SELREC, InBezit = perl.INBEZIT, Datum = perl.STARTDATE, perl.AANTAL,
                Groep = codgp.OmsGroep, Code_, CNRQ = code.CNRQ,
                Nieuw, Wie

        DGFILTER()
        Me.DGREC.DataSource = records

        If Me.ordDGREC = Nothing Then ordDGREC = "Datum"
        ordDGREC = "Datum"
        Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Descending)

        'set invisible
        Dim dginvisible = New String() {"ID", "CNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        DGREC.Columns("Code_").HeaderText = "Code"
        ' set vaste waardes
        DGREC.Columns("Code_").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("Code_").Width = 160
        DGREC.Columns("Nieuw").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("Nieuw").Width = 100
        DGREC.Columns("Wie").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("Wie").Width = 100
        'set autosizemode
        Dim dgautod = New String() {"Groep"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautoh = New String() {"SEL", "InBezit", "VNR", "Aantal", "Datum"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        'DGREC.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'If DGREC.RowCount < 1 Then
        ' keybonlvnr = 0
        ' End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keybonlvnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypervnr = DGREC.CurrentRow.Cells("VNR").Value
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
        FillInfo()
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            keypervnr = DGREC.CurrentRow.Cells("VNR").Value
            keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.CellMouseDoubleClick
        If HasFnr = True Then Exit Sub
        If keypervnr > 0 Then UpdateRec()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        Editperl.ShowDialog()
        IsNewRecord = False
        Refresh_data()
        FillInfo()
    End Sub

    Private Sub UpdateRec()
        If keypervnr < 1 Then
            MsgBox("Geen personeel-lijn beschikbaar om te bewerken.")
            Exit Sub
        End If

        ' test lock
        Dim strkey As String = keypernrq & keypervnr
        Dim lockedby = isLocked("PERL", strkey)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("PERL", strkey)

        Editperl.ShowDialog()

        Refresh_data()
        FillInfo()
    End Sub

    Private Sub DeleteRec()
        If keybonnr < 1 Then
            MsgBox("Geen PER-lijn beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder PER-lijn?", MsgBoxStyle.YesNoCancel, "Wil je deze PER-lijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        'If updatestock = True Then updateOK = StockUpdate("D", keycnrq, keybonjr, keybonnr, keybonlvnr, "0")
        Try
            Dim deleterec = (From perl In db.PERLs
                             Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr).ToList()(0)

            db.PERLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keypernrq & "/" & keypervnr.ToString("0000")
            Archive("PERL_D", key, "ToDo")
            keybonlvnr = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    a.selectedindex = 0
                End If
            End If
            If (TypeOf a Is CheckBox) Then
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
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        DeleteRec()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "PERLIJNEN")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub SelecteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecteerToolStripMenuItem.Click
        ' Loop over geselecteerde bonlijnen en zet select = true
        UpdateSelect(1)
        Refresh_data()
    End Sub

    Private Sub DeSelecteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeSelecteerToolStripMenuItem.Click
        ' Loop over geselecteerde bonlijnen en zet select = false
        UpdateSelect(0)
        Refresh_data()
    End Sub

    Private Sub UpdateSelect(setting As Integer)
        Dim skeybonlvnr As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.SelectedRows
            skeybonlvnr = row.Cells("VNR").Value
            Dim updaterecs = (From perl In db.PERLs
                              Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr).ToList()(0)
            updaterecs.SELREC = setting
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ResetSelect()
        Dim skeybonlvnr As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Me.DGREC.RowCount < 1 Then Exit Sub
        For Each row As DataGridViewRow In Me.DGREC.Rows
            If row.Cells("SEL").Value <> True Then Continue For
            skeybonlvnr = row.Cells("VNR").Value
            Dim updaterecs = (From perl In db.PERLs
                              Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr).ToList()(0)
            updaterecs.selrec = 0
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BewerkCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkCodeToolStripMenuItem.Click
        EditCode.ShowDialog()
        nofilter = True
        Refresh_data()
        nofilter = False
    End Sub

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("Nieuw.Contains(@0)", Fltnieuw.Text)
        records = records.Where("Groep.Contains(@0)", FltOmsgroep.Text)
        records = records.Where("Code_.Contains(@0)", FltCode.Text)

        chval = ""
        If (CBselectJ.Checked = True) And (CBselectN.Checked = False) Then chval = "true"
        If (CBselectN.Checked = True) And (CBselectJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("SEL == " & chval)
    End Sub

    Private Sub FltOmsgroep_TextChanged(sender As Object, e As EventArgs) Handles FltOmsgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCode_TextChanged(sender As Object, e As EventArgs) Handles FltCode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnieuw_TextChanged(sender As Object, e As EventArgs) Handles Fltnieuw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBselectJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBselectJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBselectN_CheckedChanged(sender As Object, e As EventArgs) Handles CBselectN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class