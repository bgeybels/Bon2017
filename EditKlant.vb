Imports System.ComponentModel

Public Class EditKlant
    Private Sub EditKlant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Klant: Bewerken (key=" & keyklantnrq & ")"
        If IsNewKlant = True Then Me.Text = "Klant: Nieuw"
        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditKlant_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewKlant = False Then
            Dim unlock = unlockrec("KLANT", keyklantnrq)
        End If

        IsNewKlant = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        klantrecs = From klant In db.KLANTs
                    Where klant.KNRQ = keyklantnrq
                    Take 1
    End Sub

    '****FIELDActions
    Private Function Savedata() As Boolean
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
        End If

        If IsNewKlant = True Then
            SaveNEW()
            Return True
            Exit Function
        End If

        Dim updaterec = (From klant In db.KLANTs
                         Where klant.KNRQ = keyklantnrq).ToList()(0)

        updaterec.KNaam = TBknaam.Text
        updaterec.KStraat = TBkstraat.Text
        updaterec.KAdres = TBkadres.Text
        updaterec.KWAdres = TBkwadres.Text
        updaterec.KWStraat = TBkwstraat.Text
        updaterec.Ktav = TBktav.Text
        updaterec.KTel = TBktel.Text
        updaterec.KGSM = TBkgsm.Text
        updaterec.KFax = TBkfax.Text
        updaterec.KEMail = TBkemail.Text
        updaterec.KEMailF = TBkemailf.Text
        updaterec.KBTWNr = TBkbtwnr.Text
        updaterec.ConvIN_NR = 0
        If CBfac.CheckState = 1 Then
            updaterec.FAC = "J"
        Else
            updaterec.FAC = "N"
        End If
        If CBfacm.CheckState = 1 Then
            updaterec.FACM = "J"
        Else
            updaterec.FACM = "N"
        End If
        If CBfacp.CheckState = 1 Then
            updaterec.FACP = "J"
        Else
            updaterec.FACP = "N"
        End If

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("KLANT_U", Str(keyklantnrq), updaterec.KNaam & " - " & updaterec.KStraat & "/" & updaterec.KAdres)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try

        Return True
    End Function

    Private Sub SaveNEW()

        Dim newrec As New KLANT With {
           .KNaam = TBknaam.Text,
           .Ktav = TBktav.Text,
           .KAdres = TBkadres.Text,
           .KStraat = TBkstraat.Text,
           .KWAdres = TBkwadres.Text,
           .KWStraat = TBkwstraat.Text,
           .KTel = TBktel.Text,
           .KGSM = TBkgsm.Text,
           .KFax = TBkfax.Text,
           .KEMail = TBkemail.Text,
           .KEMailF = TBkemailf.Text,
           .KBTWNr = TBkbtwnr.Text,
           .ConvIN_NR = 0,
           .FAC = "N",
           .FACM = "N",
           .FACP = "N",
           .usernrq = LoginNm,
           .USDate = ChDate,
           .chdate = ChDate}

        db.KLANTs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyklantnrq = newrec.KNRQ
        Archive("KLANT_N", Str(keyklantnrq), TBknaam.Text & " - " & TBkstraat.Text & "/" & TBkadres.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        'Dim TBNum() As TextBox = New TextBox() {TBaankp, TBeenhp, TBstock, TBminstock, TBmaxstock}
        'For Each TB As TextBox In TBNum
        'TB.BackColor = boxcolor
        'If Not IsNumeric(TB.Text) Then
        'TB.BackColor = boxcolorerror
        'AllOK = False
        'End If
        'Next
        Dim TBNum20() As TextBox = New TextBox() {TBkgsm, TBktel, TBkfax}
        For Each TB As TextBox In TBNum20
            TB.BackColor = boxcolor
            If TB.TextLength > 20 Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next
        Dim TBNum50() As TextBox = New TextBox() {TBknaam, TBkemail, TBkstraat, TBkadres, TBkemailf}
        For Each TB As TextBox In TBNum50
            TB.BackColor = boxcolor
            If TB.TextLength > 50 Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next
        Dim TBNum100() As TextBox = New TextBox() {TBktav}
        For Each TB As TextBox In TBNum100
            TB.BackColor = boxcolor
            If TB.TextLength > 100 Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next
        Dim TBNum30() As TextBox = New TextBox() {TBkbtwnr}
        For Each TB As TextBox In TBNum30
            TB.BackColor = boxcolor
            If TB.TextLength > 30 Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next
        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each klantrec In klantrecs
            If IsNewKlant Then
                Dim TBNum() As TextBox = New TextBox() {TBknaam, TBktav, TBkbtwnr, TBkstraat, TBkadres, TBkwadres, TBkwstraat, TBkemail, TBkemailf, TBktel, TBkgsm, TBkfax}
                For Each TB As TextBox In TBNum
                    TB.Text = ""
                Next
            Else
                TBknaam.Text = klantrec.KNaam
                TBktav.Text = klantrec.ktav
                TBkbtwnr.Text = klantrec.kbtwnr
                TBkstraat.Text = klantrec.kstraat
                TBkadres.Text = klantrec.kadres
                TBkwadres.Text = klantrec.kwadres
                TBkwstraat.Text = klantrec.kwstraat
                TBkemail.Text = klantrec.kemail
                TBkemailf.Text = klantrec.kemailf
                TBktel.Text = klantrec.ktel
                TBkgsm.Text = klantrec.kgsm
                TBkfax.Text = klantrec.kfax
                If klantrec.fac = "J" Then
                    CBfac.Checked = True
                Else
                    CBfac.Checked = False
                End If
                If klantrec.facm = "J" Then
                    CBfacm.Checked = True
                Else
                    CBfacm.Checked = False
                End If
                If klantrec.facp = "J" Then
                    CBfacp.Checked = True
                Else
                    CBfacp.Checked = False
                End If
            End If
        Next
    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub TBkadres_TextChanged(sender As Object, e As EventArgs) Handles TBkadres.TextChanged
        Dim getpc As String
        getpc = Getpca_postcode(TBkadres.Text)
        If getpc = "" Then getpc = Getpca_gemeente(TBkadres.Text)
        If getpc <> "" Then TBkadres.Text = getpc
    End Sub
End Class