<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Searchusers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Searchusers))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBnew = New System.Windows.Forms.ToolStripButton()
        Me.TSBedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrBFilters = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltCBdel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FltCBupd = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FltCBnew = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltnaam = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FltCBtotals = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrBFilters.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBnew, Me.TSBedit, Me.ToolStripLabel2, Me.ToolStripLabel5, Me.TSBdelete, Me.ToolStripLabel3, Me.TSBexport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(929, 31)
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
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DGREC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(140, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 500)
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
        Me.DGREC.Name = "DGREC"
        Me.DGREC.ReadOnly = True
        Me.DGREC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGREC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGREC.Size = New System.Drawing.Size(780, 481)
        Me.DGREC.TabIndex = 1
        Me.DGREC.TabStop = False
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 506.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(929, 506)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'GrBFilters
        '
        Me.GrBFilters.AutoSize = True
        Me.GrBFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBFilters.Controls.Add(Me.Label1)
        Me.GrBFilters.Controls.Add(Me.FltCBtotals)
        Me.GrBFilters.Controls.Add(Me.Label7)
        Me.GrBFilters.Controls.Add(Me.FltCBdel)
        Me.GrBFilters.Controls.Add(Me.Label6)
        Me.GrBFilters.Controls.Add(Me.FltCBupd)
        Me.GrBFilters.Controls.Add(Me.Label8)
        Me.GrBFilters.Controls.Add(Me.FltCBnew)
        Me.GrBFilters.Controls.Add(Me.Label4)
        Me.GrBFilters.Controls.Add(Me.Fltnaam)
        Me.GrBFilters.Controls.Add(Me.BTN_FilterReset)
        Me.GrBFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBFilters.Location = New System.Drawing.Point(3, 3)
        Me.GrBFilters.Name = "GrBFilters"
        Me.GrBFilters.Size = New System.Drawing.Size(131, 500)
        Me.GrBFilters.TabIndex = 3
        Me.GrBFilters.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Schrappen"
        '
        'FltCBdel
        '
        Me.FltCBdel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBdel.FormattingEnabled = True
        Me.FltCBdel.Location = New System.Drawing.Point(61, 130)
        Me.FltCBdel.Name = "FltCBdel"
        Me.FltCBdel.Size = New System.Drawing.Size(64, 21)
        Me.FltCBdel.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Update"
        '
        'FltCBupd
        '
        Me.FltCBupd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FltCBupd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FltCBupd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBupd.FormattingEnabled = True
        Me.FltCBupd.Location = New System.Drawing.Point(61, 76)
        Me.FltCBupd.Name = "FltCBupd"
        Me.FltCBupd.Size = New System.Drawing.Size(64, 21)
        Me.FltCBupd.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Nieuw"
        '
        'FltCBnew
        '
        Me.FltCBnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBnew.FormattingEnabled = True
        Me.FltCBnew.Location = New System.Drawing.Point(61, 103)
        Me.FltCBnew.Name = "FltCBnew"
        Me.FltCBnew.Size = New System.Drawing.Size(64, 21)
        Me.FltCBnew.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(0, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Naam"
        '
        'Fltnaam
        '
        Me.Fltnaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltnaam.Location = New System.Drawing.Point(61, 50)
        Me.Fltnaam.Name = "Fltnaam"
        Me.Fltnaam.Size = New System.Drawing.Size(64, 20)
        Me.Fltnaam.TabIndex = 11
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(90, 9)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 17
        Me.BTN_FilterReset.TabStop = False
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Totalen"
        '
        'FltCBtotals
        '
        Me.FltCBtotals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCBtotals.FormattingEnabled = True
        Me.FltCBtotals.Location = New System.Drawing.Point(61, 158)
        Me.FltCBtotals.Name = "FltCBtotals"
        Me.FltCBtotals.Size = New System.Drawing.Size(64, 21)
        Me.FltCBtotals.TabIndex = 33
        '
        'Searchusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 537)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Searchusers"
        Me.Text = "SearchUsers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GrBFilters.ResumeLayout(False)
        Me.GrBFilters.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GrBFilters As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FltCBdel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FltCBupd As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FltCBnew As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltnaam As TextBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents FltCBtotals As ComboBox
End Class
