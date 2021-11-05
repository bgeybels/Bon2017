Imports System.ComponentModel

Public Class EditAft
    Dim nocmdupd As Boolean = False

    Private Sub EditAft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Af-Te-Handelen Type: Bewerken (key=" & keyaftid & ")"
        If IsNewRecord = True Then Me.Text = "Af-Te-Handelen Type: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditAft_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("AFT", keyaftid)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From aft In db.AFTs
                  Where aft.AFTID = keyaftid
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

        Dim updaterec = (From aft In db.AFTs
                         Where aft.AFTID = keyaftid).ToList()(0)

        Dim oldverw As String = updaterec.AFTVERW
        updaterec.AFTVERW = TBverw.Text
        updaterec.CHDATE = ChDate
        updaterec.USERNRQ = LoginNm
        Try
            db.SubmitChanges()
            Archive("AFT_U", Str(keyaftid), oldverw & " --> " & updaterec.AFTVERW)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New AFT With {
            .AFTVERW = TBverw.Text,
            .USERNRQ = LoginNm,
            .CHDATE = ChDate}

        db.AFTs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyaftid = newrec.AFTID
        Archive("AFT_N", Str(keyaftid), TBverw.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBverw.Text = rec.aftverw
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