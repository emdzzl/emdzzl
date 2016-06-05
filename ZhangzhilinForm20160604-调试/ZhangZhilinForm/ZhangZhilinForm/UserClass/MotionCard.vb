Imports System.Threading
Public Class MotionCard
#Region "私有变量"
    ''' <summary>
    ''' 运动控制卡名属性
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MotionCardNames
        GTS800
        GTS400
    End Enum

    ''' <summary>
    ''' 运动控制卡名属性
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _MotionCardName As MotionCardNames

    ''' <summary>
    ''' 运动控制卡序号
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _MotionCardNum As Integer

    ''' <summary>
    ''' 控制卡是否被打开
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _bolCardOpenFlag As Boolean

    ''' <summary>
    ''' 运动控制卡开始轴号
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _FirstAxis As Integer

    ''' <summary>
    ''' 运动控制卡结束轴号
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _LastAxis As Integer

    ''' <summary>
    ''' 运动控制卡总轴数
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _AxisTotalNum As Integer

    ''' <summary>
    ''' 控制卡扩展模块是否被打开
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _bolCardExtOpenFlag As Boolean

    ''' <summary>
    ''' 轴参数集合
    ''' </summary>
    ''' <remarks></remarks>
    Private Property _AxisItems As AxisItemsCollection

    ''' <summary>
    ''' 最终传递给轴卡的运行参数的结构体
    ''' </summary>
    ''' <remarks></remarks>
    Private Structure AxisPar
        Dim dAcc As Double         '最终传递给轴卡的加速度单位puls/ms2
        Dim dDec As Double         '最终传递给轴卡的减速度单位puls/ms2
        Dim dSpeed As Double       '最终传递给轴卡的运行速度单位puls/ms
        Dim dHomeSpeed As Double   '最终传递给轴卡的回零速度单位puls/ms
        Dim dHomeOffset As Double  '最终传递给轴卡的回零偏移值单位puls
        Dim dDistanceRate As Double '距离倍率,将mm转换成puls的倍率
        Dim iHomeTimeOut As Integer '找原点超时时间设备单位ms
        Dim iHomeDirector As Integer '找原点方向,只能为+1或-1
        Dim dHomeSpeedLow As Double  '找原点低速单位puls/ms
        Dim dHomeSearchDis As Double '原点搜索距离单位puls
    End Structure

    ''' <summary>
    ''' 最终传递给轴卡的运行参数的结构体实体
    ''' </summary>
    ''' <remarks></remarks>
    Private sAxisPar() As AxisPar

#End Region

#Region "私有方法" 
    ''' <summary>
    ''' 将十进制数转成二进制数
    ''' </summary>
    ''' <param name="Dec"></param>
    ''' <param name="num"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DecToBin(ByVal Dec As Long, ByVal num As Integer) As Integer
        Dim i, j As Long
        Dim Bin As String
        j = Dec
        Bin = ""
        Do While j > 0
            i = j Mod 2
            Bin = CStr(Trim(i)) & Bin
            j = j \ 2
        Loop
        Bin = StrReverse(Bin)
        Bin = Bin & "00000000000000000000"
        DecToBin = CInt(Mid(Bin, num + 1, 1))
    End Function

    ''' <summary>
    ''' 将十进制数转成二进制数
    ''' </summary>
    ''' <param name="Dec"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DecToBin1(Dec As Long) As String
        DecToBin1 = ""
        Do While Dec > 0
            DecToBin1 = Dec Mod 2 & DecToBin1
            Dec = Dec \ 2
        Loop
        If DecToBin1 = "" Then
            DecToBin1 = "0000000000000000"
        Else
            DecToBin1 = "0000000000000000" & DecToBin1
            DecToBin1 = Right(DecToBin1, 16)
        End If
    End Function

    Private DelayFlag As Integer
    Private Declare Function GetTickCount Lib "kernel32" () As Integer
    Private Function Delay(delayTime As Long) As Boolean
        Dim TT As Long
        If DelayFlag = 0 Then
            TT = GetTickCount
            DelayFlag = 1
        End If
        Do
            My.Application.DoEvents()
            If GetTickCount - TT < 0 Then
                TT = GetTickCount
            End If
        Loop Until GetTickCount - TT >= delayTime
        Return True
        DelayFlag = 0
    End Function 

    Private Function CalMotinRate(AxisNum As Integer) As Integer
        Dim dAccRate, dDecRate As Double
        Dim dDistanceRate As Double
        Dim dSpeedRate As Double

        '计算dDistanceRate
        If AxisItemsAttribute.Item(AxisNum.ToString).IsRotate Then
            '将mm转换成puls的倍率
            dDistanceRate = (AxisItemsAttribute.Item(AxisNum.ToString).PulsePerRpm * AxisItemsAttribute.Item(AxisNum.ToString).Ratio) / 360
        Else
            '将mm转换成puls的倍率
            dDistanceRate = (AxisItemsAttribute.Item(AxisNum.ToString).PulsePerRpm * AxisItemsAttribute.Item(AxisNum.ToString).Ratio) / _
                            (AxisItemsAttribute.Item(AxisNum.ToString).Lead)
        End If

        '将mm/s2转换成puls/ms2的倍率              /除以得到的值包含小数点后           \除以得到的值为整数
        dAccRate = dDistanceRate / (1000 * 1000)
        dDecRate = dDistanceRate / (1000 * 1000)

        '将mm/s转换成puls/ms
        dSpeedRate = dDistanceRate / 1000

        '转换成对应距离单位为Puls,时间单位为mm
        sAxisPar(AxisNum).dAcc = AxisItemsAttribute.Item(AxisNum.ToString).Acc * dAccRate
        sAxisPar(AxisNum).dDec = AxisItemsAttribute.Item(AxisNum.ToString).Dec * dDecRate
        sAxisPar(AxisNum).dSpeed = AxisItemsAttribute.Item(AxisNum.ToString).MoveSpeed * dSpeedRate
        sAxisPar(AxisNum).dHomeSpeed = AxisItemsAttribute.Item(AxisNum.ToString).HomeSpeed * dSpeedRate
        sAxisPar(AxisNum).dHomeOffset = AxisItemsAttribute.Item(AxisNum.ToString).HomeOffset * dDistanceRate
        sAxisPar(AxisNum).dDistanceRate = dDistanceRate
        sAxisPar(AxisNum).iHomeTimeOut = AxisItemsAttribute.Item(AxisNum.ToString).HomeTimeout
        sAxisPar(AxisNum).dHomeSpeedLow = AxisItemsAttribute.Item(AxisNum.ToString).HomeSpeedLow * dSpeedRate
        sAxisPar(AxisNum).dHomeSearchDis = AxisItemsAttribute.Item(AxisNum.ToString).HomeSearchDis * dDistanceRate

        '确认方向
        If AxisItemsAttribute.Item(AxisNum.ToString).HomeDirection = "+" Then
            sAxisPar(AxisNum).iHomeDirector = 1
        ElseIf AxisItemsAttribute.Item(AxisNum.ToString).HomeDirection = "-" Then
            sAxisPar(AxisNum).iHomeDirector = -1
        Else
            sAxisPar(AxisNum).iHomeDirector = 1
        End If

        Return 0
    End Function
#End Region

#Region "属性"
    ''' <summary>
    ''' 运动控制卡名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MotionCardName() As MotionCardNames
        Get
            Return _MotionCardName
        End Get
        Set(value As MotionCardNames)
            If value <> MotionCardNames.GTS800 And value <> MotionCardNames.GTS400 Then
                Throw New Exception("MotionCardName属性设置错误")
            Else
                _MotionCardName = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' 运动控制卡序号0-7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MotionCardNum() As Integer
        Get
            Return _MotionCardNum
        End Get
        Set(value As Integer)
            If value < 0 Or value > 7 Then
                Throw New Exception("MotionCardNum属性设置错误，只能设置为0-7")
            Else
                _MotionCardNum = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' 运动控制卡是否打开标志位
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property bolCardOpenFlag() As Boolean
        Get
            Return _bolCardOpenFlag
        End Get
    End Property

    ''' <summary>
    ''' 运动控制卡开始轴号,只能设置0-7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FirstAxis() As Integer
        Get
            Return _FirstAxis
        End Get
        Set(value As Integer)
            If value < 0 Or value > 7 Then
                Throw New Exception("FirstAxis属性设置错误，只能设置为0-7")
            Else
                _FirstAxis = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' 运动控制卡结束轴号,只能设置0-7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LastAxis() As Integer
        Get
            Return _LastAxis
        End Get
        Set(value As Integer)
            If value < 0 Or value > 7 Then
                Throw New Exception("FirstAxis属性设置错误，只能设置为0-7")
            Else
                _LastAxis = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' 运动控制卡扩展模块是否打开标志位
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property bolCardExtOpenFlag() As Boolean
        Get
            Return _bolCardExtOpenFlag
        End Get
    End Property

    ''' <summary>
    ''' 运行控制卡总轴数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AxisTotalNum() As Integer
        Get
            Return _AxisTotalNum
        End Get
    End Property

    ''' <summary>
    ''' 轴参数集合
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AxisItemsAttribute() As AxisItemsCollection
        Get
            Return _AxisItems
        End Get
        Set(value As AxisItemsCollection)
            _AxisItems = value
        End Set
    End Property

#End Region

#Region "事件"
    ''' <summary>
    ''' 异常数据
    ''' </summary>
    ''' <param name="ex"></param>
    ''' <remarks></remarks>
    Public Event Exception(ByVal ex As Exception)
#End Region

#Region "方法"
    ''' <summary>
    ''' 构建函数
    ''' </summary>
    ''' <param name="nMotionCardName">运动控制卡名称,只能为MotionCardNames类型</param>
    ''' <param name="nMotionCardNum">运动控制卡号,只能设置为0-7</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal nMotionCardName As MotionCardNames, ByVal nMotionCardNum As Integer)
        '构建时就填充此属性
        MotionCardName = nMotionCardName
        MotionCardNum = nMotionCardNum

        '构建时赋初值的属性,此给此卡使用的开始轴号与结束轴号赋初值,默认是全部轴都用
        If MotionCardName = MotionCardNames.GTS800 Then
            FirstAxis = 0
            LastAxis = 7
            _AxisTotalNum = 8
            ReDim sAxisPar(7)

            Call RedimHomePara(7)
        ElseIf MotionCardName = MotionCardNames.GTS400 Then
            FirstAxis = 0
            LastAxis = 3
            _AxisTotalNum = 4
            ReDim sAxisPar(4)

            Call RedimHomePara(4)
        End If

        '给AxisItemsAttribute集合类进行构建
        AxisItemsAttribute = New AxisItemsCollection

    End Sub

    ''' <summary>
    ''' 运动控制器初始化,OK返回0,NG返回其它
    ''' </summary> 
    ''' <param name="CFG">.cfg文件路径带文件名</param>
    ''' <returns>0为执行OK,1为执行NG,nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function MotionInit(CFG As String) As Integer
        Try
            Dim i As Integer
            Dim rtn As Integer

            '打开运行控制卡
            rtn = GT_SetCardNo(MotionCardNum)                                                   '设置运行控制卡卡号
            rtn = GT_Open(MotionCardNum)                                                    '打开运动控制卡
            If rtn = 0 Then                                                                 '判断运动控制卡是否成功打开
                _bolCardOpenFlag = True                                                     '运动控制卡打开成功标志则置True 
            Else
                _bolCardOpenFlag = False                                                    '运动控制卡打开失败标志则置False 
                Throw New Exception("MotionInit运动控制卡" & MotionCardNum & "打开失败！")            '抛出异常
                Return 1
                Exit Function
            End If

            '写入配置文件
            rtn = GT_Reset(MotionCardNum)                                                       '复位运动控制器
            rtn = GT_LoadConfig(MotionCardNum, CFG)             '载入运动控制器轴配置文件
            If Not rtn = 0 Then
                Throw New Exception("MotionInit运动控制卡" & MotionCardNum & "配置文件载入失败！") '抛出异常
                Return 1
                Exit Function
            End If

            '清除报警及打开伺服使能
            For i = FirstAxis To LastAxis Step 1
                rtn = GT_ClrSts(MotionCardNum, i + 1, 1)                                             '清除1-8轴的报警标志
                rtn = GT_AxisOn(MotionCardNum, i + 1)                                                '打开1-8轴的伺服使能
                If Not rtn = 0 Then
                    Throw New Exception(MotionCardNum & " 号卡 " & i & " 号轴伺服ON打开失败！")
                    Return 1
                    Exit Function
                End If
            Next i

            '返回值,OK返回0
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 运动控制器扩展模块初始化,OK返回0,NG返回其它
    ''' </summary> 
    ''' <param name="CFG">.cfg文件路径带文件名</param>
    ''' <returns>0为执行OK,1为执行NG,nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function MotionExtInit(CFG As String) As Integer
        Try
            Dim i As Integer
            Dim rtn As Integer

            '打开运行控制卡                                                                    
            rtn = GT_OpenExtMdlGts(MotionCardNum, "gts.dll")                                   '打开运动控制卡扩展模块
            If rtn = 0 Then                                                                    '判断运动控制扩展模块是否成功打开
                _bolCardExtOpenFlag = True                                                     '运动控制卡扩展模块打开成功标志则置True 
            Else
                _bolCardExtOpenFlag = False                                                    '运动控制卡扩展模块打开失败标志则置False 
                Throw New Exception("MotionInit运动控制卡扩展模块打开失败！")                  '抛出异常
                Return 1
                Exit Function
            End If

            '写入配置文件 
            rtn = GT_ResetExtMdlGts(MotionCardNum)                                              '复位运动控制器控制模块
            rtn = GT_LoadExtConfigGts(MotionCardNum, CFG)                                       '载入运动控制器扩展模块配置文件
            If Not rtn = 0 Then
                Throw New Exception("MotionInit运动控制卡扩展模块配置文件载入失败！")        '抛出异常
                Return 1
                Exit Function
            End If

            '再次复位运动控制器控制模块
            rtn = GT_ResetExtMdlGts(MotionCardNum)

            '返回值,OK返回0
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 读取单个输入点函数
    ''' </summary>
    ''' <param name="ExtMouduleNum">此轴卡中的扩展模块号,如果不是扩展模块则可以为任何数字</param>
    ''' <param name="i">要读取的IO点序号0-15</param>
    ''' <param name="IsExtMoudle">是否是扩展模块</param>
    ''' <returns>0表示有信号输入,1表示无信号输入,Nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function Get_X_bit(ExtMouduleNum As Integer, i As Integer, ByVal IsExtMoudle As Boolean) As Integer
        Dim CardExI As Long
        Dim rtn As Integer
         
        If IsExtMoudle Then
            rtn = GT_GetExtIoValueGts(MotionCardNum, ExtMouduleNum, CardExI)
            If rtn <> 0 Then Return 1
        Else
            rtn = GT_GetDi(MotionCardNum, MC_GPI, CardExI)
            If rtn <> 0 Then Return 1
        End If
        Get_X_bit = Val(CardExI And 2 ^ (i))
        If Get_X_bit <> 0 Then Get_X_bit = 1
        Return Get_X_bit
    End Function

    ''' <summary>
    ''' 读取单个输出点函数
    ''' </summary>
    ''' <param name="ExtMouduleNum">此轴卡中的扩展模块号,如果不是扩展模块则可以为任何数字</param>
    ''' <param name="i">要读取的IO点序号0-15</param>
    ''' <param name="IsExtMoudle">是否是扩展模块</param>
    ''' <returns>0表示有信号输出,1表示无信号输出,Nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function Get_Y_bit(ExtMouduleNum As Integer, i As Integer, ByVal IsExtMoudle As Boolean) As Integer
        Dim CardExO As Long
        Dim rtn As Integer
         
        If IsExtMoudle Then
            rtn = GT_GetExtDoValueGts(MotionCardNum, ExtMouduleNum, CardExO)
            If rtn <> 0 Then Return 1
        Else
            rtn = GT_GetDo(MotionCardNum, MC_GPO, CardExO)
            If rtn <> 0 Then Return 1
        End If
        Get_Y_bit = Val(CardExO And 2 ^ (i))
        If Get_Y_bit <> 0 Then Get_Y_bit = 1
        Return Get_Y_bit
        
    End Function

    ''' <summary>
    ''' 置位单个输出点函数
    ''' </summary>
    ''' <param name="ExtMouduleNum">此轴卡中的扩展模块号,如果不是扩展模块则可以为任何数字</param>
    ''' <param name="YNum">要设置的IO点序号0-15</param>
    ''' <param name="value">要设置的值0表示置位,1表示复位</param>
    ''' <param name="IsExtMoudle">是否是扩展模块</param>
    ''' <returns>0为执行OK,1为执行NG</returns>
    ''' <remarks></remarks>
    Public Function Set_Y_bit(ExtMouduleNum As Integer, YNum As Integer, value As Integer, ByVal IsExtMoudle As Boolean) As Integer
        Dim rtn As Integer 
        If IsExtMoudle Then
            rtn = GT_SetExtIoBitGts(MotionCardNum, ExtMouduleNum, YNum, CUShort(value))
            If rtn <> 0 Then Return 1
        Else
            rtn = GT_SetDoBit(MotionCardNum, MC_GPO, YNum + 1, value)
            If rtn <> 0 Then Return 1
        End If
        Return 0
    End Function

    ''' <summary>
    ''' JOG连续运动模式子程序
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param> 
    ''' <param name="Direction">方向"+" or "-"</param> 
    ''' <returns>0为执行OK,1为执行NG</returns>
    ''' <remarks></remarks>
    Public Function JogMotion(ByVal AxisNum As Integer, ByVal Direction As String) As Integer
        Dim rtn As Integer
        Dim dir As Integer
        Dim JogPrm As TJogPrm
         
        If Direction = "+" Then                                                         '当前轴正向运动方向判定
            dir = 1
        ElseIf Direction = "-" Then                                                     '当前轴负向运动方向判定
            dir = -1
        End If

        Call CalMotinRate(AxisNum)                                                      '读取最终运行参数
        rtn = GT_ClrSts(MotionCardNum, AxisNum + 1)
        rtn = GT_PrfJog(MotionCardNum, AxisNum + 1)
        rtn = GT_GetJogPrm(MotionCardNum, AxisNum + 1, JogPrm)
        'JogPrm.acc单位为脉冲/ms2
        JogPrm.acc = sAxisPar(AxisNum).dAcc
        JogPrm.dec = sAxisPar(AxisNum).dDec
        rtn = GT_SetJogPrm(MotionCardNum, AxisNum + 1, JogPrm)
        If rtn <> 0 Then Return 1
        rtn = GT_SetVel(MotionCardNum, AxisNum + 1, sAxisPar(AxisNum).dSpeed * dir)      '设置当前轴的目标速度
        If rtn <> 0 Then Return 1
        rtn = GT_Update(MotionCardNum, 2 ^ AxisNum)                                      '启动当前轴运动
        If rtn <> 0 Then Return 1
        Return 0
        
    End Function

    ''' <summary>
    ''' 功能：STEP单步运动模式子程序(因为与RealMotion函数功能重合)
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <param name="Dist">距离:单位mm</param>
    ''' <param name="Direction">方向"+" or "-"</param>
    ''' <returns>0为执行OK,1为执行NG</returns>
    ''' <remarks></remarks>
    Public Function StepMotion(ByVal AxisNum As Integer, ByVal Dist As Double, ByVal Direction As String) As Integer
        Dim rtn As Integer
        Dim dir As Integer
        Dim EncPosTmpl As Double

        If Direction = "+" Then                                                           '当前轴正向运动方向判定
            dir = 1
        ElseIf Direction = "-" Then                                                       '当前轴负向运动方向判定
            dir = -1
        End If
        Call CalMotinRate(AxisNum)                                                         '读取最终运行参数
        rtn = GT_GetEncPos(MotionCardNum, AxisNum + 1, EncPosTmpl)
        If rtn <> 0 Then Return 1
        Call AbsMotion(AxisNum, EncPosTmpl / sAxisPar(AxisNum).dDistanceRate + dir * Dist)
        Return 0
    End Function

    ''' <summary>
    ''' 功能：Abs绝对运动模式子程序
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <param name="position">位置:单位mm</param>
    ''' <returns>0为执行OK,1为执行NG</returns>
    ''' <remarks></remarks>
    Public Function AbsMotion(AxisNum As Integer, position As Double) As Integer
        Dim rtn As Integer
        Dim TrapPrm As TTrapPrm
        Dim mode As Long

        Call CalMotinRate(AxisNum)                                                           '读取最终运行参数
        rtn = GT_ClrSts(MotionCardNum, AxisNum + 1)                                          '清除当前轴的错误标志
        rtn = GT_GetPrfMode(MotionCardNum, AxisNum + 1, mode, 1, 0)
        rtn = GT_PrfTrap(MotionCardNum, AxisNum + 1)                                         '设置指定轴为点位模式
        rtn = GT_GetTrapPrm(MotionCardNum, AxisNum + 1, TrapPrm)                             '读取点位模式运动参数
        TrapPrm.acc = sAxisPar(AxisNum).dAcc
        TrapPrm.dec = sAxisPar(AxisNum).dDec
        position = position * sAxisPar(AxisNum).dDistanceRate                                '将目标位置由mm转换成puls
        rtn = GT_SetTrapPrm(MotionCardNum, AxisNum + 1, TrapPrm)                             '设置点位模式运动参数
        If rtn <> 0 Then Return 1
        rtn = GT_SetVel(MotionCardNum, AxisNum + 1, sAxisPar(AxisNum).dSpeed)                '设置目标速度
        If rtn <> 0 Then Return 1
        rtn = GT_SetPos(MotionCardNum, AxisNum + 1, CDbl(position))                          '设置目标位置
        If rtn <> 0 Then Return 1
        rtn = GT_Update(MotionCardNum, 2 ^ AxisNum)                                          '启动当前轴运动
        If rtn <> 0 Then Return 1
        Return 0
         
    End Function

    ''' <summary>
    ''' 功能：Real相对运动模式子程序
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <param name="Dist">距离:单位mm,带正负号</param>
    ''' <returns>0为执行OK,1为执行NG</returns>
    ''' <remarks></remarks>
    Public Function RealMotion(ByVal AxisNum As Integer, ByVal Dist As Double) As Integer
        Dim rtn As Integer
        Dim TrapPrm As TTrapPrm
        Dim dpos, dvel As Double
        Dim EncPosTmpl As Double
        Dim lmode As Long

        Call CalMotinRate(AxisNum)                                                           '读取最终运行参数
        rtn = GT_ClrSts(MotionCardNum, AxisNum + 1)                                          '清除当前轴的错误标志
        rtn = GT_GetPrfMode(MotionCardNum, AxisNum + 1, lmode, 1, 0)
        rtn = GT_PrfTrap(MotionCardNum, AxisNum + 1)                                         '将当前轴设置为点位运动模式
        rtn = GT_GetTrapPrm(MotionCardNum, AxisNum + 1, TrapPrm)                             '读取当前轴点位模式运动参数
        rtn = GT_GetEncPos(MotionCardNum, AxisNum + 1, EncPosTmpl)                           '读取当前编码器位置
        TrapPrm.acc = sAxisPar(AxisNum).dAcc                                                 '载入当前轴的加速度
        TrapPrm.dec = sAxisPar(AxisNum).dDec                                                 '载入当前轴的减速度
        rtn = GT_SetTrapPrm(MotionCardNum, AxisNum + 1, TrapPrm)                             '设置当前轴加速度、减速度、起跳速度、平滑时间
        If rtn <> 0 Then Return 1
        dvel = CDbl(sAxisPar(AxisNum).dSpeed)                                                '(*计算目标速度脉冲频率*)
        dpos = CDbl(Dist * sAxisPar(AxisNum).dDistanceRate + EncPosTmpl)                                  '(*计算目标位置脉冲数量*)
        rtn = GT_SetVel(MotionCardNum, AxisNum + 1, dvel)                                    '设置当前轴的目标速度
        If rtn <> 0 Then Return 1
        rtn = GT_SetPos(MotionCardNum, AxisNum + 1, dpos)                                    '设置当前轴的目标位置 
        If rtn <> 0 Then Return 1
        rtn = GT_Update(MotionCardNum, 2 ^ AxisNum)                                          '启动当前轴运动
        If rtn <> 0 Then Return 1
        Return 0
    End Function

    ''' <summary>
    ''' "功能：获取原点状态"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>原点OK则返回0,原点NG则返回1</returns>
    ''' <remarks></remarks>
    Public Function HomeBit(AxisNum As Integer) As Integer
        Dim lTmplData As Long
        Dim rtn As Integer

        rtn = GT_GetDi(MotionCardNum, MC_HOME, lTmplData)
        If rtn <> 0 Then Return 1
        HomeBit = Val(lTmplData And 2 ^ (AxisNum))
        Return HomeBit 
    End Function

    ''' <summary>
    ''' 功能：获取报警状态
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>有报警返回0,无报警则返回1</returns>
    ''' <remarks></remarks>
    Public Function AxisAlarm(AxisNum As Integer) As Integer
        Dim lTmplData As Long
        Dim rtn As Integer

        rtn = GT_GetDi(MotionCardNum, MC_ALARM, lTmplData)
        If rtn <> 0 Then Return 0
        AxisAlarm = Val(lTmplData And 2 ^ (AxisNum))
        If AxisAlarm > 0 Then Return 0 Else Return 1 
    End Function

    ''' <summary>
    ''' "功能：获取正极限状态"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>有限位信号返回0,无限位信号返回1</returns>
    ''' <remarks></remarks>
    Public Function LimitZ(AxisNum As Integer) As Integer
        Dim lTmplData As Long
        Dim rtn As Integer

        rtn = GT_GetDi(MotionCardNum, MC_LIMIT_POSITIVE, lTmplData)
        If rtn <> 0 Then Return 0
        LimitZ = Val(lTmplData And 2 ^ (AxisNum))
        If LimitZ > 0 Then Return 0 Else Return 1 
    End Function

    ''' <summary>
    ''' "功能：获取负极限状态"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>有负限位信号返回0,无信号则返回1</returns>
    ''' <remarks></remarks>
    Public Function LimitF(AxisNum As Integer) As Integer
        Dim lTmplData As Long
        Dim rtn As Integer

        rtn = GT_GetDi(MotionCardNum, MC_LIMIT_NEGATIVE, lTmplData)
        If rtn <> 0 Then Return 0
        LimitF = Val(lTmplData And 2 ^ (AxisNum))
        If LimitF > 0 Then Return 0 Else Return 1 
    End Function

    ''' <summary>
    ''' "功能：获取伺服ON/OFF状态"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>有信号则返回0,无信号则返回1,Nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function Get_ServoOn(AxisNum As Integer) As Integer
        Dim rtn As Integer
        Dim lSts(0 To 8) As Long

        rtn = GT_GetSts(MotionCardNum, AxisNum + 1, lSts(AxisNum), 1, 0)
        If rtn <> 0 Then Return 1
        If lSts(AxisNum) And &H200 Then                                      '32位状态字中的第9位为伺服使能状态
            Get_ServoOn = 0
        Else
            Get_ServoOn = 1
        End If
        Return Get_ServoOn
         
    End Function

    ''' <summary>
    ''' 功能:伺服使能开关
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <param name="value">0表示开使能,1表示关使能</param>
    ''' <returns>正常执行OK为0,,Nothing表示异常</returns>
    ''' <remarks></remarks>
    Public Function Set_ServoOn(AxisNum As Integer, ByVal value As Integer) As Integer
        Dim rtn As Integer

        If value = 0 Then
            rtn = GT_AxisOn(MotionCardNum, AxisNum + 1)
        Else
            rtn = GT_AxisOff(MotionCardNum, AxisNum + 1)
        End If
        If rtn <> 0 Then Return 1
        Return 0
    End Function

    ''' <summary>
    ''' "功能：读编码器值"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>正常返回当前编码器值,异常时抛出异常信息</returns>
    ''' <remarks></remarks>
    Public Function GetEncPos(AxisNum As Integer) As Double
        Dim dEncPosTmpl As Double
        Dim rtn As Integer

        rtn = GT_GetEncPos(MotionCardNum, AxisNum + 1, dEncPosTmpl, 1, 0)
        If rtn <> 0 Then Throw New Exception("GetEncPos指令读取编码器值失败")
        GetEncPos = dEncPosTmpl
        Return GetEncPos
    End Function

    ''' <summary>
    ''' "功能：读编码器值,将其转换成单位为mm"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>正常返回当前编码器值单位为mm,异常时抛出异常信息</returns>
    ''' <remarks></remarks>
    Public Function GetEncPosToMM(AxisNum As Integer) As Double
        Dim dEncPosTmpl As Double
        Dim rtn As Integer

        Call CalMotinRate(AxisNum)                                                           '读取最终运行参数
        rtn = GT_GetEncPos(MotionCardNum, AxisNum + 1, dEncPosTmpl, 1, 0)
        If rtn <> 0 Then Throw New Exception("GetEncPosToMM指令读取编码器值失败")
        GetEncPosToMM = dEncPosTmpl / sAxisPar(AxisNum).dDistanceRate
        Return GetEncPosToMM
       
    End Function

    ''' <summary>
    ''' "功能：读取规划位置"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>正常返回当前规划位置值,异常时抛出异常信息</returns>
    ''' <remarks></remarks>
    Public Function GetPrfPos(AxisNum As Integer) As Double
        Dim dPrfPosTmpl As Double
        Dim rtn As Integer

        rtn = GT_GetPrfPos(MotionCardNum, AxisNum + 1, dPrfPosTmpl, 1, 0)
        If rtn <> 0 Then Throw New Exception("GetPrfPos指令读取编码器值失败")
        GetPrfPos = dPrfPosTmpl
        Return GetPrfPos
    End Function

    ''' <summary>
    ''' "功能：读取规划位置,将其转换成单位为mm"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>正常返回当前规划位置值单位为mm,异常时抛出异常信息</returns>
    ''' <remarks></remarks>
    Public Function GetPrfPosToMM(AxisNum As Integer) As Double
        Dim dPrfPosTmpl As Double
        Dim rtn As Integer 
        Call CalMotinRate(AxisNum)                                                           '读取最终运行参数
        rtn = GT_GetPrfPos(MotionCardNum, AxisNum + 1, dPrfPosTmpl, 1, 0)
        If rtn <> 0 Then Throw New Exception("GetPrfPosToMM指令读取编码器值失败")
        GetPrfPosToMM = dPrfPosTmpl / sAxisPar(AxisNum).dDistanceRate
        Return GetPrfPosToMM
    End Function

    ''' <summary>
    ''' "功能：读取轴的运行状态32位状态字"
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>正常返回读取到的状态字,异常时抛出异常信息</returns>
    ''' <remarks></remarks>
    Public Function GetAxisStatus(AxisNum As Integer) As Long
        Dim rtn As Integer
        Dim AxisStatusTemp As Long

        rtn = GT_GetSts(MotionCardNum, AxisNum + 1, AxisStatusTemp)
        If rtn <> 0 Then Throw New Exception("GetAxisStatus指令读取编码器值失败")
        GetAxisStatus = AxisStatusTemp
        Return GetAxisStatus 
    End Function

    ''' <summary>
    ''' 运动到位
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>0表示运行到位,1表示还未到位,,Nothing表示异常</returns>
    ''' <remarks>若为步进电机,轴配置里面的encoder中的脉冲计数源配置为"脉冲计数器,Nothing表示异常"</remarks>
    Public Function ZSPD(AxisNum As Integer) As Integer
        Try
            If Math.Abs(GetPrfPos(AxisNum) - GetEncPos(AxisNum)) > 200 Then
                ZSPD = 1
            Else
                If (GetAxisStatus(AxisNum) And &H400) Then
                    ZSPD = 1
                Else
                    ZSPD = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & "From:ZSPD子函数")
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 功能:手动停止
    ''' </summary>
    ''' <param name="AxisNum">0-7</param>
    ''' <param name="Smooth">平滑停止为true,紧急停止为false</param>
    ''' <returns>正常执行OK为0,异常为1</returns>
    ''' <remarks></remarks>
    Public Function StopRun(AxisNum As Integer, Smooth As Boolean) As Integer
        Dim rtn As Integer
        Dim TempSmooth As Integer

        If Smooth Then TempSmooth = 0 Else TempSmooth = 2 ^ AxisNum
        rtn = GT_Stop(MotionCardNum, 2 ^ AxisNum, TempSmooth)
        If rtn <> 0 Then Return 1
        Return 0
         
    End Function

    ''' <summary>
    ''' 功能:判断轴是否停止
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns>轴停止返回0,其它返回1</returns>
    ''' <remarks></remarks>
    Public Function IsStop(AxisNum As Integer) As Integer
        Dim rtn As Integer
        Dim Status As Integer

        rtn = GT_GetSts(MotionCardNum, AxisNum + 1, Status, 1, 0)       '获取当前轴的状态
        If rtn <> 0 Then Return 1
        If CBool(Status And &H400) = False Then
            IsStop = 0
        Else
            IsStop = 1
        End If
        Return IsStop
    End Function
     
#Region "回原点相关"
    Private HomeThread As Thread
    Private HomeTheradLineMotion As Thread
    Private timer1 As System.Timers.Timer
    Private HomeStep() As Integer
    Private CurrentPos() As Double
    Private CurrentPosEnc() As Double
    Private Status() As Long
    Private TrapPrm() As TTrapPrm
    Private Tpos(), Tvel() As Double
    Private rtn() As Short
    Private HomeCapture() As Integer
    Private HomeTempPos() As Long
    Private HomeCounter() As Integer
    Private HomeTimeLinMot() As Long
    Private HomeStepLinMot() As Long
    Private rtnLinMot() As Integer
    Private CurrentPosLinMot() As Double
    Private CurrentPosEncLinMot() As Double
    Private HomeIO() As Integer
    Private HomeCard() As Integer
    Private TrapPrmLine() As TTrapPrm
    Private TposLine(), TvelLine() As Double
    Private HomeCaptureLine() As Integer
    Private HomeTempPosLine() As Long
    Private StatusLine() As Long

    Private Sub RedimHomePara(i As Integer)
        ReDim HomeStep(i)
        ReDim CurrentPos(i)
        ReDim CurrentPosEnc(i)
        ReDim Status(i)
        ReDim TrapPrm(i)
        ReDim Tpos(i)
        ReDim Tvel(i)
        ReDim rtn(i)
        ReDim HomeCapture(i)
        ReDim HomeTempPos(i)
        ReDim HomeCounter(i)
        ReDim HomeTimeLinMot(i)
        ReDim HomeStepLinMot(i)
        ReDim rtnLinMot(i)
        ReDim CurrentPosLinMot(i)
        ReDim CurrentPosEncLinMot(i)
        ReDim HomeIO(i)
        ReDim HomeCard(i)
        ReDim TrapPrmLine(i)
        ReDim TposLine(i)
        ReDim TvelLine(i)
        ReDim HomeCaptureLine(i)
        ReDim HomeTempPosLine(i)
        ReDim StatusLine(i)
    End Sub

    ''' <summary>
    ''' 功能:回原点,普通电机回原点
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function GoHome(AxisNum As Integer) As Integer
        '先检测线程是否结束掉,结束掉的话,得重新实例
        If IsNothing(HomeThread) Then
            HomeThread = New Thread(AddressOf GoHomeThread)
            HomeThread.Start()
        End If
        '判断当前轴是否在回零过程中
        If Not AxisItemsAttribute.Item(AxisNum.ToString).HomeRunnnig Then
            AxisItemsAttribute.Item(AxisNum.ToString).HomeRunnnig = True
            HomeStep(AxisNum) = 10 
        Else
            MessageBox.Show("此轴为" & AxisNum & "号轴,此轴正在初始中,不能再次进行初始化")
        End If
        Return 0
    End Function
     
    ''' <summary>
    ''' 功能:直线电机回原点
    ''' </summary>
    ''' <param name="AxisNum">轴号0-7</param>
    ''' <param name="IO">直线电机回原点信号点(IO点序号0-15)</param>
    ''' <param name="HomeIOCard">直线电机回原点信号点所属的卡号</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function GoHome(AxisNum As Integer, IO As Integer, ByVal HomeIOCard As Integer) As Integer
        '先检测线程是否结束掉,结束掉的话,得重新实例
        If IsNothing(HomeTheradLineMotion) Then
            HomeTheradLineMotion = New Thread(AddressOf GoHomeLineMotion)
            HomeTheradLineMotion.Start()
        End If
        '判断当前轴是否在回零过程中
        If Not AxisItemsAttribute.Item(AxisNum.ToString).HomeRunnnig Then
            AxisItemsAttribute.Item(AxisNum.ToString).HomeRunnnig = True
            HomeStepLinMot(AxisNum) = 10
            HomeIO(AxisNum) = IO
            HomeCard(AxisNum) = HomeIOCard
        Else
            MessageBox.Show("此轴为" & AxisNum & "号轴,此轴正在初始中,不能再次进行初始化")
        End If
        Return 0
    End Function

    Private Sub GoHomeThread()
        Dim en As Boolean = True
        Try
            While True
                '运行所有轴的回原点程序子程序
                For i = 0 To AxisTotalNum - 1
                    GoHomeThreadProcess(i)
                    en = en And (Not AxisItemsAttribute.Item(i.ToString).HomeRunnnig)
                Next
                If en = True Then Exit While
                Thread.Sleep(1)
            End While
            HomeThread.Abort()                  '.Abort方法引发异常
        Catch ex As Exception
            HomeThread = Nothing                '只有在异常处理时才能清理线程
        End Try
    End Sub

    Private Sub GoHomeLineMotion()
        Dim en As Boolean = True
        Try
            While True
                '运行所有轴的回原点程序子程序
                For i = 0 To AxisTotalNum - 1
                    GoHomeLineMoProcess(i, HomeIO(i), HomeCard(i))
                    en = en And (Not AxisItemsAttribute.Item(i.ToString).HomeRunnnig)
                Next
                If en = True Then Exit While
                Thread.Sleep(1)
            End While
            HomeTheradLineMotion.Abort()
        Catch ex As Exception                        '.Abort方法引发异常
            HomeTheradLineMotion = Nothing           '只有在异常处理时才能清理线程
        End Try
    End Sub

    Private Sub GoHomeThreadProcess(Axis1 As Integer)
        Call CalMotinRate(Axis1)                                                          '读取运动参数

        '回零异常处理
        rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)             '获取当前轴的状态
        If (Status(Axis1) And &H2) Or (Status(Axis1) And &H100) Then                      '检测驱动器报警和急停报警
            AxisItemsAttribute.Item(Axis1.ToString).HomeOK = False
            AxisItemsAttribute.Item(Axis1.ToString).HomeRunnnig = False
            HomeStep(Axis1) = 0
            HomeCounter(Axis1) = 0
            HomeCapture(Axis1) = 0
            HomeTempPos(Axis1) = 0
            rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                           '清除当前轴驱动器报警标志
        End If

        Select Case HomeStep(Axis1)
            Case 10
                AxisItemsAttribute.Item(Axis1.ToString).HomeRunnnig = True                '置位当前轴回原点中标志
                AxisItemsAttribute.Item(Axis1.ToString).HomeOK = False                    '复位原点OK标志位
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                       '清除当前轴驱动器报警标志
                rtn(Axis1) = GT_SetPrfPos(MotionCardNum, Axis1 + 1, 0)                    '将当前轴规划器位置修改为零点
                rtn(Axis1) = GT_SetEncPos(MotionCardNum, Axis1 + 1, 0)                    '将当前轴编码器位置修改为零点
                rtn(Axis1) = GT_SynchAxisPos(MotionCardNum, 2 ^ (Axis1))                  '将当前轴进行位置同步

                rtn(Axis1) = GT_PrfTrap(MotionCardNum, Axis1 + 1)                          '设置当前轴的运动模式为点位模式
                rtn(Axis1) = GT_GetTrapPrm(MotionCardNum, Axis1 + 1, TrapPrm(Axis1))       '获取当前轴点位模式运动参数
                TrapPrm(Axis1).acc = sAxisPar(Axis1).dAcc                                  '载入当前轴的加速度
                TrapPrm(Axis1).dec = sAxisPar(Axis1).dDec                                  '载入当前轴的减速度
                rtn(Axis1) = GT_SetTrapPrm(MotionCardNum, Axis1 + 1, TrapPrm(Axis1))       '设置当前轴点位模式运动参数
                rtn(Axis1) = GT_SetCaptureMode(MotionCardNum, Axis1 + 1, CAPTURE_HOME)     '启动当前轴的原点捕获
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeed)                                   '计算当前轴目标速度脉冲频率（原点搜索速度）
                Tpos(Axis1) = CLng(sAxisPar(Axis1).iHomeDirector * sAxisPar(Axis1).dHomeSearchDis) '计算当前轴目标位置脉冲数量（即原点搜索距离）
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))              '设置当前轴的目标速度（即原点搜索速度）
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))              '设置当前轴的目标位置（即原点搜索距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                           '启动当前轴点位运动
                HomeStep(Axis1) = 15                                                       '跳转到下一步 
            Case 15
                rtn(Axis1) = GT_GetCaptureStatus(MotionCardNum, Axis1 + 1, HomeCapture(Axis1), HomeTempPos(Axis1), 1, 0) '获取当前轴原点捕获的状态及捕获的当前位置
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)       '获取当前轴的状态
                If HomeCapture(Axis1) Then                                                  '判断当前轴是否原点捕获触发
                    HomeCapture(Axis1) = 0                                                  '当前轴原点捕获触发标志清零
                    HomeStep(Axis1) = 20
                ElseIf CBool(Status(Axis1) And &H400) = False Then                          '判断当前轴是否运动停止（原点搜索距离太小或触发极限）
                    HomeStep(Axis1) = 90                                                    '跳转到第90步（移过一段极限到原点的距离再重新搜索）
                End If
            Case 20
                rtn(Axis1) = GT_Stop(MotionCardNum, 2 ^ Axis1, 2 ^ Axis1)                   '捕获到原点则当前轴紧急停止 
                HomeStep(Axis1) = 25
            Case 25
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)       '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                              '判断当前轴是否运动停止 
                    HomeStep(Axis1) = 30
                End If
            Case 30
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                          '清除当前轴驱动器报警标志
                rtn(Axis1) = GT_GetPrfPos(MotionCardNum, Axis1 + 1, CurrentPos(Axis1), 1, 0) '获取当前轴当前位置
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                  '计算当前轴目标速度脉冲频率（第二次搜索原点的偏移速度）
                Tpos(Axis1) = CLng(CurrentPos(Axis1) - sAxisPar(Axis1).iHomeDirector * sAxisPar(Axis1).dDistanceRate * 10) '计算当前轴目标位置脉冲数量（第二次搜索原点的偏移10mm
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                '设置当前轴的目标速度
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                '设置当前轴的目标位置（即第二次搜索原点的偏移距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                             '启动当前轴点位运动（运动中进行原点位置修正）
                HomeStep(Axis1) = 35
            Case 35
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)        '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                               '判断当前轴是否运动停止
                    Delay(50)                                                                '延时50ms等待马达停稳 
                    HomeStep(Axis1) = 40
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''第二次搜索原点
            Case 40
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                           '清除当前轴驱动器报警标志 
                rtn(Axis1) = GT_SetCaptureMode(MotionCardNum, Axis1 + 1, CAPTURE_HOME)        '启动当前轴的原点捕获
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                  '计算当前轴目标速度脉冲频率（原点搜索速度）
                Tpos(Axis1) = CLng(sAxisPar(Axis1).dHomeSearchDis * sAxisPar(Axis1).iHomeDirector)  '计算当前轴目标位置脉冲数量（即原点搜索距离）
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                 '设置当前轴的目标速度（即原点搜索速度）
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                 '设置当前轴的目标位置（即原点搜索距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                              '启动当前轴点位运动 
                HomeStep(Axis1) = 45
            Case 45
                rtn(Axis1) = GT_GetCaptureStatus(MotionCardNum, Axis1 + 1, HomeCapture(Axis1), HomeTempPos(Axis1), 1, 0) '获取当前轴原点捕获的状态及捕获的当前位置
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)         '获取当前轴的状态
                If HomeCapture(Axis1) Then                                                    '判断当前轴是否原点捕获触发
                    HomeCapture(Axis1) = 0                                                    '当前轴原点捕获触发标志清零
                    HomeStep(Axis1) = 50
                ElseIf CBool(Status(Axis1) And &H400) = False Then                            '判断当前轴是否运动停止（原点搜索距离太小或触发极限）
                    AxisItemsAttribute.Item(Axis1.ToString).HomeOK = False                     '当前轴回原点失败(返回结果为FALSE)
                    HomeStep(Axis1) = 18                                                      '跳转到第16步（当前轴回原点完成，回原点失败）
                End If
            Case 50
                rtn(Axis1) = GT_Stop(MotionCardNum, 2 ^ Axis1, 0)                              '捕获到原点则当前轴平滑停止
                HomeStep(Axis1) = 55
            Case 55
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)          '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                                 '判断当前轴是否运动停止
                    Delay(50) '延时50ms等待马达停稳
                    HomeStep(Axis1) = 60
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''对第二次搜索到的原点信号进行修正（高速硬件捕获锁存位置）
            Case 60
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                            '清除当前轴驱动器报警标志
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                   '计算当前轴目标速度脉冲频率（即原点修正速度）
                Tpos(Axis1) = CLng(HomeTempPos(Axis1))                                              '在第二次回零时捕捉到的零点时的编码器位置（高速硬件捕获到的原点位置）
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                  '设置当前轴的目标速度（即原点修正速度）
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                  '设置当前轴的目标位置（即原点修正距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                               '启动当前轴点位运动（运动中进行原点位置修正）
                HomeStep(Axis1) = 65
            Case 65
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)          '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                                 '判断当前轴是否运动停止（原点修正完成）
                    Delay(50)                                                                  '原点修正完成延时50ms等待马达停稳
                    HomeStep(Axis1) = 70
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''移动固定的原点偏移量
            Case 70
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                     '计算目标速度脉冲频率（原点偏移速度）
                Tpos(Axis1) = CLng(HomeTempPos(Axis1) + sAxisPar(Axis1).dHomeOffset)                  '计算目标位置脉冲数量（即原点偏移距离）
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                   '设置当前轴的目标速度（即原点偏移速度）
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                   '设置当前轴的目标位置（即原点偏移距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1) '启动当前轴点位运动 
                HomeStep(Axis1) = 75
            Case 75
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)           '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                                  '判断当前轴是否运动停止（原点偏移完成）
                    Delay(50) '原点偏移完成延时200ms等待马达停稳
                    HomeStep(Axis1) = 80
                End If
            Case 80
                rtn(Axis1) = GT_SetPrfPos(MotionCardNum, Axis1 + 1, 0)                          '将当前轴规划器位置修改为零点
                rtn(Axis1) = GT_SetEncPos(MotionCardNum, Axis1 + 1, 0)                          '将当前轴编码器位置修改为零点
                rtn(Axis1) = GT_SynchAxisPos(MotionCardNum, 2 ^ Axis1)                          '将当前轴进行位置同步
                Delay(50)
                HomeStep(Axis1) = 85
            Case 85
                rtn(Axis1) = GT_GetPrfPos(MotionCardNum, Axis1 + 1, CurrentPos(Axis1), 1, 0)    '读取0号卡当前轴规划位置
                rtn(Axis1) = GT_GetEncPos(MotionCardNum, Axis1 + 1, CurrentPosEnc(Axis1), 1, 0) '读取0号卡当前轴实际位置
                If CurrentPos(Axis1) = 0 And CurrentPosEnc(Axis1) = 0 Then
                    AxisItemsAttribute.Item(Axis1.ToString).HomeOK = True                       '当前轴回原点成功(返回结果为TRUE)
                    HomeStep(Axis1) = 150                                                       '跳转到第100步（当前轴原点复归完成，原点复归成功）
                Else
                    HomeStep(Axis1) = 80                                                        '跳转到80,重新进行位置清0和同步
                End If
            Case 90
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                             '清除当前轴驱动器报警标志（极限触发停止）
                rtn(Axis1) = GT_GetPrfPos(MotionCardNum, Axis1 + 1, CurrentPos(Axis1), 1, 0)    '获取当前轴当前位置
                rtn(Axis1) = GT_SetCaptureMode(MotionCardNum, Axis1 + 1, CAPTURE_HOME)          '启动当前轴的原点捕获
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                    '计算目标速度脉冲频率（极限过原点走过的速度）
                Tpos(Axis1) = CLng(CurrentPos(Axis1) - sAxisPar(Axis1).iHomeDirector * sAxisPar(Axis1).dHomeSearchDis)  '因为碰到极限,所以需要反向搜索原点（极限过原点走过的距离）
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                   '设置当前轴的目标速度（极限过原点走过的速度）
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                   '设置当前轴的目标位置（极限过原点走过的距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                                '启动当前轴点位运动
                HomeStep(Axis1) = 95
            Case 95
                rtn(Axis1) = GT_GetCaptureStatus(MotionCardNum, Axis1 + 1, HomeCapture(Axis1), HomeTempPos(Axis1), 1, 0) '获取当前轴原点捕获的状态及捕获的当前位置
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)           '获取当前轴的状态
                If HomeCapture(Axis1) Then                                                      '判断当前轴是否原点捕获触发
                    HomeCapture(Axis1) = 0                                                      '当前轴原点捕获触发标志清零
                    HomeStep(Axis1) = 100
                ElseIf CBool(Status(Axis1) And &H400) = False Then                               '判断当前轴是否运动停止（原点搜索距离太小或触发极限）
                    HomeCounter(Axis1) = HomeCounter(Axis1) + 1                                  '正反向都未搜索到原点
                    AxisItemsAttribute.Item(Axis1.ToString).HomeOK = False                       '表示回原点失败
                    HomeStep(Axis1) = 150                                                        '跳转到第10步（反向搜索原点还是没有搜索到）
                End If
            Case 100
                rtn(Axis1) = GT_Stop(MotionCardNum, 2 ^ Axis1, 2 ^ Axis1)                       '捕获到原点则当前轴紧急停止 
                HomeStep(Axis1) = 105
            Case 105
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)           '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                                  '判断当前轴是否运动停止 
                    HomeStep(Axis1) = 110
                End If
            Case 110
                rtn(Axis1) = GT_ClrSts(MotionCardNum, Axis1 + 1, 1)                             '清除当前轴驱动器报警标志
                rtn(Axis1) = GT_GetPrfPos(MotionCardNum, Axis1 + 1, CurrentPos(Axis1), 1, 0)    '获取当前轴当前位置
                Tvel(Axis1) = CDbl(sAxisPar(Axis1).dHomeSpeedLow)                                    '计算当前轴目标速度脉冲频率（第二次搜索原点的偏移速度）
                Tpos(Axis1) = CLng(CurrentPos(Axis1) - sAxisPar(Axis1).iHomeDirector * sAxisPar(Axis1).dDistanceRate * 10) '计算当前轴目标位置脉冲数量（第二次搜索原点的偏移10mm
                rtn(Axis1) = GT_SetVel(MotionCardNum, Axis1 + 1, Tvel(Axis1))                   '设置当前轴的目标速度
                rtn(Axis1) = GT_SetPos(MotionCardNum, Axis1 + 1, Tpos(Axis1))                   '设置当前轴的目标位置（即第二次搜索原点的偏移距离）
                rtn(Axis1) = GT_Update(MotionCardNum, 2 ^ Axis1)                                '启动当前轴点位运动（运动中进行原点位置修正）
                HomeStep(Axis1) = 115
            Case 115
                rtn(Axis1) = GT_GetSts(MotionCardNum, Axis1 + 1, Status(Axis1), 1, 0)          '获取当前轴的状态
                If CBool(Status(Axis1) And &H400) = False Then                                 '判断当前轴是否运动停止
                    Delay(50)                                                                  '延时50ms等待马达停稳 
                    HomeStep(Axis1) = 40
                End If
            Case 150
                AxisItemsAttribute.Item(Axis1.ToString).HomeRunnnig = False
                HomeStep(Axis1) = 0
                HomeCounter(Axis1) = 0
                HomeCapture(Axis1) = 0
                HomeTempPos(Axis1) = 0
            Case Else
        End Select
    End Sub

    Private Sub GoHomeLineMoProcess(Axis2 As Integer, IO As Integer, HomeIoCard As Integer)
        Call CalMotinRate(Axis2)

        '回零异常处理
        rtn(Axis2) = GT_GetSts(MotionCardNum, Axis2 + 1, Status(Axis2), 1, 0)             '获取当前轴的状态
        If (Status(Axis2) And &H2) Or (Status(Axis2) And &H100) Then        '                '检测驱动器报警和急停报警
            AxisItemsAttribute.Item(Axis2.ToString).HomeOK = False
            AxisItemsAttribute.Item(Axis2.ToString).HomeRunnnig = False
            HomeStepLinMot(Axis2) = 0
            CurrentPosLinMot(Axis2) = 0
            CurrentPosEncLinMot(Axis2) = 0
            rtnLinMot(Axis2) = GT_ClrSts(MotionCardNum, Axis2 + 1, 1)                       '清除当前轴驱动器报警标志
        End If

        Select Case HomeStepLinMot(Axis2)
            Case 10
                AxisItemsAttribute.Item(Axis2.ToString).HomeRunnnig = True
                AxisItemsAttribute.Item(Axis2.ToString).HomeOK = False

                rtnLinMot(Axis2) = GT_ClrSts(MotionCardNum, Axis2 + 1, 1)                               '清除当前轴驱动器报警标志
                rtnLinMot(Axis2) = GT_SetPrfPos(MotionCardNum, Axis2 + 1, 0)                            '将当前轴规划器位置修改为零点
                rtnLinMot(Axis2) = GT_SetEncPos(MotionCardNum, Axis2 + 1, 0)                            '将当前轴编码器位置修改为零点
                rtnLinMot(Axis2) = GT_SynchAxisPos(MotionCardNum, 2 ^ (Axis2))                          '将当前轴进行位置同步

                rtnLinMot(Axis2) = GT_PrfTrap(MotionCardNum, Axis2 + 1)                                 '设置当前轴的运动模式为点位模式
                rtnLinMot(Axis2) = GT_GetTrapPrm(MotionCardNum, Axis2 + 1, TrapPrmLine(Axis2))          '获取当前轴点位模式运动参数
                TrapPrmLine(Axis2).acc = sAxisPar(Axis2).dAcc                                           '载入当前轴的加速度
                TrapPrmLine(Axis2).dec = sAxisPar(Axis2).dDec                                           '载入当前轴的减速度
                rtnLinMot(Axis2) = GT_SetTrapPrm(MotionCardNum, Axis2 + 1, TrapPrmLine(Axis2))          '设置当前轴点位模式运动参数
                rtnLinMot(Axis2) = GT_SetCaptureMode(MotionCardNum, Axis2 + 1, CAPTURE_HOME)            '启动当前轴的原点捕获
                Tvel(Axis2) = CDbl(sAxisPar(Axis2).dHomeSpeed)                                          '计算当前轴目标速度脉冲频率（原点搜索速度）
                Tpos(Axis2) = CLng(sAxisPar(Axis2).iHomeDirector * sAxisPar(Axis2).dHomeSearchDis)      '计算当前轴目标位置脉冲数量（即原点搜索距离）
                rtnLinMot(Axis2) = GT_SetVel(MotionCardNum, Axis2 + 1, Tvel(Axis2))                     '设置当前轴的目标速度（即原点搜索速度）
                rtnLinMot(Axis2) = GT_SetPos(MotionCardNum, Axis2 + 1, Tpos(Axis2))                     '设置当前轴的目标位置（即原点搜索距离）
                rtnLinMot(Axis2) = GT_Update(MotionCardNum, 2 ^ Axis2)                                  '启动当前轴点位运动
                HomeStepLinMot(Axis2) = 11                                                              '跳转到下一步
            Case 11
                rtnLinMot(Axis2) = GT_GetCaptureStatus(MotionCardNum, Axis2 + 1, HomeCaptureLine(Axis2), HomeTempPosLine(Axis2), 1, 0) '获取当前轴原点捕获的状态及捕获的当前位置
                rtnLinMot(Axis2) = GT_GetSts(MotionCardNum, Axis2 + 1, StatusLine(Axis2), 1, 0)          '获取当前轴的状态
                If HomeCaptureLine(Axis2) Then                                                           '判断当前轴是否原点捕获触发
                    HomeCaptureLine(Axis2) = 0                                                           '当前轴原点捕获触发标志清零
                    HomeStepLinMot(Axis2) = 12
                ElseIf CBool(Status(Axis2) And &H400) = False Then                                       '判断当前轴是否运动停止（原点搜索距离太小或触发极限）
                    HomeTimeLinMot(Axis2) = GetTickCount
                    HomeStepLinMot(Axis2) = 12                                                           '跳转到第90步（移过一段极限到原点的距离再重新搜索）
                End If
            Case 12
                If GetTickCount - HomeTimeLinMot(Axis2) > 200 Then
                    rtnLinMot(Axis2) = GT_ClrSts(MotionCardNum, Axis2 + 1, 1)                               '清除当前轴驱动器报警标志
                    rtnLinMot(Axis2) = GT_GetPrfPos(MotionCardNum, Axis2 + 1, CurrentPosLinMot(Axis2), 1, 0) '获取当前轴当前位置

                    'Set_Y_bit(0, IO, 0, False)
                    GT_SetDoBit(HomeIoCard, MC_GPO, Axis2 + 1, 0)
                    HomeTimeLinMot(Axis2) = GetTickCount
                    HomeStepLinMot(Axis2) = 15
                End If 
            Case 15
                If GetTickCount - HomeTimeLinMot(Axis2) > 600 Then
                    'Set_Y_bit(0, IO, 1, False)
                    GT_SetDoBit(HomeIoCard, MC_GPO, Axis2 + 1, 1)
                    HomeTimeLinMot(Axis2) = GetTickCount
                    HomeStepLinMot(Axis2) = 20
                End If
            Case 20
                If HomeBit(Axis2) = 0 Then
                    HomeStepLinMot(Axis2) = 25
                ElseIf GetTickCount - HomeTimeLinMot(Axis2) > sAxisPar(Axis2).iHomeTimeOut Then
                    AxisItemsAttribute.Item(Axis2.ToString).HomeOK = False
                    HomeStepLinMot(Axis2) = 150
                End If
            Case 25
                rtnLinMot(Axis2) = GT_SetPrfPos(MotionCardNum, Axis2 + 1, 0)                          '将当前轴规划器位置修改为零点
                rtnLinMot(Axis2) = GT_SetEncPos(MotionCardNum, Axis2 + 1, 0)                          '将当前轴编码器位置修改为零点
                rtnLinMot(Axis2) = GT_SynchAxisPos(MotionCardNum, 2 ^ Axis2)                          '将当前轴进行位置同步
                Delay(50)
                HomeStepLinMot(Axis2) = 30
            Case 30
                rtnLinMot(Axis2) = GT_GetPrfPos(MotionCardNum, Axis2 + 1, CurrentPosLinMot(Axis2), 1, 0)    '读取0号卡当前轴规划位置
                rtnLinMot(Axis2) = GT_GetEncPos(MotionCardNum, Axis2 + 1, CurrentPosEncLinMot(Axis2), 1, 0) '读取0号卡当前轴实际位置
                If CurrentPosLinMot(Axis2) = 0 And CurrentPosEncLinMot(Axis2) = 0 Then
                    AxisItemsAttribute.Item(Axis2.ToString).HomeOK = True                                   '当前轴回原点成功(返回结果为TRUE)
                    HomeStepLinMot(Axis2) = 150
                Else
                    HomeStepLinMot(Axis2) = 25
                End If
            Case 150
                AxisItemsAttribute.Item(Axis2.ToString).HomeRunnnig = False
                HomeStepLinMot(Axis2) = 0
                CurrentPosLinMot(Axis2) = 0
                CurrentPosEncLinMot(Axis2) = 0
        End Select
    End Sub
     
#End Region
#End Region

#Region "类"

    ''' <summary>
    ''' 轴参数基类
    ''' </summary>
    ''' <remarks></remarks>
    Public Class AxisItems
        Implements IEquatable(Of AxisItems)

        '///////////////////////私有变量/////////////////////////////'
        Private _AxisNum As String
        Private _PulsePerRpm As Double
        Private _Lead As Double
        Private _Ratio As Double
        Private _MoveSpeed As Double
        Private _HomeSpeed As Double
        Private _Acc As Double
        Private _Dec As Double
        Private _HomeOffset As Double
        Private _HomeTimeout As Double
        Private _HomeSearchDis As Double
        Private _HomeSpeedLow As Double
        Private _HomeDirection As String
        Private _IsRotate As Boolean
        Private _HomeRunnnig As Boolean
        Private _HomeOK As Boolean
        '///////////////////////私有变量/////////////////////////////'

        Public Sub New()
            _HomeRunnnig = False     '构建类时将回原点中标志复位false
            _HomeOK = False          '构建类时将回原点OK标志复位false 
        End Sub

        '//////////////////////////应用层传递过来的属性//////////////////////////////'

        ''' <summary>
        ''' 轴号
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AxisNum As String
            Get
                Return _AxisNum
            End Get
            Set(value As String)
                _AxisNum = value
            End Set
        End Property

        ''' <summary>
        ''' 每转脉冲数
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PulsePerRpm() As Double
            Get
                Return _PulsePerRpm
            End Get
            Set(value As Double)
                _PulsePerRpm = value
            End Set
        End Property

        ''' <summary>
        ''' 丝干导程
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Lead() As Double
            Get
                Return _Lead
            End Get
            Set(value As Double)
                _Lead = value
            End Set
        End Property

        ''' <summary>
        ''' 齿轮减速比
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Ratio() As Double
            Get
                Return _Ratio
            End Get
            Set(value As Double)
                _Ratio = value
            End Set
        End Property

        ''' <summary>
        '''运行速度(mm/s)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MoveSpeed As Double
            Get
                Return _MoveSpeed
            End Get
            Set(value As Double)
                _MoveSpeed = value
            End Set
        End Property

        ''' <summary>
        ''' 回零速度(mm/s)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeSpeed As Double
            Get
                Return _HomeSpeed
            End Get
            Set(value As Double)
                _HomeSpeed = value
            End Set
        End Property

        ''' <summary>
        '''  回零速度低速(mm/s)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeSpeedLow() As Double
            Get
                Return _HomeSpeedLow
            End Get
            Set(value As Double)
                _HomeSpeedLow = value
            End Set
        End Property

        ''' <summary>
        ''' 加速度(mm/s2)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Acc() As Double
            Get
                Return _Acc
            End Get
            Set(value As Double)
                _Acc = value
            End Set
        End Property

        ''' <summary>
        ''' 减速度(mm/s2)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Dec() As Double
            Get
                Return _Dec
            End Get
            Set(value As Double)
                _Dec = value
            End Set
        End Property

        ''' <summary>
        ''' 原点偏移量(mm)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeOffset As Double
            Get
                Return _HomeOffset
            End Get
            Set(value As Double)
                _HomeOffset = value
            End Set
        End Property

        ''' <summary>
        ''' 原点搜索距离(mm)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeSearchDis() As Double
            Get
                Return _HomeSearchDis
            End Get
            Set(value As Double)
                _HomeSearchDis = value
            End Set
        End Property

        ''' <summary>
        ''' 回零超时设定值:单位ms
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeTimeout() As Integer
            Get
                Return _HomeTimeout
            End Get
            Set(value As Integer)
                _HomeTimeout = value
            End Set
        End Property

        ''' <summary>
        ''' 回零方向:只能输入"+" or "-"
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeDirection() As String
            Get
                Return _HomeDirection
            End Get
            Set(value As String)
                If value <> "+" And value <> "-" Then
                    Throw New Exception("输入的回零方向错误,只能为" + " or " - "")
                Else
                    _HomeDirection = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' 是否是旋转轴,true为此轴是旋转轴,false为此轴不是旋转轴
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IsRotate() As Boolean
            Get
                Return _IsRotate
            End Get
            Set(value As Boolean)
                _IsRotate = value
            End Set
        End Property

        '////////////返回到应用层的属性////////////////////

        ''' <summary>
        ''' 回原点中标志位,true为在回原点中,false表示未在回原点中
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HomeRunnnig() As Boolean
            Get
                Return _HomeRunnnig
            End Get
            Set(value As Boolean)
                _HomeRunnnig = value
            End Set
        End Property

        Public Property HomeOK() As Boolean
            Get
                Return _HomeOK
            End Get
            Set(value As Boolean)
                _HomeOK = value
            End Set
        End Property

        '//////////////////////////属性//////////////////////////////' 


        '////////////AxisItemsSameDimensions类需要此类重载方法///////////
        Public Overloads Function Equals(ByVal other As AxisItems) As Boolean Implements IEquatable(Of AxisItems).Equals
            Dim BoxSameDim = New AxisItemsSameDimensions()
            If BoxSameDim.Equals(Me, other) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function

    End Class

    ''' <summary>
    ''' 轴参数基类AxisItems的集合
    ''' </summary>
    ''' <remarks></remarks>
    Public Class AxisItemsCollection
        Implements ICollection(Of AxisItems)

        Private innerCol As List(Of AxisItems)

        Public Sub New()
            innerCol = New List(Of AxisItems)
        End Sub

        Public Sub Add(item As AxisItems) Implements ICollection(Of AxisItems).Add
            innerCol.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of AxisItems).Clear
            innerCol.Clear()
        End Sub

        Public Function Contains(item As AxisItems) As Boolean Implements ICollection(Of AxisItems).Contains
            Dim found As Boolean = False

            Dim bx As AxisItems
            For Each bx In innerCol
                If New AxisItemsSameDimensions().Equals(bx, item) Then
                    found = True
                End If
            Next

            Return found
        End Function

        Public Sub CopyTo(array() As AxisItems, arrayIndex As Integer) Implements ICollection(Of AxisItems).CopyTo
            Throw New NotImplementedException()
        End Sub

        Public ReadOnly Property Count As Integer Implements ICollection(Of AxisItems).Count
            Get
                Return innerCol.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of AxisItems).IsReadOnly
            Get
                Return False
            End Get
        End Property

        Public Overloads Property Item(ByVal AxisNum As String) As AxisItems
            Get
                For Each temp As AxisItems In innerCol
                    If temp.AxisNum = AxisNum Then
                        Return CType(temp, AxisItems)
                    End If
                Next
                Return Nothing
            End Get
            Set(ByVal Value As AxisItems)
                innerCol(AxisNum) = Value
            End Set
        End Property

        Public Overloads Property Item(ByVal index As Integer, temp As Integer) As AxisItems
            Get
                Return CType(innerCol(index), AxisItems)
            End Get
            Set(ByVal Value As AxisItems)
                innerCol(index) = Value
            End Set
        End Property

        Public Function Remove(item As AxisItems) As Boolean Implements ICollection(Of AxisItems).Remove
            Dim result As Boolean = False

            Dim i As Integer
            For i = 0 To innerCol.Count - 1

                Dim curBox As AxisItems = CType(innerCol(i), AxisItems)

                If New AxisItemsSameDimensions().Equals(curBox, item) Then
                    innerCol.RemoveAt(i)
                    result = True
                    Exit For
                End If
            Next
            Return result
        End Function

        Public Function GetEnumerator() As IEnumerator(Of AxisItems) Implements IEnumerable(Of AxisItems).GetEnumerator
            Return New AxisItemsEnumerator(Me)
        End Function

        Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
            Return Me.GetEnumerator()
        End Function
    End Class

    ''' <summary>
    ''' 此类只为完成AxisItemsCollection类中的某些功能
    ''' </summary>
    ''' <remarks></remarks>
    Private Class AxisItemsEnumerator
        Implements IEnumerator(Of AxisItems)
        Private _collection As AxisItemsCollection
        Private curIndex As Integer
        Private curAxisItmes As AxisItems

        '///////属性//////////
        Private Property AxisItems As AxisItems
        Public ReadOnly Property Current As AxisItems Implements IEnumerator(Of AxisItems).Current
            Get
                If curAxisItmes Is Nothing Then
                    Throw New InvalidOperationException()
                End If

                Return curAxisItmes
            End Get
        End Property

        Public ReadOnly Property Current1 As Object Implements IEnumerator.Current
            Get
                Return Me.Current
            End Get
        End Property
        '///////属性//////////


        '//////构造函数//////'
        Public Sub New(ByVal collection As AxisItemsCollection)
            MyBase.New()
            _collection = collection
            curIndex = -1
            curAxisItmes = Nothing
        End Sub

        Public Function MoveNext() As Boolean Implements IEnumerator(Of AxisItems).MoveNext
            curIndex = curIndex + 1
            If curIndex = _collection.Count Then
                ' Avoids going beyond the end of the collection.
                Return False
            Else
                'Set current box to next item in collection.
                curAxisItmes = _collection(curIndex)
            End If
            Return True
        End Function

        Public Sub Reset() Implements IEnumerator(Of AxisItems).Reset
            curIndex = -1
        End Sub

        Public Sub Dispose() Implements IEnumerator(Of AxisItems).Dispose
        End Sub

    End Class

    ''' <summary>
    ''' 此类只为完成AxisItemsCollection类中的某些功能
    ''' </summary>
    ''' <remarks></remarks>
    Private Class AxisItemsSameDimensions
        Inherits EqualityComparer(Of AxisItems)

        Public Overrides Function Equals(ByVal b1 As AxisItems, ByVal b2 As AxisItems) As Boolean
            If b1.Acc = b2.Acc And b1.AxisNum = b2.AxisNum And b1.Dec = b2.Dec And b1.HomeOffset = b2.HomeOffset And b1.HomeSpeed = b2.HomeSpeed _
               And b1.Lead = b2.Lead And b1.MoveSpeed = b2.MoveSpeed And b1.PulsePerRpm = b2.PulsePerRpm And b1.Ratio = b2.Ratio And b1.HomeTimeout = b2.HomeTimeout _
               And b1.HomeDirection = b2.HomeDirection And b1.HomeRunnnig = b2.HomeRunnnig And b1.HomeOK = b2.HomeOK And b1.IsRotate = b2.IsRotate And b1.HomeSearchDis = b2.HomeSearchDis And b1.HomeSpeedLow = b2.HomeSpeedLow Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Overrides Function GetHashCode(ByVal bx As AxisItems) As Integer
            Dim hCode As Integer = bx.Acc ^ bx.AxisNum ^ bx.Dec ^ bx.HomeOffset ^ bx.HomeSpeed ^ bx.Lead ^ bx.MoveSpeed ^ bx.PulsePerRpm ^ bx.Ratio ^ bx.HomeTimeout ^ bx.HomeDirection ^ bx.HomeRunnnig ^ bx.HomeOK ^ bx.IsRotate ^ bx.HomeSearchDis ^ bx.HomeSpeedLow
            Return hCode.GetHashCode()
        End Function

    End Class
#End Region
 
End Class