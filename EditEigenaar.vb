Imports System.ComponentModel

Public Class EditEigenaar
    Private Sub EditEigenaar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "Eigenaar: Nieuw"
        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditEigenaar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("EIGENAAR", keyeigenaarnrq)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From eigenaar In db.EIGENAARs
                  Where eigenaar.ENRQ = keyeigenaarnrq
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

        Dim updaterec = (From eigenaar In db.EIGENAARs
                         Where eigenaar.ENRQ = keyeigenaarnrq).ToList()(0)

        updaterec.EFirma = TBefirma.Text
        updaterec.ENaam = TBenaam.Text
        updaterec.EEMail = TBeemail.Text
        updaterec.EStraat = TBestraat.Text
        updaterec.EAdres = TBeadres.Text
        updaterec.ETel = TBetel.Text
        updaterec.EGSM = TBegsm.Text
        updaterec.EFax = TBefax.Text
        updaterec.EBTWNr = TBebtwnr.Text
        updaterec.EREKNR = TBereknr.Text

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("EIGENAAR_U", Str(keyeigenaarnrq), updaterec.ENaam)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New EIGENAAR With {
            .EFirma = TBefirma.Text,
            .ENaam = TBenaam.Text,
            .EEMail = TBeemail.Text,
            .EStraat = TBestraat.Text,
            .EAdres = TBeadres.Text,
            .ETel = TBetel.Text,
            .EGSM = TBegsm.Text,
            .EFax = TBefax.Text,
            .EBTWNr = TBebtwnr.Text,
            .EREKNR = TBereknr.Text,
            .usernrq = LoginNm,
            .chdate = ChDate}

        db.EIGENAARs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyeigenaarnrq = newrec.ENRQ
        Archive("EIGENAAR_N", Str(keyeigenaarnrq), "")
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
        For Each rec In records
            TBefirma.Text = rec.efirma
            TBenaam.Text = rec.enaam
            TBeemail.Text = rec.eemail
            TBestraat.Text = rec.estraat
            TBeadres.Text = rec.eadres
            TBetel.Text = rec.etel
            TBegsm.Text = rec.egsm
            TBefax.Text = rec.efax
            TBebtwnr.Text = rec.ebtwnr
            TBereknr.Text = rec.ereknr
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