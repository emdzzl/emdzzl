<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer_UIControl = New System.Windows.Forms.Timer(Me.components)
        Me.RoundPanel2 = New BZ.UI.RoundPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCPKMode = New BZ.UI.RoundButton()
        Me.Winsock_HB = New AxMSWinsockLib.AxWinsock()
        Me.Winsock_CCD_S3 = New AxMSWinsockLib.AxWinsock()
        Me.Winsock_CCD_S2 = New AxMSWinsockLib.AxWinsock()
        Me.Winsock_PDCA = New AxMSWinsockLib.AxWinsock()
        Me.Winsock_BBS2 = New AxMSWinsockLib.AxWinsock()
        Me.Winsock_Rbt = New AxMSWinsockLib.AxWinsock()
        Me.btnEngneeringMode = New BZ.UI.RoundButton()
        Me.btnProductionMode = New BZ.UI.RoundButton()
        Me.RoundPanel3 = New BZ.UI.RoundPanel()
        Me.RoundPanel1 = New BZ.UI.RoundPanel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New BZ.UI.RoundButton()
        Me.btnOpenCCDFile = New BZ.UI.RoundButton()
        Me.btnOpenDataFile = New BZ.UI.RoundButton()
        Me.btnStop = New BZ.UI.RoundButton()
        Me.btnPause = New BZ.UI.RoundButton()
        Me.btnMachineInfo = New BZ.UI.RoundButton()
        Me.btnParSetting = New BZ.UI.RoundButton()
        Me.btnRunInfo = New BZ.UI.RoundButton()
        Me.btnAlarmHistory = New BZ.UI.RoundButton()
        Me.btnCCDSetting = New BZ.UI.RoundButton()
        Me.btnProduction = New BZ.UI.RoundButton()
        Me.btnStart = New BZ.UI.RoundButton()
        Me.Timer_Always = New System.Windows.Forms.Timer(Me.components)
        Me.RoundPanel2.SuspendLayout()
        CType(Me.Winsock_HB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winsock_CCD_S3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winsock_CCD_S2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winsock_PDCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winsock_BBS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winsock_Rbt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer_UIControl
        '
        '
        'RoundPanel2
        '
        Me.RoundPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoundPanel2.BZ_AutoBkColor = True
        Me.RoundPanel2.BZ_Radius = CType(6, Byte)
        Me.RoundPanel2.BZ_Version = "V1.0.0"
        Me.RoundPanel2.Controls.Add(Me.Button2)
        Me.RoundPanel2.Controls.Add(Me.Button1)
        Me.RoundPanel2.Controls.Add(Me.btnCPKMode)
        Me.RoundPanel2.Controls.Add(Me.Winsock_HB)
        Me.RoundPanel2.Controls.Add(Me.Winsock_CCD_S3)
        Me.RoundPanel2.Controls.Add(Me.Winsock_CCD_S2)
        Me.RoundPanel2.Controls.Add(Me.Winsock_PDCA)
        Me.RoundPanel2.Controls.Add(Me.Winsock_BBS2)
        Me.RoundPanel2.Controls.Add(Me.Winsock_Rbt)
        Me.RoundPanel2.Controls.Add(Me.btnEngneeringMode)
        Me.RoundPanel2.Controls.Add(Me.btnProductionMode)
        Me.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel2.Location = New System.Drawing.Point(5, 70)
        Me.RoundPanel2.Name = "RoundPanel2"
        Me.RoundPanel2.Size = New System.Drawing.Size(680, 653)
        Me.RoundPanel2.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(530, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 52)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(522, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 51)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCPKMode
        '
        Me.btnCPKMode.BackColor = System.Drawing.Color.LightGray
        Me.btnCPKMode.BZ_Radius = CType(6, Byte)
        Me.btnCPKMode.BZ_Version = "V1.0.0"
        Me.btnCPKMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPKMode.ForeColor = System.Drawing.Color.Black
        Me.btnCPKMode.Location = New System.Drawing.Point(130, 283)
        Me.btnCPKMode.Name = "btnCPKMode"
        Me.btnCPKMode.Size = New System.Drawing.Size(355, 71)
        Me.btnCPKMode.TabIndex = 18
        Me.btnCPKMode.Text = "CPK Mode"
        Me.btnCPKMode.UseVisualStyleBackColor = False
        '
        'Winsock_HB
        '
        Me.Winsock_HB.Enabled = True
        Me.Winsock_HB.Location = New System.Drawing.Point(51, 346)
        Me.Winsock_HB.Name = "Winsock_HB"
        Me.Winsock_HB.OcxState = CType(resources.GetObject("Winsock_HB.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_HB.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_HB.TabIndex = 17
        '
        'Winsock_CCD_S3
        '
        Me.Winsock_CCD_S3.Enabled = True
        Me.Winsock_CCD_S3.Location = New System.Drawing.Point(51, 307)
        Me.Winsock_CCD_S3.Name = "Winsock_CCD_S3"
        Me.Winsock_CCD_S3.OcxState = CType(resources.GetObject("Winsock_CCD_S3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_CCD_S3.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_CCD_S3.TabIndex = 16
        '
        'Winsock_CCD_S2
        '
        Me.Winsock_CCD_S2.Enabled = True
        Me.Winsock_CCD_S2.Location = New System.Drawing.Point(51, 273)
        Me.Winsock_CCD_S2.Name = "Winsock_CCD_S2"
        Me.Winsock_CCD_S2.OcxState = CType(resources.GetObject("Winsock_CCD_S2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_CCD_S2.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_CCD_S2.TabIndex = 15
        '
        'Winsock_PDCA
        '
        Me.Winsock_PDCA.Enabled = True
        Me.Winsock_PDCA.Location = New System.Drawing.Point(17, 346)
        Me.Winsock_PDCA.Name = "Winsock_PDCA"
        Me.Winsock_PDCA.OcxState = CType(resources.GetObject("Winsock_PDCA.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_PDCA.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_PDCA.TabIndex = 14
        '
        'Winsock_BBS2
        '
        Me.Winsock_BBS2.Enabled = True
        Me.Winsock_BBS2.Location = New System.Drawing.Point(17, 307)
        Me.Winsock_BBS2.Name = "Winsock_BBS2"
        Me.Winsock_BBS2.OcxState = CType(resources.GetObject("Winsock_BBS2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_BBS2.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_BBS2.TabIndex = 13
        '
        'Winsock_Rbt
        '
        Me.Winsock_Rbt.Enabled = True
        Me.Winsock_Rbt.Location = New System.Drawing.Point(17, 272)
        Me.Winsock_Rbt.Name = "Winsock_Rbt"
        Me.Winsock_Rbt.OcxState = CType(resources.GetObject("Winsock_Rbt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock_Rbt.Size = New System.Drawing.Size(28, 28)
        Me.Winsock_Rbt.TabIndex = 12
        '
        'btnEngneeringMode
        '
        Me.btnEngneeringMode.BackColor = System.Drawing.Color.LightGray
        Me.btnEngneeringMode.BZ_Radius = CType(6, Byte)
        Me.btnEngneeringMode.BZ_Version = "V1.0.0"
        Me.btnEngneeringMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEngneeringMode.ForeColor = System.Drawing.Color.Black
        Me.btnEngneeringMode.Location = New System.Drawing.Point(130, 169)
        Me.btnEngneeringMode.Name = "btnEngneeringMode"
        Me.btnEngneeringMode.Size = New System.Drawing.Size(355, 71)
        Me.btnEngneeringMode.TabIndex = 6
        Me.btnEngneeringMode.Text = "Engineering Mode"
        Me.btnEngneeringMode.UseVisualStyleBackColor = False
        '
        'btnProductionMode
        '
        Me.btnProductionMode.BackColor = System.Drawing.Color.LightGray
        Me.btnProductionMode.BZ_Radius = CType(6, Byte)
        Me.btnProductionMode.BZ_Version = "V1.0.0"
        Me.btnProductionMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductionMode.ForeColor = System.Drawing.Color.Black
        Me.btnProductionMode.Location = New System.Drawing.Point(130, 61)
        Me.btnProductionMode.Name = "btnProductionMode"
        Me.btnProductionMode.Size = New System.Drawing.Size(355, 71)
        Me.btnProductionMode.TabIndex = 5
        Me.btnProductionMode.Text = "Production Mode"
        Me.btnProductionMode.UseVisualStyleBackColor = False
        '
        'RoundPanel3
        '
        Me.RoundPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoundPanel3.BZ_AutoBkColor = True
        Me.RoundPanel3.BZ_Radius = CType(6, Byte)
        Me.RoundPanel3.BZ_Version = "V1.0.0"
        Me.RoundPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel3.Location = New System.Drawing.Point(690, 462)
        Me.RoundPanel3.Name = "RoundPanel3"
        Me.RoundPanel3.Size = New System.Drawing.Size(328, 261)
        Me.RoundPanel3.TabIndex = 29
        '
        'RoundPanel1
        '
        Me.RoundPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoundPanel1.BZ_AutoBkColor = True
        Me.RoundPanel1.BZ_Radius = CType(6, Byte)
        Me.RoundPanel1.BZ_Version = "V1.0.0"
        Me.RoundPanel1.Controls.Add(Me.btnLogin)
        Me.RoundPanel1.Controls.Add(Me.btnExit)
        Me.RoundPanel1.Controls.Add(Me.TB_Password)
        Me.RoundPanel1.Controls.Add(Me.ComboBox1)
        Me.RoundPanel1.Controls.Add(Me.Label2)
        Me.RoundPanel1.Controls.Add(Me.Label1)
        Me.RoundPanel1.Controls.Add(Me.PictureBox2)
        Me.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel1.Location = New System.Drawing.Point(690, 70)
        Me.RoundPanel1.Name = "RoundPanel1"
        Me.RoundPanel1.Size = New System.Drawing.Size(328, 387)
        Me.RoundPanel1.TabIndex = 28
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLogin.Enabled = False
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(26, 303)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 32)
        Me.btnLogin.TabIndex = 24
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(166, 303)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 32)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TB_Password
        '
        Me.TB_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TB_Password.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Password.Location = New System.Drawing.Point(26, 229)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_Password.Size = New System.Drawing.Size(240, 32)
        Me.TB_Password.TabIndex = 23
        Me.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 150)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 32)
        Me.ComboBox1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "User Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHome.BZ_Radius = CType(6, Byte)
        Me.btnHome.BZ_Version = "V1.0.0"
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(958, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(60, 60)
        Me.btnHome.TabIndex = 27
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnOpenCCDFile
        '
        Me.btnOpenCCDFile.BackColor = System.Drawing.Color.White
        Me.btnOpenCCDFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpenCCDFile.BZ_Radius = CType(6, Byte)
        Me.btnOpenCCDFile.BZ_Version = "V1.0.0"
        Me.btnOpenCCDFile.FlatAppearance.BorderSize = 0
        Me.btnOpenCCDFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenCCDFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenCCDFile.Image = CType(resources.GetObject("btnOpenCCDFile.Image"), System.Drawing.Image)
        Me.btnOpenCCDFile.Location = New System.Drawing.Point(893, 5)
        Me.btnOpenCCDFile.Name = "btnOpenCCDFile"
        Me.btnOpenCCDFile.Size = New System.Drawing.Size(60, 60)
        Me.btnOpenCCDFile.TabIndex = 25
        Me.btnOpenCCDFile.UseVisualStyleBackColor = False
        '
        'btnOpenDataFile
        '
        Me.btnOpenDataFile.BackColor = System.Drawing.Color.White
        Me.btnOpenDataFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpenDataFile.BZ_Radius = CType(6, Byte)
        Me.btnOpenDataFile.BZ_Version = "V1.0.0"
        Me.btnOpenDataFile.FlatAppearance.BorderSize = 0
        Me.btnOpenDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenDataFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenDataFile.Image = CType(resources.GetObject("btnOpenDataFile.Image"), System.Drawing.Image)
        Me.btnOpenDataFile.Location = New System.Drawing.Point(828, 5)
        Me.btnOpenDataFile.Name = "btnOpenDataFile"
        Me.btnOpenDataFile.Size = New System.Drawing.Size(60, 60)
        Me.btnOpenDataFile.TabIndex = 24
        Me.btnOpenDataFile.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStop.BZ_Radius = CType(6, Byte)
        Me.btnStop.BZ_Version = "V1.0.0"
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(625, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(60, 60)
        Me.btnStop.TabIndex = 19
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPause.BZ_Radius = CType(6, Byte)
        Me.btnPause.BZ_Version = "V1.0.0"
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.ForeColor = System.Drawing.Color.Black
        Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
        Me.btnPause.Location = New System.Drawing.Point(560, 5)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(60, 60)
        Me.btnPause.TabIndex = 18
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnMachineInfo
        '
        Me.btnMachineInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnMachineInfo.BZ_Radius = CType(6, Byte)
        Me.btnMachineInfo.BZ_Version = "V1.0.0"
        Me.btnMachineInfo.FlatAppearance.BorderSize = 0
        Me.btnMachineInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMachineInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMachineInfo.ForeColor = System.Drawing.Color.Black
        Me.btnMachineInfo.Location = New System.Drawing.Point(330, 5)
        Me.btnMachineInfo.Name = "btnMachineInfo"
        Me.btnMachineInfo.Size = New System.Drawing.Size(160, 60)
        Me.btnMachineInfo.TabIndex = 16
        Me.btnMachineInfo.UseVisualStyleBackColor = False
        '
        'btnParSetting
        '
        Me.btnParSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnParSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnParSetting.BZ_Radius = CType(6, Byte)
        Me.btnParSetting.BZ_Version = "V1.0.0"
        Me.btnParSetting.FlatAppearance.BorderSize = 0
        Me.btnParSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParSetting.ForeColor = System.Drawing.Color.Black
        Me.btnParSetting.Image = CType(resources.GetObject("btnParSetting.Image"), System.Drawing.Image)
        Me.btnParSetting.Location = New System.Drawing.Point(70, 5)
        Me.btnParSetting.Name = "btnParSetting"
        Me.btnParSetting.Size = New System.Drawing.Size(60, 60)
        Me.btnParSetting.TabIndex = 15
        Me.btnParSetting.UseVisualStyleBackColor = False
        '
        'btnRunInfo
        '
        Me.btnRunInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRunInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRunInfo.BZ_Radius = CType(6, Byte)
        Me.btnRunInfo.BZ_Version = "V1.0.0"
        Me.btnRunInfo.FlatAppearance.BorderSize = 0
        Me.btnRunInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRunInfo.ForeColor = System.Drawing.Color.Black
        Me.btnRunInfo.Image = CType(resources.GetObject("btnRunInfo.Image"), System.Drawing.Image)
        Me.btnRunInfo.Location = New System.Drawing.Point(200, 5)
        Me.btnRunInfo.Name = "btnRunInfo"
        Me.btnRunInfo.Size = New System.Drawing.Size(60, 60)
        Me.btnRunInfo.TabIndex = 14
        Me.btnRunInfo.UseVisualStyleBackColor = False
        '
        'btnAlarmHistory
        '
        Me.btnAlarmHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAlarmHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlarmHistory.BZ_Radius = CType(6, Byte)
        Me.btnAlarmHistory.BZ_Version = "V1.0.0"
        Me.btnAlarmHistory.FlatAppearance.BorderSize = 0
        Me.btnAlarmHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlarmHistory.ForeColor = System.Drawing.Color.Black
        Me.btnAlarmHistory.Image = CType(resources.GetObject("btnAlarmHistory.Image"), System.Drawing.Image)
        Me.btnAlarmHistory.Location = New System.Drawing.Point(265, 5)
        Me.btnAlarmHistory.Name = "btnAlarmHistory"
        Me.btnAlarmHistory.Size = New System.Drawing.Size(60, 60)
        Me.btnAlarmHistory.TabIndex = 13
        Me.btnAlarmHistory.UseVisualStyleBackColor = False
        '
        'btnCCDSetting
        '
        Me.btnCCDSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCCDSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCCDSetting.BZ_Radius = CType(6, Byte)
        Me.btnCCDSetting.BZ_Version = "V1.0.0"
        Me.btnCCDSetting.FlatAppearance.BorderSize = 0
        Me.btnCCDSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCCDSetting.ForeColor = System.Drawing.Color.Black
        Me.btnCCDSetting.Image = CType(resources.GetObject("btnCCDSetting.Image"), System.Drawing.Image)
        Me.btnCCDSetting.Location = New System.Drawing.Point(135, 5)
        Me.btnCCDSetting.Name = "btnCCDSetting"
        Me.btnCCDSetting.Size = New System.Drawing.Size(60, 60)
        Me.btnCCDSetting.TabIndex = 12
        Me.btnCCDSetting.UseVisualStyleBackColor = False
        '
        'btnProduction
        '
        Me.btnProduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProduction.BZ_Radius = CType(6, Byte)
        Me.btnProduction.BZ_Version = "V1.0.0"
        Me.btnProduction.FlatAppearance.BorderSize = 0
        Me.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduction.ForeColor = System.Drawing.Color.Black
        Me.btnProduction.Image = CType(resources.GetObject("btnProduction.Image"), System.Drawing.Image)
        Me.btnProduction.Location = New System.Drawing.Point(5, 5)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(60, 60)
        Me.btnProduction.TabIndex = 10
        Me.btnProduction.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStart.BZ_Radius = CType(6, Byte)
        Me.btnStart.BZ_Version = "V1.0.0"
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(495, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(60, 60)
        Me.btnStart.TabIndex = 18
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 730)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.RoundPanel2)
        Me.Controls.Add(Me.RoundPanel3)
        Me.Controls.Add(Me.RoundPanel1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOpenCCDFile)
        Me.Controls.Add(Me.btnOpenDataFile)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnMachineInfo)
        Me.Controls.Add(Me.btnParSetting)
        Me.Controls.Add(Me.btnRunInfo)
        Me.Controls.Add(Me.btnAlarmHistory)
        Me.Controls.Add(Me.btnCCDSetting)
        Me.Controls.Add(Me.btnProduction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.RoundPanel2.ResumeLayout(False)
        CType(Me.Winsock_HB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winsock_CCD_S3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winsock_CCD_S2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winsock_PDCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winsock_BBS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winsock_Rbt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel1.ResumeLayout(False)
        Me.RoundPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStop As BZ.UI.RoundButton
    Friend WithEvents btnPause As BZ.UI.RoundButton
    Friend WithEvents btnMachineInfo As BZ.UI.RoundButton
    Friend WithEvents btnParSetting As BZ.UI.RoundButton
    Friend WithEvents btnRunInfo As BZ.UI.RoundButton
    Friend WithEvents btnAlarmHistory As BZ.UI.RoundButton
    Friend WithEvents btnCCDSetting As BZ.UI.RoundButton
    Friend WithEvents btnProduction As BZ.UI.RoundButton
    Friend WithEvents Timer_UIControl As System.Windows.Forms.Timer
    Friend WithEvents btnOpenCCDFile As BZ.UI.RoundButton
    Friend WithEvents btnOpenDataFile As BZ.UI.RoundButton
    Friend WithEvents btnHome As BZ.UI.RoundButton
    Friend WithEvents RoundPanel2 As BZ.UI.RoundPanel
    Friend WithEvents btnEngneeringMode As BZ.UI.RoundButton
    Friend WithEvents btnProductionMode As BZ.UI.RoundButton
    Friend WithEvents RoundPanel3 As BZ.UI.RoundPanel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents RoundPanel1 As BZ.UI.RoundPanel
    Friend WithEvents TB_Password As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Winsock_PDCA As AxMSWinsockLib.AxWinsock
    Friend WithEvents Winsock_BBS2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents Winsock_Rbt As AxMSWinsockLib.AxWinsock
    Friend WithEvents Winsock_CCD_S3 As AxMSWinsockLib.AxWinsock
    Friend WithEvents Winsock_CCD_S2 As AxMSWinsockLib.AxWinsock
    Friend WithEvents btnStart As BZ.UI.RoundButton
    Friend WithEvents Winsock_HB As AxMSWinsockLib.AxWinsock
    Friend WithEvents btnCPKMode As BZ.UI.RoundButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer_Always As System.Windows.Forms.Timer

End Class
