<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUser))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBtotals = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBupersuser = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBgetfaktnr = New System.Windows.Forms.CheckBox()
        Me.CBstockuser = New System.Windows.Forms.CheckBox()
        Me.CBsysuser = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBnaam = New System.Windows.Forms.TextBox()
        Me.TBpwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBdel = New System.Windows.Forms.CheckBox()
        Me.CBnew = New System.Windows.Forms.CheckBox()
        Me.CBupd = New System.Windows.Forms.CheckBox()
        Me.CBtotalssys = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(386, 31)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBexit
        '
        Me.TSBexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBexit.Image = Global.Bon2017.My.Resources.Resources.home
        Me.TSBexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBexit.Name = "TSBexit"
        Me.TSBexit.Size = New System.Drawing.Size(28, 28)
        Me.TSBexit.Text = "Exit"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel4.Text = "   "
        '
        'TSBsave
        '
        Me.TSBsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBsave.Image = CType(resources.GetObject("TSBsave.Image"), System.Drawing.Image)
        Me.TSBsave.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBsave.Name = "TSBsave"
        Me.TSBsave.Size = New System.Drawing.Size(28, 28)
        Me.TSBsave.Text = "Bewaar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(386, 372)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.CBtotalssys)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBtotals)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CBupersuser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBgetfaktnr)
        Me.GroupBox1.Controls.Add(Me.CBstockuser)
        Me.GroupBox1.Controls.Add(Me.CBsysuser)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TBnaam)
        Me.GroupBox1.Controls.Add(Me.TBpwd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Toon totalen bij de BON"
        '
        'CBtotals
        '
        Me.CBtotals.AutoSize = True
        Me.CBtotals.Location = New System.Drawing.Point(89, 210)
        Me.CBtotals.Name = "CBtotals"
        Me.CBtotals.Size = New System.Drawing.Size(86, 17)
        Me.CBtotals.TabIndex = 42
        Me.CBtotals.Text = "Toon totalen"
        Me.CBtotals.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Toon stockbeheer Personeel"
        '
        'CBupersuser
        '
        Me.CBupersuser.AutoSize = True
        Me.CBupersuser.Location = New System.Drawing.Point(89, 175)
        Me.CBupersuser.Name = "CBupersuser"
        Me.CBupersuser.Size = New System.Drawing.Size(110, 17)
        Me.CBupersuser.TabIndex = 40
        Me.CBupersuser.Text = "PersoneelsSTock"
        Me.CBupersuser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Zet Fnr terug na aanpassen Bonlijn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Toon status STOCK bij opstarten"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Toon menu TOOLS"
        '
        'CBgetfaktnr
        '
        Me.CBgetfaktnr.AutoSize = True
        Me.CBgetfaktnr.Location = New System.Drawing.Point(89, 141)
        Me.CBgetfaktnr.Name = "CBgetfaktnr"
        Me.CBgetfaktnr.Size = New System.Drawing.Size(120, 17)
        Me.CBgetfaktnr.TabIndex = 36
        Me.CBgetfaktnr.Text = "Auto-Set FactuurNr."
        Me.CBgetfaktnr.UseVisualStyleBackColor = True
        '
        'CBstockuser
        '
        Me.CBstockuser.AutoSize = True
        Me.CBstockuser.Location = New System.Drawing.Point(89, 108)
        Me.CBstockuser.Name = "CBstockuser"
        Me.CBstockuser.Size = New System.Drawing.Size(98, 17)
        Me.CBstockuser.TabIndex = 35
        Me.CBstockuser.Text = "Stockgebruiker"
        Me.CBstockuser.UseVisualStyleBackColor = True
        '
        'CBsysuser
        '
        Me.CBsysuser.AutoSize = True
        Me.CBsysuser.Location = New System.Drawing.Point(89, 74)
        Me.CBsysuser.Name = "CBsysuser"
        Me.CBsysuser.Size = New System.Drawing.Size(110, 17)
        Me.CBsysuser.TabIndex = 34
        Me.CBsysuser.Text = "Systeemgebruiker"
        Me.CBsysuser.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Naam"
        '
        'TBnaam
        '
        Me.TBnaam.Location = New System.Drawing.Point(89, 19)
        Me.TBnaam.Name = "TBnaam"
        Me.TBnaam.Size = New System.Drawing.Size(281, 20)
        Me.TBnaam.TabIndex = 28
        '
        'TBpwd
        '
        Me.TBpwd.Location = New System.Drawing.Point(89, 45)
        Me.TBpwd.Name = "TBpwd"
        Me.TBpwd.Size = New System.Drawing.Size(281, 20)
        Me.TBpwd.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Paswoord"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.CBdel)
        Me.GroupBox2.Controls.Add(Me.CBnew)
        Me.GroupBox2.Controls.Add(Me.CBupd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CBdel
        '
        Me.CBdel.Location = New System.Drawing.Point(267, 10)
        Me.CBdel.Name = "CBdel"
        Me.CBdel.Size = New System.Drawing.Size(83, 23)
        Me.CBdel.TabIndex = 19
        Me.CBdel.TabStop = False
        Me.CBdel.Text = "Schrappen"
        Me.CBdel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBdel.UseVisualStyleBackColor = True
        '
        'CBnew
        '
        Me.CBnew.Location = New System.Drawing.Point(178, 10)
        Me.CBnew.Name = "CBnew"
        Me.CBnew.Size = New System.Drawing.Size(83, 23)
        Me.CBnew.TabIndex = 18
        Me.CBnew.TabStop = False
        Me.CBnew.Text = "Nieuw"
        Me.CBnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBnew.UseVisualStyleBackColor = True
        '
        'CBupd
        '
        Me.CBupd.Location = New System.Drawing.Point(89, 10)
        Me.CBupd.Name = "CBupd"
        Me.CBupd.Size = New System.Drawing.Size(83, 23)
        Me.CBupd.TabIndex = 17
        Me.CBupd.TabStop = False
        Me.CBupd.Text = "Wijzigen"
        Me.CBupd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBupd.UseVisualStyleBackColor = True
        '
        'CBtotalssys
        '
        Me.CBtotalssys.AutoSize = True
        Me.CBtotalssys.Location = New System.Drawing.Point(90, 249)
        Me.CBtotalssys.Name = "CBtotalssys"
        Me.CBtotalssys.Size = New System.Drawing.Size(110, 17)
        Me.CBtotalssys.TabIndex = 44
        Me.CBtotalssys.Text = "Toon altijd totalen"
        Me.CBtotalssys.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 403)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditUser"
        Me.Text = "Gebruikers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBsysuser As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBnaam As TextBox
    Friend WithEvents TBpwd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBdel As CheckBox
    Friend WithEvents CBnew As CheckBox
    Friend WithEvents CBupd As CheckBox
    Friend WithEvents CBstockuser As CheckBox
    Friend WithEvents CBgetfaktnr As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBupersuser As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBtotals As CheckBox
    Friend WithEvents CBtotalssys As CheckBox
End Class
