Imports System.Data.SqlClient
Imports System.Linq.Dynamic
Public Class EditParameters
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqltask As String
    Dim convalArray() As String

    Private Sub EditParameters_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub EditParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Bepaalde onderdelen toegankelijk maken voor iedereen???")
        SetColors()
        TBjaarcopy.Value = My.Settings.JaarCopy
        TBTotalsAllowed.Text = My.Settings.TotalsAllowed
        FillCMBcodgp(CMBcodgp)
        CMBcodgp.SelectedValue = My.Settings.XCode


        ' lockings
        SetGrids()
        Fill_DGREC()
    End Sub

    ' Private Sub setcolor(TB As TextBox, valcolor As String)
    ' Dim TBcolor As Color = ColorTranslator.FromHtml(valcolor)
    '     TB.BackColor = TBcolor
    ' End Sub

    Private Sub setcolor(TB As TextBox, valcolor As String)
        Try
            Dim colour As Color = ColorTranslator.FromWin32(valcolor)
            TB.Text = valcolor
            TB.BackColor = colour
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem bij kleurzetten! --> " & ex.Message)
        End Try
    End Sub

    Private Sub SetColors()
        setcolor(TBGRIDrowseven, My.Settings.GRIDrowseven)
        setcolor(TBGRIDrowsodd, My.Settings.GRIDrowsodd)
        setcolor(TBGRIDforecoloreven, My.Settings.GRIDforecoloreven)
        setcolor(TBGRIDforecolorodd, My.Settings.GRIDforecolorodd)
        setcolor(TBDISPtextboxerror, My.Settings.DISPtextboxerror)
        setcolor(TBDISPtextboxbackcolor, My.Settings.DISPtextboxbackcolor)
        setcolor(TBGRIDcellnotused, My.Settings.GRIDcellnotused)
        setcolor(TBGRIDcellgratis, My.Settings.GRIDcellgratis)
        setcolor(TBGRIDcellmemo, My.Settings.GRIDcellmemo)
        setcolor(TBGridSelectieVoorgrond, My.Settings.GRIDselectfg)
        setcolor(TBGridSelectieAchtergrond, My.Settings.GRIDselectbg)

        TBSTOCKstandaardtrans.Text = My.Settings.STOCKstandaardtrans
        CBSTOCKupdateclosed.Checked = My.Settings.STOCKupdateclosed

        TBfirstfnr.Text = My.Settings.FirstFNR
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        My.Settings.GRIDrowseven = TBGRIDrowseven.Text
        My.Settings.GRIDrowsodd = TBGRIDrowsodd.Text
        My.Settings.GRIDforecoloreven = TBGRIDforecoloreven.Text
        My.Settings.GRIDforecolorodd = TBGRIDforecolorodd.Text
        My.Settings.DISPtextboxerror = TBDISPtextboxerror.Text
        My.Settings.DISPtextboxbackcolor = TBDISPtextboxbackcolor.Text
        My.Settings.GRIDcellnotused = TBGRIDcellnotused.Text
        My.Settings.GRIDcellmemo = TBGRIDcellmemo.Text
        My.Settings.GRIDcellgratis = TBGRIDcellgratis.Text
        My.Settings.GRIDselectbg = TBGridSelectieAchtergrond.Text
        My.Settings.GRIDselectfg = TBGridSelectieVoorgrond.Text

        My.Settings.STOCKstandaardtrans = TBSTOCKstandaardtrans.Text
        My.Settings.STOCKupdateclosed = CBSTOCKupdateclosed.CheckState

        My.Settings.FirstFNR = TBfirstfnr.Text

        My.Settings.JaarCopy = TBjaarcopy.Value
        My.Settings.TotalsAllowed = TBTotalsAllowed.Text
        My.Settings.XCode = CMBcodgp.SelectedValue
    End Sub

    Private Sub TBreset_Click(sender As Object, e As EventArgs) Handles TBreset.Click
        setcolor(TBGRIDrowseven, "13893118")
        TBGRIDrowseven.Text = "13893118"
        setcolor(TBGRIDrowsodd, "1048575")
        TBGRIDrowsodd.Text = "1048575"

        setcolor(TBGRIDforecoloreven, "0")
        TBGRIDforecoloreven.Text = "0"
        setcolor(TBGRIDforecolorodd, "0")
        TBGRIDforecolorodd.Text = "0"

        setcolor(TBDISPtextboxerror, "255")
        TBDISPtextboxerror.Text = "255"
        setcolor(TBDISPtextboxbackcolor, "16777215")
        TBDISPtextboxbackcolor.Text = "16777215"

        setcolor(TBGRIDcellnotused, "7642362")
        TBGRIDcellnotused.Text = "7642362"

        setcolor(TBGRIDcellgratis, "65280")
        TBGRIDcellgratis.Text = "65280"

        setcolor(TBGRIDcellmemo, "16022884")
        TBGRIDcellmemo.Text = "16022884"

    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub BTNGridEvenAchtergrond_Click(sender As Object, e As EventArgs) Handles BTNGridEvenAchtergrond.Click
        SelectColor(TBGRIDrowseven)
    End Sub

    Private Sub BTNGridOnEvenAchtergrond_Click(sender As Object, e As EventArgs) Handles BTNGridOnEvenAchtergrond.Click
        SelectColor(TBGRIDrowsodd)
    End Sub

    Private Sub SelectColor(TB As TextBox)
        Dim MyDialog As New ColorDialog()
        MyDialog.AllowFullOpen = True
        MyDialog.ShowHelp = True
        MyDialog.Color = TBGRIDrowseven.BackColor

        If (MyDialog.ShowDialog() = DialogResult.OK) Then
            TB.BackColor = MyDialog.Color
            Dim colour As Integer = ColorTranslator.ToWin32(MyDialog.Color)
            TB.Text = colour.ToString
        End If
    End Sub

    Private Sub BTNGridEvenVoorgrond_Click(sender As Object, e As EventArgs) Handles BTNGridEvenVoorgrond.Click
        SelectColor(TBGRIDforecoloreven)
    End Sub

    Private Sub BTNGridOnEvenVoorgrond_Click(sender As Object, e As EventArgs) Handles BTNGridOnEvenVoorgrond.Click
        SelectColor(TBGRIDforecolorodd)
    End Sub

    Private Sub BTNAchtergrondbijFout_Click(sender As Object, e As EventArgs) Handles BTNAchtergrondbijFout.Click
        SelectColor(TBDISPtextboxerror)
    End Sub

    Private Sub BTNAchtergrondgeenfout_Click(sender As Object, e As EventArgs) Handles BTNAchtergrondgeenfout.Click
        SelectColor(TBDISPtextboxbackcolor)
    End Sub

    Private Sub BTNcodenietgebruikt_Click(sender As Object, e As EventArgs) Handles BTNcodenietgebruikt.Click
        SelectColor(TBGRIDcellnotused)
    End Sub

    Private Sub BTNGridSelectieVoorgrond_Click(sender As Object, e As EventArgs) Handles BTNGridSelectieVoorgrond.Click
        SelectColor(TBGridSelectieVoorgrond)
    End Sub

    Private Sub BTNGridSelectieAchtergrond_Click(sender As Object, e As EventArgs) Handles BTNGridSelectieAchtergrond.Click
        SelectColor(TBGridSelectieAchtergrond)
    End Sub

    Private Sub BTNgratis_Click(sender As Object, e As EventArgs) Handles BTNgratis.Click
        SelectColor(TBGRIDcellgratis)
    End Sub

    Private Sub BTNmemo_Click(sender As Object, e As EventArgs) Handles BTNmemo.Click
        SelectColor(TBGRIDcellmemo)
    End Sub

    Private Sub BTNresetstock_Click(sender As Object, e As EventArgs) Handles BTNresetstock.Click
        If MsgBox("Wil je stock voor alle codes op 0 zetten? Actie is onomkeerbaar!!!", MsgBoxStyle.YesNoCancel, "RESET Stock.") = MsgBoxResult.Yes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            sqltask = "UPDATE COD SET STOCK = 0;"
            execPC(sqltask)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Stock op 0 gezet voor alle codes!")
        End If
    End Sub

    Private Sub BTNresetostock_Click(sender As Object, e As EventArgs) Handles BTNresetostock.Click
        If MsgBox("Wil je Oude-stock voor alle codes op 0 zetten? Actie is onomkeerbaar!!!", MsgBoxStyle.YesNoCancel, "RESET Oude Stock.") = MsgBoxResult.Yes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            sqltask = "UPDATE COD SET OSTOCK = 0;"
            execPC(sqltask)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Oude Stock op 0 gezet voor alle codes!")
        End If
    End Sub

    Private Sub execPC(sqlcmd As String)
        ConnectDB()
        command = connection.CreateCommand()
        command.CommandText = sqlcmd
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub ConnectDB()
        Dim conval As String = My.Settings.BONConnectionString
        convalArray = Split(conval, ";")
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
        If trusted = True Then constring = constring + "Trusted_Connection=True;"
        connection = New SqlConnection(constring)
        connection.Open()
    End Sub

    Private Sub SetGrids()
        SetGridRows(DGREC)
    End Sub

    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        records =
        From locks In db.LOCKs
        Join user In db.USERS On locks.LUNRQ Equals user.UNRQ
        Select locks.LID, locks.LUNRQ, locks.LTYPE, locks.LPK, locks.LDT, user.UNAAM

        records = records.OrderBy("LDT", SortOrder.Ascending = True)
        DGFILTER()
        Me.DGREC.DataSource = records

        'set invisible
        Dim dginvisible As Object = New String() {"LUNRQ", "LID"}
        For index = 0 To dginvisible.GetUpperBound(0)
            DGREC.Columns(dginvisible(index)).Visible = False
        Next

        'set autosizemode
        Dim dgautos As Object = New String() {"LTYPE", "LPK", "LDT"}
        For index = 0 To dgautos.GetUpperBound(0)
            DGREC.Columns(dgautos(index)).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next index
        DGREC.Columns("UNAAM").AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGFILTER()
        'records = records.Where("KNaam.startswith(@0)", Fltklant.Text)
        records = records.Where("LTYPE.Contains(@0)", FltType.Text)
        records = records.Where("UNAAM.Contains(@0)", FltUnaam.Text)
    End Sub

    Private Sub FltType_TextChanged(sender As Object, e As EventArgs) Handles FltType.TextChanged
        Fill_DGREC()
    End Sub

    Private Sub FltUnaam_TextChanged(sender As Object, e As EventArgs) Handles FltUnaam.TextChanged
        Fill_DGREC()
    End Sub

    Private Sub BTN_DropLocks_Click(sender As Object, e As EventArgs) Handles BTN_DropLocks.Click
        sqltask = "DELETE FROM LOCK;"
        execPC(sqltask)
        Fill_DGREC()
    End Sub

End Class