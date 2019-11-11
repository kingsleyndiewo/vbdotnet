' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2012 Funtrench Limited.*********
' ****************************************
Module tamaraChrono
    ' this module deals with all time-related
    ' functions that the AI needs. We must have
    ' the AI aware of the complete date and time

    ' *************************************
    ' Load_DateTime
    ' Loads date and time components as string values
    ' *************************************
    Public Sub Load_DateTime()

        ' local variables
        Dim fMonth As Integer
        Dim fDay As Integer

        ' load direct settings (need no modification)
        gYear = Year(Now)
        gHourofDay = Hour(Now)

        ' load indirect settings (must be num2word-ed)
        fMonth = Month(Now)
        fDay = Weekday(Now)

        ' decipher (convert to words)
        Select Case fMonth
            Case 1
                gMonth = "January"
            Case 2
                gMonth = "February"
            Case 3
                gMonth = "March"
            Case 4
                gMonth = "April"
            Case 5
                gMonth = "May"
            Case 6
                gMonth = "June"
            Case 7
                gMonth = "July"
            Case 8
                gMonth = "August"
            Case 9
                gMonth = "September"
            Case 10
                gMonth = "October"
            Case 11
                gMonth = "November"
            Case 12
                gMonth = "December"
        End Select

        ' decipher (convert to words)
        Select Case fDay
            Case 1
                gDayofWeek = "Sunday"
            Case 2
                gDayofWeek = "Monday"
            Case 3
                gDayofWeek = "Tuesday"
            Case 4
                gDayofWeek = "Wednesday"
            Case 5
                gDayofWeek = "Thursday"
            Case 6
                gDayofWeek = "Friday"
            Case 7
                gDayofWeek = "Saturday"
        End Select

        ' decipher (compute & convert to words)
        If gHourofDay > 0 And gHourofDay < 12 Then
            gPeriod = "morning"
        ElseIf gHourofDay > 12 And gHourofDay < 17 Then
            gPeriod = "afternoon"
        ElseIf gHourofDay > 16 And gHourofDay < 20 Then
            gPeriod = "evening"
        ElseIf gHourofDay > 19 And gHourofDay < 24 Then
            gPeriod = "night"
        ElseIf gHourofDay = 0 Then
            gPeriod = "midnight"
        Else
            gPeriod = "noon"
        End If
    End Sub
End Module
