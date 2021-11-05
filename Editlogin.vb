Imports System.ComponentModel

Public Class Editlogin
    Dim nocmdupd As Boolean = False

    Private Sub Editlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Gebruiker: Bewerken (key=" & keyloginnrq & ")"
        If IsNewRecord = True Then Me.Text = "Gebruiker: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub

    Private Sub Editlogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From login In db.Logins
                  Where login.nrq = keyloginnrq
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

        Dim updaterec = (From login In db.Logins
                         Where login.nrq = keyloginnrq).ToList()(0)

        updaterec.naam = TBnaam.Text
        updaterec.pwd = TBpwd.Text

        updaterec.upd = CBupd.Checked
        updaterec.del = CBdel.Checked
        updaterec.[new] = CBnew.Checked
        updaterec.CurrentLogon = "N"
        If CBcurrentlogon.Checked = True Then
            updaterec.CurrentLogon = "Y"
        End If
        updaterec.UserNrq = 0
        Try
            db.SubmitChanges()
            Archive("LOGIN_U", Str(keyloginnrq), updaterec.naam)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New Login With {
              .naam = TBnaam.Text,
              .pwd = TBpwd.Text,
              .CurrentLogon = "N",
              .upd = CBupd.Checked,
              .del = CBdel.Checked,
              .[new] = CBnew.Checked,
              .UserNrq = 0}

        db.Logins.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyloginnrq = newrec.nrq
        Archive("LOGIN_N", Str(keyloginnrq), TBnaam.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        'Dim TBNum() As TextBox = New TextBox() {TBaankp, TBeenhp, TBstock, TBminstock, TBmaxstock}
        'For Each TB As TextBox In TBNum
        'TB.BackColor = boxcolor
        'If Not IsNumeric(TB.Text) Then
        'TB.BackColor = boxcolorerror
        'AllOK = False
        'End If
        'Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBnaam.Text = rec.naam
            TBpwd.Text = rec.pwd

            CBnew.Checked = rec.[new]
            CBupd.Checked = rec.upd
            CBdel.Checked = rec.del

            CBcurrentlogon.Checked = False
            If rec.currentlogon = "Y" Then
                CBcurrentlogon.Checked = True
            End If

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