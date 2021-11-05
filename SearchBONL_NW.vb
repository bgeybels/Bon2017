Imports System.Linq.Dynamic
Imports System.ComponentModel

Public Class SearchBONL_NW
    Private ordDGREC As String = ""
    Dim sortdirection As String = "DESC"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False
    Dim fndarr() As String

    Private Sub SearchBONL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'My.Settings.fltbontbw = FltCBtbw.SelectedIndex
        vardvan = FltDatumvan.Value
        vardtot = Fltdatumtot.Value
        My.Settings.fltfilterdatum = CBfilterdatum.CheckState
        UpdateSelectAll(0)
        ' haal factnr terug op als nu 0 is en er bestaat D - C
        If GetFaktNr = True Then
            getDBFact(keybonjr, keybonnr, "D")
            getDBFact(keybonjr, keybonnr, "C")
        End If
    End Sub

    Private Sub SearchBONL_NW_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If keybonnr > 0 Then
            Bondvantot(keybonjr, keybonnr)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub SearchBONL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        GroepeerALLEBonlijnenToolStripMenuItem.Enabled = False
        If LoginSysAdmin = True Then
            GroepeerALLEBonlijnenToolStripMenuItem.Enabled = True
        End If

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
        FltDatumvan.Value = vardvan
        Fltdatumtot.Value = vardtot
        CBfilterdatum.Checked = My.Settings.fltfilterdatum

        'Info
        FillInfo()

        hkey = keybonjr
        hkey2 = keybonnr
        hkey3 = keybonlvnr
        SetGrids()
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        keybonlvnr = hkey3
        SetRECrow()

        FltOmsgroep.Focus()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        hkey = keybonjr
        hkey2 = keybonnr
        hkey3 = keybonlvnr
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        keybonlvnr = hkey3
        SetRECrow()
        keybonjr = hkey
        keybonnr = hkey2
        keybonlvnr = hkey3
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("JR").Value = keybonjr And DGREC.Rows(lp).Cells("NR").Value = keybonnr And DGREC.Rows(lp).Cells("VLNR").Value = keybonlvnr Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(4)
            End If
        Next
    End Sub

    Private Sub FillInfoRow()
        Dim prtuser As String = ""
        Dim prtdate As String = ""

        If nofilter = True Then Exit Sub
        TBResultTelL.Text = ""
        Dim codrec = From cod In db.CODs
                     Where cod.CNRQ = keycnrq
                     Select cod.Code, cod.OmsCode, cod.Stock, cod.Minstock, cod.Eenhp, cod.Aankp, cod.Plmagazijn, cod.Besteld, cod.notstock, cod.gratis
                     Take 1

        Dim extra As String = ""
        For Each rec In codrec
            If rec.OmsCode.Length() > 30 Then
                TBResultTelL.Text += rec.Code & " (" & rec.OmsCode.Substring(0, 30) & ")" & Environment.NewLine
            Else
                TBResultTelL.Text += rec.Code & " (" & rec.OmsCode & ")" & Environment.NewLine
            End If

            TBResultTelL.Text += "Stock: " & rec.Stock & "    Minimum Stock: " & rec.Minstock
            If rec.Plmagazijn <> "" Then TBResultTelL.Text += "   (" & rec.Plmagazijn & ")"
            TBResultTelL.Text += Environment.NewLine & " AP: " & rec.Aankp & "  VP: " & rec.Eenhp
            If rec.gratis = True Then extra += "Gratis "
            If rec.notstock = True Then extra += "Niet_opgenomen_in_Stock "
            If rec.Besteld = True Then extra += "In_Bestelling"
            If extra <> "" Then
                extra = "  (" & extra & ")"
            End If
            TBResultTelL.Text += extra

            TBResultTelL.Text += Environment.NewLine & "Werf:    " & DGREC.CurrentRow.Cells("Werf").Value

            TBResultTelL.Text += Environment.NewLine & "BonNr: " & DGREC.CurrentRow.Cells("BonNR").Value

            TBResultTelL.Text += Environment.NewLine
            TBResultTelL.Text += Environment.NewLine & "Upd:" & DGREC.CurrentRow.Cells("Wie").Value
            TBResultTelL.Text += " New:" & DGREC.CurrentRow.Cells("Nieuw").Value
        Next

    End Sub

    Private Sub FillInfo()
        'TBresultBONL
        Dim fndarr() As String

        TBResultBONL.Text = keybonjr & "/" & keybonnr & " "
        Dim klantrec = From bon In db.BONs
                       Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                       Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr
                       Select bon.BONJR, klant.KNRQ, bon.OmsBon
        For Each klantr In klantrec
            TBResultBONL.Text = TBResultBONL.Text & "[" & klantr.OmsBon & "] " & Environment.NewLine & GetKlantInfo(klantr.KNRQ)
        Next
        TBResultTelA.BackColor = System.Drawing.SystemColors.ControlLight

        'TBresultTELa
        fndarr = GetBonlFigures(keybonjr, keybonnr).split("#")
        If fndarr(0) = "Y" Then
            TBResultTelA.BackColor = Color.FromArgb(255, 192, 192)
        End If
        TBResultTelA.Text = fndarr(1)

    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If CBfilterdatum.Checked = True Then
            records =
            From bonl In db.BONLs
            Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
            Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
            Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
            Join aoms In db.AOms On code.ANRQ Equals aoms.ANRQ
            Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr _
              And bonl.Datum >= Format(FltDatumvan.Value, "#yyyy-MM-dd 00:00:00.000#") _
              And bonl.Datum < Format(Fltdatumtot.Value, "#yyyy-MM-dd 23:59:59.999#")
            Order By bonl.Datum Descending, bonl.BONLVNR Descending
            Let Werf = bonl.BWStraat & " " & bonl.BWAdres
            Let Wie = bonl.usernrq & "(" & bonl.chdate & ")"
            Let Nieuw = bonl.usercre & "(" & bonl.datecre & ")"
            Let Totaal = bonl.Aantal * bonl.BONEenhp
            Let FAantal = "(" & bonl.Aantal.ToString() & ")"
            Let Check = bonl.CONTROLEOK
            Select DSort = bonl.BLSORT, JR = bonl.BONJR, NR = bonl.BONNR, VLNR = bonl.BONLVNR,
                VNR = bonl.Volgorde, Check, SEL = bonl.select, bonl.Datum,
                Groep = codgp.OmsGroep, code.Code, code.OmsCode,
                bonl.memo,
                bonl.Aantal, FAantal, Eenh = aoms.Oms, EenhPrijs = bonl.BONEenhp, Totaal, BTW = btw.OmsBTW, btw.BNRQ,
                bonl.PERNM, bonl.OAANMNM, bonl.LEVNM,
                BonNR = bonl.EXTNR, bonl.omstijd,
                Werf, Wie, Nieuw,
                bonl.CNRQ, code.gratis, code.KMHEFFING, code.CGNRQ, bonl.AP
        Else
            records =
                From bonl In db.BONLs
                Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
                Join aoms In db.AOms On code.ANRQ Equals aoms.ANRQ
                Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
                Order By bonl.Datum Descending, bonl.BONLVNR Descending
                Let Werf = bonl.BWStraat & " " & bonl.BWAdres
                Let Wie = bonl.usernrq & "(" & bonl.chdate & ")"
                Let Nieuw = bonl.usercre & "(" & bonl.datecre & ")"
                Let Totaal = bonl.Aantal * bonl.BONEenhp
                Let FAantal = "(" & bonl.Aantal.ToString() & ")"
                Let Check = bonl.CONTROLEOK
                Select DSort = bonl.BLSORT, JR = bonl.BONJR, NR = bonl.BONNR, VLNR = bonl.BONLVNR,
                    VNR = bonl.Volgorde, Check, SEL = bonl.select, bonl.Datum,
                    Groep = codgp.OmsGroep, code.Code, code.OmsCode,
                    bonl.memo,
                    bonl.Aantal, FAantal, Eenh = aoms.Oms, EenhPrijs = bonl.BONEenhp, Totaal, BTW = btw.OmsBTW, btw.BNRQ,
                    bonl.PERNM, bonl.OAANMNM, bonl.LEVNM,
                    BonNR = bonl.EXTNR, bonl.omstijd,
                    Werf, Wie, Nieuw,
                    bonl.CNRQ, code.gratis, code.KMHEFFING, code.CGNRQ, bonl.AP
        End If

        DGFILTER()
        Me.DGREC.DataSource = records

        If Me.ordDGREC = Nothing Then ordDGREC = "DSort"
        If sortdirection = "DESC" Then Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Descending)
        If sortdirection = "ASC" Then Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Ascending)

        TBResultTelB.BackColor = System.Drawing.SystemColors.ControlLight
        fndarr = GetSELBonlFigures(DGREC, keybonjr, keybonnr).split("#")
        If fndarr(0) = "Y" Then
            TBResultTelB.BackColor = Color.FromArgb(255, 192, 192)
        End If
        TBResultTelB.Text = fndarr(1)

        'set numbermode
        Dim dgnums = New String() {"Aantal", "Totaal", "EenhPrijs"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Next

        'DGREC.Columns("DSort").DefaultCellStyle.Format = "dd/MM/yyyy h:mm:ss"
        'set invisible
        Dim dginvisible = New String() {"FAantal", "JR", "NR", "VLNR", "CNRQ", "CGNRQ", "BNRQ", "gratis", "KMHEFFING", "wie", "Nieuw", "AP", "Werf", "BonNR"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        DGREC.Columns("Datum").HeaderText = "StartDatum"
        DGREC.Columns("PERNM").HeaderText = "Personeel"
        DGREC.Columns("OAANMNM").HeaderText = "OnderaanN"
        DGREC.Columns("LEVNM").HeaderText = "Leverancier"
        ' set vaste waardes
        DGREC.Columns("DSort").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("DSort").Width = 90
        DGREC.Columns("Datum").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("Datum").Width = 70
        DGREC.Columns("Code").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("Code").Width = 55
        DGREC.Columns("OmsCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("OmsCode").Width = 155
        DGREC.Columns("VNR").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DGREC.Columns("VNR").Width = 35
        'set autosizemode
        Dim dgautoss = New String() {"code"}
        For index = 0 To dgautoss.GetUpperBound(0)
            DGREC.Columns(dgautoss(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautos = New String() {"memo", "Eenh"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautod = New String() {"Groep"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index

        Dim dgautoh = New String() {"SEL", "Totaal", "BTW", "PERNM", "LEVNM", "OAANMNM", "EenhPrijs", "Aantal", "Check"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index

        DGREC.Columns("omstijd").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If DGREC.RowCount < 1 Then
            keybonlvnr = 0
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
        SetPrintedCell()
    End Sub

    Private Sub SetPrintedCell()
        Dim var_memo As String
        Dim var_gratis As String
        Dim var_prijs As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i As Integer = 0 To DGREC.Rows.Count - 1
            '            DGREC.Rows(row).Cells(1).style.backcolor = dgcelcolor
            var_memo = DGREC.Rows(i).Cells("memo").Value
            var_gratis = DGREC.Rows(i).Cells("gratis").Value
            var_prijs = DGREC.Rows(i).Cells("Eenhprijs").Value
            If var_memo <> "" Then
                DGREC.Rows(i).Cells("memo").Style.BackColor = dgcelmemo
            End If
            If var_gratis = False And var_prijs = 0 Then
                DGREC.Rows(i).Cells("Eenhprijs").Style.BackColor = dgcelgratis
            End If
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keybonlvnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keybonlvnr = DGREC.CurrentRow.Cells("VLNR").Value
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
        keycgnrq = DGREC.CurrentRow.Cells("CGNRQ").Value
        FillInfoRow()

NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            keybonlvnr = DGREC.CurrentRow.Cells("VLNR").Value
            keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
            keycgnrq = DGREC.CurrentRow.Cells("CGNRQ").Value
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        If HasFnr = True Then Exit Sub
        If keybonlvnr > 0 Then UpdateRec()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        Editbonl.ShowDialog()
        IsNewRecord = False
        Refresh_data()
        FillInfo()
        FillInfoRow()
    End Sub

    Private Sub UpdateRec()
        If keybonlvnr < 1 Then
            MsgBox("Geen bonlijn beschikbaar om te bewerken.")
            Exit Sub
        End If

        ' test lock
        Dim strkey As String = keybonjr & keybonnr & keybonlvnr
        Dim lockedby = isLocked("BONL", strkey)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("BONL", strkey)

        Editbonl.ShowDialog()

        Refresh_data()
        FillInfo()
        FillInfoRow()
    End Sub

    Private Sub DeleteRec()
        If keybonlvnr < 1 Then
            MsgBox("Geen bonlijn beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder bonlijn?", MsgBoxStyle.YesNoCancel, "Wil je deze bonlijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If updatestock = True Then UpdateOk = StockUpdate("D", keycnrq, keybonjr, keybonnr, keybonlvnr, "0")
        Try
            Dim deleterec = (From bonl In db.BONLs
                             Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = keybonlvnr).ToList()(0)

            db.BONLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keybonjr & "/" & keybonnr.ToString("0000") & "_" & keybonlvnr.ToString("0000")
            Archive("BONL_D", key, "ToDo")
            keybonlvnr = 0
            Fill_DGREC()
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


    Private Sub BewerkBonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkBonToolStripMenuItem.Click
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
        FillInfo()
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
        ExportToCSV(DGREC, "BONLIJNEN")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs) Handles TSBprint.Click
        ExportToBonNaCalc(keybonjr, keybonnr)
    End Sub

    Private Sub GroepsbewerkingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroepsbewerkingToolStripMenuItem.Click
        resetbonlselect = True
        GrpBONL.ShowDialog()

        nofilter = True
        If resetbonlselect = True Then ResetSelect()
        Refresh_data()
        FillInfo()
        FillInfoRow()

        nofilter = False
    End Sub

    Private Sub GroepeerALLEBonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroepeerALLEBonlijnenToolStripMenuItem.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If GroupBONL() <> "OK" Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Groepering niet gelukt!: " & GroupBONL())
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Samenvoegen gelukt!")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        nofilter = True
        Refresh_data()
        FillInfo()
        FillInfoRow()
        If resetbonlselect = True Then ResetSelect()
        nofilter = False

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
            skeybonlvnr = row.Cells("VLNR").Value
            Dim updaterecs = (From bonl In db.BONLs
                              Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = skeybonlvnr).ToList()(0)
            updaterecs.select = setting
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub UpdateSelectAll(setting As Integer)
        Dim skeybonlvnr As Integer
        If keybonnr < 1 Then Exit Sub

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.Rows
            skeybonlvnr = row.Cells("VLNR").Value
            Dim updaterecs = (From bonl In db.BONLs
                              Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = skeybonlvnr).ToList()(0)
            updaterecs.select = setting
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
        Try
            For Each row As DataGridViewRow In Me.DGREC.Rows
                If row.Cells("SEL").Value <> True Then Continue For
                skeybonlvnr = row.Cells("VLNR").Value
                Dim updaterecs = (From bonl In db.BONLs
                                  Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = skeybonlvnr).ToList()(0)
                updaterecs.select = 0
                Try
                    db.SubmitChanges()
                Catch
                    ' Handle exception.  
                End Try
            Next
        Catch ex As Exception

        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BewerkCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkCodeToolStripMenuItem.Click
        EditCode.ShowDialog()
        nofilter = True
        Refresh_data()
        FillInfo()
        FillInfoRow()
        nofilter = False
    End Sub

    Private Sub BewerkCodeGroepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkCodeGroepToolStripMenuItem.Click
        EditCodgp.ShowDialog()
        nofilter = True
        Refresh_data()
        FillInfo()
        FillInfoRow()
        nofilter = False
    End Sub

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        If Fltvolgorde.Text <> "" And IsNumeric(Fltvolgorde.Text) Then
            records = records.Where("VNR == " & Fltvolgorde.Text)
            Exit Sub
        End If
        If Fltaantal.Text <> "" Then
            records = records.Where("FAantal.Contains(@0)", Fltaantal.Text)
        End If
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("Nieuw.Contains(@0)", Fltnieuw.Text)
        records = records.Where("BTW.Contains(@0)", Fltbtw.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        records = records.Where("Groep.Contains(@0)", FltOmsgroep.Text)
        records = records.Where("Code.Contains(@0)", FltCode.Text)
        records = records.Where("OmsCode.Contains(@0)", FltOmsCode.Text)
        records = records.Where("pernm.Contains(@0)", Fltpernm.Text)
        records = records.Where("levnm.Contains(@0)", Fltlevnm.Text)
        records = records.Where("oaanmnm.Contains(@0)", Fltoaanmnm.Text)

        If (CBlevJ.Checked = True) And (CBlevN.Checked = False) Then

        ElseIf (CBlevJ.Checked = False) And (CBlevN.Checked = True) Then

        ElseIf (CBlevJ.Checked = False) And (CBlevN.Checked = False) Then

        ElseIf (CBlevJ.Checked = True) And (CBlevN.Checked = True) Then

        End If
        If (CBlevJ.Checked = True) And (CBlevN.Checked = False) Then

        End If

        'records = records.Where("Datum.Equals(@0)", FltDatumvan.Value)
        chval = ""
        If (CBselectJ.Checked = True) And (CBselectN.Checked = False) Then chval = "true"
        If (CBselectN.Checked = True) And (CBselectJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("SEL == " & chval)
        chval = ""
        If (CBcontroleokJ.Checked = True) And (CBcontroleokN.Checked = False) Then chval = "true"
        If (CBcontroleokN.Checked = True) And (CBcontroleokJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("Check == " & chval)
    End Sub

    Private Sub Fltwerf_TextChanged_1(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltbtw_TextChanged(sender As Object, e As EventArgs) Handles Fltbtw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBselect_SelectedIndexChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub FltCBcontroleok_SelectedIndexChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltOmsgroep_TextChanged(sender As Object, e As EventArgs) Handles FltOmsgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCode_TextChanged(sender As Object, e As EventArgs) Handles FltCode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltOmsCode_TextChanged(sender As Object, e As EventArgs) Handles FltOmsCode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltpernm_TextChanged(sender As Object, e As EventArgs) Handles Fltpernm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltoaanmnm_TextChanged(sender As Object, e As EventArgs) Handles Fltoaanmnm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltlevnm_TextChanged(sender As Object, e As EventArgs) Handles Fltlevnm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfilterdatum_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilterdatum.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltDatumvan_ValueChanged(sender As Object, e As EventArgs) Handles FltDatumvan.ValueChanged
        Fltdatumtot.Value = FltDatumvan.Value
        If CBfilterdatum.Checked = True And nofilter = False Then
            Fill_DGREC()
        End If
    End Sub

    Private Sub Fltdatumtot_ValueChanged(sender As Object, e As EventArgs) Handles Fltdatumtot.ValueChanged
        If CBfilterdatum.Checked = True And nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltvolgorde_TextChanged(sender As Object, e As EventArgs) Handles Fltvolgorde.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltaantal_TextChanged(sender As Object, e As EventArgs) Handles Fltaantal.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnieuw_TextChanged(sender As Object, e As EventArgs) Handles Fltnieuw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub ControleOkéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleOkéToolStripMenuItem.Click
        ' Loop over geselecteerde bonlijnen en zet controleok = true
        UpdateControleok(1)
        Refresh_data()
    End Sub

    Private Sub ControleNietOkéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleNietOkéToolStripMenuItem.Click
        ' Loop over geselecteerde bonlijnen en zet controleok = false
        UpdateControleok(0)
        Refresh_data()
    End Sub

    Private Sub UpdateControleok(setting As Integer)
        Dim skeybonlvnr As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.SelectedRows
            skeybonlvnr = row.Cells("VLNR").Value
            Dim updaterecs = (From bonl In db.BONLs
                              Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = skeybonlvnr).ToList()(0)
            updaterecs.CONTROLEOK = setting
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub CBselectJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBselectJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBselectN_CheckedChanged(sender As Object, e As EventArgs) Handles CBselectN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcontroleokJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBcontroleokJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcontroleokN_CheckedChanged(sender As Object, e As EventArgs) Handles CBcontroleokN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGREC.ColumnHeaderMouseClick
        ordDGREC = DGREC.SortedColumn.HeaderText
        If ordDGREC = "StartDatum" Then ordDGREC = "Datum"
        sortdirection = DGREC.SortOrder
        Select Case DGREC.SortOrder
            Case 1
                sortdirection = "ASC"
            Case 2
                sortdirection = "DESC"
        End Select

    End Sub

End Class