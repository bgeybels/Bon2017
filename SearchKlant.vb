Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchKlant
    Private ordDGREC As String = "Naam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchKlant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If
        If frompopup = False Then
            TSBexit.Image = Bon2017.My.Resources.Resources.home
        Else
            TSBexit.Image = Bon2017.My.Resources.Resources.homered
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
        Let Upload = klant.FAC
        Select klant.KNRQ, Upload,
            Naam = klant.KNaam, Adres, Werf,
            Wie, Gebruikt = klant.USDate

        If Me.ordDGREC = Nothing Then ordDGREC = "Naam"
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
        Dim dgautos = New String() {"Upload", "Naam", "Adres", "Werf", "Wie", "Gebruikt"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index

        If frompopup = True Then
            Dim dginvisiblex = New String() {"Gebruikt"}
            For index = 0 To dginvisiblex.GetUpperBound(0)
                DGREC.Columns(dginvisiblex(index)).Visible = False
            Next
        End If

        DGREC.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyklantnrq = DGREC.CurrentRow.Cells("KNRQ").Value
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
        End If
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
        IsNewKlant = True

        EditKlant.ShowDialog()
        IsNewKlant = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyklantnrq = DGREC.CurrentRow.Cells("KNRQ").Value

        ' test lock
        Dim lockedby = isLocked("KLANT", keyklantnrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("KLANT", keyklantnrq)

        EditKlant.ShowDialog()

        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From bon In db.BONs
                       Where bon.KNRQ = keyklantnrq
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Klant <" & DGREC.CurrentRow.Cells("Naam").Value & "> nog gebruikt in bonnen!")
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
        Fill_DGREC()
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

    Private Sub ToonBonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToonBonlijnenToolStripMenuItem.Click
        TSBDetail.PerformClick()
    End Sub

    Private Sub TSBDetail_Click(sender As Object, e As EventArgs) Handles TSBDetail.Click
        filterstr = GetKlantNaam(keyklantnrq)
        SearchBON_NW.Show()
        'Me.Close()
    End Sub

    '****Filters
    Private Sub DGKLANTFILTER()
        Dim chval As String

        If Fltklant.Text.StartsWith("*") Then
            records = records.Where("Naam.Contains(@0)", Fltklant.Text.Remove(0, 1))
        Else
            records = records.Where("Naam.startswith(@0)", Fltklant.Text)
        End If

        chval = ""
        If (CBuploadJ.Checked = True) And (CBuploadN.Checked = False) Then chval = "J"
        If (CBuploadN.Checked = True) And (CBuploadJ.Checked = False) Then chval = "N"
        If chval <> "" Then records = records.Where("Upload.Contains(@0)", chval)

        records = records.Where("Adres.Contains(@0)", Fltadres.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub
    Public Sub Fltklant_TextChanged(sender As Object, e As EventArgs) Handles Fltklant.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltadres_TextChanged(sender As Object, e As EventArgs) Handles Fltadres.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltwerf_TextChanged(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "KLANTEN")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub CBuploadJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBuploadJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBuploadN_CheckedChanged(sender As Object, e As EventArgs) Handles CBuploadN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub UploadJaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadJaToolStripMenuItem.Click
        ' Loop over geselecteerde records en zet UPDATE=true
        UpdateSelect("J")
        Refresh_data()
    End Sub

    Private Sub UploadNeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadNeeToolStripMenuItem.Click
        ' Loop over geselecteerde records en zet UPDATE = false
        UpdateSelect("N")
        Refresh_data()
    End Sub

    Private Sub UpdateSelect(setting As String)
        Dim skeyknrq As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each row As DataGridViewRow In Me.DGREC.SelectedRows
            skeyknrq = row.Cells("KNRQ").Value
            Dim updaterecs = (From klant In db.KLANTs
                              Where klant.KNRQ = skeyknrq).ToList()(0)
            updaterecs.FAC = setting
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class