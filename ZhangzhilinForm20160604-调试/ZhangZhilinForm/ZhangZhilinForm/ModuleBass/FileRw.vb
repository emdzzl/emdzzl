Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports System.Math
Imports System.Text.StringBuilder
Imports VB = Microsoft.VisualBasic
Module FileRw

#Region "文件路径的创建"
    ''' <summary>
    ''' 文件路径变量
    ''' </summary>
    ''' <remarks></remarks>
    Public strFilePath(40) As String
    ''' <summary>
    ''' 对路径进行赋值
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreatFilePath()
        strFilePath(0) = "E:\BZ-Data"
        strFilePath(1) = "D:\BZ-Parameter"
        strFilePath(2) = Application.StartupPath & "\GTS_Config\GTS800-01.cfg"
        strFilePath(3) = Application.StartupPath & "\GTS_Config\ExtModule.cfg"
        strFilePath(4) = Application.StartupPath & "\GTS_Config\GTS400-01.cfg"
        strFilePath(5) = strFilePath(1) & "\BZ001.mdb"
    End Sub
#End Region

#Region "功能：CSV文件写入"
    Public Sub WriteCsvFile(ByVal Filename As String, ByVal Savedata As String)
        Dim rs As New System.IO.StreamWriter(Filename, True)
        Try
            rs.WriteLine(Savedata)
            rs.Close()
        Catch ex As Exception
            MsgBox("文件读取失败：" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            rs.Close()
        End Try
    End Sub
#End Region

#Region "功能：CSV文件读"
    Public Function ReadCsvFile(ByVal Filename As String) As String()
        Dim sr As IO.StreamReader
        Dim Tmpstr As String
        Dim Arry() As String = {}
        Dim Index As Long
        sr = IO.File.OpenText(Filename)
        Tmpstr = sr.ReadLine()
        Index = 0
        While Not Tmpstr Is Nothing
            ReDim Preserve Arry(Index)
            Arry(Index) = Tmpstr
            Tmpstr = sr.ReadLine()
            Index += 1
        End While
        sr.Close()
        Return Arry
    End Function

    Public Function ReadCsvFile1(ByVal Filename As String) As String
        Dim sr As IO.StreamReader
        Dim Tmpstr As String
        Dim Arry() As String = {}
        Dim Index As Long
        sr = IO.File.OpenText(Filename)
        Tmpstr = sr.ReadLine()
        Index = 0

        sr.Close()
        Return Tmpstr
    End Function
#End Region

#Region "功能：TXT文件写入"
    Public Sub WriteDattxt(ByVal Filename As String, ByVal WriteData As String)
        Dim rs As New System.IO.StreamWriter(Filename, True)
        Try
            rs.WriteLine(WriteData)
            rs.Close()
        Catch ex As Exception
            MsgBox("文件写入失败" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            rs.Close()
        End Try
    End Sub
#End Region

#Region "功能：TXT文件读取"
    Public Function ReadDattxt(ByVal Filename As String)
        Dim readdata As String = ""
        Dim readline As String
        Dim rs As New System.IO.StreamReader(Filename, True)
        Try
            Do
                readline = rs.ReadLine()
                readdata = readdata + readline
            Loop Until rs.EndOfStream = True
            Return readdata
        Catch ex As Exception
            MsgBox("文件读取失败：" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            Return ""
        End Try
    End Function
#End Region

#Region "功能：保存二进制文件"
    Public Sub WriteDatFile(ByVal Filename As String, ByRef WriteData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, CStr(Filename), OpenMode.Binary)           '以二进制的形式打开文件
            FilePut(Filenumber, WriteData)
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件写入失败" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        End Try
    End Sub
    Public Sub WritePassWordDat(ByVal Filename As String, ByRef WriteData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, CStr(Filename), OpenMode.Binary)           '以二进制的形式打开文件
            FilePut(Filenumber, WriteData)
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件写入失败" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        End Try
    End Sub

    Public Sub WriteDP2_TJFile(ByVal Filename As String, ByRef WriteData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, CStr(Filename), OpenMode.Binary)           '以二进制的形式打开文件
            FilePut(Filenumber, WriteData)
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件写入失败" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                           '写入完成关闭当前打开的文件
        End Try
    End Sub


#End Region

#Region "功能：读取二进制文件"
    Public Sub ReadDatFile(ByVal Filename As String, ByRef ReadData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, Filename, OpenMode.Binary)                 '以二进制的形式打开文件
            Dim lens As String = LOF(Filenumber)
            FileGet(Filenumber, ReadData, 1)
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件读取失败：" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        End Try
    End Sub
    Public Sub ReadPassWordDat(ByVal Filename As String, ByRef ReadData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, Filename, OpenMode.Binary)                 '以二进制的形式打开文件
            Dim lens As String = LOF(Filenumber)
            FileGet(Filenumber, ReadData, 1)
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件读取失败：" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        End Try
    End Sub
    Public Sub ReadDP2_TJFile(ByVal Filename As String, ByRef ReadData As Object)
        Dim Filenumber As Integer
        Try
            Filenumber = FreeFile()                                         '获取空闲可用的文件号
            FileOpen(Filenumber, Filename, OpenMode.Binary)                 '以二进制的形式打开文件
            Dim lens As String = LOF(Filenumber)
            FileGet(Filenumber, ReadData, 1)
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        Catch ex As Exception
            MsgBox("文件读取失败：" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误")
            FileClose(Filenumber)                                          '写入完成关闭当前打开的文件
        End Try
    End Sub
#End Region

#Region "功能：INI文件写入"
    Public Sub IniWriteValue(ByVal iniFile As String, ByVal section As String, ByVal key As String, ByVal value As String)
        Call WritePrivateProfileString(section, key, value, iniFile)
    End Sub
#End Region

#Region "功能：INI文件读"
    Public Function IniGetStringValue(ByVal iniFile As String, ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
        Dim value As String
        Const SIZE As Integer = 1024 * 10
        Dim rtn As Int32
        Dim sb As New System.Text.StringBuilder(SIZE)
        value = defaultValue
        rtn = GetPrivateProfileString(section, key, defaultValue, sb, SIZE, iniFile)
        If rtn <> 0 Then
            value = sb.ToString
        End If
        Return value
    End Function
#End Region

#Region "功能：删除INI Section"
    Public Sub DelIniSec(ByVal iniFile As String, ByVal SectionName As String) '清除section
        Dim retval As Integer
        retval = WritePrivateProfileString(SectionName, Nothing, Nothing, iniFile)
    End Sub
#End Region

#Region "功能：读取数据库"
    ''' <summary>
    ''' 读取数据库具体某行某列的值，并同时可返回读取到的Dataset对象
    ''' </summary>
    ''' <param name="strFilePahtName">文件路径带文件名</param>
    ''' <param name="strSheetName">表名</param>
    ''' <param name="intRowsNum">要读取的行：默认＝0</param>
    ''' <param name="intColumn">要读取的列：默认＝0</param>
    ''' <param name="RetDataSet">返回的DataSet对象</param>
    ''' <returns>返回读取到的内容</returns>
    ''' <remarks></remarks>
    Public Function ReadDataBase(ByVal strFilePahtName As String, ByVal strPassWord As String, ByVal strSheetName As String, ByVal intRowsNum As Integer, ByVal intColumn As Integer, Optional ByRef RetDataSet As DataSet = Nothing) As String
        Dim strCon As String
        Dim conn As System.Data.OleDb.OleDbConnection
        Dim odda As OleDbDataAdapter
        Dim ds As New DataSet

        Try
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFilePahtName & ";Jet OLEDB:Database Password=" & strPassWord
            conn = New System.Data.OleDb.OleDbConnection(strCon)   '建立连接
            conn.Open()                                            '打开连接
            odda = New OleDbDataAdapter("SELECT * FROM " & strSheetName, conn) '用指定的表来建立DataAdapter
            odda.Fill(ds)

            '返回值
            ReadDataBase = ds.Tables(0).Rows(intRowsNum).Item(intColumn).ToString
            RetDataSet = ds
            conn.Close()
        Catch ex As Exception
            ReadDataBase = Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function
#End Region

#Region "功能：从DataSet中读取某一字段所有的内容"
    ''' <summary>
    ''' 从DataSet中读取某一字段所有的内容
    ''' </summary>
    ''' <param name="DataSet">DataSet变量</param>
    ''' <param name="SheetNum">表序号</param>
    ''' <param name="DataField">字段名</param>
    ''' <returns>以数组形式返回读取到的内容</returns>
    ''' <remarks></remarks>
    Public Function ReadAllField(ByVal DataSet As DataSet, ByVal SheetNum As Integer, ByVal DataField As String) As String()
        Try
            Dim strTemp(DataSet.Tables(SheetNum).Rows.Count - 1) As String
            For i = 0 To DataSet.Tables(SheetNum).Rows.Count - 1
                '读出来的内容，如果在数据库中为空或者不为字符串弄，统一赋值为“”空字符串
                If TypeName(DataSet.Tables(SheetNum).Rows(i).Item(DataField)) <> "DBNull" Then
                    strTemp(i) = DataSet.Tables(SheetNum).Rows(i).Item(DataField)
                Else
                    strTemp(i) = ""
                End If
            Next
            Return strTemp
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
#End Region

#Region "功能：写数据库" 
    ''' <summary>
    '''功能：写数据库
    ''' </summary>
    ''' <param name="strFileFullPahtName">数据库所在的路径，带文件名</param>
    ''' <param name="strPassWord">数据库密码</param>
    ''' <param name="strSheetName">表名</param>
    ''' <param name="strRowsName">用来定位要修改数据的行名</param>
    ''' <param name="strRowsVaule">用来定位要修改数据的行名对应的值</param>
    ''' <param name="strFields">要修改数据所在的字段名</param>
    ''' <param name="strWriteValue">要定入的新值</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function WriteDataBase(ByVal strFileFullPahtName As String, ByVal strPassWord As String, ByVal strSheetName As String, ByVal strRowsName As String, ByVal strRowsVaule As String, ByVal strFields As String, ByVal strWriteValue As String) As Boolean
        Dim strCon As String
        Dim conn As System.Data.OleDb.OleDbConnection
        Dim strCommand As String
        Dim cmd As OleDbCommand

        Try
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFileFullPahtName & ";Jet OLEDB:Database Password=" & strPassWord
            conn = New System.Data.OleDb.OleDbConnection(strCon)   '建立连接
            conn.Open()                                            '打开连接 

            '表名及字段名最好用[]括起来，免得跟系统变量重名   
            'strCommand = "INSERT INTO [" & strSheetName & "$] (" & strFields & ") values (" & strWriteValue & ")"
            strCommand = "UPDATE [" & strSheetName & "] SET [" & strFields & "] = '" & strWriteValue & "' where [" & strRowsName & "] = '" & strRowsVaule & "'"
            cmd = New OleDbCommand(strCommand, conn)
            cmd.ExecuteNonQuery()

            conn.Close()
            WriteDataBase = True
        Catch ex As Exception
            WriteDataBase = False
            MessageBox.Show(ex.Message)
        End Try
    End Function

#Region "功能：写数据库"
    ''' <summary>
    ''' 功能：将DataSet写回数据库
    ''' </summary>
    ''' <param name="strFilePahtName">数据库所在的路径，带文件名</param>
    ''' <param name="strPassWord">数据库密码</param>
    ''' <param name="strSheetName">表名</param>
    ''' <param name="FormDataSet">要写入的DataSet</param>
    ''' <remarks></remarks>
    Public Sub WriteDataBaseFromDataset(ByVal strFilePahtName As String, ByVal strPassWord As String, ByVal strSheetName As String, FormDataSet As DataSet)
        Dim strCon As String
        Dim conn As System.Data.OleDb.OleDbConnection
        Dim odda As OleDbDataAdapter
        Dim ds As New DataSet
        Dim combuilder As OleDbCommandBuilder

        Try
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFilePahtName & ";Jet OLEDB:Database Password=" & strPassWord
            conn = New System.Data.OleDb.OleDbConnection(strCon)   '建立连接
            conn.Open()                                            '打开连接
            odda = New OleDbDataAdapter("SELECT * FROM " & strSheetName, conn) '用指定的表来建立DataAdapter 

            combuilder = New OleDbCommandBuilder(odda)
            combuilder.QuotePrefix = "["                           '这是为了适应,字段名和表名与数据库中的关键字重名,所以需要以此[]进行驱分
            combuilder.QuoteSuffix = "]" 
            odda.Update(FormDataSet)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#End Region
 
#Region "功能：从数据库中筛选数据"

#End Region

#Region "功能：删除表格数据"
    Public Sub DataBaseDelete()

    End Sub
#End Region

#Region "XML创建文件"
    Public Sub CreatXml(ByVal XmlFileName As String)
        Try
            Dim writer As New Xml.XmlTextWriter(XmlFileName, System.Text.Encoding.GetEncoding("utf-8"))
            writer.Formatting = Xml.Formatting.Indented
            writer.WriteRaw("<System Parameter Save>")
            writer.WriteStartElement("Config")
            'writer.WriteEndElement()
            writer.WriteFullEndElement()
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
#End Region

#Region "XML文件写"
    Public Sub WriteXml(ByVal XmlFileName As String, ByRef WriteData As Object)
        Try
            If Dir(XmlFileName, vbDirectory) = "" Then MkDir(XmlFileName)
            Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Object))
            Dim file As New System.IO.StreamWriter(XmlFileName)
            writer.Serialize(file, WriteData)
            file.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
#End Region

#Region "XML文件读"
    Public Sub ReadXml(ByVal XmlFileName As String, ByRef ReadData As Object)
        Try
            If Dir(XmlFileName, vbDirectory) = "" Then MkDir(XmlFileName)
            Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(Object))
            Dim file As New System.IO.StreamReader(XmlFileName)
            ReadData = CType(reader.Deserialize(file), Object)
            file.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
#End Region

End Module

