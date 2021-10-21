<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchfakt
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBprint = New System.Windows.Forms.ToolStripButton()
        Me.TSBtopten = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrBDetailBon = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToonFaktuurlijnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.CBfilterwyear = New System.Windows.Forms.CheckBox()
        Me.FltWJR = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.CBfilteryear = New System.Windows.Forms.CheckBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Fltbonjr = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fltnr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FltCBcnr = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltwerf = New System.Windows.Forms.TextBox()
        Me.Fltknaam = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBResultFAKTL = New System.Windows.Forms.TextBox()
        Me.TBResultFAKT = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrBDetailBon.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.FltWJR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3, Me.TSBprint, Me.TSBtopten})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1268, 31)
        Me.ToolStrip1.TabIndex = 5
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
        'TSBdelete
        '
        Me.TSBdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBdelete.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSBdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdelete.Name = "TSBdelete"
        Me.TSBdelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBdelete.Text = "Verwijder"
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
        'TSBprint
        '
        Me.TSBprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBprint.Image = Global.Bon2017.My.Resources.Resources.print
        Me.TSBprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBprint.Name = "TSBprint"
        Me.TSBprint.Size = New System.Drawing.Size(28, 28)
        Me.TSBprint.Text = "Print"
        '
        'TSBtopten
        '
        Me.TSBtopten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtopten.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtopten.Name = "TSBtopten"
        Me.TSBtopten.Size = New System.Drawing.Size(23, 28)
        Me.TSBtopten.Text = "ToolStripButton1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrBDetailBon, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1268, 447)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'GrBDetailBon
        '
        Me.GrBDetailBon.AutoSize = True
        Me.GrBDetailBon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBDetailBon.Controls.Add(Me.DGREC)
        Me.GrBDetailBon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBDetailBon.Location = New System.Drawing.Point(3, 165)
        Me.GrBDetailBon.Name = "GrBDetailBon"
        Me.GrBDetailBon.Size = New System.Drawing.Size(1262, 279)
        Me.GrBDetailBon.TabIndex = 14
        Me.GrBDetailBon.TabStop = False
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 16)
        Me.DGREC.MultiSelect = False
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(1256, 260)
        Me.DGREC.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToonFaktuurlijnenToolStripMenuItem, Me.ToolStripSeparator1, Me.VerwijderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(241, 54)
        '
        'ToonFaktuurlijnenToolStripMenuItem
        '
        Me.ToonFaktuurlijnenToolStripMenuItem.Name = "ToonFaktuurlijnenToolStripMenuItem"
        Me.ToonFaktuurlijnenToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ToonFaktuurlijnenToolStripMenuItem.Text = "Toon Faktuurlijnen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'VerwijderToolStripMenuItem
        '
        Me.VerwijderToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.VerwijderToolStripMenuItem.Name = "VerwijderToolStripMenuItem"
        Me.VerwijderToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VerwijderToolStripMenuItem.Text = "Verwijder geselecteerde Faktuur"
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.Controls.Add(Me.CBfilterwyear)
        Me.GroupFilter.Controls.Add(Me.FltWJR)
        Me.GroupFilter.Controls.Add(Me.Label3)
        Me.GroupFilter.Controls.Add(Me.Fltusernrq)
        Me.GroupFilter.Controls.Add(Me.CBfilteryear)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Controls.Add(Me.Fltbonjr)
        Me.GroupFilter.Controls.Add(Me.Label6)
        Me.GroupFilter.Controls.Add(Me.Fltnr)
        Me.GroupFilter.Controls.Add(Me.Label11)
        Me.GroupFilter.Controls.Add(Me.FltCBcnr)
        Me.GroupFilter.Controls.Add(Me.Label2)
        Me.GroupFilter.Controls.Add(Me.Label1)
        Me.GroupFilter.Controls.Add(Me.Fltwerf)
        Me.GroupFilter.Controls.Add(Me.Fltknaam)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(1262, 61)
        Me.GroupFilter.TabIndex = 12
        Me.GroupFilter.TabStop = False
        '
        'CBfilterwyear
        '
        Me.CBfilterwyear.AutoSize = True
        Me.CBfilterwyear.Location = New System.Drawing.Point(193, 18)
        Me.CBfilterwyear.Name = "CBfilterwyear"
        Me.CBfilterwyear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilterwyear.TabIndex = 35
        Me.CBfilterwyear.UseVisualStyleBackColor = True
        '
        'FltWJR
        '
        Me.FltWJR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltWJR.Location = New System.Drawing.Point(134, 15)
        Me.FltWJR.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.FltWJR.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.FltWJR.Name = "FltWJR"
        Me.FltWJR.Size = New System.Drawing.Size(56, 20)
        Me.FltWJR.TabIndex = 34
        Me.FltWJR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FltWJR.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(667, 14)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 32
        '
        'CBfilteryear
        '
        Me.CBfilteryear.AutoSize = True
        Me.CBfilteryear.Checked = True
        Me.CBfilteryear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBfilteryear.Location = New System.Drawing.Point(110, 17)
        Me.CBfilteryear.Name = "CBfilteryear"
        Me.CBfilteryear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilteryear.TabIndex = 31
        Me.CBfilteryear.UseVisualStyleBackColor = True
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(0, 7)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 30
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Fltbonjr
        '
        Me.Fltbonjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonjr.Location = New System.Drawing.Point(51, 14)
        Me.Fltbonjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltbonjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltbonjr.Name = "Fltbonjr"
        Me.Fltbonjr.Size = New System.Drawing.Size(56, 20)
        Me.Fltbonjr.TabIndex = 25
        Me.Fltbonjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltbonjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "BonNr"
        '
        'Fltnr
        '
        Me.Fltnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltnr.Location = New System.Drawing.Point(577, 14)
        Me.Fltnr.Name = "Fltnr"
        Me.Fltnr.Size = New System.Drawing.Size(53, 20)
        Me.Fltnr.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "CNr"
        '
        'FltCBcnr
        '
        Me.FltCBcnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBcnr.FormattingEnabled = True
        Me.FltCBcnr.Location = New System.Drawing.Point(462, 14)
        Me.FltCBcnr.Name = "FltCBcnr"
        Me.FltCBcnr.Size = New System.Drawing.Size(64, 21)
        Me.FltCBcnr.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Werf"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Klant"
        '
        'Fltwerf
        '
        Me.Fltwerf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltwerf.Location = New System.Drawing.Point(363, 14)
        Me.Fltwerf.Name = "Fltwerf"
        Me.Fltwerf.Size = New System.Drawing.Size(65, 20)
        Me.Fltwerf.TabIndex = 7
        '
        'Fltknaam
        '
        Me.Fltknaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltknaam.Location = New System.Drawing.Point(254, 14)
        Me.Fltknaam.Name = "Fltknaam"
        Me.Fltknaam.Size = New System.Drawing.Size(66, 20)
        Me.Fltknaam.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultFAKTL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultFAKT, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 70)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1262, 89)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'TBResultFAKTL
        '
        Me.TBResultFAKTL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultFAKTL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultFAKTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultFAKTL.Location = New System.Drawing.Point(634, 3)
        Me.TBResultFAKTL.Multiline = True
        Me.TBResultFAKTL.Name = "TBResultFAKTL"
        Me.TBResultFAKTL.Size = New System.Drawing.Size(625, 83)
        Me.TBResultFAKTL.TabIndex = 17
        '
        'TBResultFAKT
        '
        Me.TBResultFAKT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultFAKT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultFAKT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultFAKT.Location = New System.Drawing.Point(3, 3)
        Me.TBResultFAKT.Multiline = True
        Me.TBResultFAKT.Name = "TBResultFAKT"
        Me.TBResultFAKT.Size = New System.Drawing.Size(625, 83)
        Me.TBResultFAKT.TabIndex = 16
        '
        'searchfakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 478)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "searchfakt"
        Me.Text = "Fakturen: Overzicht"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GrBDetailBon.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.FltWJR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TSBprint As ToolStripButton
    Friend WithEvents TSBtopten As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GrBDetailBon As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents CBfilteryear As CheckBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Fltbonjr As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Fltnr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FltCBcnr As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltwerf As TextBox
    Friend WithEvents Fltknaam As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TBResultFAKTL As TextBox
    Friend WithEvents TBResultFAKT As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CBfilterwyear As CheckBox
    Friend WithEvents FltWJR As NumericUpDown
    Friend WithEvents ToonFaktuurlijnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
