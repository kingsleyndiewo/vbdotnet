' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2011 Funtrench Limited.*********
' ****************************************
Public NotInheritable Class frmAbout
    ' modular variables
    Private szNarrative As String
    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If gAppInfo.Title <> "" Then
            ApplicationTitle = gAppInfo.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(gAppInfo.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = gAppInfo.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", gAppInfo.Version.ToString)
        Me.LabelCopyright.Text = gAppInfo.Copyright
        Me.LabelCompanyName.Text = gAppInfo.CompanyName
        szNarrative = gAppInfo.Description & vbCrLf & vbCrLf & "Programming By: Kingsley Ndiewo" & vbCrLf & vbCrLf
        Me.TextBoxDescription.Text = szNarrative
        ' enable the timer
        timFT.Enabled = True
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub timFT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timFT.Tick
        Static szCount As Integer
        Me.TextBoxDescription.Text = szNarrative & vbCrLf & Strings.Left(gFTString, szCount + 1)
        szCount = szCount + 1
        ' check limit
        If szCount = Len(gFTString) Then szCount = 0
    End Sub
End Class
