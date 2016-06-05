<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduction
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduction))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.RL_AlarmStatus = New BZ.UI.RoundLabel()
        Me.RL_AlarmTime = New BZ.UI.RoundLabel()
        Me.RL_UPH = New BZ.UI.RoundLabel()
        Me.RL_MaterialLevel = New BZ.UI.RoundLabel()
        Me.RoundPanel1 = New BZ.UI.RoundPanel()
        Me.Chart_Column = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel2 = New BZ.UI.RoundPanel()
        Me.RoundLabel1 = New BZ.UI.RoundLabel()
        Me.Lbl_SN = New System.Windows.Forms.Label()
        Me.Btn_PressLine_VDown = New BZ.UI.RoundButton()
        Me.Btn_PressLine_VUp = New BZ.UI.RoundButton()
        Me.Btn_PressLine_HB = New BZ.UI.RoundButton()
        Me.Chart_Press = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel3 = New BZ.UI.RoundPanel()
        Me.RoundLabel5 = New BZ.UI.RoundLabel()
        Me.RoundLabel4 = New BZ.UI.RoundLabel()
        Me.RoundLabel3 = New BZ.UI.RoundLabel()
        Me.RoundLabel2 = New BZ.UI.RoundLabel()
        Me.Txt_S6ErrorMsg = New System.Windows.Forms.TextBox()
        Me.SRB_VBdown = New BZ.UI.SingleRoundBar()
        Me.SRB_VBup = New BZ.UI.SingleRoundBar()
        Me.SRB_HB = New BZ.UI.SingleRoundBar()
        Me.RoundPanel4 = New BZ.UI.RoundPanel()
        Me.Btn_Msg = New System.Windows.Forms.Button()
        Me.PB_Right2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_EndDate = New System.Windows.Forms.Label()
        Me.Lbl_StartDate = New System.Windows.Forms.Label()
        Me.Btn_Retest = New BZ.UI.RoundButton()
        Me.Btn_Yield = New BZ.UI.RoundButton()
        Me.DRB_YieldRetest = New BZ.UI.DoubleRoundBar()
        Me.Timer_Test = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_PressCurve = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Always = New System.Windows.Forms.Timer(Me.components)
        Me.RoundPanel5 = New BZ.UI.RoundPanel()
        Me.RoundLabel6 = New BZ.UI.RoundLabel()
        Me.ProductListBoxMsg = New System.Windows.Forms.ListBox()
        Me.Chart_VBDOWN = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_VBUP = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_HB = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel1.SuspendLayout()
        CType(Me.Chart_Column, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel2.SuspendLayout()
        CType(Me.Chart_Press, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel3.SuspendLayout()
        Me.RoundPanel4.SuspendLayout()
        CType(Me.PB_Right2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel5.SuspendLayout()
        CType(Me.Chart_VBDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_VBUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_HB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RL_AlarmStatus
        '
        Me.RL_AlarmStatus.BackColor = System.Drawing.Color.Magenta
        Me.RL_AlarmStatus.BZ_AutoBkColor = True
        Me.RL_AlarmStatus.BZ_BigText = "BigText"
        Me.RL_AlarmStatus.BZ_BigTextButtomOffset = 4
        Me.RL_AlarmStatus.BZ_BigTextColor = System.Drawing.Color.White
        Me.RL_AlarmStatus.BZ_BigTextFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_AlarmStatus.BZ_Radius = CType(6, Byte)
        Me.RL_AlarmStatus.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RL_AlarmStatus.BZ_SingleLine = True
        Me.RL_AlarmStatus.BZ_SmallText = "SmallText"
        Me.RL_AlarmStatus.BZ_SmallTextColor = System.Drawing.Color.White
        Me.RL_AlarmStatus.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RL_AlarmStatus.BZ_SmallTextTopOffset = 8
        Me.RL_AlarmStatus.BZ_Version = "V1.0.0"
        Me.RL_AlarmStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_AlarmStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RL_AlarmStatus.Location = New System.Drawing.Point(3, 2)
        Me.RL_AlarmStatus.Name = "RL_AlarmStatus"
        Me.RL_AlarmStatus.Size = New System.Drawing.Size(125, 60)
        Me.RL_AlarmStatus.TabIndex = 2
        Me.RL_AlarmStatus.Text = " ---"
        '
        'RL_AlarmTime
        '
        Me.RL_AlarmTime.BackColor = System.Drawing.Color.Magenta
        Me.RL_AlarmTime.BZ_AutoBkColor = True
        Me.RL_AlarmTime.BZ_BigText = "BigText"
        Me.RL_AlarmTime.BZ_BigTextButtomOffset = 4
        Me.RL_AlarmTime.BZ_BigTextColor = System.Drawing.Color.White
        Me.RL_AlarmTime.BZ_BigTextFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_AlarmTime.BZ_Radius = CType(6, Byte)
        Me.RL_AlarmTime.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RL_AlarmTime.BZ_SingleLine = False
        Me.RL_AlarmTime.BZ_SmallText = "SmallText"
        Me.RL_AlarmTime.BZ_SmallTextColor = System.Drawing.Color.White
        Me.RL_AlarmTime.BZ_SmallTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_AlarmTime.BZ_SmallTextTopOffset = 8
        Me.RL_AlarmTime.BZ_Version = "V1.0.0"
        Me.RL_AlarmTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_AlarmTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RL_AlarmTime.Location = New System.Drawing.Point(133, 2)
        Me.RL_AlarmTime.Name = "RL_AlarmTime"
        Me.RL_AlarmTime.Size = New System.Drawing.Size(125, 60)
        Me.RL_AlarmTime.TabIndex = 3
        Me.RL_AlarmTime.Text = "RoundLabel2"
        '
        'RL_UPH
        '
        Me.RL_UPH.BackColor = System.Drawing.Color.Magenta
        Me.RL_UPH.BZ_AutoBkColor = True
        Me.RL_UPH.BZ_BigText = "BigText"
        Me.RL_UPH.BZ_BigTextButtomOffset = 4
        Me.RL_UPH.BZ_BigTextColor = System.Drawing.Color.White
        Me.RL_UPH.BZ_BigTextFont = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_UPH.BZ_Radius = CType(6, Byte)
        Me.RL_UPH.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RL_UPH.BZ_SingleLine = False
        Me.RL_UPH.BZ_SmallText = "SmallText"
        Me.RL_UPH.BZ_SmallTextColor = System.Drawing.Color.White
        Me.RL_UPH.BZ_SmallTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_UPH.BZ_SmallTextTopOffset = 8
        Me.RL_UPH.BZ_Version = "V1.0.0"
        Me.RL_UPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_UPH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RL_UPH.Location = New System.Drawing.Point(263, 2)
        Me.RL_UPH.Name = "RL_UPH"
        Me.RL_UPH.Size = New System.Drawing.Size(60, 60)
        Me.RL_UPH.TabIndex = 4
        Me.RL_UPH.Text = "RoundLabel3"
        '
        'RL_MaterialLevel
        '
        Me.RL_MaterialLevel.BackColor = System.Drawing.Color.Magenta
        Me.RL_MaterialLevel.BZ_AutoBkColor = True
        Me.RL_MaterialLevel.BZ_BigText = "BigText"
        Me.RL_MaterialLevel.BZ_BigTextButtomOffset = 4
        Me.RL_MaterialLevel.BZ_BigTextColor = System.Drawing.Color.White
        Me.RL_MaterialLevel.BZ_BigTextFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_MaterialLevel.BZ_Radius = CType(6, Byte)
        Me.RL_MaterialLevel.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RL_MaterialLevel.BZ_SingleLine = False
        Me.RL_MaterialLevel.BZ_SmallText = "SmallText"
        Me.RL_MaterialLevel.BZ_SmallTextColor = System.Drawing.Color.White
        Me.RL_MaterialLevel.BZ_SmallTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_MaterialLevel.BZ_SmallTextTopOffset = 8
        Me.RL_MaterialLevel.BZ_Version = "V1.0.0"
        Me.RL_MaterialLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RL_MaterialLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RL_MaterialLevel.Location = New System.Drawing.Point(328, 2)
        Me.RL_MaterialLevel.Name = "RL_MaterialLevel"
        Me.RL_MaterialLevel.Size = New System.Drawing.Size(160, 60)
        Me.RL_MaterialLevel.TabIndex = 5
        Me.RL_MaterialLevel.Text = "RoundLabel4"
        '
        'RoundPanel1
        '
        Me.RoundPanel1.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel1.BZ_AutoBkColor = True
        Me.RoundPanel1.BZ_Radius = CType(6, Byte)
        Me.RoundPanel1.BZ_Version = "V1.0.0"
        Me.RoundPanel1.Controls.Add(Me.Chart_Column)
        Me.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel1.Location = New System.Drawing.Point(688, 2)
        Me.RoundPanel1.Name = "RoundPanel1"
        Me.RoundPanel1.Size = New System.Drawing.Size(328, 357)
        Me.RoundPanel1.TabIndex = 7
        '
        'Chart_Column
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Column.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_Column.Legends.Add(Legend1)
        Me.Chart_Column.Location = New System.Drawing.Point(-10, 10)
        Me.Chart_Column.Name = "Chart_Column"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Chart_Column.Series.Add(Series1)
        Me.Chart_Column.Series.Add(Series2)
        Me.Chart_Column.Size = New System.Drawing.Size(350, 360)
        Me.Chart_Column.TabIndex = 0
        Me.Chart_Column.Text = "Chart1"
        '
        'RoundPanel2
        '
        Me.RoundPanel2.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel2.BZ_AutoBkColor = True
        Me.RoundPanel2.BZ_Radius = CType(6, Byte)
        Me.RoundPanel2.BZ_Version = "V1.0.0"
        Me.RoundPanel2.Controls.Add(Me.RoundLabel1)
        Me.RoundPanel2.Controls.Add(Me.Lbl_SN)
        Me.RoundPanel2.Controls.Add(Me.Btn_PressLine_VDown)
        Me.RoundPanel2.Controls.Add(Me.Btn_PressLine_VUp)
        Me.RoundPanel2.Controls.Add(Me.Btn_PressLine_HB)
        Me.RoundPanel2.Controls.Add(Me.Chart_Press)
        Me.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel2.Location = New System.Drawing.Point(3, 67)
        Me.RoundPanel2.Name = "RoundPanel2"
        Me.RoundPanel2.Size = New System.Drawing.Size(680, 195)
        Me.RoundPanel2.TabIndex = 8
        '
        'RoundLabel1
        '
        Me.RoundLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel1.BZ_AutoBkColor = False
        Me.RoundLabel1.BZ_BigText = "BOTECH"
        Me.RoundLabel1.BZ_BigTextButtomOffset = 0
        Me.RoundLabel1.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel1.BZ_BigTextFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RoundLabel1.BZ_Radius = CType(6, Byte)
        Me.RoundLabel1.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RoundLabel1.BZ_SingleLine = True
        Me.RoundLabel1.BZ_SmallText = "BOTECH"
        Me.RoundLabel1.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel1.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel1.BZ_SmallTextTopOffset = 0
        Me.RoundLabel1.BZ_Version = "V1.0.0"
        Me.RoundLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel1.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel1.Location = New System.Drawing.Point(277, -1)
        Me.RoundLabel1.Name = "RoundLabel1"
        Me.RoundLabel1.Size = New System.Drawing.Size(134, 27)
        Me.RoundLabel1.TabIndex = 21
        Me.RoundLabel1.Text = " PRESS FORCE"
        '
        'Lbl_SN
        '
        Me.Lbl_SN.AutoSize = True
        Me.Lbl_SN.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Lbl_SN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SN.ForeColor = System.Drawing.Color.Black
        Me.Lbl_SN.Location = New System.Drawing.Point(40, 4)
        Me.Lbl_SN.Name = "Lbl_SN"
        Me.Lbl_SN.Size = New System.Drawing.Size(83, 20)
        Me.Lbl_SN.TabIndex = 12
        Me.Lbl_SN.Text = "SN: XXXX"
        '
        'Btn_PressLine_VDown
        '
        Me.Btn_PressLine_VDown.BackColor = System.Drawing.Color.LightGray
        Me.Btn_PressLine_VDown.BZ_Radius = CType(6, Byte)
        Me.Btn_PressLine_VDown.BZ_Version = "V1.0.0"
        Me.Btn_PressLine_VDown.FlatAppearance.BorderSize = 0
        Me.Btn_PressLine_VDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PressLine_VDown.ForeColor = System.Drawing.Color.Black
        Me.Btn_PressLine_VDown.Location = New System.Drawing.Point(611, 132)
        Me.Btn_PressLine_VDown.Name = "Btn_PressLine_VDown"
        Me.Btn_PressLine_VDown.Size = New System.Drawing.Size(60, 60)
        Me.Btn_PressLine_VDown.TabIndex = 11
        Me.Btn_PressLine_VDown.Text = "V-"
        Me.Btn_PressLine_VDown.UseVisualStyleBackColor = False
        '
        'Btn_PressLine_VUp
        '
        Me.Btn_PressLine_VUp.BackColor = System.Drawing.Color.LightGray
        Me.Btn_PressLine_VUp.BZ_Radius = CType(6, Byte)
        Me.Btn_PressLine_VUp.BZ_Version = "V1.0.0"
        Me.Btn_PressLine_VUp.FlatAppearance.BorderSize = 0
        Me.Btn_PressLine_VUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PressLine_VUp.ForeColor = System.Drawing.Color.Black
        Me.Btn_PressLine_VUp.Location = New System.Drawing.Point(611, 67)
        Me.Btn_PressLine_VUp.Name = "Btn_PressLine_VUp"
        Me.Btn_PressLine_VUp.Size = New System.Drawing.Size(60, 60)
        Me.Btn_PressLine_VUp.TabIndex = 10
        Me.Btn_PressLine_VUp.Text = "V+"
        Me.Btn_PressLine_VUp.UseVisualStyleBackColor = False
        '
        'Btn_PressLine_HB
        '
        Me.Btn_PressLine_HB.BackColor = System.Drawing.Color.LightGray
        Me.Btn_PressLine_HB.BZ_Radius = CType(6, Byte)
        Me.Btn_PressLine_HB.BZ_Version = "V1.0.0"
        Me.Btn_PressLine_HB.FlatAppearance.BorderSize = 0
        Me.Btn_PressLine_HB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PressLine_HB.ForeColor = System.Drawing.Color.Black
        Me.Btn_PressLine_HB.Location = New System.Drawing.Point(611, 2)
        Me.Btn_PressLine_HB.Name = "Btn_PressLine_HB"
        Me.Btn_PressLine_HB.Size = New System.Drawing.Size(60, 60)
        Me.Btn_PressLine_HB.TabIndex = 9
        Me.Btn_PressLine_HB.Text = "HB"
        Me.Btn_PressLine_HB.UseVisualStyleBackColor = False
        '
        'Chart_Press
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart_Press.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart_Press.Legends.Add(Legend2)
        Me.Chart_Press.Location = New System.Drawing.Point(-25, 14)
        Me.Chart_Press.Name = "Chart_Press"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart_Press.Series.Add(Series3)
        Me.Chart_Press.Size = New System.Drawing.Size(660, 174)
        Me.Chart_Press.TabIndex = 8
        Me.Chart_Press.Text = "Chart1"
        '
        'RoundPanel3
        '
        Me.RoundPanel3.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel3.BZ_AutoBkColor = True
        Me.RoundPanel3.BZ_Radius = CType(6, Byte)
        Me.RoundPanel3.BZ_Version = "V1.0.0"
        Me.RoundPanel3.Controls.Add(Me.RoundLabel5)
        Me.RoundPanel3.Controls.Add(Me.RoundLabel4)
        Me.RoundPanel3.Controls.Add(Me.RoundLabel3)
        Me.RoundPanel3.Controls.Add(Me.RoundLabel2)
        Me.RoundPanel3.Controls.Add(Me.Txt_S6ErrorMsg)
        Me.RoundPanel3.Controls.Add(Me.SRB_VBdown)
        Me.RoundPanel3.Controls.Add(Me.SRB_VBup)
        Me.RoundPanel3.Controls.Add(Me.SRB_HB)
        Me.RoundPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel3.Location = New System.Drawing.Point(3, 261)
        Me.RoundPanel3.Name = "RoundPanel3"
        Me.RoundPanel3.Size = New System.Drawing.Size(680, 216)
        Me.RoundPanel3.TabIndex = 9
        '
        'RoundLabel5
        '
        Me.RoundLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel5.BZ_AutoBkColor = False
        Me.RoundLabel5.BZ_BigText = "BOTECH"
        Me.RoundLabel5.BZ_BigTextButtomOffset = 0
        Me.RoundLabel5.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel5.BZ_BigTextFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RoundLabel5.BZ_Radius = CType(6, Byte)
        Me.RoundLabel5.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RoundLabel5.BZ_SingleLine = True
        Me.RoundLabel5.BZ_SmallText = "BOTECH"
        Me.RoundLabel5.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel5.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel5.BZ_SmallTextTopOffset = 0
        Me.RoundLabel5.BZ_Version = "V1.0.0"
        Me.RoundLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel5.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel5.Location = New System.Drawing.Point(549, 148)
        Me.RoundLabel5.Name = "RoundLabel5"
        Me.RoundLabel5.Size = New System.Drawing.Size(60, 30)
        Me.RoundLabel5.TabIndex = 51
        Me.RoundLabel5.Text = "VB-"
        '
        'RoundLabel4
        '
        Me.RoundLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel4.BZ_AutoBkColor = False
        Me.RoundLabel4.BZ_BigText = "BOTECH"
        Me.RoundLabel4.BZ_BigTextButtomOffset = 0
        Me.RoundLabel4.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel4.BZ_BigTextFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RoundLabel4.BZ_Radius = CType(6, Byte)
        Me.RoundLabel4.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RoundLabel4.BZ_SingleLine = True
        Me.RoundLabel4.BZ_SmallText = "BOTECH"
        Me.RoundLabel4.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel4.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel4.BZ_SmallTextTopOffset = 0
        Me.RoundLabel4.BZ_Version = "V1.0.0"
        Me.RoundLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel4.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel4.Location = New System.Drawing.Point(315, 148)
        Me.RoundLabel4.Name = "RoundLabel4"
        Me.RoundLabel4.Size = New System.Drawing.Size(60, 30)
        Me.RoundLabel4.TabIndex = 50
        Me.RoundLabel4.Text = "VB+"
        '
        'RoundLabel3
        '
        Me.RoundLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel3.BZ_AutoBkColor = False
        Me.RoundLabel3.BZ_BigText = "BOTECH"
        Me.RoundLabel3.BZ_BigTextButtomOffset = 0
        Me.RoundLabel3.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel3.BZ_BigTextFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RoundLabel3.BZ_Radius = CType(6, Byte)
        Me.RoundLabel3.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RoundLabel3.BZ_SingleLine = True
        Me.RoundLabel3.BZ_SmallText = "BOTECH"
        Me.RoundLabel3.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel3.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel3.BZ_SmallTextTopOffset = 0
        Me.RoundLabel3.BZ_Version = "V1.0.0"
        Me.RoundLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel3.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel3.Location = New System.Drawing.Point(78, 148)
        Me.RoundLabel3.Name = "RoundLabel3"
        Me.RoundLabel3.Size = New System.Drawing.Size(60, 30)
        Me.RoundLabel3.TabIndex = 49
        Me.RoundLabel3.Text = "HB"
        '
        'RoundLabel2
        '
        Me.RoundLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel2.BZ_AutoBkColor = False
        Me.RoundLabel2.BZ_BigText = "BOTECH"
        Me.RoundLabel2.BZ_BigTextButtomOffset = 0
        Me.RoundLabel2.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel2.BZ_BigTextFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RoundLabel2.BZ_Radius = CType(6, Byte)
        Me.RoundLabel2.BZ_RoundBackColor = System.Drawing.Color.LightGray
        Me.RoundLabel2.BZ_SingleLine = True
        Me.RoundLabel2.BZ_SmallText = "BOTECH"
        Me.RoundLabel2.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel2.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel2.BZ_SmallTextTopOffset = 0
        Me.RoundLabel2.BZ_Version = "V1.0.0"
        Me.RoundLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel2.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel2.Location = New System.Drawing.Point(257, 3)
        Me.RoundLabel2.Name = "RoundLabel2"
        Me.RoundLabel2.Size = New System.Drawing.Size(174, 27)
        Me.RoundLabel2.TabIndex = 48
        Me.RoundLabel2.Text = " BUTTON CC"
        '
        'Txt_S6ErrorMsg
        '
        Me.Txt_S6ErrorMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Txt_S6ErrorMsg.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Txt_S6ErrorMsg.Location = New System.Drawing.Point(10, 180)
        Me.Txt_S6ErrorMsg.Name = "Txt_S6ErrorMsg"
        Me.Txt_S6ErrorMsg.Size = New System.Drawing.Size(658, 34)
        Me.Txt_S6ErrorMsg.TabIndex = 47
        '
        'SRB_VBdown
        '
        Me.SRB_VBdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_VBdown.BZ_BarWidth = CType(30, Byte)
        Me.SRB_VBdown.BZ_NgBarColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.SRB_VBdown.BZ_NgRate = CType(50, Byte)
        Me.SRB_VBdown.BZ_OkBarColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_VBdown.BZ_ResultBkColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_VBdown.BZ_ResultRadius = CType(25, Byte)
        Me.SRB_VBdown.BZ_ResultText = "OK"
        Me.SRB_VBdown.BZ_ResultTextColor = System.Drawing.Color.White
        Me.SRB_VBdown.BZ_Version = "V1.0.0"
        Me.SRB_VBdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRB_VBdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_VBdown.Location = New System.Drawing.Point(492, 34)
        Me.SRB_VBdown.Name = "SRB_VBdown"
        Me.SRB_VBdown.Size = New System.Drawing.Size(174, 130)
        Me.SRB_VBdown.TabIndex = 2
        Me.SRB_VBdown.Text = "SingleRoundBar3"
        Me.SRB_VBdown.UseVisualStyleBackColor = False
        '
        'SRB_VBup
        '
        Me.SRB_VBup.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_VBup.BZ_BarWidth = CType(30, Byte)
        Me.SRB_VBup.BZ_NgBarColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.SRB_VBup.BZ_NgRate = CType(50, Byte)
        Me.SRB_VBup.BZ_OkBarColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_VBup.BZ_ResultBkColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_VBup.BZ_ResultRadius = CType(25, Byte)
        Me.SRB_VBup.BZ_ResultText = "OK"
        Me.SRB_VBup.BZ_ResultTextColor = System.Drawing.Color.White
        Me.SRB_VBup.BZ_Version = "V1.0.0"
        Me.SRB_VBup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRB_VBup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_VBup.Location = New System.Drawing.Point(257, 34)
        Me.SRB_VBup.Name = "SRB_VBup"
        Me.SRB_VBup.Size = New System.Drawing.Size(174, 130)
        Me.SRB_VBup.TabIndex = 1
        Me.SRB_VBup.Text = "SingleRoundBar2"
        Me.SRB_VBup.UseVisualStyleBackColor = False
        '
        'SRB_HB
        '
        Me.SRB_HB.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_HB.BZ_BarWidth = CType(30, Byte)
        Me.SRB_HB.BZ_NgBarColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.SRB_HB.BZ_NgRate = CType(50, Byte)
        Me.SRB_HB.BZ_OkBarColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_HB.BZ_ResultBkColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SRB_HB.BZ_ResultRadius = CType(25, Byte)
        Me.SRB_HB.BZ_ResultText = "OK"
        Me.SRB_HB.BZ_ResultTextColor = System.Drawing.Color.White
        Me.SRB_HB.BZ_Version = "V1.0.0"
        Me.SRB_HB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRB_HB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SRB_HB.Location = New System.Drawing.Point(22, 34)
        Me.SRB_HB.Name = "SRB_HB"
        Me.SRB_HB.Size = New System.Drawing.Size(174, 130)
        Me.SRB_HB.TabIndex = 0
        Me.SRB_HB.Text = "SingleRoundBar1"
        Me.SRB_HB.UseVisualStyleBackColor = False
        '
        'RoundPanel4
        '
        Me.RoundPanel4.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel4.BZ_AutoBkColor = True
        Me.RoundPanel4.BZ_Radius = CType(6, Byte)
        Me.RoundPanel4.BZ_Version = "V1.0.0"
        Me.RoundPanel4.Controls.Add(Me.Btn_Msg)
        Me.RoundPanel4.Controls.Add(Me.PB_Right2)
        Me.RoundPanel4.Controls.Add(Me.Lbl_EndDate)
        Me.RoundPanel4.Controls.Add(Me.Lbl_StartDate)
        Me.RoundPanel4.Controls.Add(Me.Btn_Retest)
        Me.RoundPanel4.Controls.Add(Me.Btn_Yield)
        Me.RoundPanel4.Controls.Add(Me.DRB_YieldRetest)
        Me.RoundPanel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel4.Location = New System.Drawing.Point(688, 364)
        Me.RoundPanel4.Name = "RoundPanel4"
        Me.RoundPanel4.Size = New System.Drawing.Size(328, 291)
        Me.RoundPanel4.TabIndex = 10
        '
        'Btn_Msg
        '
        Me.Btn_Msg.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Btn_Msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Msg.Location = New System.Drawing.Point(137, 239)
        Me.Btn_Msg.Name = "Btn_Msg"
        Me.Btn_Msg.Size = New System.Drawing.Size(60, 45)
        Me.Btn_Msg.TabIndex = 53
        Me.Btn_Msg.Text = "Button1"
        Me.Btn_Msg.UseVisualStyleBackColor = False
        '
        'PB_Right2
        '
        Me.PB_Right2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PB_Right2.BackgroundImage = CType(resources.GetObject("PB_Right2.BackgroundImage"), System.Drawing.Image)
        Me.PB_Right2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_Right2.Location = New System.Drawing.Point(93, 151)
        Me.PB_Right2.Name = "PB_Right2"
        Me.PB_Right2.Size = New System.Drawing.Size(20, 20)
        Me.PB_Right2.TabIndex = 29
        Me.PB_Right2.TabStop = False
        '
        'Lbl_EndDate
        '
        Me.Lbl_EndDate.AutoSize = True
        Me.Lbl_EndDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Lbl_EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EndDate.ForeColor = System.Drawing.Color.Black
        Me.Lbl_EndDate.Location = New System.Drawing.Point(37, 166)
        Me.Lbl_EndDate.Name = "Lbl_EndDate"
        Me.Lbl_EndDate.Size = New System.Drawing.Size(41, 12)
        Me.Lbl_EndDate.TabIndex = 6
        Me.Lbl_EndDate.Text = "04/01/15"
        Me.Lbl_EndDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_StartDate
        '
        Me.Lbl_StartDate.AutoSize = True
        Me.Lbl_StartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Lbl_StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_StartDate.ForeColor = System.Drawing.Color.Black
        Me.Lbl_StartDate.Location = New System.Drawing.Point(37, 151)
        Me.Lbl_StartDate.Name = "Lbl_StartDate"
        Me.Lbl_StartDate.Size = New System.Drawing.Size(41, 12)
        Me.Lbl_StartDate.TabIndex = 5
        Me.Lbl_StartDate.Text = "03/01/15"
        '
        'Btn_Retest
        '
        Me.Btn_Retest.BackColor = System.Drawing.Color.LightGray
        Me.Btn_Retest.BZ_Radius = CType(6, Byte)
        Me.Btn_Retest.BZ_Version = "V1.0.0"
        Me.Btn_Retest.FlatAppearance.BorderSize = 0
        Me.Btn_Retest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Retest.ForeColor = System.Drawing.Color.Black
        Me.Btn_Retest.Location = New System.Drawing.Point(212, 209)
        Me.Btn_Retest.Name = "Btn_Retest"
        Me.Btn_Retest.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Retest.TabIndex = 4
        Me.Btn_Retest.Text = "Retest"
        Me.Btn_Retest.UseVisualStyleBackColor = False
        '
        'Btn_Yield
        '
        Me.Btn_Yield.BackColor = System.Drawing.Color.LightGray
        Me.Btn_Yield.BZ_Radius = CType(6, Byte)
        Me.Btn_Yield.BZ_Version = "V1.0.0"
        Me.Btn_Yield.FlatAppearance.BorderSize = 0
        Me.Btn_Yield.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Yield.ForeColor = System.Drawing.Color.Black
        Me.Btn_Yield.Location = New System.Drawing.Point(56, 209)
        Me.Btn_Yield.Name = "Btn_Yield"
        Me.Btn_Yield.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Yield.TabIndex = 3
        Me.Btn_Yield.Text = "Yield"
        Me.Btn_Yield.UseVisualStyleBackColor = False
        '
        'DRB_YieldRetest
        '
        Me.DRB_YieldRetest.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DRB_YieldRetest.BZ_BarWidth1 = CType(38, Byte)
        Me.DRB_YieldRetest.BZ_BarWidth2 = CType(38, Byte)
        Me.DRB_YieldRetest.BZ_IntervalWidth = CType(5, Byte)
        Me.DRB_YieldRetest.BZ_NgBar1Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.DRB_YieldRetest.BZ_NgBar2Color = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.DRB_YieldRetest.BZ_NgRate1 = CType(50, Byte)
        Me.DRB_YieldRetest.BZ_NgRate2 = CType(30, Byte)
        Me.DRB_YieldRetest.BZ_OkBar1Color = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DRB_YieldRetest.BZ_OkBar2Color = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DRB_YieldRetest.BZ_ResultBkColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DRB_YieldRetest.BZ_ResultRadius = CType(35, Byte)
        Me.DRB_YieldRetest.BZ_ResultText = "OK"
        Me.DRB_YieldRetest.BZ_ResultTextColor = System.Drawing.Color.White
        Me.DRB_YieldRetest.BZ_Version = "V1.0.0"
        Me.DRB_YieldRetest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRB_YieldRetest.ForeColor = System.Drawing.Color.White
        Me.DRB_YieldRetest.Location = New System.Drawing.Point(41, 21)
        Me.DRB_YieldRetest.Name = "DRB_YieldRetest"
        Me.DRB_YieldRetest.Size = New System.Drawing.Size(243, 182)
        Me.DRB_YieldRetest.TabIndex = 2
        Me.DRB_YieldRetest.Text = "DoubleRoundBar1"
        Me.DRB_YieldRetest.UseVisualStyleBackColor = False
        '
        'Timer_Test
        '
        Me.Timer_Test.Interval = 300
        '
        'Timer_Always
        '
        Me.Timer_Always.Enabled = True
        Me.Timer_Always.Interval = 1000
        '
        'RoundPanel5
        '
        Me.RoundPanel5.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel5.BZ_AutoBkColor = True
        Me.RoundPanel5.BZ_Radius = CType(6, Byte)
        Me.RoundPanel5.BZ_Version = "V1.0.0"
        Me.RoundPanel5.Controls.Add(Me.RoundLabel6)
        Me.RoundPanel5.Controls.Add(Me.ProductListBoxMsg)
        Me.RoundPanel5.Controls.Add(Me.Chart_VBDOWN)
        Me.RoundPanel5.Controls.Add(Me.Chart_VBUP)
        Me.RoundPanel5.Controls.Add(Me.Chart_HB)
        Me.RoundPanel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel5.Location = New System.Drawing.Point(2, 478)
        Me.RoundPanel5.Name = "RoundPanel5"
        Me.RoundPanel5.Size = New System.Drawing.Size(680, 180)
        Me.RoundPanel5.TabIndex = 56
        '
        'RoundLabel6
        '
        Me.RoundLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundLabel6.BZ_AutoBkColor = True
        Me.RoundLabel6.BZ_BigText = "SHIM USAGE"
        Me.RoundLabel6.BZ_BigTextButtomOffset = 0
        Me.RoundLabel6.BZ_BigTextColor = System.Drawing.Color.Black
        Me.RoundLabel6.BZ_BigTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel6.BZ_Radius = CType(6, Byte)
        Me.RoundLabel6.BZ_RoundBackColor = System.Drawing.Color.Gainsboro
        Me.RoundLabel6.BZ_SingleLine = True
        Me.RoundLabel6.BZ_SmallText = "SHIM USAGE"
        Me.RoundLabel6.BZ_SmallTextColor = System.Drawing.Color.Black
        Me.RoundLabel6.BZ_SmallTextFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.RoundLabel6.BZ_SmallTextTopOffset = 0
        Me.RoundLabel6.BZ_Version = "V1.0.0"
        Me.RoundLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel6.ForeColor = System.Drawing.Color.Black
        Me.RoundLabel6.Location = New System.Drawing.Point(275, -7)
        Me.RoundLabel6.Name = "RoundLabel6"
        Me.RoundLabel6.Size = New System.Drawing.Size(128, 31)
        Me.RoundLabel6.TabIndex = 21
        Me.RoundLabel6.Text = "SHIM USAGE"
        '
        'ProductListBoxMsg
        '
        Me.ProductListBoxMsg.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ProductListBoxMsg.FormattingEnabled = True
        Me.ProductListBoxMsg.ItemHeight = 14
        Me.ProductListBoxMsg.Location = New System.Drawing.Point(15, 159)
        Me.ProductListBoxMsg.Name = "ProductListBoxMsg"
        Me.ProductListBoxMsg.Size = New System.Drawing.Size(653, 18)
        Me.ProductListBoxMsg.TabIndex = 17
        Me.ProductListBoxMsg.Visible = False
        '
        'Chart_VBDOWN
        '
        Me.Chart_VBDOWN.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.Chart_VBDOWN.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart_VBDOWN.Legends.Add(Legend3)
        Me.Chart_VBDOWN.Location = New System.Drawing.Point(455, 24)
        Me.Chart_VBDOWN.Name = "Chart_VBDOWN"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart_VBDOWN.Series.Add(Series4)
        Me.Chart_VBDOWN.Size = New System.Drawing.Size(214, 144)
        Me.Chart_VBDOWN.TabIndex = 16
        Me.Chart_VBDOWN.Text = "Chart4"
        '
        'Chart_VBUP
        '
        Me.Chart_VBUP.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea4.Name = "ChartArea1"
        Me.Chart_VBUP.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart_VBUP.Legends.Add(Legend4)
        Me.Chart_VBUP.Location = New System.Drawing.Point(235, 25)
        Me.Chart_VBUP.Name = "Chart_VBUP"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart_VBUP.Series.Add(Series5)
        Me.Chart_VBUP.Size = New System.Drawing.Size(214, 144)
        Me.Chart_VBUP.TabIndex = 15
        Me.Chart_VBUP.Text = "Chart3"
        '
        'Chart_HB
        '
        Me.Chart_HB.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea5.Name = "ChartArea1"
        Me.Chart_HB.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart_HB.Legends.Add(Legend5)
        Me.Chart_HB.Location = New System.Drawing.Point(15, 22)
        Me.Chart_HB.Name = "Chart_HB"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.Chart_HB.Series.Add(Series6)
        Me.Chart_HB.Size = New System.Drawing.Size(214, 144)
        Me.Chart_HB.TabIndex = 14
        Me.Chart_HB.Text = "Chart2"
        '
        'frmProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(1020, 660)
        Me.Controls.Add(Me.RoundPanel5)
        Me.Controls.Add(Me.RoundPanel4)
        Me.Controls.Add(Me.RoundPanel3)
        Me.Controls.Add(Me.RoundPanel2)
        Me.Controls.Add(Me.RoundPanel1)
        Me.Controls.Add(Me.RL_MaterialLevel)
        Me.Controls.Add(Me.RL_UPH)
        Me.Controls.Add(Me.RL_AlarmTime)
        Me.Controls.Add(Me.RL_AlarmStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduction"
        Me.ShowInTaskbar = False
        Me.Text = "Frm_Home"
        Me.RoundPanel1.ResumeLayout(False)
        CType(Me.Chart_Column, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel2.ResumeLayout(False)
        Me.RoundPanel2.PerformLayout()
        CType(Me.Chart_Press, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel3.ResumeLayout(False)
        Me.RoundPanel3.PerformLayout()
        Me.RoundPanel4.ResumeLayout(False)
        Me.RoundPanel4.PerformLayout()
        CType(Me.PB_Right2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel5.ResumeLayout(False)
        CType(Me.Chart_VBDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_VBUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_HB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RL_AlarmStatus As BZ.UI.RoundLabel
    Friend WithEvents RL_AlarmTime As BZ.UI.RoundLabel
    Friend WithEvents RL_UPH As BZ.UI.RoundLabel
    Friend WithEvents RL_MaterialLevel As BZ.UI.RoundLabel
    Friend WithEvents RoundPanel1 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel2 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel3 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel4 As BZ.UI.RoundPanel
    Friend WithEvents DRB_YieldRetest As BZ.UI.DoubleRoundBar
    Friend WithEvents SRB_VBdown As BZ.UI.SingleRoundBar
    Friend WithEvents SRB_VBup As BZ.UI.SingleRoundBar
    Friend WithEvents SRB_HB As BZ.UI.SingleRoundBar
    Friend WithEvents Btn_Retest As BZ.UI.RoundButton
    Friend WithEvents Btn_Yield As BZ.UI.RoundButton
    Friend WithEvents Lbl_EndDate As System.Windows.Forms.Label
    Friend WithEvents Lbl_StartDate As System.Windows.Forms.Label
    Friend WithEvents Chart_Press As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PB_Right2 As System.Windows.Forms.PictureBox
    Friend WithEvents Chart_Column As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Btn_PressLine_VDown As BZ.UI.RoundButton
    Friend WithEvents Btn_PressLine_VUp As BZ.UI.RoundButton
    Friend WithEvents Btn_PressLine_HB As BZ.UI.RoundButton
    Friend WithEvents Timer_Test As System.Windows.Forms.Timer
    Friend WithEvents Timer_PressCurve As System.Windows.Forms.Timer
    Friend WithEvents Lbl_SN As System.Windows.Forms.Label
    Friend WithEvents Timer_Always As System.Windows.Forms.Timer
    Friend WithEvents RoundLabel1 As BZ.UI.RoundLabel
    Friend WithEvents RoundLabel2 As BZ.UI.RoundLabel
    Friend WithEvents RoundLabel5 As BZ.UI.RoundLabel
    Friend WithEvents RoundLabel4 As BZ.UI.RoundLabel
    Friend WithEvents RoundLabel3 As BZ.UI.RoundLabel
    Friend WithEvents Txt_S6ErrorMsg As System.Windows.Forms.TextBox
    Friend WithEvents RoundPanel5 As BZ.UI.RoundPanel
    Friend WithEvents RoundLabel6 As BZ.UI.RoundLabel
    Friend WithEvents ProductListBoxMsg As System.Windows.Forms.ListBox
    Friend WithEvents Chart_VBDOWN As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_VBUP As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_HB As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Btn_Msg As System.Windows.Forms.Button
End Class
