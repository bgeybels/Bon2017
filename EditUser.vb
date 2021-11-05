Imports System.ComponentModel

Public Class EditUser
    Dim nocmdupd As Boolean = False

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Gebruiker: Bewerken (key=" & keyloginnrq & ")"
        If IsNewRecord = True Then Me.Text = "Gebruiker: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub

    Private Sub EditUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From users In db.USERs
                  Where users.UNRQ = keyloginnrq
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

        Dim updaterec = (From users In db.USERs
                         Where users.UNRQ = keyloginnrq).ToList()(0)

        updaterec.UNAAM = TBnaam.Text
        updaterec.UPWD = TBpwd.Text

        updaterec.UUPD = CBupd.Checked
        updaterec.UDEL = CBdel.Checked
        updaterec.UNEW = CBnew.Checked
        updaterec.USYSUSER = CBsysuser.Checked
        updaterec.USTOCKUSER = CBstockuser.Checked
        updaterec.UPERSUSER = CBupersuser.Checked
        updaterec.TOTALS = CBtotals.Checked
        updaterec.TOTALSSYS = CBtotalssys.Checked
        updaterec.GETFAKTNR = CBgetfaktnr.Checked
        updaterec.UCURLOGON = 0

        GetFaktNr = CBstockuser.Checked
        LoginStockAdmin = CBstockuser.Checked
        LoginSysAdmin = CBsysuser.Checked

        Try
            db.SubmitChanges()
            Archive("USERS_U", Str(keyloginnrq), updaterec.UNAAM)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New USERS With {
              .UNAAM = TBnaam.Text,
              .UPWD = TBpwd.Text,
              .USYSUSER = CBsysuser.Checked,
              .USTOCKUSER = CBstockuser.Checked,
              .UPERSUSER = CBupersuser.Checked,
              .TOTALS = CBtotals.Checked,
              .TOTALSSYS = CBtotalssys.Checked,
              .GETFAKTNR = CBgetfaktnr.Checked,
              .UUPD = CBupd.Checked,
              .UDEL = CBdel.Checked,
              .UNEW = CBnew.Checked,
              .UCURLOGON = 0}

        db.USERS.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyloginnrq = newrec.UNRQ
        Archive("USERS_N", Str(keyloginnrq), TBnaam.Text)
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
            TBnaam.Text = rec.UNAAM
            TBpwd.Text = rec.UPWD

            CBnew.Checked = rec.UNEW
            CBupd.Checked = rec.UUPD
            CBdel.Checked = rec.UDEL
            CBsysuser.Checked = rec.USYSUSER
            CBstockuser.Checked = rec.USTOCKUSER
            CBupersuser.Checked = rec.UPERSUSER
            CBtotals.Checked = rec.TOTALS
            CBtotalssys.Checked = rec.TOTALSSYS
            CBgetfaktnr.Checked = rec.GETFAKTNR
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