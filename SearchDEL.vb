Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchDEL
    Private ordDGREC As String = "chdate"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim dtfilter As DateTime

    Private Sub SearchDEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Sizable

        TSButtonPermissions(TSBdelete)
        Fltjaar.Text = DateTime.Now.ToString("yyyy")

        SetGrids()
        Fill_DGREC()
        nofilter = False
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

        If CBfltdate.Checked = True Then
            records =
                From del In db.DELs
                Let Wie = del.usernrq
                Let Wanneer = del.chdate
                Where del.chdate > Format(FltDTPselect.Value, "#yyyy-MM-dd 00:00:00.000#") _
                    And del.chdate < Format(FltDTPselect.Value, "#yyyy-MM-dd 00:00:00.000#")
                Select del.id, Onderdeel = del.delWO, Sleutel = del.part, Wie, Wanneer, Inhoud = del.delinfo, del.usernrq, del.chdate, del.yearin

        Else
            records =
                From del In db.DELs
                Let Wie = del.usernrq
                Let Wanneer = del.chdate
                Select del.id, Onderdeel = del.delWO, Sleutel = del.part, Wie, Wanneer, Inhoud = del.delinfo, del.usernrq, del.chdate, del.yearin
        End If

        If Me.ordDGREC = Nothing Then ordDGREC = "id"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Descending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible = New String() {"id", "usernrq", "chdate", "yearin"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"Onderdeel", "Sleutel", "Inhoud", "Wie", "Wanneer"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Inhoud").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub


    '*****FIELD ACtions
    Private Sub DeleteRec()
        Try
            ' HIER NOG DE CORRECTE FILTER ZETTEN!!!!!
            Dim deleterec = (From del In db.DELs).ToList()(0)

            db.DELs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            Archive("ARCHIEF_D", "FULL", "Volledige reset van archief door " & LoginNm)
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Reset Archief niet gelukt!")
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

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TSBdelete_Click(sender As Object, e As EventArgs) Handles TSBdelete.Click
        If MsgBox("Uitzuiveren archief?", MsgBoxStyle.YesNoCancel, "Wil je deze archiefrecords verwijderen?") = MsgBoxResult.Yes Then
            MsgBox("ToDo: " & SysDate)
            ' MsgBox(SysDate.value - 365)
            'DeleteRec()
        End If
    End Sub

    Private Sub TSBexport_Click(sender As Object, e As EventArgs) Handles TSBexport.Click
        MsgBox("Exporteer naar CSV")
    End Sub

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Onderdeel.Contains(@0)", FltdelWO.Text)
        records = records.Where("Sleutel.Contains(@0)", Fltpart.Text)
        records = records.Where("Inhoud.Contains(@0)", Fltdelinfo.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("yearin.Contains(@0)", Fltjaar.Text)
    End Sub

    Private Sub FltdelWO_TextChanged(sender As Object, e As EventArgs) Handles FltdelWO.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltpart_TextChanged(sender As Object, e As EventArgs) Handles Fltpart.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltdelinfo_TextChanged(sender As Object, e As EventArgs) Handles Fltdelinfo.TextChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltusernrq_TextChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub
    Private Sub Fltchdate_TextChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltDTPselect_ValueChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfltdate_CheckedChanged(sender As Object, e As EventArgs)
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub FltDTPselect_ValueChanged_1(sender As Object, e As EventArgs) Handles FltDTPselect.ValueChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfltdate_CheckedChanged_1(sender As Object, e As EventArgs) Handles CBfltdate.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub Fltjaar_ValueChanged(sender As Object, e As EventArgs) Handles Fltjaar.ValueChanged
        If nofilter = False Then Fill_DGREC()
    End Sub
End Class