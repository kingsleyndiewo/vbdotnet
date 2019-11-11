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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSendA = New System.Windows.Forms.Button
        Me.cmdClearA = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRxA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTxA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPortA = New System.Windows.Forms.ComboBox
        Me.lblAStatus = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdSendB = New System.Windows.Forms.Button
        Me.cmdClearB = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRxB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTxB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboPortB = New System.Windows.Forms.ComboBox
        Me.lblBStatus = New System.Windows.Forms.Label
        Me.spCommA = New System.IO.Ports.SerialPort(Me.components)
        Me.spCommB = New System.IO.Ports.SerialPort(Me.components)
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.cmdSendA)
        Me.GroupBox1.Controls.Add(Me.cmdClearA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRxA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTxA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPortA)
        Me.GroupBox1.Controls.Add(Me.lblAStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 550)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Port A"
        '
        'cmdSendA
        '
        Me.cmdSendA.Location = New System.Drawing.Point(222, 117)
        Me.cmdSendA.Name = "cmdSendA"
        Me.cmdSendA.Size = New System.Drawing.Size(105, 23)
        Me.cmdSendA.TabIndex = 8
        Me.cmdSendA.Text = "SEND DATA"
        Me.cmdSendA.UseVisualStyleBackColor = True
        '
        'cmdClearA
        '
        Me.cmdClearA.Location = New System.Drawing.Point(222, 336)
        Me.cmdClearA.Name = "cmdClearA"
        Me.cmdClearA.Size = New System.Drawing.Size(105, 24)
        Me.cmdClearA.TabIndex = 7
        Me.cmdClearA.Text = "CLEAR"
        Me.cmdClearA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data RECEIVED"
        '
        'txtRxA
        '
        Me.txtRxA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRxA.Location = New System.Drawing.Point(17, 363)
        Me.txtRxA.Multiline = True
        Me.txtRxA.Name = "txtRxA"
        Me.txtRxA.ReadOnly = True
        Me.txtRxA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRxA.Size = New System.Drawing.Size(310, 178)
        Me.txtRxA.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data to SEND"
        '
        'txtTxA
        '
        Me.txtTxA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTxA.Enabled = False
        Me.txtTxA.Location = New System.Drawing.Point(17, 146)
        Me.txtTxA.Multiline = True
        Me.txtTxA.Name = "txtTxA"
        Me.txtTxA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTxA.Size = New System.Drawing.Size(310, 178)
        Me.txtTxA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select a port"
        '
        'cboPortA
        '
        Me.cboPortA.FormattingEnabled = True
        Me.cboPortA.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16"})
        Me.cboPortA.Location = New System.Drawing.Point(17, 80)
        Me.cboPortA.Name = "cboPortA"
        Me.cboPortA.Size = New System.Drawing.Size(200, 23)
        Me.cboPortA.TabIndex = 1
        '
        'lblAStatus
        '
        Me.lblAStatus.AutoSize = True
        Me.lblAStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAStatus.Location = New System.Drawing.Point(13, 27)
        Me.lblAStatus.Name = "lblAStatus"
        Me.lblAStatus.Size = New System.Drawing.Size(132, 19)
        Me.lblAStatus.TabIndex = 0
        Me.lblAStatus.Text = "NO PORT OPEN"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.cmdSendB)
        Me.GroupBox2.Controls.Add(Me.cmdClearB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtRxB)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTxB)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboPortB)
        Me.GroupBox2.Controls.Add(Me.lblBStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 550)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Port B"
        '
        'cmdSendB
        '
        Me.cmdSendB.Location = New System.Drawing.Point(223, 119)
        Me.cmdSendB.Name = "cmdSendB"
        Me.cmdSendB.Size = New System.Drawing.Size(105, 23)
        Me.cmdSendB.TabIndex = 12
        Me.cmdSendB.Text = "SEND DATA"
        Me.cmdSendB.UseVisualStyleBackColor = True
        '
        'cmdClearB
        '
        Me.cmdClearB.Location = New System.Drawing.Point(223, 336)
        Me.cmdClearB.Name = "cmdClearB"
        Me.cmdClearB.Size = New System.Drawing.Size(105, 24)
        Me.cmdClearB.TabIndex = 11
        Me.cmdClearB.Text = "CLEAR"
        Me.cmdClearB.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Data RECEIVED"
        '
        'txtRxB
        '
        Me.txtRxB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRxB.Location = New System.Drawing.Point(18, 363)
        Me.txtRxB.Multiline = True
        Me.txtRxB.Name = "txtRxB"
        Me.txtRxB.ReadOnly = True
        Me.txtRxB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRxB.Size = New System.Drawing.Size(310, 178)
        Me.txtRxB.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(26, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data to SEND"
        '
        'txtTxB
        '
        Me.txtTxB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTxB.Enabled = False
        Me.txtTxB.Location = New System.Drawing.Point(18, 146)
        Me.txtTxB.Multiline = True
        Me.txtTxB.Name = "txtTxB"
        Me.txtTxB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTxB.Size = New System.Drawing.Size(310, 178)
        Me.txtTxB.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please select a port"
        '
        'cboPortB
        '
        Me.cboPortB.FormattingEnabled = True
        Me.cboPortB.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16"})
        Me.cboPortB.Location = New System.Drawing.Point(18, 80)
        Me.cboPortB.Name = "cboPortB"
        Me.cboPortB.Size = New System.Drawing.Size(200, 23)
        Me.cboPortB.TabIndex = 2
        '
        'lblBStatus
        '
        Me.lblBStatus.AutoSize = True
        Me.lblBStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBStatus.Location = New System.Drawing.Point(14, 27)
        Me.lblBStatus.Name = "lblBStatus"
        Me.lblBStatus.Size = New System.Drawing.Size(132, 19)
        Me.lblBStatus.TabIndex = 1
        Me.lblBStatus.Text = "NO PORT OPEN"
        '
        'spCommA
        '
        '
        'spCommB
        '
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryToolStripMenuItem, Me.StringToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModeToolStripMenuItem.Text = "&Mode"
        '
        'BinaryToolStripMenuItem
        '
        Me.BinaryToolStripMenuItem.CheckOnClick = True
        Me.BinaryToolStripMenuItem.Name = "BinaryToolStripMenuItem"
        Me.BinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BinaryToolStripMenuItem.Text = "&Binary"
        '
        'StringToolStripMenuItem
        '
        Me.StringToolStripMenuItem.Checked = True
        Me.StringToolStripMenuItem.CheckOnClick = True
        Me.StringToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StringToolStripMenuItem.Name = "StringToolStripMenuItem"
        Me.StringToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StringToolStripMenuItem.Text = "&String"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 586)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Serial Talk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBStatus As System.Windows.Forms.Label
    Friend WithEvents cboPortA As System.Windows.Forms.ComboBox
    Friend WithEvents cboPortB As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRxA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTxA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRxB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTxB As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearA As System.Windows.Forms.Button
    Friend WithEvents cmdClearB As System.Windows.Forms.Button
    Friend WithEvents spCommA As System.IO.Ports.SerialPort
    Friend WithEvents spCommB As System.IO.Ports.SerialPort
    Friend WithEvents cmdSendA As System.Windows.Forms.Button
    Friend WithEvents cmdSendB As System.Windows.Forms.Button
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
