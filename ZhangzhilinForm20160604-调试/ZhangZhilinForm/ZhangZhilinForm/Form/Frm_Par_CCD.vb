Imports BZ.UI

Public Class frmParCCD 
    Private Sub frmParCCD_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .Location = ChildFrmOffsetPoint
            .Size = New Size(1020, 660)
            .BackColor = Color.White
        End With
    End Sub
End Class