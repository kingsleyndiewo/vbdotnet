Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' call main
        Main()
        Me.Text = gAppInfo.ProductName
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.showdialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        ' check if patient is saying nothing
        If Len(txtResponse.Text) = 0 Or txtResponse.Text = " " _
        Then
            Tamara_Speak(Respo_Selector(3))
            Exit Sub
        End If
        ' clear prompt
        If lblNam2.Visible = True Then lblNam2.Visible = False
        ' check if patient is doing introductions
        If Len(gPatient) = 0 Then gPatient = txtResponse.Text
        ' call speaking function
        Patient_Speak(txtResponse.Text)
        ' clear box
        txtResponse.Text = vbNullString
    End Sub
End Class
