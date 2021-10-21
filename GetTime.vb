Imports System.ComponentModel

Public Class GetTime
    Private Sub GetTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetTime_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

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
        Dim hptijdu As Integer
        Dim hptijdm As Integer
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
        hptijdm = calculated - (60 * hptijdu)
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

        TimeVal = Trim(Str(hptijdu)) & "," & Trim(Str(hptijdm))
    End Sub

End Class