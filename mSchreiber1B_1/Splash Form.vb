Public Class frmSplash
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picIguanas.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        ' End the program
        Me.Close()

    End Sub
End Class
