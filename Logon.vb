﻿Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class Logon
    Dim Conn As New SqlConnection

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Check_Details()
    End Sub

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mac = getMacAddress()
        UsernameTextBox.Text = My.Settings.UserLogon
        If mac = "08002789924F" Then
            UsernameTextBox.Text = "SYSTEM"
            PasswordTextBox.Text = "BGE"
        Else
            PasswordTextBox.Text = ""
        End If

        SetInfo()

        Conn.ConnectionString = My.Settings.BONConnectionString
        If Conn.ConnectionString = "" Then
            ConnectDB.Show()
        End If

    End Sub

    Private Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub SetInfo()
        Dim conval As String = My.Settings.BONConnectionString
        Dim convalArray() As String = Split(conval, ";")
        Dim field() As String

        LBLinfo.Text = ""
        For i = 0 To 1
            field = Split(convalArray(i), "=")
            If field(1) <> "" Then LBLinfo.Text = LBLinfo.Text & ":" & field(1)
        Next
        sysDBUsed = LBLinfo.Text
        LBLinfo.Text = "DataBase " & LBLinfo.Text

        Me.Text = "Toegangscontrole: " & Application.ProductVersion & ":" & Application.ProductName & "  MAC:" & getMacAddress()
    End Sub

    Private Sub Check_Details()
        Dim UName As String = UsernameTextBox.Text.ToString.Trim
        Dim PWord As String = Me.PasswordTextBox.Text.ToString.Trim

        Dim sd As New BONDataContext

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim query = From login In sd.Logins
                        Select login.pwd, login.naam, login.[new], login.del, login.upd, login.CurrentLogon
                        Where naam = UName AndAlso pwd = PWord

            If query.Count() = 1 Then
                For Each user In query
                    LoginNm = user.naam
                    LoginDEL = user.del
                    LoginNEW = user.[new]
                    LoginUPD = user.upd
                    LoginSysAdmin = False
                    If user.currentlogon = "Y" Then loginsysadmin = True
                Next
                'Sysdate mag je enkel aanpassen met alle permissies
                SysDate = DTPsys.Value.ToString("dd/MM/yyyy")
                If LoginDEL = False Or LoginNEW = False Or LoginUPD = False Then
                    If SysDate <> Today.ToString("dd/MM/yyyy") Then
                        PositionMsgbox.CenterMsgBox(Me)
                        MsgBox("Aanpassen datum enkel toegelaten als je alle rechten hebt!")
                        'DTPsys.Value = DateTime.Now
                        SysDate = Today.ToString("dd/MM/yyyy")
                    End If

                End If

                My.Settings.UserLogon = UName
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Hide()
                MDIbon.Show()
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
                PositionMsgbox.CenterMsgBox(Me)
                MessageBox.Show("Gebruiker en/of paswoord zijn foutief!")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            PositionMsgbox.CenterMsgBox(Me)
            MessageBox.Show(ex.Message)
            ConnectDB.Show()
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BtnDB_Click(sender As Object, e As EventArgs)
        ConnectDB.ShowDialog()
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        ConnectDB.ShowDialog()
        SetInfo()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class
