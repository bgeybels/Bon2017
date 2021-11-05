Imports System.ComponentModel

Public Class EditCodgp
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "CodeGroep: Bewerken (key=" & keycgnrq & ")"
        If IsNewRecord = True Then Me.Text = "CodeGroep: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("CODGP", keycgnrq)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From codgp In db.CODGPs
                  Where codgp.CGNRQ = keycgnrq
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

        Dim updaterec = (From codgp In db.CODGPs
                         Where codgp.CGNRQ = keycgnrq).ToList()(0)

        Dim oldomsgroep As String = updaterec.OmsGroep
        updaterec.OmsGroep = TBomsgroep.Text
        updaterec.procent = TBprocent.Text
        updaterec.rondaf = CBrondaf.Checked
        updaterec.nostock = CBnostock.Checked
        updaterec.noinvent = CBnoinvent.Checked
        updaterec.dies = 0
        updaterec.INRESULT = CBinresult.Checked

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("CODGP_U", Str(keycgnrq), oldomsgroep & " --> " & updaterec.OmsGroep)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New CODGP With {
            .OmsGroep = TBomsgroep.Text,
            .procent = TBprocent.Text,
            .rondaf = CBrondaf.Checked, .nostock = CBnostock.Checked, .noinvent = CBnoinvent.Checked, .dies = 0, .INRESULT = CBinresult.Checked,
            .usernrq = LoginNm,
            .chdate = ChDate}

        db.CODGPs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keycgnrq = newrec.CGNRQ
        Archive("CODEGP_N", Str(keycgnrq), "")
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        Dim TBNum() As TextBox = New TextBox() {TBprocent}
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
        For Each rec In codrecs
            TBomsgroep.Text = rec.omsgroep
            TBprocent.Text = rec.procent

            CBrondaf.Checked = rec.rondaf
            CBnostock.Checked = rec.nostock
            CBnoinvent.Checked = rec.noinvent
            CBinresult.Checked = rec.inresult
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