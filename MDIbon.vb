Imports System.Windows.Forms

Public Class MDIbon

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub MDIbon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB.Close()
        Text = "Bonbeheer, welkom " & LoginNm & " [" & LoginID & "] (" & SysDate & ")  -  DataBase " & sysDBUsed
        DTPsys.Value = SysDate

        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
        Me.MaximizeBox = True
        Me.MinimizeBox = True

        ToolsToolStripMenuItem.Enabled = False
        StockPersToolStripMenuItem.Visible = False
        SYSTEMToolStripMenuItem.Visible = False
        If LoginSysAdmin = True Then
            ToolsToolStripMenuItem.Enabled = True
        End If
        If LoginPersAdmin = True Then
            StockPersToolStripMenuItem.Visible = True
        End If
        If LoginNm.Trim() = "SYSTEM" Or LoginNm = "bge" Then
            SYSTEMToolStripMenuItem.Visible = True
        End If

        ' Toon stockscherm met de stock < minstock
        'stocklogon = False
        'If LoginStockAdmin = True Then
        'Dim stockzero = Aggregate code In db.CODs
        'Where code.Stock < code.Minstock
        'Into Count()
        'If stockzero > 0 Then
        'stocklogon = True
        'Dim frmC As New SearchStock
        'NewForm(frmC)
        'End If
        'End If

        Dim frmC As New SearchBON_NW
        NewForm(frmC)

    End Sub

    Private Sub MDIbon_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub CloseAllForms()
        'close all MDIforms before opening a new one
        For i = Me.MdiChildren.Length - 1 To 0 Step -1
            Me.MdiChildren(i).Close()
        Next
    End Sub

    Private Sub KlantenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KlantenToolStripMenuItem.Click
        Dim frmC As New SearchKlant
        NewForm(frmC)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub CodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodesToolStripMenuItem.Click
        Dim frmC As New SearchCode
        NewForm(frmC)
    End Sub

    Private Sub BTWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTWToolStripMenuItem.Click
        Dim frmC As New SearchBTW
        NewForm(frmC)
    End Sub

    Private Sub VolumesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumesToolStripMenuItem.Click
        Dim frmC As New SearchAOms
        NewForm(frmC)
    End Sub

    Private Sub ArchiefToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchiefToolStripMenuItem.Click
        Dim frmC As New SearchDEL
        NewForm(frmC)
    End Sub

    Private Sub NewForm(frm As Form)
        CloseAllForms()
        plook = False
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub OnderaannemersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnderaannemersToolStripMenuItem.Click
        Dim frmC As New SearchOaanm
        NewForm(frmC)
    End Sub

    Private Sub CodegroepenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodegroepenToolStripMenuItem.Click
        Dim frmc As New SearchCodgp
        NewForm(frmc)
    End Sub

    Private Sub DieselToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim frmc As New SearchDies
        NewForm(frmc)
    End Sub

    Private Sub GebruikersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmc As New Searchlogin
        NewForm(frmc)
    End Sub

    Private Sub GebruikersNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GebruikersNewToolStripMenuItem.Click
        Dim frmc As New Searchusers
        NewForm(frmc)
    End Sub

    Private Sub EigenaarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EigenaarToolStripMenuItem.Click
        Dim frmc As New SearchEigenaar
        NewForm(frmc)
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Dim frmc As New SearchStock
        NewForm(frmc)
    End Sub

    Private Sub LeveranciersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeveranciersToolStripMenuItem.Click
        Dim frmc As New SearchLEV
        NewForm(frmc)
    End Sub

    Private Sub FacturenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturenToolStripMenuItem.Click
        Dim frmc As New searchfakt
        NewForm(frmc)
    End Sub

    Private Sub HistoriekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriekToolStripMenuItem.Click
        Dim frmc As New SearchStockHist
        NewForm(frmc)
    End Sub

    Private Sub BonNieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonNieuwToolStripMenuItem.Click
        Dim frmc As New SearchBON_NW
        NewForm(frmc)
    End Sub

    Private Sub ParametersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametersToolStripMenuItem.Click
        Dim frmc As New EditParameters
        NewForm(frmc)
    End Sub

    Private Sub StartSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartSQLToolStripMenuItem.Click
        Dim frmC As New StartSQL
        NewForm(frmC)
    End Sub

    Private Sub VersiegroepenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiegroepenToolStripMenuItem.Click
        Dim frmC As New SearchVersieG
        NewForm(frmC)
    End Sub

    Private Sub VersiemeldingenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiemeldingenToolStripMenuItem.Click
        Dim frmC As New SearchVersie
        NewForm(frmC)
    End Sub

    Private Sub DTPsys_ValueChanged(sender As Object, e As EventArgs) Handles DTPsys.ValueChanged
        SysDate = DTPsys.Value.ToString("dd/MM/yyyy")
        Me.Text = "Bonbeheer, welkom " & Trim(LoginNm) & " [" & LoginID & "] (" & SysDate & ")  -  DataBase " & sysDBUsed
    End Sub

    Private Sub BonlijnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonlijnenToolStripMenuItem.Click
        Dim frmC As New SearchBONL_all
        NewForm(frmC)
    End Sub

    Private Sub BonnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonnenToolStripMenuItem.Click
        Dim frmc As New Archive_BON
        NewForm(frmc)
    End Sub

    Private Sub StockPersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockPersToolStripMenuItem.Click
        Dim frmc As New SearchStockPER
        NewForm(frmc)
    End Sub

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem.Click
        Dim frmc As New SearchPSector
        NewForm(frmc)
    End Sub

    Private Sub TypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeToolStripMenuItem.Click
        Dim frmc As New SearchPType
        NewForm(frmc)
    End Sub

    Private Sub PersoneelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PersoneelToolStripMenuItem1.Click
        Dim frmC As New SearchPER
        NewForm(frmC)
    End Sub

    Private Sub PrestatiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrestatiesToolStripMenuItem1.Click
        Dim frmC As New SearchPrestaties
        NewForm(frmC)
    End Sub

    Private Sub FeestdagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeestdagenToolStripMenuItem.Click
        Dim frmC As New SearchFeest
        NewForm(frmC)
    End Sub

    Private Sub AfTeHandelenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfTeHandelenToolStripMenuItem1.Click
        Dim frmC As New SearchAF
        NewForm(frmC)
    End Sub

    Private Sub RedenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedenToolStripMenuItem.Click
        Dim frmC As New SearchAFR
        NewForm(frmC)
    End Sub

    Private Sub TypeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TypeToolStripMenuItem1.Click
        Dim frmC As New SearchAFT
        NewForm(frmC)
    End Sub
End Class
