Imports System.Linq.Dynamic
Imports System.ComponentModel

Public Class SearchAF
    Private ordDGREC As String = "SNR"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim FldEigenaar As String

    Private Sub SearchAF_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        'e.Cancel = True
    End Sub

    Private Sub SearchAF_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub

    Private Sub SearchAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        For Each a In GroupFilter.Controls
            If TypeOf a Is ComboBox Then
                If a.name Like "Flt*" Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)

        ' get values from settings
        Fltafjr.Value = My.Settings.fltbonjr

        nofilter = False
        hkey = keyafjr
        hkey2 = keyafvnr
        SetGrids()
        Fill_DGREC()
        keyafjr = hkey
        keyafvnr = hkey2
        SetRECrow()

        Fltafnr.Focus()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyafjr = 0 Then keyafjr = My.Settings.fltbonjr
        hkey = keyafjr
        hkey2 = keyafvnr
        Fill_DGREC()
        keyafjr = hkey
        keyafvnr = hkey2
        SetRECrow()
        keyafjr = hkey
        keyafvnr = hkey2
        updategrid = True

        nofilter = False
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("AFJR").Value = keyafjr And DGREC.Rows(lp).Cells("AFVNR").Value = keyafvnr Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(3)
            End If
        Next
    End Sub

    Private Sub Empty_Filters()
        Fltafnr.Text = ""
    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If CBfilteryear.Checked = True Then
            records =
                From af In db.AFs
                Join afr In db.AFRs On af.AFR Equals afr.AFRID
                Join aft In db.AFTs On af.AFT Equals aft.AFTID
                Where af.AFJR = Fltafjr.Value
                Let SNR = af.AFSORTNR
                Let Datum = af.AFDATUM
                Let Part = af.AFAP
                Let Afspraak = af.AFAFSPR
                Let Wie = af.USERNRQ & "(" & af.CHDATE & ")"
                Select af.AFJR, af.AFVNR, SNR, NR = af.AFNR, Datum, Offerte = af.AFOFF, Part, Afspraak, Reden = afr.AFRVERW, Verzonden = af.AFSEND,
                    Calculator = af.AFCALC, Link = af.AFLINK, Type = aft.AFTVERW, Start = af.AFSTART, af.AFR, af.AFT,
                     Werfleider = af.AFWERFL, Bedrag = af.AFBEDR,
                    Opmerking = af.AFOPM,
                    af.AFSORTKEY, Wie
        Else
            records =
                From af In db.AFs
                Join afr In db.AFRs On af.AFR Equals afr.AFRID
                Join aft In db.AFTs On af.AFT Equals aft.AFTID
                Let SNR = af.AFSORTNR
                Let Datum = af.AFDATUM
                Let Part = af.AFAP
                Let Afspraak = af.AFAFSPR
                Let Wie = af.USERNRQ & "(" & af.CHDATE & ")"
                Select af.AFJR, af.AFVNR, SNR, NR = af.AFNR, Datum, Offerte = af.AFOFF, Part, Afspraak, Reden = afr.AFRVERW, Verzonden = af.AFSEND,
                    Calculator = af.AFCALC, Link = af.AFLINK, Type = aft.AFTVERW, Start = af.AFSTART, af.AFR, af.AFT,
                     Werfleider = af.AFWERFL, Bedrag = af.AFBEDR,
                    Opmerking = af.AFOPM,
                    af.AFSORTKEY, Wie
        End If

        DGFILTER()
        Me.DGREC.DataSource = records
        If Me.ordDGREC = Nothing Then ordDGREC = "SNR"
        DGREC.Sort(DGREC.Columns(ordDGREC), ListSortDirection.Ascending)
        ''FillInfo()

        'If CBfilteryear.Checked = True Then SetPrintedCell()
        'set numbermode
        Dim dgnums = New String() {"Bedrag"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next

        'set invisible
        Dim dginvisible = New String() {"AFJR", "AFVNR", "AFR", "AFT", "AFSORTKEY"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next
        'set autosizemode
        Dim dgautos = New String() {"SNR", "Datum", "Reden", "Type", "Part", "Afspraak", "NR"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        'Dim dgautod = New String() {"Upl", "del", "tbw", "vs", "gstk", "uv", "part", "fnr", "cnr"}
        'For index = 0 To dgautod.GetUpperBound(0)
        'DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'Next index

        'DGREC.Columns("Part").Width = 40
        'DGREC.Columns("NR").Width = 50
        'DGREC.Columns("DatAanvang").Width = 75

        'DGREC.Columns("OmsBon").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        If DGREC.RowCount < 1 Then
            keyafjr = Fltafjr.Value
            keyafvnr = 0
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub SetPrintedCell()
        ' TODO: color certain lines
        Dim keys As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i As Integer = 0 To DGREC.Rows.Count - 1
            keys = DGREC.Rows(i).Cells("printed").Value
            If keys = True Then
                DGREC.Rows(i).Cells("NR").Style.BackColor = dgcelcolor
            End If
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keyafjr = Fltafjr.Value
        keyafvnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        'If CBfilteryear.Checked = False Then keyafjr = DGREC.CurrentRow.Cells("AFJR").Value
        keyafjr = DGREC.CurrentRow.Cells("AFJR").Value
        keyafvnr = DGREC.CurrentRow.Cells("AFVNR").Value

        ''FillInfo()

NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            keyafjr = DGREC.CurrentRow.Cells("AFJR").Value
            keyafvnr = DGREC.CurrentRow.Cells("AFVNR").Value
        End If
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs) Handles DGREC.CellMouseDoubleClick
        UpdateRec()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        EditAF.ShowDialog()
        IsNewRecord = False
        Refresh_data()
        ''FillInfo()
    End Sub

    Private Sub UpdateRec()
        If keyafvnr < 1 Then
            MsgBox("Geen record beschikbaar om te bewerken.")
            Exit Sub
        End If

        ' test lock
        Dim strkey As String = keyafjr & keyafvnr
        Dim lockedby = isLocked("AF", strkey)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("AF", strkey)

        EditAF.ShowDialog()

        hkey = keyafjr
        hkey2 = keyafvnr
        Refresh_data()
        keyafjr = hkey
        keyafvnr = hkey2
        ''FillInfo()
        keyafjr = hkey
        keyafvnr = hkey2
    End Sub

    Private Sub DeleteRec()
        If keyafvnr < 1 Then
            MsgBox("Geen record beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder deze lijn?", MsgBoxStyle.YesNoCancel, "Wil je deze lijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim deleterec = (From af In db.AFs
                             Where af.AFJR = keyafjr AndAlso af.AFVNR = keyafvnr).ToList()(0)

            db.AFs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Dim key = keyafjr & "/" & keyafvnr.ToString("0000")
            Archive("AF_D", key, "")
            keyafjr = Fltafjr.Value
            keyafvnr = 0
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
            'If (TypeOf a Is ComboBox) Then
            'If (Mid(a.name, 1, 5) = "FltCB") Then
            'a.selectedindex = 0
            'End If
            'End If
            If TypeOf a Is CheckBox Then
                If Not Mid(a.name, 1, 8) = "CBfilter" Then
                    If a.name(a.name.Length - 1) = "N" Then
                        a.checked = True
                    Else
                        a.checked = False
                    End If
                End If
            End If
        Next
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub TSBnew_Click(sender As Object, e As EventArgs) Handles TSBnew.Click
        Addrec()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TSBedit_Click(sender As Object, e As EventArgs) Handles TSBedit.Click
        UpdateRec()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        DeleteRec()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "AF")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '****Filters
    Private Sub DGFILTER()
        Dim chval As String

        If Fltafnr.Text <> "" And IsNumeric(Fltafnr.Text) Then
            records = records.Where("NR == " & Fltafnr.Text)
            Exit Sub
        End If

        chval = ""
        If (CBafapJ.Checked = True) And (CBafapN.Checked = False) Then chval = "true"
        If (CBafapN.Checked = True) And (CBafapJ.Checked = False) Then chval = "false"
        If chval <> "" Then records = records.Where("Part == " & chval)

        records = records.Where("Reden.Contains(@0)", Fltafr.Text)
        records = records.Where("Type.Contains(@0)", Fltaft.Text)
        records = records.Where("Calculator.Contains(@0)", Fltcalculator.Text)
        records = records.Where("Werfleider.Contains(@0)", Fltwerfleider.Text)
        records = records.Where("Offerte.Contains(@0)", Fltofferte.Text)
        records = records.Where("Verzonden.Contains(@0)", Fltverzonden.Text)
        records = records.Where("Opmerking.Contains(@0)", Fltopmerking.Text)
        records = records.Where("Start.Contains(@0)", Fltstart.Text)

        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
    End Sub
    Private Sub CBfilteryear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub fltafjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltafjr.ValueChanged
        keyafjr = Fltafjr.Value
        keyafvnr = 0
        'My.Settings.fltafjr = fltafjr.Value
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnr_TextChanged(sender As Object, e As EventArgs) Handles Fltafnr.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBafapJ_CheckedChanged(sender As Object, e As EventArgs) Handles CBafapJ.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBafapN_CheckedChanged(sender As Object, e As EventArgs) Handles CBafapN.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltaft_TextChanged(sender As Object, e As EventArgs) Handles Fltaft.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltafr_TextChanged(sender As Object, e As EventArgs) Handles Fltafr.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltcalculator_TextChanged(sender As Object, e As EventArgs) Handles Fltcalculator.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltwerfleider_TextChanged(sender As Object, e As EventArgs) Handles Fltwerfleider.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltofferte_TextChanged(sender As Object, e As EventArgs) Handles Fltofferte.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltverzonden_TextChanged(sender As Object, e As EventArgs) Handles Fltverzonden.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltopmerking_TextChanged(sender As Object, e As EventArgs) Handles Fltopmerking.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltstart_TextChanged(sender As Object, e As EventArgs) Handles Fltstart.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs) Handles TSBprint.Click

    End Sub
End Class