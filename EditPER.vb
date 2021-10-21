Imports System.ComponentModel

Public Class EditPER
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then Me.Text = "Personeel: Nieuw"

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
        records = From per In db.PERs
                  Where per.PERNRQ = keypernrq
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

        Dim updaterec = (From per In db.PERs
                         Where per.PERNRQ = keypernrq).ToList()(0)

        Dim oldpernm As String = updaterec.PERNM
        updaterec.PERNM = TBpernm.Text
        updaterec.tel = TBtel.Text
        updaterec.PERSORT = TBpersort.Text
        updaterec.PERTEL = TBpertel.Text
        updaterec.PERGSM = TBpergsm.Text
        updaterec.PERGSMW = TBpergsmw.Text

        updaterec.DIENST = CBdienst.Checked

        updaterec.ChDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("PER_U", Str(keypernrq), oldpernm & " --> " & updaterec.PERNM & " - " & updaterec.PERTEL & " - " & updaterec.PERGSM)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New PER With {
              .PERNM = TBpernm.Text,
              .PERTEL = TBpertel.Text,
              .PERGSM = TBpergsm.Text,
              .PERGSMW = TBpergsmw.Text,
              .tel = TBtel.Text,
              .PERSORT = TBpersort.Text,
              .DIENST = CBdienst.Checked,
              .usernrq = LoginNm,
              .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")}

        db.PERs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.")
            Exit Sub
            ' Handle exception.  
        End Try
        keypernrq = newrec.PERNRQ
        Archive("PER_N", Str(keypernrq), "")
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

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            TBpernm.Text = rec.PERNM
            TBtel.Text = rec.tel
            TBpersort.Text = rec.persort
            TBpertel.Text = rec.pertel
            TBpergsm.Text = rec.pergsm
            TBpergsmw.Text = rec.pergsmw

            CBdienst.Checked = rec.DIENST
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