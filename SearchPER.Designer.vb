<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPER))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBnew = New System.Windows.Forms.ToolStripButton()
        Me.TSBedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelecteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselecteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.GrBFilters = New System.Windows.Forms.GroupBox()
        Me.CBbediendeN = New System.Windows.Forms.CheckBox()
        Me.CBbediendeJ = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBdienstN = New System.Windows.Forms.CheckBox()
        Me.CBdienstJ = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fltpernm = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderGeselecteerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel2, Me.ToolStripLabel5, Me.TSBdelete, Me.ToolStripLabel1, Me.TSBexport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1013, 31)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NieuwToolStripMenuItem, Me.BewerkToolStripMenuItem, Me.ToolStripSeparator1, Me.SelecteerToolStripMenuItem, Me.DeselecteerToolStripMenuItem, Me.ToolStripSeparator2, Me.VerwijderToolStripMenuItem, Me.ToolStripSeparator3, Me.VerwijderGeselecteerdeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 176)
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.NieuwToolStripMenuItem.Text = "Nieuw"
        Me.NieuwToolStripMenuItem.ToolTipText = "Nieuwe blanco code"
        '
        'BewerkToolStripMenuItem
        '
        Me.BewerkToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkToolStripMenuItem.Name = "BewerkToolStripMenuItem"
        Me.BewerkToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.BewerkToolStripMenuItem.Text = "Bewerk"
        Me.BewerkToolStripMenuItem.ToolTipText = "Bewerk de code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'SelecteerToolStripMenuItem
        '
        Me.SelecteerToolStripMenuItem.Name = "SelecteerToolStripMenuItem"
        Me.SelecteerToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SelecteerToolStripMenuItem.Text = "Selectie InDienst"
        '
        'DeselecteerToolStripMenuItem
        '
        Me.DeselecteerToolStripMenuItem.Name = "DeselecteerToolStripMenuItem"
        Me.DeselecteerToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DeselecteerToolStripMenuItem.Text = "Selectie UitDienst"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'VerwijderToolStripMenuItem
        '
        Me.VerwijderToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.VerwijderToolStripMenuItem.Name = "VerwijderToolStripMenuItem"
        Me.VerwijderToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VerwijderToolStripMenuItem.Text = "Verwijder"
        Me.VerwijderToolStripMenuItem.ToolTipText = "Verwijder de code"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GrBFilters, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1013, 396)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(155, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 371.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(849, 371)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.DGREC)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(843, 365)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
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
        Me.DGREC.Size = New System.Drawing.Size(837, 346)
        Me.DGREC.TabIndex = 1
        Me.DGREC.TabStop = False
        '
        'GrBFilters
        '
        Me.GrBFilters.AutoSize = True
        Me.GrBFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBFilters.Controls.Add(Me.CBbediendeN)
        Me.GrBFilters.Controls.Add(Me.CBbediendeJ)
        Me.GrBFilters.Controls.Add(Me.Label1)
        Me.GrBFilters.Controls.Add(Me.CBdienstN)
        Me.GrBFilters.Controls.Add(Me.CBdienstJ)
        Me.GrBFilters.Controls.Add(Me.Label6)
        Me.GrBFilters.Controls.Add(Me.BTN_FilterReset)
        Me.GrBFilters.Controls.Add(Me.Label4)
        Me.GrBFilters.Controls.Add(Me.Fltusernrq)
        Me.GrBFilters.Controls.Add(Me.Label5)
        Me.GrBFilters.Controls.Add(Me.Fltpernm)
        Me.GrBFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBFilters.Location = New System.Drawing.Point(3, 3)
        Me.GrBFilters.Name = "GrBFilters"
        Me.GrBFilters.Size = New System.Drawing.Size(146, 390)
        Me.GrBFilters.TabIndex = 1
        Me.GrBFilters.TabStop = False
        '
        'CBbediendeN
        '
        Me.CBbediendeN.AutoSize = True
        Me.CBbediendeN.Location = New System.Drawing.Point(94, 137)
        Me.CBbediendeN.Name = "CBbediendeN"
        Me.CBbediendeN.Size = New System.Drawing.Size(46, 17)
        Me.CBbediendeN.TabIndex = 48
        Me.CBbediendeN.Text = "Nee"
        Me.CBbediendeN.UseVisualStyleBackColor = True
        '
        'CBbediendeJ
        '
        Me.CBbediendeJ.AutoSize = True
        Me.CBbediendeJ.Location = New System.Drawing.Point(61, 137)
        Me.CBbediendeJ.Name = "CBbediendeJ"
        Me.CBbediendeJ.Size = New System.Drawing.Size(37, 17)
        Me.CBbediendeJ.TabIndex = 47
        Me.CBbediendeJ.Text = "Ja"
        Me.CBbediendeJ.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Bediende"
        '
        'CBdienstN
        '
        Me.CBdienstN.AutoSize = True
        Me.CBdienstN.Location = New System.Drawing.Point(94, 115)
        Me.CBdienstN.Name = "CBdienstN"
        Me.CBdienstN.Size = New System.Drawing.Size(46, 17)
        Me.CBdienstN.TabIndex = 45
        Me.CBdienstN.Text = "Nee"
        Me.CBdienstN.UseVisualStyleBackColor = True
        '
        'CBdienstJ
        '
        Me.CBdienstJ.AutoSize = True
        Me.CBdienstJ.Location = New System.Drawing.Point(61, 115)
        Me.CBdienstJ.Name = "CBdienstJ"
        Me.CBdienstJ.Size = New System.Drawing.Size(37, 17)
        Me.CBdienstJ.TabIndex = 44
        Me.CBdienstJ.Text = "Ja"
        Me.CBdienstJ.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "InDienst"
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(93, 13)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 17
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Naam"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(61, 83)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Wie"
        '
        'Fltpernm
        '
        Me.Fltpernm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltpernm.Location = New System.Drawing.Point(61, 54)
        Me.Fltpernm.Name = "Fltpernm"
        Me.Fltpernm.Size = New System.Drawing.Size(66, 20)
        Me.Fltpernm.TabIndex = 11
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        'VerwijderGeselecteerdeToolStripMenuItem
        '
        Me.VerwijderGeselecteerdeToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.recycle
        Me.VerwijderGeselecteerdeToolStripMenuItem.Name = "VerwijderGeselecteerdeToolStripMenuItem"
        Me.VerwijderGeselecteerdeToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VerwijderGeselecteerdeToolStripMenuItem.Text = "Verwijder geselecteerde"
        '
        'SearchPER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 427)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchPER"
        Me.Text = "Personeel: Overzicht"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBFilters.ResumeLayout(False)
        Me.GrBFilters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBnew As ToolStripButton
    Friend WithEvents TSBedit As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SelecteerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeselecteerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents GrBFilters As GroupBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Fltpernm As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CBbediendeN As CheckBox
    Friend WithEvents CBbediendeJ As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBdienstN As CheckBox
    Friend WithEvents CBdienstJ As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents VerwijderGeselecteerdeToolStripMenuItem As ToolStripMenuItem
End Class
