Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchStockHist
    Private ordDGREC As String = "sdat"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchStockHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        nofilter = True
        FillCMBcodgp(CMBcodgp)
        CMBcodgp.SelectedIndex = 0
        keycgnrq = CMBcodgp.SelectedValue
        nofilter = False

        SetGrids()
        Fill_DGREC()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        Fill_DGREC()
        updategrid = True
    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
            From stock In db.STOCKs
            Join cod In db.CODs On stock.stcnrq Equals cod.CNRQ
            Select stock.STID, stock.stcgnrq, stock.stcnrq, Code = stock.stcode,
                OmsCode = stock.stomscode, OmsGroep = stock.stomsgroep,
                Transformatie = stock.strans, Aantal = stock.saantal, Stock = cod.Stock, Omschrijving = stock.soms, LaatsteAanpassing = cod.lupdate, stock.sdat
            Order By sdat Descending

        'If Me.ordDGREC = Nothing Then ordDGREC = "sdat"
        'records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = 1)
        DGCODFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"STID", "STCNRQ", "STCGNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Code", "OmsCode", "Stock", "OmsGroep", "Transformatie", "Aantal", "LaatsteAanpassing", "sdat"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        DGREC.Columns("Omschrijving").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GrBFilters.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
        Next
        CBFltGrp.Checked = True
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        MsgBox("TODO: Exporteer naar excel")
    End Sub


    '****Filters
    Private Sub DGCODFILTER()

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        If CBFltGrp.Checked = True Then records = records.Where("STCGNRQ.Equals(@0)", keycgnrq)
        records = records.Where("OmsGroep.Contains(@0)", Fltomsgroep.Text)
        records = records.Where("Code.Contains(@0)", Fltcode.Text)
        records = records.Where("OmsCode.Contains(@0)", Fltomscode.Text)
        records = records.Where("LaatsteAanpassing.Contains(@0)", Fltusernrq.Text)
        records = records.Where("Omschrijving.Contains(@0)", FltOmschrijving.Text)

    End Sub
    Public Sub Fltcode_TextChanged(sender As Object, e As EventArgs) Handles Fltcode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltomscode_TextChanged(sender As Object, e As EventArgs) Handles Fltomscode.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltomsgroep_TextChanged(sender As Object, e As EventArgs) Handles Fltomsgroep.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub CBFltGrp_CheckedChanged(sender As Object, e As EventArgs) Handles CBFltGrp.CheckedChanged
        If nofilter = False Then
            Fill_DGREC()
        End If
    End Sub
    Private Sub CMBcodgp_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMBcodgp.SelectedValueChanged
        On Error GoTo Troubles
        If nofilter = False Then
            keycgnrq = CMBcodgp.SelectedValue
            Fill_DGREC()
        End If
Troubles:
    End Sub

    Private Sub FltOmschrijving_TextChanged(sender As Object, e As EventArgs) Handles FltOmschrijving.TextChanged
        If nofilter = False Then
            Fill_DGREC()
        End If
    End Sub
End Class