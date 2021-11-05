<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchAF))
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
        Me.TSBprint = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Fltstart = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Fltopmerking = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Fltverzonden = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Fltofferte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fltwerfleider = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltcalculator = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fltafr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltaft = New System.Windows.Forms.TextBox()
        Me.CBafapN = New System.Windows.Forms.CheckBox()
        Me.CBafapJ = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fltafnr = New System.Windows.Forms.TextBox()
        Me.CBfilteryear = New System.Windows.Forms.CheckBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Fltafjr = New System.Windows.Forms.NumericUpDown()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.Fltafjr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel1, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3, Me.TSBprint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1050, 31)
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
        'TSBprint
        '
        Me.TSBprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBprint.Enabled = False
        Me.TSBprint.Image = Global.Bon2017.My.Resources.Resources.print
        Me.TSBprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBprint.Name = "TSBprint"
        Me.TSBprint.Size = New System.Drawing.Size(28, 28)
        Me.TSBprint.Text = "Print"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1050, 421)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DGREC, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1044, 415)
        Me.TableLayoutPanel2.TabIndex = 41
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.Label10)
        Me.GroupFilter.Controls.Add(Me.Fltstart)
        Me.GroupFilter.Controls.Add(Me.Label9)
        Me.GroupFilter.Controls.Add(Me.Fltopmerking)
        Me.GroupFilter.Controls.Add(Me.Label8)
        Me.GroupFilter.Controls.Add(Me.Fltverzonden)
        Me.GroupFilter.Controls.Add(Me.Label7)
        Me.GroupFilter.Controls.Add(Me.Fltofferte)
        Me.GroupFilter.Controls.Add(Me.Label5)
        Me.GroupFilter.Controls.Add(Me.Fltwerfleider)
        Me.GroupFilter.Controls.Add(Me.Label4)
        Me.GroupFilter.Controls.Add(Me.Fltcalculator)
        Me.GroupFilter.Controls.Add(Me.Label2)
        Me.GroupFilter.Controls.Add(Me.Fltafr)
        Me.GroupFilter.Controls.Add(Me.Label1)
        Me.GroupFilter.Controls.Add(Me.Fltaft)
        Me.GroupFilter.Controls.Add(Me.CBafapN)
        Me.GroupFilter.Controls.Add(Me.CBafapJ)
        Me.GroupFilter.Controls.Add(Me.Label14)
        Me.GroupFilter.Controls.Add(Me.Label3)
        Me.GroupFilter.Controls.Add(Me.Fltusernrq)
        Me.GroupFilter.Controls.Add(Me.Label6)
        Me.GroupFilter.Controls.Add(Me.Fltafnr)
        Me.GroupFilter.Controls.Add(Me.CBfilteryear)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Controls.Add(Me.Fltafjr)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(143, 409)
        Me.GroupFilter.TabIndex = 1
        Me.GroupFilter.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Start"
        '
        'Fltstart
        '
        Me.Fltstart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltstart.Location = New System.Drawing.Point(59, 303)
        Me.Fltstart.Name = "Fltstart"
        Me.Fltstart.Size = New System.Drawing.Size(64, 20)
        Me.Fltstart.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Opmerking"
        '
        'Fltopmerking
        '
        Me.Fltopmerking.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltopmerking.Location = New System.Drawing.Point(59, 277)
        Me.Fltopmerking.Name = "Fltopmerking"
        Me.Fltopmerking.Size = New System.Drawing.Size(64, 20)
        Me.Fltopmerking.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Verzonden"
        '
        'Fltverzonden
        '
        Me.Fltverzonden.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltverzonden.Location = New System.Drawing.Point(59, 251)
        Me.Fltverzonden.Name = "Fltverzonden"
        Me.Fltverzonden.Size = New System.Drawing.Size(64, 20)
        Me.Fltverzonden.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Offerte"
        '
        'Fltofferte
        '
        Me.Fltofferte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltofferte.Location = New System.Drawing.Point(59, 225)
        Me.Fltofferte.Name = "Fltofferte"
        Me.Fltofferte.Size = New System.Drawing.Size(64, 20)
        Me.Fltofferte.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Werfleider"
        '
        'Fltwerfleider
        '
        Me.Fltwerfleider.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltwerfleider.Location = New System.Drawing.Point(59, 199)
        Me.Fltwerfleider.Name = "Fltwerfleider"
        Me.Fltwerfleider.Size = New System.Drawing.Size(64, 20)
        Me.Fltwerfleider.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Calculator"
        '
        'Fltcalculator
        '
        Me.Fltcalculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltcalculator.Location = New System.Drawing.Point(59, 174)
        Me.Fltcalculator.Name = "Fltcalculator"
        Me.Fltcalculator.Size = New System.Drawing.Size(64, 20)
        Me.Fltcalculator.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Reden"
        '
        'Fltafr
        '
        Me.Fltafr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltafr.Location = New System.Drawing.Point(59, 149)
        Me.Fltafr.Name = "Fltafr"
        Me.Fltafr.Size = New System.Drawing.Size(64, 20)
        Me.Fltafr.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Type"
        '
        'Fltaft
        '
        Me.Fltaft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltaft.Location = New System.Drawing.Point(59, 124)
        Me.Fltaft.Name = "Fltaft"
        Me.Fltaft.Size = New System.Drawing.Size(64, 20)
        Me.Fltaft.TabIndex = 40
        '
        'CBafapN
        '
        Me.CBafapN.AutoSize = True
        Me.CBafapN.Location = New System.Drawing.Point(91, 77)
        Me.CBafapN.Name = "CBafapN"
        Me.CBafapN.Size = New System.Drawing.Size(46, 17)
        Me.CBafapN.TabIndex = 78
        Me.CBafapN.TabStop = False
        Me.CBafapN.Text = "Nee"
        Me.CBafapN.UseVisualStyleBackColor = True
        '
        'CBafapJ
        '
        Me.CBafapJ.AutoSize = True
        Me.CBafapJ.Location = New System.Drawing.Point(59, 77)
        Me.CBafapJ.Name = "CBafapJ"
        Me.CBafapJ.Size = New System.Drawing.Size(37, 17)
        Me.CBafapJ.TabIndex = 77
        Me.CBafapJ.TabStop = False
        Me.CBafapJ.Text = "Ja"
        Me.CBafapJ.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Particulier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(59, 329)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Nr"
        '
        'Fltafnr
        '
        Me.Fltafnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltafnr.Location = New System.Drawing.Point(59, 99)
        Me.Fltafnr.Name = "Fltafnr"
        Me.Fltafnr.Size = New System.Drawing.Size(64, 20)
        Me.Fltafnr.TabIndex = 39
        '
        'CBfilteryear
        '
        Me.CBfilteryear.AutoSize = True
        Me.CBfilteryear.Checked = True
        Me.CBfilteryear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBfilteryear.Location = New System.Drawing.Point(28, 54)
        Me.CBfilteryear.Name = "CBfilteryear"
        Me.CBfilteryear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilteryear.TabIndex = 36
        Me.CBfilteryear.UseVisualStyleBackColor = True
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(83, 10)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 35
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Fltafjr
        '
        Me.Fltafjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltafjr.Location = New System.Drawing.Point(59, 51)
        Me.Fltafjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltafjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltafjr.Name = "Fltafjr"
        Me.Fltafjr.Size = New System.Drawing.Size(64, 20)
        Me.Fltafjr.TabIndex = 34
        Me.Fltafjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltafjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(152, 3)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(908, 409)
        Me.DGREC.TabIndex = 2
        '
        'SearchAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 452)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchAF"
        Me.Text = "Af te handelen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.Fltafjr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TSBprint As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Fltafnr As TextBox
    Friend WithEvents CBfilteryear As CheckBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Fltafjr As NumericUpDown
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents CBafapN As CheckBox
    Friend WithEvents CBafapJ As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fltafr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltaft As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltcalculator As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Fltopmerking As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Fltverzonden As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Fltofferte As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Fltwerfleider As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Fltstart As TextBox
End Class
