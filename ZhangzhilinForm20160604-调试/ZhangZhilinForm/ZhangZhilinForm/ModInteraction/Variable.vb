Imports System.Data.OleDb
Imports System.Threading

Public Module Variable
#Region "颜色常量"
    Public colSelectedBtn As Object = Color.FromArgb(175, 218, 150)
    Public colUnselectedBtn As Object = Color.FromArgb(238, 238, 238)
    Public colMainSelectedBtn As Object = Color.FromArgb(179, 202, 255)

    Public colSelectedPauseBtn As Object = Color.FromArgb(132, 193, 251)
    Public colSelectedEndBtn As Object = Color.FromArgb(228, 146, 138)
    Public colErrorRed As Object = Color.FromArgb(200, 37, 6)
#End Region

#Region "窗体切换及显示变量"
    ''' <summary>
    ''' 主界面开启相关界面时，传递窗口名称变量
    ''' </summary>
    ''' <remarks></remarks>
    Public strOpenTargetForm As String

    ''' <summary>
    ''' 当前活动窗口名
    ''' </summary>
    ''' <remarks></remarks>
    Public strActiveFrmNme As String

    ''' <summary>
    ''' '各子界面在主界面中位置定位点
    ''' </summary>
    ''' <remarks></remarks>
    Public ChildFrmOffsetPoint As Point

    ''' <summary>
    ''' 登陆界面是否打开
    ''' </summary>
    ''' <remarks></remarks>
    Public bIsLoginFromOpen As Boolean
#End Region

#Region "用户登陆"
    ''' <summary>
    ''' 用户登陆变量
    ''' </summary>
    ''' <remarks></remarks>
    Public sLogin As structLogin

    ''' <summary>
    ''' 用户登陆结构体
    ''' </summary>
    ''' <remarks></remarks>
    Structure structLogin
        Dim Users() As String
        Dim PassWord() As String
    End Structure

#End Region

#Region "frmPar窗体变量"
    ''' <summary>
    ''' 参数允许修改标志位
    ''' </summary>
    ''' <remarks></remarks>
    Public bIsEnableParModify As Boolean
#End Region

#Region "设备控制相关变量"
    ''' <summary>
    ''' 设备初始化OK,可以启动运行
    ''' </summary>
    ''' <remarks></remarks>
    Public bolHomeOK As Boolean

    ''' <summary>
    ''' 设备运行中标志
    ''' </summary>
    ''' <remarks></remarks>
    Public bolRunning As Boolean

    ''' <summary>
    ''' 设备暂停中标志
    ''' </summary>
    ''' <remarks></remarks>
    Public bolPause As Boolean

    ''' <summary>
    ''' 设备停止中标志
    ''' </summary>
    ''' <remarks></remarks>
    Public bolStoping As Boolean

    ''' <summary>
    ''' 急停标志位
    ''' </summary>
    ''' <remarks></remarks>
    Public bolEmergency As Boolean


#End Region
     
    '    Public Const DP2_SW_Rev As String = "SV1.0.4"
    '    Public Const dDP2_CC_JudgeValue As Double = 0.109

    '    Public bIsLoginFromOpen As Boolean
    '    Public sOldColor As String
    '    Public i As Integer
    '    Public bReturnBBS2Data As Boolean
    '    Public bIsProductionMode As Boolean      'OP生产模式,与bIsEngneeringMode互斥
    '    Public bIsEngneeringMode As Boolean      '工程调试模式,与bIsProductionMode互斥
    '    Public bIsGRRMode As Boolean
    '    Public bIsCPKMode As Boolean
    '    Public bAutoRunFlag As Boolean           '设备自动运行标志
    '    Public bMaualRunFlag As Boolean          '设备手动运行标志

    '    Public bSystemIsPause As Boolean         '设备暂停标志
    '    Public bSystemIsStop As Boolean          '设备停止标志
    '    Public bIsFromMainStart As Boolean          '设备是从主界面开始初始化标志
    '    Public FilePath(40) As String               '文件保存路径暂存

    '    Public sRobot_Status As String          '机械手返回参数值的第一位
    '    Public Rbt_Speed As Double              '机械手利用Go、Jump、Pulse 命令等的PTP 动作速度,参数的有效设定值： 1 - 100
    '    Public Rbt_SpeedS As Double             '机械手Move 、Arc、Arc3、Jump3、Jump3CP 等CP 动作时的机械臂速度,参数的有效设定值： 1 - 2000
    '    Public Rbt_FitShimSpeedS As Double      '机械手Shim贴合时的Move动作时的机械臂速度

    '    Public bDemoFlag As Boolean             '设备装配演示(即空跑)标志，True---装配演示功能开启，False---装配演示功能关闭
    '    Public bIsOpenS2AllFix As Boolean     '开启二工站贴合前同时定位拍照功能功能标志
    '    Public bIsS2CheckHBCC As Boolean        '二工站开启复检HB BTN同心度功能标志
    '    Public bIsS2CheckVBCC As Boolean        '二工站开启复检VB BTN同心度功能标志

    '    Public IsWinsockSendCmdEnable As Boolean    '
    '    Public strOpenTargetForm As String        '主界面开启相关界面时，传递窗口名称变量
    '    Public FromEng_TabControl_PageIndex As Integer    '工程师界面（Frm_Engineering）的TabControl控件触发的Index
    '    Public bIsEnableParModify As Boolean    '允许修改参数设定，用于Frm_Par,及Frm_Par_CCD窗体界面

    '    Public bCardOpenFlag(0 To 2) As Boolean
    '    Public OldTime As Long
    '    Public iVBcylinderSafty As Integer
    '    Public iPBcylinderSafty As Integer
    '    Public dRingdata(20) As Double
    '    Public sRingdatastring As String
    '    Public sCCD1_Status As String         'CCD1返回值的第一位状态字暂存
    '    Public sCCD2_Status As String         'CCD2返回值的第一位状态字暂存
    '    Public sCCD1_data() As String       'CCD数据暂存
    '    Public sCCD2_data() As String       'CCD数据暂存
    '    Public sPDCA_data() As String       'PDCA数据暂存
    '    Public sendHB_data() As String
    '    Public sPDCA_Buffer As String        'PDCA据暂存
    '    Public sendHB_Buffer As String
    '    Public sPDCAStatus As String
    '    Public StaPDCA_Time As Double

    '    Public sWip_SN As String
    '    Public sBBS2_data() As String       'DP1数据暂存
    '    Public sPress_data As String        '压力传感器回传的压力值数据
    '    Public sPress_data1 As String       '标准压力传感器回传的压力值
    '    Public bIsJudgeFalg As Boolean      '流水线测试时，上一片产品OK\NG的记忆
    '    Public Real_CT As Single            'DP2实时CT时间，单位秒S
    '    Public BIM_CT_Start As Long
    '    Public bBIM_CT_IsEn As Boolean      ''//CT计时允许标志位

    '    Public lNullRunTimes As Long    ''设备空跑循环次数的计数变量

    '    Public bIsDisEnS2 As Boolean        '二工站屏蔽标志
    '    Public bIsDisEnS3 As Boolean        '三工站屏蔽标志

    '    Public sAlarmStatus As String   'Frm_Production界面上的AlarmStatus信息存储
    '    Public sAlarmTime As String     'Frm_Production界面上的AlarmTime信息存储
    '    Public cAlarmColor As Color     'Frm_Production界面上的AlarmStatus,AlarmTime Roundlabel控件的颜色赋值

    '    Public X_C As Double, Y_C As Double, X_N As Double, Y_N As Double    '相对相机原点求出来的旋转中心
    '    Public NewPosX As Double                                         '新走的DX，就是以前摆完角度后的X轴走的距离
    '    Public NewPosY As Double                                         '新走的DY，就是以前摆完角度后的y轴走的距离

    '    Public bDisEnRecBBS2Tray As Boolean             ''//不允许接受BBS2的载具

    '    Public TimerVacumm As Long          '真空泵延时数值暂存

    '    Public TossingS2(3) As String       '2站Tossing数据
    '    Public TossingS3(3) As String       '3站Tossing数据

    '    Public EMG_Stop As Boolean          '设备急停标志

    '    Public ErrorFlag As Strc_IsBusy    'Error标志

    '    Public PDCAFlag As Boolean       'PDCA完成标志
    '    Public HousingBarcode_ToPDCA As String
    '    Public PDCA_Databuffer As String
    '    Public PDCA_Step As Integer
    '    Public Error_Step As Integer
    '    Public bIsUIShow_PDCAMode As Boolean    'Frm_UI窗体显示PDCA模式

    '    Public PDCA_TCP_Flag As Boolean    'PDCA通讯异常是否

    '    Public ForceNum As Integer          '压力传感器 1-- 一次贴合，2--二次贴合标志
    '    Public PressDataName As String      '记录压力数据的文件名
    '    Public PressDataString As String    '在串口响应事件中累加压力数据，待串口关闭时一次写到CSV中
    '    Public PressDataString1 As String   '标准压力传感器收集的数据
    '    Public ShowPressCurveName As String '生产界面显示压力曲线的文件名

    '    Public sShowPressCurveSelect As String     'HB 或者 VBup 或者 VBdown
    '    Public sYieldOrRetestSelect As String      'Yield 或者 Retest
    '    Public HB_Rate, Vup_Rate, Vdown_Rate As Single  '分别为HB,VBup,VBdown的Btn装配良率数据,保留小数点后一位
    '    Public Y_Rate, Y_MonthRate As Single            '分别为当天与最近一月的产品产出良率,保留小数点后一位
    '    Public R_Rate, R_MonthRate As Single            '分别为当天与最近一月的产品重测率,保留小数点后一位
    '    Public sHourlyYield(23) As String               '为当天24小时各个小时生产的良品数量
    '    Public UPH_1HousBefore As String                   'Production界面显示的1小时前的UPH数据

    '    Public bLifeDataIsCollect As Boolean            '生产统计数据是否收集，只有当设备PDCA上传成功后生产统计数据才收集，否则不统计
    '    Public NearlyDate, NearlyDate9 As String                     '存储ProductionDataStatistics.ini中[TotalData]下的NearlyDate
    '    Public s30DaysBefore, s30DaysBefore9 As String
    '    Public MonthlyYieldNum(29) As String            '存储ProductionDataStatistics.ini中[TotalData]下的MonthlyYieldNum的30个数据
    '    Public MonthlyTossingNum(29) As String          '存储ProductionDataStatistics.ini中[TotalData]下的MonthlyTossingNum的30个数据
    '    Public MonthlyInputNum(29) As String            '存储ProductionDataStatistics.ini中[TotalData]下的MonthlyInputNum的30个数据
    '    Public MonthlyRetestNum(29) As String           '存储ProductionDataStatistics.ini中[TotalData]下的MonthlyRetestNum的30个数据
    '    Public MonthlyUPH(29) As String                 '存储ProductionDataStatistics.ini中[TotalData]下的MonthlyUPH的30个数据

    '    Public StartBuildTime As String     '存储ProductionDataStatistics.ini中[ShowUIData]下
    '    Public TotalLifeCycles As String    '存储ProductionDataStatistics.ini中[ShowUIData]下
    '    Public TotalLifeRejects As String   '存储ProductionDataStatistics.ini中[ShowUIData]下
    '    Public BIMLifeRejects As String     '存储ProductionDataStatistics.ini中[ShowUIData]下
    '    Public EndBuildTime As String       '存储ProductionDataStatistics.ini中[ShowUIData]下

    '    Public UpdataErrorMessge As String  '上传Error Code公用字符串变量
    '    Public IsC2_OnError As Boolean
    '    Public IsC3_OnError As Boolean

    '    Public MyThread_DTfileUpdata As Thread
    '    Public MyThread_Beep As Thread
    '    Public MyThread_sendHB As Thread

    '    Public result As Double
    '    Public Vup_result As Double
    '    Public Vdown_result As Double
    '    Public Hb_result As Double

    '    Public RobotGetShimTest_Hold As Boolean     '取料测试暂停标志
    '    Public Error_LuJing As Boolean     '初始化判定Error路径标志
    '    Public Initialize_OK As Boolean     '初始化完成一次标志
    '    Public AutoLoadCellStep As Integer  '压力传感器自动校正步序号
    '    Public AutoLoadCellFlag As Boolean  '压力传感器自动校正标志位
    '    Public SystimeSetStarting As Thread
    '    Public SystemData As String
    '    Public SystemTime As String

    '    Public Nozzle1CentreX As Double   '吸嘴1与CCD中心X
    '    Public Nozzle1CentreY As Double   '吸嘴1与CCD中心Y
    '    Public Nozzle2CentreX As Double   '吸嘴2与CCD中心X
    '    Public Nozzle2CentreY As Double   '吸嘴2与CCD中心Y
    '    Public Nozzle3CentreX As Double   '吸嘴3与CCD中心X
    '    Public Nozzle3CentreY As Double   '吸嘴3与CCD中心Y

    '    Public NozzleHBX As Double   '吸嘴1当前X
    '    Public NozzleHBY As Double   '吸嘴1当前Y
    '    Public NozzleVBupX As Double   '吸嘴2 与吸嘴1X差值
    '    Public NozzleVBupY As Double   '吸嘴2 与吸嘴1Y差值
    '    Public NozzleVBdwX As Double   '吸嘴3 与吸嘴1X差值
    '    Public NozzleVBdwY As Double   '吸嘴3 与吸嘴1Y差值
    '    Public AutoNozzleStep As Integer   '吸嘴中心校正步序号
    '    Public AutoNozzleFlag As Boolean   '吸嘴中心校正标志位

    '    Public Static_Test_Int As Integer   '相机静态测试次数
    '    Public Static_Test_HBX As Double  '相机静态测试X
    '    Public Static_Test_HBY As Double   '相机静态测试Y

    '    Public Robot_HBX As Double   '吸嘴1X
    '    Public Robot_HBY As Double   '吸嘴1Y
    '    Public Robot_VupX As Double   '吸嘴2 
    '    Public Robot_VupY As Double   '吸嘴2 
    '    Public Robot_VdnX As Double   '吸嘴3 
    '    Public Robot_VdnY As Double   '吸嘴3
    '    Public AutoRobotTestInt As Integer   '机械手精度测试次数
    '    Public AutoRobotTestStep As Integer   '机械手精度测试步序号
    '    Public AutoRobotTestFlag As Boolean   '机械手精度测试标志位

    '    Public ShimGRR_TestInt As Integer   'Shim复检测试次数
    '    Public ShimGRR_TestStep As Integer   'Shim复检测试步序号
    '    Public ShimGRR_TestFlag As Boolean   'Shim复检测试标志位

    '    Public BtnLoc_TestInt As Integer   'Btn定位测试次数
    '    Public BtnLoc_TestStep As Integer   'Btn定位测试步序号
    '    Public Btnloc_TestFlag As Boolean   'Btn定位测试标志位

    '    Public Abnormaldata As String     '异常界面保存为CSV文件数据源
    '    Public CPK_Amount As Integer      'CPK模式CPK数量累计
    '    Public GRR_Amount As Integer      'GRR模式CPK数量累计
    '    Public Robot_Dot As Integer      '机械手运动到某个点位坐标
    '    Public White_Flag As Boolean = True
    '    Public Black_Flag As Boolean
    '    Public Gold_Flag As Boolean
    '    Public Rose_Flag As Boolean

    '    Public Attract_Sum_HB As Integer     'HB吸嘴吸料总统计
    '    Public Attract_Sum_Vup As Integer    'Vup吸嘴吸料总统计
    '    Public Attract_Sum_Vdn As Integer    'Vdn吸嘴吸料总统计

    '    Public PauseRobot As Boolean
    '    Public AutoTakeShimFlag As Boolean = False   'Shim取成功标志
    '    Public AutoTakeShimTF As Boolean = False   'Shim取料异常抛料标志

    '#Region "BZ 自定义刷新状态"
    '    ''' <summary>
    '    ''' 工作状态监控标志位
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Public Structure Strc_IsBusy
    '        ''' <summary>
    '        ''' 使能
    '        ''' </summary>
    '        Dim Enable As Boolean
    '        ''' <summary>
    '        ''' 状态
    '        ''' </summary>
    '        Dim Status As Boolean
    '        ''' <summary>
    '        ''' 结果
    '        ''' </summary>
    '        Dim Result As Boolean
    '    End Structure
    '#End Region

    '#Region "BZ 自定义量"
    '    Public aHB_NG As Long
    '    Public aVUp_NG As Long
    '    Public aVDown_NG As Long
    '    Public aYield_NG As Long
    '    Public aRetest_Num As Long
    '    Public aTotalLife As Long

    '    Public mYield_NG As Long
    '    Public mRetest_Num As Long
    '    Public mTotalLife As Long
    '#End Region

    '#Region "BZ 自定义文件保存路径及名称相关变量"
    '    '' <summary>
    '    '' 保存数据文件夹名称 "Data"
    '    '' </summary>
    '    '' <remarks>##AABBCC</remarks>
    '    Public BZ_DataPath As String = "E:\BZ-Data\"
    '    '' <summary>
    '    '' 参数读写路径 "D:\BZ-Parameter\"
    '    '' </summary>
    '    '' <remarks>##AABBCC</remarks>
    '    Public BZ_ParPath As String = "D:\BZ-Parameter\"
    '    '' <summary>
    '    '' 参数读写路径 Application.StartupPath & " \ DP2Parameter \ "
    '    '' </summary>
    '    '' <remarks>##AABBCC</remarks>
    '    Public BZ_PasswordPath As String = Application.StartupPath & "\DP2Parameter\BIM.dat"
    '#End Region

    '#Region "板卡 变量定义"
    '    Public rtn As Short                                          '板卡
    '    Public iBoardInitFlag As Integer
    '    Public dCurrPrfPos_Card(0 To 4) As Double
    '    Public dCurrEncPos_Card(0 To 4) As Double
    '    Public dFactor(0 To 4) As Double
    '    Public AxisMachine(10) As sAxisMachine
    '    'Public HomeStep(0 To 16) As Integer                         '回原点
    '    'Public HomeOk(0 To 16) As Boolean
    '    Public HomeCapture(0 To 16) As Integer
    '    Public HomeTempPos(0 To 16) As Long
    '    Public HomeCaptureZ(0 To 16) As Integer
    '    Public HomeTempPosZ(0 To 16) As Long
    '    'Public OldTime(0 To 16) As Long
    '#End Region

    '#Region "数据库 变量定义"
    '    Public Conn As New OleDbConnection                           '数据库连接
    '    Public CmdView As New OleDbCommand
    '    Public Dr As OleDbDataReader
    '    Public CurrentDate As String
    '    Public BeforeDate As String
    '    Public Const XmlFilePath As String = "E:\Test\Test.xml"      '文件路径
    '    Public Const CsvFilePath As String = "E:\Test\Test.csv"
    '    Public Const TxtFilePath As String = "E:\Test\Test.txt"
    '    Public Const DatFilePath As String = "E:\Test\Test.dat"
    '    Public Const IniFilePath As String = "E:\Test\Test.ini"
    '#End Region

    '#Region "网络连接 变量定义"
    '    Public AxWinsock1State As Boolean                            '网络连接
    '    Public AxWinsock1Message As String
    '    Public AxWinsock1_Data() As String
    '    Public AxWinsock2State As Boolean
    '    Public AxWinsock2Message As String
    '    Public AxWinsock2_Data() As String
    '    Public AxWinsock3State As Boolean
    '    Public AxWinsock3Message As String
    '    Public AxWinsock3_Data() As String
    '    Public AxWinsock1_String As String
    '    Public AxWinsock2_String As String
    '    Public AxWinsock3_String As String
    '#End Region

    '#Region "I/O刷新 变量定义"
    '    Public Manualfrm As Boolean          '手动调试窗体是否已打开标志
    '    Public Home0_Bit(11) As Boolean
    '    Public Lim0_BitP(11) As Boolean
    '    Public Lim0_BitN(11) As Boolean
    '    Public Alarm0_Bit(11) As Boolean

    '    Public SevOn0_Bit(11) As Boolean
    '    Public AlrClr0_Bit(11) As Boolean

    '    Public EMC_STOP As Boolean
    '    'Public X0(15) As Boolean             '输入变量定义
    '    'Public X1(15) As Boolean
    '    'Public X2(15) As Boolean
    '    'Public X3(15) As Boolean
    '    'Public X4(15) As Boolean

    '    'Public Y0(15) As Boolean             '输出变量定义
    '    'Public Y1(15) As Boolean
    '    'Public Y2(15) As Boolean
    '    'Public Y3(15) As Boolean
    '    'Public Y4(15) As Boolean
    '#End Region

    '#Region "DP2 IO名称"
    '#Const WRITE_IO_STATUS = 1 '//条件编译 为TRUE时监控每一个输出状态 并将状态写入Log

    '    Public InputName(,) As String = {
    '{
    '"0-00 机械手准备好",
    '"0-01 机械手运行中",
    '"0-02 机械手暂停中",
    '"0-03 机械手报警",
    '"0-04 安全门",
    '"0-05 1号Feeder夹爪整体升降气缸伸出",
    '"0-06 2号Feeder夹爪整体升降气缸伸出",
    '"0-07 3号Feeder夹爪整体升降气缸伸出",
    '"0-08 成品流出感应器",
    '"0-09 4号Feeder夹爪整体升降气缸伸出",
    '"0-10 总负压表",
    '"0-11 总正压表",
    '"0-12 来料NG传送带 光纤1",
    '"0-13 来料NG传送带 光纤2",
    '"0-14 装配后NG传送带 光纤1",
    '"0-15 装配后NG传送带 光纤2"
    '},
    '{
    '"1-00 下一台设备可以接收载具",
    '"1-01 上一台设备有载具",
    '"1-02 上一台设备的产品已装配失败",
    '"1-03 传送带1载具检测光纤1",
    '"1-04 传送带1载具检测光纤2",
    '"1-05 传送带2载具检测光纤1",
    '"1-06 传送带2载具检测光纤2",
    '"1-07 传送带3载具检测光纤1",
    '"1-08 传送带3载具检测光纤2",
    '"1-09 阻挡气缸1上",
    '"1-10 阻挡气缸2上",
    '"1-11 阻挡气缸3上",
    '"1-12 阻挡气缸4上",
    '"1-13 5号Feeder夹爪整体升降气缸伸出",
    '"1-14 紧急停止1(正门)",
    '"1-15 紧急停止2(侧门)"
    '},
    '{
    '"2-00 吸嘴1(PB)真空负压表",
    '"2-01 吸嘴2(VB+)真空负压表",
    '"2-02 吸嘴3(VB-)真空负压表",
    '"2-03 6号Feeder夹爪整体升降气缸伸出",
    '"2-04 7号Feeder夹爪整体升降气缸伸出",
    '"2-05 Housing真空吸负压表",
    '"2-06 传送带1夹紧气缸缩回",
    '"2-07 传送带1夹紧气缸伸出",
    '"2-08 传送带2夹紧气缸缩回",
    '"2-09 传送带2夹紧气缸伸出",
    '"2-10 传送带3夹紧气缸缩回",
    '"2-11 传送带3夹紧气缸伸出",
    '"2-12 吸HSG升降气缸缩回",
    '"2-13 吸HSG升降气缸伸出",
    '"2-14 1号Feeder整体升降气缸缩回",
    '"2-15 2号Feeder整体升降气缸缩回"
    '},
    '{
    '"3-00 来料不良传送带升降气缸缩回",
    '"3-01 来料不良传送带升降气缸伸出",
    '"3-02 装配后NG传送带升降气缸缩回",
    '"3-03 装配后NG传送带升降气缸伸出",
    '"3-04 拍PB升降气缸缩回",
    '"3-05 拍PB升降气缸伸出",
    '"3-06 拍VB升降气缸缩回",
    '"3-07 拍VB升降气缸伸出",
    '"3-08 拍VB平移气缸缩回",
    '"3-09 8号Feeder夹爪整体升降气缸伸出",
    '"3-10 3号Feeder整体升降气缸缩回",
    '"3-11 4号Feeder整体升降气缸缩回",
    '"3-12 5号Feeder整体升降气缸缩回",
    '"3-13 6号Feeder整体升降气缸缩回",
    '"3-14 7号Feeder整体升降气缸缩回",
    '"3-15 8号Feeder整体升降气缸缩回"
    '},
    '{
    '"4-00 备用",
    '"4-01 备用",
    '"4-02 备用",
    '"4-03 备用",
    '"4-04 左量测升降气缸缩回",
    '"4-05 左量测升降气缸伸出",
    '"4-06 备用",
    '"4-07 备用",
    '"4-08 备用",
    '"4-09 备用",
    '"4-10 右量测升降气缸缩回",
    '"4-11 右量测升降气缸伸出",
    '"4-12 1号2号Feeder料带剪切气缸缩回",
    '"4-13 3号4号Feeder料带剪切气缸缩回",
    '"4-14 5号6号Feeder料带剪切气缸缩回",
    '"4-15 7号8号Feeder料带剪切气缸缩回"
    '},
    '{
    '"5-00 Feeder1 Ready",
    '"5-01 Feeder2 Ready",
    '"5-02 Feeder3 Ready",
    '"5-03 Feeder4 Ready",
    '"5-04 Feeder5 Ready",
    '"5-05 Feeder6 Ready",
    '"5-06 Feeder7 Ready",
    '"5-07 Feeder8 Ready",
    '"5-08 Feeder1 Alarm",
    '"5-09 Feeder2 Alarm",
    '"5-10 Feeder3 Alarm",
    '"5-11 Feeder4 Alarm",
    '"5-12 Feeder5 Alarm",
    '"5-13 Feeder6 Alarm",
    '"5-14 Feeder7 Alarm",
    '"5-15 Feeder8 Alarm"
    '}
    '}
    '    Public OutputName(,) As String = {
    '{
    '"0-00 机械手启动",
    '"0-01 机械手停止",
    '"0-02 机械手暂停",
    '"0-03 机械手继续",
    '"0-04 机械手复位",
    '"0-05 产品OK",
    '"0-06 产品NG(鸣)",
    '"0-07 红色机器报警",
    '"0-08 绿色机器工作正常",
    '"0-09 黄色机器待机中",
    '"0-10 机器报警鸣叫",
    '"0-11 真空泵电源",
    '"0-12 日光灯",
    '"0-13 给上一台可以接收信号",
    '"0-14 给下一台设备有载具信号",
    '"0-15 给下一台设备载具不可用信号"
    '},
    '{
    '"1-00 备用",
    '"1-01 Feeder夹爪气缸总控制",
    '"1-02 Feeder手柄控制开/关",
    '"1-03 Feeder电源控制开/关",
    '"1-04 1号Feeder夹爪气缸",
    '"1-05 阻挡气缸1",
    '"1-06 阻挡气缸2",
    '"1-07 阻挡气缸3",
    '"1-08 阻挡气缸4",
    '"1-09 2号Feeder夹爪气缸",
    '"1-10 3号Feeder夹爪气缸",
    '"1-11 4号Feeder夹爪气缸",
    '"1-12 5号Feeder夹爪气缸",
    '"1-13 6号Feeder夹爪气缸",
    '"1-14 7号Feeder夹爪气缸",
    '"1-15 8号Feeder夹爪气缸"
    '},
    '{
    '"2-00 吸嘴1(PB)吸真空",
    '"2-01 吸嘴1(PB)破真空",
    '"2-02 吸嘴2(V+)吸真空 ",
    '"2-03 吸嘴2(V+)破真空",
    '"2-04 吸嘴3(V-)吸真空",
    '"2-05 吸嘴3(V-)破真空",
    '"2-06 Housing吸真空",
    '"2-07 备用",
    '"2-08 备用",
    '"2-09 备用",
    '"2-10 备用",
    '"2-11 传送带1夹紧气缸",
    '"2-12 传送带2夹紧气缸",
    '"2-13 传送带3夹紧气缸",
    '"2-14 Housing吸真空升降气缸",
    '"2-15 备用"
    '},
    '{
    '"3-00 来料不良传送带升降气缸",
    '"3-01 装配后NG传送带升降气缸",
    '"3-02 拍PB升降滑台气缸",
    '"3-03 拍VB升降气缸",
    '"3-04 拍VB前后平移气缸",
    '"3-05 备用",
    '"3-06 备用",
    '"3-07 1号Feeder整体升降气缸",
    '"3-08 2号Feeder整体升降气缸",
    '"3-09 3号Feeder整体升降气缸",
    '"3-10 4号Feeder整体升降气缸",
    '"3-11 5号Feeder整体升降气缸",
    '"3-12 6号Feeder整体升降气缸",
    '"3-13 Loadcell压力达到上限值",
    '"3-14 7号Feeder整体升降气缸",
    '"3-15 8号Feeder整体升降气缸"
    '},
    '{
    '"4-00 备用",
    '"4-01 左CCD平移气缸",
    '"4-02 左量测升降气缸",
    '"4-03 备用",
    '"4-04 备用",
    '"4-05 右量测升降气缸",
    '"4-06 备用",
    '"4-07 备用",
    '"4-08 备用",
    '"4-09 备用",
    '"4-10 备用",
    '"4-11 备用",
    '"4-12 1号2号Feeder料带剪切气缸",
    '"4-13 3号4号Feeder料带剪切气缸",
    '"4-14 5号6号Feeder料带剪切气缸",
    '"4-15 7号8号Feeder料带剪切气缸"
    '},
    '{
    '"5-00 1号Feeder 脉冲信号",
    '"5-01 2号Feeder 脉冲信号",
    '"5-02 3号Feeder 脉冲信号",
    '"5-03 4号Feeder 脉冲信号",
    '"5-04 5号Feeder 脉冲信号",
    '"5-05 6号Feeder 脉冲信号",
    '"5-06 7号Feeder 脉冲信号",
    '"5-07 8号Feeder 脉冲信号",
    '"5-08 1号Feeder 使能",
    '"5-09 2号Feeder 使能",
    '"5-10 3号Feeder 使能",
    '"5-11 4号Feeder 使能",
    '"5-12 5号Feeder 使能",
    '"5-13 6号Feeder 使能",
    '"5-14 7号Feeder 使能",
    '"5-15 8号Feeder 使能"}
    '}
    '#End Region

    '#Region "VB+ 自动运行时CCD数据存储变量定义"
    '    Public Vup_OffsetX As Double
    '    Public Vup_OffsetY As Double
    '    Public Vup_OffsetAngle As Double
    '    Public Vup_MissingResult As Integer
    '    Public Vup_ButtonLength As Double
    '    Public Vup_ButtonWidth As Double
    '    Public Vup_HousingLength As Double
    '    Public Vup_HousingWidth As Double
    '#End Region
    '#Region "VB+ CCD返回数据暂存变量定义"
    '    Public Vup_WOffsetX As Double
    '    Public Vup_WOffsetY As Double
    '    Public Vup_WOffsetAngle As Double
    '    Public Vup_WMissingResult As Integer
    '    Public Vup_WButtonLength As Double
    '    Public Vup_WButtonWidth As Double
    '    Public Vup_WHousingLength As Double
    '    Public Vup_WHousingWidth As Double

    '    Public Vup_WButtonX As Double        '参数复用，此参数在校正时（"T1，2"），返回的是Mark点的X
    '    Public Vup_WButtonY As Double        '参数复用，此参数在校正时（"T1，2"），返回的是Mark点的Y
    '    Public Vup_WHousingX As Double
    '    Public Vup_WHousingY As Double
    '#End Region
    '#Region "VB- 自动运行时CCD数据存储变量定义"
    '    Public Vdown_OffsetX As Double
    '    Public Vdown_OffsetY As Double
    '    Public Vdown_OffsetAngle As Double
    '    Public Vdown_MissingResult As Integer
    '    Public Vdown_ButtonLength As Double
    '    Public Vdown_ButtonWidth As Double
    '    Public Vdown_HousingLength As Double
    '    Public Vdown_HousingWidth As Double
    '#End Region
    '#Region "VB- CCD返回数据暂存变量定义"
    '    Public Vdown_WOffsetX As Double
    '    Public Vdown_WOffsetY As Double
    '    Public Vdown_WOffsetAngle As Double
    '    Public Vdown_WMissingResult As Integer
    '    Public Vdown_WButtonLength As Double
    '    Public Vdown_WButtonWidth As Double
    '    Public Vdown_WHousingLength As Double
    '    Public Vdown_WHousingWidth As Double

    '    Public Vdown_WButtonX As Double     '参数复用，此参数在校正时（"T1，4"），返回的是Mark点的X
    '    Public Vdown_WButtonY As Double     '参数复用，此参数在校正时（"T1，4"），返回的是Mark点的Y
    '    Public Vdown_WHousingX As Double
    '    Public Vdown_WHousingY As Double
    '#End Region
    '#Region "HB 自动运行时CCD数据存储变量定义"
    '    Public HB_OffsetX As Double
    '    Public HB_OffsetY As Double
    '    Public HB_OffsetAngle As Double
    '    Public HB_MissingResult As Integer
    '    Public HB_ButtonLength As Double
    '    Public HB_ButtonWidth As Double
    '    Public HB_HousingLength As Double
    '    Public HB_HousingWidth As Double
    '#End Region
    '#Region "HB CCD返回数据暂存变量定义"
    '    Public HB_WOffsetX As Double
    '    Public HB_WOffsetY As Double
    '    Public HB_WOffsetAngle As Double
    '    Public HB_WMissingResult As Integer
    '    Public HB_WButtonLength As Double
    '    Public HB_WButtonWidth As Double
    '    Public HB_WHousingLength As Double
    '    Public HB_WHousingWidth As Double

    '    Public HB_WButtonX As Double        '参数复用，此参数在校正时（"T2，2"），返回的是Mark点的X
    '    Public HB_WButtonY As Double        '参数复用，此参数在校正时（"T2，2"），返回的是Mark点的Y
    '    Public HB_WHousingX As Double
    '    Public HB_WHousingY As Integer
    '#End Region

    '#Region "DP2 自动运行时CCD数据暂存变量定义"
    '    'Public C2_Vup_Flag_Temp As Integer              'Vup Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_Vup_OffsetX_Temp As Double
    '    'Public C2_Vup_OffsetY_Temp As Double
    '    'Public C2_Vup_BtnDiameter_Temp As Double  'Vup Btn内圆直径

    '    'Public C2_Vup_ChkFlag_Temp As Integer           'Vup Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_Vup_CC_Temp As Double
    '    'Public C2_Vup_ChkOffsetX_Temp As Double
    '    'Public C2_Vup_ChkOffsetY_Temp As Double

    '    'Public C2_Vdown_Flag_Temp As Integer              'Vdown Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_Vdown_OffsetX_Temp As Double
    '    'Public C2_Vdown_OffsetY_Temp As Double
    '    'Public C2_Vdown_BtnDiameter_Temp As Double  'Vdown Btn内圆直径

    '    'Public C2_Vdown_ChkFlag_Temp As Integer           'Vdown Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_Vdown_CC_Temp As Double
    '    'Public C2_Vdown_ChkOffsetX_Temp As Double
    '    'Public C2_Vdown_ChkOffsetY_Temp As Double

    '    'Public C2_PB_Flag_Temp As Integer              'HB Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_PB_OffsetX_Temp As Double
    '    'Public C2_PB_OffsetY_Temp As Double
    '    'Public C2_PB_BtnDiameter_Temp As Double  'HB Btn内圆直径

    '    'Public C2_PB_ChkFlag_Temp As Integer           'HB Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    'Public C2_PB_CC_Temp As Double
    '    'Public C2_PB_ChkOffsetX_Temp As Double
    '    'Public C2_PB_ChkOffsetY_Temp As Double

    '    'Public C2_Shim_ID_Temp As Integer
    '    'Public C2_Shim_Flag_Temp As Integer
    '    'Public C2_Shim_OffsetX_Temp As Integer
    '    'Public C2_Shim_OffsetY_Temp As Integer
    '    'Public C2_PB_ShimDiameter_Temp As Double      'HB Shim直径
    '    'Public C2_Vup_ShimDiameter_Temp As Double     'Vup Shim直径
    '    'Public C2_Vdown_ShimDiameter_Temp As Double   'Vdown Shim直径
    '#End Region
    '#Region "DP2 自动运行时CCD数据存储变量定义"
    '    Public C2_T1_VB As String

    '    Public C2_Vup_Flag As Integer              'Vup Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_Vup_OffsetX As Double
    '    Public C2_Vup_OffsetY As Double
    '    Public C2_Vup_BtnDiameter As Double  'Vup Btn内圆直径

    '    Public C2_Vup_EyesX As Double
    '    Public C2_Vup_EyesY As Double
    '    Public C2_Vup_MouthX As Double
    '    Public C2_Vup_MouthY As Double
    '    Public C2_Vup_Distance As Double

    '    Public C2_Vup_ChkFlag As Integer           'Vup Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_Vup_CC As Double
    '    Public C2_Vup_ChkOffsetX As Double
    '    Public C2_Vup_ChkOffsetY As Double

    '    Public C2_Vdn_Flag As Integer              'Vdown Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_Vdn_OffsetX As Double
    '    Public C2_Vdn_OffsetY As Double
    '    Public C2_Vdn_BtnDiameter As Double  'Vdown Btn内圆直径

    '    Public C2_Vdn_EyesX As Double
    '    Public C2_Vdn_EyesY As Double
    '    Public C2_Vdn_MouthX As Double
    '    Public C2_Vdn_MouthY As Double
    '    Public C2_Vdn_Distance As Double

    '    Public C2_Vdn_ChkFlag As Integer           'Vdown Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_Vdn_CC As Double
    '    Public C2_Vdn_ChkOffsetX As Double
    '    Public C2_Vdn_ChkOffsetY As Double

    '    Public C2_T2_HB As String

    '    Public C2_HB_Flag As Integer              'HB Btn定位拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_HB_OffsetX As Double
    '    Public C2_HB_OffsetY As Double
    '    Public C2_HB_BtnDiameter As Double  'HB Btn内圆直径

    '    Public C2_HB_EyesX As Double
    '    Public C2_HB_EyesY As Double
    '    Public C2_HB_MouthX As Double
    '    Public C2_HB_MouthY As Double
    '    Public C2_HB_Distance As Double

    '    Public C2_HB_ChkFlag As Integer           'HB Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C2_HB_CC As Double
    '    Public C2_HB_ChkOffsetX As Double
    '    Public C2_HB_ChkOffsetY As Double

    '    Public C2_T3_Shim As String

    '    Public C2_HB_Shim_Flag As Integer
    '    Public C2_HB_Shim_OffsetX As Double
    '    Public C2_HB_Shim_OffsetY As Double
    '    Public C2_HB_Shim_Diameter As Double      'HB Shim直径

    '    Public C2_HB_ShimX As Double
    '    Public C2_HB_ShimY As Double
    '    Public C2_Vup_ShimX As Double
    '    Public C2_Vup_ShimY As Double
    '    Public C2_Vdn_ShimX As Double
    '    Public C2_Vdn_ShimY As Double

    '    Public C2_Vup_Shim_Flag As Integer
    '    Public C2_Vup_Shim_OffsetX As Double
    '    Public C2_Vup_Shim_OffsetY As Double
    '    Public C2_Vup_Shim_Diameter As Double     'Vup Shim直径

    '    Public C2_Vdn_Shim_Flag As Integer
    '    Public C2_Vdn_Shim_OffsetX As Double
    '    Public C2_Vdn_Shim_OffsetY As Double
    '    Public C2_Vdn_Shim_Diameter As Double   'Vdown Shim直径


    '    Public C3_Vup_ChkFlag As Integer           'Vup Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C3_Vup_CC As Double
    '    Public C3_Vup_ChkOffsetX As Double
    '    Public C3_Vup_ChkOffsetY As Double

    '    Public C3_Vdn_ChkFlag As Integer           'Vdown Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C3_Vdn_CC As Double
    '    Public C3_Vdn_ChkOffsetX As Double
    '    Public C3_Vdn_ChkOffsetY As Double

    '    Public C3_HB_ChkFlag As Integer           'HB Btn复检同心度拍照模型未搜索到---0，模型搜索到---1
    '    Public C3_HB_CC As Double
    '    Public C3_HB_ChkOffsetX As Double
    '    Public C3_HB_ChkOffsetY As Double
    '#End Region

    '#Region "3工站 CCD返回数据暂存变量定义"
    '    Public Vup_S3Gap As Double
    '    Public Vup_S3GapAngle As Double
    '    Public Vdown_S3Gap As Double
    '    Public Vdown_S3GapAngle As Double
    '    Public HB_S3Gap As Double
    '    Public HB_S3GapAngle As Double

    '    Public S3_LeftGap As Double
    '    Public S3_RightGap As Double
    '#End Region

    '#Region "Feeder变量"
    '    Public ID1 As String
    '    Public ID2 As String
    '    Public ID3 As String
    '    Public ID4 As String
    '    Public ID5 As String
    '    Public ID6 As String
    '    Public ID7 As String
    '    Public ID8 As String
    '    Public Feeder_Code_Temp(0 To 7) As String
    '    Public Shim_Code_Temp(0 To 7) As String
    '    Public Feeder_Shim_Band(0 To 7) As Boolean
    '    Public Shim_Com_Display As Boolean
    '    Public Feeder_Com_Display As Boolean
    '    Public Feeder_Ready_Flag As Boolean
    '    Public Feeder_Succsed_Flag As Boolean

    '    Public FeederiniFileName As String
    '    Public Feeder_Alarm_Flag1 As Boolean
    '    Public Feeder_Alarm_Flag2 As Boolean
    '    Public Feeder_Alarm_Flag3 As Boolean

    '    Public SerialPort6OpenFlag As Boolean
    '    Public SerialPort6_String As String

    '    Public StaTime(0 To 200) As Long                            '时间存储变量
    '#End Region

    '#Region "功能：Feeder十六进制发送"
    '    Public Function HexSend(StrText As String) As Byte()

    '        On Error Resume Next
    '        Dim outputLen As Integer                                                    ' 发送数据长度
    '        Dim outData As String                                                       ' 发送数据暂存
    '        Dim SendArr() As Byte                                                       ' 发送数组
    '        Dim TemporarySave As String                                                 ' 数据暂存
    '        Dim dataCount As Integer                                                    ' 数据个数计数
    '        Dim i As Integer                                                            ' 局部变量

    '        outData = UCase(Replace(StrText, Space(1), Space(0)))                  ' 先去掉空格，再转换为大写字母
    '        outData = UCase(outData)                                                    ' 转换成大写
    '        outputLen = Len(outData)                                                    ' 数据长度

    '        For i = 0 To outputLen
    '            TemporarySave = Mid(outData, i + 1, 1)                                  ' 取一位数据
    '            If (Asc(TemporarySave) >= 48 And Asc(TemporarySave) <= 57) Or (Asc(TemporarySave) >= 65 And Asc(TemporarySave) <= 70) Then
    '                dataCount = dataCount + 1
    '            Else
    '                Exit For
    '                Exit Function
    '            End If
    '        Next

    '        If dataCount Mod 2 <> 0 Then                                                ' 判断十六进制数据是否为双数
    '            dataCount = dataCount - 1                                               ' 不是双数，则减1
    '        End If

    '        outData = Left(outData, dataCount)                                          ' 取出有效的十六进制数据

    '        ReDim SendArr(dataCount / 2 - 1)                                            ' 重新定义数组长度
    '        For i = 0 To dataCount / 2 - 1
    '            SendArr(i) = Val("&H" + Mid(outData, i * 2 + 1, 2))                     ' 取出数据转换成十六进制并放入数组中
    '        Next

    '        'SendCount = SendCount + (dataCount / 2)                                     ' 计算总发送数
    '        'TxtTXCount.Text = "TX:" & SendCount

    '        HexSend = SendArr                                                    ' 发送数据

    '    End Function

    '    Public Sub Feeder_Succsed()
    '        Feeder_Shim_Band(0) = IniGetStringValue(FeederiniFileName, ID1, "Shim1_Band_Flag", False)
    '        Feeder_Shim_Band(1) = IniGetStringValue(FeederiniFileName, ID2, "Shim2_Band_Flag", False)
    '        Feeder_Shim_Band(2) = IniGetStringValue(FeederiniFileName, ID3, "Shim3_Band_Flag", False)
    '        Feeder_Shim_Band(3) = IniGetStringValue(FeederiniFileName, ID4, "Shim4_Band_Flag", False)
    '        Feeder_Shim_Band(4) = IniGetStringValue(FeederiniFileName, ID5, "Shim5_Band_Flag", False)
    '        Feeder_Shim_Band(5) = IniGetStringValue(FeederiniFileName, ID6, "Shim6_Band_Flag", False)
    '        Feeder_Shim_Band(6) = IniGetStringValue(FeederiniFileName, ID7, "Shim7_Band_Flag", False)
    '        Feeder_Shim_Band(7) = IniGetStringValue(FeederiniFileName, ID8, "Shim8_Band_Flag", False)
    '        If Feeder_Shim_Band(0) = True And Feeder_Shim_Band(1) = True And Feeder_Shim_Band(2) = True And Feeder_Shim_Band(3) = True _
    '        And Feeder_Shim_Band(4) = True And Feeder_Shim_Band(5) = True And Feeder_Shim_Band(6) = True And Feeder_Shim_Band(7) = True Then
    '            Feeder_Succsed_Flag = True
    '        Else
    '            Feeder_Succsed_Flag = False
    '        End If
    '    End Sub
    '#End Region

    '#Region "功能：Error Code变量定义"
    '    Public HeartBeat_Enable As Boolean   '发送HB判定Error通讯定时器使能
    '    Public HeartBeat_Time As Long  '发送HB判定Error通讯时间标志
    '    Public Nozzl_Cylin As Integer '吸嘴取料当前Feeder升降气缸异常  ERR-GRPvn-30102
    '    Public CCD_Cylin As Integer 'CCD升降气缸异常相关               ERR-CNVvn-30001
    '    Public CCD_Model As Integer 'CCD模型搜索失败相关               ERR-CCDvn-30001
    '    Public Pressure_NG As Integer '气压信号异常                    ERR-FXA01-40004
    '    Public Take_Fdde_NG As Integer '取料未取到异常                 TOS-PFC01
    '    Public sErrDescription As String       '路径

    '    Public Sub Error_Code_Num()
    '        'ErrorCode当前错误代码
    '    End Sub

    '    Public Sub Error_Code_Description(ByVal ErrorCode As String)

    '        If InStr(1, ErrorCode, "ERR-GRP") <> 0 Then
    '            If ErrorCode = "ERR-GRP01-30102" Then    '吸嘴1所对应的夹爪伸出或缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-GRPvn-30102-1", ErrorCode, "N/A")
    '            ElseIf ErrorCode = "ERR-GRP02-30102" Then    '吸嘴2所对应的夹爪伸出或缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-GRPvn-30102-2", ErrorCode, "N/A")
    '            ElseIf ErrorCode = "ERR-GRP03-30102" Then    '吸嘴3所对应的夹爪伸出或缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-GRPvn-30102-3", ErrorCode, "N/A")
    '            End If
    '        ElseIf InStr(1, ErrorCode, "ERR-CNV01-30001") <> 0 Or InStr(1, ErrorCode, "ERR-CNV02-30001") <> 0 Then     'CCD升降气缸异常相关
    '            If CCD_Cylin = 1 Then     'HSG真空吸异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-1", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 2 Then   '2工站定位气缸伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-2", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 3 Then   '2工站定位气缸缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-3", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 4 Then   '3工站定位气缸伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-4", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 5 Then   '3工站定位气缸缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-5", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 6 Then   '二工站拍VB升降气缸伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-6", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 7 Then   '二工站拍VB升降气缸缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-7", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 8 Then    '二工站拍HB升降气缸伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-8", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 9 Then    '二工站拍HB升降气缸缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-9", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 10 Then   '二工站拍VB平移气缸伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-10", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 11 Then   '二工站拍VB平移气缸缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-11", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 12 Then   '三工站NG流水线伸出异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-12", ErrorCode, "N/A")
    '            ElseIf CCD_Cylin = 13 Then    '三工站NG流水线缩回异常
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CNVvn-30001-13", ErrorCode, "N/A")
    '            End If
    '        ElseIf InStr(1, ErrorCode, "ERR-CCD") <> 0 Then      'CCD模型搜索失败相关
    '            If CCD_Model = 1 Then    'VB+定位模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-1", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 2 Then  'VB-定位模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-2", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 3 Then   'HB 定位模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-3", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 4 Then   'VB-复检模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-4", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 5 Then   'VB+复检模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-5", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 6 Then    'HB复检模型搜索失败
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-6", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 7 Then    '二站CCD通讯连接断开
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-7", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 8 Then    '三站CCD通讯连接断开
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-8", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 9 Then   '二站CCD拍照等待数据返回超时
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-9", ErrorCode, "N/A")
    '            ElseIf CCD_Model = 10 Then   '三站CCD拍照等待数据返回超时
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-CCDvn-30001-10", ErrorCode, "N/A")
    '            End If
    '        ElseIf InStr(1, ErrorCode, "ERR-FXA") <> 0 Then      '气压信号异常
    '            If Pressure_NG = 1 Then    '主气路正气压信号异常 
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-FXA01-40004-1", ErrorCode, "N/A")
    '            ElseIf Pressure_NG = 2 Then  '主气路负气压信号异常 
    '                sErrDescription = IniGetStringValue(FilePath(22), "ERR-FXA01-40004-2", ErrorCode, "N/A")
    '            End If
    '        ElseIf InStr(1, ErrorCode, "TOS-PFC01") <> 0 Then      'Shim取料未取到异常
    '            If Take_Fdde_NG = 1 Then   'HB未取到
    '                sErrDescription = IniGetStringValue(FilePath(22), "TOS-PFC01-HB", ErrorCode, "N/A")
    '            ElseIf Take_Fdde_NG = 2 Then  'VB+未取到
    '                sErrDescription = IniGetStringValue(FilePath(22), "TOS-PFC01-VB+", ErrorCode, "N/A")
    '            ElseIf Take_Fdde_NG = 3 Then  'VB-未取到
    '                sErrDescription = IniGetStringValue(FilePath(22), "TOS-PFC01-VB-", ErrorCode, "N/A")
    '            End If
    '        Else
    '            sErrDescription = IniGetStringValue(FilePath(22), "ErrorCodeDescription", ErrorCode, "N/A")
    '            'sErrDescription = IniGetStringValue(FilePath(22), "ErrorCodeDescription", ErrorCode, "N/A")
    '        End If
    '    End Sub

    '#End Region

    '#Region "ErrorCode判断连接状态相关函数"
    '    Public Sub ErrorCode_Check()
    '        Static LocalSystemTime As String
    '        Dim TempStr As String
    '        Dim Temp1 As String
    '        Dim sErrorStatus As String
    '        Dim StaError_Time As Double
    '        Static SHARED_FOLDER_EXIST As Integer
    '        Temp1 = Now.ToString("yyyyMMddHHmmss")
    '        On Error Resume Next
    '        Select Case Error_Step
    '            Case 5
    '                If Dir(FilePath(10), vbDirectory) = "" Then
    '                    SHARED_FOLDER_EXIST = 0
    '                Else
    '                    SHARED_FOLDER_EXIST = 1
    '                    Error_Step = 20
    '                End If
    '                If Frm_Main.Winsock_HB.CtlState = 7 Then
    '                    sendHB_Buffer = ""
    '                    Error_Step = 20
    '                Else
    '                    StaError_Time = GetTickCount
    '                    Error_Step = 10
    '                End If
    '            Case 10
    '                If Frm_Main.Winsock_HB.CtlState = 7 Then
    '                    sendHB_Buffer = ""
    '                    Error_Step = 20
    '                Else
    '                    If GetTickCount - StaError_Time > 3000 Then
    '                        '    Call SavePDCALog("ErrorCode", "Error上传网络连接异常！")
    '                        '    Call SavePDCALog("ErrorCode", "Main.Winsock_Error.State = " & Frm_Main.Winsock_PDCA.CtlState)
    '                        '    'ERROR 通讯连接断开
    '                        '    Call St3SubPushError(Error_Step, "********", "Error上传通讯连接异常", "Go", "Uploading")
    '                        '    Frm_UI.List_Sts.Items.Add("Error上传网络连接异常，请确认！")
    '                        '    Error_Step = 70
    '                        'Else
    '                        Frm_Engineering.LB_list.Items.Add("◆HeartBeat发送网络连接异常")
    '                        Error_Step = 70
    '                        'If PDCAFlag = False Then     'PDCA未使用时
    '                        '    Call Winsock_HBConn()
    '                        '    Error_Step = 20
    '                        'End If
    '                    End If
    '                End If
    '            Case 20
    '                'Send_HB,DP2,Temp1,SHARED_FOLDER_EXIST,@
    '                HB_SendCmd("Send_HB,DP2," & Temp1 & "," & SHARED_FOLDER_EXIST & ",@")
    '                If bIsEngneeringMode Then
    '                    Frm_Engineering.LB_list.Items.Add("◆发送Send_HB命令给FMM")
    '                    If Frm_Engineering.LB_list.Items.Count = 70 Then
    '                        Frm_Engineering.LB_list.Items.Clear()
    '                    End If
    '                End If
    '                Call SaveHBLog("ErrorCode：", ">>>发送(Send_HB,@)命令给Mac Mini")
    '                StaError_Time = GetTickCount
    '                LocalSystemTime = Date.Now.ToString("yyyyMMddHHmmss")

    '                Error_Step = 30
    '            Case 30
    '                If sendHB_data(0) = "Ack" Then     'InStr(1, sendHB_Buffer, "Ack,@") <> 0 
    '                    If bIsEngneeringMode Then
    '                        sendHB_Buffer = Mid(sendHB_Buffer, 5, Len(sendHB_Buffer))
    '                        If sendHB_Buffer <> "@" Then
    '                            Call SystimeSet(LocalSystemTime, Mid(Trim(sendHB_Buffer), 1, 14))   'Mid(Trim(HeatBtReceiveStr), 1, 14)
    '                        End If
    '                        'HeatBtReceiveStr = Mid(HeatBtReceiveStr, 5, Len(HeatBtReceiveStr))
    '                        'Call SystimeSet(LocalSystemTime, Mid(Trim(HeatBtReceiveStr), 1, 14))
    '                        'MyThread_sendHB = New Threading.Thread(AddressOf Set_Time)
    '                        'MyThread_sendHB.Start()
    '                        'MyThread_sendHB.IsBackground = True
    '                        'Call SystimeSet(LocalSystemTime, Mid(Trim(sendHB_Buffer), 1, 14))   'Mid(Trim(HeatBtReceiveStr), 1, 14)
    '                        'Today = Format(sPDCA_data(1), "yy/MM/dd")
    '                        'TimeOfDay = Format(sPDCA_data(1), "HH:mm:ss")
    '                        Frm_Engineering.LB_list.Items.Add("◆收到FMM返回的Ack:" & sendHB_Buffer)

    '                    End If
    '                    Call SaveHBLog("ErrorCode：", "◆收到FMM返回的Ack:" & sendHB_Buffer)
    '                    Error_Step = 40
    '                Else
    '                    If GetTickCount - StaError_Time > 5000 Then
    '                        Call SaveHBLog("ErrorCode：", sendHB_Buffer)
    '                        If bIsEngneeringMode Then
    '                            Frm_Engineering.LB_list.Items.Add("◆没有收到FMM的Ack命令")
    '                        End If
    '                        Call SaveHBLog("ErrorCode：", "<<<等待5S后，未收到Mac Mini返回的(Ack,@)")
    '                        Error_Step = 70
    '                    End If
    '                End If
    '            Case 40
    '                If bIsEngneeringMode Then
    '                    Frm_Engineering.LB_list.Items.Add("◆Error上传与Mac Mini通讯正常")
    '                End If
    '                Call SaveHBLog("ErrorCode：", "◆Error上传与Mac Mini通讯正常")
    '                'ErrorFlag.Status = False   'Error状态
    '                HeartBeat_Time = GetTickCount
    '                Frm_Main.Timer_Error.Enabled = False
    '                HeartBeat_Enable = False
    '                'Frm_Main.Winsock_PDCA.Close()
    '                Error_Step = 0
    '            Case 70
    '                If bIsEngneeringMode Then
    '                    Frm_Engineering.LB_list.Items.Add("◆Error上传与Mac Mini通讯异常")
    '                End If
    '                Call SaveHBLog("ErrorCode：", "◆Error上传与Mac Mini通讯异常")
    '                'ErrorFlag.Status = False   'Error状态
    '                HeartBeat_Time = GetTickCount
    '                Frm_Main.Timer_Error.Enabled = False
    '                HeartBeat_Enable = False
    '                'Frm_Main.Winsock_PDCA.Close()
    '                Error_Step = 0
    '        End Select
    '    End Sub
    '    Public Sub SaveHBLog(SN As String, LogItem As String)      'SendHB Log File保存
    '        Dim CurrentData As String
    '        Dim CurrentTime As String
    '        CurrentData = Now.ToString("yyyyMMdd")
    '        CurrentTime = Now.ToString("HH:mm:ss")
    '        WriteDattxt(FilePath(4) & "\" & CurrentData & "_DP2 HB Log.txt", "SN: " & SN & " \*Time: " & CurrentData & "_" & CurrentTime & " \*Message: " & LogItem)
    '    End Sub
    '    Public Sub SystimeSet(ByVal LocalSystemTime As String, ByVal MiniSystemTime As String)
    '        'Dim SysTimechang As Boolean
    '        Dim SysTime(2) As Int32
    '        Dim i As Integer
    '        Dim SystemYear(2) As String
    '        Dim Systemmonth(2) As String
    '        Dim Systemday(2) As String
    '        Dim Systemhour(2) As String
    '        Dim Systemmin(2) As String
    '        Dim Systemss(2) As String
    '        SystemYear(0) = Mid(LocalSystemTime, 1, 4)
    '        Systemmonth(0) = Mid(LocalSystemTime, 5, 2)
    '        Systemday(0) = Mid(LocalSystemTime, 7, 2)
    '        Systemhour(0) = Mid(LocalSystemTime, 9, 2)
    '        Systemmin(0) = Mid(LocalSystemTime, 11, 2)
    '        Systemss(0) = Mid(LocalSystemTime, 13, 2)
    '        SystemYear(1) = Mid(MiniSystemTime, 1, 4)
    '        Systemmonth(1) = Mid(MiniSystemTime, 5, 2)
    '        Systemday(1) = Mid(MiniSystemTime, 7, 2)
    '        Systemhour(1) = Mid(MiniSystemTime, 9, 2)
    '        Systemmin(1) = Mid(MiniSystemTime, 11, 2)
    '        Systemss(1) = Mid(MiniSystemTime, 13, 2)
    '        SysTime(0) = Convert.ToInt32(Systemhour(0)) * 60 + Convert.ToInt32(Systemmin(0)) * 60 + Convert.ToInt32(Systemss(0))
    '        SysTime(1) = Convert.ToInt32(Systemhour(1)) * 60 + Convert.ToInt32(Systemmin(1)) * 60 + Convert.ToInt32(Systemss(1))
    '        'SysTimechang = False
    '        ''For i = 1 To 8
    '        '    If Mid(LocalSystemTime, i, 1) <> Mid(MiniSystemTime, i, 1) Then
    '        '        SysTimechang = True
    '        '        Exit For
    '        '    End If
    '        'Next
    '        'If SysTimechang = False Then
    '        '    If Math.Abs(SysTime(0) - SysTime(1)) > 90 Then
    '        '        SysTimechang = True
    '        '    End If
    '        'End If
    '        'If SysTimechang = False Then
    '        '    Exit Sub
    '        'End If


    '        SystemData = SystemYear(1) & "/" & Systemmonth(1) & "/" & Systemday(1)
    '        SystemTime = Systemhour(1) & ":" & Systemmin(1) & ":" & Systemss(1)

    '        SystimeSetStarting = New Thread(AddressOf SystimeSetStart)
    '        SystimeSetStarting.Priority = ThreadPriority.Highest
    '        SystimeSetStarting.IsBackground = True
    '        SystimeSetStarting.Start()

    '    End Sub
    '    Sub SystimeSetStart()
    '        Today = SystemData
    '        TimeOfDay = SystemTime
    '    End Sub
    '#End Region

    '#Region "函数：将吸嘴补正值赋值给机械手补正变量"
    '    Public Sub Nolzz_Offset()
    '        NozzleVBupX = Par.Par_TxtBox(11)  '吸嘴2 与吸嘴1X差值
    '        NozzleVBupY = Par.Par_TxtBox(12)   '吸嘴2 与吸嘴1Y差值
    '        NozzleVBdwX = Par.Par_TxtBox(13)   '吸嘴3 与吸嘴1X差值
    '        NozzleVBdwY = Par.Par_TxtBox(14)   '吸嘴3 与吸嘴1Y差值
    '    End Sub
    '#End Region

    '#Region "功能：取料测试Shim CCD拍照数据收集"
    '    Public Sub TakeShimTest_DataCollect()
    '        Dim TakeShimDate As String
    '        Dim TakeShimTime As String
    '        Dim TakeShimAlldata As String
    '        TakeShimDate = Now.ToString("yyyyMMdd")
    '        TakeShimTime = Now.ToString("HHmmss")

    '        TakeShimAlldata = ""
    '        If bAutoRunFlag Then
    '            TakeShimAlldata = "," & TrayInfo(St2Tray).HSG_SN & "," & TakeShimDate & "," & TakeShimTime & "," & TrayInfo(St2Tray).HBShimX & "," & _
    '            TrayInfo(St2Tray).HBShimY & "," & TrayInfo(St2Tray).HBShimCC & "," & TrayInfo(St2Tray).VdnShimX & "," & _
    '            TrayInfo(St2Tray).VdnShimY & "," & TrayInfo(St2Tray).VdnShimCC & "," & TrayInfo(St2Tray).VupShimX & "," & _
    '            TrayInfo(St2Tray).VupShimY & "," & TrayInfo(St2Tray).VupShimCC
    '        Else
    '            TakeShimAlldata = "," & "" & "," & TakeShimDate & "," & TakeShimTime & "," & TrayInfo(St2Tray).HBShimX & "," & _
    '            TrayInfo(St2Tray).HBShimY & "," & TrayInfo(St2Tray).HBShimCC & "," & TrayInfo(St2Tray).VdnShimX & "," & _
    '            TrayInfo(St2Tray).VdnShimY & "," & TrayInfo(St2Tray).VdnShimCC & "," & TrayInfo(St2Tray).VupShimX & "," & _
    '            TrayInfo(St2Tray).VupShimY & "," & TrayInfo(St2Tray).VupShimCC
    '        End If

    '        If Dir(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestData.csv") = "" Then
    '            Call FileCopy(Application.StartupPath & "\DP2Parameter" & "\TakeShimTestData.csv", FilePath(7) & "\" & TakeShimDate & "_TakeShimTestData.csv")
    '        End If
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestData.csv", TakeShimAlldata)
    '    End Sub
    '#End Region

    '#Region "功能：取料测试Shim结果数据收集"
    '    Public TakeShim_N1_OKNum As Integer
    '    Public TakeShim_N1_NGNum As Integer
    '    Public TakeShim_N2_OKNum As Integer
    '    Public TakeShim_N2_NGNum As Integer
    '    Public TakeShim_N3_OKNum As Integer
    '    Public TakeShim_N3_NGNum As Integer
    '    Public Sub TakeShimTestALL_DataCollect()
    '        Dim Feeder1_TakeShim, Feeder2_TakeShim, Feeder3_TakeShim, Feeder4_TakeShim, Feeder5_TakeShim, _
    '            Feeder6_TakeShim, Feeder7_TakeShim, Feeder8_TakeShim, Feeder_TakeShimHB, _
    '            Feeder_TakeShimVup, Feeder_TakeShimVdn As String
    '        Dim TakeShimDate As String
    '        Dim TakeShimTime As String
    '        Dim TakeShimAllNozzle As String
    '        Dim TakeShim_SUM As String
    '        Dim TakeShimAlldata As String
    '        TakeShimDate = Now.ToString("yyyyMMdd")
    '        TakeShimTime = Now.ToString("HHmmss")
    '        If Dir(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv") = "" Then
    '            Call FileCopy(Application.StartupPath & "\DP2Parameter" & "\TakeShimTestALL.csv", FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv")
    '        End If

    '        Feeder1_TakeShim = "Feeder1" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label143.Text) & "," & _
    '            Val(Frm_Engineering.Label142.Text) & "," & Val(Frm_Engineering.Label141.Text) & "," & Val(Frm_Engineering.Label140.Text) & "," & _
    '            Val(Frm_Engineering.Label139.Text) & "," & Val(Frm_Engineering.Label138.Text) & "," & Val(Frm_Engineering.Label137.Text) & "," & _
    '        Val(Frm_Engineering.Label136.Text) '& "," & UCase(Frm_Engineering.Label49.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder1_TakeShim)

    '        Feeder2_TakeShim = "Feeder2" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label151.Text) & "," & _
    '            Val(Frm_Engineering.Label150.Text) & "," & Val(Frm_Engineering.Label149.Text) & "," & Val(Frm_Engineering.Label148.Text) & "," & _
    '            Val(Frm_Engineering.Label147.Text) & "," & Val(Frm_Engineering.Label146.Text) & "," & Val(Frm_Engineering.Label145.Text) & "," & _
    '        Val(Frm_Engineering.Label144.Text) ' & "," & UCase(Frm_Engineering.Label50.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder2_TakeShim)

    '        Feeder3_TakeShim = "Feeder3" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label159.Text) & "," & _
    '            Val(Frm_Engineering.Label158.Text) & "," & Val(Frm_Engineering.Label157.Text) & "," & Val(Frm_Engineering.Label156.Text) & "," & _
    '            Val(Frm_Engineering.Label155.Text) & "," & Val(Frm_Engineering.Label154.Text) & "," & Val(Frm_Engineering.Label153.Text) & "," & _
    '        Val(Frm_Engineering.Label152.Text) '& "," & UCase(Frm_Engineering.Label51.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder3_TakeShim)

    '        Feeder4_TakeShim = "Feeder4" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label167.Text) & "," & _
    '            Val(Frm_Engineering.Label166.Text) & "," & Val(Frm_Engineering.Label165.Text) & "," & Val(Frm_Engineering.Label164.Text) & "," & _
    '            Val(Frm_Engineering.Label163.Text) & "," & Val(Frm_Engineering.Label162.Text) & "," & Val(Frm_Engineering.Label161.Text) & "," & _
    '        Val(Frm_Engineering.Label160.Text) ' & "," & UCase(Frm_Engineering.Label52.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder4_TakeShim)

    '        Feeder5_TakeShim = "Feeder5" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label175.Text) & "," & _
    '            Val(Frm_Engineering.Label174.Text) & "," & Val(Frm_Engineering.Label173.Text) & "," & Val(Frm_Engineering.Label172.Text) & "," & _
    '            Val(Frm_Engineering.Label171.Text) & "," & Val(Frm_Engineering.Label170.Text) & "," & Val(Frm_Engineering.Label169.Text) & "," & _
    '        Val(Frm_Engineering.Label168.Text) '& "," & UCase(Frm_Engineering.Label53.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder5_TakeShim)

    '        Feeder6_TakeShim = "Feeder6" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label183.Text) & "," & _
    '            Val(Frm_Engineering.Label182.Text) & "," & Val(Frm_Engineering.Label181.Text) & "," & Val(Frm_Engineering.Label180.Text) & "," & _
    '            Val(Frm_Engineering.Label179.Text) & "," & Val(Frm_Engineering.Label178.Text) & "," & Val(Frm_Engineering.Label177.Text) & "," & _
    '        Val(Frm_Engineering.Label176.Text) '& "," & UCase(Frm_Engineering.Label54.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder6_TakeShim)

    '        Feeder7_TakeShim = "Feeder7" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label191.Text) & "," & _
    '            Val(Frm_Engineering.Label190.Text) & "," & Val(Frm_Engineering.Label189.Text) & "," & Val(Frm_Engineering.Label188.Text) & "," & _
    '            Val(Frm_Engineering.Label187.Text) & "," & Val(Frm_Engineering.Label186.Text) & "," & Val(Frm_Engineering.Label185.Text) & "," & _
    '        Val(Frm_Engineering.Label184.Text) ' & "," & UCase(Frm_Engineering.Label55.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder7_TakeShim)

    '        Feeder8_TakeShim = "Feeder8" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label199.Text) & "," & _
    '            Val(Frm_Engineering.Label198.Text) & "," & Val(Frm_Engineering.Label197.Text) & "," & Val(Frm_Engineering.Label196.Text) & "," & _
    '            Val(Frm_Engineering.Label195.Text) & "," & Val(Frm_Engineering.Label194.Text) & "," & Val(Frm_Engineering.Label193.Text) & "," & _
    '        Val(Frm_Engineering.Label192.Text) '& "," & UCase(Frm_Engineering.Label56.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", Feeder8_TakeShim)

    '        TakeShim_SUM = "TakeShimSum" & "," & "'" & TakeShimDate & TakeShimTime & "," & Val(Frm_Engineering.Label202.Text) & "," & _
    '        Val(Frm_Engineering.Label201.Text) & "," & Val(Frm_Engineering.Label200.Text) & "," & Val(Frm_Engineering.Label57.Text) & "," & _
    '        Val(Frm_Engineering.Label58.Text) & "," & Val(Frm_Engineering.Label59.Text) & "," & Val(Frm_Engineering.Label60.Text) & "," & _
    '        Val(Frm_Engineering.Label61.Text)
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", TakeShim_SUM)

    '        TakeShimAllNozzle = "," & "'" & TakeShimDate & TakeShimTime & "," & "N1_HB_T" & "," & "N1_HB_F" & "," & _
    '            "N2_Vup_T" & "," & "N2_Vup_F" & "," & "N3_Vdn_T" & "," & "N3_Vdn_F"
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", TakeShimAllNozzle)
    '        TakeShimAlldata = "," & "" & "" & "," & TakeShim_N1_OKNum & "," & TakeShim_N1_NGNum & "," & _
    '            TakeShim_N2_OKNum & "," & TakeShim_N2_NGNum & "," & TakeShim_N3_OKNum & "," & TakeShim_N3_NGNum
    '        WriteCsvFile(FilePath(7) & "\" & TakeShimDate & "_TakeShimTestALL.csv", TakeShimAlldata)
    '    End Sub
    '#End Region

End Module

