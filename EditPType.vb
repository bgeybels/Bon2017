Imports System.ComponentModel
Public Class EditPType
    Dim nocmdupd As Boolean = False
    Private Sub EditPType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Prestatietype: Bewerken (key=" & keyptid & ")"
        If IsNewRecord = True Then Me.Text = "Prestatietype: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditPType_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("PTYPE", keyptid)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From ptype In db.PTYPEs
                  Where ptype.PTID = keyptid
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

        Dim updaterec = (From ptype In db.PTYPEs
                         Where ptype.PTID = keyptid).ToList()(0)

        Dim oldptverw As String = updaterec.PTVERW
        updaterec.PTVERW = TBptverw.Text
        updaterec.PTTOT = CBpttot.Checked

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("TYPE_U", Str(keyptid), oldptverw & " --> " & updaterec.PTVERW)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New PTYPE With {
            .PTVERW = TBptverw.Text, .PTTOT = CBpttot.Checked,
            .USERNRQ = LoginNm,
            .CHDATE = ChDate}

        db.PTYPEs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyptid = newrec.PTID
        Archive("TYPE_N", Str(keyptid), TBptverw.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBptverw.Text = rec.ptverw

            CBpttot.Checked = rec.pttot
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