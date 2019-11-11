Public Class frmEntry
    Private mResponses As Collection
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        ' process the save
        cmdSave_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim szLoop As Integer
        Dim szCnt As Integer
        ' fill structure
        With rsPrompts
            ' add new record
            .AddNew()
            .Fields(1).Value = txtPrompt.Text
            ' fill the responses
            For szLoop = 0 To 5
                ' increment blanks counter
                If mResponses(szLoop).Text = "<I will reply with this>" Or mResponses(szLoop).text = vbNullString Then
                    .Fields(szLoop + 2).Value = vbNullString
                    szCnt = szCnt + 1
                Else
                    .Fields(szLoop + 2).Value = mResponses(szLoop).Text
                End If
            Next
            .Fields(8).Value = 6 - szCnt
            ' save structure
            .Update()
        End With
    End Sub

    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load textboxes into collection
        With mResponses
            .Add(txtResp0)
            .Add(txtResp1)
            .Add(txtResp2)
            .Add(txtResp3)
            .Add(txtResp4)
            .Add(txtResp5)
        End With
    End Sub

    Public Sub Edit_Entry(szPatStr As String)
        txtPrompt.Text = szPatStr
        Me.ShowDialog()
    End Sub
End Class