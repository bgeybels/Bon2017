<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStock
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrBFilters = New System.Windows.Forms.GroupBox()
        Me.CBnotstockN = New System.Windows.Forms.CheckBox()
        Me.CBnotstockJ = New System.Windows.Forms.CheckBox()
        Me.CBbesteldN = New System.Windows.Forms.CheckBox()
        Me.CBbesteldJ = New System.Windows.Forms.CheckBox()
        Me.CBminstockN = New System.Windows.Forms.CheckBox()
        Me.CBminstockJ = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Fltlev = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Fltplmagazijn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltomsgroep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBFltGrp = New System.Windows.Forms.CheckBox()
        Me.CMBcodgp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltomscode = New System.Windows.Forms.TextBox()
        Me.Fltcode = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BewerkCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrBFilters.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.ToolStripLabel5, Me.ToolStripButton1, Me.TSBexport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1416, 31)
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
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel5.Text = "   "
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Bon2017.My.Resources.Resources.print
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GrBFilters, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 429.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1416, 429)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'GrBFilters
        '
        Me.GrBFilters.AutoSize = True
        Me.GrBFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBFilters.Controls.Add(Me.CBnotstockN)
        Me.GrBFilters.Controls.Add(Me.CBnotstockJ)
        Me.GrBFilters.Controls.Add(Me.CBbesteldN)
        Me.GrBFilters.Controls.Add(Me.CBbesteldJ)
        Me.GrBFilters.Controls.Add(Me.CBminstockN)
        Me.GrBFilters.Controls.Add(Me.CBminstockJ)
        Me.GrBFilters.Controls.Add(Me.Label10)
        Me.GrBFilters.Controls.Add(Me.Label9)
        Me.GrBFilters.Controls.Add(Me.Fltlev)
        Me.GrBFilters.Controls.Add(Me.Label8)
        Me.GrBFilters.Controls.Add(Me.Fltplmagazijn)
        Me.GrBFilters.Controls.Add(Me.Label7)
        Me.GrBFilters.Controls.Add(Me.Label6)
        Me.GrBFilters.Controls.Add(Me.Label4)
        Me.GrBFilters.Controls.Add(Me.Fltomsgroep)
        Me.GrBFilters.Controls.Add(Me.Label3)
        Me.GrBFilters.Controls.Add(Me.CBFltGrp)
        Me.GrBFilters.Controls.Add(Me.CMBcodgp)
        Me.GrBFilters.Controls.Add(Me.Label5)
        Me.GrBFilters.Controls.Add(Me.Fltusernrq)
        Me.GrBFilters.Controls.Add(Me.Label2)
        Me.GrBFilters.Controls.Add(Me.Label1)
        Me.GrBFilters.Controls.Add(Me.Fltomscode)
        Me.GrBFilters.Controls.Add(Me.Fltcode)
        Me.GrBFilters.Controls.Add(Me.BTN_FilterReset)
        Me.GrBFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBFilters.Location = New System.Drawing.Point(3, 3)
        Me.GrBFilters.Name = "GrBFilters"
        Me.GrBFilters.Size = New System.Drawing.Size(248, 423)
        Me.GrBFilters.TabIndex = 3
        Me.GrBFilters.TabStop = False
        '
        'CBnotstockN
        '
        Me.CBnotstockN.AutoSize = True
        Me.CBnotstockN.Location = New System.Drawing.Point(104, 39)
        Me.CBnotstockN.Name = "CBnotstockN"
        Me.CBnotstockN.Size = New System.Drawing.Size(46, 17)
        Me.CBnotstockN.TabIndex = 77
        Me.CBnotstockN.Text = "Nee"
        Me.CBnotstockN.UseVisualStyleBackColor = True
        '
        'CBnotstockJ
        '
        Me.CBnotstockJ.AutoSize = True
        Me.CBnotstockJ.Location = New System.Drawing.Point(71, 39)
        Me.CBnotstockJ.Name = "CBnotstockJ"
        Me.CBnotstockJ.Size = New System.Drawing.Size(37, 17)
        Me.CBnotstockJ.TabIndex = 76
        Me.CBnotstockJ.Text = "Ja"
        Me.CBnotstockJ.UseVisualStyleBackColor = True
        '
        'CBbesteldN
        '
        Me.CBbesteldN.AutoSize = True
        Me.CBbesteldN.Location = New System.Drawing.Point(104, 15)
        Me.CBbesteldN.Name = "CBbesteldN"
        Me.CBbesteldN.Size = New System.Drawing.Size(46, 17)
        Me.CBbesteldN.TabIndex = 75
        Me.CBbesteldN.Text = "Nee"
        Me.CBbesteldN.UseVisualStyleBackColor = True
        '
        'CBbesteldJ
        '
        Me.CBbesteldJ.AutoSize = True
        Me.CBbesteldJ.Location = New System.Drawing.Point(71, 15)
        Me.CBbesteldJ.Name = "CBbesteldJ"
        Me.CBbesteldJ.Size = New System.Drawing.Size(37, 17)
        Me.CBbesteldJ.TabIndex = 74
        Me.CBbesteldJ.Text = "Ja"
        Me.CBbesteldJ.UseVisualStyleBackColor = True
        '
        'CBminstockN
        '
        Me.CBminstockN.AutoSize = True
        Me.CBminstockN.Location = New System.Drawing.Point(104, 261)
        Me.CBminstockN.Name = "CBminstockN"
        Me.CBminstockN.Size = New System.Drawing.Size(46, 17)
        Me.CBminstockN.TabIndex = 56
        Me.CBminstockN.Text = "Nee"
        Me.CBminstockN.UseVisualStyleBackColor = True
        '
        'CBminstockJ
        '
        Me.CBminstockJ.AutoSize = True
        Me.CBminstockJ.Location = New System.Drawing.Point(71, 261)
        Me.CBminstockJ.Name = "CBminstockJ"
        Me.CBminstockJ.Size = New System.Drawing.Size(37, 17)
        Me.CBminstockJ.TabIndex = 55
        Me.CBminstockJ.Text = "Ja"
        Me.CBminstockJ.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Stock<Min"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "LEV"
        '
        'Fltlev
        '
        Me.Fltlev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltlev.Location = New System.Drawing.Point(72, 92)
        Me.Fltlev.Name = "Fltlev"
        Me.Fltlev.Size = New System.Drawing.Size(66, 20)
        Me.Fltlev.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "PLMagazijn"
        '
        'Fltplmagazijn
        '
        Me.Fltplmagazijn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltplmagazijn.Location = New System.Drawing.Point(72, 66)
        Me.Fltplmagazijn.Name = "Fltplmagazijn"
        Me.Fltplmagazijn.Size = New System.Drawing.Size(66, 20)
        Me.Fltplmagazijn.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Besteld"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "GeenStock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Groep"
        '
        'Fltomsgroep
        '
        Me.Fltomsgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomsgroep.Location = New System.Drawing.Point(72, 147)
        Me.Fltomsgroep.Name = "Fltomsgroep"
        Me.Fltomsgroep.Size = New System.Drawing.Size(66, 20)
        Me.Fltomsgroep.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Groep"
        '
        'CBFltGrp
        '
        Me.CBFltGrp.AutoSize = True
        Me.CBFltGrp.Checked = True
        Me.CBFltGrp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBFltGrp.Location = New System.Drawing.Point(53, 124)
        Me.CBFltGrp.Name = "CBFltGrp"
        Me.CBFltGrp.Size = New System.Drawing.Size(15, 14)
        Me.CBFltGrp.TabIndex = 39
        Me.CBFltGrp.TabStop = False
        Me.CBFltGrp.UseVisualStyleBackColor = True
        '
        'CMBcodgp
        '
        Me.CMBcodgp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBcodgp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMBcodgp.FormattingEnabled = True
        Me.CMBcodgp.Location = New System.Drawing.Point(72, 120)
        Me.CMBcodgp.Name = "CMBcodgp"
        Me.CMBcodgp.Size = New System.Drawing.Size(170, 21)
        Me.CMBcodgp.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "LaatsteUPd."
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(72, 225)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(120, 20)
        Me.Fltusernrq.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "OmsCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Code"
        '
        'Fltomscode
        '
        Me.Fltomscode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomscode.Location = New System.Drawing.Point(72, 199)
        Me.Fltomscode.Name = "Fltomscode"
        Me.Fltomscode.Size = New System.Drawing.Size(66, 20)
        Me.Fltomscode.TabIndex = 24
        '
        'Fltcode
        '
        Me.Fltcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltcode.Location = New System.Drawing.Point(72, 173)
        Me.Fltcode.Name = "Fltcode"
        Me.Fltcode.Size = New System.Drawing.Size(66, 20)
        Me.Fltcode.TabIndex = 22
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(207, 12)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 17
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DGREC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(257, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1156, 423)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DGREC
        '
        Me.DGREC.AllowUserToAddRows = False
        Me.DGREC.AllowUserToDeleteRows = False
        Me.DGREC.AllowUserToOrderColumns = True
        Me.DGREC.AllowUserToResizeRows = False
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 16)
        Me.DGREC.MultiSelect = False
        Me.DGREC.Name = "DGREC"
        Me.DGREC.ReadOnly = True
        Me.DGREC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGREC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGREC.Size = New System.Drawing.Size(1150, 404)
        Me.DGREC.TabIndex = 3
        Me.DGREC.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NieuwToolStripMenuItem, Me.ToolStripSeparator1, Me.BewerkCodeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 54)
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NieuwToolStripMenuItem.Text = "Nieuw"
        Me.NieuwToolStripMenuItem.ToolTipText = "Nieuwe blanco code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'BewerkCodeToolStripMenuItem
        '
        Me.BewerkCodeToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkCodeToolStripMenuItem.Name = "BewerkCodeToolStripMenuItem"
        Me.BewerkCodeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BewerkCodeToolStripMenuItem.Text = "Bewerk Code"
        '
        'SearchStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 460)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchStock"
        Me.Text = "Stockbeheer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GrBFilters.ResumeLayout(False)
        Me.GrBFilters.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBnew As ToolStripButton
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrBFilters As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Fltlev As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Fltplmagazijn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltomsgroep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBFltGrp As CheckBox
    Friend WithEvents CMBcodgp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltomscode As TextBox
    Friend WithEvents Fltcode As TextBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents BewerkCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CBminstockN As CheckBox
    Friend WithEvents CBminstockJ As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CBnotstockN As CheckBox
    Friend WithEvents CBnotstockJ As CheckBox
    Friend WithEvents CBbesteldN As CheckBox
    Friend WithEvents CBbesteldJ As CheckBox
End Class
