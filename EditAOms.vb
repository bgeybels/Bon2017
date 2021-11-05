Imports System.ComponentModel

Public Class EditAOms
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Eenheden: bewerken (key=" & keyanrq & ")"
        If IsNewRecord = True Then Me.Text = "Eenheden: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub
    Private Sub EditCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewRecord = False Then
            Dim unlock = unlockrec("AOMS", keyanrq)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From aoms In db.AOms
                  Where aoms.ANRQ = keyanrq
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

        Dim updaterec = (From aoms In db.AOms
                         Where aoms.ANRQ = keyanrq).ToList()(0)

        Dim oldoms As String = updaterec.Oms
        updaterec.Oms = TBoms.Text
        'updaterec.chdateao = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.chdateao = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("VOLUME_U", Str(keyanrq), oldoms & " --> " & TBoms.Text)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New AOms With {
            .Oms = TBoms.Text,
            .usernrq = LoginNm,
            .chdateao = ChDate
        }

        db.AOms.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyanrq = newrec.ANRQ
        Archive("VOLUME_N", Str(keyanrq), TBoms.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        ' Dim TBNum() As TextBox = New TextBox() {TBbtw}
        ' For Each TB As TextBox In TBNum
        ' TB.BackColor = boxcolor
        ' If Not IsNumeric(TB.Text) Then
        ' TB.BackColor = boxcolorerror
        ' AllOK = False
        ' End If
        ' Next

        TBoms.BackColor = boxcolor
        If Len(TBoms.Text) > 4 Then
            TBoms.BackColor = boxcolorerror
            AllOK = False
        End If

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBoms.Text = rec.oms
        Next
    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class