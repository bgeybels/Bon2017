Imports System.ComponentModel

Public Class Editbonl
    Dim nocmdupd As Boolean = True
    Dim NotSaved As Boolean = True
    Dim apcod As Double = 0

    Private Sub Editbonl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Bonlijn: Bewerken (Key=" & keybonjr & "/" & keybonnr & "-" & keybonlvnr & ")"
        If IsNewRecord = True Then
            Me.Text = "Bonlijn: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If

        FillCMBbtw(CMBbtw)
        FillCMBper(CMBper)
        FillCMBlev(CMBlev)
        FillCMBoaanmnm(CMBoaanm)
        ZoekCodeIM.Text = ""

        NotSaved = True
        Fill_DG()
        Velden_vullen()
        nocmdupd = False
        TBextnr.Focus()
    End Sub

    Private Sub Editbonl_MenuStart(sender As Object, e As EventArgs) Handles Me.MenuStart
        TBaantal.Focus()
    End Sub

    Private Sub Editbonl_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        If NotSaved = True Then
            If LoginNm <> "SYSTEM" And LoginNm <> "bge" Then
                If MessageBox.Show("Niet opgeslagen, toch afsluiten?", "Bewerk Bonlijn", MessageBoxButtons.YesNo) = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub Editbonl_Closed(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewRecord = False Then
            Dim strkey As String = keybonjr & keybonnr & keybonlvnr
            Dim unlock = unlockrec("BONL", strkey)
        End If

        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From bonl In db.BONLs
                      Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = keybonlvnr
                      Take 1
        Catch ex As Exception
            MsgBox("Probleem met sleutels: .." & keybonjr & "../.." & keybonnr & ".._.." & keybonlvnr & " --> " & ex.Message)
            Close()
        End Try

    End Sub

    '****FIELDActions

    Private Function update_bon()
        Dim updatebon = (From bon In db.BONs
                         Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr).ToList()(0)

        updatebon.usernrq = LoginNm
        'updatebon.chdate = ChDate
        updatebon.chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try
        Return True
    End Function


    Private Function Savedata() As Boolean
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
        End If
        ' zorgt ervoor dat je de vraag "toch afsluiten" niet krijgt!!!
        NotSaved = False

        update_bon()
        If IsNewRecord = True Then
            SaveNEW()
            Return True
            Exit Function
        End If

        Dim updaterec = (From bonl In db.BONLs
                         Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = keybonlvnr).ToList()(0)

        If updatestock = True Then
            UpdateOk = StockUpdate("U", keycnrq, keybonjr, keybonnr, keybonlvnr, TBaantal.Text)
            If updateOK <> "" Then MsgBox(updateOK)
        End If
        With updaterec
            If TBvolgorde.Text = "" Then TBvolgorde.Text = updaterec.BONLVNR
            .Volgorde = TBvolgorde.Text
            .Datum = Format(DTPdatum.Value, "#yyyy-MM-dd#")
            .BLSORT = .Datum.ToString("yyyyMMdd") & "-" & .Volgorde.ToString("D4")

            .BWStraat = TBbwstraat.Text
            .BWAdres = TBbwadres.Text
            .Aantal = TBaantal.Text
            .BONEenhp = TBboneenhp.Text
            .ap = apcod
            .BONEenhpbu = TBboneenhp.Text
            .select = CBselect.Checked
            .levering = 0
            .diesel = 0
            .omstijd = Lblomstijd.Text
            .EXTNR = TBextnr.Text
            .DNRQ = 0
            .ANRQ = 0
            .memo = TBmemo.Text
            .PERNM = TBpernm.Text
            .OAANMNM = TBoaanmnm.Text
            .LEVNM = TBlevnm.Text

            .BNRQ = CMBbtw.SelectedValue
            .CNRQ = keycnrq

            .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
            .usernrq = LoginNm
            'MsgBox("datum: " & Format(DTPdatum.Value, "#yyyy-MM-dd#"))
            'MsgBox("datum: " & ChDate & " " & DateTime.Now.ToString("HH:mm:ss"))
        End With

        Try
            db.SubmitChanges()
            Dim key = keybonjr & "/" & keybonnr.ToString("0000")
            Archive("BONL_U", key, TBmemo.Text)

        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        If keyknrq = 0 Then keyknrq = 1
        Dim newbonlvnr = GetHighBonLVNR(keybonjr, keybonnr)
        If TBvolgorde.Text = "" Then TBvolgorde.Text = newbonlvnr

        Dim newrec As New BONL With {
                .BONJR = keybonjr,
                .BONNR = keybonnr,
                .BONLVNR = newbonlvnr,
                .Volgorde = TBvolgorde.Text,
                .Datum = DTPdatum.Value,
                .BLSORT = .Datum.ToString("yyyyMMdd") & "-" & .Volgorde.ToString("D4"),
                .BWStraat = TBbwstraat.Text,
                .BWAdres = TBbwadres.Text,
                .Aantal = TBaantal.Text,
                .BONEenhp = TBboneenhp.Text,
                .AP = apcod,
                .BONEenhpbu = TBboneenhp.Text,
                .select = CBselect.Checked,
                .levering = 0,
                .CONTROLEOK = 0,
                .diesel = 0,
                .omstijd = Lblomstijd.Text,
                .EXTNR = TBextnr.Text,
                .DNRQ = 0,
                .memo = TBmemo.Text,
                .PERNM = TBpernm.Text,
                .OAANMNM = TBoaanmnm.Text,
                .LEVNM = TBlevnm.Text,
                .BNRQ = CMBbtw.SelectedValue,
                .CNRQ = keycnrq,
                .ANRQ = 0,
                .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                .usernrq = LoginNm,
                .usercre = LoginNm,
                .datecre = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
            }

        db.BONLs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
            If updatestock = True Then
                UpdateOk = StockUpdate("N", keycnrq, keybonjr, keybonnr, newbonlvnr, TBaantal.Text)
                If updateOK <> "" Then MsgBox(updateOK)
            End If
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keybonjr = newrec.BONJR
        keybonnr = newrec.BONNR
        keybonlvnr = newrec.BONLVNR
        Dim key = keybonjr & "/" & keybonnr.ToString("0000") & "_" & keybonlvnr.ToString("0000")
        Archive("BONL_N", key, "")
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0

        TBextnr.BackColor = boxcolor
        If Len(TBextnr.Text) > 10 Then
            AllOK = False
            TBextnr.BackColor = boxcolorerror
        End If

        Dim TBNum() As TextBox = New TextBox() {TBvolgorde}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) And Not TB.Text = "" Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next
        Dim TBNumN() As TextBox = New TextBox() {TBaantal, TBboneenhp}
        For Each TB As TextBox In TBNumN
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        keycnrq = 0
        keycgnrq = 0
        DTPdatum.Value = SysDate
        TBvolgorde.Text = GetHighBonLVNR(keybonjr, keybonnr)
        TBbwstraat.Text = ""
        TBbwadres.Text = ""
        TBaantal.Text = 0
        Lblomstijd.Text = ""
        TBboneenhp.Text = 0
        CBselect.Checked = False
        TBextnr.Text = ""
        TBmemo.Text = ""
        TBpernm.Text = ""
        TBoaanmnm.Text = ""
        TBlevnm.Text = ""
        CMBbtw.SelectedIndex = 0
        Try
            For Each rec In records
                keycnrq = rec.cnrq
                setcode(keycnrq)

                searchrecs = From cod In db.CODs
                             Where cod.CNRQ = keycnrq
                             Select cod.CGNRQ, cod.Code
                             Take 1
                For Each srec In searchrecs
                    keycgnrq = srec.CGNRQ
                Next

                If IsNewRecord = True Then
                    DTPdatum.Value = SysDate
                    Lblomstijd.Text = ""
                    TBextnr.Text = ""
                    TBbwstraat.Text = ""
                    TBbwadres.Text = ""
                    TBpernm.Text = rec.pernm
                    TBoaanmnm.Text = rec.oaanmnm
                    TBlevnm.Text = rec.levnm
                    TBbwstraat.Text = ""
                    TBbwadres.Text = ""
                    TBmemo.Text = ""

                    Dim newbonlvolgorde = GetHighBonLVolgorde(keybonjr, keybonnr)
                    TBvolgorde.Text = newbonlvolgorde
                Else
                    DTPdatum.Value = rec.datum
                    TBvolgorde.Text = rec.volgorde
                    TBaantal.Text = rec.aantal
                    Lblomstijd.Text = rec.omstijd
                    TBextnr.Text = rec.extnr
                    TBpernm.Text = rec.pernm
                    TBoaanmnm.Text = rec.oaanmnm
                    TBlevnm.Text = rec.levnm
                    TBbwstraat.Text = rec.bwstraat
                    TBbwadres.Text = rec.bwadres
                    TBmemo.Text = rec.memo
                End If

                TBboneenhp.Text = rec.boneenhp
                CBselect.Checked = rec.select
                CMBbtw.SelectedValue = rec.bnrq

            Next
        Catch ex As Exception

        End Try
        fillDisplay()

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If keycnrq < 1 Then
            MsgBox("Selecteer een geldige code voor deze BonLijn!")
            Exit Sub
        End If
        If Savedata() = True Then Close()
    End Sub

    Private Sub ZoekCode_Click(sender As Object, e As EventArgs) Handles ZoekCode.Click
        SelCGNRQ = keycgnrq
        frompopup = True
        filtercode = ZoekCodeIM.Text
        codfrombon = True
        SearchCode.ShowDialog()
        codfrombon = False
        filtercode = ""
        frompopup = False
        SelCGNRQ = 0
        setcode(keycnrq)
        fillDisplay()
    End Sub

    '****Functions
    Private Sub FillDisplay()
        LBLbonlinfo.Text = ""
        Dim klantrec = From bon In db.BONs
                       Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                       Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr
                       Select klant.KNaam, bon.BONJR
        For Each klantr In klantrec
            If IsNewRecord = True Then
                LBLbonlinfo.Text = keybonjr & "/" & keybonnr.ToString("0000") & "_... (" & klantr.KNaam & ")"
            Else
                LBLbonlinfo.Text = keybonjr & "/" & keybonnr.ToString("0000") & "_" & keybonlvnr.ToString("0000") & " (" & klantr.KNaam & ")"
            End If
        Next

        LBLaoms.Text = ""
        Dim aomsrec = From cod In db.CODs
                      Join aoms In db.AOms On cod.ANRQ Equals aoms.ANRQ
                      Where cod.CNRQ = keycnrq
                      Let volume = aoms.Oms
                      Select volume, cod.Code
        For Each volrec In aomsrec
            LBLaoms.Text = volrec.volume
        Next
    End Sub

    Private Sub Setcode(key As Integer)
        Dim valcode As String
        valcode = Getvalcode(key)
        lblCODEinfo.Text = valcode

        'préfill db-data
        codrecs = From cod In db.CODs
                  Where cod.CNRQ = key
                  Select cod.Eenhp, cod.Aankp, cod.PERNM, cod.OAANMNM, cod.LEV

        For Each codrec In codrecs
            TBboneenhp.Text = codrec.Eenhp
            apcod = codrec.Aankp
            TBpernm.Text = codrec.PERNM
            TBoaanmnm.Text = codrec.OAANMNM
            TBlevnm.Text = codrec.LEV
        Next
    End Sub

    '****COMBO's
    Private Sub CMBper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBper.SelectedIndexChanged
        TBpernm.Text = CMBper.SelectedValue.ToString
        TBoaanmnm.Text = ""
    End Sub

    Private Sub CMBlev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBlev.SelectedIndexChanged
        TBlevnm.Text = CMBlev.SelectedValue.ToString
    End Sub

    Private Sub CMBoaanm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBoaanm.SelectedIndexChanged
        TBoaanmnm.Text = CMBoaanm.SelectedValue.ToString
        TBpernm.Text = ""
    End Sub

    Private Sub BTNtijd_Click(sender As Object, e As EventArgs) Handles BTNtijd.Click
        TimeVal = Lblomstijd.Text
        GetTime.StartPosition = FormStartPosition.CenterParent
        GetTime.ShowDialog()
        If TimeVal <> "" Then
            TBaantal.Text = TimeVal
            Lblomstijd.Text = TimeStr
        End If
        'If TimeString <> "" Then xyz = 1
    End Sub

    Private Sub TBaantal_TextChanged(sender As Object, e As EventArgs) Handles TBaantal.TextChanged
        Lblomstijd.Text = ""
    End Sub

    Private Sub ZoekCodeIM_TextChanged(sender As Object, e As EventArgs) Handles ZoekCodeIM.TextChanged
        Dim sfound As Integer = 0
        If ZoekCodeIM.Text = "" Then Exit Sub

        SelCGNRQ = keycgnrq
        sfound = 0
        Dim codrecs = From cod In db.CODs
                      Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                      Where cod.Code.StartsWith(ZoekCodeIM.Text) And codgp.INRESULT = True
                      Order By cod.Code Ascending
                      Select cod.CNRQ, cod.Code

        For Each codrec In codrecs
            If sfound = 0 Then
                sfound = codrec.CNRQ
            Else
                Exit For
            End If
        Next
        If sfound = 0 Then
            Dim codrecsd = From cod In db.CODs
                           Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                           Where cod.Code.StartsWith(ZoekCodeIM.Text)
                           Order By cod.Code Ascending
                           Select cod.CNRQ, cod.Code
            For Each codrec In codrecsd
                If sfound = 0 Then
                    sfound = codrec.CNRQ
                Else
                    Exit For
                End If
            Next

        End If
        keycnrq = sfound
        SelCGNRQ = 0
        Setcode(keycnrq)
        FillDisplay()
    End Sub

    Private Sub BewerkCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkCodeToolStripMenuItem.Click
        EditCode.ShowDialog()
        Setcode(keycnrq)
        FillDisplay()
    End Sub

    Private Sub BewerkPersoneelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkPersoneelToolStripMenuItem.Click
        SearchPER.ShowDialog()
        FillCMBper(CMBper)
        'FillCMBoaanmnm(CMBoaanm)
    End Sub

    Private Sub BTWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTWToolStripMenuItem.Click
        SearchBTW.ShowDialog()
        FillCMBbtw(CMBbtw)
    End Sub

    Private Sub OnderaannemerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnderaannemerToolStripMenuItem.Click
        SearchOaanm.ShowDialog()
        FillCMBoaanmnm(CMBoaanm)
    End Sub

    Private Sub LeverancierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeverancierToolStripMenuItem.Click
        SearchLEV.ShowDialog()
        FillCMBlev(CMBlev)
    End Sub

    Private Sub lblCODEinfo_Click(sender As Object, e As EventArgs) Handles lblCODEinfo.Click

    End Sub


End Class