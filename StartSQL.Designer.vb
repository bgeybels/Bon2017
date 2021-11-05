<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartSQL
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBtyDEFAULT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBtyU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBtyN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBtyH = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TBsql = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1054, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateAFToolStripMenuItem})
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SQLToolStripMenuItem.Text = "SQL"
        '
        'UpdateAFToolStripMenuItem
        '
        Me.UpdateAFToolStripMenuItem.Name = "UpdateAFToolStripMenuItem"
        Me.UpdateAFToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.UpdateAFToolStripMenuItem.Text = "Update AF"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1054, 326)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBtyDEFAULT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBtyU)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBtyN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBtyH)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DGREC)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BtnStart)
        Me.GroupBox1.Controls.Add(Me.TBsql)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(606, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Type Default"
        '
        'TBtyDEFAULT
        '
        Me.TBtyDEFAULT.Location = New System.Drawing.Point(680, 97)
        Me.TBtyDEFAULT.Name = "TBtyDEFAULT"
        Me.TBtyDEFAULT.Size = New System.Drawing.Size(54, 20)
        Me.TBtyDEFAULT.TabIndex = 16
        Me.TBtyDEFAULT.Text = "4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(632, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Type U"
        '
        'TBtyU
        '
        Me.TBtyU.Location = New System.Drawing.Point(680, 71)
        Me.TBtyU.Name = "TBtyU"
        Me.TBtyU.Size = New System.Drawing.Size(54, 20)
        Me.TBtyU.TabIndex = 14
        Me.TBtyU.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(632, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Type N"
        '
        'TBtyN
        '
        Me.TBtyN.Location = New System.Drawing.Point(680, 45)
        Me.TBtyN.Name = "TBtyN"
        Me.TBtyN.Size = New System.Drawing.Size(54, 20)
        Me.TBtyN.TabIndex = 12
        Me.TBtyN.Text = "3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(632, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Type H"
        '
        'TBtyH
        '
        Me.TBtyH.Location = New System.Drawing.Point(680, 19)
        Me.TBtyH.Name = "TBtyH"
        Me.TBtyH.Size = New System.Drawing.Size(54, 20)
        Me.TBtyH.TabIndex = 10
        Me.TBtyH.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(762, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ReadAFTH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Location = New System.Drawing.Point(391, 163)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(648, 148)
        Me.DGREC.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(404, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Totaal BONL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(404, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Totaal BON"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(509, 19)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(112, 35)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "ConvertAFTH"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TBsql
        '
        Me.TBsql.Location = New System.Drawing.Point(9, 19)
        Me.TBsql.Multiline = True
        Me.TBsql.Name = "TBsql"
        Me.TBsql.Size = New System.Drawing.Size(364, 186)
        Me.TBsql.TabIndex = 2
        '
        'StartSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 350)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StartSQL"
        Me.Text = "Start SQL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents TBsql As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents UpdateAFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBtyH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBtyU As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBtyN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBtyDEFAULT As TextBox
End Class
