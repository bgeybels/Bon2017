<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStockPER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchStockPER))
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
        Me.CMScode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMInewPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIupdatePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMIdeletePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSpers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMInewP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIupdateP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel_FULL = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_PER = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilterPER = New System.Windows.Forms.GroupBox()
        Me.CBdienstN = New System.Windows.Forms.CheckBox()
        Me.CBdienstJ = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltpernm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel_DGRECP = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECP = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel_ALL_COD = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_INFOS = New System.Windows.Forms.TableLayoutPanel()
        Me.TBinfo2 = New System.Windows.Forms.TextBox()
        Me.TBinfo1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel_COD = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilterCOD = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FltOmsgroep = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel_DGRECC = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECC = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.CMScode.SuspendLayout()
        Me.CMSpers.SuspendLayout()
        Me.TableLayoutPanel_FULL.SuspendLayout()
        Me.TableLayoutPanel_PER.SuspendLayout()
        Me.GroupFilterPER.SuspendLayout()
        Me.TableLayoutPanel_DGRECP.SuspendLayout()
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_ALL_COD.SuspendLayout()
        Me.TableLayoutPanel_INFOS.SuspendLayout()
        Me.TableLayoutPanel_COD.SuspendLayout()
        Me.GroupFilterCOD.SuspendLayout()
        Me.TableLayoutPanel_DGRECC.SuspendLayout()
        CType(Me.DGRECC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel1, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1325, 31)
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
        Me.TSMInewPL.Text = "Nieuwe personeelslijn"
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
        'TableLayoutPanel_FULL
        '
        Me.TableLayoutPanel_FULL.ColumnCount = 2
        Me.TableLayoutPanel_FULL.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel_FULL.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel_FULL.Controls.Add(Me.TableLayoutPanel_PER, 0, 0)
        Me.TableLayoutPanel_FULL.Controls.Add(Me.TableLayoutPanel_ALL_COD, 1, 0)
        Me.TableLayoutPanel_FULL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_FULL.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel_FULL.Name = "TableLayoutPanel_FULL"
        Me.TableLayoutPanel_FULL.RowCount = 1
        Me.TableLayoutPanel_FULL.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_FULL.Size = New System.Drawing.Size(1325, 473)
        Me.TableLayoutPanel_FULL.TabIndex = 11
        '
        'TableLayoutPanel_PER
        '
        Me.TableLayoutPanel_PER.ColumnCount = 1
        Me.TableLayoutPanel_PER.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_PER.Controls.Add(Me.GroupFilterPER, 0, 0)
        Me.TableLayoutPanel_PER.Controls.Add(Me.TableLayoutPanel_DGRECP, 0, 1)
        Me.TableLayoutPanel_PER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_PER.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_PER.Name = "TableLayoutPanel_PER"
        Me.TableLayoutPanel_PER.RowCount = 2
        Me.TableLayoutPanel_PER.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_PER.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_PER.Size = New System.Drawing.Size(259, 467)
        Me.TableLayoutPanel_PER.TabIndex = 0
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
        Me.GroupFilterPER.Size = New System.Drawing.Size(253, 74)
        Me.GroupFilterPER.TabIndex = 3
        Me.GroupFilterPER.TabStop = False
        '
        'CBdienstN
        '
        Me.CBdienstN.AutoSize = True
        Me.CBdienstN.Location = New System.Drawing.Point(94, 38)
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
        Me.CBdienstJ.Location = New System.Drawing.Point(60, 38)
        Me.CBdienstJ.Name = "CBdienstJ"
        Me.CBdienstJ.Size = New System.Drawing.Size(37, 17)
        Me.CBdienstJ.TabIndex = 63
        Me.CBdienstJ.Text = "Ja"
        Me.CBdienstJ.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "InDienst"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Naam"
        '
        'Fltpernm
        '
        Me.Fltpernm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltpernm.Location = New System.Drawing.Point(60, 12)
        Me.Fltpernm.Name = "Fltpernm"
        Me.Fltpernm.Size = New System.Drawing.Size(128, 20)
        Me.Fltpernm.TabIndex = 58
        '
        'TableLayoutPanel_DGRECP
        '
        Me.TableLayoutPanel_DGRECP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel_DGRECP.ColumnCount = 1
        Me.TableLayoutPanel_DGRECP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_DGRECP.Controls.Add(Me.DGRECP, 0, 0)
        Me.TableLayoutPanel_DGRECP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_DGRECP.Location = New System.Drawing.Point(3, 83)
        Me.TableLayoutPanel_DGRECP.Name = "TableLayoutPanel_DGRECP"
        Me.TableLayoutPanel_DGRECP.RowCount = 1
        Me.TableLayoutPanel_DGRECP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_DGRECP.Size = New System.Drawing.Size(253, 381)
        Me.TableLayoutPanel_DGRECP.TabIndex = 4
        '
        'DGRECP
        '
        Me.DGRECP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECP.ContextMenuStrip = Me.CMSpers
        Me.DGRECP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECP.Location = New System.Drawing.Point(3, 3)
        Me.DGRECP.MultiSelect = False
        Me.DGRECP.Name = "DGRECP"
        Me.DGRECP.Size = New System.Drawing.Size(247, 375)
        Me.DGRECP.TabIndex = 5
        '
        'TableLayoutPanel_ALL_COD
        '
        Me.TableLayoutPanel_ALL_COD.ColumnCount = 1
        Me.TableLayoutPanel_ALL_COD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_ALL_COD.Controls.Add(Me.TableLayoutPanel_INFOS, 0, 0)
        Me.TableLayoutPanel_ALL_COD.Controls.Add(Me.TableLayoutPanel_COD, 0, 1)
        Me.TableLayoutPanel_ALL_COD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_ALL_COD.Location = New System.Drawing.Point(268, 3)
        Me.TableLayoutPanel_ALL_COD.Name = "TableLayoutPanel_ALL_COD"
        Me.TableLayoutPanel_ALL_COD.RowCount = 2
        Me.TableLayoutPanel_ALL_COD.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_ALL_COD.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_ALL_COD.Size = New System.Drawing.Size(1054, 467)
        Me.TableLayoutPanel_ALL_COD.TabIndex = 1
        '
        'TableLayoutPanel_INFOS
        '
        Me.TableLayoutPanel_INFOS.ColumnCount = 2
        Me.TableLayoutPanel_INFOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_INFOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_INFOS.Controls.Add(Me.TBinfo2, 0, 0)
        Me.TableLayoutPanel_INFOS.Controls.Add(Me.TBinfo1, 0, 0)
        Me.TableLayoutPanel_INFOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_INFOS.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_INFOS.Name = "TableLayoutPanel_INFOS"
        Me.TableLayoutPanel_INFOS.RowCount = 1
        Me.TableLayoutPanel_INFOS.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_INFOS.Size = New System.Drawing.Size(1048, 87)
        Me.TableLayoutPanel_INFOS.TabIndex = 0
        '
        'TBinfo2
        '
        Me.TBinfo2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBinfo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBinfo2.Enabled = False
        Me.TBinfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBinfo2.Location = New System.Drawing.Point(527, 3)
        Me.TBinfo2.Multiline = True
        Me.TBinfo2.Name = "TBinfo2"
        Me.TBinfo2.Size = New System.Drawing.Size(518, 81)
        Me.TBinfo2.TabIndex = 19
        '
        'TBinfo1
        '
        Me.TBinfo1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBinfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBinfo1.Enabled = False
        Me.TBinfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBinfo1.Location = New System.Drawing.Point(3, 3)
        Me.TBinfo1.Multiline = True
        Me.TBinfo1.Name = "TBinfo1"
        Me.TBinfo1.Size = New System.Drawing.Size(518, 81)
        Me.TBinfo1.TabIndex = 18
        '
        'TableLayoutPanel_COD
        '
        Me.TableLayoutPanel_COD.ColumnCount = 2
        Me.TableLayoutPanel_COD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_COD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_COD.Controls.Add(Me.GroupFilterCOD, 0, 0)
        Me.TableLayoutPanel_COD.Controls.Add(Me.TableLayoutPanel_DGRECC, 1, 0)
        Me.TableLayoutPanel_COD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_COD.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel_COD.Name = "TableLayoutPanel_COD"
        Me.TableLayoutPanel_COD.RowCount = 1
        Me.TableLayoutPanel_COD.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_COD.Size = New System.Drawing.Size(1048, 368)
        Me.TableLayoutPanel_COD.TabIndex = 1
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
        Me.GroupFilterCOD.Size = New System.Drawing.Size(156, 362)
        Me.GroupFilterCOD.TabIndex = 3
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
        Me.FltCode.Size = New System.Drawing.Size(91, 20)
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
        Me.FltOmsgroep.Size = New System.Drawing.Size(91, 20)
        Me.FltOmsgroep.TabIndex = 88
        '
        'TableLayoutPanel_DGRECC
        '
        Me.TableLayoutPanel_DGRECC.ColumnCount = 1
        Me.TableLayoutPanel_DGRECC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_DGRECC.Controls.Add(Me.DGRECC, 0, 0)
        Me.TableLayoutPanel_DGRECC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_DGRECC.Location = New System.Drawing.Point(165, 3)
        Me.TableLayoutPanel_DGRECC.Name = "TableLayoutPanel_DGRECC"
        Me.TableLayoutPanel_DGRECC.RowCount = 1
        Me.TableLayoutPanel_DGRECC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_DGRECC.Size = New System.Drawing.Size(880, 362)
        Me.TableLayoutPanel_DGRECC.TabIndex = 4
        '
        'DGRECC
        '
        Me.DGRECC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECC.ContextMenuStrip = Me.CMScode
        Me.DGRECC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECC.Location = New System.Drawing.Point(3, 3)
        Me.DGRECC.MultiSelect = False
        Me.DGRECC.Name = "DGRECC"
        Me.DGRECC.Size = New System.Drawing.Size(874, 356)
        Me.DGRECC.TabIndex = 6
        '
        'SearchStockPER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 504)
        Me.Controls.Add(Me.TableLayoutPanel_FULL)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchStockPER"
        Me.Text = "SearchStockPER"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CMScode.ResumeLayout(False)
        Me.CMSpers.ResumeLayout(False)
        Me.TableLayoutPanel_FULL.ResumeLayout(False)
        Me.TableLayoutPanel_PER.ResumeLayout(False)
        Me.TableLayoutPanel_PER.PerformLayout()
        Me.GroupFilterPER.ResumeLayout(False)
        Me.GroupFilterPER.PerformLayout()
        Me.TableLayoutPanel_DGRECP.ResumeLayout(False)
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_ALL_COD.ResumeLayout(False)
        Me.TableLayoutPanel_INFOS.ResumeLayout(False)
        Me.TableLayoutPanel_INFOS.PerformLayout()
        Me.TableLayoutPanel_COD.ResumeLayout(False)
        Me.TableLayoutPanel_COD.PerformLayout()
        Me.GroupFilterCOD.ResumeLayout(False)
        Me.GroupFilterCOD.PerformLayout()
        Me.TableLayoutPanel_DGRECC.ResumeLayout(False)
        CType(Me.DGRECC, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CMScode As ContextMenuStrip
    Friend WithEvents TSMInewPL As ToolStripMenuItem
    Friend WithEvents TSMIupdatePL As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSMIdeletePL As ToolStripMenuItem
    Friend WithEvents CMSpers As ContextMenuStrip
    Friend WithEvents TSMInewP As ToolStripMenuItem
    Friend WithEvents TSMIupdateP As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel_FULL As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_PER As TableLayoutPanel
    Friend WithEvents GroupFilterPER As GroupBox
    Friend WithEvents CBdienstN As CheckBox
    Friend WithEvents CBdienstJ As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltpernm As TextBox
    Friend WithEvents TableLayoutPanel_ALL_COD As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_INFOS As TableLayoutPanel
    Friend WithEvents TBinfo1 As TextBox
    Friend WithEvents TBinfo2 As TextBox
    Friend WithEvents TableLayoutPanel_COD As TableLayoutPanel
    Friend WithEvents GroupFilterCOD As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FltCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FltOmsgroep As TextBox
    Friend WithEvents TableLayoutPanel_DGRECC As TableLayoutPanel
    Friend WithEvents DGRECC As DataGridView
    Friend WithEvents TableLayoutPanel_DGRECP As TableLayoutPanel
    Friend WithEvents DGRECP As DataGridView
End Class
