' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2012 Funtrench Limited.*********
' ****************************************
Module tamaraMain
    ' Sub Main
    ' Entry point into the application
    ' Initializes database connections and creates data
    Public Sub Main()
        ' get the application info
        gAppInfo = My.Application.Info
        ' load main settings, load form and apply
        Load_Globals()
        ' initialize the database
        ' set the connection to the database
        cnTamaraSys = New ADODB.Connection
        With cnTamaraSys
            .ConnectionString = gAppInfo.DirectoryPath & gDataPath
            .Provider = "Microsoft.jet.oledb.4.0"
            .Open()
        End With
        ' open the Prompts table
        rsPrompts = New ADODB.Recordset
        With rsPrompts
            .ActiveConnection = cnTamaraSys
            .LockType = LockTypeEnum.adLockOptimistic
            .CursorType = CursorTypeEnum.adOpenKeyset
            .Open("Prompts")
        End With
        Update_Settings()
        ' seed the randomizer with time in seconds since midnight
        Randomize(DateAndTime.Timer)
        ' initialize flag
        Introflag = True
        ' get dates and times
        Load_DateTime()
        ' open resource file
        Try
            Dim szAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim tmrRes As IO.Stream = szAssembly.GetManifestResourceStream("Tamara2012.Resources.resources")
            gResReader = New Resources.ResourceReader(tmrRes)
            ' get our res file from here
            Dim resDataType As String = Nothing
            Dim resData() As Byte = Nothing
            gResReader.GetResourceData("tamara", resDataType, resData)
            ' make the res file the source for the reader
            Dim tamaraRes As New IO.MemoryStream(resData)
            gResReader = New Resources.ResourceReader(tamaraRes)
            MsgBox("Hello")
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Exclamation, gAppInfo.Title)
        End Try
        ' greet the patient
        Tamara_Speak(Respo_Selector(1))
    End Sub

#Region "Data"
    ' *************************************
    ' Find_Record
    ' Finds a record in a recordset
    ' Returns True if found
    ' *************************************
    Public Function Find_Record(rs As ADODB.Recordset, Field As String, ByVal value As String) As Boolean
        If rs.RecordCount > 0 Then
            rs.MoveFirst()
            If IsNumeric(value) Then
                rs.Find(Field & "=" & Val(value), , SearchDirectionEnum.adSearchForward, BookmarkEnum.adBookmarkFirst)
            Else
                rs.Find(Field & " Like '" & (value) & "'", , SearchDirectionEnum.adSearchForward, BookmarkEnum.adBookmarkFirst)
            End If
            ' set result
            If rs.EOF Then
                Find_Record = False
            Else
                Find_Record = True
            End If
        Else
            ' empty recordset
            Find_Record = False
        End If
    End Function



    Public Function LoadResString(resID As Integer) As String
        ' load a resource from the internal resource file (tamara.res)
        Try
            Dim dataType As String = Nothing
            Dim data() As Byte = Nothing
            gResReader.GetResourceData(resID, dataType, data)
            ' change to string
            Dim reader As New IO.BinaryReader(New IO.MemoryStream(data))
            LoadResString = reader.ReadString()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Exclamation, gAppInfo.Title)
            LoadResString = "Error"
        End Try
    End Function
#End Region

#Region "Settings"
    ' this region deals with settings, the registry
    ' and application of these to the GUI.

    ' *************************************
    ' Load_Globals
    ' Loads all global settings
    ' *************************************
    Public Sub Load_Globals()
        ' load all settings
        Try
            gInterfaceOptions.tmrHue1 = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "TamaraHue", "&H554FEF")
            gInterfaceOptions.tmrHue2 = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "PatientHue", "&HA85622")
            gInterfaceOptions.tmrHue3 = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "BackHue", "&HFFFFFF")
            gInterfaceOptions.tmrFontName = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntName", "Arial")
            gInterfaceOptions.tmrFontSz = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntSz", "11")
            gInterfaceOptions.tmrFontBld = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntBld", False)
            gInterfaceOptions.tmrFontItalic = GetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntItc", False)
        Catch ex As System.Security.SecurityException
            MsgBox("Tamara could not read the system registry. Try running as administrator.", MsgBoxStyle.Information, gAppInfo.Title)
        End Try
        ' check if size is 0, which means the registry folder for this application doesn't yet exist
        If (gInterfaceOptions.tmrFontSz = 0) Then
            ' create the path
            With gInterfaceOptions
                .tmrHue1 = "&H554FEF"
                .tmrHue2 = "&HA85622"
                .tmrHue3 = "&HFFFFFF"
                .tmrFontName = "Arial"
                .tmrFontSz = 11
                .tmrFontBld = False
                .tmrFontItalic = False
            End With
            ' save values
            Save_Globals()
        End If
        ' database path
        gDataPath = "\Data\Tamara.mdb"
    End Sub

    ' *************************************
    ' Save_Globals
    ' Saves all global settings
    ' *************************************
    Public Sub Save_Globals()
        With gInterfaceOptions
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "TamaraHue", CStr(.tmrHue1))
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "PatientHue", CStr(.tmrHue2))
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "BackHue", CStr(.tmrHue3))
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntName", .tmrFontName)
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntSz", CStr(.tmrFontSz))
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntBld", CStr(.tmrFontBld))
            SetValue(regRootCompany & gAppInfo.Title & "\Settings", "FntItc", CStr(.tmrFontItalic))
        End With
    End Sub

    ' *************************************
    ' Update_Settings
    ' Updates all settings into current session
    ' Formats appropriately
    ' *************************************
    Public Sub Update_Settings()
        Dim szSel As Long
        ' set dialog settings
        With frmMain.rtfDisplay
            .BackColor = ColorTranslator.FromWin32(gInterfaceOptions.tmrHue3)
            ' store position
            szSel = .SelectionStart
            ' update actively
            .SelectionStart = 0
            .SelectionLength = Len(.Text) + 2
            ' create font
            If gInterfaceOptions.tmrFontBld And gInterfaceOptions.tmrFontItalic Then
                .SelectionFont = New Font(gInterfaceOptions.tmrFontName, gInterfaceOptions.tmrFontSz, FontStyle.Bold)
            ElseIf gInterfaceOptions.tmrFontBld Then
                .SelectionFont = New Font(gInterfaceOptions.tmrFontName, gInterfaceOptions.tmrFontSz, FontStyle.Bold)
            ElseIf gInterfaceOptions.tmrFontItalic Then
                .SelectionFont = New Font(gInterfaceOptions.tmrFontName, gInterfaceOptions.tmrFontSz, FontStyle.Italic)
            Else
                .SelectionFont = New Font(gInterfaceOptions.tmrFontName, gInterfaceOptions.tmrFontSz, FontStyle.Regular)
            End If

            ' restore position
            .SelectionStart = szSel
            .SelectionLength = 0
        End With
    End Sub
#End Region
End Module
