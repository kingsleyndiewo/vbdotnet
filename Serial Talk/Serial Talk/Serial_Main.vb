Module Serial_Main
    ' Main
    ' entry point into the program
    Public Sub Main()
        ' default is serial mode
        gMode = False
        ' get the application info
        gAppInfo = My.Application.Info
        gMode = True
    End Sub
End Module