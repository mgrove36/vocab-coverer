Class MainWindow
    Sub Window_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseDown
        If e.ChangedButton = MouseButton.Left Then
            DragMove()
        End If
    End Sub
End Class
