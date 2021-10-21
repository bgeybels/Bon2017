Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchKlant
    Private ordDGREC As String = "KNaam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchKlant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(NieuwToolStripMenuItem)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        hkey = keyklantnrq
        SetGrids()
        fill_DGREC()
        keyklantnrq = hkey
        SetRECrow()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyklantnrq = 0 Then keyklantnrq = 1
        hkey = keyklantnrq
        Fill_DGREC()
        keyklantnrq = hkey
        SetRECrow()
        keyklantnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("KNRQ").Value = keyklantnrq Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(1)
            End If
        Next
    End Sub


    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
        From klant In db.KLANTs
        Let Adres = klant.KStraat & " " & klant.KAdres
        Let Werf = klant.KWStraat & " " & klant.KWAdres
        Let Wie = klant.usernrq & " (" & klant.chdate & ")"
        Let Gebruikt = klant.USDate
        Select klant.KNRQ,
            klant.KNaam, Adres, Werf,
            Wie, Gebruikt

        If Me.ordDGREC = Nothing Then ordDGREC = "KNaam"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGKLANTFILTER()
        Me.DGREC.DataSource = records
        'Me.DGREC.Refresh()

        'set invisible
        Dim dginvisible = New String() {"KNRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"KNaam", "Adres", "Werf", "Wie", "Gebruikt"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("KNaam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyklantnrq = DGREC.CurrentRow.Cells("KNRQ").Value
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.DoubleClick
        UpdateRec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGREC.ColumnHeaderMouseClick 'i
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        EditKlant.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyklantnrq = DGREC.CurrentRow.Cells("KNRQ").Value
        EditKlant.ShowDialog()

        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From bon In db.BONs
                       Where bon.KNRQ = keyklantnrq
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Klant <" & DGREC.CurrentRow.Cells("KNaam").Value & "> nog gebruikt in bonnen!")
            Exit Sub
        End If

        Try
            Dim deleterec = (From klant In db.KLANTs
                             Where klant.KNRQ = keyklantnrq).ToList()(0)
            db.KLANTs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("KLANT_D", Str(keyklantnrq), deleterec.KNaam & " - " & deleterec.KStraat & "/" & deleterec.KAdres & " ( " & deleterec.KGSM & ")")
            keyklantnrq = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
        Next
        nofilter = False
        fill_DGREC()
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuwToolStripMenuItem.Click
        TSBnew.PerformClick()
    End Sub

    Private Sub TSBnew_Click(sender As Object, e As EventArgs) Handles TSBnew.Click
        Addrec()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub BewerkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BewerkToolStripMenuItem.Click
        TSBedit.PerformClick()
    End Sub

    Private Sub TSBedit_Click(sender As Object, e As EventArgs) Handles TSBedit.Click
        UpdateRec()
    End Sub

    Private Sub VerwijderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderToolStripMenuItem.Click
        TSBdelete.PerformClick()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        If MsgBox("Verwijder klant?", MsgBoxStyle.YesNoCancel, "Wil je deze klant echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Dim excelFile = New ExcelFile()

        ' Foreach DataTable in DataSet:
        ' 1. Create new worksheet and set it as active.
        ' 2. Insert DataTable to active worksheet.
        ' 3. Save active worksheet to CSV file.
        For Each dataTable As DataTable In DataSet.Tables
            excelFile.Worksheets.ActiveWorksheet = excelFile.Worksheets.Add(dataTable.TableName)
            excelFile.Worksheets.ActiveWorksheet.InsertDataTable(dataTable, "A1", True)
            excelFile.SaveCsv(dataTable.TableName + ".csv", CsvType.CommaDelimited)
        Next
    End Sub

    Private Sub ToonBonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToonBonlijnenToolStripMenuItem.Click
        TSBDetail.PerformClick()
    End Sub

    Private Sub TSBDetail_Click(sender As Object, e As EventArgs) Handles TSBDetail.Click
        filterstr = getKlantNaam(keyklantnrq)
        FrmBONE.Show()
        'Me.Close()
    End Sub


    '****Filters
    Private Sub DGKLANTFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("KNaam.Contains(@0)", Fltklant.Text)
        records = records.Where("Adres.Contains(@0)", Fltadres.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub
    Public Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltadres_TextChanged(sender As Object, e As EventArgs) Handles Fltadres.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltwerf_TextChanged(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then fill_DGREC()
    End Sub
End Class