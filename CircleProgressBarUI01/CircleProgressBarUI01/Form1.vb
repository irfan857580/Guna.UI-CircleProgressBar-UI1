Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaCircleProgressBar1.Increment(1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        GunaCircleProgressBar2.Increment(1)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        GunaCircleProgressBar3.Increment(1)
    End Sub

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch1.CheckedChanged
        GunaCircleProgressBar1.Animated = GunaSwitch1.Checked
        GunaCircleProgressBar2.Animated = GunaSwitch1.Checked
        GunaCircleProgressBar3.Animated = GunaSwitch1.Checked
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        GunaCircleProgressBar1.Value = 30
        GunaCircleProgressBar2.Value = 50
        GunaCircleProgressBar3.Value = 20
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub
End Class
