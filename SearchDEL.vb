Imports System.Linq.Dynamic
Imports System.Linq

Public Class SearchDEL
    Private ordDGREC As String = "chdate"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True
    Dim dtfilter As DateTime

    Private Sub SearchDEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Sizable

        Fltjaar.Text = DateTime.Now.ToString("yyyy")

        SetGrids()
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
                Let Wanneer = "[" & del.chdate & "]"
                Where del.chdate >= Format(FltDTPselect.Value, "#yyyy-MM-dd 00:00:00.000#") _
                And del.chdate < Format(FltDTPselectt.Value, "#yyyy-MM-dd 23:59:59.999#")
                Select del.id, Onderdeel = del.delWO, Sleutel = del.part, Wie, Wanneer, Inhoud = del.delinfo, del.usernrq, del.chdate, del.yearin
        Else
            records =
                From del In db.DELs
                Let Wie = del.usernrq
                Let Wanneer = "[" & del.chdate & "]"
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

        'DGREC.Columns("Wanneer").DefaultCellStyle.Format = "N2"

        'set autosizemode
        Dim dgautos = New String() {"Onderdeel", "Sleutel", "Inhoud", "Wie", "Wanneer"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Inhoud").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGREC.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DGREC.CurrentCell = DGREC(e.ColumnIndex, e.RowIndex)
        End If
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

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("Onderdeel.Contains(@0)", FltdelWO.Text)
        records = records.Where("Sleutel.Contains(@0)", Fltpart.Text)
        records = records.Where("Inhoud.Contains(@0)", Fltdelinfo.Text)
        records = records.Where("Wie.Contains(@0)", Fltusernrq.Text)
        records = records.Where("Wanneer.Contains(@0)", Fltjaar.Text)
    End Sub

    Private Sub TsBtnStartFilter_Click(sender As Object, e As EventArgs) Handles TsBtnStartFilter.Click
        Fill_DGREC()
    End Sub
End Class