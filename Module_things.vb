Module Module_things
    Public Sub GETError()
        ' puur informatief
        ' Try
        'db.SubmitChanges(Data.Linq.ConflictMode.ContinueOnConflict)
        'Dim key = keybonjr & "/" & keybonnr.ToString("0000")
        'Archive("BON_U", key, TBmemo.Text)
        'Catch
        'PositionMsgbox.CenterMsgBox(Me)
        'MsgBox("Probleem... Aanpassingen zijn niet opgeslagen!")
        'Catch e As Data.Linq.ChangeConflictException
        'MsgBox(e.Message)
        'Console.WriteLine("Optimistic concurrency error.")
        'Console.WriteLine(e.Message)
        'Console.ReadLine()
        '
        'For Each occ In db.ChangeConflicts
        'Console.Write("Customer ID: ")
        'For Each mcc In occ.MemberConflicts
        '
        'Dim currVal = mcc.CurrentValue
        'Dim origVal = mcc.OriginalValue
        'Dim databaseVal = mcc.DatabaseValue
        'Dim mi = mcc.Member
        'Console.WriteLine("Member: {0}", mi.Name)
        'Console.WriteLine("current value: {0}", currVal)
        'Console.WriteLine("original value: {0}", origVal)
        'Console.WriteLine("database value: {0}", databaseVal)
        'Next
        'Next
    End Sub

    Public Sub TSButtonPermissions(btn As ToolStripButton)
        If btn.Name.Contains("new") Then
            If LoginNEW = False Then
                btn.Enabled = False
            End If
            Exit Sub
        End If
        If btn.Name.Contains("delete") Then
            If LoginDEL = False Then
                btn.Enabled = False
            End If
            Exit Sub
        End If
        If btn.Name.Contains("save") Then
            If LoginUPD = False Then
                btn.Enabled = False
            End If
            Exit Sub
        End If
    End Sub

    Public Sub CMButtonPermissions(btn As ToolStripMenuItem)
        If btn.Name.Contains("nieuw") Then
            If LoginNEW = False Then
                btn.Enabled = False
            End If
            Exit Sub
        End If
        If btn.Name.Contains("verwijder") Then
            If LoginDEL = False Then
                btn.Enabled = False
            End If
            Exit Sub
        End If
    End Sub

    Public Function GetKlantNaam(key As Integer)
        Dim found As String = ""
        klantrecs = From klant In db.KLANTs
                    Where klant.KNRQ = key
                    Let valadres = klant.KStraat & "  -  " & klant.KAdres
                    Let valcontact = klant.KTel & "  -  " & klant.KGSM & "  -  " & klant.KEMail
                    Let kwerf = klant.KWStraat & " " & klant.KWAdres
                    Select kwerf, klant.KNaam, valadres, valcontact

        For Each klantrec In klantrecs
            found = " " & klantrec.knaam & Environment.NewLine & " " & klantrec.valadres
            Dim Klantwerf As String = klantrec.kwerf.Replace(" ", "")
            If Klantwerf <> "" Then found = found & " (Werf: " & Klantwerf & ")"
            found = found & Environment.NewLine & " " & klantrec.valcontact
        Next

        Return found
    End Function

    Public Function GetFirstKlant()
        Dim found As Integer = 0
        klantrecs = From klant In db.KLANTs
                    Select klant.KNRQ, klant.KNaam
                    Take 1

        For Each klantrec In klantrecs
            found = klantrec
        Next
        Return found

    End Function

    Public Function Getvalcode(key As Integer)
        Dim found As String

        found = ""
        codrecs = From cod In db.CODs
                  Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                  Where cod.CNRQ = key
                  Let valcodgp = codgp.OmsGroep
                  Let valcode = cod.Code & " (" & cod.OmsCode & ")"
                  Select cod.Eenhp, cod.Aankp, cod.Stock, cod.Plmagazijn, valcodgp, valcode, cod.gratis, cod.CGNRQ
                  Take 1

        For Each codrec In codrecs
            found = codrec.valcodgp & " (" & codrec.cgnrq & ")"
            found = found & Environment.NewLine & codrec.valcode
            found = found & Environment.NewLine & "Aankoop: " & codrec.Aankp & " Verkoop: " & codrec.Eenhp
            found = found & Environment.NewLine & "Stock: " & codrec.stock & " Magazijn: " & codrec.Plmagazijn
            If codrec.gratis = True Then found = found & Environment.NewLine & "Gratis"
        Next
        Return found
    End Function

    Public Function GetvalcodeSearch(key As Integer)
        Dim found As String

        found = ""
        codrecs = From cod In db.CODs
                  Join codgp In db.CODGPs On cod.CGNRQ Equals codgp.CGNRQ
                  Where cod.CNRQ = key
                  Let valcodgp = codgp.OmsGroep
                  Let valcode = cod.Code & " (" & cod.OmsCode & ")"
                  Select cod.Eenhp, cod.Aankp, cod.Stock, cod.Plmagazijn, valcodgp, valcode, cod.CGNRQ, cod.Minstock, cod.Maxstock, cod.PERNM, cod.OAANMNM
                  Take 1

        For Each codrec In codrecs
            found = codrec.valcodgp & " - " & codrec.valcode
            found = found & Environment.NewLine & "Stock: " & codrec.stock & " Magazijn: " & codrec.Plmagazijn
            found = found & Environment.NewLine & "Stock MIN: " & codrec.minstock & " MAX: " & codrec.Maxstock
            found = found & Environment.NewLine & "Personeel: " & codrec.pernm & " Onderaannemer: " & codrec.oaanmnm
        Next
        Return found
    End Function

    Public Function GetHighFAKTL(keyjr As Integer, keyfnr As Integer, keydc As String)
        Dim found As Integer

        found = 0
        Try
            found = (From faktl In db.FAKTLs Where faktl.FJAAR = keyjr AndAlso faktl.FNR = keyfnr AndAlso faktl.DC = keydc Select faktl.FAKTL).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Sub FillCMBeigenaar(CMB As ComboBox)
        Dim cmbrecs =
            From eigenaar In db.EIGENAARs
            Order By eigenaar.ENaam
            Select eigenaar.ENaam, eigenaar.ENRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "ENaam"
        CMB.ValueMember = "ENRQ"
    End Sub

    Public Sub FillCMBcodgp(CMB As ComboBox)
        Dim cmbrecs =
            From codgp In db.CODGPs
            Order By codgp.OmsGroep
            Select codgp.OmsGroep, codgp.CGNRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "OmsGroep"
        CMB.ValueMember = "CGNRQ"
    End Sub

    Public Sub FillCMBbtw(CMB As ComboBox)
        Dim cmbrecs =
            From btw In db.BTWs
            Order By btw.OmsBTW
            Select btw.OmsBTW, btw.BTW, btw.BNRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "OmsBTW"
        CMB.ValueMember = "BNRQ"
    End Sub

    Public Sub FillCMBaoms(CMB As ComboBox)
        Dim cmbrecs =
            From aoms In db.AOms
            Order By aoms.Oms
            Select aoms.Oms, aoms.ANRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "oms"
        CMB.ValueMember = "ANRQ"
    End Sub

    Public Sub FillCMBper(CMB As ComboBox)
        Dim cmbrecs =
            From per In db.PERs
            Order By per.PERNM
            Select per.PERNM, per.PERNRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "PERNM"
        CMB.ValueMember = "PERNM"
    End Sub

    Public Sub FillCMBdies(CMB As ComboBox)
        Dim cmbrecs =
            From dies In db.DIES
            Order By dies.OmsDIES
            Where dies.actief = True
            Select dies.DIES, dies.OmsDIES

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "OmsDIES"
        CMB.ValueMember = "DIES"
    End Sub

    Public Sub FillCMBoaanmnm(CMB As ComboBox)
        Dim cmbrecs =
            From oaanm In db.OAANMs
            Order By oaanm.OAANMNM
            Select oaanm.OAANMNM, oaanm.OAANMNRQ

        CMB.DataSource = cmbrecs
        CMB.DisplayMember = "OAANMNM"
        CMB.ValueMember = "OAANMNM"
    End Sub

    Public Sub FillCMBeau(CMB As ComboBox)
        CMB.Items.Add("Eender")
        CMB.Items.Add("Aan")
        CMB.Items.Add("Uit")
    End Sub

    Public Sub FillCMBtopten(CMB As ComboBox)
        nofilter = True
        Dim check =
            From bon In db.BONs
            Join klant In db.KLANTs On bon.KNRQ Equals klant.KNRQ
            Let pkey = bon.BONJR & "/" & bon.BONNR
            Let display = bon.BONJR & "/" & bon.BONNR & " " & klant.KNaam & " (" & bon.chdate & ")"
            Select bon.BONJR, bon.BONNR, bon.chdate, bon.usernrq, pkey, display
            Where usernrq = LoginNm
            Order By chdate Descending

        check = check.Take(10)

        CMB.DataSource = check
        CMB.DisplayMember = "display"
        CMB.ValueMember = "pkey"
        nofilter = False
    End Sub

    Public Function Archive(dw As String, prt As String, dinfo As String) As Boolean
        Dim SaveOK As Boolean = True

        Dim newrec As New DEL With {
          .delWO = dw,
          .part = prt,
          .delinfo = dinfo,
          .usernrq = LoginNm,
          .chdate = SysDate & " " & DateTime.Now.ToString("HH:mm:ss"),
          .yearin = DateTime.Now.ToString("yyyy")
          }

        db.DELs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch
            SaveOK = False
            ' Handle exception.  
        End Try

        Return SaveOK
    End Function

End Module
