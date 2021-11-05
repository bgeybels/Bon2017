<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStockHist
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.GrBFilters = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FltOmschrijving = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltomsgroep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBFltGrp = New System.Windows.Forms.CheckBox()
        Me.CMBcodgp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltomscode = New System.Windows.Forms.TextBox()
        Me.Fltcode = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.ToolStripButton1, Me.TSBexport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1260, 31)
        Me.ToolStrip1.TabIndex = 7
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1260, 489)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DGREC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(256, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 483)
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
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 16)
        Me.DGREC.MultiSelect = False
        Me.DGREC.Name = "DGREC"
        Me.DGREC.ReadOnly = True
        Me.DGREC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGREC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGREC.Size = New System.Drawing.Size(995, 464)
        Me.DGREC.TabIndex = 3
        Me.DGREC.TabStop = False
        '
        'GrBFilters
        '
        Me.GrBFilters.AutoSize = True
        Me.GrBFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBFilters.Controls.Add(Me.Label6)
        Me.GrBFilters.Controls.Add(Me.FltOmschrijving)
        Me.GrBFilters.Controls.Add(Me.Label5)
        Me.GrBFilters.Controls.Add(Me.Fltusernrq)
        Me.GrBFilters.Controls.Add(Me.Label4)
        Me.GrBFilters.Controls.Add(Me.Fltomsgroep)
        Me.GrBFilters.Controls.Add(Me.Label3)
        Me.GrBFilters.Controls.Add(Me.CBFltGrp)
        Me.GrBFilters.Controls.Add(Me.CMBcodgp)
        Me.GrBFilters.Controls.Add(Me.Label2)
        Me.GrBFilters.Controls.Add(Me.Label1)
        Me.GrBFilters.Controls.Add(Me.Fltomscode)
        Me.GrBFilters.Controls.Add(Me.Fltcode)
        Me.GrBFilters.Controls.Add(Me.BTN_FilterReset)
        Me.GrBFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBFilters.Location = New System.Drawing.Point(3, 3)
        Me.GrBFilters.Name = "GrBFilters"
        Me.GrBFilters.Size = New System.Drawing.Size(247, 483)
        Me.GrBFilters.TabIndex = 3
        Me.GrBFilters.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Omschrijving"
        '
        'FltOmschrijving
        '
        Me.FltOmschrijving.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltOmschrijving.Location = New System.Drawing.Point(102, 119)
        Me.FltOmschrijving.Name = "FltOmschrijving"
        Me.FltOmschrijving.Size = New System.Drawing.Size(66, 20)
        Me.FltOmschrijving.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "LaatsteAanpassing"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(102, 145)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Groep"
        '
        'Fltomsgroep
        '
        Me.Fltomsgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomsgroep.Location = New System.Drawing.Point(102, 93)
        Me.Fltomsgroep.Name = "Fltomsgroep"
        Me.Fltomsgroep.Size = New System.Drawing.Size(66, 20)
        Me.Fltomsgroep.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 70)
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
        Me.CBFltGrp.Location = New System.Drawing.Point(81, 96)
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
        Me.CMBcodgp.Location = New System.Drawing.Point(102, 66)
        Me.CMBcodgp.Name = "CMBcodgp"
        Me.CMBcodgp.Size = New System.Drawing.Size(139, 21)
        Me.CMBcodgp.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "OmsCode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Code"
        '
        'Fltomscode
        '
        Me.Fltomscode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomscode.Location = New System.Drawing.Point(102, 40)
        Me.Fltomscode.Name = "Fltomscode"
        Me.Fltomscode.Size = New System.Drawing.Size(66, 20)
        Me.Fltomscode.TabIndex = 24
        '
        'Fltcode
        '
        Me.Fltcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltcode.Location = New System.Drawing.Point(102, 14)
        Me.Fltcode.Name = "Fltcode"
        Me.Fltcode.Size = New System.Drawing.Size(66, 20)
        Me.Fltcode.TabIndex = 22
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(206, 14)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 17
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'SearchStockHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 520)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchStockHist"
        Me.Text = "Historiek Stock"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBFilters.ResumeLayout(False)
        Me.GrBFilters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents GrBFilters As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FltOmschrijving As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltomsgroep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBFltGrp As CheckBox
    Friend WithEvents CMBcodgp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltomscode As TextBox
    Friend WithEvents Fltcode As TextBox
    Friend WithEvents BTN_FilterReset As Button
End Class
