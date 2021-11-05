<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchFAKTL
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBResultTelA = New System.Windows.Forms.TextBox()
        Me.TBResultTelL = New System.Windows.Forms.TextBox()
        Me.TBResultBONL = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrBDetailBon = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltomscode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fltgroep = New System.Windows.Forms.TextBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fltwerf = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GrBDetailBon.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Bon2017.My.Resources.Resources.canvas_faktuurlijnen
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1303, 31)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1303, 368)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultTelA, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultTelL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultBONL, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1379, 84)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'TBResultTelA
        '
        Me.TBResultTelA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultTelA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultTelA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultTelA.Location = New System.Drawing.Point(913, 3)
        Me.TBResultTelA.Multiline = True
        Me.TBResultTelA.Name = "TBResultTelA"
        Me.TBResultTelA.Size = New System.Drawing.Size(463, 78)
        Me.TBResultTelA.TabIndex = 20
        '
        'TBResultTelL
        '
        Me.TBResultTelL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultTelL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultTelL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultTelL.Location = New System.Drawing.Point(458, 3)
        Me.TBResultTelL.Multiline = True
        Me.TBResultTelL.Name = "TBResultTelL"
        Me.TBResultTelL.Size = New System.Drawing.Size(449, 78)
        Me.TBResultTelL.TabIndex = 19
        '
        'TBResultBONL
        '
        Me.TBResultBONL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultBONL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultBONL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultBONL.Location = New System.Drawing.Point(3, 3)
        Me.TBResultBONL.Multiline = True
        Me.TBResultBONL.Name = "TBResultBONL"
        Me.TBResultBONL.Size = New System.Drawing.Size(449, 78)
        Me.TBResultBONL.TabIndex = 18
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GrBDetailBon, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 93)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1379, 272)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'GrBDetailBon
        '
        Me.GrBDetailBon.AutoSize = True
        Me.GrBDetailBon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBDetailBon.Controls.Add(Me.DGREC)
        Me.GrBDetailBon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBDetailBon.Location = New System.Drawing.Point(143, 3)
        Me.GrBDetailBon.Name = "GrBDetailBon"
        Me.GrBDetailBon.Size = New System.Drawing.Size(1233, 266)
        Me.GrBDetailBon.TabIndex = 15
        Me.GrBDetailBon.TabStop = False
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 16)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(1227, 247)
        Me.DGREC.TabIndex = 0
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.Label1)
        Me.GroupFilter.Controls.Add(Me.Fltomscode)
        Me.GroupFilter.Controls.Add(Me.Label7)
        Me.GroupFilter.Controls.Add(Me.FltCode)
        Me.GroupFilter.Controls.Add(Me.Label4)
        Me.GroupFilter.Controls.Add(Me.Fltgroep)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Controls.Add(Me.Label2)
        Me.GroupFilter.Controls.Add(Me.Fltwerf)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(134, 266)
        Me.GroupFilter.TabIndex = 16
        Me.GroupFilter.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "OmsCode"
        '
        'Fltomscode
        '
        Me.Fltomscode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltomscode.Location = New System.Drawing.Point(62, 97)
        Me.Fltomscode.Name = "Fltomscode"
        Me.Fltomscode.Size = New System.Drawing.Size(66, 20)
        Me.Fltomscode.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Code"
        '
        'FltCode
        '
        Me.FltCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltCode.Location = New System.Drawing.Point(62, 71)
        Me.FltCode.Name = "FltCode"
        Me.FltCode.Size = New System.Drawing.Size(66, 20)
        Me.FltCode.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Groep"
        '
        'Fltgroep
        '
        Me.Fltgroep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltgroep.Location = New System.Drawing.Point(62, 45)
        Me.Fltgroep.Name = "Fltgroep"
        Me.Fltgroep.Size = New System.Drawing.Size(66, 20)
        Me.Fltgroep.TabIndex = 34
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(93, 6)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 33)
        Me.BTN_FilterReset.TabIndex = 30
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Werf"
        '
        'Fltwerf
        '
        Me.Fltwerf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltwerf.Location = New System.Drawing.Point(62, 123)
        Me.Fltwerf.Name = "Fltwerf"
        Me.Fltwerf.Size = New System.Drawing.Size(66, 20)
        Me.Fltwerf.TabIndex = 7
        '
        'SearchFAKTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 399)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SearchFAKTL"
        Me.Text = "Faktuurlijnen: Overzicht"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GrBDetailBon.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TBResultTelA As TextBox
    Friend WithEvents TBResultTelL As TextBox
    Friend WithEvents TBResultBONL As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltomscode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FltCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Fltgroep As TextBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Fltwerf As TextBox
    Friend WithEvents GrBDetailBon As GroupBox
    Friend WithEvents DGREC As DataGridView
End Class
