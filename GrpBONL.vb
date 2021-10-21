Imports System.Linq.Dynamic

Public Class GrpBONL
    Dim nofilter As Boolean = True

    Private Sub GrpBONL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()

        FillCMBbtw(CMBbtw)
        FillCMBdies(CMBdies)
        FillCMBper(CMBper)
        Fltbonjr.Value = My.Settings.fltbonjr

        For Each a In GroupBox1.Controls
            If TypeOf a Is CheckBox Then
                a.checked = False
            End If
        Next

        nofilter = False
        Fill_DGREC()
        Fill_DGBON()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
        SetGridRows(DGBON)
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        records =
            From bonl In db.BONLs
            Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
            Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
            Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
            Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.select = True
            Let Code_ = code.Code & " (" & code.OmsCode & ")"
            Let Werf = bonl.BWStraat & " " & bonl.BWAdres
            Let Wie = bonl.usernrq & " (" & bonl.chdate & ")"
            Select JR = bonl.BONJR, NR = bonl.BONNR, VLNR = bonl.BONLVNR,
                VNR = bonl.Volgorde, SEL = bonl.select, bonl.Datum,
                Groep = codgp.OmsGroep, Code_,
                bonl.memo,
                Dies = bonl.diesel, bonl.Aantal, EenhPrijs = bonl.BONEenhp, BTW = btw.OmsBTW,
                bonl.PERNM, bonl.OAANMNM,
                BonNR = bonl.EXTNR,
                Werf, Wie,
                bonl.CNRQ


        records = records.OrderBy("VNR", SortOrder.Ascending = True)
        'DGFILTER()
        Me.DGREC.DataSource = records
        Me.Text = "Groepsbeheer BonLijnen " & keybonjr & "/" & keybonnr & ".  Aantal geselecteerde lijnen: " & records.Count

        'set invisible
        Dim dginvisible = New String() {"JR", "NR", "VLNR", "CNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        DGREC.Columns("Code_").HeaderText = "Code"
        DGREC.Columns("Dies").HeaderText = "Dies%"
        DGREC.Columns("Datum").HeaderText = "StartDatum"
        DGREC.Columns("PERNM").HeaderText = "Personeel"
        DGREC.Columns("OAANMNM").HeaderText = "OnderaanNm"
        'set autosizemode
        Dim dgautos = New String() {"Code_", "Wie", "memo"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautod = New String() {"Groep"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        Dim dgautoh = New String() {"SEL", "BTW", "Dies", "BonNR", "VNR", "PERNM", "OAANMNM", "EenhPrijs", "Aantal", "Datum"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGREC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        DGREC.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If DGREC.RowCount < 1 Then
            keybonlvnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Fill_DGBON()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        bonrecs =
                From bon In db.BONs
                Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                Where bon.BONJR = Fltbonjr.Value
                Select JR = bon.BONJR, NR = bon.BONNR,
                    bon.KNRQ,
                    bon.DatumAanvang, klant.KNaam, bon.OmsBon

        bonrecs = bonrecs.OrderBy("KNaam", SortOrder.Ascending = True)
        ' DGFILTER()

        hkey = keybonjr
        hkey2 = keybonnr
        Me.DGBON.DataSource = bonrecs
        keybonjr = hkey
        keybonnr = hkey2

        'set invisible
        Dim dginvisible = New String() {"KNRQ", "JR"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGBON.Columns(dginvisible(index)).Visible = False
        Next
        'set autosizemode
        Dim dgautos = New String() {"KNaam", "NR", "DatumAanvang"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGBON.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index

        DGBON.Columns("OmsBon").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        If DGBON.RowCount < 1 Then
            tokeybonjr = Fltbonjr.Value
            tokeybonnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub DGFILTER()
        records = records.Where("KNaam.Contains(@0)", Fltklant.Text)
        records = records.Where("OmsBon.Contains(@0)", Fltwerf.Text)
    End Sub

    Private Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        If nofilter = False Then Fill_DGBON()
    End Sub

    Private Sub Fltwerf_TextChanged(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGBON()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        If nofilter = False Then Fill_DGBON()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If MsgBox("Alle aanpassingen toepassen op onderstaande BonLijnen?", MsgBoxStyle.YesNo, "Aanpassing bonlijnen") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If UpdateBonL(keybonjr, keybonnr) = False Then
            MsgBox("Aanpassingen niet gelukt!")
        Else
            Me.Close()
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBverplaats_Click(sender As Object, e As EventArgs) Handles TSBverplaats.Click
        If tokeybonnr = 0 Then
            MsgBox("Selecteer een bestemming: Bonjaar/Bonnummer!")
            Exit Sub
        End If
        Dim tocopy = MsgBox("Wil je onderstaande bonlijnen kopiëren naar " & tokeybonjr & "/" & tokeybonnr & "?", MsgBoxStyle.YesNo, "Kopiëren BonLijnen")
        If tocopy = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim alsodelete As Boolean = False
        Dim todelete = MsgBox("Wil je de bonlijnen na verplaatsen ook verwijderen?", MsgBoxStyle.YesNoCancel, "Verwijder bonlijnen")
        If todelete = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        If todelete = MsgBoxResult.Yes Then
            alsodelete = True
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        CopyBONL(keybonjr, keybonnr, tokeybonjr, tokeybonnr)
        If alsodelete = True Then DelBONLsel(keybonjr, keybonnr)
        keybonjr = tokeybonjr
        keybonnr = tokeybonnr
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        If MsgBox("Wil je onderstaande bonlijnen echt verwijderen?", MsgBoxStyle.YesNoCancel, "Verwijder bonlijnen") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DelBONLsel(keybonjr, keybonnr)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGBON_SelectionChanged(sender As Object, e As EventArgs) Handles DGBON.SelectionChanged
        tokeybonnr = 0
        On Error GoTo NoRecords
        tokeybonjr = DGBON.CurrentRow.Cells("JR").Value
        tokeybonnr = DGBON.CurrentRow.Cells("NR").Value

NoRecords:
    End Sub

    '****Functions
    Private Function UpdateBonL(kjr As Integer, knr As Integer) As Boolean
        If CBbtw.Checked = False And CBdatum.Checked = False And CBdiesel.Checked = False And CBlevering.Checked = False And CBpersoneel.Checked = False And CBprijs.Checked = False Then
            MsgBox("Selecteer minstens 1 aanpassing!")
            Return False
        End If
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
        End If
        Dim strselected As String
        For Each row As DataGridViewRow In Me.DGREC.Rows
            keybonlvnr = row.Cells("VLNR").Value
            Dim updaterec = (From bonl In db.BONLs
                             Where bonl.BONJR = kjr AndAlso bonl.BONNR = knr AndAlso bonl.BONLVNR = keybonlvnr).ToList()(0)
            With updaterec
                If CBbtw.Checked = True Then .BNRQ = CMBbtw.SelectedValue
                If CBdatum.Checked = True Then .Datum = DTPdatum.Value
                If CBprijs.Checked = True Then .BONEenhp = TBboneenhp.Text
                If CBdiesel.Checked = True Then
                    strselected = CMBdies.SelectedValue.ToString
                    If strselected = "" Then strselected = 0
                    .diesel = strselected
                End If
                If CBpersoneel.Checked = True Then .PERNM = CMBper.SelectedValue.ToString
                If CBlevering.Checked = True Then .levering = CBleveringf.Checked

                .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
                .usernrq = LoginNm
            End With

            Try
                db.SubmitChanges()
                Dim key = keybonjr & "/" & keybonnr.ToString("0000")
                Archive("BONL_U", key, "Groepsbewerking!")
            Catch
                'PositionMsgbox.CenterMsgBox(Me)
                'MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
                Return False
            End Try
        Next
        Return True
    End Function

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0
        TBboneenhp.BackColor=boxcolor
        If CBprijs.Checked = True Then
            If Not IsNumeric(TBboneenhp.Text) Then
                TBboneenhp.BackColor = boxcolorerror
                AllOK = False
            End If
        End If

        Return AllOK
    End Function
End Class