Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class EditCode
    Dim nocmdupd As Boolean = False

    Private Sub EditCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        If IsNewRecord = True Then
            Me.Text = "Code: Nieuw"
            'Me.ToolStrip1.BackColor = Color.Bisque
        End If

        nocmdupd = True
        fillCMBcodgp(ICMBcodgp)
        fillCMBper(ICMBper)
        fillCMBoaanmnm(ICMBoaanm)
        fillCMBaoms(ICMBaoms)

        Fill_DG()
        nocmdupd = False
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
        End If

        If IsNewRecord = True Then
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
        updaterec.LEV = TBlev.Text
        updaterec.Plmagazijn = TBplmagazijn.Text

        updaterec.Besteld = CBbesteld.Checked
        updaterec.notstock = CBnotstock.Checked
        updaterec.gratis = CBgratis.Checked

        updaterec.PERNM = ""
        If ICMBper.SelectedIndex > -1 Then updaterec.PERNM = ICMBper.SelectedValue
        updaterec.OAANMNM = ""
        If ICMBoaanm.SelectedIndex > -1 Then updaterec.OAANMNM = ICMBoaanm.SelectedValue
        updaterec.ANRQ = ICMBaoms.SelectedValue
        updaterec.CGNRQ = ICMBcodgp.SelectedValue

        updaterec.ChDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm
        If IsNewRecord = True Then
            updaterec.USDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        End If
        Try
            db.SubmitChanges()
            Archive("CODE_U", Str(keycgnrq), updaterec.Code & " - " & updaterec.OmsCode & " - " & updaterec.Aankp & "/" & updaterec.Perc & "/" & updaterec.Eenhp & updaterec.Stock)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim valPERNM As String = ""
        If ICMBper.SelectedIndex > -1 Then valPERNM = ICMBper.SelectedValue
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
        .LEV = TBlev.Text,
        .gratis = CBgratis.Checked,
        .usernrq = LoginNm,
        .USDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .ChDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.CODs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw record niet gelukt.")
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
        If IsNewRecord = True Then
            result = (From code In db.CODs Where (code.Code = TBcode.Text) And (code.CGNRQ = keycgnrq)
                      Select code).Count()
            TBcode.BackColor = boxcolor
            If result > 1 Then
                ToolTip1.SetToolTip(TBcode, "De code wordt reeds gebruik binnen deze groep.")
                TBcode.BackColor = boxcolorerror
                AllOK = False
            End If
        End If

        'Controle dubbele omschrijving
        If IsNewRecord = True Then
            result = (From code In db.CODs Where (code.OmsCode = TBomscode.Text) And (code.CGNRQ = keycgnrq)
                      Select code).Count()
            TBomscode.BackColor = boxcolor
            If result > 1 Then
                ToolTip1.SetToolTip(TBomscode, "De omschrijving wordt reeds gebruik binnen deze groep.")
                TBomscode.BackColor = boxcolorerror
                AllOK = False
            End If
        End If

        Return AllOK
    End Function

    Private Function PredictCode() As String
        ' voorspel voor code = xxx99 xxx999 een nieuwe code xxx99+1
        Dim codel As String
        Dim pattern As String = "[A-Za-z]{3}\d{2}"
        Dim r As Regex = New Regex(pattern, RegexOptions.IgnoreCase)
        Dim m As Match = r.Match(TBcode.Text)

        PredictCode = TBcode.Text
        If m.Success = False Then
            Exit Function
        End If

        records = From code In db.CODs
                  Where code.Code Like (Mid(TBcode.Text, 1, 3) & "*") And code.CGNRQ = keycgnrq
                  Order By code.Code
                  Select code.Code
        codel = TBcode.Text
        For Each record In records
            m = r.Match(record)
            If m.Success = True Then
                codel = record
            End If
        Next
        PredictCode = Mid(codel, 1, 3).ToUpper & Format(Mid(codel, 4, 5) + 1, "00")

    End Function

    Private Sub Velden_vullen()
        For Each rec In codrecs
            TBcode.Text = rec.code
            If IsNewRecord Then
                TBcode.Text = PredictCode()
            End If
            TBsort.Text = rec.sort
            TBomscode.Text = rec.omscode
            TBaankp.Text = rec.aankp
            TBperc.Value = rec.perc
            TBeenhp.Text = rec.eenhp
            TBstock.Text = rec.stock
            TBminstock.Text = rec.minstock
            TBmaxstock.Text = rec.maxstock
            TBlev.Text = rec.lev
            TBplmagazijn.Text = rec.plmagazijn

            CBbesteld.Checked = rec.besteld
            CBnotstock.Checked = rec.notstock
            CBgratis.Checked = rec.gratis

            ICMBaoms.SelectedValue = rec.anrq
            ICMBcodgp.SelectedValue = rec.cgnrq
            ICMBper.SelectedValue = rec.pernm
            ICMBoaanm.SelectedValue = rec.oaanmnm

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
        Dim ap As Decimal
        Dim vp As Decimal
        Dim pr As Integer

        ap = CDec(TBaankp.Text)
        vp = 0
        pr = CDec(TBperc.Value)

        vp = ap + ((ap * pr) / 100)
        vp = Math.Round(vp, 2)
        TBeenhp.Text = CStr(vp)
    End Sub

End Class