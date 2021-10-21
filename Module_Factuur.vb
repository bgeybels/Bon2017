Module Module_Factuur
    'Private Sub ToolStripButton2xx_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    '    Dim totals = From bonl In db.BONLs
    '                 Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
    '                 Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso btw.nieuwbon = True
    '                 Group By bonl.BONNR
    '                    Into tbedrag = Sum(((((bonl.Aantal * bonl.BONEenhp) * bonl.diesel) / 100) + (bonl.Aantal * bonl.BONEenhp)) + ((((((bonl.Aantal * bonl.BONEenhp) * bonl.Aantal * bonl.BONEenhp) / 100) + (bonl.Aantal * bonl.BONEenhp)) * btw.BTW / 100))),
    '                     tbtw = Sum((((((bonl.Aantal * bonl.BONEenhp) * bonl.diesel) / 100) + (bonl.Aantal * bonl.BONEenhp)) * btw.BTW) / 100),
    '                     teenhp = Sum((((bonl.Aantal * bonl.BONEenhp) * bonl.diesel) / 100) + (bonl.Aantal * bonl.BONEenhp))
    '                 Select tbedrag, tbtw, teenhp

    '    For Each total In totals
    '        MsgBox("TBEDRAG: " & Format(total.tbedrag, "c") & " - TBTW: " & Format(total.tbtw, "c") & " - TEENHP: " & Format(total.teenhp, "c"))
    '    Next

    'End Sub

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

    Public Sub Fact(RecExists As Boolean, kjr As Integer, knr As Integer, factnr As Integer, dc As String)
        If RecExists = False Then
            NewFAKT(kjr, knr, factnr, dc)
        End If

        ' Totaliseer de bonlijnen: voor new fakt= new bedrag voor bestaande fakt= update
        Dim totals = From bonl In db.BONLs
                     Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                     Where bonl.BONJR = keybonjr AndAlso bonl.BONNR = keybonnr AndAlso btw.nieuwbon = True
                     Let ehp = bonl.Aantal * bonl.BONEenhp
                     Let diesel = (ehp * bonl.diesel) / 100
                     Let tbtw = ((ehp + diesel) * btw.BTW) / 100
                     Select ehp, diesel, tbtw, btw.BNRQ
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
            .bon_type = bond.bon.bon_type
            .fakt_ncalc = 0
            .usernrq = LoginNm
            .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
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
                .DATUM = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
                .BWSTRAAT = bonldrec.bonl.BWStraat,
                .BWADRES = bonldrec.bonl.BWAdres,
                .AANTAL = bonldrec.bonl.Aantal,
                .EENHP = bonldrec.bonl.BONEenhp,
                .BTW = bonldrec.btw.BTW,
                .AOMS = bonldrec.aoms.Oms,
                .CODE = bonldrec.code.Code,
                .OMSCODE = bonldrec.code.OmsCode,
                .GROEP = bonldrec.codgp.OmsGroep,
                .diesel = bonldrec.bonl.diesel
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
        .Datin = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .Werf = "",
        .tbedrag = 0,
        .ENRQ = 0,
        .KSTRAAT = "",
        .KADRES = "",
        .WJAAR = kjr,
        .dvan = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .dtot = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
        .teenhp = 0,
        .tbtw = 0,
        .bon_type = "O",
        .fakt_ncalc = 0,
        .usernrq = LoginNm,
        .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss")
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
        .DATUM = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
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

    Private Sub DelFAKTL(kjr As Integer, knr As Integer, dc As String)
        Try
            Dim deleterec = (From faktl In db.FAKTLs
                             Where faktl.FJAAR = kjr AndAlso faktl.FNR = knr AndAlso faktl.DC = dc).ToList()(0)
            db.FAKTLs.DeleteOnSubmit(deleterec)
            db.SubmitChanges()
        Catch
            'MsgBox("Schrappen faktuurlijnen niet gelukt!")
        End Try
    End Sub

    Public Function GetFaktlFigures(keyjr As Integer, keynr As Integer)
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
End Module
