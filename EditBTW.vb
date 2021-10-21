Imports System.ComponentModel
Imports System.Linq.Dynamic
Imports System.Linq

Public Class EditBTW
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "BTW: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub
    Private Sub EditCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From btw In db.BTWs
                  Where btw.BNRQ = keybtwnrq
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

        Dim updaterec = (From btw In db.BTWs
                         Where btw.BNRQ = keybtwnrq).ToList()(0)

        updaterec.BTW = TBbtw.Text
        updaterec.OmsBTW = TBomsbtw.Text
        updaterec.nieuwbon = CBnieuwbon.Checked
        updaterec.chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("BTW_U", Str(keybtwnrq), updaterec.BTW & " - " & updaterec.OmsBTW)

        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try

        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New BTW With {
            .BTW = TBbtw.Text,
            .OmsBTW = TBomsbtw.Text,
            .nieuwbon = CBnieuwbon.Checked,
            .usernrq = LoginNm,
            .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.BTWs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.")
            Exit Sub
            ' Handle exception.  
        End Try
        keybtwnrq = newrec.BNRQ
        Archive("BTW_N", Str(keybtwnrq), "")
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        Dim TBNum() As TextBox = New TextBox() {TBbtw}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBbtw.Text = rec.btw
            TBomsbtw.Text = rec.omsbtw

            CBnieuwbon.Checked = rec.nieuwbon
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