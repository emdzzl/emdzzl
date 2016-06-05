Public Class frmLogin
#Region "功能：窗体加载" 
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = New Point(ChildFrmOffsetPoint.X + 200, ChildFrmOffsetPoint.Y + 100)
            .Size = New Size(600, 235)
            .TopMost = True
            .Opacity = 0.85
        End With
        '用于读取更新用户名和密码
        RereshParaLogin(Me.ComboBox1)
        '默认用户名为工程师用户
        Me.ComboBox1.SelectedIndex = 1
        bIsLoginFromOpen = True
    End Sub
#End Region

#Region "窗体关闭"
    Private Sub Frm_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        bIsLoginFromOpen = False
    End Sub
#End Region

#Region "修改密码允许checkbox事件"
    Private Sub ckbPasswordChanges_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPasswordChanges.CheckedChanged
        If ckbPasswordChanges.Checked Then
            Me.lblNPassword1.Enabled = True
            Me.lblNPassword2.Enabled = True
            Me.txtNPassword1.Enabled = True
            Me.txtNPassword2.Enabled = True
            Me.btnChange.Enabled = True

            Me.Size = New Size(600, 408)
            Me.Opacity = 0.85
            Me.ResizeRedraw = True
        Else
            Me.lblNPassword1.Enabled = False
            Me.lblNPassword2.Enabled = False
            Me.txtNPassword1.Enabled = False
            Me.txtNPassword2.Enabled = False
            Me.btnChange.Enabled = False
            Me.Size = New Size(600, 235)
            Me.Opacity = 0.85
            Me.ResizeRedraw = True
        End If
    End Sub
#End Region

#Region "密码修改函数---Btn_Change_MouseDown"
    Private Sub btnChange_MouseDown(sender As Object, e As EventArgs) Handles btnChange.MouseDown
        Dim sInputPassword, sNowPassword As String

        Me.btnChange.Enabled = False
        If Trim(Me.txtNPassword1.Text) <> Trim(Me.txtNPassword2.Text) Then
            MsgBox("两次输入的密码不同，请重新输入！", MsgBoxStyle.OkOnly)
            Me.txtNPassword1.Text = ""
            Me.txtNPassword2.Text = ""
            Exit Sub
        End If

        sInputPassword = Trim(Me.txtNPassword1.Text)
        Select Case Me.ComboBox1.SelectedItem.ToString
            Case sLogin.Users(0).ToString                             '"ManualOperation_ID" 
                sNowPassword = sLogin.PassWord(0)
                sLogin.PassWord(0) = sInputPassword
            Case sLogin.Users(1).ToString                             '"EngineeringMode_ID"
                sNowPassword = sLogin.PassWord(1)
                sLogin.PassWord(1) = sInputPassword
            Case sLogin.Users(2).ToString                             '"Administrator_ID"
                sNowPassword = sLogin.PassWord(2)
                sLogin.PassWord(2) = sInputPassword
            Case Else
                sNowPassword = Nothing
        End Select

        If Trim(Me.txtPassword.Text) = sNowPassword And (sNowPassword IsNot Nothing) Then
            '用于保存密码
            If WriteParaLogin(sLogin) Then
                MessageBox.Show("The PassWord is Saved Succeed")
            Else
                MessageBox.Show("The PassWord is Saved Fail")
            End If
            '重新读取更新后的密码
            Call RereshParaLogin(Me.ComboBox1)

            Me.txtPassword.Text = ""
            Me.txtNPassword1.Text = ""
            Me.txtNPassword2.Text = ""
        Else
            '用于读取更新用户名和密码
            Call RereshParaLogin(Me.ComboBox1)
            MsgBox("原密码不正确，请重新输入正确的原密码！", MsgBoxStyle.OkOnly)
            Me.txtPassword.Text = ""
            Exit Sub
        End If

        ckbPasswordChanges.Checked = False
    End Sub
#End Region

#Region "密码对比登录函数---Btn_Login_MouseDown"
    Private Sub Btn_Login_MouseDown(sender As Object, e As EventArgs) Handles btnLogin.MouseDown
        Dim sInputPassword As String
        sInputPassword = Trim(Me.txtPassword.Text)
        Select Case strOpenTargetForm
            Case "frmPar"
                If (ComboBox1.SelectedItem <> sLogin.Users(1)) And (ComboBox1.SelectedItem <> sLogin.Users(2)) Then
                    MsgBox("只可以使用" & sLogin.Users(1) & "或者" & sLogin.Users(2) & "用户名登录此界面，请重新修正用户名！", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                If (ComboBox1.SelectedItem = sLogin.Users(1) And (sInputPassword = sLogin.PassWord(1) Or sInputPassword = sLogin.PassWord(2))) Or _
                   (ComboBox1.SelectedItem = sLogin.Users(2) And sInputPassword = sLogin.PassWord(2)) Then
                    If Not bIsEnableParModify Then
                        bIsEnableParModify = True
                        'frmPar解锁需要的动作
                        frmPar.Timer.Enabled = True
                    End If
                Else
                    MsgBox("密码不正确，请重新输入正确的原密码！", MsgBoxStyle.OkOnly)
                    Me.txtPassword.Text = ""
                    Exit Sub
                End If
            Case "Frm_Engineering"
                If (ComboBox1.SelectedItem <> sLogin.Users(1)) And (ComboBox1.SelectedItem <> sLogin.Users(2)) Then
                    MsgBox("只可以使用" & sLogin.Users(1) & "或者" & sLogin.Users(2) & "用户名登录此界面，请重新修正用户名！", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                If (ComboBox1.SelectedItem = sLogin.Users(1) And (sInputPassword = sLogin.PassWord(1) Or sInputPassword = sLogin.PassWord(2))) Or _
                   (ComboBox1.SelectedItem = sLogin.Users(2) And sInputPassword = sLogin.PassWord(2)) Then
                    If Not bIsEnableParModify Then
                        bIsEnableParModify = True
                        'frmPar解锁需要的动作
                        'Call EnableManualOption()
                    End If
                Else
                    MsgBox("密码不正确，请重新输入正确的原密码！", MsgBoxStyle.OkOnly)
                    Me.txtPassword.Text = ""
                    Exit Sub
                End If
            Case "Frm_Engineering_Manual"
                If (ComboBox1.SelectedItem <> sLogin.Users(1)) And (ComboBox1.SelectedItem <> sLogin.Users(2)) Then
                    MsgBox("只可以使用" & sLogin.Users(1) & "或者" & sLogin.Users(2) & "用户名登录此界面，请重新修正用户名！", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                If (ComboBox1.SelectedItem = sLogin.Users(1) And (sInputPassword = sLogin.PassWord(1) Or sInputPassword = sLogin.PassWord(2))) Or _
                   (ComboBox1.SelectedItem = sLogin.Users(2) And sInputPassword = sLogin.PassWord(2)) Then
                    If Not bIsEnableParModify Then
                        bIsEnableParModify = True
                        'frmPar解锁需要的动作
                        'Call EnableManualOption()
                        'Home_OK = False
                        'bAutoRunFlag = False
                    End If
                Else
                    MsgBox("密码不正确，请重新输入正确的原密码！", MsgBoxStyle.OkOnly)
                    Me.txtPassword.Text = ""
                    Exit Sub
                End If 
            Case Else
                    Exit Sub
        End Select
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
     
#Region "登录取消函数---Btn_Cancel_MouseDown"
    Private Sub Btn_Cancel_MouseDown(sender As Object, e As EventArgs) Handles btnCancel.MouseDown
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
     
End Class