' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2012 Funtrench Limited.*********
' ****************************************
Module tamaraResponses
    ' All the selection structures for the
    ' responses are here. Might end up being
    ' rather long.

    ' *************************************
    ' Respo_Selector
    ' Response selector
    ' Selects a response
    ' *************************************
    Public Function Respo_Selector(intMode As Integer) As String
        Dim intRnd As Integer
        ' check for mode
        Select Case intMode
            Case 1
                ' randomize for 15 possibilities (0-14)
                intRnd = Rnd() * 14
                Respo_Selector = LoadResString(101 + intRnd)
                ' prompt for name
                frmMain.lblNam.Visible = True
            Case 2
                ' randomize for 15 possibilities (0-14)
                intRnd = Rnd() * 14
                Select Case intRnd
                    Case 0
                        Respo_Selector = "How are we this " _
                        & gDayofWeek & " " & gPeriod & ", " & _
                        gPatient & "?"
                    Case 1
                        Respo_Selector = "Lovely " & gDayofWeek _
                        & " " & gPeriod & ", isn't it " & _
                        gPatient & "?"
                    Case 2
                        Respo_Selector = "A wonderful " & _
                        gDayofWeek & " " & gPeriod & " for " _
                        & "chatting, wouldn't you say " & _
                        gPatient & "?"
                    Case 3
                        Respo_Selector = gDayofWeek & " " & _
                        gPeriod & "s are my favorite sessions " _
                        & gPatient & ". Let's begin!"
                    Case 4
                        Respo_Selector = "Splendid " & gPeriod _
                        & ", " & gPatient & ". Shall we begin" _
                        & " our " & gDayofWeek & " session?"
                    Case 5
                        Respo_Selector = "Great " & gDayofWeek _
                        & " " & gPeriod & ". I'm ready to " _
                        & "listen. Are you ready to talk " _
                        & gPatient & "?"
                    Case 6
                        Respo_Selector = gDayofWeek & " " & _
                        gPeriod & "s are hectic for counselling." _
                        & " Does horrid things to schedule " _
                        & gPatient & ", but it's a livin!"
                    Case 7
                        Respo_Selector = "I'm not promising " _
                        & "a " & gDayofWeek & " " & gPeriod _
                        & " of magic " & gPatient & ", there's" _
                        & " only so much I can do..." & vbCrLf _
                        & "No No " & gPatient & ". No " _
                        & "touching. I'm married."
                    Case 8
                        Respo_Selector = "It's funny how I can" _
                        & " tell it is " & gDayofWeek & " " _
                        & gPeriod & ", but I can't really feel" _
                        & " the whole " & gDayofWeek & "-ness" _
                        & " of it...like a human...oh sorry..." _
                        & "tell me your trouble " & gPatient
                    Case 9
                        Respo_Selector = "What impedes your " _
                        & "well-being this " & gDayofWeek & _
                        " " & gPeriod & ", " & gPatient & "?"
                    Case 10
                        Respo_Selector = "Wonderful " & _
                        gDayofWeek & " " & gPeriod & ". I'm" _
                        & " really wondering what could " _
                        & "possibly be wrong with yours " & _
                        gPatient & "?"
                    Case 11
                        Respo_Selector = "ViS MultiMedia " _
                        & "insists that every time I say hi," _
                        & " I have to show that I know it's " _
                        & gDayofWeek & " " & gPeriod & ". And" _
                        & " you think you have issues!" & vbCrLf _
                        & "Can't even omit your name so " _
                        & "there..." & gPatient
                    Case 12
                        Respo_Selector = "God! It's " & _
                        gDayofWeek & " " & gPeriod & " already. " _
                        & "I really need a diary. Oh. Hi " & _
                        gPatient & "!"
                    Case 13
                        Respo_Selector = "The " & gPeriod & _
                        " is a key part of the day (oh boy)," _
                        & " this " & gDayofWeek & " ViS MultiMedia " _
                        & "are giving you the chance of a lifetime!" _
                        & vbCrLf & "You " & gPatient & ", can chat " _
                        & "with ME and pour your heart out. Cool?"
                    Case 14
                        Respo_Selector = gDayofWeek & " " & _
                        gPeriod & "s are good for counselling " _
                        & gPatient & ". Read your horoscope?"
                    Case Else
                        Respo_Selector = "It's funny how I can" _
                        & " tell it is " & gDayofWeek & " " _
                        & gPeriod & ", but I can't really feel" _
                        & " the whole " & gDayofWeek & "-ness" _
                        & " of it...like a human...oh sorry..." _
                        & "tell me your trouble " & gPatient
                End Select
            Case 3
                ' randomize for 12 possibilities (0-11)
                intRnd = Rnd() * 11
                Respo_Selector = LoadResString(216 + intRnd)
                ' prompt for no blank
                frmMain.lblNam2.Visible = True
            Case 4
                ' randomize for 12 possibilities (0-11)
                intRnd = Rnd() * 11
                Respo_Selector = LoadResString(328 + intRnd)
                ' prompt for yes or no
                frmMain.lblNam3.Visible = True
            Case 5
                ' randomize for 5 possibilities (0-4)
                intRnd = Rnd() * 4
                Respo_Selector = LoadResString(380 + intRnd)
            Case Else
                ' randomize for 12 possibilities (0-11)
                intRnd = Rnd() * 11
                Respo_Selector = LoadResString(216 + intRnd)
                ' prompt for no blank
                frmMain.lblNam2.Visible = True
        End Select
    End Function

End Module
