'Name:      Average Test Scores
'Purpose:   Calculate the average 3 test scores
'Author:      Mike Schreiber on 09/08/2016

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'calculates test score 1, 2, & 3 by adding them together and then dividing by 3
        lblAverageTestScore.Text = Format((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3, "fixed")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this will clear the form and put the focus back to Test score 1 txt box
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblAverageTestScore.Text = String.Empty

        txtScore1.Focus()


    End Sub
End Class
