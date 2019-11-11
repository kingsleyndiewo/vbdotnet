<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtfDisplay = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNam = New System.Windows.Forms.Label()
        Me.lblNam2 = New System.Windows.Forms.Label()
        Me.lblNam3 = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(612, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'rtfDisplay
        '
        Me.rtfDisplay.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rtfDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtfDisplay.Location = New System.Drawing.Point(0, 24)
        Me.rtfDisplay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtfDisplay.Name = "rtfDisplay"
        Me.rtfDisplay.Size = New System.Drawing.Size(612, 363)
        Me.rtfDisplay.TabIndex = 1
        Me.rtfDisplay.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(129, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PLEASE ENTER YOUR RESPONSE:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNam
        '
        Me.lblNam.AutoSize = True
        Me.lblNam.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblNam.Location = New System.Drawing.Point(393, 391)
        Me.lblNam.Name = "lblNam"
        Me.lblNam.Size = New System.Drawing.Size(51, 18)
        Me.lblNam.TabIndex = 3
        Me.lblNam.Text = "NAME"
        Me.lblNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNam.Visible = False
        '
        'lblNam2
        '
        Me.lblNam2.AutoSize = True
        Me.lblNam2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam2.ForeColor = System.Drawing.Color.Red
        Me.lblNam2.Location = New System.Drawing.Point(397, 391)
        Me.lblNam2.Name = "lblNam2"
        Me.lblNam2.Size = New System.Drawing.Size(85, 18)
        Me.lblNam2.TabIndex = 4
        Me.lblNam2.Text = "NO INPUT!"
        Me.lblNam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNam2.Visible = False
        '
        'lblNam3
        '
        Me.lblNam3.AutoSize = True
        Me.lblNam3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam3.ForeColor = System.Drawing.Color.Navy
        Me.lblNam3.Location = New System.Drawing.Point(397, 391)
        Me.lblNam3.Name = "lblNam3"
        Me.lblNam3.Size = New System.Drawing.Size(92, 18)
        Me.lblNam3.TabIndex = 5
        Me.lblNam3.Text = "YES OR NO"
        Me.lblNam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNam3.Visible = False
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(12, 412)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResponse.Size = New System.Drawing.Size(588, 134)
        Me.txtResponse.TabIndex = 6
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Enabled = False
        Me.cmdSubmit.Location = New System.Drawing.Point(220, 552)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(162, 37)
        Me.cmdSubmit.TabIndex = 7
        Me.cmdSubmit.Text = "&SUBMIT"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(612, 594)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtResponse)
        Me.Controls.Add(Me.lblNam3)
        Me.Controls.Add(Me.lblNam2)
        Me.Controls.Add(Me.lblNam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtfDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtfDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNam As System.Windows.Forms.Label
    Friend WithEvents lblNam2 As System.Windows.Forms.Label
    Friend WithEvents lblNam3 As System.Windows.Forms.Label
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button

End Class
