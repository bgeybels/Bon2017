﻿Imports System.ComponentModel

Public Class EditOaanm
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "Onderaannemer: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From oaanm In db.OAANMs
                  Where oaanm.OAANMNRQ = keyoaanmnrq
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

        Dim updaterec = (From oaanm In db.OAANMs
                         Where oaanm.OAANMNRQ = keyoaanmnrq).ToList()(0)

        Dim oldnaam As String = updaterec.OAANMNM
        updaterec.OAANMNM = TBoaanmnm.Text
        updaterec.chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("OAANM_U", Str(keyoaanmnrq), oldnaam & " --> " & TBoaanmnm.Text)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New OAANM With {
            .OAANMNM = TBoaanmnm.Text,
            .usernrq = LoginNm,
            .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.OAANMs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record toevoegen niet gelukt.")
            Exit Sub
            ' Handle exception.  
        End Try
        keyoaanmnrq = newrec.OAANMNRQ
        Archive("OAANM_N", Str(keyoaanmnrq), TBoaanmnm.Text)
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

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBoaanmnm.Text = rec.oaanmnm
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