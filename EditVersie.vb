Imports System.ComponentModel

Public Class EditVERSIE
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "VersieGroep: Bewerken (key=" & keyversiegnrq & ")"
        If IsNewRecord = True Then Me.Text = "Versiegroep: Nieuw"

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
        records = From versieg In db.VERSIEGs
                  Where versieg.VERSIEGNRQ = keyversiegnrq
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

        Dim updaterec = (From versie In db.VERSIEs
                         Where versie.VNRQ = keyvnrq).ToList()(0)

        updaterec.VER = TBver.Text
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New VERSIE With {
              .VER = TBver.Text}

        db.VERSIEs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyvnrq = newrec.VNRQ
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

        'TBpersort.BackColor = boxcolor
        'If Len(TBpersort.Text) > 3 Then
        'TBpersort.BackColor = boxcolorerror
        'AllOK = False
        'End If

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBver.Text = rec.VER
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