Imports System.ComponentModel

Public Class EditPER
    Dim nocmdupd As Boolean = False

    Private Sub EditPER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Personeel: Bewerken (key=" & keypernrq & ")"
        If IsNewRecord = True Then Me.Text = "Personeel: Nieuw"

        Fill_DG()
        Velden_vullen()
    End Sub
    Private Sub EditCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("PER", keypernrq)
        End If
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
        updaterec.PERSORTLONG = TBpersort.Text
        updaterec.PERSORT = ""
        updaterec.PERTEL = TBpertel.Text
        updaterec.PERGSM = TBpergsm.Text
        updaterec.PERICE = TBperice.Text
        updaterec.PERGSMW = TBpergsmw.Text

        updaterec.DIENST = CBdienst.Checked
        updaterec.BEDIENDE = CBbediende.Checked

        updaterec.PERDTID = Format(DTPperdtid.Value, "#yyyy-MM-dd#")
        updaterec.PERDTCT = Format(DTPperdtct.Value, "#yyyy-MM-dd#")
        updaterec.PERDTUD = Format(DTPperdtud.Value, "#yyyy-MM-dd#")

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("PER_U", Str(keypernrq), oldpernm & " --> " & updaterec.PERNM & " - " & updaterec.PERTEL & " - " & updaterec.PERGSM)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New PER With {
              .PERNM = TBpernm.Text,
              .PERTEL = TBpertel.Text,
              .PERGSM = TBpergsm.Text,
              .PERICE = TBperice.Text,
              .PERGSMW = TBpergsmw.Text,
              .PERSORT = "",
              .PERSORTLONG = TBpersort.Text,
              .DIENST = CBdienst.Checked,
              .BEDIENDE = CBbediende.Checked,
              .PERDTID = DTPperdtid.Value,
              .PERDTCT = DTPperdtct.Value,
              .PERDTUD = DTPperdtud.Value,
              .usernrq = LoginNm,
              .chdate = ChDate}

        db.PERs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
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

        TBpersort.BackColor = boxcolor
        If Len(TBpersort.Text) > 10 Then
            TBpersort.BackColor = boxcolorerror
            AllOK = False
        End If

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        For Each rec In records
            If IsNewRecord Then
                Dim TBNum() As TextBox = New TextBox() {TBpernm, TBpertel, TBpersort, TBpertel, TBpergsm, TBpergsmw}
                For Each TB As TextBox In TBNum
                    TB.Text = ""
                Next
                DTPperdtid.Value = SysDate
                DTPperdtct.Value = "01.01.2050"
                DTPperdtud.Value = "01.01.2050"
                CBdienst.Checked = True
                CBbediende.Checked = False
            Else
                TBpernm.Text = rec.PERNM
                TBpertel.Text = rec.tel
                TBpersort.Text = rec.persortlong
                TBpertel.Text = rec.pertel
                TBpergsm.Text = rec.pergsm
                TBperice.Text = rec.perice
                TBpergsmw.Text = rec.pergsmw
                CBdienst.Checked = rec.DIENST
                CBbediende.Checked = rec.BEDIENDE
                If Not IsNothing(rec.perdtid) Then
                    DTPperdtid.Value = rec.perdtid
                Else
                    DTPperdtid.Value = SysDate
                End If
                If Not IsNothing(rec.perdtct) Then
                    DTPperdtct.Value = rec.perdtct
                Else
                    DTPperdtct.Value = SysDate
                End If
                If Not IsNothing(rec.perdtud) Then
                    DTPperdtud.Value = rec.perdtud
                Else
                    DTPperdtud.Value = SysDate
                End If
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