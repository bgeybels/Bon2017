Imports System.Configuration
Imports System.Data.SqlClient

Public Class ConnectDB
    Dim Conn As New SqlConnection
    Dim conval As String
    Dim convalArray() As String

    Private Sub ConnectDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conval = My.Settings.BONConnectionString
        fillbox(TextBox1, conval)
    End Sub

    Private Sub fillbox(tbox As TextBox, from As String)
        convalArray = Split(conval, ";")
        TextBox1.Text = ""
        For i As Integer = 0 To convalArray.Length - 1
            TextBox1.Text = TextBox1.Text & convalArray(i) & Chr(13) & Chr(10)
        Next
    End Sub

    Private Sub SetDB()
        convalArray = Split(TextBox1.Text, Chr(13) & Chr(10))
        conval = ""
        For i As Integer = 0 To convalArray.Length - 1
            If convalArray(i) <> "" Then conval = conval & convalArray(i) & ";"
        Next

        conval = Join(convalArray, ";")
        My.Settings.SetUserOverride("BONConnectionString", conval)
        My.Settings.Save()

        Conn.ConnectionString = My.Settings.BONConnectionString
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Conn.Open()
            Conn.Close()
            MsgBox("Connectie DB ok")
        Catch ex As Exception  'Failure
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BtnBon_Click(sender As Object, e As EventArgs) Handles BtnBon.Click
        SetDB()
    End Sub

    Private Sub BtnJK_Click(sender As Object, e As EventArgs) Handles BtnJK.Click
        conval = "Data Source=APPS-SERVER;Initial Catalog=BON;User id=sa;Password=bonnen2016"
        fillbox(TextBox1, conval)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conval = "Data Source=DESKTOP-SBURR68;Initial Catalog=BON;Integrated Security=True"
        fillbox(TextBox1, conval)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conval = "Data Source=DESKTOP-AGFTUAJ;Initial Catalog=BON;Integrated Security=True"
        fillbox(TextBox1, conval)
    End Sub

End Class