Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class StartSQL
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlString As String
    Dim sqlTask As String
    Dim convalArray() As String

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        ' LAATSTE LIJN VERWIJDEREN IN CSV !!!!
        Dim strfilename As String

        ' Load the files
        strfilename = "C:\temp\AFHANDELexport.csv"
        loadafth(strfilename, 0)
        strfilename = "C:\temp\PARTICULIERexport.csv"
        loadafth(strfilename, 1)
    End Sub

    Private Sub loadafth(strfilename As String, what As Integer)
        Dim num_rows As Long = 0
        Dim num_cols As Long = 0
        Dim x As Integer
        Dim y As Integer
        Dim strarray(1, 1) As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Check if file exist
        If File.Exists(strfilename) Then
            Dim tmpstream As StreamReader = File.OpenText(strfilename)
            Dim strlines() As String
            Dim strline() As String

            'Load content of file to strLines array
            strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)

            ' Redimension the array.
            num_rows = UBound(strlines)
            strline = strlines(0).Split(";")
            num_cols = UBound(strline)
            ReDim strarray(num_rows, num_cols)

            ' Copy the data into the array.
            For x = 0 To num_rows
                strline = strlines(x).Split(";")
                For y = 0 To num_cols
                    strarray(x, y) = strline(y)
                Next
            Next

            ' move data to sqlimporter (0 = Header)
            For x = 1 To num_rows

                Dim oaft = strarray(x, 10)
                Select Case oaft
                    Case "H"
                        oaft = TBtyH.Text
                    Case "N"
                        oaft = TBtyN.Text
                    Case "U"
                        oaft = TBtyU.Text
                    Case Else
                        oaft = 4
                End Select

                keyafjr = strarray(x, 0)
                Dim newafvnr = GetHighAFVNR(keyafjr)
                Dim afdatum = strarray(x, 3)
                Dim sortafdatum = afdatum.Replace("/", "")
                sortafdatum = Mid(sortafdatum, 5, 4) + Mid(sortafdatum, 3, 2) + Mid(sortafdatum, 1, 2)

                Dim newrec As New AF With {
                    .AFJR = keyafjr,
                    .AFVNR = newafvnr,
                    .AFDATUM = afdatum,
                    .AFAP = what,
                    .AFR = 6,
                    .AFT = oaft,
                    .AFAFSPR = strarray(x, 8),
                    .AFNR = strarray(x, 2),
                    .AFLINK = strarray(x, 4),
                    .AFCALC = strarray(x, 5),
                    .AFOFF = strarray(x, 6),
                    .AFSEND = strarray(x, 7),
                    .AFOPM = strarray(x, 9),
                    .AFWERFL = strarray(x, 11),
                    .AFSTART = strarray(x, 12),
                    .AFTERMIJN = "",
                    .AF30BIS = "",
                    .AFVS = "",
                    .AFFACT = "",
                    .AFBEDR = strarray(x, 17),
                    .AFSORTKEY = sortafdatum & "-" & .AFVNR.ToString("D4"),
                    .AFSORTNR = sortafdatum & "-" & .AFNR.ToString("D4"),
                    .CHDATE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                    .USERNRQ = LoginNm,
                    .USERCRE = LoginNm,
                    .DATECRE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
                }

                db.AFs.InsertOnSubmit(newrec)
                Try
                    db.SubmitChanges()
                Catch ex As Exception
                    PositionMsgbox.CenterMsgBox(Me)
                    MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
                    Exit Sub
                    ' Handle exception.  
                End Try

            Next

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        If what = 0 Then MsgBox(num_rows & " records inserted als AfTeHandelen.")
        If what = 1 Then MsgBox(num_rows & " records inserted als Particulier.")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strfilename As String
        Dim num_rows As Long
        Dim num_cols As Long
        Dim x As Integer
        Dim y As Integer
        Dim strarray(1, 1) As String

        ' Load the file.
        strfilename = "C:\temp\AFHANDELexport.csv"

        'Check if file exist
        If File.Exists(strfilename) Then
            Dim tmpstream As StreamReader = File.OpenText(strfilename)
            Dim strlines() As String
            Dim strline() As String

            'Load content of file to strLines array
            strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)

            ' Redimension the array.
            num_rows = UBound(strlines)
            strline = strlines(0).Split(";")
            num_cols = UBound(strline)
            ReDim strarray(num_rows, num_cols)

            ' Copy the data into the array.
            For x = 0 To num_rows
                strline = strlines(x).Split(";")
                For y = 0 To num_cols
                    strarray(x, y) = strline(y)
                Next
            Next

            ' Display the data in textbox (0 = Header!!)
            For x = 1 To 10
                For y = 0 To num_cols
                    TBsql.Text = TBsql.Text & strarray(x, y) & ","
                Next
                TBsql.Text = TBsql.Text & Environment.NewLine
            Next

        End If
    End Sub

    Private Sub StartSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conval As String = My.Settings.BONConnectionString
        ConnectDB(conval)
        TBsql.Text = "UPDATE BONL SET BONL.AP=(SELECT COD.Aankp FROM COD WHERE COD.CNRQ=BONL.CNRQ and not COD.Aankp IS NULL) where AP=0;"
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
        If trusted = True Then constring = constring + "Trusted_Connection=True;"
        connection = New SqlConnection(constring)
        connection.Open()
    End Sub

    Private Sub StartSQL_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bons = From bon In db.BONs
        MsgBox(bons.Count)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bonls = From bonl In db.BONLs
        MsgBox(bonls.Count)
    End Sub

    Private Sub UpdUSER()

        Dim dblogin = From login In db.Logins
        For Each rlogin In dblogin

            sqlTask = "INSERT INTO USERS (UNAAM,UPWD,UCURLOGON,UUPD,UDEL,UNEW,USYSUSER) values ("
            sqlTask = sqlTask & "'" & rlogin.naam & "'"
            sqlTask = sqlTask & ", " & "'" & rlogin.pwd & "'"
            sqlTask = sqlTask & ", 1, 1, 1, 1, 1); "
            MsgBox(sqlTask)
            execPC(sqlTask)

        Next
        MsgBox("Update USERS oké.")
    End Sub

    Private Sub NewUSER()
        sqlTask = "DROP TABLE IF EXISTS USERS;"
        execPC(sqlTask)

        sqlTask = "CREATE TABLE USERS(" &
                    "NRQ INT Not NULL IDENTITY PRIMARY KEY, " &
                    "NAAM VARCHAR(50) Not NULL, " &
                    "PWD VARCHAR(50) Not NULL,  " &
                    "CURRENTLOGON BIT Not NULL, " &
                    "UPD BIT Not NULL,  " &
                    "DEL BIT Not NULL, " &
                    "New BIT Not NULL" &
                    ");"

        execPC(sqlTask)

        sqlTask = "SET IDENTITY_INSERT USERS ON"
        execPC(sqlTask)

        MsgBox("Creatie USERS oké.")
    End Sub

    Private Sub UpdateAFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAFToolStripMenuItem.Click
        createAF()
    End Sub

    Private Sub UpdatePERSSorteringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePERSSorteringToolStripMenuItem.Click
        updateperssort()
    End Sub

    Private Sub UpdateTOTALSToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        updatetotals()
    End Sub

    Private Sub ADDOPMBONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Updatebon()
    End Sub

    Private Sub CreateAFRT()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        sqlTask = "DROP TABLE IF EXISTS AFR;"
        execPC(sqlTask)
        sqlTask = "DROP TABLE IF EXISTS AFT;"
        execPC(sqlTask)
        sqlTask = "CREATE TABLE AFR(" &
                    "AFRID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "AFRVERW VARCHAR(20) Not NULL, " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL" &
                    ");"
        execPC(sqlTask)
        sqlTask = "CREATE TABLE AFT(" &
                    "AFTID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "AFTVERW VARCHAR(20) Not NULL, " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL" &
                    ");"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Creatie AFR-AFT gelukt.")
    End Sub

    Private Sub createAF()
        If MsgBox("Reset de Tabel AfTeHandelen?", MsgBoxStyle.YesNoCancel, "AfTeHandelen") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        sqlTask = "DROP TABLE IF EXISTS AF;"
        execPC(sqlTask)
        sqlTask = "CREATE TABLE AF(" &
                    "AFJR INT Not NULL, " &
                    "AFVNR Int Not NULL, " &
                    "AFDATUM DATETIME,  " &
                    "AFAP BIT Not NULL,  " &
                    "AFR INT Not NULL, " &
                    "AFT INT Not NULL, " &
                    "AFNR INT Not NULL, " &
                    "AFLINK VARCHAR(500), " &
                    "AFCALC VARCHAR(60), " &
                    "AFOFF VARCHAR(60), " &
                    "AFSEND VARCHAR(60), " &
                    "AFAFSPR VARCHAR(60), " &
                    "AFOPM VARCHAR(60), " &
                    "AFWERFL VARCHAR(60), " &
                    "AFSTART VARCHAR(60), " &
                    "AFTERMIJN VARCHAR(60), " &
                    "AF30BIS VARCHAR(60), " &
                    "AFVS VARCHAR(60), " &
                    "AFFACT VARCHAR(60), " &
                    "AFBEDR VARCHAR(60), " &
                    "AFSORTKEY VARCHAR(13), " &
                    "AFSORTNR VARCHAR(13), " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL, " &
                    "USERCRE VARCHAR(10) Not NULL, " &
                    "DATECRE DATETIME Not NULL, " &
                    "PRIMARY KEY(AFJR, AFVNR)" &
                    ");"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Creatie AF gelukt.")
    End Sub

    Private Sub Newlock()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        sqlTask = "CREATE TABLE LOCK(" &
                    "LID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "LUNRQ  INT NOT NULL, " &
                    "LTYPE VARCHAR(15), " &
                    "LDT DATETIME Not NULL,  " &
                    "LPK INT Not NULL, " &
                    "LSPK VARCHAR(15)" &
                    ");"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Tabellen aangemaakt.")
    End Sub

    Private Sub updatePrest()
        sqlTask = "ALTER TABLE PREST ADD PRDATEU DATE Not null default '01/01/2021';"
        execPC(sqlTask)
        sqlTask = "UPDATE PREST SET PREST.PRDATEU=PREST.PRDATE;"
        execPC(sqlTask)

        MsgBox("New Field Prestaties added.")
    End Sub

    Private Sub UpdateFeest()
        sqlTask = "CREATE TABLE FEEST(" &
            "FID INT Not NULL PRIMARY KEY IDENTITY, " &
            "FYYYY VARCHAR(4) Not NULL, " &
            "FMM VARCHAR(2) Not NULL, " &
            "FDD VARCHAR(2) Not NULL, " &
            "FDATE VARCHAR(8) Not NULL, " &
            "FNM VARCHAR(50) Not NULL" &
            ");"
        execPC(sqlTask)
        MsgBox("Tabel feestdagen aangemaakt.")
    End Sub

    Private Sub updatetotals()
        sqlTask = "ALTER TABLE USERS ADD TOTALSSYS BIT Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE USERS SET TOTALSSYS = 0;"
        execPC(sqlTask)



        MsgBox("Voorbereiding TOTALS gelukt.")
    End Sub

    Private Sub updatepers()
        sqlTask = "ALTER TABLE PER ADD BEDIENDE BIT Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE PER SET BEDIENDE = 0;"
        execPC(sqlTask)

        MsgBox("New Field PER added.")
    End Sub

    Private Sub updateperssort()
        sqlTask = "ALTER TABLE PER ADD PERSORTLONG VARCHAR(20) Not NULL default '';"
        execPC(sqlTask)
        sqlTask = "UPDATE PER SET PER.PERSORTLONG=PER.PERSORT;"
        execPC(sqlTask)

        MsgBox("Sortering Personeel aangepast.")
    End Sub

    Private Sub CreatePrestaties()

        sqlTask = "CREATE TABLE PTYPE(" &
                    "PTID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "PTVERW VARCHAR(50) Not NULL, " &
                    "PTTOT BIT Not NULL default 0,  " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL" &
                    ");"
        execPC(sqlTask)
        sqlTask = "CREATE TABLE PSECTOR(" &
            "PSID INT Not NULL PRIMARY KEY IDENTITY, " &
            "PSVERW VARCHAR(50) Not NULL, " &
            "USERNRQ VARCHAR(10) Not NULL, " &
            "CHDATE DATETIME Not NULL" &
            ");"
        execPC(sqlTask)
        sqlTask = "CREATE TABLE PREST(" &
                    "PRID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "PRPERNRQ  INT NOT NULL, " &
                    "PRYEAR INT Not NULL,  " &
                    "PRDATE DATE Not NULL, " &
                    "PRPSID INT NOT NULL, " &
                    "PRPTID INT NOT NULL, " &
                    "PRAANTAL REAL NOT NULL, " &
                    "PRPTTOT BIT NOT NULL default 0, " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL" &
                    ");"
        execPC(sqlTask)
        MsgBox("Tabellen aangemaakt.")
    End Sub

    Private Sub Updatebon()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        sqlTask = "ALTER TABLE BON ADD OPM VARCHAR(50) Not NULL default '';"
        execPC(sqlTask)
        sqlTask = "UPDATE BON SET OPM = '';"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("New Fields BON added.")
    End Sub

    Private Sub Newbonl()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        sqlTask = "ALTER TABLE BONL ADD BLSORT  VARCHAR(13) Not NULL default '';"
        execPC(sqlTask)
        sqlTask = "UPDATE BONL SET BLSORT = '';"
        execPC(sqlTask)

        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("New Field BONL.BLSORT added.")
    End Sub

    Private Sub Updatebonl()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim numstr As String
        Dim datstr As String
        Dim frombonls = From bonl In db.BONLs
        For Each frombonl In frombonls
            numstr = frombonl.Volgorde.ToString("D4")
            datstr = frombonl.Datum.ToString("yyyyMMdd")
            frombonl.BLSORT = datstr & "-" & numstr
            db.SubmitChanges()
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("New Field BONL.BLSORT added and updated.")
    End Sub

    Private Sub updateuser()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        sqlTask = "ALTER TABLE USERS ADD GETFAKTNR BIT Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE USERS SET GETFAKTNR = 0;"
        execPC(sqlTask)

        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub updateklant()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        sqlTask = "ALTER TABLE KLANT ADD KEMailF VARCHAR(50) not null default ''"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KEMailF= '';"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub updateklantx()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        sqlTask = "ALTER TABLE KLANT ADD FACM VARCHAR(1) not null default 'N'"
        execPC(sqlTask)
        sqlTask = "ALTER TABLE KLANT ADD FACP VARCHAR(1) not null default 'N'"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET FACM= 'N';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET FACP= 'N';"
        execPC(sqlTask)

        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub updatebonlxy()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'sqltask = "ALTER TABLE BONL ADD AP FLOAT Not null default 0;"
        'execPC(sqltask)

        sqlTask = "UPDATE BONL SET BONL.AP=(SELECT COD.Aankp FROM COD WHERE COD.CNRQ=BONL.CNRQ and not COD.Aankp IS NULL) where BONL.AP=0;"
        execPC(sqlTask)
        Me.Cursor = System.Windows.Forms.Cursors.Default

        MsgBox("AP updated.")
    End Sub

    Private Sub updatebonx()

        sqlTask = "ALTER TABLE BON ADD TRECUP NUMERIC(18,2) Not null default 0, TFACT NUMERIC(18,2) Not null default 0, TNACALC NUMERIC(18,2) Not null default 0, TKILOH NUMERIC(18,2) Not null default 0, TRESULT NUMERIC(18,2) Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE BON SET TRECUP = 0, TFACT = 0, TNACALC = 0, TKILOH = 0, TRESULT = 0;"
        execPC(sqlTask)

        MsgBox("New Fields BON added.")
    End Sub

    Private Sub updatebedragen()
        Dim frombons = From bon In db.BONs Where bon.BONJR > 2017

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For Each frombon In frombons
            Bondvantot(frombon.BONJR, frombon.BONNR)
        Next
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        MsgBox("Opvullen bedragen in orde.")
    End Sub

    Private Sub perlijnen()

        sqlTask = "CREATE TABLE PERL(" &
                    "PERL_NRQ INT Not NULL, " &
                    "PERL_VNR Int Not NULL, " &
                    "SELREC BIT Not NULL,  " &
                    "INBEZIT BIT Not NULL, " &
                    "STARTDATE DATETIME,  " &
                    "CNRQ INT Not NULL, " &
                    "AANTAL REAL Not NULL, " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL, " &
                    "USERCRE VARCHAR(10) Not NULL, " &
                    "DATECRE DATETIME Not NULL, " &
                    "PRIMARY KEY(PERL_NRQ, PERL_VNR)" &
                    ");"
        execPC(sqlTask)

        MsgBox("Creatie PERL oké.")
    End Sub


    ' Done
    Private Sub xNewBONL_controleok()

        sqlTask = "ALTER TABLE BONL ADD CONTROLEOK BIT Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE BONL SET CONTROLEOK = 0;"
        execPC(sqlTask)
        MsgBox("New Field BONL.CONTROLEOK added.")
    End Sub

    Private Sub xNewCOD_kmheffing()
        sqlTask = "ALTER TABLE COD ADD KMHEFFING BIT Not null default 0;"
        execPC(sqlTask)
        sqlTask = "UPDATE COD SET KMHEFFING = 0;"
        execPC(sqlTask)
        MsgBox("New Field COD.KMHEFFING added.")
    End Sub

    Private Sub xUpdateBNRQ11ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE BTW SET OmsBTW = 'RM: Regie- en of Meerwerk (bge)' WHERE BNRQ = 11;"
    End Sub

    Private Sub xOPGLOudsbergenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE POST SET PGEMEENTE = 'Oudsbergen (Opglabbeek)', PNRQ = 'B-3660 Oudsbergen (Opglabbeek)' WHERE PCODE = 3660;"
    End Sub

    Private Sub xMEGROudsbergenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE POST SET PGEMEENTE = 'Oudsbergen (Meeuwen-Gruitrode)', PNRQ = 'B-3670 Oudsbergen (Meeuwen-Gruitrode)' WHERE PCODE = 3670;"
    End Sub

    Private Sub xNEERPeltToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE POST SET PGEMEENTE = 'Pelt (Neerpelt)', PNRQ = 'B-3910 Pelt (Neerpelt)' WHERE PCODE = 3910;"
    End Sub

    Private Sub xOVERPeltToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE POST SET PGEMEENTE = 'Pelt (Overpelt)', PNRQ = 'B-3900 Pelt (Overpelt)' WHERE PCODE = 3900;"
    End Sub

    Private Sub xKlantFACNewToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        TBsql.Text = "ALTER TABLE KLANT ADD FAC VARCHAR(1) not null default 'N'"
    End Sub

    Private Sub xKlantFACNToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE KLANT SET FAC = 'N' WHERE KNRQ > 0;"
    End Sub

    Private Sub xOPGLOudsbergenToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE KLANT SET KAdres = 'B-3660 Oudsbergen (Opglabbeek)' WHERE KAdres = 'B-3660 Opglabbeek';"
    End Sub

    Private Sub xMEGROudsbergenToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE KLANT SET KAdres = 'B-3670 Oudsbergen (Meeuwen-Gruitrode)' WHERE KAdres = 'B-3670 Meeuwen-Gruitrode';"
    End Sub

    Private Sub xOVERPeltToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE KLANT SET KAdres = 'B-3900 Pelt (Overpelt)' WHERE KAdres = 'B-3900 Overpelt';"
    End Sub

    Private Sub xNEERPeltToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        TBsql.Text = "UPDATE KLANT SET KAdres = 'B-3910 Pelt (Neerpelt)' WHERE KAdres = 'B-3910 Neerpelt';"
    End Sub

    Private Sub Fusie(sender As Object, e As EventArgs)
        ' Aalter (9880) + Knesselare (9910) --> Aalter
        ' !! Aalter blijft Aalter
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Aalter (Knesselare)', PNRQ = 'B-9910 Aalter (Knesselare)' WHERE PNRQ = 'B-9910 Knesselare';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9910 Aalter (Knesselare)' WHERE KAdres = 'B-9910 Knesselare';"
        execPC(sqlTask)
        MsgBox("Aalter omgezet")
        ' Deinze (9800) + Nevele (9850) --> Deinze
        ' !! Deinze blijft Deinze
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Deinze (Nevele)', PNRQ = 'B-9850 Deinze (Nevele)' WHERE PNRQ = 'B-9850 Nevele';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9850 Deinze (Nevele)' WHERE KAdres = 'B-9850 Nevele';"
        execPC(sqlTask)
        MsgBox("Deinze omgezet")
        ' Kruishoutem (9770) + Zingem (9750) --> Kruisem
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Kruisem (Kruishoutem)', PNRQ = 'B-9770 Kruisem (Kruishoutem)' WHERE PNRQ = 'B-9770 Kruishoutem';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9770 Kruisem (Kruishoutem)' WHERE KAdres = 'B-9770 Kruishoutem';"
        execPC(sqlTask)
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Kruisem (Zingem)', PNRQ = 'B-9750 Kruisem (Zingem)' WHERE PNRQ = 'B-9750 Zingem';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9750 Kruisem (Zingem)' WHERE KAdres = 'B-9750 Zingem';"
        execPC(sqlTask)
        MsgBox("Kruisem omgezet")
        ' Waarschoot (9950) + Lovendegem (9920) + Zomergem (9930) --> Lievegem
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Lievegem (Waarschoot)', PNRQ = 'B-9950 Lievegem (Waarschoot)' WHERE PNRQ = 'B-9950 Waarschoot';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9950 Lievegem (Waarschoot)' WHERE KAdres = 'B-9950 Waarschoot';"
        execPC(sqlTask)
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Lievegem (Lovendegem)', PNRQ = 'B-9920 Lievegem (Lovendegem)' WHERE PNRQ = 'B-9920 Lovendegem';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9920 Lievegem (Lovendegem)' WHERE KAdres = 'B-9920 Lovendegem';"
        execPC(sqlTask)
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Lievegem (Zomergem)', PNRQ = 'B-9930 Lievegem (Zomergem)' WHERE PNRQ = 'B-9930 Zomergem';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-9930 Lievegem (Zomergem)' WHERE KAdres = 'B-9930 Zomergem';"
        execPC(sqlTask)
        MsgBox("Lievegem omgezet")
        ' Puurs (2870) + Sint-Amands (2890) --> Puurs-Sint-Amands
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Puurs-Sint-Amands (Puurs)', PNRQ = 'B-2870 Puurs-Sint-Amands (Puurs)' WHERE PNRQ = 'B-2870 Puurs';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-2870 Puurs-Sint-Amands (Puurs)' WHERE KAdres = 'B-2870 Puurs';"
        execPC(sqlTask)
        sqlTask = "UPDATE POST SET PGEMEENTE = 'Puurs-Sint-Amands (Sint-Amands)', PNRQ = 'B-2890 Puurs-Sint-Amands (Sint-Amands)' WHERE PNRQ = 'B-2890 Sint-Amands';"
        execPC(sqlTask)
        sqlTask = "UPDATE KLANT SET KAdres = 'B-2890 Puurs-Sint-Amands (Sint-Amands)' WHERE KAdres = 'B-2890 Sint-Amands';"
        execPC(sqlTask)
        MsgBox("Puurs-Sint-Amands omgezet")
    End Sub

    Private Sub execPC(sqlcmd As String)
        command = connection.CreateCommand()
        command.CommandText = sqlcmd
        command.ExecuteNonQuery()
    End Sub

    Private Sub xNewCODGPinresultToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sqlTask = "ALTER TABLE CODGP ADD INRESULT BIT not null default 1;"
        execPC(sqlTask)
        sqlTask = "UPDATE CODGP SET INRESULT = 1;"
        execPC(sqlTask)
        MsgBox("New Field CODGP.INRESULT added.")
    End Sub

    Private Sub xButton4_Click(sender As Object, e As EventArgs)
        Dim frombonls = From bonl In db.BONLs Where bonl.BONJR = 2020 And bonl.BONNR = 23 And bonl.BONLVNR = 9
        Dim numstr As String
        Dim datstr As String
        For Each frombonl In frombonls
            numstr = frombonl.Volgorde.ToString("D4")
            datstr = frombonl.Datum.ToString("yyyyMMdd")
            'datstr = Replace(frombonl.Datum.Date, "/", "")
            'datstr = Mid(datstr, 5, 4) & Mid(datstr, 3, 2) & Mid(datstr, 1, 2)
            MsgBox(datstr & "-" & numstr)
        Next
    End Sub

    Private Sub UPDBONPARTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OneToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sqlTask = "CREATE TABLE PREST(" &
                    "PRID INT Not NULL PRIMARY KEY IDENTITY, " &
                    "PRPERNRQ  INT NOT NULL, " &
                    "PRYEAR INT Not NULL,  " &
                    "PRDATE DATE Not NULL, " &
                    "PRPSID INT NOT NULL, " &
                    "PRPTID INT NOT NULL, " &
                    "PRAANTAL REAL NOT NULL, " &
                    "PRPTTOT BIT NOT NULL default 0, " &
                    "USERNRQ VARCHAR(10) Not NULL, " &
                    "CHDATE DATETIME Not NULL" &
                    ");"
        execPC(sqlTask)
        MsgBox("Tabellen aangemaakt.")
    End Sub

End Class