Public Class Form1
    '也可以支接使用 Handle 加上method, 來連結click Event
    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        AddHandler btnOri.Click, AddressOf btnOri_Click
    End Sub
    '要傳入兩個參數 sender:object (就是button)   , e:EventArg
    Private Sub btnOri_Click(sender As Object, e As EventArgs)
        MessageBox.Show("已加上Event了")
    End Sub
End Class
