Imports System.ComponentModel

Public Class EditDIES
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "Dieselpercentage: Nieuw"

        Fill_DG()
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
        records = From dies In db.DIES
                  Where dies.DNRQ = keydiesnrq
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

        Dim updaterec = (From dies In db.DIES
                         Where dies.DNRQ = keydiesnrq).ToList()(0)

        updaterec.DIES = TBdies.Text
        updaterec.OmsDIES = TBomsdies.Text

        updaterec.actief = CBactief.Checked

        updaterec.chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("DIES_U", Str(keydiesnrq), "Actief=" & updaterec.actief & " - " & updaterec.DIES & " - " & updaterec.OmsDIES)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New DIES With {
               .DIES = TBdies.Text,
               .OmsDIES = TBomsdies.Text,
               .actief = CBactief.Checked,
               .usernrq = LoginNm,
               .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")}

        db.DIES.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.")
            Exit Sub
            ' Handle exception.  
        End Try
        keydiesnrq = newrec.DNRQ
        Archive("DIES_N", Str(keydiesnrq), TBdies.Text & " - " & TBomsdies.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        '  Dim TBNum() As TextBox = New TextBox() {TBaankp, TBeenhp, TBstock, TBminstock, TBmaxstock}
        '  For Each TB As TextBox In TBNum
        '  TB.BackColor = boxcolor
        '  If Not IsNumeric(TB.Text) Then
        '  TB.BackColor = boxcolorerror
        '  AllOK = False
        '  End If
        '  Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBdies.Text = rec.dies
            TBomsdies.Text = rec.omsdies

            CBactief.Checked = rec.actief
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