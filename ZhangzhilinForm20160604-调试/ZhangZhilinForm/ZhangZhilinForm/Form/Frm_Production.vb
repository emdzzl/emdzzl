Imports BZ.UI
Imports System
Imports System.Math
Imports System.Threading

Public Class frmProduction 
    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = ChildFrmOffsetPoint
            .Size = New Size(1020, 660)
            .BackColor = Color.White
        End With
    End Sub
End Class