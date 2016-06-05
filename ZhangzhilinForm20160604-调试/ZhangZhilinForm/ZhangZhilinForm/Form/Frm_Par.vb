Imports BZ.UI
Imports System.Math

Public Class frmPar 
    Private Sub frmPar_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = ChildFrmOffsetPoint
            .Size = New Size(1020, 660)
            .BackColor = Color.White
        End With

        '初始化DataGridView,并将读取数据到DataGridView
        ReadAxisPar()
        InitDataGridViewAxisPar(Me.DataGridViewAxisPar)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If bIsEnableParModify Then
            TableLayoutPanel1.Enabled = True
            TableLayoutPanel2.Enabled = True
            TableLayoutPanel3.Enabled = True
            'TableLayoutPanel4.Enabled = True
            Btn_ParSave.Enabled = True
            Btn_ParBackup.Enabled = True
            Btn_ParKeyboard.Enabled = True
            Btn_DefautPar.Enabled = True 

            Me.TextBox219.Enabled = True
            Me.TextBox220.Enabled = True
            Me.TextBox221.Enabled = True
            Me.TextBox222.Enabled = True
            Me.TextBox223.Enabled = True
            Me.TextBox224.Enabled = True
            Me.TextBox225.Enabled = True
            Me.TextBox226.Enabled = True
            Me.TextBox227.Enabled = True
            Me.TextBox228.Enabled = True
            Me.TextBox229.Enabled = True
            Me.TextBox230.Enabled = True
            Me.TextBox231.Enabled = True
            Me.TextBox232.Enabled = True
            Me.TextBox233.Enabled = True
            Me.TextBox234.Enabled = True
            Me.TextBox235.Enabled = True
            Me.TextBox236.Enabled = True
        Else
            TableLayoutPanel1.Enabled = False
            TableLayoutPanel2.Enabled = False
            TableLayoutPanel3.Enabled = False
            'TableLayoutPanel4.Enabled = False
            Btn_ParSave.Enabled = False
            Btn_ParBackup.Enabled = False
            Btn_ParKeyboard.Enabled = False
            Btn_DefautPar.Enabled = False 

            Me.TextBox219.Enabled = False
            Me.TextBox220.Enabled = False
            Me.TextBox221.Enabled = False
            Me.TextBox222.Enabled = False
            Me.TextBox223.Enabled = False
            Me.TextBox224.Enabled = False
            Me.TextBox225.Enabled = False
            Me.TextBox226.Enabled = False
            Me.TextBox227.Enabled = False
            Me.TextBox228.Enabled = False
            Me.TextBox229.Enabled = False
            Me.TextBox230.Enabled = False
            Me.TextBox231.Enabled = False
            Me.TextBox232.Enabled = False
            Me.TextBox233.Enabled = False
            Me.TextBox234.Enabled = False
            Me.TextBox235.Enabled = False
            Me.TextBox236.Enabled = False
        End If
        'Me.Timer.Enabled = False
    End Sub 

    Private Sub Btn_ParEnable_Click(sender As Object, e As EventArgs) Handles Btn_ParEnable.Click
        If bIsLoginFromOpen Then Exit Sub
        frmLogin.Show(frmMain)
    End Sub
     
    Private Sub btnAxisParSave_Click(sender As Object, e As EventArgs) Handles btnAxisParSave.Click
        '将参数保存
        DataGridViewTODB()

        '重新更新参数到界面上
        ReadAxisPar()
        InitDataGridViewAxisPar(Me.DataGridViewAxisPar)
    End Sub

    Private Sub btnAxisParAllow_Click(sender As Object, e As EventArgs) Handles btnAxisParAllow.Click
        DataGridViewAxisPar.ReadOnly = False
    End Sub
End Class