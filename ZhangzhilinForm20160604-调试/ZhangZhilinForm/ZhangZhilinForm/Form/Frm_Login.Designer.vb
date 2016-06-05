<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ckbPasswordChanges = New System.Windows.Forms.CheckBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblNPassword1 = New System.Windows.Forms.Label()
        Me.lblNPassword2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtNPassword1 = New System.Windows.Forms.TextBox()
        Me.txtNPassword2 = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(465, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(160, 167)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(89, 32)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(331, 167)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 32)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ckbPasswordChanges
        '
        Me.ckbPasswordChanges.AutoSize = True
        Me.ckbPasswordChanges.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPasswordChanges.Location = New System.Drawing.Point(446, 173)
        Me.ckbPasswordChanges.Name = "ckbPasswordChanges"
        Me.ckbPasswordChanges.Size = New System.Drawing.Size(142, 20)
        Me.ckbPasswordChanges.TabIndex = 9
        Me.ckbPasswordChanges.Text = "Password Changes"
        Me.ckbPasswordChanges.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Location = New System.Drawing.Point(160, 350)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(89, 32)
        Me.btnChange.TabIndex = 12
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblNPassword1
        '
        Me.lblNPassword1.AutoSize = True
        Me.lblNPassword1.Enabled = False
        Me.lblNPassword1.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPassword1.Location = New System.Drawing.Point(33, 255)
        Me.lblNPassword1.Name = "lblNPassword1"
        Me.lblNPassword1.Size = New System.Drawing.Size(111, 16)
        Me.lblNPassword1.TabIndex = 13
        Me.lblNPassword1.Text = "New Password 1"
        '
        'lblNPassword2
        '
        Me.lblNPassword2.AutoSize = True
        Me.lblNPassword2.Enabled = False
        Me.lblNPassword2.Font = New System.Drawing.Font("Cambria", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPassword2.Location = New System.Drawing.Point(33, 310)
        Me.lblNPassword2.Name = "lblNPassword2"
        Me.lblNPassword2.Size = New System.Drawing.Size(111, 16)
        Me.lblNPassword2.TabIndex = 14
        Me.lblNPassword2.Text = "New Password 2"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(160, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 33)
        Me.ComboBox1.TabIndex = 16
        '
        'txtNPassword1
        '
        Me.txtNPassword1.Enabled = False
        Me.txtNPassword1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPassword1.Location = New System.Drawing.Point(160, 245)
        Me.txtNPassword1.Name = "txtNPassword1"
        Me.txtNPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNPassword1.Size = New System.Drawing.Size(260, 32)
        Me.txtNPassword1.TabIndex = 17
        Me.txtNPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNPassword2
        '
        Me.txtNPassword2.Enabled = False
        Me.txtNPassword2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPassword2.Location = New System.Drawing.Point(160, 300)
        Me.txtNPassword2.Name = "txtNPassword2"
        Me.txtNPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNPassword2.Size = New System.Drawing.Size(260, 32)
        Me.txtNPassword2.TabIndex = 18
        Me.txtNPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(160, 107)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(260, 32)
        Me.txtPassword.TabIndex = 19
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 408)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNPassword2)
        Me.Controls.Add(Me.txtNPassword1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblNPassword2)
        Me.Controls.Add(Me.lblNPassword1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.ckbPasswordChanges)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ckbPasswordChanges As System.Windows.Forms.CheckBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents lblNPassword1 As System.Windows.Forms.Label
    Friend WithEvents lblNPassword2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtNPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class
