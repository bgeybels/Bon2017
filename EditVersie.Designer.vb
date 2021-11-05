<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditVERSIE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditVersie))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBopl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBok = New System.Windows.Forms.CheckBox()
        Me.TBgrp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBtype = New System.Windows.Forms.TextBox()
        Me.TBver = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBmel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPu = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(405, 31)
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
        'TSBsave
        '
        Me.TSBsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBsave.Image = CType(resources.GetObject("TSBsave.Image"), System.Drawing.Image)
        Me.TSBsave.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBsave.Name = "TSBsave"
        Me.TSBsave.Size = New System.Drawing.Size(28, 28)
        Me.TSBsave.Text = "Bewaar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(405, 258)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DTPu)
        Me.GroupBox1.Controls.Add(Me.TBmel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBopl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBok)
        Me.GroupBox1.Controls.Add(Me.TBgrp)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TBtype)
        Me.GroupBox1.Controls.Add(Me.TBver)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TBopl
        '
        Me.TBopl.Location = New System.Drawing.Point(93, 144)
        Me.TBopl.Multiline = True
        Me.TBopl.Name = "TBopl"
        Me.TBopl.Size = New System.Drawing.Size(242, 20)
        Me.TBopl.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Oplossing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Datum"
        '
        'CBok
        '
        Me.CBok.AutoSize = True
        Me.CBok.Location = New System.Drawing.Point(93, 97)
        Me.CBok.Name = "CBok"
        Me.CBok.Size = New System.Drawing.Size(52, 17)
        Me.CBok.TabIndex = 38
        Me.CBok.TabStop = False
        Me.CBok.Text = "Done"
        Me.CBok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBok.UseVisualStyleBackColor = True
        '
        'TBgrp
        '
        Me.TBgrp.Location = New System.Drawing.Point(93, 71)
        Me.TBgrp.Name = "TBgrp"
        Me.TBgrp.Size = New System.Drawing.Size(242, 20)
        Me.TBgrp.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Groep"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Reden"
        '
        'TBtype
        '
        Me.TBtype.Location = New System.Drawing.Point(93, 45)
        Me.TBtype.Name = "TBtype"
        Me.TBtype.Size = New System.Drawing.Size(242, 20)
        Me.TBtype.TabIndex = 12
        '
        'TBver
        '
        Me.TBver.Location = New System.Drawing.Point(93, 19)
        Me.TBver.Name = "TBver"
        Me.TBver.Size = New System.Drawing.Size(242, 20)
        Me.TBver.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Versie"
        '
        'TBmel
        '
        Me.TBmel.Location = New System.Drawing.Point(93, 170)
        Me.TBmel.Multiline = True
        Me.TBmel.Name = "TBmel"
        Me.TBmel.Size = New System.Drawing.Size(242, 20)
        Me.TBmel.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Melding"
        '
        'DTPu
        '
        Me.DTPu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPu.Location = New System.Drawing.Point(93, 119)
        Me.DTPu.Name = "DTPu"
        Me.DTPu.Size = New System.Drawing.Size(107, 20)
        Me.DTPu.TabIndex = 41
        '
        'EditVersie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 289)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditVersie"
        Me.Text = "EditVersie"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBopl As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBok As CheckBox
    Friend WithEvents TBgrp As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TBtype As TextBox
    Friend WithEvents TBver As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBmel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPu As DateTimePicker
End Class
