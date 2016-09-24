Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        'Me.Close()
        frmStarWars.Show()
        tmrExit.Enabled = False




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tmrExit2_Tick(sender As Object, e As EventArgs) Handles tmrExit2.Tick
        frmToucan.Show()
        tmrExit2.Enabled = False

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles tmr3Exit.Tick
        Me.Close()

    End Sub
End Class
