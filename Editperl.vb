Imports System.ComponentModel

Public Class Editperl
    Dim nocmdupd As Boolean = True
    Dim NotSaved As Boolean = True

    Private Sub Editbonl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Personeelslijn: Bewerken (Key=" & keypernrq & "-" & keypervnr & ")"
        If IsNewRecord = True Then
            Me.Text = "Personeelslijn: Nieuw"
        End If

        ZoekCodeIM.Text = ""

        NotSaved = True
        Fill_DG()
        Velden_vullen()
        nocmdupd = False
    End Sub

    Private Sub Editbonl_MenuStart(sender As Object, e As EventArgs) Handles Me.MenuStart
        TBaantal.Focus()
    End Sub

    Private Sub Editbonl_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        If NotSaved = True Then
            If LoginNm <> "SYSTEM" And LoginNm <> "bge" Then
                If MessageBox.Show("Niet opgeslagen, toch afsluiten?", "Bewerk PERlijn", MessageBoxButtons.YesNo) = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub Editbonl_Closed(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewRecord = False Then
            Dim strkey As String = keypernrq & keypervnr
            Dim unlock = unlockrec("PERL", strkey)
        End If

        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From perl In db.PERLs
                      Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr
                      Take 1
        Catch ex As Exception
            MsgBox("Probleem met sleutels: .." & keypernrq & "../.." & keypervnr & " --> " & ex.Message)
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

        Dim updaterec = (From perl In db.PERLs
                         Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr).ToList()(0)

        If updatestock = True Then
            updateOK = ""
            updateOK = StockUpdatePer("U", keycnrq, keypernrq, keypervnr, TBaantal.Text)
            If updateOK <> "" Then MsgBox(updateOK)
        End If
        With updaterec
            .STARTDATE = Format(DTPstartdate.Value, "#yyyy-MM-dd#")
            .AANTAL = TBaantal.Text
            .SELREC = CBselrec.Checked
            .INBEZIT = CBinbezit.Checked
            .CNRQ = keycnrq

            .CHDATE = ChDate
            .USERNRQ = LoginNm
        End With

        Try
            db.SubmitChanges()
            Dim key = keypernrq & "-" & keypervnr.ToString("0000")
            Archive("PERL_U", key, "")

        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newperlvnr = GetHighPerlVNR(keypernrq)

        Dim newrec As New PERL With {
                .PERL_NRQ = keypernrq,
                .PERL_VNR = newperlvnr,
                .STARTDATE = DTPstartdate.Value,
                .AANTAL = TBaantal.Text,
                .SELREC = CBselrec.Checked,
                .INBEZIT = CBinbezit.Checked,
                .CNRQ = keycnrq,
                .CHDATE = ChDate,
                .USERNRQ = LoginNm,
                .USERCRE = LoginNm,
                .DATECRE = ChDate
            }

        db.PERLs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
            If updatestock = True Then
                updateOK = StockUpdate("N", keycnrq, keybonjr, keybonnr, newperlvnr, TBaantal.Text)
                If updateOK <> "" Then MsgBox(updateOK)
            End If
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keypernrq = newrec.PERL_NRQ
        keypervnr = newrec.PERL_VNR
        Dim key = keypernrq & "-" & keypervnr.ToString("0000")
        Archive("PERL_N", key, "")
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0

        Dim TBNumN() As TextBox = New TextBox() {TBaantal}
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
        DTPstartdate.Value = SysDate
        TBaantal.Text = 1
        CBselrec.Checked = False
        CBinbezit.Checked = False
        Try
            For Each rec In records
                keycnrq = rec.cnrq
                Setcode(keycnrq)

                searchrecs = From cod In db.CODs
                             Where cod.CNRQ = keycnrq
                             Select cod.CGNRQ, cod.Code
                             Take 1
                For Each srec In searchrecs
                    keycgnrq = srec.CGNRQ
                Next

                If IsNewRecord = True Then
                    DTPstartdate.Value = SysDate
                Else
                    DTPstartdate.Value = rec.startdate
                    TBaantal.Text = rec.aantal
                End If

                CBselrec.Checked = rec.selrec
                CBinbezit.Checked = rec.inbezit

            Next
        Catch ex As Exception

        End Try
        FillDisplay()

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If keycnrq < 1 Then
            MsgBox("Selecteer een geldige code voor deze PER-lijn!")
            Exit Sub
        End If
        If Savedata() = True Then Close()
    End Sub

    Private Sub ZoekCode_Click(sender As Object, e As EventArgs) Handles ZoekCode.Click
        SelCGNRQ = keycgnrq
        frompopup = True
        filtercode = ZoekCodeIM.Text
        SearchCode.ShowDialog()
        filtercode = ""
        frompopup = False
        SelCGNRQ = 0
        Setcode(keycnrq)
        FillDisplay()
    End Sub

    '****Functions
    Private Sub FillDisplay()
        LBLperlinfo.Text = ""
        Dim perrec = From per In db.PERs
                     Where per.PERNRQ = keypernrq
                     Select per.PERNM, per.PERGSM, per.PERGSMW
        For Each perr In perrec
            If IsNewRecord = True Then
                LBLperlinfo.Text = perr.PERNM & " GSM/W: " & perr.PERGSM & " " & perr.PERGSMW
            Else
                LBLperlinfo.Text = perr.PERNM & " GSM/W: " & perr.PERGSM & " " & perr.PERGSMW
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

    End Sub

    Private Sub ZoekCodeIM_TextChanged(sender As Object, e As EventArgs) Handles ZoekCodeIM.TextChanged
        Dim sfound As Integer = 0
        If ZoekCodeIM.Text = "" Then Exit Sub

        SelCGNRQ = keycgnrq
        sfound = 0
        Dim codrecs = From cod In db.CODs
                      Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                      Where cod.Code.StartsWith(ZoekCodeIM.Text) And codgp.INRESULT = True
                      Select cod.CNRQ, cod.Code

        For Each codrec In codrecs
            If sfound = 0 Then
                sfound = codrec.CNRQ
            Else
                Exit For
            End If
        Next
        keycnrq = sfound
        SelCGNRQ = 0
        FillDisplay()
    End Sub

End Class