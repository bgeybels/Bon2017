Imports System.Linq.Dynamic
Imports System.ComponentModel

Public Class Searchfakt
    Private ordDGREC As String = "FNR"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub SearchFAKT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevents closing the window
        'e.Cancel = True
    End Sub

    Private Sub SearchFAKT_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'My.Settings.fltbonjr = Fltbonjr.Value
        'My.Settings.fltbontbw = FltCBtbw.SelectedIndex
    End Sub

    Private Sub SearchFAKT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        'For Each a In GroupFilter.Controls
        'If TypeOf a Is ComboBox Then
        'If a.name Like "Flt*" Then
        'FillCMBeau(a)
        'a.selectedindex = 0
        'End If
        'End If
        'Next
        ''FillCMBdc(FltCBcnr)

        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(VerwijderToolStripMenuItem)

        nofilter = False
        ' get values from settings
        Fltbonjr.Value = My.Settings.fltbonjr
        '      CMBtype.SelectedIndex = 1
        NFltCBtype.SelectedItem = "Verkoop"
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw

        hkey = keyfaktjr
        hkey2 = keyfaktnr
        hkeystr = keyfaktdc
        SetGrids()
        Fill_DGREC()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkeystr
        SetRECrow()
    End Sub


    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyfaktjr = 0 Then keyfaktjr = My.Settings.fltbonjr
        hkey = keyfaktjr
        hkey2 = keyfaktnr
        hkeystr = keyfaktdc
        Fill_DGREC()
        keybonjr = hkey
        keybonnr = hkey2
        keyfaktdc = hkeystr
        SetRECrow()
        keyfaktjr = hkey
        keyfaktnr = hkey2
        keyfaktdc = hkeystr
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        Dim count As Integer = 0
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("JR").Value = keyfaktjr And DGREC.Rows(lp).Cells("NR").Value = keyfaktnr And DGREC.Rows(lp).Cells("DC").Value = keyfaktdc Then
                DGREC.ClearSelection()
                DGREC.Rows(lp).Selected = True
                DGREC.FirstDisplayedScrollingRowIndex = lp

                DGREC.CurrentCell = DGREC.Rows(lp).Cells(1)
            End If
        Next
    End Sub

    Private Sub FillInfo()
        TBResultFAKTL.Text = " Faktuur: " & keyfaktjr & "/" & keyfaktfnr.ToString("0000") & "-" & keyfaktdc & "  (Totaal aantal fakturen: " & DGREC.RowCount & ")"
        TBResultFAKTL.Text = TBResultFAKTL.Text & Environment.NewLine & GetFaktlFigures(keybonjr, keybonnr)
    End Sub

    Private Sub FillInfoSEL()
        'TBResultFAKT
        TBResultFAKT.Text = GetSELFaktlFigures(DGREC)
    End Sub
    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If (CBfilteryear.Checked = True) And (CBfilterdatum.Checked = False) Then
            records =
                    From fakt In db.FAKTs
                    Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                    Where fakt.JAAR = Fltbonjr.Value
                    Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                    Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.fakt_bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
                        fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
                        Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
                        fakt.KNaam, fakt.Werf,
                        EIGENAAR = eigenaar.ENaam, Wie
        ElseIf (CBfilteryear.Checked = True) And (CBfilterdatum.Checked = True) Then
            records = From fakt In db.FAKTs
                      Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                      Where fakt.JAAR = Fltbonjr.Value _
                      And fakt.dvan >= Format(FltDatumvan.Value, "#yyyy-MM-dd 00:00:00.000#") _
                      And fakt.dtot < Format(Fltdatumtot.Value, "#yyyy-MM-dd 23:59:59.999#")
                      Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                      Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.fakt_bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
                fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
                Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
                fakt.KNaam, fakt.Werf,
                EIGENAAR = eigenaar.ENaam, Wie
        ElseIf (CBfilterdatum.Checked = True) Then
            records =
                From fakt In db.FAKTs
                Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                Where fakt.JAAR = Fltbonjr.Value _
                      And fakt.dvan >= Format(FltDatumvan.Value, "#yyyy-MM-dd 00:00:00.000#") _
                      And fakt.dtot < Format(Fltdatumtot.Value, "#yyyy-MM-dd 23:59:59.999#")
                Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.fakt_bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
            fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
            Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
            fakt.KNaam, fakt.Werf,
            EIGENAAR = eigenaar.ENaam, Wie
        Else
            records =
                From fakt In db.FAKTs
                Join eigenaar In db.EIGENAARs On fakt.ENRQ Equals eigenaar.ENRQ
                Let Wie = fakt.usernrq & " (" & fakt.chdate & ")"
                Select JR = fakt.JAAR, NR = fakt.NR, Type = fakt.fakt_bon_type, DC = fakt.DC, fakt.FNR, WJR = fakt.WJAAR,
                        fakt.Datin, Start = fakt.dvan, Einde = fakt.dtot,
                        Inclusief = fakt.tbedrag, Exclusief = fakt.teenhp, BTW = fakt.tbtw, NaCalc = fakt.fakt_ncalc,
                        fakt.KNaam, fakt.Werf,
                        EIGENAAR = eigenaar.ENaam, Wie
        End If

        DGFILTER()
        Me.DGREC.DataSource = records
        If Me.ordDGREC = Nothing Then ordDGREC = "FNR"
        Me.DGREC.Sort(Me.DGREC.Columns(ordDGREC), ListSortDirection.Descending)

        'set numbermode
        Dim dgnums = New String() {"Inclusief", "Exclusief", "BTW", "NaCalc"}
        For index = 0 To dgnums.GetUpperBound(0)
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Format = "N2"
            DGREC.Columns(dgnums(index)).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next

        'set invisible
        'Dim dginvisible = New String() {"KNRQ", "fok", "cok", "printed"}
        'For index = 0 To dginvisible.GetUpperBound(0)
        'DGREC.Columns(dginvisible(index)).Visible = False
        'Next
        'set autosizemode
        Dim dgautos = New String() {"FNR", "WJR", "Datin", "Start", "Einde", "Inclusief", "Exclusief", "BTW", "NACalc", "KNaam", "Wie"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        Dim dgautod = New String() {"JR", "NR", "DC", "Type", "EIGENAAR", "Type"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGREC.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next index
        DGREC.Columns("Werf").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DGREC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If DGREC.RowCount < 1 Then
            keyfaktjr = Fltbonjr.Value
            keyfaktnr = 0
        End If

        FillInfo()
        FillInfoSEL()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        keyfaktjr = Fltbonjr.Value
        keyfaktnr = 0
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        'If CBfilteryear.Checked = False Then keybonjr = DGREC.CurrentRow.Cells("JR").Value
        keyfaktjr = DGREC.CurrentRow.Cells("JR").Value
        keyfaktnr = DGREC.CurrentRow.Cells("NR").Value
        keyfaktfnr = DGREC.CurrentRow.Cells("FNR").Value
        keyfaktdc = DGREC.CurrentRow.Cells("DC").Value

        FillInfo()

NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
            keyfaktjr = DGREC.CurrentRow.Cells("JR").Value
            keyfaktnr = DGREC.CurrentRow.Cells("NR").Value
            keyfaktfnr = DGREC.CurrentRow.Cells("FNR").Value
            keyfaktdc = DGREC.CurrentRow.Cells("DC").Value
        End If
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub DeleteRec()
        If keyfaktnr < 1 Then
            MsgBox("Geen faktuur beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Wil je deze faktuur en bijhorende faktuurlijnen echt verwijderen?", MsgBoxStyle.YesNoCancel, "Verwijder faktuur?") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim bonlinked As Boolean = False
        If keyfaktdc = "D" Then
            Dim checkrec = From bon In db.BONs Where bon.BONJR = keyfaktjr And bon.BONNR = keyfaktnr And bon.fnr = keyfaktfnr
            If checkrec.Count > 0 Then
                bonlinked = True
            End If
        Else
            Dim checkrec = From bon In db.BONs Where bon.BONJR = keyfaktjr And bon.BONNR = keyfaktnr And bon.cnr = keyfaktfnr
            If checkrec.Count > 0 Then
                bonlinked = True
            End If
        End If
        If bonlinked = True Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Faktuur " & keyfaktjr & "/" & keyfaktnr & " is nog gelinkt in bon!")
            Exit Sub
        End If

        Try
            Dim delsrec = (From fakt In db.FAKTs
                           Where fakt.JAAR = keyfaktjr AndAlso fakt.NR = keyfaktnr AndAlso fakt.DC = keyfaktdc).ToList()(0)

            db.FAKTs.DeleteOnSubmit(delsrec)
            db.SubmitChanges()
            Dim key = keyfaktjr & "/" & keyfaktnr.ToString("0000") & "-" & keyfaktdc
            Archive("FAKT_D", key, delsrec.KNaam)
            keyfaktjr = Fltbonjr.Value

        Catch
            'PositionMsgbox.CenterMsgBox(Me)
            'MsgBox("Schrappen faktuur niet gelukt!")
        End Try
        DelFAKTL(keyfaktjr, keyfaktnr, keyfaktdc)
        keyfaktnr = 0
        Refresh_data()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs) Handles BTN_FilterReset.Click
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    a.selectedindex = 0
                End If
            End If
            If TypeOf a Is CheckBox Then
                a.checked = False
            End If
        Next
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub VerwijderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderToolStripMenuItem.Click
        TSBdelete.PerformClick()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        ' Voeg nog een test toe of gebruikt in bonnen!!!!
        DeleteRec()
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ExportToCSV(DGREC, "FAKTUUR")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TSBprint_Click(sender As Object, e As EventArgs) Handles TSBprint.Click
        MsgBox("Todo: Print")
    End Sub


    '****Filters
    Private Sub DGFILTER()
        Dim chval As String
        If Fltnr.Text <> "" Then
            records = records.Where("NR == " & Fltnr.Text)
            Exit Sub
        End If

        If ChkBType.Checked = True Then
            Dim tyx = NFltCBtype.SelectedItem.substring(0, 1)
            records = records.Where("Type.equals(@0)", tyx)
            ' updaterec.bon_type = tyx.Substring(0, 1)
        End If

        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("KNaam.Contains(@0)", Fltknaam.Text)
        records = records.Where("Werf.Contains(@0)", Fltwerf.Text)
        If CBfilterwyear.Checked = True Then
            records = records.Where("WJR.equals(@0)", Convert.ToInt32(FltWJR.Value))
        End If

        chval = ""
        If (CBcnrD.Checked = True) And (CBcnrC.Checked = False) Then chval = "D"
        If (CBcnrC.Checked = True) And (CBcnrD.Checked = False) Then chval = "C"
        If chval <> "" Then records = records.Where("DC.equals(@0)", chval)
    End Sub

    Private Sub CBfilteryear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub CBfilterwyear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilterwyear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        keybonjr = Fltbonjr.Value
        keybonnr = 0
        If (nofilter = False) And (CBfilteryear.Checked = True) Then Fill_DGREC()
    End Sub
    Private Sub Fltwjr_ValueChanged(sender As Object, e As EventArgs) Handles FltWJR.ValueChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltknaam_TextChanged(sender As Object, e As EventArgs) Handles Fltknaam.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltwerf_TextChanged(sender As Object, e As EventArgs) Handles Fltwerf.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltnr_TextChanged(sender As Object, e As EventArgs) Handles Fltnr.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub ToonFaktuurlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToonFaktuurlijnenToolStripMenuItem.Click
        plook = False
        SearchFAKTL.MdiParent = MDIbon
        SearchFAKTL.WindowState = FormWindowState.Maximized
        SearchFAKTL.Show()
    End Sub

    Private Sub FltCBtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NFltCBtype.SelectedIndexChanged
        If nofilter = False Then
            If ChkBType.Checked = True Then
                Fill_DGREC()
            End If
        End If
    End Sub

    Private Sub ChkBType_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBType.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcnrD_CheckedChanged(sender As Object, e As EventArgs) Handles CBcnrD.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBcnrC_CheckedChanged(sender As Object, e As EventArgs) Handles CBcnrC.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfilterdatum_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilterdatum.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class