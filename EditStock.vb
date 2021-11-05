Imports System.Linq.Dynamic
Imports System.Linq

Public Class EditStock
    Dim fcode As String
    Dim fomscode As String
    Dim fcgnrq As Integer
    Dim fgrpoms As String

    Private Sub EditStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        TBtrans.Text = My.Settings.STOCKstandaardtrans

        Fill_DGstock()
        Fill_DGlev()
        SetGrids()
        FillInfoRow()

    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBplus_Click(sender As Object, e As EventArgs) Handles TSBplus.Click
        NewStock("+", TBaantal.Value, TBtrans.Text)
    End Sub

    Private Sub TSBmin_Click(sender As Object, e As EventArgs) Handles TSBmin.Click
        NewStock("-", TBaantal.Value, TBtrans.Text)
    End Sub

    Private Sub NewStock(plusmin As String, aantal As Integer, oms As String)
        codrecs = From cod In db.CODs
                  Where cod.CNRQ = keycnrq
                  Select cod.CGNRQ, cod.Code, cod.OmsCode
                  Take 1

        fcode = ""
        fomscode = ""
        fgrpoms = ""
        fcgnrq = 0
        UpdateCOD(aantal, plusmin, oms)

        Dim newrec As New STOCK With {
            .stcgnrq = fcgnrq,
            .stcnrq = keycnrq,
            .stcode = fcode,
            .stomscode = fomscode,
            .stomsgroep = fgrpoms,
            .strans = plusmin,
            .saantal = aantal,
            .soms = oms & " [" & plusmin & aantal & " " & "(" & LoginNm & " - " & SysDate & " " & DateTime.Now.ToString("HH:mm:ss") & ")]",
            .sdat = ChDate
        }

        db.STOCKs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
            Archive("STOCK", Str(keycnrq), fcode & " - " & fomscode & " - " & aantal & " - " & oms)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        Close()
    End Sub

    Private Sub UpdateCOD(aantal As Integer, plusmin As String, oms As String)
        Dim updaterec = (From code In db.CODs
                         Where code.CNRQ = keycnrq).ToList()(0)

        fcode = updaterec.Code
        fomscode = updaterec.OmsCode
        fcgnrq = updaterec.CGNRQ

        Dim codgprecs = (From codgp In db.CODGPs
                         Where codgp.CGNRQ = fcgnrq).ToList()(0)
        fgrpoms = codgprecs.OmsGroep

        If plusmin = "+" Then
            If CB_OudeStock.Checked = False Then updaterec.Stock = updaterec.Stock + aantal
            If (My.Settings.STOCKupdateclosed = True) Or (CB_OudeStock.Checked = True) Then
                updaterec.OStock = updaterec.OStock + aantal
            End If
        Else
            If CB_OudeStock.Checked = False Then updaterec.Stock = updaterec.Stock - aantal
            If (My.Settings.STOCKupdateclosed = True) Or (CB_OudeStock.Checked = True) Then
                updaterec.OStock = updaterec.OStock - aantal
            End If
        End If
        updaterec.lupdate = plusmin & aantal & " " & oms
        updaterec.ChDate = ChDate
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("CODE_S", Str(keycgnrq), updaterec.Code & " - " & updaterec.OmsCode & " - " & updaterec.Stock & " - " & oms)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
    End Sub

    Private Sub FillInfoRow()
        TBResultCODE.Text = ""
        Dim codrec = From cod In db.CODs
                     Where cod.CNRQ = keycnrq
                     Select cod.Code, cod.OmsCode, cod.Stock, cod.Minstock, cod.Eenhp, cod.Aankp, cod.Plmagazijn, cod.Besteld, cod.notstock, cod.gratis
                     Take 1

        Dim extra As String = ""
        For Each rec In codrec
            TBResultCODE.Text = TBResultCODE.Text & rec.Code & " (" & rec.OmsCode & ")" & Environment.NewLine
            TBResultCODE.Text = TBResultCODE.Text & "Stock: " & rec.Stock & "    Minimum Stock: " & rec.Minstock & "   (" & rec.Plmagazijn & ")"
            TBResultCODE.Text = TBResultCODE.Text & Environment.NewLine & " AP: " & rec.Aankp & "  VP: " & rec.Eenhp
            If rec.gratis = True Then extra = extra & "Gratis "
            If rec.notstock = True Then extra = extra & "Niet_opgenomen_in_Stock "
            If rec.Besteld = True Then extra = extra & "In_Bestelling"
            TBResultCODE.Text = TBResultCODE.Text & Environment.NewLine & extra
        Next

    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGstock()
        'keycnrq
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records = From stock In db.STOCKs
                  Select stock.stcnrq, stock.sdat, stock.strans, stock.soms

        records = records.OrderBy("sdat", SortOrder.Ascending = True)
        DGFstock()
        Me.DGstock.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"stcnrq"}
        Setcolumns("V", DGstock, dginvisible)

        'set autosizemode
        Dim dgautos = New String() {"sdat", "strans", "soms"}
        Setcolumns("AC", DGstock, dgautos)

        DGstock.Columns("soms").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Fill_DGlev()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records = From lev In db.LEVs
                  Select lev.LEVnrq, lev.LEVnaam

        records = records.OrderBy("levnaam", SortOrder.Ascending = True)
        DGFlev()
        Me.DGlev.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"levnrq"}
        Setcolumns("V", DGlev, dginvisible)

        DGlev.Columns("levnaam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Setcolumns(what As String, dg As DataGridView, dginv As String())
        For index = 0 To dginv.GetUpperBound(0)
            Select Case what
                Case "V"
                    dg.Columns(dginv(index)).Visible = False
                Case "AC"
                    dg.Columns(dginv(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End Select
        Next
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        SetGridRows(DGstock)
        SetGridRows(DGlev)
    End Sub

    '****Filters
    Private Sub DGFstock()
        records = records.Where("stcnrq.equals(@0)", keycnrq)
    End Sub

    Private Sub DGFlev()
        records = records.Where("levnaam.Contains(@0)", Fltlevnaam.Text)
    End Sub

    Private Sub Fltlevnaam_TextChanged(sender As Object, e As EventArgs) Handles Fltlevnaam.TextChanged
        Fill_DGlev()
    End Sub

    Private Sub DGlev_MouseDown(sender As Object, e As MouseEventArgs) Handles DGlev.MouseDown
        On Error GoTo notselected
        If e.Button = MouseButtons.Right Then
            TBtrans.Text = DGlev.CurrentRow.Cells("levnaam").Value
        End If
notselected:
    End Sub

End Class