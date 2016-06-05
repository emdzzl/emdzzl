Imports BZ.UI
Imports System.Data.OleDb
Imports System.Math
Imports System.Text.StringBuilder 
Imports System.Threading

Public Class frmMain
#Region "窗体加载"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = New Point(0, 0)
            .Size = New Size(1024, 730)
            .BackColor = Color.White
            ChildFrmOffsetPoint = New Point(2, 68)
        End With

        '用于对路径变量赋值
        CreatFilePath()

        '用于读取更新用户名和密码
        RereshParaLogin(ComboBox1)

        '用于读取更新轴运行参数
        Call ReadAxisPar()

        '用于初始化轴卡
        Call InitMotionCard()
    End Sub
#End Region

#Region "窗体自定义控件重绘"
    Private Sub Frm_Main_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf (a) Is RoundPanel Then
                a.Invalidate()
            End If
        Next
        For Each a In Me.Controls
            If TypeOf (a) Is RoundLabel Then
                a.Invalidate()
            End If
        Next
        For Each a In Me.Controls
            If TypeOf (a) Is SingleRoundBar Then
                a.Invalidate()
            End If
        Next
        For Each a In Me.Controls
            If TypeOf (a) Is DoubleRoundBar Then
                a.Invalidate()
            End If
        Next
    End Sub
#End Region

#Region "主界面各按钮响应事件" 
#Region "界面切换详细动作"
    ''' <summary>
    ''' 各界面切换按钮
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click, btnRunInfo.Click, btnParSetting.Click, btnMachineInfo.Click, btnHome.Click, btnCCDSetting.Click, btnAlarmHistory.Click
        LoadFormAndSetBtBkColor(sender)
    End Sub

    Private Sub LoadFormAndSetBtBkColor(bt As Button)
        Dim tempFrm As String = ""
        Me.BackColor = Color.White
        btnProduction.BackColor = colUnselectedBtn
        btnParSetting.BackColor = colUnselectedBtn
        btnCCDSetting.BackColor = colUnselectedBtn
        btnRunInfo.BackColor = colUnselectedBtn
        btnAlarmHistory.BackColor = colUnselectedBtn
        btnMachineInfo.BackColor = colUnselectedBtn
        btnOpenDataFile.BackColor = Color.White
        btnOpenCCDFile.BackColor = Color.White
        btnHome.BackColor = colUnselectedBtn
        bt.BackColor = colSelectedBtn

        Select Case bt.Name
            Case "btnProduction"
                If IsNotShow("frmProduction") Then frmProduction.Show(Me)
                Me.btnProduction.BackColor = colSelectedBtn
                strOpenTargetForm = "frmProduction"
            Case "btnRunInfo"
                If IsNotShow("frmRunInfo") Then frmRunInfo.Show(Me)
                strOpenTargetForm = "frmRunInfo"
            Case "btnAlarmHistory"
                If IsNotShow("frmAlarmHistory") Then frmAlarmHistory.Show(Me)
                strOpenTargetForm = "frmAlarmHistory"
            Case "btnMachineInfo"
                If IsNotShow("frmMachineInfo") Then frmMachineInfo.Show(Me)
                strOpenTargetForm = "frmMachineInfo"
            Case "btnParSetting"
                strOpenTargetForm = "frmPar"
                If IsNotShow("frmPar") Then frmPar.Show(Me)
            Case "btnCCDSetting"
                strOpenTargetForm = "frmParCCD"
                If IsNotShow("frmParCCD") Then frmParCCD.Show(Me)
            Case "btnHome"
                Me.btnProductionMode.BackColor = Color.LightGray
                Me.btnEngneeringMode.BackColor = Color.LightGray
                Me.btnCPKMode.BackColor = Color.LightGray
                Me.TB_Password.Text = ""
                If IsNotShow("frmMain") Then
                End If
                strOpenTargetForm = ""
                RestoreLoginDialog()
        End Select
    End Sub

    Private Sub InitLoginDialog()
        ComboBox1.BackColor = Color.White
        ComboBox1.SelectedIndex = 1
        TB_Password.BackColor = Color.White
        TB_Password.Focus()
        btnLogin.BackColor = Color.FromArgb(253, 253, 191)
        btnLogin.Enabled = True
        Me.BackColor = Color.FromArgb(252, 223, 222)
        btnOpenDataFile.BackColor = Color.FromArgb(252, 223, 222)
        btnOpenCCDFile.BackColor = Color.FromArgb(252, 223, 222)
    End Sub

    Private Sub RestoreLoginDialog()
        btnLogin.Enabled = False
        TB_Password.BackColor = colUnselectedBtn
        btnLogin.BackColor = colUnselectedBtn
        ComboBox1.BackColor = colUnselectedBtn
        ComboBox1.SelectedIndex = 1
    End Sub

    Private Function IsNotShow(frmName As String)
        If Application.OpenForms.Item(frmName) Is Nothing Then
            IsNotShow = True
        Else
            IsNotShow = False
        End If
        strActiveFrmNme = frmName
        Timer_UIControl.Enabled = True
    End Function

    ''' <summary>
    ''' 上一步中使用的定时器
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer_UIControl_Tick(sender As Object, e As EventArgs) Handles Timer_UIControl.Tick
        For Each Fr As Form In Application.OpenForms
            If Fr.Name <> strActiveFrmNme And Fr.Name <> "frmMain" And Fr.Name <> "frmLogin" And Fr.Name <> "frmUI" Then
                Fr.Close()
                Fr.Dispose()
                Timer_UIControl.Enabled = False
                Exit For
            End If
        Next
    End Sub 
#End Region

#Region "窗体上Exit按钮"
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("确定要退出控制软件吗？", vbOKCancel) <> vbOK Then  '判断是否确认退出主窗体
            Exit Sub
        End If
        CloseAllForm()
    End Sub

    Public Sub CloseAllForm()
        If Application.OpenForms.Item("frmAlarmHistory") IsNot Nothing Then
            frmAlarmHistory.Close()
            frmAlarmHistory.Dispose()
        End If
        If Application.OpenForms.Item("frmEngineering") IsNot Nothing Then
            frmEngineering.Close()
            frmEngineering.Dispose()
        End If
        If Application.OpenForms.Item("frmMachineInfo") IsNot Nothing Then
            frmMachineInfo.Close()
            frmMachineInfo.Dispose()
        End If
        If Application.OpenForms.Item("frmPar") IsNot Nothing Then
            frmPar.Close()
            frmPar.Dispose()
        End If
        If Application.OpenForms.Item("frmParCCD") IsNot Nothing Then
            frmParCCD.Close()
            frmParCCD.Dispose()
        End If
        If Application.OpenForms.Item("frmProduction") IsNot Nothing Then
            frmProduction.Close()
            frmProduction.Dispose()
        End If
        If Application.OpenForms.Item("frmRunInfo") IsNot Nothing Then
            frmRunInfo.Close()
            frmRunInfo.Dispose()
        End If
        If Application.OpenForms.Item("frmUI") IsNot Nothing Then
            frmUI.Close()
            frmUI.Dispose()
        End If
        If Application.OpenForms.Item("frmLogin") IsNot Nothing Then
            frmLogin.Close()
            frmLogin.Dispose()
        End If
        If Application.OpenForms.Item("frmMain") IsNot Nothing Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub
#End Region

#Region "窗体上打开文件和图片按钮响应事件"
    Private Sub Btn_OpenCCDFile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpenCCDFile.MouseDown
        btnOpenCCDFile.BackColor = colSelectedBtn
        Shell("explorer " & strFilePath(0), vbNormalFocus)
    End Sub

    Private Sub Btn_OpenCCDFile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenCCDFile.MouseUp
        btnOpenCCDFile.BackColor = Color.White
    End Sub

    Private Sub Btn_OpenDataFile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpenDataFile.MouseDown
        btnOpenDataFile.BackColor = colSelectedBtn
        Shell("explorer " & strFilePath(0), vbNormalFocus)
    End Sub

    Private Sub Btn_OpenDataFile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenDataFile.MouseUp
        btnOpenDataFile.BackColor = Color.White
    End Sub
#End Region

#Region "Main窗体上Start按钮"
    Private Sub Btn_Start_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStart.MouseDown
        'Write_Debug_log("#####设备生产界面运行按钮触发")
        'If Is_E_StopTrigger() Then  '设备紧急停止信号触发

        'End If
        'Set_Y_bit(0, 0, 11, 0)

        'bIsFromMainStart = True
        'If Home_OK Then
        '    On_StartAutoRun()
        'Else
        '    Me.Timer_Home.Enabled = True
        '    HomeStep = 10
        'End If
    End Sub
#End Region

#Region "Main窗体上Pause按钮"
    Private Sub Btn_Pause_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPause.MouseDown
        'If bAutoRunFlag Then
        '    If bSystemIsPause And Feeder_Alarm_Flag1 = False Then
        '        Call PauseEnd()
        '    Else
        '        'If MsgBox("确定要暂停设备运行吗？", vbOKCancel) <> vbOK Then  '判断是否确认退出主窗体
        '        '    Exit Sub
        '        'End If
        '        If St2SubStep > 150 And St2SubStep < 560 Then
        '            Frm_UI.List_Sts.Items.Add("当前机械手位置不允许设备暂停!")
        '            Frm_UI.List_Sts.Items.Add("如有需要请按下急停按钮!")
        '        Else
        '            Call PauseStart()
        '        End If
        '        'Call PauseStart()
        '        If Par.Par_ChkBox(18) = 1 And Feeder_Alarm_Flag1 And bAutoRunFlag Then
        '            MsgBox("Feeder被拔出或未上料成功，请检查！")
        '        End If
        '    End If
        'End If
    End Sub
#End Region

#Region "Main窗体上Stop按钮"
    Private Sub Btn_Stop_MouseDown(sender As Object, e As EventArgs) Handles btnStop.MouseDown
        'If bAutoRunFlag Then
        '    Write_Debug_log("#####设备停止按钮触发")
        '    Me.Btn_Stop.BackColor = colSelectedEndBtn
        'End If
    End Sub
    Private Sub Btn_Stop_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStop.MouseUp
        'If bSt2SubIsFinish = False Then
        '    Frm_UI.List_Sts.Items.Add("请等待二工位工作完成！！！")
        '    Exit Sub
        'End If

        'If bAutoRunFlag Then
        '    If St1Step <> 50 Or St2Step <> 50 Or St3Step <> 50 Or St6Step <> 50 Then
        '        Frm_UI.List_Sts.Items.Add("流水线有产品工序未完成，请在所有产品完全流出后停止！")
        '        Exit Sub
        '    End If
        '    If MsgBox("确定要停止设备运行吗？", vbOKCancel) <> vbOK Then  '判断是否确认退出主窗体
        '        Me.Btn_Stop.BackColor = colUnselectedBtn
        '        Exit Sub
        '    End If
        '    If bSystemIsPause Then
        '        Call PauseEnd()
        '    End If
        '    If bDemoFlag And bAutoRunFlag Then
        '        Write_Debug_log("#####设备空跑模式中断，当前共计空跑循环" & lNullRunTimes & "次！#######################")
        '        IniWriteValue(FilePath(19), "BIMTotalData", "Demonstration", Val(Frm_Engineering.TxtB_LifeNum.Text))
        '    End If
        '    Call On_Error()
        '    Me.Btn_Stop.BackColor = colUnselectedBtn
        'End If
    End Sub
#End Region

#Region "Main窗体上ProductionMode按钮"
    Private Sub btnProductionMode_Click(sender As Object, e As EventArgs) Handles btnProductionMode.Click
        If IsNotShow("frmProduction") Then frmProduction.Show(Me)
        Me.btnProduction.BackColor = colSelectedBtn
        Me.btnHome.BackColor = colUnselectedBtn
    End Sub
#End Region

#Region "Main窗体上EngneeringMode按钮"
    Private Sub Btn_EngneeringMode_Click(sender As Object, e As EventArgs) Handles btnEngneeringMode.Click 
        InitLoginDialog() 
        Me.btnEngneeringMode.BackColor = colMainSelectedBtn
        Me.btnCPKMode.BackColor = Color.LightGray
        strOpenTargetForm = "frmEngineering"
        If IsNotShow("frmEngineering") Then
        End If
    End Sub
#End Region

#Region "Main窗体上EngneeringCPKMode按钮"
    Private Sub Btn_CPKMode_Click(sender As Object, e As EventArgs) Handles btnCPKMode.Click 
        InitLoginDialog()
        Me.btnCPKMode.BackColor = colMainSelectedBtn
        Me.btnEngneeringMode.BackColor = Color.LightGray
        strOpenTargetForm = "frmEngineering"
        If IsNotShow("frmEngineering") Then
        End If
    End Sub
#End Region

#End Region
 
#Region "Main窗体上Login按钮"
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strInputPassword As String = Trim(Me.TB_Password.Text)
        If ComboBox1.SelectedItem = sLogin.Users(0) And (strInputPassword = sLogin.PassWord(0) Or strInputPassword = sLogin.PassWord(1) Or strInputPassword = sLogin.PassWord(2)) Then
            frmEngineering.Show(Me)
            RestoreLoginDialog()
            Me.BackColor = Color.White
            btnOpenDataFile.BackColor = Color.White
            btnOpenCCDFile.BackColor = Color.White
        ElseIf ComboBox1.SelectedItem = sLogin.Users(1) And (strInputPassword = sLogin.PassWord(1) Or strInputPassword = sLogin.PassWord(2)) Then
            frmEngineering.Show(Me)
            RestoreLoginDialog()
            Me.BackColor = Color.White
            btnOpenDataFile.BackColor = Color.White
            btnOpenCCDFile.BackColor = Color.White
        ElseIf ComboBox1.SelectedItem = sLogin.Users(2) And strInputPassword = sLogin.PassWord(2) Then
            frmEngineering.Show(Me)
            RestoreLoginDialog()
            Me.BackColor = Color.White
            btnOpenDataFile.BackColor = Color.White
            btnOpenCCDFile.BackColor = Color.White
        Else
            MsgBox("密码不正确，请重新输入正确的原密码！", MsgBoxStyle.OkOnly)
            Me.TB_Password.Text = ""
        End If
    End Sub
#End Region

#Region "验证"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
    End Sub
#End Region
  
End Class
