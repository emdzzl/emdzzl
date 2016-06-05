<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRunInfo
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.RoundPanel1 = New BZ.UI.RoundPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1_Addition = New System.Windows.Forms.Button()
        Me.TrackBar1_Subtraction = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Chart_Yield = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel2 = New BZ.UI.RoundPanel()
        Me.TrackBar2_Addition = New System.Windows.Forms.Button()
        Me.TrackBar2_Subtraction = New System.Windows.Forms.Button()
        Me.TrackBar3_Addition = New System.Windows.Forms.Button()
        Me.TrackBar3_Subtraction = New System.Windows.Forms.Button()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Chart_UPH = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_Tossing = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundPanel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Yield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundPanel2.SuspendLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_UPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Tossing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundPanel1
        '
        Me.RoundPanel1.BackColor = System.Drawing.Color.White
        Me.RoundPanel1.BZ_AutoBkColor = True
        Me.RoundPanel1.BZ_Radius = CType(6, Byte)
        Me.RoundPanel1.BZ_Version = "V1.0.0"
        Me.RoundPanel1.Controls.Add(Me.Label3)
        Me.RoundPanel1.Controls.Add(Me.TrackBar1_Addition)
        Me.RoundPanel1.Controls.Add(Me.TrackBar1_Subtraction)
        Me.RoundPanel1.Controls.Add(Me.TrackBar1)
        Me.RoundPanel1.Controls.Add(Me.Chart_Yield)
        Me.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel1.Location = New System.Drawing.Point(3, 2)
        Me.RoundPanel1.Name = "RoundPanel1"
        Me.RoundPanel1.Size = New System.Drawing.Size(1013, 324)
        Me.RoundPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(479, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Date:"
        '
        'TrackBar1_Addition
        '
        Me.TrackBar1_Addition.BackColor = System.Drawing.Color.LightGray
        Me.TrackBar1_Addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar1_Addition.ForeColor = System.Drawing.Color.Black
        Me.TrackBar1_Addition.Location = New System.Drawing.Point(666, 272)
        Me.TrackBar1_Addition.Name = "TrackBar1_Addition"
        Me.TrackBar1_Addition.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar1_Addition.TabIndex = 18
        Me.TrackBar1_Addition.Text = "+"
        Me.TrackBar1_Addition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrackBar1_Addition.UseVisualStyleBackColor = False
        '
        'TrackBar1_Subtraction
        '
        Me.TrackBar1_Subtraction.BackColor = System.Drawing.Color.LightGray
        Me.TrackBar1_Subtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar1_Subtraction.ForeColor = System.Drawing.Color.Black
        Me.TrackBar1_Subtraction.Location = New System.Drawing.Point(314, 272)
        Me.TrackBar1_Subtraction.Name = "TrackBar1_Subtraction"
        Me.TrackBar1_Subtraction.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar1_Subtraction.TabIndex = 17
        Me.TrackBar1_Subtraction.Text = "-"
        Me.TrackBar1_Subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrackBar1_Subtraction.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrackBar1.Location = New System.Drawing.Point(360, 272)
        Me.TrackBar1.Maximum = 30
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(300, 45)
        Me.TrackBar1.TabIndex = 12
        Me.TrackBar1.Value = 3
        '
        'Chart_Yield
        '
        Me.Chart_Yield.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Yield.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_Yield.Legends.Add(Legend1)
        Me.Chart_Yield.Location = New System.Drawing.Point(-30, 9)
        Me.Chart_Yield.Name = "Chart_Yield"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart_Yield.Series.Add(Series1)
        Me.Chart_Yield.Size = New System.Drawing.Size(1040, 261)
        Me.Chart_Yield.TabIndex = 0
        Me.Chart_Yield.Text = "Chart1"
        '
        'RoundPanel2
        '
        Me.RoundPanel2.BackColor = System.Drawing.Color.White
        Me.RoundPanel2.BZ_AutoBkColor = True
        Me.RoundPanel2.BZ_Radius = CType(6, Byte)
        Me.RoundPanel2.BZ_Version = "V1.0.0"
        Me.RoundPanel2.Controls.Add(Me.TrackBar2_Addition)
        Me.RoundPanel2.Controls.Add(Me.TrackBar2_Subtraction)
        Me.RoundPanel2.Controls.Add(Me.TrackBar3_Addition)
        Me.RoundPanel2.Controls.Add(Me.TrackBar3_Subtraction)
        Me.RoundPanel2.Controls.Add(Me.TrackBar3)
        Me.RoundPanel2.Controls.Add(Me.TrackBar2)
        Me.RoundPanel2.Controls.Add(Me.Chart_UPH)
        Me.RoundPanel2.Controls.Add(Me.Chart_Tossing)
        Me.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RoundPanel2.Location = New System.Drawing.Point(-3, 331)
        Me.RoundPanel2.Name = "RoundPanel2"
        Me.RoundPanel2.Size = New System.Drawing.Size(1013, 324)
        Me.RoundPanel2.TabIndex = 1
        '
        'TrackBar2_Addition
        '
        Me.TrackBar2_Addition.BackColor = System.Drawing.Color.LightGray
        Me.TrackBar2_Addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar2_Addition.ForeColor = System.Drawing.Color.Black
        Me.TrackBar2_Addition.Location = New System.Drawing.Point(419, 277)
        Me.TrackBar2_Addition.Name = "TrackBar2_Addition"
        Me.TrackBar2_Addition.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar2_Addition.TabIndex = 18
        Me.TrackBar2_Addition.Text = "+"
        Me.TrackBar2_Addition.UseVisualStyleBackColor = False
        '
        'TrackBar2_Subtraction
        '
        Me.TrackBar2_Subtraction.BackColor = System.Drawing.Color.LightGray
        Me.TrackBar2_Subtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar2_Subtraction.ForeColor = System.Drawing.Color.Black
        Me.TrackBar2_Subtraction.Location = New System.Drawing.Point(67, 277)
        Me.TrackBar2_Subtraction.Name = "TrackBar2_Subtraction"
        Me.TrackBar2_Subtraction.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar2_Subtraction.TabIndex = 17
        Me.TrackBar2_Subtraction.Text = "-"
        Me.TrackBar2_Subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrackBar2_Subtraction.UseVisualStyleBackColor = False
        '
        'TrackBar3_Addition
        '
        Me.TrackBar3_Addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar3_Addition.ForeColor = System.Drawing.Color.Black
        Me.TrackBar3_Addition.Location = New System.Drawing.Point(914, 277)
        Me.TrackBar3_Addition.Name = "TrackBar3_Addition"
        Me.TrackBar3_Addition.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar3_Addition.TabIndex = 16
        Me.TrackBar3_Addition.Text = "+"
        Me.TrackBar3_Addition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrackBar3_Addition.UseVisualStyleBackColor = True
        '
        'TrackBar3_Subtraction
        '
        Me.TrackBar3_Subtraction.BackColor = System.Drawing.Color.LightGray
        Me.TrackBar3_Subtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackBar3_Subtraction.ForeColor = System.Drawing.Color.Black
        Me.TrackBar3_Subtraction.Location = New System.Drawing.Point(562, 277)
        Me.TrackBar3_Subtraction.Name = "TrackBar3_Subtraction"
        Me.TrackBar3_Subtraction.Size = New System.Drawing.Size(40, 30)
        Me.TrackBar3_Subtraction.TabIndex = 15
        Me.TrackBar3_Subtraction.Text = "-"
        Me.TrackBar3_Subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrackBar3_Subtraction.UseVisualStyleBackColor = False
        '
        'TrackBar3
        '
        Me.TrackBar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrackBar3.Location = New System.Drawing.Point(608, 277)
        Me.TrackBar3.Maximum = 30
        Me.TrackBar3.Minimum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(300, 45)
        Me.TrackBar3.TabIndex = 14
        Me.TrackBar3.Value = 3
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrackBar2.Location = New System.Drawing.Point(113, 277)
        Me.TrackBar2.Maximum = 30
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(300, 45)
        Me.TrackBar2.TabIndex = 13
        Me.TrackBar2.Value = 3
        '
        'Chart_UPH
        '
        Me.Chart_UPH.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.Chart_UPH.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart_UPH.Legends.Add(Legend2)
        Me.Chart_UPH.Location = New System.Drawing.Point(486, 10)
        Me.Chart_UPH.Name = "Chart_UPH"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart_UPH.Series.Add(Series2)
        Me.Chart_UPH.Size = New System.Drawing.Size(516, 256)
        Me.Chart_UPH.TabIndex = 1
        Me.Chart_UPH.Text = "Chart3"
        '
        'Chart_Tossing
        '
        Me.Chart_Tossing.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.Chart_Tossing.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart_Tossing.Legends.Add(Legend3)
        Me.Chart_Tossing.Location = New System.Drawing.Point(-3, 10)
        Me.Chart_Tossing.Name = "Chart_Tossing"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart_Tossing.Series.Add(Series3)
        Me.Chart_Tossing.Size = New System.Drawing.Size(516, 256)
        Me.Chart_Tossing.TabIndex = 0
        Me.Chart_Tossing.Text = "Chart2"
        '
        'frmRunInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 660)
        Me.Controls.Add(Me.RoundPanel2)
        Me.Controls.Add(Me.RoundPanel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRunInfo"
        Me.ShowInTaskbar = False
        Me.RoundPanel1.ResumeLayout(False)
        Me.RoundPanel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Yield, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundPanel2.ResumeLayout(False)
        Me.RoundPanel2.PerformLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_UPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Tossing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundPanel1 As BZ.UI.RoundPanel
    Friend WithEvents RoundPanel2 As BZ.UI.RoundPanel
    Friend WithEvents Chart_Yield As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_UPH As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_Tossing As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar3_Addition As System.Windows.Forms.Button
    Friend WithEvents TrackBar3_Subtraction As System.Windows.Forms.Button
    Friend WithEvents TrackBar2_Addition As System.Windows.Forms.Button
    Friend WithEvents TrackBar2_Subtraction As System.Windows.Forms.Button
    Friend WithEvents TrackBar1_Addition As System.Windows.Forms.Button
    Friend WithEvents TrackBar1_Subtraction As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
