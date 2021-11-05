Imports System.Linq.Dynamic
Imports System.Linq
Public Class SearchPERStock
    Private ordDGRECP As String = "Naam"
    Private ordDGRECC As String = "Datum"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchPersStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Sizable

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(TSMInewP)

        nofilter = True
        nofilter = False

        hkey = keypernrq
        SetGrids()
        keypernrq = hkey
        Fill_DGRECP()
        keypernrq = hkey
        SetRECProw()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGRECP)
        SetGridRows(DGRECC)
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_dataP()
        updategrid = False
        If keypernrq = 0 Then keypernrq = 1
        hkey = keypernrq
        Fill_DGRECP()
        keypernrq = hkey
        SetRECProw()
        keypernrq = hkey
        updategrid = True
    End Sub

    Private Sub Refresh_dataC()
        updategrid = False
        hkey = keypernrq
        hkey2 = keypervnr
        Fill_DGRECC()
        keypernrq = hkey
        keypervnr = hkey2
        SetRECCrow()
        keypernrq = hkey
        keypervnr = hkey2
        updategrid = True
    End Sub

    Private Sub SetRECProw()
        For lp = 0 To DGRECP.Rows.Count - 1
            If DGRECP.Rows(lp).Cells("PERNRQ").Value = keypernrq Then
                DGRECP.ClearSelection()
                DGRECP.Rows(lp).Selected = True
                DGRECP.FirstDisplayedScrollingRowIndex = lp

                DGRECP.CurrentCell = DGRECP.Rows(lp).Cells(1)
            End If
        Next
    End Sub
    Private Sub SetRECCrow()
        For lp = 0 To DGRECC.Rows.Count - 1
            If DGRECC.Rows(lp).Cells("ID").Value = keypernrq And DGRECC.Rows(lp).Cells("VNR").Value = keypervnr Then
                DGRECC.ClearSelection()
                DGRECC.Rows(lp).Selected = True
                DGRECC.FirstDisplayedScrollingRowIndex = lp

                DGRECC.CurrentCell = DGRECC.Rows(lp).Cells(4)
            End If
        Next
    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGRECP()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
            From per In db.PERs
            Select per.PERNRQ,
                Sortering = per.PERSORT,
                Naam = per.PERNM,
                InDienst = per.DIENST

        If Me.ordDGRECP = Nothing Then ordDGRECP = "Naam"
        records = records.OrderBy(Me.ordDGRECP, SortOrder.Ascending = True)
        DGFILTERP()
        Me.DGRECP.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"PERNRQ", "InDienst"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGRECP.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Naam", "Sortering"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGRECP.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGRECP.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Fill_DGRECC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        records =
            From perl In db.PERLs
            Join code In db.CODs On perl.CNRQ Equals code.CNRQ
            Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
            Where perl.PERL_NRQ = keypernrq
            Let Code_ = code.Code & " (" & code.OmsCode & ")"
            Let Wie = perl.USERNRQ & " (" & perl.CHDATE & ")"
            Let Nieuw = perl.USERCRE & " (" & perl.DATECRE & ")"
            Select ID = perl.PERL_NRQ, VNR = perl.PERL_VNR,
                SEL = perl.SELREC, InBezit = perl.INBEZIT, Datum = perl.STARTDATE, perl.AANTAL,
                Groep = codgp.OmsGroep, Code_, CNRQ = code.CNRQ,
                Nieuw, Wie

        If Me.ordDGRECC = Nothing Then ordDGRECC = "Datum"
        records = records.OrderBy(Me.ordDGRECC, SortOrder.Ascending = True)
        DGFILTERC()
        Me.DGRECC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"ID", "CNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGRECC.Columns(dginvisible(index)).Visible = False
        Next
        DGRECC.Columns("Code_").HeaderText = "Code"
        ' set vaste waardes

        'DGRECC.Columns("Nieuw").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'DGRECC.Columns("Nieuw").Width = 120
        'DGRECC.Columns("Wie").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'DGRECC.Columns("Wie").Width = 120
        'set autosizemode
        Dim dgautod = New String() {"Groep", "Datum", "Nieuw", "Wie"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGRECC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautoh = New String() {"SEL", "InBezit", "VNR", "Aantal"}
        For index = 0 To dgautoh.GetUpperBound(0)
            DGRECC.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next index
        DGRECC.Columns("Code_").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'If DGREC.RowCount < 1 Then
        ' keybonlvnr = 0
        ' End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGRECP_SelectionChanged(sender As Object, e As EventArgs) Handles DGRECP.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypernrq = DGRECP.CurrentRow.Cells("PERNRQ").Value
        Fill_DGRECC()

NoRecords:
    End Sub
    Private Sub DGRECP_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGRECP.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGRECP.CurrentCell = DGRECP(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub DGRECC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGRECC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGRECC.CurrentCell = DGRECC(e.ColumnIndex, e.RowIndex)
        End If
    End Sub
    Private Sub DGRECC_SelectionChanged(sender As Object, e As EventArgs) Handles DGRECC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypervnr = DGRECC.CurrentRow.Cells("VNR").Value

NoRecords:
    End Sub

    '*****FIELD ACtions    
    Private Sub AddrecP()
        IsNewRecord = True
        EditPER.ShowDialog()
        IsNewRecord = False
        Refresh_dataP()
    End Sub

    Private Sub UpdateRecP()
        keypernrq = DGRECP.CurrentRow.Cells("PERNRQ").Value
        EditPER.ShowDialog()
        Refresh_dataP()
    End Sub

    Private Sub AddrecC()
        IsNewRecord = True
        Editperl.ShowDialog()
        IsNewRecord = False
        Refresh_dataC()
    End Sub

    Private Sub UpdateRecC()
        If keypervnr < 1 Then
            MsgBox("Geen personeel-lijn beschikbaar om te bewerken.")
            Exit Sub
        End If
        Editperl.ShowDialog()

        Refresh_dataC()
    End Sub

    Private Sub DeleteRecC()
        If keybonnr < 1 Then
            MsgBox("Geen PER-lijn beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder PER-lijn?", MsgBoxStyle.YesNoCancel, "Wil je deze PER-lijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        'If updatestock = True Then updateOK = StockUpdate("D", keycnrq, keybonjr, keybonnr, keybonlvnr, "0")
        Try
            Dim deleterec = (From perl In db.PERLs
                             Where perl.PERL_NRQ = keypernrq AndAlso perl.PERL_VNR = keypervnr).ToList()(0)

            db.PERLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keypernrq & "/" & keypervnr.ToString("0000")
            Archive("PERL_D", key, "ToDo")
            keybonlvnr = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_dataC()
    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TSMInewP_Click(sender As Object, e As EventArgs) Handles TSMInewP.Click
        AddrecP()
    End Sub

    Private Sub TSMIupdateP_Click(sender As Object, e As EventArgs) Handles TSMIupdateP.Click
        UpdateRecP()
    End Sub

    Private Sub DGRECP_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRECP.CellContentDoubleClick
        UpdateRecP()
    End Sub

    Private Sub TSMInewPL_Click(sender As Object, e As EventArgs) Handles TSMInewPL.Click
        AddrecC()
    End Sub

    Private Sub TSMIupdatePL_Click(sender As Object, e As EventArgs) Handles TSMIupdatePL.Click
        UpdateRecC()
    End Sub

    Private Sub TSMIdeletePL_Click(sender As Object, e As EventArgs) Handles TSMIdeletePL.Click
        DeleteRecC()
    End Sub

    Private Sub DGRECC_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRECC.CellContentDoubleClick
        UpdateRecC()
    End Sub

    Private Sub TSBnew_Click(sender As Object, e As EventArgs) Handles TSBnew.Click

    End Sub

    Private Sub TSBedit_Click(sender As Object, e As EventArgs) Handles TSBedit.Click

    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click

    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click

    End Sub

    '****Filters
    Private Sub DGFILTERP()
        Dim chval As String

        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Naam.Contains(@0)", Fltpernm.Text)

        chval = ""
        If (CBdienstJ.Checked = True) And (CBdienstN.Checked = False) Then chval = "true"
        If (CBdienstN.Checked = True) And (CBdienstJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("InDienst == " & chval)
    End Sub
    Private Sub DGFILTERC()

        records = records.Where("Groep.Contains(@0)", FltOmsgroep.Text)
        records = records.Where("Code_.Contains(@0)", FltCode.Text)

    End Sub

    Private Sub Fltpernm_TextChanged(sender As Object, e As EventArgs) Handles Fltpernm.TextChanged
        If nofilter = False Then Fill_DGRECP()
    End Sub

    Private Sub CBdienstJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstJ.CheckedChanged
        If nofilter = False Then Fill_DGRECP()
    End Sub

    Private Sub CBdienstN_CheckedChanged(sender As Object, e As EventArgs) Handles CBdienstN.CheckedChanged
        If nofilter = False Then Fill_DGRECP()
    End Sub

    Private Sub FltOmsgroep_TextChanged(sender As Object, e As EventArgs) Handles FltOmsgroep.TextChanged
        If nofilter = False Then Fill_DGRECC()
    End Sub

    Private Sub FltCode_TextChanged(sender As Object, e As EventArgs) Handles FltCode.TextChanged
        If nofilter = False Then Fill_DGRECC()
    End Sub

End Class