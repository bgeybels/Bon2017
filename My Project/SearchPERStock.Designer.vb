<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPERStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPERStock))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBnew = New System.Windows.Forms.ToolStripButton()
        Me.TSBedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.CMSpers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMInewP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIupdateP = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMScode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMInewPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIupdatePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMIdeletePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECP = New System.Windows.Forms.DataGridView()
        Me.GroupFilterPER = New System.Windows.Forms.GroupBox()
        Me.CBdienstN = New System.Windows.Forms.CheckBox()
        Me.CBdienstJ = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltpernm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECC = New System.Windows.Forms.DataGridView()
        Me.GroupFilterCOD = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FltOmsgroep = New System.Windows.Forms.TextBox()
        Me.TBResultBON = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.CMSpers.SuspendLayout()
        Me.CMScode.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilterPER.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.DGRECC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilterCOD.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel1, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1224, 31)
        Me.ToolStrip1.TabIndex = 8
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
        'TSBnew
        '
        Me.TSBnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBnew.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.TSBnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBnew.Name = "TSBnew"
        Me.TSBnew.Size = New System.Drawing.Size(28, 28)
        Me.TSBnew.Text = "Nieuw"
        Me.TSBnew.ToolTipText = "Nieuwe BON"
        '
        'TSBedit
        '
        Me.TSBedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBedit.Image = CType(resources.GetObject("TSBedit.Image"), System.Drawing.Image)
        Me.TSBedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBedit.Name = "TSBedit"
        Me.TSBedit.Size = New System.Drawing.Size(28, 28)
        Me.TSBedit.Text = "Editeer"
        Me.TSBedit.ToolTipText = "Bewerk BON"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
        '
        'TSBdelete
        '
        Me.TSBdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBdelete.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSBdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdelete.Name = "TSBdelete"
        Me.TSBdelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBdelete.Text = "Verwijder"
        Me.TSBdelete.ToolTipText = "Verwijder BON"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'TSBexport
        '
        Me.TSBexport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBexport.Image = Global.Bon2017.My.Resources.Resources.excel
        Me.TSBexport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBexport.Name = "TSBexport"
        Me.TSBexport.Size = New System.Drawing.Size(28, 28)
        Me.TSBexport.Text = "Exporteer"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
        '
        'CMSpers
        '
        Me.CMSpers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMInewP, Me.TSMIupdateP})
        Me.CMSpers.Name = "ContextMenuStrip"
        Me.CMSpers.Size = New System.Drawing.Size(185, 48)
        '
        'TSMInewP
        '
        Me.TSMInewP.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.TSMInewP.Name = "TSMInewP"
        Me.TSMInewP.Size = New System.Drawing.Size(184, 22)
        Me.TSMInewP.Text = "Nieuw Personeelslid"
        '
        'TSMIupdateP
        '
        Me.TSMIupdateP.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.TSMIupdateP.Name = "TSMIupdateP"
        Me.TSMIupdateP.Size = New System.Drawing.Size(184, 22)
        Me.TSMIupdateP.Text = "Bewerk Personeelslid"
        '
        'CMScode
        '
        Me.CMScode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMInewPL, Me.TSMIupdatePL, Me.ToolStripSeparator5, Me.TSMIdeletePL})
        Me.CMScode.Name = "ContextMenuStrip"
        Me.CMScode.Size = New System.Drawing.Size(217, 76)
        '
        'TSMInewPL
        '
        Me.TSMInewPL.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.TSMInewPL.Name = "TSMInewPL"
        Me.TSMInewPL.Size = New System.Drawing.Size(216, 22)
        Me.TSMInewPL.Text = "Nieuwe Personeelslijn"
        '
        'TSMIupdatePL
        '
        Me.TSMIupdatePL.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.TSMIupdatePL.Name = "TSMIupdatePL"
        Me.TSMIupdatePL.Size = New System.Drawing.Size(216, 22)
        Me.TSMIupdatePL.Text = "Bewerk Personeelslijn"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(213, 6)
        '
        'TSMIdeletePL
        '
        Me.TSMIdeletePL.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSMIdeletePL.Name = "TSMIdeletePL"
        Me.TSMIdeletePL.Size = New System.Drawing.Size(216, 22)
        Me.TSMIdeletePL.Text = "Verwijder geselecteerde lijn"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1224, 474)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupFilterPER, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(238, 468)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.DGRECP, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 83)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(232, 382)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'DGRECP
        '
        Me.DGRECP.AllowUserToAddRows = False
        Me.DGRECP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECP.ContextMenuStrip = Me.CMSpers
        Me.DGRECP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECP.Location = New System.Drawing.Point(3, 3)
        Me.DGRECP.MultiSelect = False
        Me.DGRECP.Name = "DGRECP"
        Me.DGRECP.Size = New System.Drawing.Size(226, 376)
        Me.DGRECP.TabIndex = 4
        '
        'GroupFilterPER
        '
        Me.GroupFilterPER.AutoSize = True
        Me.GroupFilterPER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilterPER.Controls.Add(Me.CBdienstN)
        Me.GroupFilterPER.Controls.Add(Me.CBdienstJ)
        Me.GroupFilterPER.Controls.Add(Me.Label6)
        Me.GroupFilterPER.Controls.Add(Me.Label4)
        Me.GroupFilterPER.Controls.Add(Me.Fltpernm)
        Me.GroupFilterPER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilterPER.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilterPER.Name = "GroupFilterPER"
        Me.GroupFilterPER.Size = New System.Drawing.Size(232, 74)
        Me.GroupFilterPER.TabIndex = 3
        Me.GroupFilterPER.TabStop = False
        '
        'CBdienstN
        '
        Me.CBdienstN.AutoSize = True
        Me.CBdienstN.Location = New System.Drawing.Point(82, 38)
        Me.CBdienstN.Name = "CBdienstN"
        Me.CBdienstN.Size = New System.Drawing.Size(46, 17)
        Me.CBdienstN.TabIndex = 64
        Me.CBdienstN.Text = "Nee"
        Me.CBdienstN.UseVisualStyleBackColor = True
        '
        'CBdienstJ
        '
        Me.CBdienstJ.AutoSize = True
        Me.CBdienstJ.Checked = True
        Me.CBdienstJ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBdienstJ.Location = New System.Drawing.Point(48, 38)
        Me.CBdienstJ.Name = "CBdienstJ"
        Me.CBdienstJ.Size = New System.Drawing.Size(37, 17)
        Me.CBdienstJ.TabIndex = 63
        Me.CBdienstJ.Text = "Ja"
        Me.CBdienstJ.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "InDienst"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Naam"
        '
        'Fltpernm
        '
        Me.Fltpernm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltpernm.Location = New System.Drawing.Point(48, 12)
        Me.Fltpernm.Name = "Fltpernm"
        Me.Fltpernm.Size = New System.Drawing.Size(66, 20)
        Me.Fltpernm.TabIndex = 58
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TBResultBON, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(247, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(974, 468)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupFilterCOD, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(968, 362)
        Me.TableLayoutPanel6.TabIndex = 19
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.DGRECC, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(140, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(863, 356)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'DGRECC
        '
        Me.DGRECC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECC.ContextMenuStrip = Me.CMScode
        Me.DGRECC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECC.Location = New System.Drawing.Point(3, 3)
        Me.DGRECC.MultiSelect = False
        Me.DGRECC.Name = "DGRECC"
        Me.DGRECC.Size = New System.Drawing.Size(857, 350)
        Me.DGRECC.TabIndex = 5
        '
        'GroupFilterCOD
        '
        Me.GroupFilterCOD.AutoSize = True
        Me.GroupFilterCOD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilterCOD.Controls.Add(Me.Label7)
        Me.GroupFilterCOD.Controls.Add(Me.FltCode)
        Me.GroupFilterCOD.Controls.Add(Me.Label1)
        Me.GroupFilterCOD.Controls.Add(Me.FltOmsgroep)
        Me.GroupFilterCOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilterCOD.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilterCOD.Name = "GroupFilterCOD"
        Me.GroupFilterCOD.Size = New System.Drawing.Size(131, 356)
        Me.GroupFilterCOD.TabIndex = 2
        Me.GroupFilterCOD.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Code"
        '
        'FltCode
        '
        Me.FltCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCode.Location = New System.Drawing.Point(59, 38)
        Me.FltCode.Name = "FltCode"
        Me.FltCode.Size = New System.Drawing.Size(66, 20)
        Me.FltCode.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Groep"
        '
        'FltOmsgroep
        '
        Me.FltOmsgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltOmsgroep.Location = New System.Drawing.Point(59, 12)
        Me.FltOmsgroep.Name = "FltOmsgroep"
        Me.FltOmsgroep.Size = New System.Drawing.Size(66, 20)
        Me.FltOmsgroep.TabIndex = 88
        '
        'TBResultBON
        '
        Me.TBResultBON.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultBON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultBON.Enabled = False
        Me.TBResultBON.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultBON.Location = New System.Drawing.Point(3, 3)
        Me.TBResultBON.Multiline = True
        Me.TBResultBON.Name = "TBResultBON"
        Me.TBResultBON.Size = New System.Drawing.Size(968, 94)
        Me.TBResultBON.TabIndex = 18
        '
        'SearchPERStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 505)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchPERStock"
        Me.Text = "SearchPERStock"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CMSpers.ResumeLayout(False)
        Me.CMScode.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilterPER.ResumeLayout(False)
        Me.GroupFilterPER.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.DGRECC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilterCOD.ResumeLayout(False)
        Me.GroupFilterCOD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBnew As ToolStripButton
    Friend WithEvents TSBedit As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents CMSpers As ContextMenuStrip
    Friend WithEvents TSMInewP As ToolStripMenuItem
    Friend WithEvents TSMIupdateP As ToolStripMenuItem
    Friend WithEvents CMScode As ContextMenuStrip
    Friend WithEvents TSMInewPL As ToolStripMenuItem
    Friend WithEvents TSMIupdatePL As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSMIdeletePL As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupFilterPER As GroupBox
    Friend WithEvents CBdienstN As CheckBox
    Friend WithEvents CBdienstJ As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltpernm As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DGRECP As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TBResultBON As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents DGRECC As DataGridView
    Friend WithEvents GroupFilterCOD As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FltCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FltOmsgroep As TextBox
End Class
