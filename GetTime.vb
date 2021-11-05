Imports System.ComponentModel

Public Class GetTime
    Private Sub GetTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spart As String()
        If TimeVal <> "" Then
            'MsgBox(TimeVal)
            Dim parts As String() = TimeVal.Split(New Char() {":"c})
            CBuvan.Text = parts(1)
            spart = Split(parts(2))
            CBmvan.Text = spart(0)
            CButot.Text = parts(3)
            spart = Split(parts(4))
            CBmtot.Text = spart(0)
            CBumin.Text = parts(5)
            CBmmin.Text = parts(6)
        Else
            CBuvan.Text = "00"
            CBmvan.Text = "00"
            CButot.Text = "00"
            CBmtot.Text = "00"
            CBumin.Text = "00"
            CBmmin.Text = "00"
        End If

        TimeVal = ""
    End Sub

    Private Sub GetTime_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CBuvan.Focus()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        CalcTime()
        Close()
    End Sub

    Private Sub CalcTime()
        Dim strcalctime As String = ""
        Dim calculated As Integer = 0
        Dim uvan As Integer = 0
        Dim utot As Integer = 0
        Dim umin As Integer = 0
        Dim hptijdu As Decimal
        Dim hptijdui As Integer
        Dim hptijdm As Integer

        If CBuvan.Text = "00" And CBmvan.Text = "00" And CButot.Text = "00" And CBmtot.Text = "00" And CBumin.Text = "00" And CBmmin.Text = "00" Then
            Exit Sub
        End If

        uvan = (CBuvan.Text * 60) + CBmvan.Text
        utot = (CButot.Text * 60) + CBmtot.Text
        umin = (CBumin.Text * 60) + CBmmin.Text

        If utot > uvan Then
            uvan = 1440 - uvan
            utot = 1440 - utot
            calculated = (uvan - utot) - umin
        Else
            uvan = 1440 - uvan
            calculated = (utot + uvan) - umin
        End If

        hptijdu = calculated / 60
        hptijdui = Math.Truncate(hptijdu)
        hptijdm = calculated - (60 * hptijdui)
        Select Case hptijdm
            Case 1 To 15
                hptijdm = 25
            Case 16 To 30
                hptijdm = 50
            Case 31 To 45
                hptijdm = 75
            Case 46 To 59
                hptijdm = 0
                hptijdu = hptijdu + 1
            Case Else
                hptijdm = 0
        End Select

        TimeStr = ""
        TimeStr = "Van:" & CBuvan.Text & ":" & CBmvan.Text
        TimeStr = TimeStr & " tot:" & CButot.Text & ":" & CBmtot.Text
        TimeStr = TimeStr & " min:" & CBumin.Text & ":" & CBmmin.Text

        TimeVal = Trim(Str(hptijdui)) & "," & Trim(Str(hptijdm))
        'TimeVal = Str(hptijdu)
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class