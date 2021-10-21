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
        For Each frombon In frombons
            Dim newrec As New BON With {
            .BONJR = ToJaar,
            .BONNR = newbonnr,
            .KNRQ = frombon.KNRQ,
            .ENRQ = frombon.ENRQ,
            .DatumAanvang = SysDate,
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
            .bon_type = frombon.bon_type,
            .usernrq = LoginNm,
            .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
            }
            db.BONs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
            Catch
                MsgBox("Nieuw record niet gelukt.  Probeer opnieuw.")
                Return CoMoOK
                ' Handle exception.  
            End Try
            Dim key = ToJaar & "/" & newbonnr.ToString("0000")
            Archive("BON_N", key, frombon.OmsBon)
        Next

        'BONLIJNEN dupliceren
        CopyBONL(keybonjr, keybonnr, ToJaar, newbonnr)

        keybonjr = ToJaar
        keybonnr = newbonnr
        CoMoOK = True
        Return CoMoOK
    End Function

    Public Sub CopyBONL(kjr As Integer, knr As Integer, tokjr As Integer, toknr As Integer)
        Dim frombonls = From bonl In db.BONLs
                        Where bonl.BONJR = kjr AndAlso bonl.BONNR = knr
        For Each frombonl In frombonls
            Dim newbonlvnr = GetHighBonLVNR(tokjr, toknr)
            Dim newrec As New BONL With {
                    .BONJR = tokjr,
                    .BONNR = toknr,
                    .BONLVNR = newbonlvnr,
                    .Volgorde = frombonl.Volgorde,
                    .Datum = frombonl.Datum,
                    .BWStraat = frombonl.BWStraat,
                    .BWAdres = frombonl.BWAdres,
                    .Aantal = frombonl.Aantal,
                    .BONEenhp = frombonl.BONEenhp,
                    .BONEenhpbu = frombonl.BONEenhpbu,
                    .select = 0,
                    .levering = 0,
                    .diesel = frombonl.diesel,
                    .omstijd = frombonl.omstijd,
                    .EXTNR = frombonl.EXTNR,
                    .DNRQ = 0,
                    .ANRQ = frombonl.ANRQ,
                    .memo = frombonl.memo,
                    .PERNM = frombonl.PERNM,
                    .OAANMNM = frombonl.OAANMNM,
                    .BNRQ = frombonl.BNRQ,
                    .CNRQ = frombonl.CNRQ,
                    .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                    .usernrq = LoginNm,
                    .usercre = LoginNm,
                    .datecre = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
                }
            db.BONLs.InsertOnSubmit(newrec)
            Try
                db.SubmitChanges()
            Catch
                ' Handle exception.  
            End Try
        Next
    End Sub

    Public Function GroupBONL()
        'Groepeer de bonlijnen: keybonjr, keybonnr, keybonlvnr
        Dim GroupingOK As Boolean = True
        MsgBox("ToDo: Groepeer de bonlijnen.")
        'Groepeer op CNRQ, BNRQ, diesel, BONEenhp en aantal=aantal+
        Return GroupingOK
    End Function

    Public Function GetBonlFigures(keyjr As Integer, keynr As Integer)
        Dim found As String = ""
        searchrecs = From bonl In db.BONLs
                     Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                     Let tbedr = (bonl.Aantal * bonl.BONEenhp)
                     Where bonl.BONJR = keyjr AndAlso bonl.BONNR = keynr
                     Select tbedr, bonl.diesel, bonl.BNRQ

        Dim totrm As Decimal = 0
        Dim totnac As Decimal = 0
        Dim tot As Decimal = 0
        Dim calcx As Decimal = 0
        Dim telbonl As Integer = 0
        For Each searchrec In searchrecs
            telbonl = telbonl + 1
            calcx = searchrec.tbedr
            If searchrec.diesel <> 0 Then
                calcx = calcx + ((calcx * searchrec.diesel) / 100)
            End If
            Select Case searchrec.BNRQ
                Case 11
                    totrm = totrm + calcx
                Case 1
                    totnac = totnac + calcx
                Case Else
                    tot = tot + calcx
            End Select
        Next
        found = " Aantal bonlijnen: " & telbonl
        found = found & Environment.NewLine & " Recuperatie : " & totrm.ToString("0.00")
        found = found & Environment.NewLine & " Nacalculatie: " & totnac.ToString("0.00")
        found = found & Environment.NewLine & " Facturatie  : " & tot.ToString("0.00")

        Return found
    End Function

    Public Sub DelBONLsel(kjr As Integer, knr As Integer)
        Try
            Dim deleterec = (From bonl In db.BONLs
                             Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso bonl.select = True).ToList()(0)
            db.BONLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
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


End Module
