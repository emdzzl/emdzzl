<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlarmHistory
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlarmHistory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RoundPanel1 = New BZ.UI.RoundPanel()
        Me.LB_CodeDescription = New System.Windows.Forms.ListBox()
        Me.RoundPanel2 = New BZ.UI.RoundPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel3 = New BZ.UI.RoundPanel()
        Me.Btn_Download = New System.Windows.Forms.Button()
        Me.AlarmDataGridView = New System.Windows.Forms.DataGridView()
        Me.RoundPanel1.SuspendLayout()
        Me.RoundPanel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel3.SuspendLayout()
        CType(Me.AlarmDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundPanel1
        '
        Me.RoundPanel1.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel1.BZ_AutoBkColor = True
        Me.RoundPanel1.BZ_Radius = CType(6, Byte)
        Me.RoundPanel1.BZ_Version = "V1.0.0"
        Me.RoundPanel1.Controls.Add(Me.LB_CodeDescription)
        Me.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.RoundPanel1.Location = New System.Drawing.Point(3, 2)
        Me.RoundPanel1.Name = "RoundPanel1"
        Me.RoundPanel1.Size = New System.Drawing.Size(550, 80)
        Me.RoundPanel1.TabIndex = 0
        '
        'LB_CodeDescription
        '
        Me.LB_CodeDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.LB_CodeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_CodeDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CodeDescription.FormattingEnabled = True
        Me.LB_CodeDescription.ItemHeight = 20
        Me.LB_CodeDescription.Items.AddRange(New Object() {"● Code: ABCDEFG", "● Normal state"})
        Me.LB_CodeDescription.Location = New System.Drawing.Point(10, 20)
        Me.LB_CodeDescription.Name = "LB_CodeDescription"
        Me.LB_CodeDescription.Size = New System.Drawing.Size(530, 20)
        Me.LB_CodeDescription.TabIndex = 0
        '
        'RoundPanel2
        '
        Me.RoundPanel2.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel2.BZ_AutoBkColor = True
        Me.RoundPanel2.BZ_Radius = CType(6, Byte)
        Me.RoundPanel2.BZ_Version = "V1.0.0"
        Me.RoundPanel2.Controls.Add(Me.Chart1)
        Me.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel2.Location = New System.Drawing.Point(558, 2)
        Me.RoundPanel2.Name = "RoundPanel2"
        Me.RoundPanel2.Size = New System.Drawing.Size(458, 653)
        Me.RoundPanel2.TabIndex = 1
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.IsDockedInsideChartArea = False
        Legend1.Name = "Legend1"
        Legend1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(19, 19)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Series1.IsValueShownAsLabel = True
        Series1.Label = "#VALX:#VAL"
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Lime
        Series1.SmartLabelStyle.CalloutLineWidth = 5
        Series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(416, 443)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'RoundPanel3
        '
        Me.RoundPanel3.BackColor = System.Drawing.Color.Magenta
        Me.RoundPanel3.BZ_AutoBkColor = True
        Me.RoundPanel3.BZ_Radius = CType(6, Byte)
        Me.RoundPanel3.BZ_Version = "V1.0.0"
        Me.RoundPanel3.Controls.Add(Me.Btn_Download)
        Me.RoundPanel3.Controls.Add(Me.AlarmDataGridView)
        Me.RoundPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel3.Location = New System.Drawing.Point(3, 87)
        Me.RoundPanel3.Name = "RoundPanel3"
        Me.RoundPanel3.Size = New System.Drawing.Size(550, 568)
        Me.RoundPanel3.TabIndex = 2
        '
        'Btn_Download
        '
        Me.Btn_Download.Image = CType(resources.GetObject("Btn_Download.Image"), System.Drawing.Image)
        Me.Btn_Download.Location = New System.Drawing.Point(231, 383)
        Me.Btn_Download.Name = "Btn_Download"
        Me.Btn_Download.Size = New System.Drawing.Size(78, 70)
        Me.Btn_Download.TabIndex = 1
        Me.Btn_Download.UseVisualStyleBackColor = True
        '
        'AlarmDataGridView
        '
        Me.AlarmDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.AlarmDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlarmDataGridView.Location = New System.Drawing.Point(9, 31)
        Me.AlarmDataGridView.Name = "AlarmDataGridView"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.AlarmDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AlarmDataGridView.RowTemplate.Height = 23
        Me.AlarmDataGridView.Size = New System.Drawing.Size(534, 346)
        Me.AlarmDataGridView.TabIndex = 0
        '
        'frmAlarmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(1020, 660)
        Me.Controls.Add(Me.RoundPanel3)
        Me.Controls.Add(Me.RoundPanel2)
        Me.Controls.Add(Me.RoundPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlarmHistory"
        Me.ShowInTaskbar = False
        Me.Text = "Frm_AlarmHistory"
        Me.RoundPanel1.ResumeLayout(False)
        Me.RoundPanel2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel3.ResumeLayout(False)
        CType(Me.AlarmDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundPanel1 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel2 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel3 As BZ.UI.RoundPanel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AlarmDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Download As System.Windows.Forms.Button
    Friend WithEvents LB_CodeDescription As System.Windows.Forms.ListBox
End Class
