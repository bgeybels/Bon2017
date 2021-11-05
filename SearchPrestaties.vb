Imports System.Linq.Dynamic
Imports System.Linq
Imports System.ComponentModel

Public Class SearchPrestaties
    Private ordDGRECP As String = "Naam"
    Private ordDGRECPR As String = "DatumVan"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim fndarr() As String

    Private Sub SearchPrestaties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Sizable

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)
        CMButtonPermissions(TSMInewP)

        Fltbonjr.Value = My.Settings.fltbonjr

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
        SetGridRows(DGRECPR)
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
        nofilter = False
    End Sub

    Private Sub Refresh_dataPR()
        updategrid = False
        hkey = keypernrq
        hkey2 = keyprid
        Fill_DGRECPR()
        keypernrq = hkey
        keyprid = hkey2
        SetRECPRrow()
        keypernrq = hkey
        keyprid = hkey2
        updategrid = True
        nofilter = False
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
    Private Sub SetRECPRrow()
        For lp = 0 To DGRECPR.Rows.Count - 1
            If DGRECPR.Rows(lp).Cells("PRPERNRQ").Value = keypernrq And DGRECPR.Rows(lp).Cells("ID").Value = keyprid Then
                DGRECPR.ClearSelection()
                DGRECPR.Rows(lp).Selected = True
                DGRECPR.FirstDisplayedScrollingRowIndex = lp

                DGRECPR.CurrentCell = DGRECPR.Rows(lp).Cells(5)
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

    Private Sub Fill_DGRECPR()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        recordsd =
            From prest In db.PRESTs
            Join psector In db.PSECTORs On psector.PSID Equals prest.PRPSID
            Join ptype In db.PTYPEs On ptype.PTID Equals prest.PRPTID
            Where prest.PRPERNRQ = keypernrq
            Let Wie = prest.USERNRQ & " (" & prest.CHDATE & ")"
            Let Totaal = prest.PRPTTOT
            Let DatumVan = prest.PRDATE
            Let DatumTot = prest.PRDATEU
            Select prest.PRPERNRQ, ID = prest.PRID, prest.PRYEAR,
                DatumVan, DatumTot, Aantal = prest.PRAANTAL, Sector = psector.PSVERW, Type = ptype.PTVERW, Totaal,
                Wie

        If Me.ordDGRECPR = Nothing Then ordDGRECPR = "DatumVan"
        recordsd = recordsd.OrderBy(Me.ordDGRECPR, SortOrder.Ascending = True)
        DGFILTERPR()
        Me.DGRECPR.DataSource = recordsd
        If Me.ordDGRECPR = Nothing Then ordDGRECPR = "DatumVan"
        Me.DGRECPR.Sort(Me.DGRECPR.Columns(ordDGRECPR), ListSortDirection.Descending)

        'set invisible
        Dim dginvisible = New String() {"PRPERNRQ", "ID", "PRYEAR"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGRECPR.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautod = New String() {"DatumVan", "DatumTot", "Aantal", "Sector", "Totaal", "Type", "Wie"}
        For index = 0 To dgautod.GetUpperBound(0)
            DGRECPR.Columns(dgautod(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        'Dim dgautoh = New String() {"SEL", "InBezit", "VNR", "Aantal"}
        'For index = 0 To dgautoh.GetUpperBound(0)
        ' DGRECPR.Columns(dgautoh(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        ' Next index
        DGRECPR.Columns("Wie").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        fndarr = GetSELPrestFigures(DGRECPR).split("#")
        If fndarr(0) = "Y" Then
        End If
        TBResultPREST.Text = fndarr(1)

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FillInfoRow()
        Dim prtuser As String = ""
        Dim prtdate As String = ""
        Dim nullfield As String = ""

        If nofilter = True Then Exit Sub
        TBResultPERS2.Text = ""
        TBResultPERSH2.Text = ""
        TBResultPERSH.Text = ""
        TBResultPERS.Text = ""
        Dim perrec = From per In db.PERs
                     Where per.PERNRQ = keypernrq
                     Select per.PERNM, per.PERTEL, per.PERGSM, per.PERGSMW, per.PERICE, per.PERDTID, per.PERDTCT, per.PERDTUD
                     Take 1

        Dim extra As String = ""
        For Each rec In perrec
            TBResultPERSH.Text += Environment.NewLine
            TBResultPERSH.Text += "In Dienst    : " & Environment.NewLine
            TBResultPERSH.Text += "Vast Contract: " & Environment.NewLine
            TBResultPERSH.Text += "Uit Dienst   : "

            TBResultPERS.Text += rec.PERNM & Environment.NewLine
            nullfield = ""
            If Not rec.PERDTID Is Nothing Then
                nullfield = rec.PERDTID
            End If
            TBResultPERS.Text += nullfield & Environment.NewLine
            nullfield = ""
            If Not rec.PERDTCT Is Nothing Then
                nullfield = rec.PERDTCT
            End If
            TBResultPERS.Text += nullfield & Environment.NewLine
            nullfield = ""
            If Not rec.PERDTUD Is Nothing Then
                nullfield = rec.PERDTUD
            End If
            TBResultPERS.Text += nullfield

            TBResultPERSH2.Text += "GSM     : " & Environment.NewLine
            TBResultPERSH2.Text += "GSM-Werk: " & Environment.NewLine
            TBResultPERSH2.Text += "Tel     : " & Environment.NewLine
            TBResultPERSH2.Text += "ICE     : "

            TBResultPERS2.Text += rec.PERGSM & Environment.NewLine
            TBResultPERS2.Text += rec.PERGSMW & Environment.NewLine
            TBResultPERS2.Text += rec.PERTEL & Environment.NewLine
            TBResultPERS2.Text += rec.PERICE
        Next

    End Sub

    Private Sub DGRECP_SelectionChanged(sender As Object, e As EventArgs) Handles DGRECP.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keypernrq = DGRECP.CurrentRow.Cells("PERNRQ").Value
        Fill_DGRECPR()
        FillInfoRow()

NoRecords:
    End Sub
    Private Sub DGRECPR_SelectionChanged(sender As Object, e As EventArgs) Handles DGRECPR.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        ''keypernrq = DGRECPR.CurrentRow.Cells("PRPERNRQ").Value
        keyprid = DGRECPR.CurrentRow.Cells("ID").Value
NoRecords:
    End Sub

    Private Sub DGRECP_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGRECP.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGRECP.CurrentCell = DGRECP(e.ColumnIndex, e.RowIndex)
        End If
    End Sub
    Private Sub DGRECPR_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGRECPR.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGRECPR.CurrentCell = DGRECPR(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    '*****FIELD ACtions    
    Private Sub AddrecP()
        IsNewRecord = True
        EditPER.ShowDialog()
        IsNewRecord = False
        Refresh_dataP()
        FillInfoRow()
    End Sub

    Private Sub UpdateRecP()
        keypernrq = DGRECP.CurrentRow.Cells("PERNRQ").Value

        ' test lock
        Dim lockedby = isLocked("PER", keypernrq)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("PER", keypernrq)

        EditPER.ShowDialog()
        Refresh_dataP()
        FillInfoRow()
    End Sub

    Private Sub AddrecPR()
        IsNewRecord = True
        EditPrest.ShowDialog()
        IsNewRecord = False
        Refresh_dataPR()
    End Sub

    Private Sub UpdateRecPR()
        If keyprid < 1 Then
            MsgBox("Geen personeel-lijn beschikbaar om te bewerken.")
            Exit Sub
        End If

        ' test lock
        Dim lockedby = isLocked("PREST", keyprid)
        If lockedby <> "" Then
            MsgBox("Record momenteel in gebruik door " & lockedby)
            Exit Sub
        End If
        ' lock het record
        Dim lock = lockrec("PREST", keyprid)

        EditPrest.ShowDialog()

        Refresh_dataPR()
    End Sub

    Private Sub DeleteRecPR()
        If keyprid < 1 Then
            MsgBox("Geen Prestatie-lijn beschikbaar om te verwijderen.")
            Exit Sub
        End If
        If MsgBox("Verwijder Prestatie-lijn?", MsgBoxStyle.YesNoCancel, "Wil je deze Prestatie-lijn echt verwijderen?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim deleterec = (From prest In db.PRESTs
                             Where prest.PRID = keyprid).ToList()(0)

            db.PRESTs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()

            perrecs = From per In db.PERs
                      Where per.PERNRQ = keypernrq
                      Select per.PERNRQ, per.PERNM
            Dim keynaam As String = ""
            For Each perrec In perrecs
                keynaam = perrec.pernm
            Next
            Dim key = keyprid.ToString("0000")
            Archive("PREST_D", key, keynaam)

            keyprid = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_dataPR()
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

    Private Sub DGRECPR_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRECPR.CellContentDoubleClick
        UpdateRecPR()
    End Sub

    Private Sub TSMInewPL_Click(sender As Object, e As EventArgs) Handles TSMInewPL.Click
        AddrecPR()
    End Sub

    Private Sub TSMIupdatePL_Click(sender As Object, e As EventArgs) Handles TSMIupdatePL.Click
        UpdateRecPR()
    End Sub

    Private Sub TSMIdeletePL_Click(sender As Object, e As EventArgs) Handles TSMIdeletePL.Click
        DeleteRecPR()
    End Sub

    Private Sub TSBnew_Click(sender As Object, e As EventArgs) Handles TSBnew.Click
        AddrecPR()
    End Sub

    Private Sub TSBedit_Click(sender As Object, e As EventArgs) Handles TSBedit.Click
        UpdateRecPR()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        DeleteRecPR()
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

    Private Sub DGFILTERPR()
        If CBfilteryear.Checked = True Then
            recordsd = recordsd.Where("PRYEAR == " & Fltbonjr.Value)
        End If
        recordsd = recordsd.Where("Wie.Contains(@0)", Fltusernrq.Text)
        recordsd = recordsd.Where("Type.Contains(@0)", Flttype.Text)
        recordsd = recordsd.Where("Sector.Contains(@0)", Fltsector.Text)
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

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        If nofilter = False Then Fill_DGRECPR()
    End Sub

    Private Sub CBfilteryear_CheckedChanged_1(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGRECPR()
    End Sub

    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs) Handles Fltusernrq.TextChanged
        If nofilter = False Then Fill_DGRECPR()
    End Sub

    Private Sub Fltsector_TextChanged(sender As Object, e As EventArgs) Handles Fltsector.TextChanged
        If nofilter = False Then Fill_DGRECPR()
    End Sub

    Private Sub Flttype_TextChanged(sender As Object, e As EventArgs) Handles Flttype.TextChanged
        If nofilter = False Then Fill_DGRECPR()
    End Sub
End Class