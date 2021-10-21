Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class StartSQL
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlString As String
    Dim convalArray() As String

    Private Sub BtnStart_Click(sender As Object, e As EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Command = connection.CreateCommand()
        command.CommandText = TBsql.Text
        command.ExecuteNonQuery()

        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Uitvoering SQL ok!")
    End Sub

    Private Sub StartSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conval As String = My.Settings.BONConnectionString
        ConnectDB(conval)
    End Sub

    Private Sub ConnectDB(from As String)
        convalArray = Split(from, ";")
        Dim constring As String = ""
        Dim where As Integer
        Dim val As String
        Dim key As String
        Dim trusted As Boolean = True

        For i As Integer = 0 To convalArray.Length - 1
            where = InStr(convalArray(i), "=")
            If where < 1 Then Continue For
            val = Mid(convalArray(i), where + 1)
            key = Mid(convalArray(i), 1, where - 1)
            Select Case key
                Case "Data Source"
                    constring = constring + "Server=" & val & ";"
                Case "Initial Catalog"
                    constring = constring + "Database=" & val & ";"
                Case "User id"
                    constring = constring + "User Id=" & val & ";"
                    trusted = False
                Case "Password"
                    constring = constring + "Password=" & val & ";"
            End Select
        Next
        If trusted = True Then constring = constring + "Trusted_Connection=True;"
        connection = New SqlConnection(constring)
        connection.Open()
    End Sub

    Private Sub StartSQL_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        connection.Close()
    End Sub

    Private Sub UpdateBNRQ11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBNRQ11ToolStripMenuItem.Click
        TBsql.Text = "UPDATE BTW SET OmsBTW = 'RM: Regie- en of Meerwerk (bge)' WHERE BNRQ = 11;"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bonld = From bonl In db.BONLs
                    Join aoms In db.AOms On bonl.ANRQ Equals aoms.ANRQ
                    Where bonl.BONJR = 2018 And bonl.BONNR = 7
        MsgBox(bonld.Count)
    End Sub
End Class