<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUI
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
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.List_Sts = New System.Windows.Forms.ListBox()
        Me.Btn_Confirm = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Txt_UIPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Location = New System.Drawing.Point(206, 209)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(110, 41)
        Me.Btn_Cancel.TabIndex = 0
        Me.Btn_Cancel.Text = "取消(Cancel)"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'List_Sts
        '
        Me.List_Sts.FormattingEnabled = True
        Me.List_Sts.ItemHeight = 12
        Me.List_Sts.Location = New System.Drawing.Point(12, 12)
        Me.List_Sts.Name = "List_Sts"
        Me.List_Sts.Size = New System.Drawing.Size(560, 184)
        Me.List_Sts.TabIndex = 1
        '
        'Btn_Confirm
        '
        Me.Btn_Confirm.Location = New System.Drawing.Point(12, 209)
        Me.Btn_Confirm.Name = "Btn_Confirm"
        Me.Btn_Confirm.Size = New System.Drawing.Size(110, 41)
        Me.Btn_Confirm.TabIndex = 2
        Me.Btn_Confirm.Text = "确定(Confirm)"
        Me.Btn_Confirm.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Txt_UIPassword
        '
        Me.Txt_UIPassword.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Txt_UIPassword.Location = New System.Drawing.Point(375, 220)
        Me.Txt_UIPassword.Name = "Txt_UIPassword"
        Me.Txt_UIPassword.Size = New System.Drawing.Size(197, 30)
        Me.Txt_UIPassword.TabIndex = 3
        Me.Txt_UIPassword.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "取消时，请输入PDCACancel_ID解锁密码"
        Me.Label1.Visible = False
        '
        'frmUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_UIPassword)
        Me.Controls.Add(Me.Btn_Confirm)
        Me.Controls.Add(Me.List_Sts)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUI"
        Me.Text = "UI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents List_Sts As System.Windows.Forms.ListBox
    Friend WithEvents Btn_Confirm As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Txt_UIPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
