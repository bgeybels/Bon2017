Imports System.ComponentModel
Imports System.Linq.Dynamic
Imports System.Text.RegularExpressions

Public Class EditCode
    Dim nocmdupd As Boolean = False
    Dim keepep As Decimal

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valnostock As Boolean

        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Code: Bewerken (key=" & keycnrq & ")"
        If IsNewCode = True Then
            Me.Text = "Code: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If

        nocmdupd = True
        FillCMBcodgp(ICMBcodgp)
        FillCMBper(ICMBper)
        FillCMBlev(ICMBlev)
        FillCMBoaanmnm(ICMBoaanm)
        FillCMBaoms(ICMBaoms)

        CBkmheffing.Enabled = False
        If LoginSysAdmin = True Then
            CBkmheffing.Enabled = True
        End If

        Fill_DG()
        nocmdupd = False
        Velden_vullen()

        If IsNewCode = True Then
            valnostock = GetCodgpValues(ICMBcodgp.SelectedValue)
            CBnotstock.Checked = valnostock

        End If
    End Sub
    Private Sub EditCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' unlock record (niet voor nieuwe records)
        If IsNewCode = False Then
            Dim unlock = unlockrec("CODE", keycnrq)
        End If
        IsNewCode = False
        SetAllColors()
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        codrecs = From cod In db.CODs
                  Where cod.CNRQ = keycnrq
                  Take 1
    End Sub

    '****FIELDActions
    Private Function Savedata() As Boolean
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
            Exit Function
        End If

        If IsNewCode = True Then
            SaveNEW()
            Return True
            Exit Function
        End If

        Dim updaterec = (From code In db.CODs
                         Where code.CNRQ = keycnrq).ToList()(0)

        updaterec.Code = TBcode.Text
        updaterec.sort = TBsort.Text
        updaterec.OmsCode = TBomscode.Text
        updaterec.Aankp = TBaankp.Text
        updaterec.Perc = TBperc.Value
        updaterec.Eenhp = TBeenhp.Text
        updaterec.Stock = TBstock.Text
        updaterec.Minstock = TBminstock.Text
        updaterec.Maxstock = TBmaxstock.Text
        updaterec.Plmagazijn = TBplmagazijn.Text

        updaterec.Besteld = CBbesteld.Checked
        updaterec.notstock = CBnotstock.Checked
        updaterec.gratis = CBgratis.Checked
        updaterec.KMHEFFING = CBkmheffing.Checked

        updaterec.PERNM = ""
        If ICMBper.SelectedIndex > -1 Then updaterec.PERNM = ICMBper.SelectedValue
        updaterec.LEV = ""
        If ICMBlev.SelectedIndex > -1 Then updaterec.LEV = ICMBlev.SelectedValue
        updaterec.OAANMNM = ""
        If ICMBoaanm.SelectedIndex > -1 Then updaterec.OAANMNM = ICMBoaanm.SelectedValue
        updaterec.ANRQ = ICMBaoms.SelectedValue
        updaterec.CGNRQ = ICMBcodgp.SelectedValue

        updaterec.ChDate = ChDate
        updaterec.usernrq = LoginNm
        If IsNewCode = True Then
            updaterec.ChDate = ChDate
        End If
        Try
            db.SubmitChanges()
            Archive("CODE_U", Str(keycgnrq), updaterec.Code & " - " & updaterec.OmsCode & " - " & updaterec.Aankp & "/" & updaterec.Perc & "/" & updaterec.Eenhp & updaterec.Stock)
            If ((keepep = 0) And (keepep <> TBeenhp.Text)) Or ((TBeenhp.Text = 0) And (keepep <> TBeenhp.Text)) Then
                If MsgBox("Prijswijziging (" & keepep & " naar " & TBeenhp.Text & ") toepassen op alle (exclusief bonnen met Factuur/Creditnota) bonlijnen?", MsgBoxStyle.YesNoCancel, "Aanpassen prijs") = MsgBoxResult.Yes Then
                    UpdateBONLS()
                End If
            End If
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim valPERNM As String = ""
        If ICMBper.SelectedIndex > -1 Then valPERNM = ICMBper.SelectedValue
        Dim valLEV As String = ""
        If ICMBlev.SelectedIndex > -1 Then valLEV = ICMBlev.SelectedValue
        Dim valOAANMNM As String = ""
        If ICMBoaanm.SelectedIndex > -1 Then valOAANMNM = ICMBoaanm.SelectedValue

        Dim newrec As New COD With {
        .CGNRQ = ICMBcodgp.SelectedValue,
        .Code = TBcode.Text,
        .OmsCode = TBomscode.Text,
        .OmsLong = "",
        .Eenhp = TBeenhp.Text,
        .EenhpO = TBeenhp.Text,
        .Aankp = TBaankp.Text,
        .ANRQ = ICMBaoms.SelectedValue,
        .milieu = 0,
        .Perc = TBperc.Value,
        .sort = TBsort.Text,
        .Besteld = CBbesteld.Checked,
        .Minstock = TBminstock.Text,
        .Maxstock = TBmaxstock.Text,
        .Stock = TBstock.Text,
        .OStock = TBstock.Text,
        .Plmagazijn = TBplmagazijn.Text,
        .notstock = CBnotstock.Checked,
        .lupdate = "",
        .PERNM = valPERNM,
        .select = 0,
        .OAANMNM = valOAANMNM,
        .LEV = valLEV,
        .gratis = CBgratis.Checked,
        .KMHEFFING = CBkmheffing.Checked,
        .usernrq = LoginNm,
        .USDate = ChDate,
        .ChDate = ChDate
        }

        db.CODs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keycnrq = newrec.CNRQ
        Archive("CODE_N", Str(keycnrq), "")
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True
        Dim result As Integer = 0

        Dim TBNum() As TextBox = New TextBox() {TBaankp, TBeenhp, TBstock, TBminstock, TBmaxstock}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) Then
                ToolTip1.SetToolTip(TB, "Veld moet numerisch zijn.")
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        'Controle dubbele Code
        If IsNewCode = True Then
            result = (From code In db.CODs Where (code.Code = TBcode.Text) And (code.CGNRQ = keycgnrq)
                      Select code).Count()
            TBcode.BackColor = boxcolor
            If result > 1 Then
                ToolTip1.SetToolTip(TBcode, "De code wordt reeds gebruik binnen deze groep.")
                TBcode.BackColor = boxcolorerror
                AllOK = False
            End If
        End If

        TBomscode.BackColor = boxcolor
        'Controle dubbele omschrijving
        If IsNewCode = True Then
            result = (From code In db.CODs Where (code.OmsCode = TBomscode.Text) And (code.CGNRQ = keycgnrq)
                      Select code).Count()

            If result > 1 Then
                ToolTip1.SetToolTip(TBomscode, "De omschrijving wordt reeds gebruik binnen deze groep.")
                TBomscode.BackColor = boxcolorerror
                AllOK = False
            End If
        End If
        If Len(TBomscode.Text) > 50 Then
            TBomscode.BackColor = boxcolorerror
            AllOK = False
        End If

        Return AllOK
    End Function

    Private Sub UpdateBONLS()
        Dim bonlrecs = From bonl In db.BONLs
                       Join bon In db.BONs On bon.BONJR Equals bonl.BONJR And bon.BONNR Equals bonl.BONNR
                       Where bonl.CNRQ = keycnrq And bon.fok = False And bon.cok = False
                       Select bonl.BONJR, bonl.BONNR, bonl.BONLVNR

        For Each bonlrec In bonlrecs

            Dim updaterec = (From bonl In db.BONLs
                             Where bonl.BONJR = bonlrec.BONJR And bonl.BONNR = bonlrec.BONNR And bonl.BONLVNR = bonlrec.BONLVNR).ToList()(0)

            updaterec.BONEenhp = TBeenhp.Text
            updaterec.usernrq = LoginNm
            updaterec.chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")

            Try
                db.SubmitChanges()
            Catch
                MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
            End Try
        Next
        MsgBox(bonlrecs.Count & " bonlijnen werden aangepast.")

    End Sub

    Private Function PredictCode() As String
        ' voorspel voor code = xxx99 xxx999 een nieuwe code xxx99+1
        Dim codel As String
        Dim pattern As String = "\b[A-Za-z]{3}\d{2}"
        Dim r As Regex = New Regex(pattern, RegexOptions.IgnoreCase)
        Dim m As Match = r.Match(TBcode.Text)

        PredictCode = TBcode.Text
        If m.Success = False Then
            Exit Function
        End If

        records = From code In db.CODs
                  Where code.CGNRQ = keycgnrq
                  Order By code.Code
                  Select code.Code, code.CGNRQ
        records = records.Where("Code.Contains(@0)", Mid(TBcode.Text, 1, 3))
        codel = TBcode.Text
        For Each record In records
            m = r.Match(record.Code)
            If m.Success = True Then
                codel = record.Code
            End If
        Next
        'PredictCode = Mid(codel, 1, 3).ToUpper & Format(Mid(codel, 4, 5) + 1, "00")
        PredictCode = Mid(codel, 1, 3) & Format(Mid(codel, 4, 5) + 1, "00")

    End Function

    Private Sub Velden_vullen()
        keycgnrq = 0
        For Each rec In codrecs
            TBcode.Text = rec.code

            TBsort.Text = rec.sort
            TBomscode.Text = rec.omscode
            TBaankp.Text = rec.aankp
            TBperc.Value = rec.perc
            TBeenhp.Text = rec.eenhp
            keepep = TBeenhp.Text
            TBstock.Text = rec.stock
            TBminstock.Text = rec.minstock
            TBmaxstock.Text = rec.maxstock
            TBplmagazijn.Text = rec.plmagazijn

            CBbesteld.Checked = rec.besteld
            CBnotstock.Checked = rec.notstock
            CBgratis.Checked = rec.gratis
            CBkmheffing.Checked = rec.kmheffing

            ICMBaoms.SelectedValue = rec.anrq
            ICMBcodgp.SelectedValue = rec.cgnrq
            keycgnrq = rec.cgnrq
            ICMBper.SelectedValue = rec.pernm
            ICMBlev.SelectedValue = rec.lev
            ICMBoaanm.SelectedValue = rec.oaanmnm

            If IsNewCode Then
                TBcode.Text = PredictCode()
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

    Private Sub TBperc_ValueChanged(sender As Object, e As EventArgs) Handles TBperc.ValueChanged
        updateprice()
    End Sub

    Private Sub TBaankp_TextChanged(sender As Object, e As EventArgs) Handles TBaankp.TextChanged
        If Not IsNumeric(TBaankp.Text) Then TBaankp.Text = 0
        updateprice()
    End Sub

    Private Sub updateprice()
        Dim ap As Decimal
        Dim vp As Decimal
        Dim pr As Integer
        Dim rondaf As Integer

        rondaf = 0
        If keycgnrq <> 0 Then
            records = From codgp In db.CODGPs
                      Where codgp.CGNRQ = keycgnrq
                      Take 1
            For Each rec In records
                rondaf = rec.rondaf
            Next
        End If

        ap = CDec(TBaankp.Text)
        vp = 0
        pr = CDec(TBperc.Value)

        vp = ap + ((ap * pr) / 100)
        Select Case rondaf
            Case -1
                Dim words As String() = CStr(vp).Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
                Dim result As String = "0,00"
                If words.Length > 1 Then
                    Dim onechar As String = (words(1)(0))
                    Select Case CInt(onechar)
                        Case < 5
                            result = words(0) + ",00"
                        Case > 5
                            result = CStr(CInt(words(0)) + 1) + ",00"
                        Case Else
                            result = words(0) + ",50"
                    End Select
                Else
                    result = words(0) + ",00"
                End If

                'vp = vp + (vp Mod 0.5)
                ' vp = Math.Round(vp, 2, MidpointRounding.AwayFromZero)
                TBeenhp.Text = result
            Case Else
                'OK
                TBeenhp.Text = FormatNumber(CStr(vp), 2)
        End Select
        TBeenhp.Text = FormatNumber(CStr(TBeenhp.Text), 2)
        'TBeenhp.Text = CStr(vp)
    End Sub

    Private Sub ICMBcodgp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ICMBcodgp.SelectedIndexChanged
        Try
            keycgnrq = ICMBcodgp.SelectedValue
        Catch
        End Try
    End Sub

    Private Sub BewerkGroepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkGroepToolStripMenuItem.Click
        EditCodgp.ShowDialog()
        hkey = keycgnrq
        FillCMBcodgp(ICMBcodgp)
        keycgnrq = hkey
        ICMBcodgp.SelectedValue = keycgnrq
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuwToolStripMenuItem.Click
        IsNewRecord = True
        EditCodgp.ShowDialog()
        hkey = keycgnrq
        FillCMBcodgp(ICMBcodgp)
        keycgnrq = hkey
        ICMBcodgp.SelectedValue = keycgnrq
    End Sub
End Class