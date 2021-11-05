Imports System.Linq.Dynamic

Public Class MoveCode
    Private Sub MoveCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MoveCode_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        FillCMBcodgp(CMBcodgp)
        ' if transgrp contains <> from 0 = preset to this codgrp
        If transgrp <> 0 Then
            CMBcodgp.SelectedValue = transgrp
        End If
    End Sub

    Private Sub movecode()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        keycgnrq = CMBcodgp.SelectedValue
        For Each row As DataGridViewRow In transgrid.SelectedRows
            'MsgBox(row.Cells("CNRQ").Value & " " & row.Cells("Code").Value)

            keycnrq = row.Cells("CNRQ").Value
            Dim updaterec = (From code In db.CODs
                             Where code.CNRQ = keycnrq).ToList()(0)
            updaterec.CGNRQ = CMBcodgp.SelectedValue
            Try
                db.SubmitChanges()
            Catch ex As Exception
                PositionMsgbox.CenterMsgBox(Me)
                MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
            End Try
        Next

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBverplaats_Click(sender As Object, e As EventArgs) Handles TSBverplaats.Click
        movecode()
        Close()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub
End Class