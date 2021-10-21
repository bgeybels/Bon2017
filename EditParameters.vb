Public Class EditParameters
    Private Sub EditParameters_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub EditParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bepaalde onderdelen toegankelijk maken voor iedereen???")
        SetColors()
    End Sub

    Private Sub setcolor(TB As TextBox, valcolor As String)
        Dim TBcolor As Color = ColorTranslator.FromHtml(valcolor)
        TB.BackColor = TBcolor
    End Sub

    Private Sub SetColors()
        setcolor(TBGRIDrowseven, My.Settings.GRIDrowseven)
        TBGRIDrowseven.Text = My.Settings.GRIDrowseven
        setcolor(TBGRIDrowsodd, My.Settings.GRIDrowsodd)
        TBGRIDrowsodd.Text = My.Settings.GRIDrowsodd

        setcolor(TBGRIDforecoloreven, My.Settings.GRIDforecoloreven)
        TBGRIDforecoloreven.Text = My.Settings.GRIDforecoloreven
        setcolor(TBGRIDforecolorodd, My.Settings.GRIDforecolorodd)
        TBGRIDforecolorodd.Text = My.Settings.GRIDforecolorodd

        setcolor(TBDISPtextboxerror, My.Settings.DISPtextboxerror)
        TBDISPtextboxerror.Text = My.Settings.DISPtextboxerror
        setcolor(TBDISPtextboxbackcolor, My.Settings.DISPtextboxbackcolor)
        TBDISPtextboxbackcolor.Text = My.Settings.DISPtextboxbackcolor

        setcolor(TBGRIDcellnotused, My.Settings.GRIDcellnotused)
        TBGRIDcellnotused.Text = My.Settings.GRIDcellnotused

        TBSTOCKstandaardtrans.Text = My.Settings.STOCKstandaardtrans
        CBSTOCKupdateclosed.Checked = My.Settings.STOCKupdateclosed

        TBfirstfnr.Text = My.Settings.FirstFNR
    End Sub

    Private Sub TSBsave_Click(sender As Object, e As EventArgs) Handles TSBsave.Click
        My.Settings.GRIDrowseven = TBGRIDrowseven.Text
        My.Settings.GRIDrowsodd = TBGRIDrowsodd.Text
        My.Settings.GRIDforecoloreven = TBGRIDforecoloreven.Text
        My.Settings.GRIDforecolorodd = TBGRIDforecolorodd.Text
        My.Settings.DISPtextboxerror = TBDISPtextboxerror.Text
        My.Settings.DISPtextboxbackcolor = TBDISPtextboxbackcolor.Text
        My.Settings.GRIDcellnotused = TBGRIDcellnotused.Text

        My.Settings.STOCKstandaardtrans = TBSTOCKstandaardtrans.Text
        My.Settings.STOCKupdateclosed = CBSTOCKupdateclosed.CheckState

        My.Settings.FirstFNR = TBfirstfnr.Text
    End Sub

    Private Sub TBreset_Click(sender As Object, e As EventArgs) Handles TBreset.Click
        setcolor(TBGRIDrowseven, "#ffffb3")
        TBGRIDrowseven.Text = "#ffffb3"
        setcolor(TBGRIDrowsodd, "#ffff66")
        TBGRIDrowsodd.Text = "#ffff66"

        setcolor(TBGRIDforecoloreven, "#1e47fc")
        TBGRIDforecoloreven.Text = "#1e47fc"
        setcolor(TBGRIDforecolorodd, "#000000")
        TBGRIDforecolorodd.Text = "#000000"

        setcolor(TBDISPtextboxerror, "#ff4500")
        TBDISPtextboxerror.Text = "#ff4500"
        setcolor(TBDISPtextboxbackcolor, "#ffffff")
        TBDISPtextboxbackcolor.Text = "#ffffff"

        setcolor(TBGRIDcellnotused, "#f49d5a")
        TBGRIDcellnotused.Text = "#f49d5a"

        'TBGRIDrowseven.Text = "#ffffb3"
        'TBGRIDrowsodd.Text = "#ffff66"
        'TBGRIDforecoloreven.Text = "#ffff66"
        'TBGRIDforecolorodd.Text = "#ffff66"
    End Sub

    Private Sub TSBexit_Click(sender As Object, e As EventArgs) Handles TSBexit.Click
        Close()
    End Sub
End Class