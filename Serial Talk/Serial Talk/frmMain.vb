Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main()
        Me.Text = gAppInfo.Title
        ' important for multithreaded apps
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' close the ports
        If spCommA.IsOpen = True Then spCommA.Close()
        If spCommB.IsOpen = True Then spCommB.Close()
        End
    End Sub

    Private Sub cmdClearA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearA.Click
        txtRxA.Text = vbNullString
    End Sub

    Private Sub cmdClearB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearB.Click
        txtRxB.Text = vbNullString
    End Sub

    Private Sub cboPortA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPortA.SelectedIndexChanged
        If cboPortA.Text = vbNullString Then Exit Sub
        If spCommA.PortName = cboPortA.Text And lblAStatus.Text = "PORT OPEN" Then
            Exit Sub
        ElseIf spCommA.PortName = cboPortA.Text And lblAStatus.Text <> "PORT OPEN" Then
            ' set the status
            GoTo GoodPortA
        End If
        ' close the port first
        If spCommA.IsOpen = True Then spCommA.Close()
        ' open the selected port
        Try
            spCommA.PortName = cboPortA.Text
            spCommA.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, gAppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lblAStatus.Text = "INACCESSIBLE PORT!"
            txtTxA.Enabled = False
            cmdSendA.Enabled = False
            Exit Sub
        End Try
GoodPortA:
        lblAStatus.Text = "PORT OPEN"
        txtTxA.Enabled = True
        cmdSendA.Enabled = True
    End Sub

    Private Sub cboPortB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPortB.SelectedIndexChanged
        If cboPortB.Text = vbNullString Then Exit Sub
        If spCommB.PortName = cboPortB.Text And lblBStatus.Text = "PORT OPEN" Then
            Exit Sub
        ElseIf spCommB.PortName = cboPortB.Text And lblBStatus.Text <> "PORT OPEN" Then
            ' set the status
            GoTo GoodPortB
        End If
        ' close the port first
        If spCommB.IsOpen = True Then spCommB.Close()
        ' open the selected port
        Try
            spCommB.PortName = cboPortB.Text
            spCommB.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, gAppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lblBStatus.Text = "INACCESSIBLE PORT!"
            txtTxB.Enabled = False
            cmdSendB.Enabled = False
            Exit Sub
        End Try
GoodPortB:
        lblBStatus.Text = "PORT OPEN"
        txtTxB.Enabled = True
        cmdSendB.Enabled = True
    End Sub

    Private Sub cmdSendA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendA.Click
        ' send data
        If txtTxA.Text = vbNullString Then Exit Sub
        spCommA.Write(txtTxA.Text)
    End Sub

    Private Sub cmdSendB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendB.Click
        ' send data
        If txtTxB.Text = vbNullString Then Exit Sub
        spCommB.Write(txtTxB.Text)
    End Sub

    Private Sub spCommA_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spCommA.DataReceived
        ' put received data in textbox
        Try
            If gMode = True Then
                txtRxA.Text = spCommA.ReadExisting
            Else
                ReDim gReceive(spCommA.ReadBufferSize)
                spCommA.Read(gReceive, 0, spCommA.ReadBufferSize)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, gAppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub spCommB_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spCommB.DataReceived
        ' put received data in textbox
        Try
            If gMode = True Then
                txtRxB.Text = spCommB.ReadExisting
            Else
                ReDim gReceive(spCommB.ReadBufferSize)
                spCommB.Read(gReceive, 0, spCommB.ReadBufferSize)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, gAppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub BinaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinaryToolStripMenuItem.Click
        ' check if selected
        If BinaryToolStripMenuItem.Checked = True Then
            StringToolStripMenuItem.Checked = False
            gMode = False
        Else
            StringToolStripMenuItem.Checked = True
        End If
        gMode = StringToolStripMenuItem.Checked
    End Sub

    Private Sub StringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StringToolStripMenuItem.Click
        ' check if selected
        If StringToolStripMenuItem.Checked = True Then
            BinaryToolStripMenuItem.Checked = False
        Else
            BinaryToolStripMenuItem.Checked = True
        End If
        gMode = StringToolStripMenuItem.Checked
    End Sub
End Class
