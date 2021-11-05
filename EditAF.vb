Imports System.ComponentModel

Public Class EditAF
    Dim nocmdupd As Boolean = False
    Dim oldnum As String = ""

    Private Sub Editaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Af te handelen: Bewerken (key=" & keybonjr & "/" & keybonnr & ")"
        If IsNewRecord = True Then
            'TSBPrintBon.Enabled = False
            Me.Text = "Af te handelen: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If
        FillCMBafr(CMBafr)
        FillCMBaft(CMBaft)

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()

        DTPafdatum.Focus()

    End Sub
    Private Sub Editaf_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewRecord = False Then
            Dim strkey As String = keyafjr & keyafvnr
            Dim unlock = unlockrec("AF", strkey)
        End If

        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From af In db.AFs
                      Where af.AFJR = keyafjr AndAlso af.AFVNR = keyafvnr
                      Take 1

        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Ophalen niet gelukt! --> " & ex.Message)

        End Try

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

        Dim updaterec = (From af In db.AFs
                         Where af.AFJR = keyafjr AndAlso af.AFVNR = keyafvnr).ToList()(0)

        With updaterec
            .AFDATUM = DTPafdatum.Value
            .AFAP = CBafap.CheckState
            .AFR = CMBafr.SelectedValue
            .AFT = CMBaft.SelectedValue
            .AFNR = TBafnr.Text
            .AFAFSPR = TBafafspr.Text
            .AFLINK = TBaflink.Text
            .AFCALC = TBafcalc.Text
            .AFOFF = TBafoff.Text
            .AFSEND = TBafsend.Text
            .AFOPM = TBafopm.Text
            .AFWERFL = TBafwerfl.Text
            .AFSTART = TBafstart.Text
            .AFBEDR = TBafbedr.Text

            ''.AFSORTKEY = DTPafdatum.Value.ToString("yyyyMMdd") & "-" & .AFVNR.ToString("D4")
            .AFSORTNR = DTPafdatum.Value.ToString("yyyyMMdd") & "-" & .AFNR.ToString("D4")

            .CHDATE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
            .USERNRQ = LoginNm
        End With

        Try
            db.SubmitChanges()
            Dim key = keyafjr & "/" & keyafvnr.ToString("0000")
            Archive("AF_U", key, TBafnr.Text)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newafvnr = GetHighAFVNR(keyafjr)

        Dim newrec As New AF With {
            .AFJR = keyafjr,
            .AFVNR = newafvnr,
            .AFDATUM = DTPafdatum.Value,
            .AFAP = CBafap.CheckState,
            .AFR = CMBafr.SelectedValue,
            .AFT = CMBaft.SelectedValue,
            .AFAFSPR = TBafafspr.Text,
            .AFNR = TBafnr.Text,
            .AFLINK = TBaflink.Text,
            .AFCALC = TBafcalc.Text,
            .AFOFF = TBafoff.Text,
            .AFSEND = TBafsend.Text,
            .AFOPM = TBafopm.Text,
            .AFWERFL = TBafwerfl.Text,
            .AFSTART = TBafstart.Text,
            .AFTERMIJN = "",
            .AF30BIS = "",
            .AFVS = "",
            .AFFACT = "",
            .AFBEDR = TBafbedr.Text,
            .AFSORTKEY = DTPafdatum.Value.ToString("yyyyMMdd") & "-" & .AFVNR.ToString("D4"),
            .AFSORTNR = DTPafdatum.Value.ToString("yyyyMMdd") & "-" & .AFNR.ToString("D4"),
            .CHDATE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
            .USERNRQ = LoginNm,
            .USERCRE = LoginNm,
            .DATECRE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.AFs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyafjr = newrec.AFJR
        keyafvnr = newrec.AFVNR
        Dim key = keyafjr & "/" & keyafvnr.ToString("0000")
        Archive("AF_N", key, TBafnr.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0

        Dim TBNum() As TextBox = New TextBox() {TBafnr, TBafbedr}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) And Not TB.Text = "" Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        If oldnum <> TBafnr.Text Then
            'If IsNewRecord = True Then
            AllOK = AFNRexist(keyafjr, TBafnr.Text)
            If AllOK = False Then
                TBafnr.BackColor = boxcolorerror
            End If
        End If

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        DTPafdatum.Value = SysDate
        If IsNewRecord = True Then
            TBafnr.Text = GetHighAFNR(keyafjr)
        End If
        CBafap.Checked = 0

        TBaflink.Text = ""
        TBafcalc.Text = ""
        TBafoff.Text = ""
        TBafsend.Text = ""
        TBafafspr.Text = ""
        TBafopm.Text = ""
        TBafwerfl.Text = ""
        TBafstart.Text = ""
        TBafbedr.Text = ""
        Try
            For Each rec In records
                If IsNewRecord = True Then
                    DTPafdatum.Value = SysDate
                    CBafap.Checked = 0

                    TBafnr.Text = GetHighAFNR(keyafjr)
                    TBaflink.Text = ""
                    TBafcalc.Text = ""
                    TBafoff.Text = ""
                    TBafsend.Text = ""
                    TBafafspr.Text = ""
                    TBafopm.Text = ""
                    TBafwerfl.Text = ""
                    TBafstart.Text = ""
                    TBafbedr.Text = ""
                Else
                    DTPafdatum.Value = rec.afdatum
                    CBafap.Checked = rec.afap

                    TBafnr.Text = rec.afnr
                    oldnum = rec.afnr
                    TBaflink.Text = rec.aflink
                    TBafcalc.Text = rec.afcalc
                    TBafoff.Text = rec.afoff
                    TBafsend.Text = rec.afsend
                    TBafafspr.Text = rec.afafspr
                    TBafopm.Text = rec.afopm
                    TBafwerfl.Text = rec.afwerfl
                    TBafstart.Text = rec.afstart
                    TBafbedr.Text = rec.afbedr
                End If

                CMBafr.SelectedValue = rec.afr
                CMBaft.SelectedValue = rec.aft

            Next
        Catch
        End Try

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub BTNgetfile_Click(sender As Object, e As EventArgs) Handles BTNgetfile.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            'File.Copy(dialog.FileName, TBaflink.Text)
            TBaflink.Text = dialog.FileName
        End Using
    End Sub

    Private Sub BTNopenlink_Click(sender As Object, e As EventArgs) Handles BTNopenlink.Click

        If My.Computer.FileSystem.FileExists(TBaflink.Text) Then
            Process.Start(TBaflink.Text)
        Else
            MsgBox("Document niet gevonden.")
        End If
    End Sub


End Class