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

        Fltbonjr.Value = My.Settings.fltbonjr
        TBtrans.Text = My.Settings.STOCKstandaardtrans
        For Each a In GrBFilters.Controls
            If TypeOf a Is ComboBox Then
                FillCMBeau(a)
                a.selectedindex = 0
            End If
        Next

        Fill_DGstock()
        Fill_DGbon()
        Fill_DGlev()
        SetGrids()
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
            .sdat = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.STOCKs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
            Archive("STOCK", Str(keycnrq), fcode & " - " & fomscode & " - " & aantal & " - " & oms)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Nieuw STOCK-record niet gelukt.")
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
        updaterec.ChDate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.usernrq = LoginNm

        Try
            db.SubmitChanges()
            Archive("CODE_S", Str(keycgnrq), updaterec.Code & " - " & updaterec.OmsCode & " - " & updaterec.Stock & " - " & oms)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen stock zijn niet opgeslagen!")
        End Try
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

    Private Sub Fill_DGbon()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records = From bon In db.BONs
                  Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                  Where bon.BONJR = Fltbonjr.Value
                  Select JR = bon.BONJR, NR = bon.BONNR, bon.fnr, klant.KNaam, Werf = bon.OmsBon, bon.tbw

        records = records.OrderBy("NR", SortOrder.Ascending = True)
        DGFbon()
        Me.DGbon.DataSource = records

        'set invisible
        '  Dim dginvisible = New String() {"JR", "TBW"}
        '  Setcolumns("V", Me.DGbon, dginvisible)

        'set autosizemode
        ' Dim dgautos = New String() {"NR", "fnr", "knaam"}
        ' Setcolumns("AC", dgbon, dgautos)
        ' DGbon.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
        SetGridRows(DGstock)
        SetGridRows(DGlev)
        SetGridRows(DGbon)
    End Sub

    '****Filters
    Private Sub DGFstock()
        records = records.Where("stcnrq.equals(@0)", keycnrq)
    End Sub
    Private Sub DGFlev()
        records = records.Where("levnaam.Contains(@0)", Fltlevnaam.Text)
    End Sub
    Private Sub DGFbon()
        Dim chval As String
        records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Werf.Contains(@0)", FLTwerf.Text)
        Select Case FltCBtbw.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("tbw == " & chval)

        Select Case FltCBfnr.SelectedItem
            Case "Aan"
                records = records.Where("fnr <> 0")
            Case "Uit"
                records = records.Where("fnr == 0")
            Case Else
                chval = ""
        End Select
    End Sub

    Private Sub Fltlevnaam_TextChanged(sender As Object, e As EventArgs) Handles Fltlevnaam.TextChanged
        Fill_DGlev()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        Fill_DGbon()
    End Sub

    Private Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        Fill_DGbon()
    End Sub

    Private Sub FltCBfnr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBfnr.SelectedIndexChanged
        Fill_DGbon()
    End Sub

    Private Sub FltCBtbw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FltCBtbw.SelectedIndexChanged
        Fill_DGbon()
    End Sub

    Private Sub FLTwerf_TextChanged(sender As Object, e As EventArgs) Handles FLTwerf.TextChanged
        Fill_DGbon()
    End Sub

    Private Sub DGbon_MouseDown(sender As Object, e As MouseEventArgs) Handles DGbon.MouseDown
        On Error GoTo notselected
        If e.Button = MouseButtons.Right Then
            TBtrans.Text = DGbon.CurrentRow.Cells("KNaam").Value & " (" & DGbon.CurrentRow.Cells("JR").Value & "/" & DGbon.CurrentRow.Cells("NR").Value & ")"
        End If
notselected:
    End Sub
    Private Sub DGlev_MouseDown(sender As Object, e As MouseEventArgs) Handles DGlev.MouseDown
        On Error GoTo notselected
        If e.Button = MouseButtons.Right Then
            TBtrans.Text = DGlev.CurrentRow.Cells("levnaam").Value
        End If
notselected:
    End Sub

End Class