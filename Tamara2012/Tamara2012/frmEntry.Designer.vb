<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrompt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtResp0 = New System.Windows.Forms.TextBox()
        Me.txtResp1 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.txtResp5 = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrompt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient's Input"
        '
        'txtPrompt
        '
        Me.txtPrompt.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrompt.Location = New System.Drawing.Point(6, 23)
        Me.txtPrompt.Multiline = True
        Me.txtPrompt.Name = "txtPrompt"
        Me.txtPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrompt.Size = New System.Drawing.Size(454, 61)
        Me.txtPrompt.TabIndex = 0
        Me.txtPrompt.Text = "<This is what I said>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtResp5)
        Me.GroupBox2.Controls.Add(Me.txtResp4)
        Me.GroupBox2.Controls.Add(Me.txtResp3)
        Me.GroupBox2.Controls.Add(Me.txtResp2)
        Me.GroupBox2.Controls.Add(Me.txtResp1)
        Me.GroupBox2.Controls.Add(Me.txtResp0)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(466, 427)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tamara's Responses"
        '
        'txtResp0
        '
        Me.txtResp0.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp0.Location = New System.Drawing.Point(6, 23)
        Me.txtResp0.Multiline = True
        Me.txtResp0.Name = "txtResp0"
        Me.txtResp0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp0.Size = New System.Drawing.Size(454, 61)
        Me.txtResp0.TabIndex = 0
        Me.txtResp0.Text = "<I will reply with this>"
        '
        'txtResp1
        '
        Me.txtResp1.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp1.Location = New System.Drawing.Point(6, 90)
        Me.txtResp1.Multiline = True
        Me.txtResp1.Name = "txtResp1"
        Me.txtResp1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp1.Size = New System.Drawing.Size(454, 61)
        Me.txtResp1.TabIndex = 1
        Me.txtResp1.Text = "<I will reply with this>"
        '
        'txtResp2
        '
        Me.txtResp2.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp2.Location = New System.Drawing.Point(6, 157)
        Me.txtResp2.Multiline = True
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp2.Size = New System.Drawing.Size(454, 61)
        Me.txtResp2.TabIndex = 2
        Me.txtResp2.Text = "<I will reply with this>"
        '
        'txtResp3
        '
        Me.txtResp3.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp3.Location = New System.Drawing.Point(6, 224)
        Me.txtResp3.Multiline = True
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp3.Size = New System.Drawing.Size(454, 61)
        Me.txtResp3.TabIndex = 3
        Me.txtResp3.Text = "<I will reply with this>"
        '
        'txtResp4
        '
        Me.txtResp4.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp4.Location = New System.Drawing.Point(6, 291)
        Me.txtResp4.Multiline = True
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp4.Size = New System.Drawing.Size(454, 61)
        Me.txtResp4.TabIndex = 4
        Me.txtResp4.Text = "<I will reply with this>"
        '
        'txtResp5
        '
        Me.txtResp5.BackColor = System.Drawing.SystemColors.Window
        Me.txtResp5.Location = New System.Drawing.Point(6, 358)
        Me.txtResp5.Multiline = True
        Me.txtResp5.Name = "txtResp5"
        Me.txtResp5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp5.Size = New System.Drawing.Size(454, 61)
        Me.txtResp5.TabIndex = 5
        Me.txtResp5.Text = "<I will reply with this>"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(12, 550)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(92, 31)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&APPLY"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(386, 550)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 31)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(177, 550)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(128, 31)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "SAVE AND &QUIT"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(490, 590)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tamara Database Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrompt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResp0 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp5 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp4 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
