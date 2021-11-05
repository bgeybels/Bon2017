Module Module_BON

    Public Function CopyBON(fltbonjr As String)
        'Copy bon naar newjr: keybonjr, keybonnr
        Dim CoMoOK As Boolean = False

        Dim ToJaar As String
        ToJaar = InputBox("Dupliceer BON " & keybonjr & "/" & keybonnr & " naar jaar: ", "Dupliceer Bon + BonLijnen", fltbonjr)
        If ToJaar = "" Then
            Return CoMoOK
        End If

        If Not IsNumeric(ToJaar) Then
            MsgBox("Nieuw bonjaar niet numerisch!")
            Return CoMoOK
        ElseIf Len(ToJaar) <> 4 Then
            MsgBox("Bonjaar niet correct!")
            Return CoMoOK
        End If

        'BON dupliceren
        Dim frombons = From bon In db.BONs
                       Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr
        Dim newbonnr = GetHighBonNR(ToJaar)
        '.OmsBon = frombon.OmsBon & " ( V" & keybonjr & "/" & keybonnr & ")",
        For Each frombon In frombons
            Dim newrec As New BON With {
            .BONJR = ToJaar,
            .BONNR = newbonnr,
            .KNRQ = frombon.KNRQ,
            .ENRQ = frombon.ENRQ,
            .DatumAanvang = ChDate,
            .OmsBon = frombon.OmsBon,
            .Particulier = frombon.Particulier,
            .Betaald = frombon.Betaald,
            .printed = 0,
            .tav = frombon.tav,
            .dvan = frombon.dvan,
            .dtot = frombon.dtot,
            .cnr = 0,
            .fnr = 0,
            .fok = 0,
            .cok = 0,
            .del = 0,
            .tbw = 0,
            .vs = 0,
            .gstk = 0,
            .uv = 0,
            .klaar = 0,
            .OPM = frombon.OPM,
            .bon_type = frombon.bon_type,
            .usernrq = LoginNm,
            .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
            }
            db.BONs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
            Catch ex As Exception
                MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
                Return CoMoOK
                ' Handle exception.  
            End Try
            Dim key = ToJaar & "/" & newbonnr.ToString("0000")
            Archive("BON_N", key, frombon.OmsBon)
        Next

        'BONLIJNEN dupliceren
        CopyBONL(keybonjr, keybonnr, ToJaar, newbonnr)

        '' update VAN-bon met het naar-bonnummer
        'Dim updaterec = (From bon In db.BONs
        'Where bon.BONJR = keybonjr AndAlso bon.BONNR = keybonnr).ToList()(0)
        '
        'updaterec.OmsBon = updaterec.OmsBon & " ( N" & ToJaar & "/" & newbonnr & ")"
        'Try
        'db.SubmitChanges()
        'Catch
        'End Try

        keybonjr = ToJaar
        keybonnr = newbonnr
        My.Settings.fltbonjr = keybonjr
        CoMoOK = True
        Return CoMoOK
    End Function

    Public Sub CopyBONL(kjr As Integer, knr As Integer, tokjr As Integer, toknr As Integer)
        Dim frombonls = From bonl In db.BONLs
                        Where bonl.BONJR = kjr AndAlso bonl.BONNR = knr
        For Each frombonl In frombonls
            Dim newbonlvnr = GetHighBonLVNR(tokjr, toknr)
            Dim newbonlvolgorde = GetHighBonLVolgorde(tokjr, toknr)
            Dim newrec As New BONL With {
                    .BONJR = tokjr,
                    .BONNR = toknr,
                    .BONLVNR = newbonlvnr,
                    .Volgorde = newbonlvolgorde,
                    .Datum = frombonl.Datum,
                    .BLSORT = frombonl.Datum.ToString("yyyyMMdd") & "-" & .Volgorde.ToString("D4"),
                    .BWStraat = frombonl.BWStraat,
                    .BWAdres = frombonl.BWAdres,
                    .Aantal = frombonl.Aantal,
                    .BONEenhp = frombonl.BONEenhp,
                    .BONEenhpbu = frombonl.BONEenhpbu,
                    .select = 0,
                    .levering = 0,
                    .diesel = 0,
                    .omstijd = frombonl.omstijd,
                    .EXTNR = frombonl.EXTNR,
                    .DNRQ = 0,
                    .ANRQ = frombonl.ANRQ,
                    .memo = frombonl.memo,
                    .PERNM = frombonl.PERNM,
                    .OAANMNM = frombonl.OAANMNM,
                    .LEVNM = frombonl.LEVNM,
                    .AP = frombonl.AP,
                    .BNRQ = frombonl.BNRQ,
                    .CNRQ = frombonl.CNRQ,
                    .CONTROLEOK = 0,
                    .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                    .usernrq = LoginNm,
                    .usercre = LoginNm,
                    .datecre = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
                }
            db.BONLs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
                If updatestock = True Then
                    updateOK = StockUpdate("N", frombonl.CNRQ, tokjr, toknr, newbonlvnr, frombonl.Aantal)
                End If
            Catch
                ' Handle exception.  
            End Try
        Next
    End Sub

    Public Sub CopyBONLSelected(kjr As Integer, knr As Integer, tokjr As Integer, toknr As Integer)
        Dim frombonls = From bonl In db.BONLs
                        Where bonl.BONJR = kjr AndAlso bonl.BONNR = knr AndAlso bonl.select = True

        For Each frombonl In frombonls
            Dim newbonlvnr = GetHighBonLVNR(tokjr, toknr)
            Dim newbonlvolgorde = GetHighBonLVolgorde(tokjr, toknr)
            Dim newrec As New BONL With {
                    .BONJR = tokjr,
                    .BONNR = toknr,
                    .BONLVNR = newbonlvnr,
                    .Volgorde = newbonlvolgorde,
                    .Datum = frombonl.Datum,
                    .BLSORT = frombonl.Datum.ToString("yyyyMMdd") & "-" & .Volgorde.ToString("D4"),
                    .BWStraat = frombonl.BWStraat,
                    .BWAdres = frombonl.BWAdres,
                    .Aantal = frombonl.Aantal,
                    .BONEenhp = frombonl.BONEenhp,
                    .BONEenhpbu = frombonl.BONEenhpbu,
                    .select = 0,
                    .levering = 0,
                    .diesel = 0,
                    .omstijd = frombonl.omstijd,
                    .EXTNR = frombonl.EXTNR,
                    .DNRQ = 0,
                    .ANRQ = frombonl.ANRQ,
                    .memo = frombonl.memo,
                    .PERNM = frombonl.PERNM,
                    .OAANMNM = frombonl.OAANMNM,
                    .LEVNM = frombonl.LEVNM,
                    .AP = frombonl.AP,
                    .BNRQ = frombonl.BNRQ,
                    .CNRQ = frombonl.CNRQ,
                    .CONTROLEOK = 0,
                    .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                    .usernrq = LoginNm,
                    .usercre = LoginNm,
                    .datecre = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
                }
            db.BONLs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
                If updatestock = True Then
                    updateOK = StockUpdate("N", frombonl.CNRQ, tokjr, toknr, newbonlvnr, frombonl.Aantal)
                End If
            Catch
                ' Handle exception.  
            End Try
        Next

        ' update VAN-bon met het naar-bonnummer
        Dim updaterec = (From bon In db.BONs
                         Where bon.BONJR = kjr AndAlso bon.BONNR = knr).ToList()(0)
        updaterec.OmsBon = updaterec.OmsBon & " (N" & tokjr & "/" & toknr & ")"
        Try
            db.SubmitChanges()
        Catch
        End Try
        ' update NAAR-bon met het van-bonnummer
        Dim updaterecn = (From bon In db.BONs
                          Where bon.BONJR = tokjr AndAlso bon.BONNR = toknr).ToList()(0)
        updaterecn.OmsBon = updaterecn.OmsBon & " (V" & kjr & "/" & knr & ")"
        Try
            db.SubmitChanges()
        Catch
        End Try
    End Sub

    Public Sub Bondvantot(keyjr As Integer, keynr As Integer)
        ' Hoogste/laagste datum ophalen
        Dim frombonls = From bonl In db.BONLs
                        Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                        Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                        Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr
                        Select bonl.Aantal, bonl.BONEenhp, bonl.BNRQ, code.KMHEFFING, bonl.Datum, bonl.OAANMNM, bonl.AP

        Dim totrm As Decimal = 0
        Dim totkm As Decimal = 0
        Dim totnac As Decimal = 0
        Dim resultaat As Decimal = 0
        Dim tot As Decimal = 0
        Dim calcx As Decimal = 0
        Dim telbonl As Integer = 0
        'Dim negatief As String
        Dim DtHigh As Date = #01/01/1000#
        Dim DtLow As Date = DateTime.Now
        Dim rfound As Boolean = False
        For Each frombon In frombonls
            rfound = True
            If DtHigh < frombon.Datum Then
                DtHigh = frombon.Datum
            End If
            If DtLow > frombon.Datum Then
                DtLow = frombon.Datum
            End If

            telbonl = telbonl + 1
            calcx = frombon.BONEenhp * frombon.Aantal
            If frombon.OAANMNM <> "" Then calcx = frombon.AP * frombon.Aantal

            If frombon.KMHEFFING = 0 Then
                Select Case frombon.BNRQ
                    Case 11
                        totrm = totrm + calcx
                    Case 1
                        totnac = totnac + calcx
                    Case Else
                        tot = tot + calcx
                End Select
            Else
                totkm = totkm + calcx
            End If
        Next
        If rfound = True Then
            ' update dvan/dtot in BON
            Dim updaterec = (From bon In db.BONs
                             Where bon.BONJR = keyjr AndAlso bon.BONNR = keynr).ToList()(0)

            updaterec.dvan = DtLow
            updaterec.dtot = DtHigh

            updaterec.TRESULT = (tot - totnac) + totkm
            updaterec.TRECUP = totrm
            updaterec.TNACALC = totnac
            updaterec.TFACT = tot
            updaterec.TKILOH = totkm

            Try
                db.SubmitChanges()
            Catch
                MsgBox("nietgelukt")
            End Try
        End If
    End Sub

    Public Function GroupBONL()
        'Groepeer de bonlijnen: keybonjr, keybonnr, keybonlvnr
        Dim GroupingOK As String = "OK"
        Dim grkey As String = ""
        Dim grkeys As String = ""
        Dim firstrun As Boolean = True
        Dim taantal As Double = 0

        If MsgBox("Bonlijnen groeperen op Code, BTW en eenheidsprijs?", MsgBoxStyle.YesNo, "Groeperen bonlijnen " & keybonjr & "/" & keybonnr) = MsgBoxResult.No Then
            GroupingOK = "STOP"
            Return GroupingOK
        End If

        'Maak eerst BONLdup leeg
        Try
            delrecs = From bonldup In db.BONLdups
            For Each deleterec In delrecs
                db.BONLdups.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Catch
            GroupingOK = "DELBONLDUP"
            'MsgBox("Probleem bij verwijderen BONLDUP")
            Return GroupingOK
        End Try

        'Groepeer op CNRQ, BNRQ, BONEenhp en aantal=aantal+
        Dim bonlrecs = From bonl In db.BONLs
                       Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
                       Order By bonl.CNRQ, bonl.BNRQ, bonl.BONEenhp

        ' loop over de bonlijnen... eerste grkey<>grkeys = nieuwe bonldup + bewaar de keys bonldupjr/nr
        ' bij volgende grkey<>grkeys update aantal van de hulpkeys
        ' reset aantal + hulpkeys
        keybonldjr = keybonjr
        keybonldnr = keybonnr
        keybonldvnr = 0
        For Each bonlr In bonlrecs
            grkey = "CNRQ_" & bonlr.CNRQ & " BNRQ_" & bonlr.BNRQ & " EENHP_" & bonlr.BONEenhp
            If grkey <> grkeys Then
                grkeys = grkey
                If firstrun = True Then
                    firstrun = False
                    taantal = 0
                Else
                    'update eerst met de oude keys
                    BonlDUP_update(taantal)
                    taantal = 0
                End If
                'init het nieuwe record
                BonlDUP_Add(bonlr.BONJR, bonlr.BONNR, bonlr.BONLVNR)
            End If
            taantal = taantal + bonlr.Aantal
        Next

        If started = True Then
            BonlDUP_update(taantal)
        End If

        ' verwijder bonl
        Try
            delrecs = From bonl In db.BONLs Where bonl.BONJR = keybonjr And bonl.BONNR = keybonnr
            For Each deleterec In delrecs
                db.BONLs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Catch
            GroupingOK = "DELBONL"
            'MsgBox("Probleem bij verwijderen BONL")
            Return GroupingOK
        End Try
        ' zet nu bonldup naar bonl
        Dim bonldrecs = From bonldup In db.BONLdups
                        Where bonldup.BONJR = keybonldjr And bonldup.BONNR = keybonldnr

        For Each bonldrec In bonldrecs
            Dim newrec As New BONL With {
            .BONJR = keybonldjr,
            .BONNR = keybonldnr,
            .BONLVNR = bonldrec.BONLVNR,
            .Volgorde = bonldrec.Volgorde,
            .Datum = bonldrec.Datum,
            .BLSORT = bonldrec.Datum.ToString("yyyyMMdd") & "-" & .Volgorde.ToString("D4"),
            .BWStraat = bonldrec.BWStraat,
            .BWAdres = bonldrec.BWAdres,
            .Aantal = bonldrec.Aantal,
            .BONEenhp = bonldrec.BONEenhp,
            .BONEenhpbu = bonldrec.BONEenhp,
            .select = bonldrec.select,
            .levering = bonldrec.levering,
            .diesel = 0,
            .omstijd = "",
            .EXTNR = bonldrec.EXTNR,
            .DNRQ = 0,
            .CONTROLEOK = 0,
            .memo = bonldrec.memo,
            .PERNM = bonldrec.PERNM,
            .OAANMNM = bonldrec.OAANMNM,
            .LEVNM = "",
            .AP = 0,
            .BNRQ = bonldrec.BNRQ,
            .CNRQ = bonldrec.CNRQ,
            .ANRQ = bonldrec.ANRQ,
            .chdate = bonldrec.chdate,
            .usernrq = bonldrec.usernrq,
            .usercre = bonldrec.usercre,
            .datecre = bonldrec.datecre
        }

            db.BONLs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
            Catch
                GroupingOK = "ADDGRBONL"
                Return GroupingOK
            End Try
        Next

        Return GroupingOK
    End Function

    Public Sub BonlDUP_update(taantal As Double)
        'update keybonldvnr
        'MsgBox(taantal)

        Dim updaterec = (From bonldup In db.BONLdups
                         Where bonldup.BONJR = keybonldjr And bonldup.BONNR = keybonldnr And bonldup.BONLVNR = keybonldvnr).ToList()(0)

        updaterec.Aantal = taantal
        Try
            db.SubmitChanges()
        Catch ex As Exception
        End Try
        started = False
    End Sub

    Public Sub BonlDUP_Add(fkeyjr As Integer, fkeynr As Integer, fkeylvnr As Integer)
        ' voeg 1 lijn toe met dezelfde info als nkeyjr+nkeynr
        ' aantal = 0

        Dim bonld = From bonl In db.BONLs
                    Where bonl.BONJR = fkeyjr And bonl.BONNR = fkeynr And bonl.BONLVNR = fkeylvnr

        For Each bonldrec In bonld
            keybonldvnr = GetHighBonLDupVNR(keybonldjr, keybonldnr)

            Dim newrec As New BONLdup With {
            .BONJR = keybonldjr,
            .BONNR = keybonldnr,
            .BONLVNR = keybonldvnr,
            .Volgorde = keybonldvnr,
            .Datum = ChDate,
            .BWStraat = bonldrec.BWStraat,
            .BWAdres = bonldrec.BWAdres,
            .Aantal = 0,
            .BONEenhp = bonldrec.BONEenhp,
            .BONEenhpbu = bonldrec.BONEenhp,
            .select = bonldrec.select,
            .levering = bonldrec.levering,
            .diesel = 0,
            .omstijd = "",
            .EXTNR = bonldrec.EXTNR,
            .DNRQ = 0,
            .memo = bonldrec.memo,
            .PERNM = bonldrec.PERNM,
            .OAANMNM = bonldrec.OAANMNM,
            .BNRQ = bonldrec.BNRQ,
            .CNRQ = bonldrec.CNRQ,
            .ANRQ = bonldrec.ANRQ,
            .chdate = ChDate,
            .usernrq = LoginNm,
            .usercre = LoginNm,
            .datecre = ChDate
        }

            db.BONLdups.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
            Catch
            End Try
        Next
        started = True
    End Sub

    Public Function GetBonlFigures(keyjr As Integer, keynr As Integer)
        Dim found As String = ""
        searchrecs = From bon In db.BONs
                     Where bon.BONJR = keyjr And bon.BONNR = keynr
                     Select bon.BONJR, bon.BONNR, bon.OPM, bon.klaar

        Dim bonopm As String = ""
        Dim bonklaar As Boolean = False
        For Each searchrec In searchrecs
            bonopm = searchrec.opm
            bonklaar = searchrec.klaar
        Next

        searchrecs = From bonl In db.BONLs
                     Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                     Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                     Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr
                     Select bonl.Aantal, bonl.BONEenhp, bonl.AP, bonl.BNRQ, code.KMHEFFING, bonl.OAANMNM

        Dim totrm As Decimal = 0
        Dim totkm As Decimal = 0
        Dim totnac As Decimal = 0
        Dim tot As Decimal = 0
        Dim calcx As Decimal = 0
        Dim telbonl As Integer = 0
        For Each searchrec In searchrecs
            telbonl = telbonl + 1
            calcx = searchrec.BONEenhp * searchrec.Aantal
            If searchrec.KMHEFFING = 0 Then
                Select Case searchrec.BNRQ
                    ' was 11
                    ' 8 = recupe 0%
                    Case 8
                        totrm = totrm + calcx
                    ' 1 = Nacalculaties 0%
                    Case 1
                        totnac = totnac + calcx
                    Case Else
                        tot = tot + calcx
                End Select
            Else
                totkm = totkm + calcx
            End If
        Next
        found = buildresult(totrm, totkm, totnac, 0, tot, telbonl, bonopm, bonklaar)

        Return found
    End Function

    Public Function buildresult(totrm As Decimal, totkm As Decimal, totnac As Decimal, totnaco As Decimal, tot As Decimal, telbonl As Integer, bonopm As String, bonklaar As Boolean)
        Dim resultaat As Decimal = 0
        Dim found As String
        Dim negatief As String
        Dim resulto As Decimal = 0

        resultaat = (tot - totnac) + totkm
        found = " Selectie bonlijnen: " & telbonl
        found &= Environment.NewLine
        If (TotalsAllowed = True) Then
            found = found & LSet(" RM    : " & totrm.ToString("0.00"), 30) & " Nacalc.: " & totnac.ToString("0.00")
        End If
        found &= Environment.NewLine
        If (TotalsAllowed = True) Then
            found = found & LSet(" Fact. : " & tot.ToString("0.00"), 30) & " KilometerH. : " & totkm.ToString("0.00")
        End If
        found &= Environment.NewLine
        If (TotalsAllowed = True) Then
            found = found & LSet(" Result.: " & resultaat.ToString("0.00"), 30)
        End If
        found &= Environment.NewLine
        found = found & " " & bonopm
        negatief = "N"
        If resultaat < 0 Then negatief = "Y"
        Return negatief & "#" & found
    End Function

    Public Function buildresultolder(totrm As Decimal, totkm As Decimal, totnac As Decimal, totnaco As Decimal, tot As Decimal, telbonl As Integer, bonopm As String, bonklaar As Boolean)
        Dim resultaat As Decimal = 0
        Dim found As String
        Dim negatief As String
        Dim resulto As Decimal = 0

        resultaat = (tot - totnac) + totkm
        found = " Selectie bonlijnen: " & telbonl
        found &= Environment.NewLine
        If (LoginTotalsSys = True) Or ((LoginTotals = True) And (bonklaar = True)) Then
            found = found & LSet(" RM    : " & totrm.ToString("0.00"), 30) & " Nacalc.: " & totnac.ToString("0.00")
        End If
        found &= Environment.NewLine
        If (LoginTotalsSys = True) Or ((LoginTotals = True) And (bonklaar = True)) Then
            found = found & LSet(" Fact. : " & tot.ToString("0.00"), 30) & " KilometerH. : " & totkm.ToString("0.00")
        End If
        found &= Environment.NewLine
        If (LoginTotalsSys = True) Or ((LoginTotals = True) And (bonklaar = True)) Then
            found = found & LSet(" Result.: " & resultaat.ToString("0.00"), 30)
        End If
        found &= Environment.NewLine
        found = found & " " & bonopm
        negatief = "N"
        If resultaat < 0 Then negatief = "Y"
        Return negatief & "#" & found
    End Function

    Public Function buildresultOLD(totrm As Decimal, totkm As Decimal, totnac As Decimal, totnaco As Decimal, tot As Decimal, telbonl As Integer)
        'having NACALCO
        Dim resultaat As Decimal = 0
        Dim found As String
        Dim negatief As String
        Dim resulto As Decimal = 0

        resultaat = (tot - totnac) + totkm
        resulto = totnac - totnaco
        found = " Selectie bonlijnen: " & telbonl
        found = found & Environment.NewLine
        found = found & LSet(" RM    : " & totrm.ToString("0.00"), 30) & " Nacalc.: " & totnac.ToString("0.00")
        found = found & Environment.NewLine
        found = found & LSet(" Fact. : " & tot.ToString("0.00"), 30) & " KilometerH. : " & totkm.ToString("0.00")
        found = found & Environment.NewLine
        found = found & LSet(" Result.: " & resultaat.ToString("0.00"), 30) & " NacalcO.: " & resulto.ToString("0.00")
        negatief = "N"
        If resultaat < 0 Then negatief = "Y"
        Return negatief & "#" & found
    End Function

    Public Function GetSELBonlFigures(bonldata As DataGridView, keyjr As Integer, keynr As Integer)
        Dim found As String
        Dim totrm As Decimal = 0
        Dim totkm As Decimal = 0
        Dim totnac As Decimal = 0
        Dim totnaco As Decimal = 0
        Dim tot As Decimal = 0
        Dim calcx As Decimal
        Dim telbonl As Integer = 0

        searchrecs = From bon In db.BONs
                     Where bon.BONJR = keyjr And bon.BONNR = keynr
                     Select bon.BONJR, bon.BONNR, bon.OPM, bon.klaar

        Dim bonklaar As Boolean = False
        For Each searchrec In searchrecs
            bonklaar = searchrec.klaar
        Next

        Try
            For Each row As DataGridViewRow In bonldata.Rows
                telbonl = telbonl + 1
                calcx = row.Cells("Aantal").Value * row.Cells("EenhPrijs").Value
                If row.Cells("KMHEFFING").Value = 0 Then
                    Select Case row.Cells("BNRQ").Value
                        Case 8
                            totrm = totrm + calcx
                        Case 1
                            totnac = totnac + calcx
                        Case Else
                            tot = tot + calcx
                    End Select
                Else
                    totkm = totkm + calcx
                End If
            Next
        Catch ex As Exception

        End Try

        found = buildresult(totrm, totkm, totnac, 0, tot, telbonl, "", bonklaar)

        Return found
    End Function

    Public Sub DelBONLsel(kjr As Integer, knr As Integer)
        Try
            delrecs = From bonl In db.BONLs
                      Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.select = True
            For Each deleterec In delrecs
                keybonlvnr = deleterec.BONLVNR
                If updatestock = True Then updateOK = StockUpdate("D", keycnrq, keybonjr, keybonnr, keybonlvnr, "0")

                db.BONLs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Catch
            'MsgBox("Schrappen faktuurlijnen niet gelukt!")
        End Try
    End Sub

    Public Function GetHighBonNR(keyjr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From bon In db.BONs Where bon.BONJR = keyjr Select bon.BONNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function GetHighBonLVNR(keyjr As Integer, keynr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From bonl In db.BONLs Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr Select bonl.BONLVNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function GetHighPerlVNR(keynrq As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From perl In db.PERLs Where perl.PERL_NRQ = keynrq Select perl.PERL_VNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function GetHighBonLDupVNR(keyjr As Integer, keynr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From bonldup In db.BONLdups Where bonldup.BONJR = keyjr AndAlso bonldup.BONNR = keynr Select bonldup.BONLVNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function GetHighBonLVolgorde(keyjr As Integer, keynr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From bonl In db.BONLs Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr Select bonl.Volgorde).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function
End Module
