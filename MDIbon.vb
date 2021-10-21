Imports System.Windows.Forms

Public Class MDIbon

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub MDIbon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB.Close()
        Text = "Bonbeheer, welkom " & LoginNm & " (" & SysDate & ")  --  Versie: " & Application.ProductVersion & ":" & Application.ProductName & " -- " & sysDBUsed


        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
        Me.MaximizeBox = True
        Me.MinimizeBox = False

        ToolsToolStripMenuItem.Enabled = False
        SYSTEMToolStripMenuItem.Visible = False
        If LoginSysAdmin = True Then
            ToolsToolStripMenuItem.Enabled = True
        End If
        If LoginNm = "SYSTEM" Or LoginNm = "bge" Then
            SYSTEMToolStripMenuItem.Visible = True
        End If
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

    Private Sub BonToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmC As New FrmBONE
        NewForm(frmC)
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

    Private Sub PersoneelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersoneelToolStripMenuItem.Click
        Dim frmC As New SearchPER
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

    Private Sub DieselToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DieselToolStripMenuItem.Click
        Dim frmc As New SearchDies
        NewForm(frmc)
    End Sub

    Private Sub GebruikersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GebruikersToolStripMenuItem.Click
        Dim frmc As New Searchlogin
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


    Private Sub UitvoerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UitvoerenToolStripMenuItem.Click
        MsgBox("UITVOEREN!!!!: ALTER TABLE dbo.DEL ALTER COLUMN usernrq NVARCHAR(10)" &
                vbNewLine & "alter table dbo.DEL add yearin NVARCHAR(4);" &
               vbNewLine & "INSERT INTO DEL (usernrq,delWO,chdate,part,delinfo,yearin) VALUES ('user','elWO','08/05/2017','part','delinfo','2017');" &
             vbNewLine & "DELETE from DEL;" &
             vbNewLine & "Reset TELLER!!; DBCC CHECKIDENT (DEL, RESEED, 0)")
    End Sub

    Private Sub HistoriekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriekToolStripMenuItem.Click
        Dim frmc As New SearchStockHist
        NewForm(frmc)
    End Sub

    Private Sub BonNieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonNieuwToolStripMenuItem.Click
        Dim frmc As New SearchBON
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
End Class
