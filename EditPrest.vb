Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class EditPrest

    Private Sub EditPrest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSButtonPermissions(TSBsave)

        SetGrids()
        Me.Text = "Prestaties: Bewerken (key=" & keyprid & ")"
        If IsNewRecord = True Then
            Me.Text = "Prestaties: Nieuw"
        End If
        FillCMBtype(CMBtype)
        FillCMBsector(CMBsector)

        Fill_DG()
        Velden_vullen()

        DTPprdate.Focus()

    End Sub
    Private Sub EditPrest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If IsNewRecord = False Then
            Dim unlock = unlockrec("PREST", keyprid)
        End If
        IsNewRecord = False
    End Sub

    Private Sub SetGrids()
        SetPopupForm(Me)
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
    End Sub

    Private Sub Fill_DG()
        Try
            records = From prest In db.PRESTs
                      Where prest.PRID = keyprid
                      Take 1

        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Ophalen niet gelukt! --> " & ex.Message)

        End Try

    End Sub

    '****FIELDActions
    Private Function Savedata() As Boolean
        If Check_Data() = False Then
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Inhoud veld(en) niet juist!")
            Return False
        End If

        If IsNewRecord = True Then
            SaveNEW()
            Return True
            Exit Function
        End If

        Dim updaterec = (From prest In db.PRESTs
                         Where prest.PRID = keyprid).ToList()(0)

        updaterec.PRDATE = DTPprdate.Value
        updaterec.PRDATEU = DTPprdateu.Value
        updaterec.PRYEAR = DTPprdate.Value.Year
        updaterec.PRAANTAL = TBpraantal.Text
        updaterec.PRPTTOT = CBpttot.CheckState
        updaterec.PRPTID = CMBtype.SelectedValue
        updaterec.PRPSID = CMBsector.SelectedValue
        updaterec.PRPERNRQ = keypernrq
        updaterec.CHDATE = ChDate & " " & DateTime.Now.ToString("HH:mm:ss")
        updaterec.USERNRQ = LoginNm
        Try
            db.SubmitChanges()
            perrecs = From per In db.PERs
                      Where per.PERNRQ = keypernrq
                      Select per.PERNRQ, per.PERNM
            Dim keynaam As String = ""
            For Each perrec In perrecs
                keynaam = perrec.pernm
            Next
            Dim key = keyprid.ToString("0000")
            Archive("PREST_U", key, keynaam)
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Aanpassingen zijn niet opgeslagen! --> " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub SaveNEW()
        Dim newrec As New PREST With {
        .PRPERNRQ = keypernrq,
        .PRPSID = CMBsector.SelectedValue,
        .PRPTID = CMBtype.SelectedValue,
        .PRDATE = DTPprdate.Value,
        .PRDATEU = DTPprdateu.Value,
        .PRYEAR = DTPprdate.Value.Year,
        .PRAANTAL = TBpraantal.Text,
        .PRPTTOT = True,
        .USERNRQ = LoginNm,
        .CHDATE = ChDate
        }

        db.PRESTs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            PositionMsgbox.CenterMsgBox(Me)
            MsgBox("Probleem... Nieuw record niet gelukt! --> " & ex.Message)
            Exit Sub
            ' Handle exception.  
        End Try
        keyprid = newrec.PRID
        perrecs = From per In db.PERs
                  Where per.PERNRQ = keypernrq
                  Select per.PERNRQ, per.PERNM
        Dim keynaam As String = ""
        For Each perrec In perrecs
            keynaam = perrec.pernm
        Next
        Dim key = keyprid.ToString("0000")
        Archive("PREST_N", key, keynaam)
    End Sub

    Private Function Check_Data() As Boolean
        Dim AllOK As Boolean = True

        Dim TBNum() As TextBox = New TextBox() {TBpraantal}
        For Each TB As TextBox In TBNum
            TB.BackColor = boxcolor
            If Not IsNumeric(TB.Text) And Not TB.Text = "" Then
                TB.BackColor = boxcolorerror
                AllOK = False
            End If
        Next

        Return AllOK
    End Function

    Private Sub Velden_vullen()
        'LBLboninfo.Text = keybonjr & "/" & keybonnr
        'If IsNewRecord = True Then LBLboninfo.Text = keybonjr & "/" & "..."
        'CMBtype.SelectedItem = "Onbekend"
        Try
            For Each rec In records
                If IsNewRecord = True Then
                    DTPprdate.Value = SysDate
                    DTPprdateu.Value = SysDate
                    TBpraantal.Text = 0
                Else
                    DTPprdate.Value = rec.prdate
                    DTPprdateu.Value = rec.prdateu
                    TBpraantal.Text = rec.praantal
                    CBpttot.Checked = rec.prpttot
                End If

                CMBsector.SelectedValue = rec.prpsid
                CMBtype.SelectedValue = rec.prptid
            Next
        Catch ex As Exception
            DTPprdate.Value = SysDate
            DTPprdateu.Value = SysDate
            TBpraantal.Text = 0
        End Try

    End Sub

    '****BUTTON-KEY Actions
    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        If Savedata() = True Then Close()
    End Sub

    Private Sub CMBtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBtype.SelectedIndexChanged

        On Error GoTo theend

        Dim ptkey As Integer
        ptkey = CMBtype.SelectedValue

        Getrecs(ptkey)

        'MsgBox(ptkey.ToString())

theend:
    End Sub
    Private Sub Getrecs(selval As Integer)
        ptyperecs = From ptype In db.PTYPEs
                    Where ptype.PTID = selval
                    Select ptype.PTID, ptype.PTTOT

        For Each ptyperec In ptyperecs
            CBpttot.Checked = ptyperec.PTTOT
        Next
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        'Dim CalcVal As Long
        ' dtpprdate.value - dtpprdateu.value
        'CalcVal = DTPprdate.Value - DTPprdateu.Value
        'CalcVal = DateDiff(DateInterval.Day, DTPprdate.Value, DTPprdateu.Value) + 1

        Dim HolidayList As New List(Of Date)
        If CBexfeestdagen.Checked = True Then
            Dim fromy As Integer = DTPprdate.Value.Year
            Dim tilly As Integer = DTPprdateu.Value.Year
            records = From feest In db.FEESTs
                      Where feest.FYYYY = fromy Or feest.FID = tilly
                      Select feest.FYYYY, feest.FMM, feest.FDD
            For Each record In records
                HolidayList.Add(DateSerial(CInt(record.FYYYY), CInt(record.FMM), CInt(record.FDD)))
            Next
        End If

        Dim CalcVal As Int32 = GetBusinessDays(CBexweekend.CheckState, DTPprdate.Value, DTPprdateu.Value, HolidayList)

        TBpraantal.Text = CalcVal.ToString()
    End Sub
    Public Shared Function GetBusinessDays(exweekend As Boolean, startDay As DateTime, endDay As DateTime, bankHoliday As List(Of Date)) As Integer
        If endDay < startDay Then Return 0

        Dim today = Date.Today
        Dim nonWorkingDays = bankHoliday
        Dim weekend = {DayOfWeek.Saturday, DayOfWeek.Sunday}
        If exweekend = False Then weekend = {}
        Dim businessDays =
            From d In Enumerable.Range(0, (endDay - startDay).Days + 1)
            Select day = startDay.AddDays(d)
            Where Not weekend.Contains(day.DayOfWeek) AndAlso Not nonWorkingDays.Contains(day)
        Return businessDays.Count()
    End Function

End Class
