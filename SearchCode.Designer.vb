<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchCode))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBresultCode = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.GrBFilters = New System.Windows.Forms.GroupBox()
        Me.CBkmheffingN = New System.Windows.Forms.CheckBox()
        Me.CBkmheffingJ = New System.Windows.Forms.CheckBox()
        Me.CBgratisN = New System.Windows.Forms.CheckBox()
        Me.CBgratisJ = New System.Windows.Forms.CheckBox()
        Me.CBbesteldN = New System.Windows.Forms.CheckBox()
        Me.CBbesteldJ = New System.Windows.Forms.CheckBox()
        Me.CBstockisnulN = New System.Windows.Forms.CheckBox()
        Me.CBstockisnulJ = New System.Windows.Forms.CheckBox()
        Me.CBstockknulN = New System.Windows.Forms.CheckBox()
        Me.CBstockknulJ = New System.Windows.Forms.CheckBox()
        Me.CBnotstockN = New System.Windows.Forms.CheckBox()
        Me.CBnotstockJ = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.KmHeffing = New System.Windows.Forms.Label()
        Me.CBFltinresult = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltomsgroep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBFltGrp = New System.Windows.Forms.CheckBox()
        Me.CMBcodgp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltomscode = New System.Windows.Forms.TextBox()
        Me.Fltcode = New System.Windows.Forms.TextBox()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBnew = New System.Windows.Forms.ToolStripButton()
        Me.TSBedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.TSBverplaats = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBDeleteSelected = New System.Windows.Forms.ToolStripButton()
        Me.TSBverplaatsX = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBFilters.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NieuwToolStripMenuItem, Me.BewerkToolStripMenuItem, Me.ToolStripSeparator2, Me.VerwijderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 76)
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.NieuwToolStripMenuItem.Text = "Nieuw"
        Me.NieuwToolStripMenuItem.ToolTipText = "Nieuwe blanco code"
        '
        'BewerkToolStripMenuItem
        '
        Me.BewerkToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkToolStripMenuItem.Name = "BewerkToolStripMenuItem"
        Me.BewerkToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.BewerkToolStripMenuItem.Text = "Bewerk"
        Me.BewerkToolStripMenuItem.ToolTipText = "Bewerk de code"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(119, 6)
        '
        'VerwijderToolStripMenuItem
        '
        Me.VerwijderToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.VerwijderToolStripMenuItem.Name = "VerwijderToolStripMenuItem"
        Me.VerwijderToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VerwijderToolStripMenuItem.Text = "Verwijder"
        Me.VerwijderToolStripMenuItem.ToolTipText = "Verwijder de code"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1310, 462)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.TBresultCode, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1304, 63)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'TBresultCode
        '
        Me.TBresultCode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBresultCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBresultCode.Location = New System.Drawing.Point(3, 3)
        Me.TBresultCode.Multiline = True
        Me.TBresultCode.Name = "TBresultCode"
        Me.TBresultCode.Size = New System.Drawing.Size(428, 57)
        Me.TBresultCode.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GrBFilters, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 72)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1304, 387)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DGREC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(217, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1084, 381)
        Me.GroupBox1.TabIndex = 6
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
        Me.DGREC.Name = "DGREC"
        Me.DGREC.ReadOnly = True
        Me.DGREC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGREC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGREC.Size = New System.Drawing.Size(1078, 362)
        Me.DGREC.TabIndex = 1
        Me.DGREC.TabStop = False
        '
        'GrBFilters
        '
        Me.GrBFilters.AutoSize = True
        Me.GrBFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBFilters.Controls.Add(Me.CBkmheffingN)
        Me.GrBFilters.Controls.Add(Me.CBkmheffingJ)
        Me.GrBFilters.Controls.Add(Me.CBgratisN)
        Me.GrBFilters.Controls.Add(Me.CBgratisJ)
        Me.GrBFilters.Controls.Add(Me.CBbesteldN)
        Me.GrBFilters.Controls.Add(Me.CBbesteldJ)
        Me.GrBFilters.Controls.Add(Me.CBstockisnulN)
        Me.GrBFilters.Controls.Add(Me.CBstockisnulJ)
        Me.GrBFilters.Controls.Add(Me.CBstockknulN)
        Me.GrBFilters.Controls.Add(Me.CBstockknulJ)
        Me.GrBFilters.Controls.Add(Me.CBnotstockN)
        Me.GrBFilters.Controls.Add(Me.CBnotstockJ)
        Me.GrBFilters.Controls.Add(Me.Label10)
        Me.GrBFilters.Controls.Add(Me.Label9)
        Me.GrBFilters.Controls.Add(Me.KmHeffing)
        Me.GrBFilters.Controls.Add(Me.CBFltinresult)
        Me.GrBFilters.Controls.Add(Me.Label7)
        Me.GrBFilters.Controls.Add(Me.Label6)
        Me.GrBFilters.Controls.Add(Me.Label8)
        Me.GrBFilters.Controls.Add(Me.Label4)
        Me.GrBFilters.Controls.Add(Me.Fltomsgroep)
        Me.GrBFilters.Controls.Add(Me.Label3)
        Me.GrBFilters.Controls.Add(Me.CBFltGrp)
        Me.GrBFilters.Controls.Add(Me.CMBcodgp)
        Me.GrBFilters.Controls.Add(Me.Label5)
        Me.GrBFilters.Controls.Add(Me.Fltusernrq)
        Me.GrBFilters.Controls.Add(Me.BTN_FilterReset)
        Me.GrBFilters.Controls.Add(Me.Label2)
        Me.GrBFilters.Controls.Add(Me.Label1)
        Me.GrBFilters.Controls.Add(Me.Fltomscode)
        Me.GrBFilters.Controls.Add(Me.Fltcode)
        Me.GrBFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBFilters.Location = New System.Drawing.Point(3, 3)
        Me.GrBFilters.Name = "GrBFilters"
        Me.GrBFilters.Size = New System.Drawing.Size(208, 381)
        Me.GrBFilters.TabIndex = 5
        Me.GrBFilters.TabStop = False
        '
        'CBkmheffingN
        '
        Me.CBkmheffingN.AutoSize = True
        Me.CBkmheffingN.Location = New System.Drawing.Point(92, 230)
        Me.CBkmheffingN.Name = "CBkmheffingN"
        Me.CBkmheffingN.Size = New System.Drawing.Size(46, 17)
        Me.CBkmheffingN.TabIndex = 51
        Me.CBkmheffingN.Text = "Nee"
        Me.CBkmheffingN.UseVisualStyleBackColor = True
        '
        'CBkmheffingJ
        '
        Me.CBkmheffingJ.AutoSize = True
        Me.CBkmheffingJ.Location = New System.Drawing.Point(59, 230)
        Me.CBkmheffingJ.Name = "CBkmheffingJ"
        Me.CBkmheffingJ.Size = New System.Drawing.Size(37, 17)
        Me.CBkmheffingJ.TabIndex = 50
        Me.CBkmheffingJ.Text = "Ja"
        Me.CBkmheffingJ.UseVisualStyleBackColor = True
        '
        'CBgratisN
        '
        Me.CBgratisN.AutoSize = True
        Me.CBgratisN.Location = New System.Drawing.Point(92, 206)
        Me.CBgratisN.Name = "CBgratisN"
        Me.CBgratisN.Size = New System.Drawing.Size(46, 17)
        Me.CBgratisN.TabIndex = 49
        Me.CBgratisN.Text = "Nee"
        Me.CBgratisN.UseVisualStyleBackColor = True
        '
        'CBgratisJ
        '
        Me.CBgratisJ.AutoSize = True
        Me.CBgratisJ.Location = New System.Drawing.Point(59, 206)
        Me.CBgratisJ.Name = "CBgratisJ"
        Me.CBgratisJ.Size = New System.Drawing.Size(37, 17)
        Me.CBgratisJ.TabIndex = 48
        Me.CBgratisJ.Text = "Ja"
        Me.CBgratisJ.UseVisualStyleBackColor = True
        '
        'CBbesteldN
        '
        Me.CBbesteldN.AutoSize = True
        Me.CBbesteldN.Location = New System.Drawing.Point(92, 180)
        Me.CBbesteldN.Name = "CBbesteldN"
        Me.CBbesteldN.Size = New System.Drawing.Size(46, 17)
        Me.CBbesteldN.TabIndex = 47
        Me.CBbesteldN.Text = "Nee"
        Me.CBbesteldN.UseVisualStyleBackColor = True
        '
        'CBbesteldJ
        '
        Me.CBbesteldJ.AutoSize = True
        Me.CBbesteldJ.Location = New System.Drawing.Point(59, 180)
        Me.CBbesteldJ.Name = "CBbesteldJ"
        Me.CBbesteldJ.Size = New System.Drawing.Size(37, 17)
        Me.CBbesteldJ.TabIndex = 46
        Me.CBbesteldJ.Text = "Ja"
        Me.CBbesteldJ.UseVisualStyleBackColor = True
        '
        'CBstockisnulN
        '
        Me.CBstockisnulN.AutoSize = True
        Me.CBstockisnulN.Location = New System.Drawing.Point(92, 128)
        Me.CBstockisnulN.Name = "CBstockisnulN"
        Me.CBstockisnulN.Size = New System.Drawing.Size(46, 17)
        Me.CBstockisnulN.TabIndex = 45
        Me.CBstockisnulN.Text = "Nee"
        Me.CBstockisnulN.UseVisualStyleBackColor = True
        '
        'CBstockisnulJ
        '
        Me.CBstockisnulJ.AutoSize = True
        Me.CBstockisnulJ.Location = New System.Drawing.Point(59, 128)
        Me.CBstockisnulJ.Name = "CBstockisnulJ"
        Me.CBstockisnulJ.Size = New System.Drawing.Size(37, 17)
        Me.CBstockisnulJ.TabIndex = 44
        Me.CBstockisnulJ.Text = "Ja"
        Me.CBstockisnulJ.UseVisualStyleBackColor = True
        '
        'CBstockknulN
        '
        Me.CBstockknulN.AutoSize = True
        Me.CBstockknulN.Location = New System.Drawing.Point(92, 103)
        Me.CBstockknulN.Name = "CBstockknulN"
        Me.CBstockknulN.Size = New System.Drawing.Size(46, 17)
        Me.CBstockknulN.TabIndex = 43
        Me.CBstockknulN.Text = "Nee"
        Me.CBstockknulN.UseVisualStyleBackColor = True
        '
        'CBstockknulJ
        '
        Me.CBstockknulJ.AutoSize = True
        Me.CBstockknulJ.Location = New System.Drawing.Point(59, 103)
        Me.CBstockknulJ.Name = "CBstockknulJ"
        Me.CBstockknulJ.Size = New System.Drawing.Size(37, 17)
        Me.CBstockknulJ.TabIndex = 42
        Me.CBstockknulJ.Text = "Ja"
        Me.CBstockknulJ.UseVisualStyleBackColor = True
        '
        'CBnotstockN
        '
        Me.CBnotstockN.AutoSize = True
        Me.CBnotstockN.Location = New System.Drawing.Point(92, 155)
        Me.CBnotstockN.Name = "CBnotstockN"
        Me.CBnotstockN.Size = New System.Drawing.Size(46, 17)
        Me.CBnotstockN.TabIndex = 41
        Me.CBnotstockN.Text = "Nee"
        Me.CBnotstockN.UseVisualStyleBackColor = True
        '
        'CBnotstockJ
        '
        Me.CBnotstockJ.AutoSize = True
        Me.CBnotstockJ.Location = New System.Drawing.Point(59, 155)
        Me.CBnotstockJ.Name = "CBnotstockJ"
        Me.CBnotstockJ.Size = New System.Drawing.Size(37, 17)
        Me.CBnotstockJ.TabIndex = 40
        Me.CBnotstockJ.Text = "Ja"
        Me.CBnotstockJ.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Stock=0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Stock<0"
        '
        'KmHeffing
        '
        Me.KmHeffing.AutoSize = True
        Me.KmHeffing.Location = New System.Drawing.Point(6, 232)
        Me.KmHeffing.Name = "KmHeffing"
        Me.KmHeffing.Size = New System.Drawing.Size(42, 13)
        Me.KmHeffing.TabIndex = 35
        Me.KmHeffing.Text = "KmHef."
        '
        'CBFltinresult
        '
        Me.CBFltinresult.AutoSize = True
        Me.CBFltinresult.Checked = True
        Me.CBFltinresult.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBFltinresult.Location = New System.Drawing.Point(59, 285)
        Me.CBFltinresult.Name = "CBFltinresult"
        Me.CBFltinresult.Size = New System.Drawing.Size(124, 17)
        Me.CBFltinresult.TabIndex = 33
        Me.CBFltinresult.Text = "Geen ""Oude Codes"""
        Me.CBFltinresult.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Besteld"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "GeenSt."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Gratis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Groep"
        '
        'Fltomsgroep
        '
        Me.Fltomsgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomsgroep.Location = New System.Drawing.Point(59, 25)
        Me.Fltomsgroep.Name = "Fltomsgroep"
        Me.Fltomsgroep.Size = New System.Drawing.Size(66, 20)
        Me.Fltomsgroep.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Groep"
        Me.Label3.Visible = False
        '
        'CBFltGrp
        '
        Me.CBFltGrp.AutoSize = True
        Me.CBFltGrp.Checked = True
        Me.CBFltGrp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBFltGrp.Location = New System.Drawing.Point(43, 320)
        Me.CBFltGrp.Name = "CBFltGrp"
        Me.CBFltGrp.Size = New System.Drawing.Size(15, 14)
        Me.CBFltGrp.TabIndex = 23
        Me.CBFltGrp.UseVisualStyleBackColor = True
        Me.CBFltGrp.Visible = False
        '
        'CMBcodgp
        '
        Me.CMBcodgp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBcodgp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMBcodgp.FormattingEnabled = True
        Me.CMBcodgp.Location = New System.Drawing.Point(58, 317)
        Me.CMBcodgp.Name = "CMBcodgp"
        Me.CMBcodgp.Size = New System.Drawing.Size(144, 21)
        Me.CMBcodgp.TabIndex = 10
        Me.CMBcodgp.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(59, 253)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 14
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(165, 10)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 17
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "OmsCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Code"
        '
        'Fltomscode
        '
        Me.Fltomscode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomscode.Location = New System.Drawing.Point(59, 77)
        Me.Fltomscode.Name = "Fltomscode"
        Me.Fltomscode.Size = New System.Drawing.Size(66, 20)
        Me.Fltomscode.TabIndex = 13
        '
        'Fltcode
        '
        Me.Fltcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltcode.Location = New System.Drawing.Point(59, 52)
        Me.Fltcode.Name = "Fltcode"
        Me.Fltcode.Size = New System.Drawing.Size(66, 20)
        Me.Fltcode.TabIndex = 12
        '
        'TSBexit
        '
        Me.TSBexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBexit.ForeColor = System.Drawing.SystemColors.ControlText
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
        'TSBedit
        '
        Me.TSBedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBedit.Image = CType(resources.GetObject("TSBedit.Image"), System.Drawing.Image)
        Me.TSBedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBedit.Name = "TSBedit"
        Me.TSBedit.Size = New System.Drawing.Size(28, 28)
        Me.TSBedit.Text = "Editeer"
        Me.TSBedit.ToolTipText = "Bewerk"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel5.Text = "   "
        '
        'TSBdelete
        '
        Me.TSBdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBdelete.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSBdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdelete.Name = "TSBdelete"
        Me.TSBdelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBdelete.Text = "Verwijder"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
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
        'TSBverplaats
        '
        Me.TSBverplaats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSBverplaats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBverplaats.Image = Global.Bon2017.My.Resources.Resources.itemnext
        Me.TSBverplaats.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBverplaats.Name = "TSBverplaats"
        Me.TSBverplaats.Size = New System.Drawing.Size(28, 28)
        Me.TSBverplaats.Text = "Verplaats geselecteerde codes"
        Me.TSBverplaats.ToolTipText = "Verplaats selectie"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel2, Me.ToolStripLabel5, Me.TSBdelete, Me.ToolStripLabel1, Me.TSBDeleteSelected, Me.ToolStripLabel3, Me.TSBexport, Me.TSBverplaatsX, Me.TSBverplaats})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1310, 31)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
        '
        'TSBDeleteSelected
        '
        Me.TSBDeleteSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBDeleteSelected.Image = Global.Bon2017.My.Resources.Resources.recycle
        Me.TSBDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBDeleteSelected.Name = "TSBDeleteSelected"
        Me.TSBDeleteSelected.Size = New System.Drawing.Size(28, 28)
        Me.TSBDeleteSelected.Text = "ToolStripButton1"
        Me.TSBDeleteSelected.ToolTipText = "Verwijder ALLE geselecteerde codes!"
        '
        'TSBverplaatsX
        '
        Me.TSBverplaatsX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSBverplaatsX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBverplaatsX.Image = Global.Bon2017.My.Resources.Resources.add2
        Me.TSBverplaatsX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBverplaatsX.Name = "TSBverplaatsX"
        Me.TSBverplaatsX.Size = New System.Drawing.Size(28, 28)
        Me.TSBverplaatsX.Text = "Verplaats selectie naar VASTE code"
        Me.TSBverplaatsX.ToolTipText = "Verplaats selectie naar VASTE code"
        '
        'SearchCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 493)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchCode"
        Me.Text = "Code: overzicht"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBFilters.ResumeLayout(False)
        Me.GrBFilters.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBnew As ToolStripButton
    Friend WithEvents TSBedit As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents TSBverplaats As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TSBDeleteSelected As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TBresultCode As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents GrBFilters As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltomsgroep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBFltGrp As CheckBox
    Friend WithEvents CMBcodgp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltomscode As TextBox
    Friend WithEvents Fltcode As TextBox
    Friend WithEvents CBFltinresult As CheckBox
    Friend WithEvents KmHeffing As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TSBverplaatsX As ToolStripButton
    Friend WithEvents CBnotstockN As CheckBox
    Friend WithEvents CBnotstockJ As CheckBox
    Friend WithEvents CBstockknulN As CheckBox
    Friend WithEvents CBstockknulJ As CheckBox
    Friend WithEvents CBstockisnulN As CheckBox
    Friend WithEvents CBstockisnulJ As CheckBox
    Friend WithEvents CBkmheffingN As CheckBox
    Friend WithEvents CBkmheffingJ As CheckBox
    Friend WithEvents CBgratisN As CheckBox
    Friend WithEvents CBgratisJ As CheckBox
    Friend WithEvents CBbesteldN As CheckBox
    Friend WithEvents CBbesteldJ As CheckBox
End Class
