
Imports System.Linq.Dynamic
Imports System.Linq
Imports System.ComponentModel

Public Class SearchBONL_all
    Private ordDGREC As String = "Datum"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim fndarr() As String


    Private Sub SearchBONL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'My.Settings.fltbontbw = FltCBtbw.SelectedIndex
        vardvan = FltDatumvan.Value
        vardtot = Fltdatumtot.Value
        My.Settings.fltfilterdatum = CBfilterdatum.CheckState
        My.Settings.fltbonjr = Fltbonjr.Value
        My.Settings.fltbontbw = FltCBtbw.SelectedIndex
        My.Settings.fltbonvs = FltCBvs.SelectedIndex
        My.Settings.fltbongst = FltCBgst.SelectedIndex
        My.Settings.fltbonuv = FltCBuv.SelectedIndex
        My.Settings.fltbonfnr = FltCBfnr.SelectedIndex
        My.Settings.fltboncnr = FltCBcnr.SelectedIndex
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

        ' get values from settings
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw
        Fltbonjr.Value = My.Settings.fltbonjr
        FltDatumvan.Value = vardvan
        Fltdatumtot.Value = vardtot
        FltCBtbw.SelectedIndex = My.Settings.fltbontbw
        FltCBvs.SelectedIndex = My.Settings.fltbonvs
        FltCBgst.SelectedIndex = My.Settings.fltbongst
        FltCBuv.SelectedIndex = My.Settings.fltbonuv
        FltCBfnr.SelectedIndex = My.Settings.fltbonfnr
        FltCBcnr.SelectedIndex = My.Settings.fltboncnr
        CBfilterdatum.Checked = My.Settings.fltfilterdatum

        'Info
        FillInfo()
        FillInfoRow()

        nofilter = False
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
        Dim count As Integer = 0
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
        If nofilter = True Then Exit Sub
        TBResultTelL.Text = ""
        Dim codrec = From cod In db.CODs
                     Where cod.CNRQ = keycnrq
                     Select cod.Code, cod.OmsCode, cod.Stock, cod.Minstock, cod.Eenhp, cod.Aankp, cod.Plmagazijn, cod.Besteld, cod.notstock, cod.gratis
                     Take 1

        Dim extra As String = ""
        For Each rec In codrec
            TBResultTelL.Text = TBResultTelL.Text & rec.Code & " (" & rec.OmsCode & ")" & Environment.NewLine
            TBResultTelL.Text = TBResultTelL.Text & "Stock: " & rec.Stock & "    Minimum Stock: " & rec.Minstock & "   (" & rec.Plmagazijn & ")"
            TBResultTelL.Text = TBResultTelL.Text & Environment.NewLine & " AP: " & rec.Aankp & "  VP: " & rec.Eenhp
            If rec.gratis = True Then extra = extra & "Gratis "
            If rec.notstock = True Then extra = extra & "Niet_opgenomen_in_Stock "
            If rec.Besteld = True Then extra = extra & "In_Bestelling"
            TBResultTelL.Text = TBResultTelL.Text & Environment.NewLine & extra
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

        'TBresultTELa
        TBResultTelA.BackColor = System.Drawing.SystemColors.ControlLight
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
            Join bon In db.BONs On bonl.BONJR Equals bon.BONJR And bonl.BONNR Equals bon.BONNR
            Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
            Where bonl.BONJR = Fltbonjr.Value _
              And bonl.Datum >= Format(FltDatumvan.Value, "#yyyy-MM-dd 00:00:00.000#") _
              And bonl.Datum < Format(Fltdatumtot.Value, "#yyyy-MM-dd 23:59:59.999#")
            Let Code_ = code.Code & " (" & code.OmsCode & ")"
            Let Werf = bonl.BWStraat & " " & bonl.BWAdres
            Let Totaal = bonl.Aantal * bonl.BONEenhp
            Let Check = bonl.CONTROLEOK
            Select JR = bonl.BONJR, NR = bonl.BONNR, VLNR = bonl.BONLVNR,
                VNR = bonl.Volgorde, Check, SEL = bonl.select, bonl.Datum, bon.OmsBon,
                bon.tbw, bon.vs, bon.gstk, bon.uv, bon.fok, bon.cok, bon.fnr, bon.cnr,
                Groep = codgp.OmsGroep, Code_,
                bonl.memo, klant.KNaam,
                bonl.Aantal, EenhPrijs = bonl.BONEenhp, Totaal, BTW = btw.OmsBTW, btw.BNRQ,
                bonl.PERNM, bonl.OAANMNM,
                Werf,
                bonl.CNRQ, code.KMHEFFING
        Else
            records =
                From bonl In db.BONLs
                Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
                Join bon In db.BONs On bonl.BONJR Equals bon.BONJR And bonl.BONNR Equals bon.BONNR
                Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                Where bonl.BONJR = Fltbonjr.Value
                Let Code_ = code.Code & " (" & code.OmsCode & ")"
                Let Werf = bonl.BWStraat & " " & bonl.BWAdres
                Let Totaal = bonl.Aantal * bonl.BONEenhp
                Let Check = bonl.CONTROLEOK
                Select JR = bonl.BONJR, NR = bonl.BONNR, VLNR = bonl.BONLVNR,
                    VNR = bonl.Volgorde, Check, SEL = bonl.select, bonl.Datum, bon.OmsBon,
                    bon.tbw, bon.vs, bon.gstk, bon.uv, bon.fok, bon.cok, bon.fnr, bon.cnr,
                    Groep = codgp.OmsGroep, Code_,
                    bonl.memo, klant.KNaam,
                    bonl.Aantal, EenhPrijs = bonl.BONEenhp, Totaal, BTW = btw.OmsBTW, btw.BNRQ,
                    bonl.PERNM, bonl.OAANMNM,
                    Werf,
                    bonl.CNRQ, code.KMHEFFING
        End If

        DGFILTER()
        Me.DGREC.DataSource = records

        If Me.ordDGREC = Nothing Then ordDGREC = "Datum"
        Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Descending)

        fndarr = GetSELBonlFigures(DGREC, keybonjr, keybonnr).split("#")
        TBResultTelB.BackColor = System.Drawing.SystemColors.ControlLight
        If fndarr(0) = "Y" Then
            TBResultTelB.BackColor = Color.FromArgb(255, 192, 192)
        End If
        TBResultTelB.Text = fndarr(1)

        'set decimals
        DGREC.Columns("Totaal").DefaultCellStyle.Format = "N2"

        'set invisible
        Dim dginvisible = New String() {"VLNR", "CNRQ", "BNRQ", "fok", "cok", "tbw", "vs", "gstk", "uv", "KMHEFFING"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        DGREC.Columns("Code_").HeaderText = "Code - Omschrijving"
        DGREC.Columns("Datum").HeaderText = "StartDatum"
        DGREC.Columns("PERNM").HeaderText = "Personeel"
        DGREC.Columns("OAANMNM").HeaderText = "OnderaanNm"
        ''set autosizemode
        'Dim dgautoss = New String() {"omstijd"}
        'For index = 0 To dgautoss.GetUpperBound(0)
        ' DGREC.Columns(dgautoss(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ' Next index
        Dim dgautos = New String() {"JR", "memo"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautod = New String() {"Groep"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautoh = New String() {"NR", "Code_", "OmsBon", "fnr", "cnr", "Check", "SEL", "Totaal", "BTW", "VNR", "PERNM", "OAANMNM", "EenhPrijs", "Aantal", "Datum", "KNaam"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        DGREC.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If DGREC.RowCount < 1 Then
            keybonlvnr = 0
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keybonlvnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keybonjr = DGREC.CurrentRow.Cells("JR").Value
        keybonnr = DGREC.CurrentRow.Cells("NR").Value
        keybonlvnr = DGREC.CurrentRow.Cells("VLNR").Value
        keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value

        'BGE
        BewerkToolStripMenuItem.Enabled = True
        NieuwToolStripMenuItem.Enabled = True
        TSBedit.Enabled = True
        TSBnew.Enabled = True
        If (DGREC.CurrentRow.Cells("fnr").Value <> 0) Or (DGREC.CurrentRow.Cells("cnr").Value <> 0) Then
            BewerkToolStripMenuItem.Enabled = False
            NieuwToolStripMenuItem.Enabled = False
            TSBedit.Enabled = False
            TSBnew.Enabled = False
        End If

        FillInfoRow()
        FillInfo()

NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            keybonjr = DGREC.CurrentRow.Cells("JR").Value
            keybonnr = DGREC.CurrentRow.Cells("NR").Value
            keybonlvnr = DGREC.CurrentRow.Cells("VLNR").Value
            keycnrq = DGREC.CurrentRow.Cells("CNRQ").Value
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.CellMouseDoubleClick
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
        If keybonnr < 1 Then
            MsgBox("Geen bonlijn beschikbaar om te bewerken.")
            Exit Sub
        End If
        Editbonl.ShowDialog()

        Refresh_data()
        FillInfo()
        FillInfoRow()
    End Sub

    Private Sub UpdateRecBON()
        If keybonjr < 1 Then
            MsgBox("Geen bon beschikbaar om te bewerken.")
            Exit Sub
        End If
        Editbon.ShowDialog()

        Refresh_data()
        FillInfo()
        FillInfoRow()
    End Sub

    Private Sub DeleteRec()
        If keybonnr < 1 Then
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
        Next
        nofilter = False
        GroepeerALLEBonlijnenToolStripMenuItem.Enabled = False
        GroepsbewerkingToolStripMenuItem.Enabled = False
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

    Private Sub BewerkBONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkBONToolStripMenuItem.Click
        UpdateRecBON()
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
        Refresh_data()
        FillInfo()
        FillInfoRow()
        If resetbonlselect = True Then ResetSelect()
        nofilter = False
    End Sub

    Private Sub GroepeerALLEBonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroepeerALLEBonlijnenToolStripMenuItem.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If GroupBONL() <> "OK" Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Groepering niet gelukt!")
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
    Private Sub ResetSelect()
        Dim skeybonlvnr As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Me.DGREC.RowCount < 1 Then Exit Sub
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

    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        If Fltnr.Text <> "" And IsNumeric(Fltnr.Text) Then
            records = records.Where("NR == " & Fltnr.Text)
            Exit Sub
        End If

        records = records.Where("BTW.Contains(@0)", Fltbtw.Text)
        records = records.Where("OmsBon.Contains(@0)", Fltwerfb.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        records = records.Where("Groep.Contains(@0)", FltOmsgroep.Text)
        records = records.Where("Code_.Contains(@0)", FltCode.Text)
        records = records.Where("pernm.Contains(@0)", Fltpernm.Text)
        records = records.Where("oaanmnm.Contains(@0)", Fltoaanmnm.Text)

        If Fltklant.Text.StartsWith("*") Then
            records = records.Where("KNaam.Contains(@0)", Fltklant.Text.Remove(0, 1))
        Else
            records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        End If

        Select Case FltCBselect.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("SEL == " & chval)
        Select Case FltCBtbw.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("tbw == " & chval)
        Select Case FltCBvs.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("vs == " & chval)
        Select Case FltCBgst.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("gstk == " & chval)
        Select Case FltCBcontroleok.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("Check == " & chval)
        Select Case FltCBuv.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("uv == " & chval)
        Select Case FltCBfnr.SelectedItem
            Case "Aan"
                records = records.Where("fnr <> 0")
            Case "Uit"
                records = records.Where("fnr == 0")
            Case Else
        End Select
        Select Case FltCBcnr.SelectedItem
            Case "Aan"
                records = records.Where("cnr <> 0")
            Case "Uit"
                records = records.Where("cnr == 0")
            Case Else
        End Select

    End Sub

    Private Sub Fltwerf_TextChanged_1(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltbtw_TextChanged(sender As Object, e As EventArgs) Handles Fltbtw.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBselect.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub FltCBcontroleok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBcontroleok.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltOmsgroep_TextChanged(sender As Object, e As EventArgs) Handles FltOmsgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCode_TextChanged(sender As Object, e As EventArgs) Handles FltCode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltpernm_TextChanged(sender As Object, e As EventArgs) Handles Fltpernm.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltoaanmnm_TextChanged(sender As Object, e As EventArgs) Handles Fltoaanmnm.TextChanged
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

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        keybonjr = Fltbonjr.Value
        'My.Settings.fltbonjr = Fltbonjr.Value
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBtbw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBtbw.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBvs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBvs.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBgst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBgst.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBuv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBuv.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBfnr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBfnr.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltCBcnr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBcnr.SelectedIndexChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnr_TextChanged(sender As Object, e As EventArgs) Handles Fltnr.TextChanged
        If Fltnr.Text <> "" Then
            GroepeerALLEBonlijnenToolStripMenuItem.Enabled = True
            GroepsbewerkingToolStripMenuItem.Enabled = True
        Else
            GroepeerALLEBonlijnenToolStripMenuItem.Enabled = False
            GroepsbewerkingToolStripMenuItem.Enabled = False
        End If
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltwerfb_TextChanged(sender As Object, e As EventArgs) Handles Fltwerfb.TextChanged
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


End Class