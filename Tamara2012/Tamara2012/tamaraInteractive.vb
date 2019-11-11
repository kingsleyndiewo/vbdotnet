' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2012 Funtrench Limited.*********
' ****************************************
Module tamaraInteractive
    ' this module deals with all the speech-
    ' processing that Tamara has - I/O with
    ' the patient

    ' *************************************
    ' Tamara_Speak
    ' Inserts Tamara's speech
    ' Formats appropriately
    ' *************************************
    Public Sub Tamara_Speak(strTSpeech As String)
        With frmMain.rtfDisplay
            .SelectionColor = ColorTranslator.FromWin32(gInterfaceOptions.tmrHue1)
            .SelectedText = "TAMARA:  " & strTSpeech & vbCrLf
            .SelectionStart = Len(.Text)
            .SelectionLength = 0
        End With
        ' allow patient to speak
        frmMain.cmdSubmit.Enabled = True
    End Sub

    ' *************************************
    ' Patient_Speak
    ' Inserts patient's speech
    ' Formats appropriately
    ' *************************************
    Public Sub Patient_Speak(strPSpeech As String)
        With frmMain.rtfDisplay
            .SelectionColor = ColorTranslator.FromWin32(gInterfaceOptions.tmrHue2)
            .SelectedText = gPatient & ":  " & strPSpeech & vbCrLf
            .SelectionStart = Len(.Text)
            .SelectionLength = 0
        End With
        ' don't allow patient to speak twice
        frmMain.cmdSubmit.Enabled = False
        ' call responder engine
        Tamara_Responder(strPSpeech)
    End Sub

    ' *************************************
    ' Tamara_Responder
    ' Responds to patient's speech
    ' *************************************
    Public Sub Tamara_Responder(strPSpeech As String)
        If Introflag Then
            ' respond to introduction
            Tamara_Speak(Respo_Selector(2))
            Introflag = False
            ' hide the prompt
            frmMain.lblNam.Visible = False
            Exit Sub
        ElseIf Teachflag Then
            ' check the answer
            If strPSpeech = "YES" Or strPSpeech = "Yes" Or _
            strPSpeech = "yes" Then
                ' prompt user to enter a preferred response
                frmEntry.Edit_Entry(pendEntry)
                ' conclude the transaction
                Tamara_Speak(Respo_Selector(5))
                Teachflag = False
                ' hide the prompt
                frmMain.lblNam3.Visible = False
                Exit Sub
                ' anything else goes as a 'NO'
                ' so we just IntelliParse
            End If
        End If
        ' otherwise use the parser
        Tamara_Speak(IntelliParser(strPSpeech))
    End Sub

    ' *************************************
    ' IntelliParser
    ' Parses the user input and generates a response
    ' Returns the response
    ' This is Tamara's brain
    ' Development commenced January 2008
    ' *************************************
    Public Function IntelliParser(patStr As String) As String
        Dim szRand As Integer
        ' consult the database
        If Find_Record(rsPrompts, "tmrPrompt", patStr) = False Then
            ' prompt for response?
            Teachflag = True
            pendEntry = patStr
            IntelliParser = Respo_Selector(4)
        Else
            ' get a response from the table
            ' randomize
            szRand = Rnd() * (rsPrompts.Fields("tmrResponseCount").Value - 1)
            szRand = szRand + 1
            Select Case szRand
                Case 1
                    IntelliParser = rsPrompts.Fields("tmrResponse1").Value
                Case 2
                    IntelliParser = rsPrompts.Fields("tmrResponse2").Value
                Case 3
                    IntelliParser = rsPrompts.Fields("tmrResponse3").Value
                Case 4
                    IntelliParser = rsPrompts.Fields("tmrResponse4").Value
                Case 5
                    IntelliParser = rsPrompts.Fields("tmrResponse5").Value
                Case 6
                    IntelliParser = rsPrompts.Fields("tmrResponse6").Value
                Case Else
                    IntelliParser = rsPrompts.Fields("tmrResponse1").Value
            End Select
        End If
    End Function
End Module
