Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Editfakt
    Dim nocmdupd As Boolean = False

    Private Sub Editfakt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Faktuur: Bewerken (key=" & keybonjr & "/" & keybonnr & ")"
        If IsNewRecord = True Then
            Me.Text = "Faktuur: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If
        FillCMBeigenaar(CMBeigenaar)

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()
    End Sub
    Private Sub Editfakt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From fakt In db.FAKTs
                      Where fakt.JAAR = keyfaktjr AndAlso fakt.NR = keyfaktnr
                      Take 1
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Ophalen records niet gelukt! --> " & ex.Message)
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

        Dim updaterec = (From bon In db.BONs
                         Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr).ToList()(0)

        updaterec.DatumAanvang = DTPdatin.Value
        updaterec.tav = TBtav.Text

        Dim tyx = CMBtype.SelectedItem
        updaterec.bon_type = tyx.Substring(0, 1)

        updaterec.dvan = DTPdvan.Text
        updaterec.dtot = DTPdtot.Text
        If CBcok.CheckState = 1 Then
            TBcnr.Text = DBFact(keybonjr, keybonnr, "C")
        Else
            TBcnr.Text = ""
        End If
        updaterec.cnr = Format(TBcnr.Text, "0")
        If CBfok.CheckState = 1 Then
            TBfnr.Text = DBFact(keybonjr, keybonnr, "D")
        Else
            TBfnr.Text = ""
        End If
        updaterec.fnr = Format(TBfnr.Text, "0")
        updaterec.cok = CBcok.CheckState
        updaterec.fok = CBfok.CheckState
        updaterec.OmsBon = TBomsbon.Text
        updaterec.dtot = DTPdtot.Value
        updaterec.dvan = DTPdvan.Value
        updaterec.ENRQ = CMBeigenaar.SelectedValue
        updaterec.KNRQ = keyknrq

        updaterec.chdate = ChDate
        updaterec.usernrq = LoginNm
        Try
            db.SubmitChanges()
            Dim key = keybonjr & "/" & keybonnr.ToString("0000")
            Archive("BON_U", key, TBomsbon.Text)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        If keyknrq = 0 Then keyknrq = GetFirstKlant()
        Dim newbonnr = GetHighBonNR(keybonjr)
        Dim tyx = CMBtype.SelectedItem

        Dim newrec As New BON With {
        .BONJR = keybonjr,
        .BONNR = newbonnr,
        .KNRQ = keyknrq,
        .ENRQ = CMBeigenaar.SelectedValue,
        .DatumAanvang = DTPdatin.Value,
        .OmsBon = TBomsbon.Text,
        .Particulier = 0,
        .Betaald = 0,
        .printed = 0,
        .tav = TBtav.Text,
        .dvan = DTPdvan.Text,
        .dtot = DTPdtot.Text,
        .cnr = Format(TBcnr.Text, "0"),
        .fnr = Format(TBfnr.Text, "0"),
        .fok = CBfok.CheckState,
        .cok = CBcok.CheckState,
        .bon_type = tyx.Substring(0, 1),
        .usernrq = LoginNm,
        .chdate = ChDate
        }

        db.BONs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.  Probeer opnieuw.")
            Exit Sub
            ' Handle exception.  
        End Try
        keybonjr = newrec.BONJR
        keybonnr = newrec.BONNR
        Dim key = keybonjr & "/" & keybonnr.ToString("0000")
        Archive("BON_N", key, TBomsbon.Text)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0

        Dim TBNum() As TextBox = New TextBox() {TBfnr, TBcnr}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) And Not TB.Text = "" Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        LBLfaktinfo.Text = keybonjr & "/" & keybonnr
        If IsNewRecord = True Then LBLfaktinfo.Text = keybonjr & "/" & "..."
        CMBtype.SelectedItem = "Onbekend"
        Try
            For Each rec In records
                keyknrq = rec.knrq

                If IsNewRecord = True Then
                    DTPdatin.Value = SysDate
                    DTPdvan.Value = SysDate
                    DTPdtot.Value = SysDate
                Else
                    DTPdatin.Value = rec.datumaanvang
                    DTPdvan.Value = rec.dvan
                    DTPdtot.Value = rec.dtot
                End If

                TBtav.Text = rec.tav
                TBomsbon.Text = rec.omsbon
                CBfok.Checked = rec.fnr
                CBcok.Checked = rec.cnr
                CMBeigenaar.SelectedValue = rec.enrq

                Select Case rec.bon_type
                    Case "B"
                        CMBtype.SelectedItem = "Bouw"
                    Case "V"
                        CMBtype.SelectedItem = "Verkoop"
                    Case "T"
                        CMBtype.SelectedItem = "Transport"
                    Case "C"
                        CMBtype.SelectedItem = "Container"
                    Case Else
                        CMBtype.SelectedItem = "Onbekend"
                End Select
            Next
        Catch ex As Exception

            DTPdatin.Value = SysDate
            DTPdvan.Value = SysDate
            DTPdtot.Value = SysDate
            TBtav.Text = ""
            TBomsbon.Text = ""
            CBfok.Checked = 0
            CBcok.Checked = 0
            CMBeigenaar.SelectedItem = 1

            CMBtype.SelectedItem = "Onbekend"
        End Try

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub CBfok_CheckedChanged(sender As Object, e As EventArgs) Handles CBfok.CheckedChanged

    End Sub

    '****Functions

End Class