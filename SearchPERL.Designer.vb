<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPERL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPERL))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelecteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeSelecteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.CBselectN = New System.Windows.Forms.CheckBox()
        Me.CBselectJ = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Fltnieuw = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FltOmsgroep = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBResult = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilter.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NieuwToolStripMenuItem, Me.BewerkToolStripMenuItem, Me.BewerkCodeToolStripMenuItem, Me.ToolStripSeparator4, Me.SelecteerToolStripMenuItem, Me.DeSelecteerToolStripMenuItem, Me.ToolStripSeparator1, Me.VerwijderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 148)
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemadd
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NieuwToolStripMenuItem.Text = "Nieuwe PER-lijn"
        '
        'BewerkToolStripMenuItem
        '
        Me.BewerkToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkToolStripMenuItem.Name = "BewerkToolStripMenuItem"
        Me.BewerkToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BewerkToolStripMenuItem.Text = "Bewerk PER-Lijn"
        '
        'BewerkCodeToolStripMenuItem
        '
        Me.BewerkCodeToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkCodeToolStripMenuItem.Name = "BewerkCodeToolStripMenuItem"
        Me.BewerkCodeToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BewerkCodeToolStripMenuItem.Text = "Bewerk Code"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(156, 6)
        '
        'SelecteerToolStripMenuItem
        '
        Me.SelecteerToolStripMenuItem.Name = "SelecteerToolStripMenuItem"
        Me.SelecteerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SelecteerToolStripMenuItem.Text = "Selecteer"
        '
        'DeSelecteerToolStripMenuItem
        '
        Me.DeSelecteerToolStripMenuItem.Name = "DeSelecteerToolStripMenuItem"
        Me.DeSelecteerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DeSelecteerToolStripMenuItem.Text = "De-Selecteer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'VerwijderToolStripMenuItem
        '
        Me.VerwijderToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.VerwijderToolStripMenuItem.Name = "VerwijderToolStripMenuItem"
        Me.VerwijderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VerwijderToolStripMenuItem.Text = "Verwijder"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel1, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1113, 31)
        Me.ToolStrip1.TabIndex = 63
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
        Me.TSBnew.ToolTipText = "Nieuwe BONLIJN"
        '
        'TSBedit
        '
        Me.TSBedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBedit.Image = CType(resources.GetObject("TSBedit.Image"), System.Drawing.Image)
        Me.TSBedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBedit.Name = "TSBedit"
        Me.TSBedit.Size = New System.Drawing.Size(28, 28)
        Me.TSBedit.Text = "Editeer"
        Me.TSBedit.ToolTipText = "Bewerk BONLIJN"
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
        Me.TSBdelete.ToolTipText = "Verwijder BONLIJN"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1113, 450)
        Me.TableLayoutPanel1.TabIndex = 64
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1107, 444)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DGREC, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 109)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1107, 444)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(140, 3)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(964, 438)
        Me.DGREC.TabIndex = 3
        Me.DGREC.TabStop = False
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.CBselectN)
        Me.GroupFilter.Controls.Add(Me.CBselectJ)
        Me.GroupFilter.Controls.Add(Me.Label3)
        Me.GroupFilter.Controls.Add(Me.Fltusernrq)
        Me.GroupFilter.Controls.Add(Me.Label12)
        Me.GroupFilter.Controls.Add(Me.Fltnieuw)
        Me.GroupFilter.Controls.Add(Me.Label11)
        Me.GroupFilter.Controls.Add(Me.Label7)
        Me.GroupFilter.Controls.Add(Me.FltCode)
        Me.GroupFilter.Controls.Add(Me.Label4)
        Me.GroupFilter.Controls.Add(Me.FltOmsgroep)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(131, 438)
        Me.GroupFilter.TabIndex = 2
        Me.GroupFilter.TabStop = False
        '
        'CBselectN
        '
        Me.CBselectN.AutoSize = True
        Me.CBselectN.Location = New System.Drawing.Point(79, 110)
        Me.CBselectN.Name = "CBselectN"
        Me.CBselectN.Size = New System.Drawing.Size(46, 17)
        Me.CBselectN.TabIndex = 71
        Me.CBselectN.Text = "Nee"
        Me.CBselectN.UseVisualStyleBackColor = True
        '
        'CBselectJ
        '
        Me.CBselectJ.AutoSize = True
        Me.CBselectJ.Location = New System.Drawing.Point(46, 110)
        Me.CBselectJ.Name = "CBselectJ"
        Me.CBselectJ.Size = New System.Drawing.Size(37, 17)
        Me.CBselectJ.TabIndex = 70
        Me.CBselectJ.Text = "Ja"
        Me.CBselectJ.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(46, 159)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(66, 20)
        Me.Fltusernrq.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Nieuw"
        '
        'Fltnieuw
        '
        Me.Fltnieuw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltnieuw.Location = New System.Drawing.Point(46, 133)
        Me.Fltnieuw.Name = "Fltnieuw"
        Me.Fltnieuw.Size = New System.Drawing.Size(66, 20)
        Me.Fltnieuw.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "SEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Code"
        '
        'FltCode
        '
        Me.FltCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCode.Location = New System.Drawing.Point(46, 82)
        Me.FltCode.Name = "FltCode"
        Me.FltCode.Size = New System.Drawing.Size(66, 20)
        Me.FltCode.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Groep"
        '
        'FltOmsgroep
        '
        Me.FltOmsgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltOmsgroep.Location = New System.Drawing.Point(46, 56)
        Me.FltOmsgroep.Name = "FltOmsgroep"
        Me.FltOmsgroep.Size = New System.Drawing.Size(66, 20)
        Me.FltOmsgroep.TabIndex = 36
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(77, 15)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 31
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Controls.Add(Me.TBResult, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1107, 100)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'TBResult
        '
        Me.TBResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResult.Location = New System.Drawing.Point(3, 3)
        Me.TBResult.Multiline = True
        Me.TBResult.Name = "TBResult"
        Me.TBResult.Size = New System.Drawing.Size(362, 94)
        Me.TBResult.TabIndex = 20
        Me.TBResult.TabStop = False
        '
        'SearchPERL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 481)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchPERL"
        Me.Text = "SearchPERL"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelecteerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeSelecteerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Fltnieuw As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FltCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FltOmsgroep As TextBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TBResult As TextBox
    Friend WithEvents CBselectN As CheckBox
    Friend WithEvents CBselectJ As CheckBox
End Class
