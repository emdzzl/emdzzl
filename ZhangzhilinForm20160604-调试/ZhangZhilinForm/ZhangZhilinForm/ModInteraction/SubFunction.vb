Module SubFunction

#Region "Main窗体加载触发CCD程序开启"
    ''' <summary>
    ''' 打开外部应用程序，如果应用程序已打开，则将其显示
    ''' </summary>
    ''' <param name="path">路径名称，不包含应用文件名，如"D:\Cognex-Run\COGNEX\"</param>
    ''' <param name="AppName">应用程序名称，如"AlignVisSystem.exe"</param>
    ''' <remarks></remarks>
    Sub OpenShellExecute(path As String, AppName As String)
        Dim Soft_hwnd, Temp_hwnd As Long
        Dim strAppName(2) As String

        strAppName = Split(AppName, ".")
        Temp_hwnd = FindWindow(vbNullString, "frmMain")
        Soft_hwnd = FindWindow(vbNullString, strAppName(0))
        If Soft_hwnd > 0 Then
            BringWindowToTop(Soft_hwnd)                          '
        Else
            ShellExecute(Temp_hwnd, "Open", AppName, "", path, 4)
        End If
    End Sub
#End Region

#Region "功能：读取数据库中的用户名及密码"
    Public Sub RereshParaLogin(ByRef cobTemp As ComboBox)
        sLogin = ReadUsersAndPassWord()
        '将读取到的所有用户名全部添加进主界面中的Combox框
        If sLogin.Users.Length > 0 And sLogin.PassWord.Length > 0 Then
            For i = 0 To sLogin.Users.Length - 1
                cobTemp.Items.Add(sLogin.Users(i))
            Next
        End If
    End Sub

    Public Function ReadUsersAndPassWord() As structLogin
        Dim TempLogin As structLogin
        Dim strTemp As String
        Dim DataSetVar As DataSet
        '先连接上数据库，并将数据读取成DataSet类
        strTemp = ReadDataBase(strFilePath(5), "123", "login", 1, 1, DataSetVar)
        If DataSetVar IsNot Nothing Then
            '将DataSet类中用户名和密码一起读取出
            TempLogin.Users = ReadAllField(DataSetVar, 0, "UserName")
            TempLogin.PassWord = ReadAllField(DataSetVar, 0, "PassWord")
            Return TempLogin
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "功能：写入数据库用户名及密码"
    Public Function WriteParaLogin(ByVal structTempLogin As structLogin) As Boolean
        Try
            If sLogin.Users.Length > 0 Then
                '将所有用户名的密码更新一次
                For i = 0 To sLogin.Users.Length - 1
                    Call WriteDataBase(strFilePath(5), "123", "login", "UserName", sLogin.Users(i), "PassWord", sLogin.PassWord(i))
                Next
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
#End Region
 
End Module
