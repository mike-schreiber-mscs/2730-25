'Name : Loops,sum, count
'Purpose:  creating different types of loops using pre and post test
'Author: Mike Schreiber on 11/14/2016
Option Strict On
Option Explicit On
Option Infer On

Public Class frmMain
    Private Sub btnPreDoWhile_Click(sender As Object, e As EventArgs) Handles btnPreDoWhile.Click
        ' uses a pretest do while to count to 20

        Dim i As Integer = 2
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop

    End Sub

    Private Sub btnPreDoUntil_Click(sender As Object, e As EventArgs) Handles btnPreDoUntil.Click
        ' uses a pretest do until to count to 20

        Dim i As Integer = 2
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Do Until i = 22
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPostWhile_Click(sender As Object, e As EventArgs) Handles btnPostWhile.Click
        ' uses a post do while to count to 20 START HERE

        Dim i As Integer = 2
        lblEven.Text = "Posttest Do While" & ControlChars.NewLine
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2

                End Sub

    Private Sub btnPostUntil_Click(sender As Object, e As EventArgs) Handles btnPostUntil.Click
        ' uses a post do until to count to 20


    End Sub

    Private Sub btnPreFor_Click(sender As Object, e As EventArgs) Handles btnPreFor.Click
        ' uses a pre for next to count to 20
    End Sub
End Class
