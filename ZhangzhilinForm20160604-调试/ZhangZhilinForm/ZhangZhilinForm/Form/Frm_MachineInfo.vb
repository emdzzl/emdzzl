Imports BZ.UI

Public Class frmMachineInfo 
    Private Sub frmMachineInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = ChildFrmOffsetPoint
            .Size = New Size(1020, 660)
            .BackColor = Color.White
        End With
    End Sub
End Class