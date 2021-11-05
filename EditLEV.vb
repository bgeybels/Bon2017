Imports System.ComponentModel

Public Class EditLEV
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Leverancier: Bewerken (key=" & keylevnrq & ")"
        If IsNewRecord = True Then Me.Text = "Leverancier: Nieuw"

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub

    Private Sub EditLEV_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("LEV", keylevnrq)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        records = From lev In db.LEVs
                  Where lev.LEVnrq = keylevnrq
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

        Dim updaterec = (From lev In db.LEVs
                         Where lev.LEVnrq = keylevnrq).ToList()(0)

        Dim oldnaam As String = updaterec.LEVnaam
        updaterec.LEVnaam = TBlevnaam.Text
        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Archive("LEV_U", Str(keylevnrq), oldnaam & " --> " & updaterec.LEVnaam)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Public Sub SaveNEW()
        Dim newrec As New LEV With {
          .LEVnaam = TBlevnaam.Text,
          .usernrq = LoginNm,
          .chdate = ChDate
          }

        db.LEVs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keylevnrq = newrec.LEVnrq
        Archive("LEV_N", Str(keylevnrq), TBlevnaam.Text)
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
            TBlevnaam.Text = rec.levnaam
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