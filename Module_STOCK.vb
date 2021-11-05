Module Module_STOCK

    Public Function StockUpdate(what As String, scnrq As Integer, sbonjr As Integer, sbonnr As Integer, sbonvnr As Integer, newaantal As String)
        Dim UpdateOK As String = ""
        Dim codCode As String = ""
        Dim oldstock As Double
        Dim newstock As Double
        Dim oaantal As Double = 0
        Dim ocnrq As Integer
        Dim NoStock As Boolean = False
        Dim plusmin As String = "+"

        'what "N"=new  "U"=update  "D"=delete
        ' N : + = stock verminderen - = stock vermeerderen 
        '     --> je kan meteen updaten met newaantal (geen select nodig)
        ' D : + = stock vermeerderen - = stock verminderen 
        '     --> haal hier eerst bonl.aantal op met select.. naantal = 0
        ' U : Eerst D, daarna N 
        '     --> dus ook voor D bonl.aantal ophalen en voor N naantal gebruiken

        If what = "D" Or what = "U" Then
            ' zet eerst de vorige actie terug recht voor je delete of update doet
            ' neem ook de CNRQ van de bon zoals die "toen" was.
            Dim getbonl = (From bonl In db.BONLs
                           Where bonl.BONJR = sbonjr And bonl.BONNR = sbonnr And bonl.BONLVNR = sbonvnr
                           Select bonl.Aantal, bonl.CNRQ).First
            oaantal = getbonl.Aantal
            If what = "U" And oaantal = newaantal Then
                Return UpdateOK
            End If
            ocnrq = getbonl.CNRQ
            Dim getcodc = (From cod In db.CODs
                               Where cod.CNRQ = ocnrq
                               Select cod.notstock, cod.Stock, cod.Code).First
            NoStock = getcodc.notstock
            oldstock = getcodc.Stock
            codCode = getcodc.Code

            If NoStock = False Then
                    If oaantal <> 0 Then
                        ' omgekeerde bewerking... wat er toen bijkwam moet er nu vanaf
                        If oaantal > 0 Then
                            newstock = oldstock + oaantal
                            plusmin = "+"
                        Else
                        If (oldstock < oaantal) Then UpdateOK = UpdateOK + " STOCKteKLEIN: " + codCode
                        newstock = oldstock + oaantal
                            plusmin = "-"
                        End If
                        SaveStock(True, plusmin, oaantal, ocnrq, newstock, sbonjr, sbonnr, sbonvnr)
                    End If
                End If
            End If
            If what = "D" Then
            Return UpdateOK
        End If

        ' nu nog de N en U voor het nieuwe aantal
        Dim getcodn = (From cod In db.CODs
                       Where cod.CNRQ = scnrq
                       Select cod.notstock, cod.Stock, cod.Code).First
        NoStock = getcodn.notstock
        oldstock = getcodn.Stock
        codCode = getcodn.Code
        If NoStock = False Then
            If newaantal <> 0 Then
                If newaantal > 0 Then
                    If oldstock < newaantal Then UpdateOK = UpdateOK + " STOCKteKLEIN: " + codCode
                    newstock = oldstock - newaantal
                    plusmin = "-"
                Else
                    newstock = oldstock - newaantal
                    plusmin = "+"
                End If

                SaveStock(False, plusmin, newaantal, scnrq, newstock, sbonjr, sbonnr, sbonvnr)
            End If
        End If
        Return UpdateOK

    End Function

    Public Sub SaveStock(back As Boolean, plusmin As String, aantal As Double, getcnrq As Integer, newstock As Double, bjr As Integer, bnr As Integer, bvnr As Integer)
        Dim updaterec = (From cod In db.CODs
                         Where cod.CNRQ = getcnrq).ToList()(0)
        updaterec.Stock = newstock
        updaterec.lupdate = plusmin & aantal & " " & bjr & "-" & bnr & "-" & bvnr
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try

        ' HISTORIEK
        Dim hcode As String = ""
        Dim hcgnrq As Integer
        Dim homscode As String = ""
        Dim hgrpoms As String = ""
        Dim msg As String = ""

        Dim getcodh = (From cod In db.CODs
                       Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                       Where cod.CNRQ = getcnrq
                       Select cod.Code, cod.CGNRQ, cod.OmsCode, codgp.OmsGroep).First
        hcgnrq = getcodh.CGNRQ
        hcode = getcodh.Code
        homscode = getcodh.OmsCode
        hgrpoms = getcodh.OmsGroep

        msg = bjr & "/" & bnr & "-" & bvnr & " ["
        If back = True Then msg = msg & "Delete/Update "
        msg = msg & plusmin & aantal & " " & "(" & LoginNm & " - " & ChDate & " " & DateTime.Now.ToString("HH:mm:ss") & ")]"

        Dim newrec As New STOCK With {
        .stcgnrq = hcgnrq,
        .stcnrq = getcnrq,
        .stcode = hcode,
        .stomscode = homscode,
        .stomsgroep = hgrpoms,
        .strans = plusmin,
        .saantal = aantal,
        .soms = msg,
        .sdat = ChDate
        }

        db.STOCKs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try

    End Sub

    Public Function StockUpdatePer(what As String, scnrq As Integer, spernrq As Integer, spervnr As Integer, newaantal As String)
        Dim UpdateOK As String = ""
        Dim codCode As String = ""
        Dim oldstock As Double
        Dim newstock As Double
        Dim oaantal As Double = 0
        Dim ocnrq As Integer
        Dim NoStock As Boolean = False
        Dim plusmin As String = "+"

        'what "N"=new  "U"=update  "D"=delete
        ' N : + = stock verminderen - = stock vermeerderen 
        '     --> je kan meteen updaten met newaantal (geen select nodig)
        ' D : + = stock vermeerderen - = stock verminderen 
        '     --> haal hier eerst bonl.aantal op met select.. naantal = 0
        ' U : Eerst D, daarna N 
        '     --> dus ook voor D bonl.aantal ophalen en voor N naantal gebruiken

        If what = "D" Or what = "U" Then
            ' zet eerst de vorige actie terug recht voor je delete of update doet
            ' neem ook de CNRQ van de bon zoals die "toen" was.
            Dim getperl = (From perl In db.PERLs
                           Where perl.PERL_NRQ = spernrq And perl.PERL_VNR = spervnr
                           Select perl.AANTAL, perl.CNRQ).First
            oaantal = getperl.AANTAL
            If what = "U" And oaantal = newaantal Then
                Return UpdateOK
            End If
            ocnrq = getperl.CNRQ
            Dim getcodc = (From cod In db.CODs
                           Where cod.CNRQ = ocnrq
                           Select cod.notstock, cod.Stock, cod.Code).First
            NoStock = getcodc.notstock
            oldstock = getcodc.Stock
            codCode = getcodc.Code

            If NoStock = False Then
                If oaantal <> 0 Then
                    ' omgekeerde bewerking... wat er toen bijkwam moet er nu vanaf
                    If oaantal > 0 Then
                        newstock = oldstock + oaantal
                        plusmin = "+"
                    Else
                        If (oldstock < oaantal) Then UpdateOK = UpdateOK + "#" + what + "_STOCKteKLEIN_" + codCode
                        newstock = oldstock + oaantal
                        plusmin = "-"
                    End If
                    SaveStockPer(True, plusmin, oaantal, ocnrq, newstock, spernrq, spervnr)
                End If
            End If
        End If
        If what = "D" Then
            Return UpdateOK
        End If

        ' nu nog de N en U voor het nieuwe aantal
        Dim getcodn = (From cod In db.CODs
                       Where cod.CNRQ = scnrq
                       Select cod.notstock, cod.Stock, cod.Code).First
        NoStock = getcodn.notstock
        oldstock = getcodn.Stock
        codCode = getcodn.Code
        If NoStock = False Then
            If newaantal <> 0 Then
                If newaantal > 0 Then
                    If oldstock < newaantal Then UpdateOK = UpdateOK + "#" + what + "_STOCKteKLEIN_" + codCode
                    newstock = oldstock - newaantal
                    plusmin = "-"
                Else
                    newstock = oldstock - newaantal
                    plusmin = "+"
                End If

                SaveStockPer(False, plusmin, newaantal, scnrq, newstock, spernrq, spervnr)
            End If
        End If
        Return UpdateOK

    End Function

    Public Sub SaveStockPer(back As Boolean, plusmin As String, aantal As Double, getcnrq As Integer, newstock As Double, bnrq As Integer, bvnr As Integer)
        Dim updaterec = (From cod In db.CODs
                         Where cod.CNRQ = getcnrq).ToList()(0)
        updaterec.Stock = newstock
        updaterec.lupdate = plusmin & aantal & " Personeel (" & bnrq & "-" & bvnr & ")"
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try

        ' HISTORIEK
        Dim hcode As String = ""
        Dim hcgnrq As Integer
        Dim homscode As String = ""
        Dim hgrpoms As String = ""
        Dim msg As String = ""

        Dim getcodh = (From cod In db.CODs
                       Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                       Where cod.CNRQ = getcnrq
                       Select cod.Code, cod.CGNRQ, cod.OmsCode, codgp.OmsGroep).First
        hcgnrq = getcodh.CGNRQ
        hcode = getcodh.Code
        homscode = getcodh.OmsCode
        hgrpoms = getcodh.OmsGroep

        msg = "Personeel " & "(" & bnrq & "-" & bvnr & ") "
        If back = True Then msg = msg & "Delete/Update "
        msg = msg & plusmin & aantal & " " & "(" & LoginNm & " - " & ChDate & " " & DateTime.Now.ToString("HH:mm:ss") & ")]"

        Dim newrec As New STOCK With {
        .stcgnrq = hcgnrq,
        .stcnrq = getcnrq,
        .stcode = hcode,
        .stomscode = homscode,
        .stomsgroep = hgrpoms,
        .strans = plusmin,
        .saantal = aantal,
        .soms = msg,
        .sdat = ChDate
        }

        db.STOCKs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try

    End Sub

End Module
