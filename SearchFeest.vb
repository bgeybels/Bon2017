Imports System.Linq.Dynamic
Imports System.Data.SqlClient

Imports System.IO
Imports System.Net

Imports Newtonsoft.Json.Linq

Public Class SearchFeest
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlString As String
    Dim sqlTask As String
    Dim convalArray() As String
    Dim responseFromServer As String

    Private ordDGREC As String = "FDATE"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = False

    Private Sub SearchFeest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormBorderStyle = FormBorderStyle.Sizable

        TSButtonPermissions(TSBnew)
        TSButtonPermissions(TSBdelete)

        Fltbonjr.Value = My.Settings.fltbonjr

        nofilter = False
        hkey = keyfeest
        SetGrids()
        keyfeest = hkey
        Fill_DGREC()
        keyfeest = hkey
        SetRECrow()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub

    '****FUNCTIONS
    Private Sub Refresh_data()
        updategrid = False
        If keyfeest = 0 Then keyfeest = 1
        hkey = keyfeest
        Fill_DGREC()
        keyfeest = hkey
        SetRECrow()
        keyfeest = hkey
        updategrid = True
    End Sub

    Private Sub SetRECrow()
        For lp = 0 To DGREC.Rows.Count - 1
            If DGREC.Rows(lp).Cells("FID").Value = keyfeest Then
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
            From feest In db.FEESTs
            Select feest.FID, feest.FDATE, feest.FYYYY, feest.FMM, feest.FDD, Naam = feest.FNM

        If Me.ordDGREC = Nothing Then ordDGREC = "FDATE"
        records = records.OrderBy(Me.ordDGREC, SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        On Error GoTo ErrorFILL
        'set invisible
        Dim dginvisible = New String() {"FID"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos = New String() {"FDATE", "FYYYY", "FMM", "FDD"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("Naam").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
ErrorFILL:
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGREC_SelectionChanged(sender As Object, e As EventArgs) Handles DGREC.SelectionChanged
        On Error GoTo NoRecords
        If updategrid = False Then Exit Sub
        keyfeest = DGREC.CurrentRow.Cells("FID").Value
NoRecords:
    End Sub

    Private Sub DGREC_CellMouseDoubleClick(sender As Object, e As EventArgs)
        'UpdateRec()
    End Sub

    Private Sub DGREC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Me.ordDGREC = DGREC.Columns(e.ColumnIndex).Name
        'MsgBox(ordDGREC)
    End Sub

    '*****FIELD ACtions
    Private Sub Addrec()
        IsNewRecord = True
        'EditFeest.ShowDialog()
        IsNewRecord = False
        Refresh_data()
    End Sub

    Private Sub UpdateRec()
        keyfeest = DGREC.CurrentRow.Cells("FID").Value
        'EditFeest.ShowDialog()
        Refresh_data()
    End Sub

    Private Sub DeleteRec()
        Try
            Dim deleterec = (From feest In db.FEESTs
                             Where feest.FID = keyfeest).ToList()(0)
            db.FEESTs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
            keyfeest = 0
        Catch
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Schrappen niet gelukt!")
        End Try
        Refresh_data()
    End Sub


    '****BUTTON-KEY Actions
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
        If MsgBox("Verwijder feestdag?", MsgBoxStyle.YesNoCancel, "Wil je deze feestdag echt verwijderen?") = MsgBoxResult.Yes Then
            DeleteRec()
        End If
    End Sub

    '****Filters
    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        If CBfilteryear.Checked = True Then
            records = records.Where("FYYYY.Contains(@0)", Fltbonjr.Value.ToString())
        End If
    End Sub

    Private Sub BT_getfeest_Click(sender As Object, e As EventArgs) Handles BT_getfeest.Click
        If MsgBox("Feestdagen ophalen voor jaar " & Fltbonjr.Value & "? Bestaande worden overschreven!", MsgBoxStyle.YesNoCancel, "Ophalen feestdagen") = MsgBoxResult.Yes Then
            UpdateFeestdagen()
        End If
    End Sub

    Private Sub UpdateFeestdagen()
        Dim conval As String = My.Settings.BONConnectionString
        ConnectDB(conval)

        ' verwijder bestaande feestdagen
        sqlTask = "DELETE From FEEST Where FYYYY = '" & Fltbonjr.Value.ToString() & "';"
        execPC(sqlTask)

        ' haal feestdagen op
        GetFeestdagen()

        ' voeg feestdagen toe
        Dim json As String = responseFromServer
        Dim ser As JObject = JObject.Parse(json)
        Dim data As List(Of JToken) = ser.Children().ToList

        For Each item As JProperty In data
            item.CreateReader()
            Select Case item.Name
                Case "metadata"
                    'MsgBox(item.Name)
                Case "holidays"
                    For Each msg As JObject In item.Values

                        Dim fnm As String = msg("name_local")
                        Dim fyyyy As String = msg("year")
                        Dim fmm As String = msg("month")
                        If fmm.Length() = 1 Then fmm = "0" + fmm
                        Dim fdd As String = msg("month_day")
                        If fdd.Length() = 1 Then fdd = "0" + fdd
                        Dim fdate As String = fyyyy + fmm + fdd

                        sqlTask = "INSERT INTO FEEST (FDATE,FYYYY,FMM,FDD,FNM) values ("
                        sqlTask = sqlTask & "'" & fdate & "'"
                        sqlTask = sqlTask & ", " & "'" & fyyyy & "'"
                        sqlTask = sqlTask & ", " & "'" & fmm & "'"
                        sqlTask = sqlTask & ", " & "'" & fdd & "'"
                        sqlTask = sqlTask & ", " & "'" & fnm & "'"
                        sqlTask &= "); "
                        execPC(sqlTask)
                    Next
            End Select
        Next
    End Sub
    Private Sub ExecPC(sqlcmd As String)
        command = connection.CreateCommand()
        command.CommandText = sqlcmd
        command.ExecuteNonQuery()
    End Sub

    Private Sub GetFeestdagen()
        Dim apicall As String
        apicall = "https://address.whacky.nl/api/date/holiday?api_key=8ADD9919-E715-414C-B592-137253CE85AA&iso_alpha_2_country=BE&year="
        apicall += Fltbonjr.Value.ToString()
        apicall += "&output_format=yyyy-MM-dd%27T%27HH:mm:ss"
        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create(apicall)
        request.Credentials = CredentialCache.DefaultCredentials
        Dim response As WebResponse = request.GetResponse()

        'MsgBox(CType(response, HttpWebResponse).StatusDescription)

        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        responseFromServer = reader.ReadToEnd()

        reader.Close()
        response.Close()
    End Sub

    Private Sub ConnectDB(from As String)
        convalArray = Split(from, ";")
        Dim constring As String = ""
        Dim where As Integer
        Dim val As String
        Dim key As String
        Dim trusted As Boolean = True

        For i As Integer = 0 To convalArray.Length - 1
            where = InStr(convalArray(i), "=")
            If where < 1 Then Continue For
            val = Mid(convalArray(i), where + 1)
            key = Mid(convalArray(i), 1, where - 1)
            Select Case key
                Case "Data Source"
                    constring = constring + "Server=" & val & ";"
                Case "Initial Catalog"
                    constring = constring + "Database=" & val & ";"
                Case "User id"
                    constring = constring + "User Id=" & val & ";"
                    trusted = False
                Case "Password"
                    constring = constring + "Password=" & val & ";"
            End Select
        Next
        If trusted = True Then constring += "Trusted_Connection=True;"
        connection = New SqlConnection(constring)
        connection.Open()
    End Sub

    Private Sub Fltbonjr_ValueChanged(sender As Object, e As EventArgs) Handles Fltbonjr.ValueChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

    Private Sub CBfilteryear_CheckedChanged(sender As Object, e As EventArgs) Handles CBfilteryear.CheckedChanged
        If nofilter = False Then Fill_DGREC()
    End Sub

End Class