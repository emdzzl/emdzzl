Module API
    Public Declare Function GetTickCount Lib "kernel32" () As Integer
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String,
                            ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As System.Text.StringBuilder,
                            ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As _
                                                                                                         String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, _
                                                                         ByVal lpWindowName As String) As Integer
    Public Declare Function BringWindowToTop Lib "user32" (ByVal hwnd As Integer) As Integer
    Public Declare Function CloseWindow Lib "user32" (ByVal hwnd As Integer) As Integer
    Public Declare Function DestroyWindow Lib "user32" (ByVal hwnd As Integer) As Integer
    Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, _
                                                       ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, _
                                                       ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Public Declare Function MessageBeep Lib "user32" (ByVal wType As Integer) As Integer
    Public Declare Function Beep Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, _
                                                                      ByVal wParam As Integer, lParam As Object) As Integer
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

End Module
