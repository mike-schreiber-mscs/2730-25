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
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
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
        Loop While i <= 20


    End Sub

    Private Sub btnPostUntil_Click(sender As Object, e As EventArgs) Handles btnPostUntil.Click
        ' uses a post do until to count to 20

        Dim i As Integer = 2
        lblEven.Text = "Posttest Do Until" & ControlChars.NewLine
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i = 22

    End Sub

    Private Sub btnPreFor_Click(sender As Object, e As EventArgs) Handles btnPreFor.Click
        ' uses a pre for next to count to 20

        Dim i As Integer = 2
        lblEven.Text = "Pretest For Next" & ControlChars.NewLine

        For i = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i
    End Sub

    Private Sub btnSumWhile_Click(sender As Object, e As EventArgs) Handles btnSumWhile.Click
        'clears controls
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty
        txtBoxNum.Text = String.Empty

        'Calculates average
        Const strPrompt As String =
            "Enter a number" & ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAverage As Double

        'sets strNum to InputBox
        strNum = InputBox(strPrompt, strTitle, "0")

        Do While strNum <> String.Empty

            Int32.TryParse(strNum, intNum)

            'display the input in the text list
            txtBoxNum.Text = txtBoxNum.Text & intNum.ToString &
                ControlChars.NewLine

            'update the count
            intCount = intCount + 1
            intSum = intNum + intSum

            'update control variable
            strNum = InputBox(strPrompt, strTitle, "0")

            'end loop
        Loop

        lblCount.Text = intCount.ToString

        'check to avoid dividing by 0
        If intCount > 0 Then
            dblAverage = intSum / intCount
            lblAverage.Text = dblAverage.ToString("N2")
        Else
            lblAverage.Text = "NA"
        End If
    End Sub

    Private Sub btnSumUntil_Click(sender As Object, e As EventArgs) Handles btnSumUntil.Click
        'clears controls
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty
        txtBoxNum.Text = String.Empty

        'Calculates average
        Const strPrompt As String =
            "Enter a number" & ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAverage As Double


        strNum = InputBox(strPrompt, strTitle, "0")


        'start loop and repeat until input is empty
        Do

            'convert string to integer
            Int32.TryParse(strNum, intNum)



            'display the input in the text list
            txtBoxNum.Text = txtBoxNum.Text & intNum.ToString &
                ControlChars.NewLine

            'update the count
            intCount = intCount + 1
            intSum = intNum + intSum

            lblCount.Text = intCount.ToString

            'check to avoid dividing by 0
            If intCount > 0 Then
                dblAverage = intSum / intCount
                lblAverage.Text = dblAverage.ToString("N2")
            Else
                lblAverage.Text = "NA"
            End If

            'update control variable
            strNum = InputBox(strPrompt, strTitle, "0")

        Loop Until strNum = String.Empty

    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click

        'clears controls
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty
        txtBoxNum.Text = String.Empty

        'Calculates average
        Const strPrompt As String =
            "Enter a number" & ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Const strPrompt2 As String = "Enter Quantity of Numbers"
        Dim strCounter As String
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAverage As Double
        Dim intCounter As Integer

        'first pop up to ask user for number of entries
        strCounter = InputBox(strPrompt2)

        'check for valid user input 
        If strCounter = "" Then
            intNum = 0
        Else
            'Convert String to integer
            Int32.TryParse(strCounter, intCounter)
        End If

        'ask for user input
        strNum = InputBox(strPrompt, strTitle, "0")

        'check for valid user input 
        If strNum = "" Then
            intNum = 0
        Else
            'Convert String to integer
            Int32.TryParse(strNum, intNum)
        End If

        'start loop 
        For intCounter = 1 To intCount

            'display the input in the text list
            txtBoxNum.Text = txtBoxNum.Text & intNum.ToString &
                ControlChars.NewLine

            'update the count
            intCount = intCount + 1
            intSum = intNum + intSum
            strCounter = InputBox(strPrompt2, strTitle, "0")
            strNum = InputBox(strPrompt, strTitle, "0")
        Next

        lblCount.Text = intCount.ToString

            'check to avoid dividing by 0
            If intCount > 0 Then
                dblAverage = intSum / intCount
                lblAverage.Text = dblAverage.ToString("N2")
            Else
                lblAverage.Text = "NA"
            End If



    End Sub
End Class
