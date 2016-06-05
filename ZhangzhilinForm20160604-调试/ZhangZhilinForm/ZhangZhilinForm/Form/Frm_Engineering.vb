Imports BZ.UI
Imports System
Imports System.Math

Public Class frmEngineering

#Region "私有变量"
    'S2站回原点变量
    Private bolS2_X_Homeing, bolS2_Y_Homeing, bolS2_Z_Homeing As Boolean                      '单站回原点中标志
    Private intS2_X_HomeStartTime, intS2_Y_HomeStartTime, intS2_Z_HomeStartTime As Integer    '单站回原点开始时间
#End Region

#Region "窗体加载"
    Private Sub frmEngineering_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = ChildFrmOffsetPoint
            .Size = New Size(1020, 660)
            .BackColor = Color.White
        End With

        '控件赋初始值 
        cmbS2_X_Speed.SelectedIndex = 0         'S2单步速度选择选项中的第一项
        cmbS2_Y_Speed.SelectedIndex = 0
        cmbS2_Z_Speed.SelectedIndex = 0
        cmbS2_R_Speed.SelectedIndex = 0

        cmbS2_X_StemDis.SelectedIndex = 0       'S2单步距离选择选项中的第一项
        cmbS2_Y_StemDis.SelectedIndex = 0
        cmbS2_Z_StemDis.SelectedIndex = 0
        cmbS2_R_StemDis.SelectedIndex = 0
    End Sub
#End Region

#Region "解锁"
    ''' <summary>
    ''' 解锁1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Btn_Locked2_Click(sender As Object, e As EventArgs) Handles Btn_Locked2.Click
        If bIsLoginFromOpen Then Exit Sub
        frmLogin.Show(frmMain)
    End Sub

    ''' <summary>
    ''' 解锁2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Btn_Locked1_Click(sender As Object, e As EventArgs) Handles Btn_Locked1.Click
        If bIsLoginFromOpen Then Exit Sub
        frmLogin.Show(frmMain)
    End Sub
#End Region

#Region "手动调试界面-2站调试-控件事件"

    ''' <summary>
    '''开伺服
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnS2_X_ServoOn_Click(sender As Object, e As EventArgs) Handles btnS2_X_ServoOn.Click, _
                                  btnS2_Y_ServoOn.Click, btnS2_Z_ServoOn.Click, btnS2_R_ServoOn.Click
        Select Case sender.Tag
            Case 0
                If Card(S2_X).Get_ServoOn(Axis(S2_X)) = 1 Then
                    If Card(S2_X).Set_ServoOn(Axis(S2_X), 0) <> 0 Then MessageBox.Show("伺服打开失败")
                End If
            Case 1
                If Card(S2_Y).Get_ServoOn(Axis(S2_Y)) = 1 Then
                    If Card(S2_Y).Set_ServoOn(Axis(S2_Y), 0) <> 0 Then MessageBox.Show("伺服打开失败")
                End If
            Case 2
                If Card(S2_Z).Get_ServoOn(Axis(S2_Z)) = 1 Then
                    If Card(S2_Z).Set_ServoOn(Axis(S2_Z), 0) <> 0 Then MessageBox.Show("伺服打开失败")
                End If
        End Select
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    ''' <summary>
    ''' 关伺服
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnS2_X_ServoOff_Click(sender As Object, e As EventArgs) Handles btnS2_X_ServoOff.Click, _
                                 btnS2_Y_ServoOff.Click, btnS2_Z_ServoOff.Click, btnS2_R_ServoOff.Click

        Select Case sender.Tag
            Case 0
                If Card(S2_X).Get_ServoOn(Axis(S2_X)) = 0 Then
                    Card(S2_X).Set_ServoOn(Axis(S2_X), 1)
                End If
            Case 1
                If Card(S2_Y).Get_ServoOn(Axis(S2_Y)) = 0 Then
                    Card(S2_Y).Set_ServoOn(Axis(S2_Y), 1)
                End If
            Case 2
                If Card(S2_Z).Get_ServoOn(Axis(S2_Z)) = 0 Then
                    Card(S2_Z).Set_ServoOn(Axis(S2_Z), 1)
                End If
        End Select
    End Sub

    ''' <summary>
    ''' 回原点
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnS2_X_Home_Click(sender As Object, e As EventArgs) Handles btnS2_X_Home.Click, _
                                    btnS2_Y_Home.Click, btnS2_Z_Home.Click, btnS2_R_Home.Click

        '先确认设备是否在急停中
        If Is_E_StopTrigger() = True Then
            MessageBox.Show("设备急停中,请确认...")
            Exit Sub
        End If
        '根据按钮回零各轴
        Select Case sender.Tag
            Case 0
                If Not Card(S2_X).Get_ServoOn(Axis(S2_X)) = 0 Then
                    MessageBox.Show("S2_X轴伺服使能未打开,请先打开伺服使能")
                    Exit Sub
                    '屏蔽此处,是因为底层有检测重复回原点功能
                    'ElseIf Card(S2_X).AxisItemsAttribute.Item(Axis(S2_X).ToString).HomeRunnnig = True Then
                    '    MessageBox.Show("S2_X轴正在回原点中,请确认...")
                    '    Exit Sub
                End If
                '屏蔽此处,是因为底层开始回零时,会置位此标志,如果此处提前置位,底层就会认为此轴正在回原点中
                'Card(S2_X).AxisItemsAttribute.Item(Axis(S2_X).ToString).HomeRunnnig = True
                bolS2_X_Homeing = True
                intS2_X_HomeStartTime = GetTickCount()
                Card(S2_X).GoHome(Axis(S2_X), 0, 1)
                Timer_Home.Interval = 100
                Timer_Home.Enabled = True
            Case 1
                If Not Card(S2_Y).Get_ServoOn(Axis(S2_Y)) = 0 Then
                    MessageBox.Show("S2_Y轴伺服使能未打开,请先打开伺服使能")
                    Exit Sub
                    'ElseIf Card(S2_Y).AxisItemsAttribute.Item(Axis(S2_Y).ToString).HomeRunnnig = True Then
                    '    MessageBox.Show("S2_Y轴正在回原点中,请确认...")
                    '    Exit Sub
                End If
                'Card(S2_Y).AxisItemsAttribute.Item(Axis(S2_Y).ToString).HomeRunnnig = True
                bolS2_Y_Homeing = True
                intS2_Y_HomeStartTime = GetTickCount()
                Card(S2_Y).GoHome(Axis(S2_Y), 1, 1)
                Timer_Home.Interval = 100
                Timer_Home.Enabled = True
            Case 2
                If Not Card(S2_Z).Get_ServoOn(Axis(S2_Z)) = 0 Then
                    MessageBox.Show("S2_Z轴伺服使能未打开,请先打开伺服使能")
                    Exit Sub
                    'ElseIf Card(S2_Z).AxisItemsAttribute.Item(Axis(S2_X).ToString).HomeRunnnig = True Then
                    '    MessageBox.Show("S2_Z轴正在回原点中,请确认...")
                    '    Exit Sub
                End If
                'Card(S2_Z).AxisItemsAttribute.Item(Axis(S2_Z).ToString).HomeRunnnig = True
                bolS2_Z_Homeing = True
                intS2_Z_HomeStartTime = GetTickCount()
                Card(S2_Z).GoHome(Axis(S2_Z))
                Timer_Home.Interval = 100
                Timer_Home.Enabled = True
        End Select
    End Sub


#End Region

#Region "回原点定时器检测"
    ''' <summary>
    ''' 回原点定时器
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer_Home_Tick(sender As Object, e As EventArgs) Handles Timer_Home.Tick
        Timer_Home.Enabled = False

        'S2_X轴回原点检测
        If bolS2_X_Homeing Then
            If (Not Card(S2_X).AxisItemsAttribute.Item(Axis(S2_X).ToString).HomeRunnnig) And _
                    Card(S2_X).AxisItemsAttribute.Item(Axis(S2_X).ToString).HomeOK Then
                bolS2_X_Homeing = False                                    '回原点成功
                intS2_X_HomeStartTime = 0
                MessageBox.Show("S2_X轴回原点成功")
            ElseIf GetTickCount - intS2_X_HomeStartTime > 30000000 Then       '回零超时时间设置为30S
                bolS2_X_Homeing = False                                    '回原点失败
                intS2_X_HomeStartTime = 0
                MessageBox.Show("S2_X轴回原点失败")
            End If
        End If

        'S2_Y轴回原点检测
        If bolS2_Y_Homeing Then
            If (Not Card(S2_Y).AxisItemsAttribute.Item(Axis(S2_Y).ToString).HomeRunnnig) And _
                    Card(S2_Y).AxisItemsAttribute.Item(Axis(S2_Y).ToString).HomeOK Then
                bolS2_Y_Homeing = False                                    '回原点成功
                intS2_Y_HomeStartTime = 0
                MessageBox.Show("S2_Y轴回原点成功")
            ElseIf GetTickCount - intS2_Y_HomeStartTime > 30000 Then       '回零超时时间设置为30S
                bolS2_Y_Homeing = False                                    '回原点失败
                intS2_Y_HomeStartTime = 0
                MessageBox.Show("S2_Y轴回原点失败")
            End If
        End If

        'S2_Z轴回原点检测
        If bolS2_Z_Homeing Then
            If (Not Card(S2_Z).AxisItemsAttribute.Item(Axis(S2_Z).ToString).HomeRunnnig) And _
                    Card(S2_Z).AxisItemsAttribute.Item(Axis(S2_Z).ToString).HomeOK Then
                bolS2_Z_Homeing = False                                    '回原点成功
                intS2_Z_HomeStartTime = 0
                MessageBox.Show("S2_Z轴回原点成功")
            ElseIf GetTickCount - intS2_Z_HomeStartTime > 3000000 Then       '回零超时时间设置为30S
                bolS2_Z_Homeing = False                                    '回原点失败
                intS2_Z_HomeStartTime = 0
                MessageBox.Show("S2_Z轴回原点失败")
            End If
        End If

        '判断如果所有轴都未在回原点时,则此定时器关闭
        If bolS2_X_Homeing Or bolS2_Y_Homeing Or bolS2_Z_Homeing Then
            Timer_Home.Enabled = True
        Else
            Timer_Home.Enabled = False
        End If
    End Sub
#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clsMotCard0.Set_Y_bit(0, 12, 0, False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clsMotCard0.Set_Y_bit(0, 12, 1, False)
    End Sub
End Class
