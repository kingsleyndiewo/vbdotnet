' ****************************************
' *******Author: Kingsley Ndiewo**********
' *******kingsley@funtrench.com***********
' *******©2012 Funtrench Limited.*********
' ****************************************
Module tamaraGlobals

    ' Tamara is a self-learning bot that I must
    ' admit was inspired by ECC Eliza. I wish to make
    ' her more interactive and flexible than her bot
    ' colleagues out there. Version 1.0 was made in VB6
    ' and this version is firstly a move to VS2012 and
    ' secondly a move away from AccessDB

    ' constants
    ' ---------------------------------------------------------------------- 
    Public Const dataStrLen = 500
    Public Const numofOption = 5
    ' registry settings
    Public Const regRootCompany As String = "HKEY_CURRENT_USER\SOFTWARE\Funtrench\"
    Public Const regRoot As String = "HKEY_CURRENT_USER\SOFTWARE\"
    Public Const regRootRun As String = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
    ' FT string
    Public Const gFTString = "Funtrench Limited. The Digital Tomorrow..." & _
    vbCrLf & "Established 2008. Quality technology since then..."
    ' enums
    ' structures
    Structure tmrEntry
        Public dataString As String
        Public dataNumber As Integer
        Public dataLen() As Integer
    End Structure
    Structure tmrSettings
        ' Tamara's speech color
        Public tmrHue1 As Long
        ' Patient's speech color
        Public tmrHue2 As Long
        ' Background color
        Public tmrHue3 As Long
        ' Font attributes
        Public tmrFontName As String
        Public tmrFontSz As Integer
        Public tmrFontBld As Boolean
        Public tmrFontItalic As Boolean
    End Structure
    ' global objects
    Public gAppInfo As AssemblyInfo
    Public gResReader As Resources.ResourceReader
    Public gInterfaceOptions As tmrSettings
    ' other globals
    ' ----------------------------------------------------------------------  
    ' patient's name
    Public gPatient As String

    ' date and time
    Public gDayofWeek As String
    Public gHourofDay As Integer
    Public gMonth As String
    Public gYear As Integer
    Public gPeriod As String

    ' flags
    Public Introflag As Boolean
    Public Teachflag As Boolean
    ' flag data
    Public pendEntry As String

    ' database variables
    ' ----------------------------------------------------------------------  
    Public cnTamaraSys As ADODB.Connection
    ' recordsets
    Public rsPrompts As ADODB.Recordset
    ' path
    Public gDataPath As String
    ' ----------------------------------------------------------------------  
    Public gEdenExists As Boolean
End Module
