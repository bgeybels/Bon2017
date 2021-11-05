Imports System.Linq.Dynamic
Imports System.Linq
Imports System.ComponentModel

Public Class Archive_BON
    Private ordDGREC As String = "Datum"
    Dim updategrid As Boolean = True
    Dim nofilter As Boolean = True

    Private Sub Archive_BON_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.fltbonjr = Fltbonjr.Value
    End Sub

    Private Sub Archive_BON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If plook = True Then
            FormBorderStyle = FormBorderStyle.FixedDialog
        Else
            plook = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If

        For Each a In GroupFilter.Controls
            If TypeOf a Is ComboBox Then
                If a.name Like "Flt*" Then
                    FillCMBeau(a)
                    a.selectedindex = 0
                End If
            End If
        Next

        ' get values from settings
        'FltCBtbw.SelectedIndex = My.Settings.fltbontbw
        Fltbonjr.Value = My.Settings.fltbonjr
        FltCBtbw.SelectedIndex = 0
        FltCBvs.SelectedIndex = 0
        FltCBgst.SelectedIndex = 0
        FltCBuv.SelectedIndex = 0
        FltCBfnr.SelectedIndex = 0
        FltCBcnr.SelectedIndex = 0

        SetGridRows(DGREC)
    End Sub

    '****DATAGRID stuff
    Private Sub Fill_DGREC()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        records =
            From bon In db.BONs
            Where bon.BONJR = Fltbonjr.Value

        DGFILTER()

        Me.DGREC.DataSource = records

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DGFILTER()
        Dim chval As String
        Select Case FltCBtbw.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("tbw == " & chval)
        Select Case FltCBvs.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("vs == " & chval)
        Select Case FltCBgst.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("gstk == " & chval)
        Select Case FltCBuv.SelectedItem
            Case "Aan"
                chval = "true"
            Case "Uit"
                chval = "false"
            Case Else
                chval = ""
        End Select
        If chval <> "" Then records = records.Where("uv == " & chval)
        Select Case FltCBfnr.SelectedItem
            Case "Aan"
                records = records.Where("fnr <> 0")
            Case "Uit"
                records = records.Where("fnr == 0")
            Case Else
        End Select
        Select Case FltCBcnr.SelectedItem
            Case "Aan"
                records = records.Where("cnr <> 0")
            Case "Uit"
                records = records.Where("cnr == 0")
            Case Else
        End Select

    End Sub

    '****BUTTON-KEY Actions
    Private Sub BTN_FilterReset_Click(sender As Object, e As EventArgs)
        nofilter = True
        For Each a In GroupFilter.Controls
            If TypeOf a Is TextBox Then
                a.text = ""
            End If
            If (TypeOf a Is ComboBox) Then
                If (Mid(a.name, 1, 5) = "FltCB") Then
                    a.selectedindex = 0
                End If
            End If
        Next
        nofilter = False
        Fill_DGREC()
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Me.Close()
    End Sub

    Private Sub TsBtnStartFilter_Click(sender As Object, e As EventArgs) Handles TsBtnStartFilter.Click
        Fill_DGREC()
    End Sub

    Private Sub TSBarchive_Click(sender As Object, e As EventArgs) Handles TSBarchive.Click
        ' Overloop alle bonjr/bonnr in DGREC
        ' vul een nieuwe select per nrq met alle info (nrq+verwoording) bon+bonl op elke lijn
        ' export deze naar csv
        Dim result As Integer = MessageBox.Show(text:="Alle geselecteerde bonnen/bonlijnen archiveren? Momenteel enkel exporteren, geen delete!!!", caption:="Archiveer bonlijnen", buttons:=MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim selbons As New List(Of String)()
        For Each row As DataGridViewRow In Me.DGREC.Rows
            keybonjr = row.Cells("BONJR").Value
            keybonnr = row.Cells("BONNR").Value
            selbons.Add(item:=Str(keybonjr) + " " + Str(keybonnr))
        Next
        ArchiveSelBons(selbons, Fltbonjr.Value, "ARCH")

        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Archivering is klaar.")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles TSBArchiveDelete.Click
        Dim result As Integer = MessageBox.Show(text:="Alle geselecteerde bonnen/bonlijnen archiveren? DELETE!!!!", caption:="Archiveer bonlijnen", buttons:=MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim selbons As New List(Of String)()
        For Each row As DataGridViewRow In Me.DGREC.Rows
            keybonjr = row.Cells("BONJR").Value
            keybonnr = row.Cells("BONNR").Value
            selbons.Add(item:=Str(keybonjr) + " " + Str(keybonnr))
        Next
        ArchiveSelBons(selbons, Fltbonjr.Value, "ARCH_DEL")
        For Each row As DataGridViewRow In Me.DGREC.Rows
            keybonjr = row.Cells("BONJR").Value
            keybonnr = row.Cells("BONNR").Value
            selbons.Add(item:=Str(keybonjr) + " " + Str(keybonnr))
        Next
        ArchiveDelSelBons(selbons)

        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Archivering en Verwijdering klaar.")
    End Sub

    Private Sub backup()
        Dim rtocsv = From bonl In db.BONLs
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
    End Sub

End Class