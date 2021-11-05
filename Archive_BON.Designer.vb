<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archive_BON
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
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.TsBtnStartFilter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBarchive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBArchiveDelete = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.DGRECcsv = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FltCBcnr = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FltCBfnr = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FltCBuv = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FltCBgst = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FltCBvs = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FltCBtbw = New System.Windows.Forms.ComboBox()
        Me.Fltbonjr = New System.Windows.Forms.NumericUpDown()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.DGRECcsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel5, Me.TsBtnStartFilter, Me.ToolStripLabel3, Me.ToolStripLabel2, Me.ToolStripLabel4, Me.TSBarchive, Me.ToolStripLabel1, Me.TSBArchiveDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1223, 31)
        Me.ToolStrip1.TabIndex = 62
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
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel5.Text = "   "
        '
        'TsBtnStartFilter
        '
        Me.TsBtnStartFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBtnStartFilter.Image = Global.Bon2017.My.Resources.Resources.search
        Me.TsBtnStartFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBtnStartFilter.Name = "TsBtnStartFilter"
        Me.TsBtnStartFilter.Size = New System.Drawing.Size(28, 28)
        Me.TsBtnStartFilter.Text = "Filter"
        Me.TsBtnStartFilter.ToolTipText = "Start filter"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel4.Text = "   "
        '
        'TSBarchive
        '
        Me.TSBarchive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBarchive.Image = Global.Bon2017.My.Resources.Resources.light
        Me.TSBarchive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBarchive.Name = "TSBarchive"
        Me.TSBarchive.Size = New System.Drawing.Size(28, 28)
        Me.TSBarchive.Text = "Archiveer"
        Me.TSBarchive.ToolTipText = "Archiveer BON-BONL"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
        '
        'TSBArchiveDelete
        '
        Me.TSBArchiveDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSBArchiveDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBArchiveDelete.Image = Global.Bon2017.My.Resources.Resources.yum3
        Me.TSBArchiveDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBArchiveDelete.Name = "TSBArchiveDelete"
        Me.TSBArchiveDelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBArchiveDelete.Text = "Arhiveer EN DELETE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1093.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGREC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1223, 405)
        Me.TableLayoutPanel1.TabIndex = 64
        '
        'DGREC
        '
        Me.DGREC.AllowUserToAddRows = False
        Me.DGREC.AllowUserToDeleteRows = False
        Me.DGREC.AllowUserToOrderColumns = True
        Me.DGREC.AllowUserToResizeRows = False
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(133, 9)
        Me.DGREC.MultiSelect = False
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(1087, 393)
        Me.DGREC.TabIndex = 19
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(124, 1)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 9)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(124, 393)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.DGRECcsv)
        Me.GroupFilter.Controls.Add(Me.Label3)
        Me.GroupFilter.Controls.Add(Me.FltCBcnr)
        Me.GroupFilter.Controls.Add(Me.Label12)
        Me.GroupFilter.Controls.Add(Me.FltCBfnr)
        Me.GroupFilter.Controls.Add(Me.Label17)
        Me.GroupFilter.Controls.Add(Me.FltCBuv)
        Me.GroupFilter.Controls.Add(Me.Label18)
        Me.GroupFilter.Controls.Add(Me.FltCBgst)
        Me.GroupFilter.Controls.Add(Me.Label19)
        Me.GroupFilter.Controls.Add(Me.FltCBvs)
        Me.GroupFilter.Controls.Add(Me.Label20)
        Me.GroupFilter.Controls.Add(Me.FltCBtbw)
        Me.GroupFilter.Controls.Add(Me.Fltbonjr)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(118, 387)
        Me.GroupFilter.TabIndex = 2
        Me.GroupFilter.TabStop = False
        '
        'DGRECcsv
        '
        Me.DGRECcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRECcsv.Location = New System.Drawing.Point(6, 234)
        Me.DGRECcsv.Name = "DGRECcsv"
        Me.DGRECcsv.Size = New System.Drawing.Size(106, 147)
        Me.DGRECcsv.TabIndex = 87
        Me.DGRECcsv.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "CNr"
        '
        'FltCBcnr
        '
        Me.FltCBcnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBcnr.FormattingEnabled = True
        Me.FltCBcnr.Location = New System.Drawing.Point(48, 192)
        Me.FltCBcnr.Name = "FltCBcnr"
        Me.FltCBcnr.Size = New System.Drawing.Size(64, 21)
        Me.FltCBcnr.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "FNr"
        '
        'FltCBfnr
        '
        Me.FltCBfnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBfnr.FormattingEnabled = True
        Me.FltCBfnr.Location = New System.Drawing.Point(48, 165)
        Me.FltCBfnr.Name = "FltCBfnr"
        Me.FltCBfnr.Size = New System.Drawing.Size(64, 21)
        Me.FltCBfnr.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "UV"
        '
        'FltCBuv
        '
        Me.FltCBuv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBuv.FormattingEnabled = True
        Me.FltCBuv.Location = New System.Drawing.Point(48, 138)
        Me.FltCBuv.Name = "FltCBuv"
        Me.FltCBuv.Size = New System.Drawing.Size(64, 21)
        Me.FltCBuv.TabIndex = 81
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 13)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Gst"
        '
        'FltCBgst
        '
        Me.FltCBgst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBgst.FormattingEnabled = True
        Me.FltCBgst.Location = New System.Drawing.Point(48, 111)
        Me.FltCBgst.Name = "FltCBgst"
        Me.FltCBgst.Size = New System.Drawing.Size(64, 21)
        Me.FltCBgst.TabIndex = 79
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "VS"
        '
        'FltCBvs
        '
        Me.FltCBvs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBvs.FormattingEnabled = True
        Me.FltCBvs.Location = New System.Drawing.Point(48, 84)
        Me.FltCBvs.Name = "FltCBvs"
        Me.FltCBvs.Size = New System.Drawing.Size(64, 21)
        Me.FltCBvs.TabIndex = 77
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "TBW"
        '
        'FltCBtbw
        '
        Me.FltCBtbw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBtbw.FormattingEnabled = True
        Me.FltCBtbw.Location = New System.Drawing.Point(48, 57)
        Me.FltCBtbw.Name = "FltCBtbw"
        Me.FltCBtbw.Size = New System.Drawing.Size(64, 21)
        Me.FltCBtbw.TabIndex = 75
        '
        'Fltbonjr
        '
        Me.Fltbonjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonjr.Location = New System.Drawing.Point(48, 12)
        Me.Fltbonjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltbonjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltbonjr.Name = "Fltbonjr"
        Me.Fltbonjr.Size = New System.Drawing.Size(56, 20)
        Me.Fltbonjr.TabIndex = 68
        Me.Fltbonjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltbonjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(3, 12)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 31
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Archive_BON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 436)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Archive_BON"
        Me.Text = "Archive_BON"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.DGRECcsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBarchive As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FltCBcnr As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FltCBfnr As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents FltCBuv As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents FltCBgst As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents FltCBvs As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents FltCBtbw As ComboBox
    Friend WithEvents Fltbonjr As NumericUpDown
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TsBtnStartFilter As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents DGRECcsv As DataGridView
    Friend WithEvents TSBArchiveDelete As ToolStripButton
End Class
