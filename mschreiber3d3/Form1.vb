'Name: mschreiber3d3 Arrays, subscripts, loops
'Purpose: Diplay the average sold
'Name: Mike Schreiber on 12/1/2016
Option Strict On
Option Explicit On
Option Infer On

Public Class Form1
    'declare arrays here as Private class
    Dim intDaysofMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31,
        30, 31, 30, 31}

    'intSold array declaration
    Dim intSold() As Integer = {250, 225, 193, 260}

    'wholesale retail array declaration
    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads starting value of 1 in Month Number 
        txtMonthNum.Text = "1"

        'adds wholesale prices to lst box
        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub

    End Sub

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        'display the number of days in the entered month
        Dim intMonthNum As Integer

        Integer.TryParse(txtMonthNum.Text, intMonthNum)


        If intMonthNum >= 1 AndAlso intMonthNum <= 12 Then
            lblNumDays.Text = intDaysofMonth(intMonthNum - 1).ToString
            lblNumDays.Focus()
            lblNumDays.Select()
        Else
            MessageBox.Show("Invalid Month Number", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        txtMonthNum.Focus()
        txtMonthNum.SelectAll()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the form
        Me.Close()

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        'for next loop
        Dim intTotal As Integer
        Dim intSub1 As Integer
        Dim dblAverage As Double
        Dim dblHighest As Double = intSold(0)
        Dim intHighSub As Integer = intSold.GetUpperBound(0)

        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty


        For intSub1 = 0 To intHighSub
            intTotal += intSold(intSub1)
        Next

        dblAverage = intTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString("N2")

        For intSub1 = 0 To intHighSub
            intTotal += intSold(intSub1)

            If intSold(intSub1) < dblAverage Then
                lblLessThanAvg.Text &= intSold(intSub1).ToString & ", "
            End If
        Next
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click

        'for each loop 
        Dim intTotal As Integer
        Dim intSub1 As Integer
        Dim dblAverage As Double
        Dim dblHighest As Double = intSold(0)
        Dim intHighSub As Integer = intSold.GetUpperBound(0)

        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty

        For Each intSub1 In intSold
            intTotal += intSub1
        Next

        dblAverage = intTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString("N2")

        For Each intSub1 In intSold
            intTotal += intSub1

            If intSub1 < dblAverage Then
                lblLessThanAvg.Text &= intSub1.ToString & ", "
            End If
        Next
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub


    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        'do while loop
        Dim intTotal As Integer
        Dim intSub1 As Integer
        Dim dblAverage As Double
        Dim dblHighest As Double = intSold(0)
        Dim intHighSub As Integer = intSold.GetUpperBound(0)


        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty


        'Calculate Total using loop
        Do While intSub1 <= intHighSub
            intTotal += intSold(intSub1)
            intSub1 += 1
        Loop


        'calculate average and display it
        dblAverage = intTotal / intSold.Length
        lblAvg.Text = dblAverage.ToString("N2")


        'find array values that are < average value using loop and if statement
        intSub1 = 0
        Do While intSub1 <= intHighSub
            If intSold(intSub1) < dblAverage Then
                lblLessThanAvg.Text &= intSold(intSub1).ToString & ", "
            End If
            intSub1 += 1
        Loop

        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        'asks user for input percentage of markup

        Const strPrompt As String = "Markup Rate"
        Const strTitle As String = "Enter Markup Rate"
        Dim strInput As String
        Dim dblMarkupRate As Double
        Dim dblSub As Double
        Dim dblRetail As Double


        strInput = InputBox(strPrompt, strTitle, "50")


        Double.TryParse(strInput, dblMarkupRate)
        dblMarkupRate = dblMarkupRate / 100

        For Each dblSub In dblWholesale
            dblRetail = dblSub * dblMarkupRate + dblSub
            lstRetail.Items.Add(dblRetail.ToString("N2").PadLeft(6))




        Next
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub

        lstRetail.Items.Clear()
    End Sub


End Class







