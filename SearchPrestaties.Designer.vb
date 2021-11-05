<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchPrestaties
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPrestaties))
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECP = New System.Windows.Forms.DataGridView()
        Me.GroupFilterPER = New System.Windows.Forms.GroupBox()
        Me.CBdienstN = New System.Windows.Forms.CheckBox()
        Me.CBdienstJ = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltpernm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilterCOD = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Flttype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltsector = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.CBfilteryear = New System.Windows.Forms.CheckBox()
        Me.Fltbonjr = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGRECPR = New System.Windows.Forms.DataGridView()
        Me.CMScode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMInewPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIupdatePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMIdeletePL = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBResultPERSH2 = New System.Windows.Forms.TextBox()
        Me.TBResultPERS2 = New System.Windows.Forms.TextBox()
        Me.TBResultPERS = New System.Windows.Forms.TextBox()
        Me.TBResultPREST = New System.Windows.Forms.TextBox()
        Me.TBResultPERSH = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.CMSpers.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilterPER.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupFilterCOD.SuspendLayout()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DGRECPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMScode.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel1, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1299, 31)
        Me.ToolStrip1.TabIndex = 6
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
        Me.TSBnew.ToolTipText = "Nieuwe prestatie"
        '
        'TSBedit
        '
        Me.TSBedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBedit.Image = CType(resources.GetObject("TSBedit.Image"), System.Drawing.Image)
        Me.TSBedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBedit.Name = "TSBedit"
        Me.TSBedit.Size = New System.Drawing.Size(28, 28)
        Me.TSBedit.Text = "Editeer"
        Me.TSBedit.ToolTipText = "Bewerk prestatie"
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
        Me.TSBdelete.ToolTipText = "Verwijder prestatie"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1299, 471)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1293, 365)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupFilterPER, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(344, 359)
        Me.TableLayoutPanel4.TabIndex = 1
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
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(338, 273)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'DGRECP
        '
        Me.DGRECP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECP.ContextMenuStrip = Me.CMSpers
        Me.DGRECP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECP.Location = New System.Drawing.Point(3, 3)
        Me.DGRECP.MultiSelect = False
        Me.DGRECP.Name = "DGRECP"
        Me.DGRECP.Size = New System.Drawing.Size(332, 267)
        Me.DGRECP.TabIndex = 4
        Me.DGRECP.TabStop = False
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
        Me.GroupFilterPER.Size = New System.Drawing.Size(338, 74)
        Me.GroupFilterPER.TabIndex = 2
        Me.GroupFilterPER.TabStop = False
        '
        'CBdienstN
        '
        Me.CBdienstN.AutoSize = True
        Me.CBdienstN.Location = New System.Drawing.Point(82, 38)
        Me.CBdienstN.Name = "CBdienstN"
        Me.CBdienstN.Size = New System.Drawing.Size(46, 17)
        Me.CBdienstN.TabIndex = 64
        Me.CBdienstN.TabStop = False
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
        Me.CBdienstJ.TabStop = False
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
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.GroupFilterCOD, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(353, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(937, 359)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'GroupFilterCOD
        '
        Me.GroupFilterCOD.AutoSize = True
        Me.GroupFilterCOD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilterCOD.Controls.Add(Me.Label2)
        Me.GroupFilterCOD.Controls.Add(Me.Flttype)
        Me.GroupFilterCOD.Controls.Add(Me.Label1)
        Me.GroupFilterCOD.Controls.Add(Me.Fltsector)
        Me.GroupFilterCOD.Controls.Add(Me.Label3)
        Me.GroupFilterCOD.Controls.Add(Me.Fltusernrq)
        Me.GroupFilterCOD.Controls.Add(Me.CBfilteryear)
        Me.GroupFilterCOD.Controls.Add(Me.Fltbonjr)
        Me.GroupFilterCOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilterCOD.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilterCOD.Name = "GroupFilterCOD"
        Me.GroupFilterCOD.Size = New System.Drawing.Size(118, 353)
        Me.GroupFilterCOD.TabIndex = 3
        Me.GroupFilterCOD.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Type"
        '
        'Flttype
        '
        Me.Flttype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Flttype.Location = New System.Drawing.Point(45, 68)
        Me.Flttype.Name = "Flttype"
        Me.Flttype.Size = New System.Drawing.Size(66, 20)
        Me.Flttype.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Sector"
        '
        'Fltsector
        '
        Me.Fltsector.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltsector.Location = New System.Drawing.Point(46, 42)
        Me.Fltsector.Name = "Fltsector"
        Me.Fltsector.Size = New System.Drawing.Size(66, 20)
        Me.Fltsector.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(45, 94)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 98
        '
        'CBfilteryear
        '
        Me.CBfilteryear.AutoSize = True
        Me.CBfilteryear.Checked = True
        Me.CBfilteryear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBfilteryear.Location = New System.Drawing.Point(25, 15)
        Me.CBfilteryear.Name = "CBfilteryear"
        Me.CBfilteryear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilteryear.TabIndex = 93
        Me.CBfilteryear.TabStop = False
        Me.CBfilteryear.UseVisualStyleBackColor = True
        '
        'Fltbonjr
        '
        Me.Fltbonjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonjr.Location = New System.Drawing.Point(46, 15)
        Me.Fltbonjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltbonjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltbonjr.Name = "Fltbonjr"
        Me.Fltbonjr.Size = New System.Drawing.Size(65, 20)
        Me.Fltbonjr.TabIndex = 92
        Me.Fltbonjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltbonjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DGRECPR, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(127, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(807, 353)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'DGRECPR
        '
        Me.DGRECPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECPR.ContextMenuStrip = Me.CMScode
        Me.DGRECPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRECPR.Location = New System.Drawing.Point(3, 3)
        Me.DGRECPR.MultiSelect = False
        Me.DGRECPR.Name = "DGRECPR"
        Me.DGRECPR.Size = New System.Drawing.Size(801, 347)
        Me.DGRECPR.TabIndex = 6
        Me.DGRECPR.TabStop = False
        '
        'CMScode
        '
        Me.CMScode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMInewPL, Me.TSMIupdatePL, Me.ToolStripSeparator5, Me.TSMIdeletePL})
        Me.CMScode.Name = "ContextMenuStrip"
        Me.CMScode.Size = New System.Drawing.Size(181, 98)
        '
        'TSMInewPL
        '
        Me.TSMInewPL.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.TSMInewPL.Name = "TSMInewPL"
        Me.TSMInewPL.Size = New System.Drawing.Size(216, 22)
        Me.TSMInewPL.Text = "Nieuwe Prestatie"
        '
        'TSMIupdatePL
        '
        Me.TSMIupdatePL.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.TSMIupdatePL.Name = "TSMIupdatePL"
        Me.TSMIupdatePL.Size = New System.Drawing.Size(216, 22)
        Me.TSMIupdatePL.Text = "Bewerk Prestatie"
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
        Me.TSMIdeletePL.Size = New System.Drawing.Size(180, 22)
        Me.TSMIdeletePL.Text = "Verwijder Prestatie"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 6
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.TBResultPERSH2, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TBResultPERS2, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TBResultPERS, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TBResultPREST, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TBResultPERSH, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1293, 94)
        Me.TableLayoutPanel7.TabIndex = 20
        '
        'TBResultPERSH2
        '
        Me.TBResultPERSH2.BackColor = System.Drawing.SystemColors.Control
        Me.TBResultPERSH2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBResultPERSH2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultPERSH2.Enabled = False
        Me.TBResultPERSH2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultPERSH2.Location = New System.Drawing.Point(703, 3)
        Me.TBResultPERSH2.Multiline = True
        Me.TBResultPERSH2.Name = "TBResultPERSH2"
        Me.TBResultPERSH2.Size = New System.Drawing.Size(144, 88)
        Me.TBResultPERSH2.TabIndex = 24
        '
        'TBResultPERS2
        '
        Me.TBResultPERS2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultPERS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultPERS2.Enabled = False
        Me.TBResultPERS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultPERS2.Location = New System.Drawing.Point(853, 3)
        Me.TBResultPERS2.Multiline = True
        Me.TBResultPERS2.Name = "TBResultPERS2"
        Me.TBResultPERS2.Size = New System.Drawing.Size(244, 88)
        Me.TBResultPERS2.TabIndex = 23
        '
        'TBResultPERS
        '
        Me.TBResultPERS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultPERS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultPERS.Enabled = False
        Me.TBResultPERS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultPERS.Location = New System.Drawing.Point(453, 3)
        Me.TBResultPERS.Multiline = True
        Me.TBResultPERS.Name = "TBResultPERS"
        Me.TBResultPERS.Size = New System.Drawing.Size(244, 88)
        Me.TBResultPERS.TabIndex = 22
        '
        'TBResultPREST
        '
        Me.TBResultPREST.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultPREST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultPREST.Enabled = False
        Me.TBResultPREST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultPREST.Location = New System.Drawing.Point(3, 3)
        Me.TBResultPREST.Multiline = True
        Me.TBResultPREST.Name = "TBResultPREST"
        Me.TBResultPREST.Size = New System.Drawing.Size(294, 88)
        Me.TBResultPREST.TabIndex = 20
        '
        'TBResultPERSH
        '
        Me.TBResultPERSH.BackColor = System.Drawing.SystemColors.Control
        Me.TBResultPERSH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBResultPERSH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultPERSH.Enabled = False
        Me.TBResultPERSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultPERSH.Location = New System.Drawing.Point(303, 3)
        Me.TBResultPERSH.Multiline = True
        Me.TBResultPERSH.Name = "TBResultPERSH"
        Me.TBResultPERSH.Size = New System.Drawing.Size(144, 88)
        Me.TBResultPERSH.TabIndex = 19
        '
        'SearchPrestaties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 502)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchPrestaties"
        Me.Text = "SearchPrestaties"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CMSpers.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.DGRECP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilterPER.ResumeLayout(False)
        Me.GroupFilterPER.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupFilterCOD.ResumeLayout(False)
        Me.GroupFilterCOD.PerformLayout()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.DGRECPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMScode.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DGRECP As DataGridView
    Friend WithEvents GroupFilterPER As GroupBox
    Friend WithEvents CBdienstN As CheckBox
    Friend WithEvents CBdienstJ As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltpernm As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupFilterCOD As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DGRECPR As DataGridView
    Friend WithEvents CBfilteryear As CheckBox
    Friend WithEvents Fltbonjr As NumericUpDown
    Friend WithEvents CMScode As ContextMenuStrip
    Friend WithEvents TSMInewPL As ToolStripMenuItem
    Friend WithEvents TSMIupdatePL As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSMIdeletePL As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Flttype As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltsector As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TBResultPREST As TextBox
    Friend WithEvents TBResultPERSH As TextBox
    Friend WithEvents TBResultPERS2 As TextBox
    Friend WithEvents TBResultPERS As TextBox
    Friend WithEvents TBResultPERSH2 As TextBox
End Class
