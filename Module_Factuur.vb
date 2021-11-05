Module Module_Factuur

    Public Function DBFact(kbonjr As Integer, kbonnr As Integer, dc As String)
        Dim FactNR As Integer = 0
        Dim RecExists As Boolean = False

        'Check of er al een FAKT-rec bestaat
        factrecs = From fact In db.FAKTs
                   Where fact.JAAR = kbonjr And fact.NR = kbonnr And fact.DC = dc
                   Select fact.JAAR, fact.NR, fact.FNR
        For Each factrec In factrecs
            FactNR = factrec.FNR
            RecExists = True
        Next
        'Als niet bestaat neem je binnen dat jaar de laatste + 1
        If FactNR < 1 Then
            factrecs = From fact In db.FAKTs
                       Where fact.JAAR = kbonjr And fact.DC = dc
                       Order By fact.FNR Descending
                       Select fact.JAAR, fact.NR, fact.FNR
                       Take (1)
            For Each factrec In factrecs
                FactNR = factrec.FNR + 1
            Next
        End If
        'Als nog geen bestaat binnen dat jaar neem je startwaarde uit FirstNR
        If FactNR < 1 Then
            FactNR = My.Settings.FirstFNR
        End If

        Fact(RecExists, kbonjr, kbonnr, FactNR, dc)
        FactL(kbonjr, kbonnr, FactNR, dc)

        Return FactNR
    End Function

    Public Sub getDBFact(kbonjr As Integer, kbonnr As Integer, dc As String)
        Dim FactNR As Integer = 0
        Dim RecExists As Boolean = False
        Dim curnr As Integer = 0
        Dim message As String = ""
        If kbonnr < 1 Then Exit Sub

        Dim bond = (From bon In db.BONs
                    Where bon.BONJR = kbonjr AndAlso bon.BONNR = kbonnr).First()
        Select Case dc
            Case "D"
                curnr = bond.fnr
                message = "Factuurnummer (Debet) "
            Case "C"
                curnr = bond.cnr
                message = "Factuurnummer (Credit) "
        End Select
        ' fnr/cnr staat er al in
        If curnr > 0 Then Exit Sub

        'Check of er al een FAKT-rec bestaat
        factrecs = From fact In db.FAKTs
                   Where fact.JAAR = kbonjr And fact.NR = kbonnr And fact.DC = dc
                   Select fact.JAAR, fact.NR, fact.FNR
        For Each factrec In factrecs
            FactNR = factrec.FNR
            RecExists = True
        Next
        If FactNR < 1 Then Exit Sub

        'aan beide voorwaarden voldaan: (in bon=0) (er bestaat een fnr)... nu de vraag
        If MsgBox(message & FactNR & " overnemen?", MsgBoxStyle.YesNoCancel, "Terugzetten factuurnummer.") = MsgBoxResult.No Then
            Exit Sub
        End If


        ' update fnr/cnr fok/cok
        Dim updaterec = (From bon In db.BONs
                         Where bon.BONJR = kbonjr And bon.BONNR = kbonnr).ToList()(0)

        Select Case dc
            Case "D"
                updaterec.fnr = FactNR
                updaterec.fok = True
            Case "C"
                updaterec.cnr = FactNR
                updaterec.cok = True
        End Select
        Try
            db.SubmitChanges()
        Catch ex As Exception
            Exit Sub
        End Try
        ' update de factuur/factuurlijnen
        Fact(RecExists, kbonjr, kbonnr, FactNR, dc)
        FactL(kbonjr, kbonnr, FactNR, dc)

        ''   this.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ''  Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub Fact(RecExists As Boolean, kjr As Integer, knr As Integer, factnr As Integer, dc As String)
        If RecExists = False Then
            NewFAKT(kjr, knr, factnr, dc)
        End If

        ' Totaliseer de bonlijnen: voor new fakt= new bedrag voor bestaande fakt= update
        Dim totals = From bonl In db.BONLs
                     Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                     Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso btw.nieuwbon = False
                     Let ehp = bonl.Aantal * bonl.BONEenhp
                     Let tbtw = (ehp * btw.BTW) / 100
                     Select ehp, tbtw, btw.BNRQ
        Dim totehp As Decimal = 0
        Dim totbtw As Decimal = 0
        Dim tottbt As Decimal = 0
        Dim totnac As Decimal = 0
        For Each total In totals
            If total.BNRQ = 1 Then
                totnac = totnac + total.ehp
            End If
            totehp = totehp + total.ehp
            totbtw = totbtw + total.tbtw
        Next
        tottbt = totehp + totbtw

        'informatie uit BON
        Dim bond = (From bon In db.BONs
                    Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                    Where bon.BONJR = kjr AndAlso bon.BONNR = knr).First()

        Dim updaterec = (From fakt In db.FAKTs
                         Where fakt.JAAR = kjr And fakt.NR = knr And fakt.DC = dc).ToList()(0)

        With updaterec
            .KNaam = bond.klant.KNaam
            .Datin = bond.bon.DatumAanvang
            .Werf = bond.bon.OmsBon
            .tbedrag = Format(tottbt, "#.00")
            .ENRQ = bond.bon.ENRQ
            .KSTRAAT = bond.klant.KStraat
            .KADRES = bond.klant.KAdres
            .WJAAR = kjr
            .dvan = bond.bon.dvan
            .dtot = bond.bon.dtot
            .teenhp = Format(totehp, "#.00")
            .tbtw = Format(totbtw, "#.00")
            .fakt_bon_type = bond.bon.bon_type
            .fakt_ncalc = 0
            .usernrq = LoginNm
            .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        End With

        Try
            db.SubmitChanges()
        Catch
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        End Try
    End Sub

    Public Sub FactL(kjr As Integer, knr As Integer, factnr As Integer, dc As String)
        DelFAKTL(kjr, knr, dc)
        'informatie uit BONL
        Dim bonld = From bonl In db.BONLs
                    Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                    Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
                    Join aoms In db.AOms On code.ANRQ Equals aoms.ANRQ
                    Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                    Where bonl.BONJR = kjr And bonl.BONNR = knr

        For Each bonldrec In bonld
            Dim newfaktl = GetHighFAKTL(kjr, knr, dc)

            Dim newrec As New FAKTL With {
                .FJAAR = kjr,
                .FNR = knr,
                .DC = dc,
                .FAKTL = newfaktl,
                .DATUM = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                .BWSTRAAT = bonldrec.bonl.BWStraat,
                .BWADRES = bonldrec.bonl.BWAdres,
                .AANTAL = bonldrec.bonl.Aantal,
                .EENHP = bonldrec.bonl.BONEenhp,
                .BTW = bonldrec.btw.BTW,
                .AOMS = bonldrec.aoms.Oms,
                .CODE = bonldrec.code.Code,
                .OMSCODE = bonldrec.code.OmsCode,
                .GROEP = bonldrec.codgp.OmsGroep,
                .diesel = 0
            }
            db.FAKTLs.InsertOnSubmit(newrec)

            Try
                db.SubmitChanges()
            Catch
                MsgBox("Nieuwe Faktuurlijn (FAKTL) niet gelukt.  Probeer opnieuw.")
                Exit Sub
                ' Handle exception.  
            End Try
        Next

    End Sub

    Private Sub NewFAKT(kjr As Integer, knr As Integer, factnr As Integer, dc As String)
        Dim newrec As New FAKT With {
        .JAAR = kjr,
        .NR = knr,
        .DC = dc,
        .FNR = factnr,
        .KNaam = "",
        .Datin = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .Werf = "",
        .tbedrag = 0,
        .ENRQ = 0,
        .KSTRAAT = "",
        .KADRES = "",
        .WJAAR = kjr,
        .dvan = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .dtot = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .teenhp = 0,
        .tbtw = 0,
        .fakt_bon_type = "O",
        .fakt_ncalc = 0,
        .usernrq = LoginNm,
        .chdate = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        }

        db.FAKTs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            MsgBox("Nieuwe Faktuur (FAKT) niet gelukt.  Probeer opnieuw.")
            Exit Sub
            ' Handle exception.  
        End Try
    End Sub

    Private Sub NewFAKTL(kjr As Integer, knr As Integer, dc As String)
        Dim newfaktl = GetHighFAKTL(kjr, knr, dc)

        Dim newrec As New FAKTL With {
        .FJAAR = kjr,
        .FNR = knr,
        .DC = dc,
        .FAKTL = newfaktl,
        .DATUM = ChDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .BWSTRAAT = "",
        .BWADRES = "",
        .AANTAL = 0,
        .EENHP = 0,
        .BTW = 0,
        .AOMS = 0,
        .CODE = "",
        .OMSCODE = "",
        .GROEP = "",
        .diesel = 0
        }

        db.FAKTLs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            MsgBox("Nieuwe Faktuurlijn (FAKTL) niet gelukt.  Probeer opnieuw.")
            Exit Sub
            ' Handle exception.  
        End Try
    End Sub

    Public Sub DelFAKTL(kjr As Integer, knr As Integer, dc As String)

        Try
            delrecs = From faktl In db.FAKTLs
                      Where faktl.FJAAR = kjr AndAlso faktl.FNR = knr AndAlso faktl.DC = dc
            For Each todelrec In delrecs
                db.FAKTLs.DeleteOnSubmit(todelrec)
                db.SubmitChanges()
            Next
        Catch
            'MsgBox("Schrappen faktuurlijnen niet gelukt!")
        End Try

    End Sub

    Public Function GetFaktlFigures(keyjr As Integer, keynr As Integer)
        Dim found As String = ""
        searchrecs = From faktl In db.FAKTLs
                     Let tbedr = (faktl.AANTAL * faktl.EENHP)
                     Where faktl.FJAAR = keyfaktjr AndAlso faktl.FNR = keyfaktnr AndAlso faktl.DC = keyfaktdc
                     Select tbedr, faktl.BTW

        Dim totincl As Decimal = 0
        Dim totbtw As Decimal = 0
        Dim totexcl As Decimal = 0
        Dim calcx As Decimal = 0
        Dim calcy As Decimal = 0
        Dim telfaktl As Integer = 0
        For Each searchrec In searchrecs
            telfaktl = telfaktl + 1
            calcx = searchrec.tbedr
            totexcl = totexcl + calcx

            'btw op calcx
            calcy = 0
            If searchrec.btw <> 0 Then
                calcy = (calcx * searchrec.btw) / 100
            End If
            totincl = totincl + calcx + calcy
            totbtw = totbtw + calcy
        Next
        found = " Aantal faktuurlijnen: " & telfaktl
        found = found & Environment.NewLine & " Totaal Exclusief : " & totexcl.ToString("0.00")
        found = found & Environment.NewLine & "        BTW       : " & totbtw.ToString("0.00")
        found = found & Environment.NewLine & "        Inclusief : " & totincl.ToString("0.00")

        Return found
    End Function

     Public Function GetSELFaktlFigures(faktldata As DataGridView)
        Dim found As String = ""

        Dim ljr As Integer
        Dim lnr As Integer
        Dim ldc As String

        Dim totincl As Decimal = 0
        Dim totbtw As Decimal = 0
        Dim totexcl As Decimal = 0
        Dim calcx As Decimal = 0
        Dim calcy As Decimal = 0
        Dim telfaktl As Integer = 0
        Dim telfakt As Integer = 0

        For Each row As DataGridViewRow In faktldata.Rows
            ljr = row.Cells("JR").Value
            lnr = row.Cells("NR").Value
            ldc = row.Cells("DC").Value

            searchrecs = From faktl In db.FAKTLs
                         Let tbedr = (faktl.AANTAL * faktl.EENHP)
                         Where faktl.FJAAR = ljr AndAlso faktl.FNR = lnr AndAlso faktl.DC = ldc
                         Select tbedr, faktl.BTW

            telfakt = telfakt + 1
            For Each searchrec In searchrecs
                telfaktl = telfaktl + 1
                calcx = searchrec.tbedr
                totexcl = totexcl + calcx

                'btw op calcx
                calcy = 0
                If searchrec.btw <> 0 Then
                    calcy = (calcx * searchrec.btw) / 100
                End If
                totincl = totincl + calcx + calcy
                totbtw = totbtw + calcy
            Next
        Next

        found = "Totaal fakturen     : " & telfakt
        found = found & Environment.NewLine & "Totaal faktuurlijnen: " & telfaktl
        found = found & Environment.NewLine & "Totaal Exclusief : " & totexcl.ToString("0.00")
        found = found & Environment.NewLine & "       BTW       : " & totbtw.ToString("0.00")
        found = found & Environment.NewLine & "       Inclusief : " & totincl.ToString("0.00")

        Return found
    End Function


End Module
