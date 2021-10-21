Imports System.ComponentModel

Public Class EditKlant
    Private Sub EditKlant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "Klanten: Nieuw"
        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditKlant_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsNewRecord = False
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

        If IsNewRecord = True Then
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
        updaterec.KBTWNr = TBkbtwnr.Text
        updaterec.ConvIN_NR = Val(TBconvin_nr.Text)

        updaterec.chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm

        updaterec.USDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")

        Try
            db.SubmitChanges()
            Archive("KLANT_U", Str(keyklantnrq), updaterec.KNaam & " - " & updaterec.KStraat & "/" & updaterec.KAdres)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
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
           .KBTWNr = TBkbtwnr.Text,
           .ConvIN_NR = TBconvin_nr.Text,
           .usernrq = LoginNm,
           .USDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
           .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")}

        db.KLANTs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.")
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

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each klantrec In klantrecs
            TBknaam.Text = klantrec.KNaam
            TBktav.Text = klantrec.ktav
            TBconvin_nr.Text = klantrec.convin_nr
            TBkbtwnr.Text = klantrec.kbtwnr
            TBkstraat.Text = klantrec.kstraat
            TBkadres.Text = klantrec.kadres
            TBkwadres.Text = klantrec.kwadres
            TBkwstraat.Text = klantrec.kwstraat
            TBkemail.Text = klantrec.kemail
            TBktel.Text = klantrec.ktel
            TBkgsm.Text = klantrec.kgsm
            TBkfax.Text = klantrec.kfax
        Next
    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

End Class