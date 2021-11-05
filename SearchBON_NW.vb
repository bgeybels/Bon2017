Imports System.Linq.Dynamic
Imports System.ComponentModel

Public Class SearchBON_NW
    Private ordDGREC As String = "KNaam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim FldEigenaar As String

    Private Sub SearchBON_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        'e.Cancel = True
    End Sub

    Private Sub SearchBON_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.fltbonjr = Fltbonjr.Value

        My.Settings.fltbontbw = 0
        If (CBtbwJ.Checked = True) And (CBtbwN.Checked = False) Then
            My.Settings.fltbontbw = 1
        ElseIf (CBtbwJ.Checked = False) And (CBtbwN.Checked = True) Then
            My.Settings.fltbontbw = 2
        End If

        My.Settings.fltbondel = 0
        If (CBdelJ.Checked = True) And (CBdelN.Checked = False) Then
            My.Settings.fltbondel = 1
        ElseIf (CBdelJ.Checked = False) And (CBdelN.Checked = True) Then
            My.Settings.fltbondel = 2
        End If

        My.Settings.fltbonvs = 0
        If (CBvsJ.Checked = True) And (CBvsN.Checked = False) Then
            My.Settings.fltbonvs = 1
        ElseIf (CBvsJ.Checked = False) And (CBvsN.Checked = True) Then
            My.Settings.fltbonvs = 2
        End If

        My.Settings.fltbongst = 0
        If (CBgstJ.Checked = True) And (CBgstN.Checked = False) Then
            My.Settings.fltbongst = 1
        ElseIf (CBgstJ.Checked = False) And (CBgstN.Checked = True) Then
            My.Settings.fltbongst = 2
        End If

        My.Settings.fltbonuv = 0
        If (CBuvJ.Checked = True) And (CBuvN.Checked = False) Then
            My.Settings.fltbonuv = 1
        ElseIf (CBuvJ.Checked = False) And (CBuvN.Checked = True) Then
            My.Settings.fltbonuv = 2
        End If

        My.Settings.fltbonfnr = 0
        If (CBfnrJ.Checked = True) And (CBfnrN.Checked = False) Then
            My.Settings.fltbonfnr = 1
        ElseIf (CBfnrJ.Checked = False) And (CBfnrN.Checked = True) Then
            My.Settings.fltbonfnr = 2
        End If

        My.Settings.fltbonpart = 0
        If (CBpartJ.Checked = True) And (CBpartN.Checked = False) Then
            My.Settings.fltbonpart = 1
        ElseIf (CBpartJ.Checked = False) And (CBpartN.Checked = True) Then
            My.Settings.fltbonpart = 2
        End If

        My.Settings.fltboncnr = 0
        If (CBcnrJ.Checked = True) And (CBcnrN.Checked = False) Then
            My.Settings.fltboncnr = 1
        ElseIf (CBcnrJ.Checked = False) And (CBcnrN.Checked = True) Then
            My.Settings.fltboncnr = 2
        End If

        My.Settings.fltfilterleegBON = CBfilterleeg.CheckState
    End Sub

    Private Sub SearchBON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' get values from settings
        Fltbonjr.Value = My.Settings.fltbonjr

        Select Case My.Settings.fltbontbw
            Case 1
                CBtbwJ.Checked = True
                CBtbwN.Checked = False
            Case 2
                CBtbwJ.Checked = False
                CBtbwN.Checked = True
            Case 0
                CBtbwJ.Checked = False
                CBtbwN.Checked = False
        End Select
        Select Case My.Settings.fltbondel
            Case 1
                CBdelJ.Checked = True
                CBdelN.Checked = False
            Case 2
                CBdelJ.Checked = False
                CBdelN.Checked = True
            Case 0
                CBdelJ.Checked = False
                CBdelN.Checked = False
        End Select
        Select Case My.Settings.fltbonvs
            Case 1
                CBvsJ.Checked = True
                CBvsN.Checked = False
            Case 2
                CBvsJ.Checked = False
                CBvsN.Checked = True
            Case 0
                CBvsJ.Checked = False
                CBvsN.Checked = False
        End Select
        Select Case My.Settings.fltbongst
            Case 1
                CBgstJ.Checked = True
                CBgstN.Checked = False
            Case 2
                CBgstJ.Checked = False
                CBgstN.Checked = True
            Case 0
                CBgstJ.Checked = False
                CBgstN.Checked = False
        End Select
        Select Case My.Settings.fltbonuv
            Case 1
                CBuvJ.Checked = True
                CBuvN.Checked = False
            Case 2
                CBuvJ.Checked = False
                CBuvN.Checked = True
            Case 0
                CBuvJ.Checked = False
                CBuvN.Checked = False
        End Select
        Select Case My.Settings.fltbonfnr
            Case 1
                CBfnrJ.Checked = True
                CBfnrN.Checked = False
            Case 2
                CBfnrJ.Checked = False
                CBfnrN.Checked = True
            Case 0
                CBfnrJ.Checked = False
                CBfnrN.Checked = False
        End Select
        Select Case My.Settings.fltboncnr
            Case 1
                CBcnrJ.Checked = True
                CBcnrN.Checked = False
            Case 2
                CBcnrJ.Checked = False
                CBcnrN.Checked = True
            Case 0
                CBcnrJ.Checked = False
                CBcnrN.Checked = False
        End Select
        Select Case My.Settings.fltbonpart
            Case 1
                CBpartJ.Checked = True
                CBpartN.Checked = False
            Case 2
                CBpartJ.Checked = False
                CBpartN.Checked = True
            Case 0
                CBpartJ.Checked = False
                CBpartN.Checked = False
        End Select

        If My.Settings.fltfilterleegBON = True Then
            CBfilterleeg.CheckState = 1
        Else
            CBfilterleeg.CheckState = 0
        End If

        Fltklant.Text = filterstr
        filterstr = ""

        'TopTen
        '''' FillCMBtopten(CMBtopten)'''

        nofilter = False
        hkey = keybonjr
        hkey2 = keybonnr
        SetGrids()
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        SetRECrow()

        Fltklant.Focus()
    End Sub

    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keybonjr = 0 Then keybonjr = My.Settings.fltbonjr
        hkey = keybonjr
        hkey2 = keybonnr
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        SetRECrow()
        keybonjr = hkey
        keybonnr = hkey2
        updategrid = True

        nofilter = True
        FillCMBtopten(CMBtopten)
        nofilter = False
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("JR").Value = keybonjr And DGREC.Rows(lp).Cells("NR").Value = keybonnr Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(1)
            End If
        Next
    End Sub

    Private Sub FillInfo()
        'TBResultBON
        Dim fndarr() As String
        TBResultBONL.BackColor = System.Drawing.SystemColors.ControlLight

        If keybonnr = 0 Then
            keybonnr = hkey2
        End If

        TBResultBON.Text = ""
        TBResultBON.Text = TBResultBON.Text & " Bon: " & keybonjr & "/" & keybonnr.ToString("0000") & "  (Totaal aantal bonnen: " & DGREC.RowCount & ") " & FldEigenaar
        TBResultBON.Text = TBResultBON.Text & Environment.NewLine & GetKlantInfo(keyknrq)
        'Next

        'TBRESULTBONF
        TBResultBONF.Text = ""
        TBResultBONF.Text = TBResultBONF.Text & GetKlantInfoFact(keyknrq)

        'TBResultBONL
        fndarr = GetBonlFigures(keybonjr, keybonnr).split("#")
        If fndarr(0) = "Y" Then
            TBResultBONL.BackColor = Color.FromArgb(255, 192, 192)
        End If
        TBResultBONL.Text = fndarr(1)
    End Sub

    Private Sub Empty_Filters()
        'Fltklant.Text = ""
        Fltklant.Text = ""
        Fltwerf.Text = ""
        Fltnr.Text = ""
    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If CBfilteryear.Checked = True Then
            records =
                From bon In db.BONs
                Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                Join eigenaar In db.EIGENAARs On bon.ENRQ Equals eigenaar.ENRQ
                Where bon.BONJR = Fltbonjr.Value
                Let BType = bon.bon_type
                Let Wie = bon.usernrq & "(" & bon.chdate & ")"
                Let Upl = klant.FAC
                Select JR = bon.BONJR, NR = bon.BONNR,
                    bon.KNRQ, bon.del, bon.klaar, bon.tbw, bon.vs, bon.gstk, bon.uv, bon.printed, bon.PART,
                    bon.fnr, bon.fok, bon.cnr, bon.cok, DatAanvang = bon.DatumAanvang, BType, Upl, klant.KNaam, bon.OmsBon,
                    REC = bon.TRECUP, FAC = bon.TFACT, NAC = bon.TNACALC, KHE = bon.TKILOH, Res = bon.TRESULT,
                    EIGENAAR = eigenaar.ENaam, Wie
        Else
            records =
                From bon In db.BONs
                Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                Join eigenaar In db.EIGENAARs On bon.ENRQ Equals eigenaar.ENRQ
                Let BType = bon.bon_type
                Let Wie = bon.usernrq & "(" & bon.chdate & ")"
                Let Upl = klant.FAC
                Select JR = bon.BONJR, NR = bon.BONNR,
                    bon.KNRQ, bon.del, bon.klaar, bon.tbw, bon.vs, bon.gstk, bon.uv, bon.printed, bon.PART,
                    bon.fnr, bon.fok, bon.cnr, bon.cok, DatAanvang = bon.DatumAanvang, BType, Upl, klant.KNaam, bon.OmsBon,
                    REC = bon.TRECUP, FAC = bon.TFACT, NAC = bon.TNACALC, KHE = bon.TKILOH, RES = bon.TRESULT,
                    Eigenaar = eigenaar.ENaam, Wie
        End If

        DGFILTER()
        Me.DGREC.DataSource = records
        If Me.ordDGREC = Nothing Then ordDGREC = "KNaam"
        Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Ascending)
        FillInfo()

        If CBfilteryear.Checked = True Then SetPrintedCell()
        'set numbermode
        Dim dgnums = New String() {"FAC", "NAC", "KHE", "RES", "REC"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next

        'set invisible
        Dim dginvisible = New String() {"KNRQ", "fok", "cok", "printed", "Eigenaar"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        'set autosizemode
        Dim dgautos = New String() {"KNaam", "NR", "Wie", "JR", "BType", "DatAanvang", "FAC", "NAC", "KHE", "RES", "REC"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautod = New String() {"Upl", "del", "klaar", "tbw", "vs", "gstk", "uv", "part", "fnr", "cnr"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index

        'DGREC.Columns("JR").Width = 35
        'DGREC.Columns("BType").Width = 40
        'DGREC.Columns("DatAanvang").Width = 75

        'DGREC.Columns("FAC").Width = 75
        'DGREC.Columns("NAC").Width = 75
        'DGREC.Columns("KHE").Width = 75
        'DGREC.Columns("RES").Width = 75
        'DGREC.Columns("REC").Width = 75

        DGREC.Columns("OmsBon").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'DGREC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If DGREC.RowCount < 1 Then
            keybonjr = Fltbonjr.Value
            keybonnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub SetPrintedCell()
        Dim keys As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i As Integer = 0 To DGREC.Rows.Count - 1
            keys = DGREC.Rows(i).Cells("printed").Value
            If keys = True Then
                DGREC.Rows(i).Cells("NR").Style.BackColor = dgcelcolor
            End If
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keybonjr = Fltbonjr.Value
        keybonnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        'If CBfilteryear.Checked = False Then keybonjr = DGREC.CurrentRow.Cells("JR").Value
        keybonjr = DGREC.CurrentRow.Cells("JR").Value
        keybonnr = DGREC.CurrentRow.Cells("NR").Value
        keyknrq = DGREC.CurrentRow.Cells("KNRQ").Value
        FldEigenaar = DGREC.CurrentRow.Cells("Eigenaar").Value

        FillInfo()

NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            'DGREC.CurrentRow = DGREC(e.RowIndex)
            keybonjr = DGREC.CurrentRow.Cells("JR").Value
            keybonnr = DGREC.CurrentRow.Cells("NR").Value
            keyknrq = DGREC.CurrentRow.Cells("KNRQ").Value
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.CellMouseDoubleClick
        UpdateRec()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        Editbon.ShowDialog()
        If CBfilterleeg.CheckState = 1 Then
            Empty_Filters()
        End If
        IsNewRecord = False
        Refresh_data()
        FillInfo()
    End Sub

    Private Sub UpdateRec()
        If keybonnr < 1 Then
            MsgBox("Geen bon beschikbaar om te bewerken.")
            Exit Sub
        End If

        ' test lock
        Dim strkey As String = keybonjr & keybonnr
        Dim lockedby = isLocked("BON", strkey)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("BON", strkey)

        Editbon.ShowDialog()
        If CBfilterleeg.CheckState = 1 Then
            Empty_Filters()
        End If

        hkey = keybonjr
        hkey2 = keybonnr
        'Fltbonjr.Value = My.Settings.fltbonjr
        keybonjr = hkey
        keybonnr = hkey2
        Refresh_data()
        keybonjr = hkey
        keybonnr = hkey2
        FillInfo()
        keybonjr = hkey
        keybonnr = hkey2
    End Sub

    Private Sub DeleteRec()
        If keybonnr < 1 Then
            MsgBox("Geen bon beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder bon?", MsgBoxStyle.YesNoCancel, "Wil je deze bon echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim checkrec = From bonl In db.BONLs
                       Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            If LoginSysAdmin = True Then
                If MsgBox("BON " & keybonjr & "/" & keybonnr & " bevat nog BONLijnen!!", MsgBoxStyle.YesNoCancel, "Wil je deze bon EN bonlijnen echt verwijderen?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                Try
                    delrecs = From bonl In db.BONLs Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
                    For Each Delbl In delrecs
                        db.BONLs.DeleteOnSubmit(Delbl)
                        db.SubmitChanges()
                        Dim key = keybonjr & "/" & keybonnr.ToString("0000") & "_" & keybonlvnr.ToString("0000")
                        Archive("BONL_D", key, "ToDo")
                    Next
                Catch
                    PositionMsgbox.CenterMsgBox(Me)
                    MsgBox("Schrappen niet gelukt!")
                    Exit Sub
                End Try
            Else
                MsgBox("Bon bevat nog bonlijnen, deze moet je eerst verwijderen!")
                Exit Sub
            End If
        End If
        Try
            Dim deleterec = (From bon In db.BONs
                             Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr).ToList()(0)

            db.BONs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keybonjr & "/" & keybonnr.ToString("0000")
            Archive("BON_D", key, deleterec.OmsBon)
            keybonjr = Fltbonjr.Value
            keybonnr = 0
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
            'If (TypeOf a Is ComboBox) Then
            'If (Mid(a.name, 1, 5) = "FltCB") Then
            'a.selectedindex = 0
            'End If
            'End If
            If TypeOf a Is CheckBox Then
                If Not Mid(a.name, 1, 8) = "CBfilter" Then
                    If a.name(a.name.Length - 1) = "N" Then
                        a.checked = True
                    Else
                        a.checked = False
                    End If
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
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        DeleteRec()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "BON")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DupliceerBonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DupliceerBonToolStripMenuItem.Click
        Dim xhkey2 As Integer
        ' Nieuwjaar = ToJaar
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If CopyBON(My.Settings.JaarCopy) = False Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Kopieer Bon(lijnen) niet gelukt!")
            Exit Sub
        End If

        hkey = keybonjr
        xhkey2 = keybonnr
        Fltbonjr.Value = keybonjr
        keybonjr = hkey
        keybonnr = xhkey2
        SetGrids()
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = xhkey2
        SetRECrow()
        keybonjr = hkey
        keybonnr = xhkey2
        FillInfo()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub StartBonLines()
        Dim msgbonl As String = ""
        plook = False
        SearchBONL_NW.MdiParent = MDIbon
        SearchBONL_NW.WindowState = FormWindowState.Maximized
        HasFnr = False
        If DGREC.CurrentRow.Cells("fok").Value = True Or DGREC.CurrentRow.Cells("cok").Value = True Then
            HasFnr = True
            msgbonl = "BON " & keybonjr & "/" & keybonnr & " bevat al Factuur/Creditnota!!" & vbCrLf & "Bonlijnen toch aanpassen?"

            Select Case MsgBox(msgbonl, MsgBoxStyle.YesNoCancel, "Opgelet!")
                Case MsgBoxResult.Yes
                    HasFnr = False
                Case MsgBoxResult.Cancel
                    Exit Sub
                Case MsgBoxResult.No
                    HasFnr = True
            End Select
        End If

        SearchBONL_NW.Show()

    End Sub

    Private Sub ToonBonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToonBonlijnenToolStripMenuItem.Click
        StartBonLines()
    End Sub

    Private Sub BewerkKlantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkKlantToolStripMenuItem.Click
        keyklantnrq = keyknrq
        EditKlant.ShowDialog()
        nofilter = True
        Refresh_data()
        FillInfo()
        nofilter = False
    End Sub

    Private Sub CMBtopten_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMBtopten.SelectedValueChanged
        On Error GoTo Troubles
        If nofilter = False Then
            Dim selval As String = CMBtopten.SelectedValue

            keybonjr = selval.Substring(0, selval.IndexOf("/"))
            'Fltbonjr.Value = keybonjr
            keybonnr = selval.Substring(selval.IndexOf("/") + 1, Len(selval) - (selval.IndexOf("/") + 1))
            StartBonLines()

            nofilter = True
            Refresh_data()
            FillInfo()
            nofilter = False
        End If
Troubles:
    End Sub

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        If Fltnr.Text <> "" And IsNumeric(Fltnr.Text) Then
            records = records.Where("NR == " & Fltnr.Text)
            Exit Sub
        End If

        If Fltklant.Text.StartsWith("*") Then
            records = records.Where("KNaam.Contains(@0)", Fltklant.Text.Remove(0, 1))
        Else
            records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        End If
        records = records.Where("OmsBon.Contains(@0)", Fltwerf.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)

        chval = ""
        If (CBdelJ.Checked = True) And (CBdelN.Checked = False) Then chval = "true"
        If (CBdelN.Checked = True) And (CBdelJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("del == " & chval)
        chval = ""
        If (CBklaarJ.Checked = True) And (CBklaarN.Checked = False) Then chval = "true"
        If (CBklaarN.Checked = True) And (CBklaarJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("klaar == " & chval)
        chval = ""
        If (CBtbwJ.Checked = True) And (CBtbwN.Checked = False) Then chval = "true"
        If (CBtbwN.Checked = True) And (CBtbwJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("tbw == " & chval)
        chval = ""
        If (CBvsJ.Checked = True) And (CBvsN.Checked = False) Then chval = "true"
        If (CBvsN.Checked = True) And (CBvsJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("vs == " & chval)
        chval = ""
        If (CBgstJ.Checked = True) And (CBgstN.Checked = False) Then chval = "true"
        If (CBgstN.Checked = True) And (CBgstJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("gstk == " & chval)
        chval = ""
        If (CBuvJ.Checked = True) And (CBuvN.Checked = False) Then chval = "true"
        If (CBuvN.Checked = True) And (CBuvJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("uv == " & chval)
        chval = ""
        If (CBfnrJ.Checked = True) And (CBfnrN.Checked = False) Then chval = "fnr <> 0"
        If (CBfnrN.Checked = True) And (CBfnrJ.Checked = False) Then chval = "fnr == 0"
        If chval <> "" Then
            records = records.Where(chval)
        End If
        chval = ""
        If (CBcnrJ.Checked = True) And (CBcnrN.Checked = False) Then chval = "cnr <> 0"
        If (CBcnrN.Checked = True) And (CBcnrJ.Checked = False) Then chval = "cnr == 0"
        If chval <> "" Then
            records = records.Where(chval)
        End If
        chval = ""
        If (CBpartJ.Checked = True) And (CBpartN.Checked = False) Then chval = "true"
        If (CBpartN.Checked = True) And (CBpartJ.Checked = False) Then chval = "false"
        If chval <> "" Then
            records = records.Where("part == " & chval)
        End If

    End Sub
    Private Sub CBfilteryear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        keybonjr = Fltbonjr.Value
        keybonnr = 0
        'My.Settings.fltbonjr = Fltbonjr.Value
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltwerf_TextChanged_1(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnr_TextChanged(sender As Object, e As EventArgs) Handles Fltnr.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs) Handles TSBprint.Click
        ExportToBonNaCalc(keybonjr, keybonnr)
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub SearchBON_NW_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'FillCMBtopten(CMBtopten)
        If CBfilterleeg.CheckState = 1 Then
            Empty_Filters()
        End If
        ''Fill_DGREC()

        Refresh_data()
        ''FillInfo()
    End Sub

    Private Sub CBdelJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBdelJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBdelN_CheckedChanged(sender As Object, e As EventArgs) Handles CBdelN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBtbwJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBtbwJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBtbwN_CheckedChanged(sender As Object, e As EventArgs) Handles CBtbwN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBvsJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBvsJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBvsN_CheckedChanged(sender As Object, e As EventArgs) Handles CBvsN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBgstJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBgstJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBgstN_CheckedChanged(sender As Object, e As EventArgs) Handles CBgstN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBuvJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBuvJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBuvN_CheckedChanged(sender As Object, e As EventArgs) Handles CBuvN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfnrJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBfnrJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfnrN_CheckedChanged(sender As Object, e As EventArgs) Handles CBfnrN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcnrJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBcnrJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcnrN_CheckedChanged(sender As Object, e As EventArgs) Handles CBcnrN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBpartJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBpartJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBpartN_CheckedChanged(sender As Object, e As EventArgs) Handles CBpartN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBklaarJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBklaarJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBklaarN_CheckedChanged(sender As Object, e As EventArgs) Handles CBklaarN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub


End Class