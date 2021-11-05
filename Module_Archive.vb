Module Module_Archive

    Public Sub ArchiveSelBons(SelBons As List(Of String), FYear As String, What As String)
        Dim file As System.IO.StreamWriter
        Dim sb As New System.Text.StringBuilder
        Dim s As String
        Dim delim As String = ";"

        Dim tofile As String = filenm & "\ArchiefBon2017"
        If (Not System.IO.Directory.Exists(tofile)) Then
            System.IO.Directory.CreateDirectory(tofile)
        End If
        tofile = tofile & "\" & Today.ToString("yyyyMMdd") & "_" & DateTime.Now.ToString("HHmmss") & "_" & What & "_" & FYear & ".csv"

        file = My.Computer.FileSystem.OpenTextFileWriter(tofile, False)

        s = ""
        s = addvalue(s, "BONJR", delim)
        s = addvalue(s, "BONNR", delim)
        s = addvalue(s, "BONLVNR", delim)
        s = addvalue(s, "DAanvang", delim)
        s = addvalue(s, "FNR", delim)
        s = addvalue(s, "CNR", delim)
        s = addvalue(s, "OmsBon", delim)
        s = addvalue(s, "BonType", delim)
        s = addvalue(s, "Aantal", delim)
        s = addvalue(s, "Eenheid", delim)
        s = addvalue(s, "BONEenhp", delim)
        s = addvalue(s, "diesel", delim)
        s = addvalue(s, "BTW", delim)
        s = addvalue(s, "Code", delim)
        s = addvalue(s, "OmsCode", delim)
        s = addvalue(s, "OmsGroep", delim)
        s = addvalue(s, "Werfstraat", delim)
        s = addvalue(s, "Werfadres", delim)
        s = addvalue(s, "Memo", delim)
        s = addvalue(s, "Personeel", delim)
        s = addvalue(s, "Onderaannm", delim)
        s = addvalue(s, "KNaam", delim)
        s = addvalue(s, "KStraat", delim)
        s = addvalue(s, "KAdres", delim)
        s = addvalue(s, "KGSM", "")
        sb.AppendLine(s)

        Dim selbon As String
        For i As Integer = SelBons.Count - 1 To 0 Step -1
            selbon = SelBons(i)
            Dim bonarray() As String = Split(selbon)
            Dim records = (From bonl In db.BONLs
                           Join btw In db.BTWs On bonl.BNRQ Equals btw.BNRQ
                           Join code In db.CODs On bonl.CNRQ Equals code.CNRQ
                           Join codgp In db.CODGPs On code.CGNRQ Equals codgp.CGNRQ
                           Join bon In db.BONs On bonl.BONJR Equals bon.BONJR And bonl.BONNR Equals bon.BONNR
                           Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                           Join aoms In db.AOms On code.ANRQ Equals aoms.ANRQ
                           Where bonl.BONJR = CInt(bonarray(1)) And bonl.BONNR = CInt(bonarray(3))
                           Select
                          bonl.BONJR, bonl.BONNR,
                          bon.DatumAanvang, bon.fnr, bon.cnr, bon.OmsBon, bon.bon_type,
                          bonl.BONLVNR, bonl.Aantal, bonl.BONEenhp, bonl.diesel,
                          aoms.Oms,
                          btw.BTW,
                          code.Code, code.OmsCode,
                          codgp.OmsGroep,
                          bonl.BWStraat, bonl.BWAdres, bonl.memo, bonl.PERNM, bonl.OAANMNM,
                          klant.KNaam, klant.KStraat, klant.KAdres, klant.KGSM).ToList()

            For Each record In records
                s = ""
                s = addvalue(s, record.BONJR, delim)
                s = addvalue(s, record.BONNR, delim)
                s = addvalue(s, record.BONLVNR, delim)
                s = addvalue(s, record.DatumAanvang, delim)
                s = addvalue(s, record.fnr, delim)
                s = addvalue(s, record.cnr, delim)
                s = addvalue(s, record.OmsBon, delim)
                s = addvalue(s, record.bon_type, delim)
                s = addvalue(s, record.Aantal.ToString, delim)
                s = addvalue(s, record.Oms, delim)
                s = addvalue(s, record.BONEenhp.ToString, delim)
                s = addvalue(s, record.diesel.ToString, delim)
                s = addvalue(s, record.BTW.ToString, delim)
                s = addvalue(s, record.Code, delim)
                s = addvalue(s, record.OmsCode, delim)
                s = addvalue(s, record.OmsGroep, delim)
                s = addvalue(s, record.BWStraat, delim)
                s = addvalue(s, record.BWAdres, delim)
                s = addvalue(s, record.memo, delim)
                s = addvalue(s, record.PERNM, delim)
                s = addvalue(s, record.OAANMNM, delim)
                s = addvalue(s, record.KNaam, delim)
                s = addvalue(s, record.KStraat, delim)
                s = addvalue(s, record.KAdres, delim)
                s = addvalue(s, record.KGSM, "")
                sb.AppendLine(s)
            Next
            If records.Count > 0 Then
                SelBons.RemoveAt(i)
            End If
        Next

        'bonnen zonder bonlijnen
        For i As Integer = SelBons.Count - 1 To 0 Step -1
            selbon = SelBons(i)
            Dim bonarray() As String = Split(selbon)
            Dim records = (From bon In db.BONs
                           Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
                           Where bon.BONJR = CInt(bonarray(1)) And bon.BONNR = CInt(bonarray(3))
                           Select
                              bon.BONJR, bon.BONNR,
                              bon.DatumAanvang, bon.fnr, bon.cnr, bon.OmsBon, bon.bon_type,
                              klant.KNaam, klant.KStraat, klant.KAdres, klant.KGSM).ToList()

            For Each record In records
                s = ""
                s = addvalue(s, record.BONJR, delim)
                s = addvalue(s, record.BONNR, delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, record.DatumAanvang, delim)
                s = addvalue(s, record.fnr, delim)
                s = addvalue(s, record.cnr, delim)
                s = addvalue(s, record.OmsBon, delim)
                s = addvalue(s, record.bon_type, delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, "", delim)
                s = addvalue(s, record.KNaam, delim)
                s = addvalue(s, record.KStraat, delim)
                s = addvalue(s, record.KAdres, delim)
                s = addvalue(s, record.KGSM, "")
                sb.AppendLine(s)
            Next
            SelBons.RemoveAt(i)
        Next

        file.Write(sb.ToString())
        file.Close()

    End Sub

    Public Sub ArchiveDelSelBons(SelBons As List(Of String))

        Dim selbon As String
        For i As Integer = SelBons.Count - 1 To 0 Step -1
            selbon = SelBons(i)
            Dim bonarray() As String = Split(selbon)

            delrecs = From bonl In db.BONLs
                      Where bonl.BONJR = CInt(bonarray(1)) AndAlso bonl.BONNR = CInt(bonarray(3))
            For Each deleterec In delrecs
                db.BONLs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Next

        'bonnen zonder bonlijnen
        For i As Integer = SelBons.Count - 1 To 0 Step -1
            selbon = SelBons(i)
            Dim bonarray() As String = Split(selbon)
            Dim records = (From bon In db.BONs
                           Where bon.BONJR = CInt(bonarray(1)) And bon.BONNR = CInt(bonarray(3))).ToList()

            delrecs = From bon In db.BONs
                      Where bon.BONJR = CInt(bonarray(1)) AndAlso bon.BONNR = CInt(bonarray(3))
            For Each deleterec In delrecs
                db.BONs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Next

    End Sub

    Public Function addvalue(baseval As String, valcel As String, delim As String)
        Dim celval As String = ""
        celval = baseval + valcel + delim
        Return celval
    End Function

End Module
