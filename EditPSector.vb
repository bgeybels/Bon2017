Imports System.ComponentModel
Public Class EditPSector
    Dim nocmdupd As Boolean = False

    Private Sub EditPSector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Sector: Bewerken (key=" & keypsid & ")"
        If IsNewRecord = True Then Me.Text = "Sector: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditPSector_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("PSECTOR", keypsid)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
    End Sub

    Private Sub Fill_DG()
        codrecs = From psector In db.PSECTORs
                  Where psector.PSID = keypsid
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

        Dim updaterec = (From psector In db.PSECTORs
                         Where psector.PSID = keypsid).ToList()(0)

        Dim oldpsverw As String = updaterec.PSVERW
        updaterec.PSVERW = TBpsverw.Text

        updaterec.CHDATE = ChDate
        updaterec.USERNRQ = LoginNm
        Try
            db.SubmitChanges()
            Archive("SECTOR_U", Str(keypsid), oldpsverw & " --> " & updaterec.PSVERW)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New PSECTOR With {
            .PSVERW = TBpsverw.Text,
            .USERNRQ = LoginNm,
            .CHDATE = ChDate}

        db.PSECTORs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keypsid = newrec.PSID
        Archive("SECTOR_N", Str(keypsid), TBpsverw.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBpsverw.Text = rec.psverw
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