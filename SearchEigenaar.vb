Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchEigenaar
    Private ordDGREC As String = "Naam"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchEigenaar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        hkey = keyeigenaarnrq
        SetGrids()
        Fill_DGREC()
        keyeigenaarnrq = hkey
        SetRECrow()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyeigenaarnrq = 0 Then keyeigenaarnrq = 1
        hkey = keyeigenaarnrq
        Fill_DGREC()
        keyeigenaarnrq = hkey
        SetRECrow()
        keyeigenaarnrq = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("ENRQ").Value = keyeigenaarnrq Then
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
        From eigenaar In db.EIGENAARs
        Let Firma = eigenaar.EFirma
        Let Naam = eigenaar.ENaam
        Let Email = eigenaar.EEMail
        Let Adres = eigenaar.EStraat & " " & eigenaar.EAdres
        Let Telefoon = eigenaar.ETel
        Let GSM = eigenaar.EGSM
        Let Fax = eigenaar.EFax
        Let BTWnr = eigenaar.EBTWNr
        Let Rekening = eigenaar.EREKNR
        Let Wie = eigenaar.usernrq & " (" & eigenaar.chdate & ")"
        Select eigenaar.ENRQ, Firma, Naam, Email, Adres, Telefoon, GSM, Fax, BTWnr, Rekening,
            Wie

        If Me.ordDGREC = Nothing Then ordDGREC = "Naam"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records
        'Me.DGREC.Refresh()

        'set invisible
        Dim dginvisible = New String() {"ENRQ"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Firma", "Naam", "Email", "Adres", "Telefoon", "GSM", "Fax", "BTWnr", "Rekening", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("ENRQ").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGREC.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyeigenaarnrq = DGREC.CurrentRow.Cells("ENRQ").Value
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
        EditEigenaar.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyeigenaarnrq = DGREC.CurrentRow.Cells("ENRQ").Value
        EditEigenaar.ShowDialog()

        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Dim checkrec = From bon In db.BONs
                       Where bon.ENRQ = keyeigenaarnrq
        If checkrec.Count > 0 Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Eigenaar " & keyeigenaarnrq & " nog gebruikt in bonnen!")
            Exit Sub
        End If
        Try
            Dim deleterec = (From eigenaar In db.EIGENAARs
                             Where eigenaar.ENRQ = keyeigenaarnrq).ToList()(0)
            db.EIGENAARs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("EIGENAAR_D", Str(keyeigenaarnrq), deleterec.ENaam & " - " & deleterec.EFirma)
            keyeigenaarnrq = 0
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
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        If MsgBox("Verwijder eigenaar?", MsgBoxStyle.YesNoCancel, "Wil je deze eigenaar echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' 'FilterKlant.ShowDialog()
        ' Dim f As New FilterKlant
        ' Try
        ' f.Owner = Me
        ' f.ShowDialog()
        ' Finally
        ' f.Dispose()
        ' End Try
    End Sub


    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Naam.Contains(@0)", Fltnaam.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub
    Public Sub Fltnaam_TextChanged(sender As Object, e As EventArgs) Handles Fltnaam.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged_1(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class