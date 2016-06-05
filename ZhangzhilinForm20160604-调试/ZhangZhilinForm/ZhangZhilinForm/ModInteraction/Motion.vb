Module ModMotionCard

#Region "初始化两张运动控制卡对象"
    Public clsMotCard0 As New MotionCard(MotionCard.MotionCardNames.GTS800, 0)
    Public clsMotCard1 As New MotionCard(MotionCard.MotionCardNames.GTS800, 1)
#End Region

#Region "分配卡号,轴号"
     
    Public Const S2_X As Integer = 0 
    Public Const S2_Y As Integer = 1
    Public Const S2_Z As Integer = 2
    Public Const S3_X As Integer = 3
    Public Const S3_Y As Integer = 4
    Public Const S3_Z As Integer = 5
    Public Const S3_R As Integer = 6
    Public Const Y1 As Integer = 7
    Public Const S4_X As Integer = 8
    Public Const S4_Y As Integer = 9
    Public Const S4_Z As Integer = 10
    Public Const SM_R As Integer = 11
    Public Const Y2 As Integer = 12
    Public Const Z1 As Integer = 13
    Public Const Z2 As Integer = 14

    ''' <summary>
    ''' 返回轴对应的卡
    ''' </summary>
    ''' <param name="AxisNum">轴名:如S2_X等</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Card(AxisNum As Integer) As MotionCard
        Select Case AxisNum
            Case 0, 1, 2, 3, 4, 5, 6, 7
                Card = clsMotCard0
            Case Else
                Card = clsMotCard1
        End Select
    End Function

    ''' <summary>
    ''' 返回轴对应的轴号
    ''' </summary>
    ''' <param name="AxisNum"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Axis(AxisNum As Integer) As Integer
        Axis = AxisNum Mod 8
    End Function

#End Region
 
#Region "轴运动参数变量"
    ''' <summary>
    ''' 读取轴参数,读取到的轴参数DataSet
    ''' </summary>
    ''' <remarks></remarks>
    Public dsAxisPar As DataSet

    ''' <summary>
    ''' AxisItem数组,将此数组是为了分配给轴卡的,定义14,是因为此机台只有15个轴
    ''' </summary>
    ''' <remarks></remarks>
    Dim AxisItems(14) As MotionCard.AxisItems

#End Region

#Region "运动参数读写及写入轴卡对象"
    ''' <summary>
    ''' 读取到dsAxisPar这个变量,将其绑定到参数设定界面的表格
    ''' </summary>
    ''' <param name="temp"></param>
    ''' <remarks></remarks>
    Public Sub AxisParToDataGrid(temp As DataGridView)
        Dim strTemp As String
        Dim DataSetVar As DataSet
        '先连接上数据库，并将数据读取成DataSet类
        strTemp = ReadDataBase(strFilePath(5), "123", "AxisPar", 1, 1, DataSetVar)
        If DataSetVar IsNot Nothing Then
            dsAxisPar = DataSetVar
            temp.DataSource = dsAxisPar.Tables(0)
        Else
            MessageBox.Show("读取轴参数失败")
        End If
    End Sub

    ''' <summary>
    ''' 保存轴参数,将DataSet对象写入到数据库中
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub DataGridViewTODB()
        WriteDataBaseFromDataset(strFilePath(5), "123", "AxisPar", dsAxisPar)
    End Sub

    ''' <summary>
    ''' 将读取到的DataSet中的数据填充更新到AxisItems(i)数组中
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub AxisParToAxisItems()
        Dim SN() As DataRow
        For i = 0 To AxisItems.Length - 1
            SN = dsAxisPar.Tables(0).Select("ID = " & i)
            AxisItems(i) = New MotionCard.AxisItems
            AxisItems(i).AxisNum = SN(0).Item("AxisNum")
            AxisItems(i).PulsePerRpm = SN(0).Item("PulsePerRpm")
            AxisItems(i).Lead = SN(0).Item("Lead")
            AxisItems(i).Ratio = SN(0).Item("Ratio")
            AxisItems(i).MoveSpeed = SN(0).Item("MoveSpeed")
            AxisItems(i).HomeSpeed = SN(0).Item("HomeSpeed")
            AxisItems(i).HomeSpeedLow = SN(0).Item("HomeSpeedLow")
            AxisItems(i).Acc = SN(0).Item("Acc")
            AxisItems(i).Dec = SN(0).Item("Dec")
            AxisItems(i).HomeOffset = SN(0).Item("HomeOffset")
            AxisItems(i).HomeSearchDis = SN(0).Item("HomeSearchDis")
            AxisItems(i).HomeTimeout = SN(0).Item("HomeTimeOut")
            AxisItems(i).HomeDirection = SN(0).Item("HomeDirection")
            AxisItems(i).IsRotate = SN(0).Item("IsRotate")
        Next
    End Sub

    ''' <summary>
    ''' 完成读取参数所有动作(以上功能的总成)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadAxisPar()
        Dim a, b As Integer

        '第一步,读取数据库到DataSet,并在DataGrid中去显示
        Call AxisParToDataGrid(frmPar.DataGridViewAxisPar)

        '第二步,将DataSet中的数据读取到AxisItems中
        Call AxisParToAxisItems()

        '第三步,将AxisItems更新至运动控制卡对象
        clsMotCard0.AxisItemsAttribute.Clear()
        clsMotCard1.AxisItemsAttribute.Clear()
        For i = 0 To AxisItems.Length - 1
            a = i \ 8 : b = i Mod 8
            If a = 0 Then
                clsMotCard0.AxisItemsAttribute.Add(AxisItems(b))
            ElseIf a = 1 Then
                clsMotCard1.AxisItemsAttribute.Add(AxisItems(b))
            End If
        Next
    End Sub

#End Region

#Region "控制卡对象相关操作函数"
    ''' <summary>
    ''' 轴卡初始化
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitMotionCard()
        Try
            clsMotCard0.MotionInit(strFilePath(2))
            clsMotCard0.MotionExtInit(strFilePath(3))
            clsMotCard1.MotionInit(strFilePath(4))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 读取急停状态
    ''' </summary>
    ''' <returns>true表示急停中,false表示正常</returns>
    ''' <remarks></remarks>
    Public Function Is_E_StopTrigger() As Boolean
        Is_E_StopTrigger = IIf(clsMotCard0.Get_X_bit(0, 15, False) = 1 Or clsMotCard1.Get_X_bit(0, 15, False) = 1, True, False) '设备紧急停止信号触发
    End Function

#End Region


























End Module
