Imports System.ComponentModel

Public Class Editbonl
    Dim nocmdupd As Boolean = False
    Dim NotSaved As Boolean = True

    Private Sub Editbonl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then
            Me.Text = "Bon: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If
        FillCMBbtw(CMBbtw)
        FillCMBdies(CMBdies)
        FillCMBper(CMBper)
        FillCMBoaanmnm(CMBoaanm)

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub

    Private Sub Editbonl_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        If NotSaved = True Then
            If MessageBox.Show("Niet opgeslagen, toch afsluiten?", "Bewerk Bonlijn", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Editbonl_Closed(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
            MsgBox("Probleem met sleutels: .." & keybonjr & "../.." & keybonnr & ".._.." & keybonlvnr)
            Close()
        End Try

    End Sub

    '****FIELDActions
    Private Function Savedata() As Boolean
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
        End If
        ' zorgt ervoor dat je de vraag "toch afsluiten" niet krijgt!!!
        NotSaved = False

        If IsNewRecord = True Then
            SaveNEW()
            Return True
            Exit Function
        End If

        Dim updaterec = (From bonl In db.BONLs
                         Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.BONLVNR = keybonlvnr).ToList()(0)

        With updaterec
            If TBvolgorde.Text = "" Then TBvolgorde.Text = updaterec.BONLVNR
            .Volgorde = TBvolgorde.Text
            .Datum = DTPdatum.Value
            .BWStraat = TBbwstraat.Text
            .BWAdres = TBbwadres.Text
            .Aantal = TBaantal.Text
            .BONEenhp = TBboneenhp.Text
            .BONEenhpbu = TBboneenhp.Text
            .select = CBselect.Checked
            .levering = CBlevering.Checked
            .diesel = TBdiesel.Text
            .omstijd = TimeStr
            .EXTNR = TBextnr.Text
            .DNRQ = 0
            .ANRQ = 0
            .memo = TBmemo.Text
            .PERNM = TBpernm.Text
            .OAANMNM = TBoaanmnm.Text

            .BNRQ = CMBbtw.SelectedValue
            .CNRQ = keycnrq

            .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
            .usernrq = LoginNm
        End With

        Try
            db.SubmitChanges()
            Dim key = keybonjr & "/" & keybonnr.ToString("0000")
            Archive("BONL_U", key, TBmemo.Text)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        If keyknrq = 0 Then keyknrq = 1
        Dim newbonlvnr = GetHighBonLVNR(keybonjr, keybonnr)
        If TBvolgorde.Text = "" Then TBvolgorde.Text = newbonlvnr
        If TBdiesel.Text = "" Then TBdiesel.Text = 0

        Dim newrec As New BONL With {
                .BONJR = keybonjr,
                .BONNR = keybonnr,
                .BONLVNR = newbonlvnr,
                .Volgorde = TBvolgorde.Text,
                .Datum = DTPdatum.Value,
                .BWStraat = TBbwstraat.Text,
                .BWAdres = TBbwadres.Text,
                .Aantal = TBaantal.Text,
                .BONEenhp = TBboneenhp.Text,
                .BONEenhpbu = TBboneenhp.Text,
                .select = CBselect.Checked,
                .levering = CBlevering.Checked,
                .diesel = TBdiesel.Text,
                .omstijd = TimeStr,
                .EXTNR = TBextnr.Text,
                .DNRQ = 0,
                .memo = TBmemo.Text,
                .PERNM = TBpernm.Text,
                .OAANMNM = TBoaanmnm.Text,
                .BNRQ = CMBbtw.SelectedValue,
                .CNRQ = keycnrq,
                .ANRQ = 0,
                .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                .usernrq = LoginNm,
                .usercre = LoginNm,
                .datecre = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
            }

        db.BONLs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.  Probeer opnieuw.")
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

        If TBdiesel.Text = "" Then TBdiesel.Text = 0

        Dim TBNum() As TextBox = New TextBox() {TBvolgorde, TBdiesel}
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
        TBaantal.Text = 1
        TBboneenhp.Text = 0
        CBselect.Checked = False
        CBlevering.Checked = False
        TBdiesel.Text = ""
        TBextnr.Text = ""
        TBmemo.Text = ""
        TBpernm.Text = ""
        TBoaanmnm.Text = ""
        CMBbtw.SelectedIndex = 1
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
                Else
                    DTPdatum.Value = rec.datum
                End If
                If IsNewRecord = False Then TBvolgorde.Text = rec.volgorde
                TBbwstraat.Text = rec.bwstraat
                TBbwadres.Text = rec.bwadres
                TBaantal.Text = rec.aantal
                TBboneenhp.Text = rec.boneenhp
                CBselect.Checked = rec.select
                CBlevering.Checked = rec.levering
                TBdiesel.Text = rec.diesel
                TBextnr.Text = rec.extnr
                TBmemo.Text = rec.memo
                TBpernm.Text = rec.pernm
                TBoaanmnm.Text = rec.oaanmnm
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

    Private Sub zoekCode_Click(sender As Object, e As EventArgs) Handles ZoekCode.Click
        SelCGNRQ = keycgnrq
        SearchCode.ShowDialog()
        SelCGNRQ = 0
        setcode(keycnrq)
        fillDisplay()
    End Sub

    '****Functions
    Private Sub fillDisplay()
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

    Private Sub setcode(key As Integer)
        Dim valcode As String
        valcode = Getvalcode(key)
        lblCODEinfo.Text = valcode

        'préfill db-data
        codrecs = From cod In db.CODs
                  Where cod.CNRQ = key
                  Select cod.Eenhp, cod.Aankp, cod.PERNM, cod.OAANMNM

        For Each codrec In codrecs
            TBboneenhp.Text = codrec.Eenhp
            TBpernm.Text = codrec.PERNM
            TBoaanmnm.Text = codrec.OAANMNM
        Next
    End Sub

    '****COMBO's
    Private Sub CMBper_SelectedIndexChanged(sender As Object, e As EventArgs) 
        TBpernm.Text = CMBper.SelectedValue.ToString
    End Sub

    Private Sub CMBoaanm_SelectedIndexChanged(sender As Object, e As EventArgs) 
        TBoaanmnm.Text = CMBoaanm.SelectedValue.ToString
    End Sub

    Private Sub CMBdies_SelectedIndexChanged(sender As Object, e As EventArgs) 
        TBdiesel.Text = CMBdies.SelectedValue.ToString
    End Sub

    Private Sub BTNtijd_Click(sender As Object, e As EventArgs) Handles BTNtijd.Click
        GetTime.StartPosition = FormStartPosition.CenterParent
        GetTime.ShowDialog()
        TBaantal.Text = TimeVal
    End Sub
End Class