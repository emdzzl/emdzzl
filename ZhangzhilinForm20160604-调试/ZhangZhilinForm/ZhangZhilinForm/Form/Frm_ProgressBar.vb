Public Class frmProgressBar
    Public Sub IsShowProgresBar(IsShow As Boolean)
        If IsShow Then
            If Not Me.Visible Then
                Me.Show()
            End If
        Else
            If Me.Visible Then
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Public Sub SetValueProgressBar(Value As Int32)
        If Value >= 0 And Value <= 100 Then
            InitProgressBar.Value = Value
        End If
    End Sub
End Class