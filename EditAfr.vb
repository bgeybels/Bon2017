Imports System.ComponentModel

Public Class EditAfr
    Dim nocmdupd As Boolean = False

    Private Sub EditAfr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Af-Te-Handelen Reden: Bewerken (key=" & keyafrid & ")"
        If IsNewRecord = True Then Me.Text = "Af-Te-Handelen Reden: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditAfr_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("AFR", keyafrid)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From afr In db.AFRs
                  Where afr.AFRID = keyafrid
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

        Dim updaterec = (From afr In db.AFRs
                         Where afr.AFRID = keyafrid).ToList()(0)

        Dim oldverw As String = updaterec.AFRVERW
        updaterec.AFRVERW = TBverw.Text
        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("AFR_U", Str(keyafrid), oldverw & " --> " & updaterec.AFRVERW)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New AFR With {
            .AFRVERW = TBverw.Text,
            .USERNRQ = LoginNm,
            .CHDATE = ChDate}

        db.AFRs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyafrid = newrec.AFRID
        Archive("AFR_N", Str(keyafrid), TBverw.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBverw.Text = rec.afrverw
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