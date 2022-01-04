
Module Module_Export

    Public Sub ExportDBToCSV()
        Dim file As System.IO.StreamWriter
        Dim sb As New System.Text.StringBuilder
        Dim s As String

        'Dim queryResults = From cust In customers, ord In orders
        'Where cust.CustomerID = ord.CustomerID
        'Select Case cust, ord
        'For Each result In queryResults
        'Debug.WriteLine(result.ord.Amount & "  " & result.ord.CustomerID & "  " & result.cust.CompanyName)
        'Next

        Dim tofile As String = filenm & "\csv"
        If (Not System.IO.Directory.Exists(tofile)) Then
            System.IO.Directory.CreateDirectory(tofile)
        End If
        tofile = tofile & "\" & "test.csv"

        file = My.Computer.FileSystem.OpenTextFileWriter(tofile, False)

        Dim records = From bonl In db.BONLs
                      Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                      Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                      Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
                      Join bon In db.BONs On bonl.BONJR Equals bon.BONJR And bonl.BONNR Equals bon.BONNR
                      Join KLANT In db.KLANTs On bon.KNRQ Equals KLANT.KNRQ
                      Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
                      Select bonl.BONJR, bonl.BONNR, bonl.BONLVNR, bonl.Aantal, bonl.BONEenhp, bonl.diesel,
                          btw.BTW,
                          code.Code, code.OmsCode,
                          codgp.OmsGroep,
                          KLANT.KNaam, KLANT.KStraat, KLANT.KAdres, KLANT.KGSM
        s = ""
        For Each record In records
            sb.AppendLine(record.ToString)
        Next

        file.Write(sb.ToString())

        'For Each record In records
        'For Each field In record
        'file.Write(field.ToString)
        'Next
        'Next

        file.Close()
    End Sub

    Public Sub ExportToCSV(dgview As DataGridView, fnm As String)
        Dim file As System.IO.StreamWriter
        'Dim tofile As String = "c:\Temp\" & fnm & ".csv"
        Dim delimeter As String = ";"
        Dim sb As New System.Text.StringBuilder

        Dim tofile As String = filenm & "\csv"
        If (Not System.IO.Directory.Exists(tofile)) Then
            System.IO.Directory.CreateDirectory(tofile)
        End If
        tofile = tofile & "\" & fnm & ".csv"

        file = My.Computer.FileSystem.OpenTextFileWriter(tofile, False)

        For i As Integer = 0 To dgview.Rows.Count - 1
            Dim array As String() = New String(dgview.Columns.Count - 1) {}
            If i.Equals(0) Then
                For j As Integer = 0 To dgview.Columns.Count - 1
                    array(j) = dgview.Columns(j).HeaderText
                Next
                sb.AppendLine(String.Join(delimeter, array))
            End If
            For j As Integer = 0 To dgview.Columns.Count - 1
                If Not dgview.Rows(i).IsNewRow Then
                    array(j) = dgview(j, i).Value.ToString
                End If
            Next
            If Not dgview.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(delimeter, array))
            End If
        Next
        file.Write(sb.ToString)
        file.Close()

        If System.IO.File.Exists(tofile) = True Then
            Process.Start(tofile)
        Else
            MsgBox("Bestand " & filenm & " bestaat niet.")
        End If

    End Sub

    Public Sub testToFile(dgview As DataGridView)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\Temp\test.txt", False)
        file.WriteLine("Here is the first string.")
        file.WriteLine("Second line.")
        file.Close()
    End Sub

    Public Sub ExportToExcel(dgview As DataGridView, fnm As String)
        Dim objExcelApp As Object
        Dim wb As Object
        Dim ws As Object

        objExcelApp = CreateObject("Excel.Application")
        'objExcelApp.Visible = False
        wb = objExcelApp.Workbooks.Add

        ''First is row, then Column
        'ws.Cells(1, 1).Value = "Hello"
        'ws.Cells(1, 2).Value = "World"

        Try
            ws = wb.ActiveSheet
            ws.Name = "ExportedFromDatGrid"

            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1

            'Loop through each row and read value from each column.
            For i As Integer = 0 To dgview.Rows.Count - 2
                For j As Integer = 0 To dgview.Columns.Count - 1
                    ' Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                    If cellRowIndex = 1 Then
                        ws.Cells(cellRowIndex, cellColumnIndex) = dgview.Columns(j).HeaderText
                    Else
                        ws.Cells(cellRowIndex, cellColumnIndex) = dgview.Rows(i).Cells(j).Value.ToString()
                    End If
                    cellColumnIndex += 1
                Next
                cellColumnIndex = 1
                cellRowIndex += 1
            Next

            'Getting the location and file name of the excel to save from user.
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 2
            saveDialog.FileName = fnm

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                wb.SaveAs(saveDialog.FileName)
                MessageBox.Show("Export Successful")
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            objExcelApp.Quit()
            wb = Nothing
            'excel = Nothing
        End Try


        'Close the workbook
        ' wb.SaveAs("c:\temp\testxls.xlsx")
        ' wb.Close
        'wb = Nothing
        objExcelApp = Nothing
    End Sub

    Public Function NUMtoCHAR(InNum As Integer)
        'Groepeer de bonlijnen: keybonjr, keybonnr, keybonlvnr
        Dim ReturnCHAR As String = ""
        Select Case InNum
            Case 1
                ReturnCHAR = "A"
            Case 2
                ReturnCHAR = "B"
            Case 3
                ReturnCHAR = "C"
            Case Else
                ReturnCHAR = ""
        End Select

        Return ReturnCHAR
    End Function

    Public Sub ExportToBonNaCalc(keyjr As Integer, keynr As Integer)
        Dim resultnonewbon As String = ""
        Dim resultnewbon As String = ""

        Cursor.Current = Cursors.WaitCursor
        Dim NoNewBon = Aggregate bonl In db.BONLs
                          Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                          Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr AndAlso btw.nieuwbon = False
                          Into Count()
        If NoNewBon > 0 Then
            resultnonewbon = ExportToBON(keybonjr, keybonnr, False)
        End If

        Dim NewBon = Aggregate bonl In db.BONLs
         Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
         Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr AndAlso btw.nieuwbon = True
         Into Count()
        If NewBon > 0 Then
            resultnewbon = ExportToBON(keybonjr, keybonnr, True)
        End If
        Cursor.Current = Cursors.Default

        If resultnewbon <> "" Or resultnonewbon <> "" Then
            Dim xlTmp As Object = CreateObject("Excel.Application")
            If resultnonewbon <> "" Then
                xlTmp.Workbooks.Open(resultnonewbon)
            End If
            If resultnewbon <> "" Then
                xlTmp.workbooks.open(resultnewbon)
            End If
            xlTmp.Visible = True
            xlTmp = Nothing
            'xlTmp.quit()
        End If

    End Sub

    Public Function ExportToBON(keyjr As Integer, keynr As Integer, NaCalc As Boolean)
        Dim objExcelApp As Object = CreateObject("Excel.Application")
        Dim wb As Object = objExcelApp.Workbooks.Add
        Dim ws As Object = wb.ActiveSheet
        Dim DBbon As IQueryable
        Dim DBbonls As IQueryable
        'Dim DBbonlr As IQueryable
        Dim oldCursor As Cursor = Cursor.Current
        Dim facnr As String = ""
        Dim numform As String = "# ##0.00"

        ws.Name = "Bon " & keyjr & "-" & keynr
        ws.select

        DBbon = From bon In db.BONs
                Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                Join eigenaar In db.EIGENAARs On bon.ENRQ Equals eigenaar.ENRQ
                Where bon.BONJR = keyjr AndAlso bon.BONNR = keynr
                Select bon.BONJR, bon.BONNR, bon.OmsBon, bon.DatumAanvang, bon.dvan, bon.dtot, bon.fnr, bon.cnr,
                    klant.KNaam, klant.KAdres, klant.KStraat, klant.FAC, klant.FACM, klant.FACP,
                    klant.KTel, klant.KFax, klant.KGSM, klant.KWAdres, klant.KWStraat, klant.KBTWNr, klant.KEMail, klant.KEMailF,
                    eigenaar.ENaam, eigenaar.EFirma, eigenaar.EStraat, eigenaar.EAdres,
                    eigenaar.ETel, eigenaar.EBTWNr, eigenaar.EEMail

        DBbonls = From bonl In db.BONLs
                  Join code In db.CODs On code.CNRQ Equals bonl.CNRQ
                  Join codgp In db.CODGPs On codgp.CGNRQ Equals code.CGNRQ
                  Join aoms In db.AOms On aoms.ANRQ Equals code.ANRQ
                  Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                  Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr AndAlso btw.nieuwbon = NaCalc
                  Order By bonl.Datum
                  Let DTotExcl = bonl.Aantal * bonl.BONEenhp
                  Let BAANT = bonl.Aantal
                  Let BAOMS = aoms.Oms
                  Select BAANT, BAOMS, bonl.Datum, bonl.BONEenhp, btw.BTW, code.OmsCode, code.Code, codgp.OmsGroep, bonl.BWStraat, bonl.BWAdres, bonl.EXTNR, DTotExcl

        ' set Landscape
        objExcelApp.ActiveSheet.pagesetup.Orientation = xlLandscape

        ' Header bonlijnen: op lijn 14
        Dim dtHEAD(0, 9) As String
        dtHEAD(0, 0) = "Datum"
        dtHEAD(0, 1) = "Code"
        dtHEAD(0, 2) = "Omschrijving"
        dtHEAD(0, 3) = "Eenheid"
        dtHEAD(0, 4) = "Aantal"
        dtHEAD(0, 5) = "EenhPr"
        dtHEAD(0, 6) = "Totaal Excl."
        dtHEAD(0, 7) = "BTW"
        dtHEAD(0, 8) = "Werfadres (Ext.Nr)"
        ws.range("I14", "K14").merge
        ws.Range("A14", "I14").Value = dtHEAD
        If NaCalc = False Then ws.range("A14", "I14").Interior.color = RGB(255, 255, 153)

        ' Bonlijnen vanaf lijn 15
        Dim bonlcnt As Integer = 0
        Dim rowcnt As Integer = 14
        Dim DWerf As String = ""
        For Each dbbonl In DBbonls
            bonlcnt += 1
            rowcnt += 1
            ws.range("I" & rowcnt, "K" & rowcnt).merge
            ws.cells(rowcnt, 1) = dbbonl.datum
            ws.cells(rowcnt, 1).NumberFormat = "dd/mm/yyyy"
            ws.cells(rowcnt, 2) = "'" & dbbonl.Code
            ws.cells(rowcnt, 3) = dbbonl.OmsCode
            ws.cells(rowcnt, 4) = dbbonl.BAOMS
            ws.cells(rowcnt, 5) = System.Convert.ToDecimal(dbbonl.BAANT)
            ws.cells(rowcnt, 5).NumberFormat = numform
            ws.cells(rowcnt, 6) = System.Convert.ToDecimal(dbbonl.BONEenhp)
            ws.cells(rowcnt, 6).NumberFormat = "# ##0.00"
            ws.cells(rowcnt, 7) = System.Convert.ToDecimal(dbbonl.DTotExcl)
            ws.cells(rowcnt, 7).NumberFormat = "# ##0.00"
            ws.cells(rowcnt, 8) = dbbonl.BTW

            DWerf = dbbonl.BWStraat & " " & dbbonl.BWAdres
            If dbbonl.extnr <> "" Then
                If DWerf = " " Then DWerf = "'"
                DWerf = DWerf & " (" & System.Convert.ToString(dbbonl.EXTNR) & ")"
            End If
            ws.cells(rowcnt, 9) = DWerf.Trim
            If System.Convert.ToDecimal(dbbonl.DTotExcl) < 0 Then
                ws.range("A" & rowcnt, "K" & rowcnt).font.color = RGB(255, 0, 0)
            End If
        Next

        Dim ftotw = "K" & bonlcnt + 14
        ws.range("A15", ftotw).font.size = 9

        ' display header
        ws.range("A14", "K14").borders.linestyle = xlContinuous
        ws.range("A14", "K14").borders.weight = xlThick
        ws.range("A14", "K14").borders.color = RGB(30, 144, 255)
        ws.range("A14", "K14").horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

        ' display bonlijnen
        ws.range("A15", ftotw).borders.linestyle = xlContinuous
        ws.range("A15", ftotw).borders.weight = xlThin
        ws.range("A15", ftotw).borders.color = RGB(30, 144, 255)

        ' AutoFit columns
        ws.range("A14", "A" & bonlcnt + 14).columnwidth = 9
        ws.range("B14", "B" & bonlcnt + 14).columnwidth = 12
        ws.range("C14", "C" & bonlcnt + 14).columnwidth = 39
        ws.range("C15", "C" & bonlcnt + 14).WrapText = True

        ws.range("E14", "E" & bonlcnt + 14).columnwidth = 8
        ws.range("E15", "E" & bonlcnt + 14).horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlRight
        ws.range("E14", "D" & bonlcnt + 14).columnwidth = 8
        ws.range("G14", "G" & bonlcnt + 14).columnwidth = 10
        ws.range("G14", "G" & bonlcnt + 14).horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlRight
        ws.range("H14", "H" & bonlcnt + 14).columnwidth = 8
        ws.range("I14", "I" & bonlcnt + 14).columnwidth = 10
        ws.range("J14", "J" & bonlcnt + 14).columnwidth = 25

        Dim bondesc As String = ""
        Dim bonfooter As String = ""
        For Each dbbonr In DBbon
            Dim domsbon As String = Left(Replace(dbbonr.omsbon, vbCrLf, " "), 70)
            ws.cells(1, 1).value = dbbonr.ENaam
            ws.cells(1, 1).font.bold = FontStyle.Bold
            ws.cells(1, 1).font.size = 12
            ws.cells(2, 1).value = dbbonr.efirma
            ws.cells(3, 1).value = dbbonr.estraat
            ws.cells(4, 1).value = dbbonr.eadres
            ws.cells(5, 1).value = "  Tel. :"
            ws.cells(5, 2).value = dbbonr.etel
            'ws.cells(6, 1).value = "  Fax :"
            'ws.cells(6, 2).value = dbbonr.efax
            ws.cells(7, 1).value = "  BTWnr :"
            ws.cells(7, 2).value = System.Convert.ToString(dbbonr.ebtwnr)
            ws.cells(7, 2).horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            ws.cells(8, 2).value = "www.jackyknoops.be"
            ws.cells(9, 2).value = dbbonr.eemail

            If dbbonr.fac = "J" Then
                ws.cells(10, 4).value = "Upload"
            End If
            If dbbonr.facm = "J" Then
                ws.cells(11, 4).value = "Mail"
                If dbbonr.kemailf <> "" Then
                    ws.cells(11, 5).value = dbbonr.kemailf
                End If
            End If
            If dbbonr.facp = "J" Then
                ws.cells(12, 4).value = "Post"
            End If
            ws.range("D10", "E12").font.color = RGB(139, 0, 0)
            ws.range("D10", "E12").font.bold = True


            ''If NaCalc = False Then ws.range("A1", "C10").Interior.color = RGB(255, 255, 133)
            If NaCalc = False Then ws.range("A1", "C10").font.color = RGB(1, 1, 216)
            'KLANT
            Dim finfo As String = ""
            Dim sendinfo As String = ""
            finfo = ""
            If NaCalc = False Then
                If dbbonr.fnr > 0 Then
                    finfo = " Factuur: " & dbbonr.fnr
                ElseIf dbbonr.cnr > 0 Then
                    finfo = " Creditnota: " & dbbonr.cnr
                End If
            End If
            sendinfo = ""
            If sendinfo <> "" Then sendinfo = "[" & sendinfo & "] "
            ws.cells(1, 7).value = sendinfo & finfo
            ws.cells(2, 8).value = dbbonr.KNaam
            ws.cells(2, 8).font.bold = FontStyle.Bold
            ws.cells(2, 8).font.size = 12
            ws.cells(3, 8).value = dbbonr.Kstraat
            ws.cells(4, 8).value = dbbonr.KAdres
            ws.cells(5, 9).value = dbbonr.kemail
            Dim phones As String
            phones = ""
            If dbbonr.ktel <> "" Then
                phones = phones & "Tel: " & dbbonr.ktel & " "
            End If
            If dbbonr.kgsm <> "" Then
                phones = phones & "GSM: " & dbbonr.kgsm & " "
            End If
            If dbbonr.kfax <> "" Then
                phones = phones & "Fax: " & dbbonr.kfax
            End If
            ws.cells(6, 8).value = phones

            ws.cells(7, 8).value = "BTWnr :"
            ws.cells(7, 9).value = dbbonr.KBTWNr
            ws.cells(7, 9).horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            ws.cells(8, 8).value = "Werf: "
            ws.cells(8, 9).value = dbbonr.kwadres
            ws.cells(9, 9).value = dbbonr.kwstraat

            ws.cells(10, 8).value = domsbon
            ws.Cells(12, 8).value = "Startdatum: " & dbbonr.dvan & " Einddatum: " & dbbonr.dtot

            ws.range("G" & 1, "K" & 1).merge
            ws.range("H" & 2, "K" & 2).merge
            ws.range("G" & 1, "K" & 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            ws.range("H" & 10, "K" & 10).merge
            ws.range("H" & 10, "K" & 10).WrapText = True

            bondesc = Replace(dbbonr.knaam, "*", "")
            bonfooter = bondesc & " " & domsbon
            bondesc = Replace(bondesc, " ", "_") & "_" & Replace(Left(domsbon, 10), "/", "")
        Next

        'resumé
        Dim bonlrecs = From bonl In db.BONLs
                       Join code In db.CODs On code.CNRQ Equals bonl.CNRQ
                       Join codgp In db.CODGPs On codgp.CGNRQ Equals code.CGNRQ
                       Join aoms In db.AOms On aoms.ANRQ Equals code.ANRQ
                       Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                       Where bonl.BONJR = keyjr And bonl.BONNR = keynr And btw.nieuwbon = NaCalc
                       Order By codgp.OmsGroep, code.OmsCode, code.CNRQ, code.Code, btw.BTW
                       Group By x = New With {
                           Key .omsgp = codgp.OmsGroep,
                           Key .omscode = code.OmsCode,
                           Key .cnrq = code.CNRQ,
                           Key .code = code.Code,
                           Key .btw = btw.BTW,
                           Key .eenhp = bonl.BONEenhp} Into g = Group
                       Select New With {
                           .omsgp = x.omsgp,
                           .omscode = x.omscode,
                           .cnrq = x.cnrq,
                           .code = x.code,
                           .btw = x.btw,
                           .count = g.Count,
                           .taantal = g.Sum(Function(r) r.bonl.Aantal),
                           .teenhp = x.eenhp,
                           .texcl = g.Sum(Function(r) r.bonl.Aantal) * x.eenhp,
                           .tbtw = (((g.Sum(Function(r) r.bonl.Aantal) * x.eenhp)) * x.btw) / 100
                           }

        'Page Break new page nieuwe pagina
        'ws.rows(bonlcnt + 16).PageBreak = 1

        Dim resrow As Integer = bonlcnt + 16

        'Header résumé
        ws.cells(resrow, 1) = "Résumé"
        ws.cells(resrow, 10) = "Totaal Incl."
        ws.cells(resrow, 10).horizontalalignment = Microsoft.Office.Interop.Excel.Constants.xlRight
        ws.cells(resrow, 1).font.size = 12
        ws.cells(resrow, 1).font.bold = True
        ws.cells(resrow, 10).font.size = 12
        ws.cells(resrow, 10).font.bold = True
        ws.range("I" & resrow, "J" & resrow).merge
        resrow = resrow + 1

        'print résumé
        Dim rescol As Integer = 0
        Dim keepgrp As String = ""
        Dim keepgrpp As String = ""
        Dim first As Boolean = True
        Dim gtotexcl As Double = 0
        Dim ftotexcl As Double = 0
        Dim gtotincl As Double = 0
        Dim ftotincl As Double = 0
        Dim gtotbtw As Double = 0
        Dim ftotbtw As Double = 0
        Dim GetCHAR As String = ""

        For Each bonrres In bonlrecs
            ws.cells(resrow, 1).value = ""
            If keepgrp <> bonrres.omsgp Then
                keepgrpp = keepgrp
                keepgrp = bonrres.omsgp
                If first = False Then
                    ws.cells(resrow, 1).value = "Totaal " & keepgrpp
                    ftotbtw = ftotbtw + gtotbtw
                    ws.cells(resrow, 7).value = gtotexcl
                    ws.cells(resrow, 7).NumberFormat = numform
                    ws.cells(resrow, 8).value = gtotbtw
                    ws.cells(resrow, 8).NumberFormat = numform
                    ftotexcl = ftotexcl + gtotexcl
                    ws.cells(resrow, 9).value = gtotincl
                    ws.cells(resrow, 9).NumberFormat = numform
                    ftotincl = ftotincl + gtotincl
                    ws.range("A" & resrow, "J" & resrow).font.size = 9

                    For index As Integer = 1 To 9
                        ws.cells(resrow, index).font.bold = True
                        ws.cells(resrow, index).Font.Color = RGB(57, 104, 162)
                    Next
                    ' display 
                    ws.range("A" & resrow, "J" & resrow).interior.color = RGB(204, 238, 255)
                    ws.range("A" & resrow, "F" & resrow).merge
                    ws.range("I" & resrow, "J" & resrow).merge

                    gtotexcl = 0
                    gtotincl = 0
                    gtotbtw = 0
                    resrow = resrow + 1
                End If
                first = False

                ws.cells(resrow, 2).value = "'" & bonrres.code
                ws.cells(resrow, 3).value = bonrres.omscode
                ws.range("C" & resrow, "D" & resrow).merge
                ws.cells(resrow, 5).value = bonrres.taantal
                ws.cells(resrow, 5).NumberFormat = numform
                ws.cells(resrow, 6).value = bonrres.teenhp
                ws.cells(resrow, 6).NumberFormat = numform
                ws.cells(resrow, 7).value = bonrres.texcl
                ws.cells(resrow, 7).NumberFormat = numform

                ws.range("A" & resrow, "J" & resrow).font.size = 9
                ws.range("A" & resrow, "J" & resrow).rowheight = 11.25
                ws.range("A" & resrow, "J" & resrow).borders.linestyle = xlContinuous
                ws.range("A" & resrow, "J" & resrow).borders.weight = xlThin
                ws.range("A" & resrow, "J" & resrow).borders.color = RGB(30, 144, 255)
                ws.range("I" & resrow, "J" & resrow).merge
                ''ws.cells(resrow, 1).interior.color = RGB(204, 238, 255)

                gtotexcl = gtotexcl + bonrres.texcl
                gtotincl = gtotincl + bonrres.texcl + bonrres.tbtw
                gtotbtw = gtotbtw + bonrres.tbtw
                resrow = resrow + 1

                Continue For
            End If
            ws.cells(resrow, 2).value = "'" & bonrres.code
            ws.cells(resrow, 3).value = bonrres.omscode
            ws.range("C" & resrow, "D" & resrow).merge
            ws.cells(resrow, 5).value = bonrres.taantal
            ws.cells(resrow, 5).NumberFormat = numform
            ws.cells(resrow, 6).value = bonrres.teenhp
            ws.cells(resrow, 6).NumberFormat = numform
            ws.cells(resrow, 7).value = bonrres.texcl
            ws.cells(resrow, 7).NumberFormat = numform

            ws.range("A" & resrow, "J" & resrow).font.size = 9
            ws.range("A" & resrow, "J" & resrow).rowheight = 11.25
            ws.range("A" & resrow, "J" & resrow).borders.linestyle = xlContinuous
            ws.range("A" & resrow, "J" & resrow).borders.weight = xlThin
            ws.range("A" & resrow, "J" & resrow).borders.color = RGB(30, 144, 255)
            ws.range("I" & resrow, "J" & resrow).merge

            gtotexcl = gtotexcl + bonrres.texcl
            gtotincl = gtotincl + bonrres.texcl + bonrres.tbtw
            gtotbtw = gtotbtw + bonrres.tbtw
            resrow = resrow + 1
        Next

        ws.cells(resrow, 1).value = "Totaal " & keepgrp
        ws.cells(resrow, 8).value = gtotbtw
        ws.cells(resrow, 8).NumberFormat = numform
        ftotbtw = ftotbtw + gtotbtw
        ws.cells(resrow, 7).value = gtotexcl
        ws.cells(resrow, 7).NumberFormat = numform
        ftotexcl = ftotexcl + gtotexcl
        ws.cells(resrow, 9).value = gtotincl
        ws.cells(resrow, 9).NumberFormat = numform
        ftotincl = ftotincl + gtotincl
        ws.range("A" & resrow, "J" & resrow).font.size = 9

        For index As Integer = 1 To 9
            ws.cells(resrow, index).font.bold = True
            ws.cells(resrow, index).Font.Color = RGB(57, 104, 162)
        Next
        ' display 
        ws.range("A" & resrow, "J" & resrow).interior.color = RGB(204, 238, 255)
        ws.range("A" & resrow, "F" & resrow).merge
        ws.range("I" & resrow, "J" & resrow).merge

        resrow = resrow + 2

        '' EINDTOTAAL
        ws.cells(resrow, 6).value = "Totaal: "
        ws.cells(resrow, 7).value = ftotexcl
        ws.cells(resrow, 8).value = ftotbtw
        ws.cells(resrow, 10).value = ftotincl
        For index As Integer = 5 To 10
            ws.cells(resrow, index).numberformat = numform
            ws.cells(resrow, index).font.size = 10
            ws.cells(resrow, index).font.bold = True
        Next
        ws.range("I" & resrow, "J" & resrow).merge

        objExcelApp.Application.PrintCommunication = False
        With objExcelApp.ActiveSheet.PageSetup
            .FitToPagesWide = 1
            .FitToPagesTall = False
            .printtitlerows = "$14:$14"
            .LeftHeader = ""
            .CenterHeader = ""
            .RightHeader = ""
            '.LeftFooter = "Pagina &P/&N" & " " & System.DateTime.Now.ToString("dd/MM/yyyy")
            .LeftFooter = "Pagina &P/&N"
            .CenterFooter = ""
            .RightFooter = keyjr & "-" & keynr & " " & bonfooter
            .LeftMargin = objExcelApp.InchesToPoints(0.25)
            .RightMargin = objExcelApp.InchesToPoints(0.25)
            .TopMargin = objExcelApp.InchesToPoints(0.5)
            .BottomMargin = objExcelApp.InchesToPoints(0.5)
            .HeaderMargin = objExcelApp.InchesToPoints(0.3)
            .FooterMargin = objExcelApp.InchesToPoints(0.3)
            .PrintHeadings = False
            .PrintGridlines = False
            .CenterHorizontally = False
            .CenterVertically = False
        End With
        objExcelApp.Application.PrintCommunication = True
        Dim tofile As String = filenm & "\Bonnen\" & keyjr
        If (Not System.IO.Directory.Exists(tofile)) Then
            System.IO.Directory.CreateDirectory(tofile)
        End If
        Dim dtstr As String = ""
        dtstr = "_" & Today.ToString("yyyy.MM.dd") & "." & DateTime.Now.ToString("HH.mm.ss")

        If NaCalc = True Then
            tofile = tofile & "\" & bondesc & "_" & keyjr & "-" & keynr & "_Nacalculatie" & dtstr & ".xlsx"
        Else
            tofile = tofile & "\" & bondesc & "_" & keyjr & "-" & keynr & dtstr & ".xlsx"
        End If
        objExcelApp.DisplayAlerts = False
        Try
            wb.SaveAs(tofile)
            objExcelApp.Visible = False
            objExcelApp.DisplayAlerts = True
        Catch ex As Exception
        End Try

        wb.close(False)
        wb = Nothing

        objExcelApp.quit()
        objExcelApp = Nothing
        Return tofile

    End Function

    Public Sub restorebons()
        ' Dim path = GetAndCreateFilePath()

        ' Dim results = (From line In File.ReadAllLines(path).Dump("Lines read")
        '               Let value = line.Split(",").
        'Skip(1). ' Skip the RowNumber 
        'Select Case (Function(x) Integer.Parse(x))
        'Select Case New With {.MinimumValue = value.Min(),
        '.MaximumValue = value.Max(),
        '.Average = value.Average(),
        '.RowTotal = value.Sum()}).ToList().Dump("Statistics")
        '
        'File.Delete(path)
    End Sub


End Module