Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intNums() As Integer = {2, 4, 6, 8, 10, 12}

        lblNumElements.Text = intNums.Length.ToString("N1")
        lblUpperBound.Text = (intNums.GetUpperBound(0) + 1).ToString("N1")

    End Sub
End Class
