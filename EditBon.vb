Imports System.ComponentModel

Public Class Editbon
    Dim nocmdupd As Boolean = False

    Private Sub Editbon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Bon: Bewerken (key=" & keybonjr & "/" & keybonnr & ")"
        If IsNewRecord = True Then
            'TSBPrintBon.Enabled = False
            Me.Text = "Bon: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If
        FillCMBeigenaar(CMBeigenaar)

        nocmdupd = True
        Fill_DG()
        nocmdupd = False
        Velden_vullen()

        DTPdatumaanvang.Focus()

    End Sub
    Private Sub Editbon_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewRecord = False Then
            Dim strkey As String = keybonjr & keybonnr
            Dim unlock = unlockrec("BON", strkey)
        End If

        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From bon In db.BONs
                      Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr
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

        Dim updaterec = (From bon In db.BONs
                         Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr).ToList()(0)

        updaterec.DatumAanvang = DTPdatumaanvang.Value
        updaterec.tav = TBtav.Text
        updaterec.OPM = TBopm.Text

        Dim tyx = CMBtype.SelectedItem
        updaterec.bon_type = tyx.Substring(0, 1)

        updaterec.dvan = DTPdvan.Text
        updaterec.dtot = DTPdtot.Text
        If CBcok.CheckState = 1 Then
            TBcnr.Text = DBFact(keybonjr, keybonnr, "C")
        Else
            TBcnr.Text = 0
        End If
        updaterec.cnr = TBcnr.Text
        If CBfok.CheckState = 1 Then
            TBfnr.Text = DBFact(keybonjr, keybonnr, "D")
        Else
            TBfnr.Text = 0
        End If
        updaterec.fnr = TBfnr.Text
        updaterec.cok = CBcok.CheckState
        updaterec.fok = CBfok.CheckState
        updaterec.PART = CBpart.CheckState
        updaterec.klaar = CBklaar.CheckState
        updaterec.del = CBdel.CheckState
        updaterec.tbw = CBtbw.CheckState
        updaterec.vs = CBvs.CheckState
        updaterec.gstk = CBgstk.CheckState
        updaterec.uv = CBuv.CheckState
        updaterec.OmsBon = TBomsbon.Text
        updaterec.dtot = DTPdtot.Value
        updaterec.dvan = DTPdvan.Value
        updaterec.ENRQ = CMBeigenaar.SelectedValue
        updaterec.KNRQ = keyknrq

        updaterec.chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        'updaterec.chdate = sysdate & DateTime.Now.ToString("HH:mm:ss")
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
        .DatumAanvang = DTPdatumaanvang.Value,
        .OmsBon = TBomsbon.Text,
        .Particulier = 0,
        .Betaald = 0,
        .printed = 0,
        .tav = TBtav.Text,
        .OPM = TBopm.Text,
        .dvan = DTPdvan.Text,
        .dtot = DTPdtot.Text,
        .cnr = Format(TBcnr.Text, "0"),
        .fnr = Format(TBfnr.Text, "0"),
        .fok = CBfok.CheckState,
        .cok = CBcok.CheckState,
        .PART = CBpart.CheckState,
        .klaar = CBklaar.CheckState,
        .del = CBdel.CheckState,
        .tbw = CBtbw.CheckState,
        .vs = CBvs.CheckState,
        .gstk = CBgstk.CheckState,
        .uv = CBuv.CheckState,
        .bon_type = tyx.Substring(0, 1),
        .usernrq = LoginNm,
        .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.BONs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
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
        setklant(0)
        DTPdatumaanvang.Value = SysDate
        DTPdvan.Value = SysDate
        DTPdtot.Value = SysDate
        TBtav.Text = ""
        TBopm.Text = ""
        TBomsbon.Text = ""
        CBdel.Checked = 0
        CBvs.Checked = 0
        CBgstk.Checked = 0
        CBuv.Checked = 0
        CBfok.Checked = 0
        CBcok.Checked = 0
        CBpart.Checked = 0
        CBklaar.Checked = 0
        CMBeigenaar.SelectedItem = 1

        LBLboninfo.Text = keybonjr & "/" & keybonnr
        If IsNewRecord = True Then LBLboninfo.Text = keybonjr & "/" & "..."
        CMBtype.SelectedItem = "Onbekend"
        Try
            For Each rec In records
                keyknrq = rec.knrq
                setklant(keyknrq)

                If IsNewRecord = True Then
                    DTPdatumaanvang.Value = SysDate
                    DTPdvan.Value = SysDate
                    DTPdtot.Value = SysDate
                    TBomsbon.Text = ""
                    TBtav.Text = ""
                    TBopm.Text = ""
                    CBdel.Checked = 0
                    CBvs.Checked = 0
                    CBgstk.Checked = 0
                    CBuv.Checked = 0
                    CBfok.Checked = 0
                    CBpart.Checked = 0
                    CBklaar.Checked = 0
                    CBtbw.Checked = 0
                    TBfnr.Text = 0
                    TBcnr.Text = 0
                    CBcok.Checked = 0
                Else
                    DTPdatumaanvang.Value = rec.datumaanvang
                    DTPdvan.Value = rec.dvan
                    DTPdtot.Value = rec.dtot
                    TBomsbon.Text = rec.omsbon
                    TBtav.Text = rec.tav
                    TBopm.Text = rec.opm
                    CBdel.Checked = rec.del
                    CBvs.Checked = rec.vs
                    CBtbw.Checked = rec.tbw
                    CBgstk.Checked = rec.gstk
                    CBuv.Checked = rec.uv
                    CBfok.Checked = rec.fok
                    CBpart.Checked = rec.part
                    CBklaar.Checked = rec.klaar
                    TBfnr.Text = rec.fnr
                    TBcnr.Text = rec.cnr
                    CBcok.Checked = rec.cok
                End If

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
                    Case "N"
                        CMBtype.SelectedItem = "Nazorg"
                    Case "G"
                        CMBtype.SelectedItem = "Groenonderhoud"
                    Case Else
                        CMBtype.SelectedItem = "Onbekend"
                End Select
            Next
        Catch ex As Exception

        End Try

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub zoekKlant_Click(sender As Object, e As EventArgs) Handles ZoekKlant.Click
        keyklantnrq = keyknrq
        frompopup = True
        SearchKlant.ShowDialog()
        frompopup = False
        keyknrq = keyklantnrq
        setklant(keyknrq)
    End Sub

    '****Functions
    Private Sub setklant(key As Integer)
        Dim klantnaam As String
        klantnaam = GetKlantInfo(key)
        lblKLANTinfo.Text = klantnaam
    End Sub

    Private Sub PrintBon_Click(sender As Object, e As EventArgs) Handles TSBPrintBon.Click
        If Savedata() = True Then
            ExportToBonNaCalc(keybonjr, keybonnr)
        End If
    End Sub

    Private Sub TSBCopyBon_Click(sender As Object, e As EventArgs) Handles TSBCopyBon.Click
        ' Nieuwjaar = ToJaar
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If CopyBON(keybonjr) = False Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Kopieer Bon(lijnen) niet gelukt!")
            Exit Sub
        End If

        My.Settings.fltbonjr = keybonjr
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Close()
    End Sub


End Class