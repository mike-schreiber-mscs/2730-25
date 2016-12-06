'Name: mschreiber3e1
'Purpose: Displays counts of salespeople commissions
'Author: Mike Schreiber on Dec 5 2016

Option Strict On
Option Explicit On
Option Infer On


Public Class Form1

    'array to populate commission values
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750,
           90, 150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}

    'sub procedure that iterates thru the intcommission array and populates the lbl with values

    Private Sub DisplayCommissions()
        Dim intCount1 As Integer
        Dim intHighSub As Integer = intCommission.GetUpperBound(0)

        Do While intCount1 <= intHighSub
            lblCommissionValues.Text &= intCommission(intCount1).ToString & ", "
            intCount1 += 1
        Loop

        If lblCommissionValues.Text.EndsWith(", ") Then
            lblCommissionValues.Text = lblCommissionValues.Text.Substring(0, lblCommissionValues.Text.Length - 2)
        End If
    End Sub

    'form load calls DisplayCommissions sub procedure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
    End Sub

    'calculates the count value by interating thru the intcommissions value array and compares search value to 
    'each array element  Then increments the counter by 1 each time a match happens

    Private Function CountValue(ByVal intSearchValue As Integer) As Integer
        Dim intCount1 As Integer
        Dim intCount2 As Integer
        Dim intMatchCount As Integer

        Do While intCount2 <= intCommission.GetUpperBound(0)
            'THIS IS NOT CORRECT... NEED SOMETHING IN HERE TO ASSIGN EACH ARRAY ELEMENT BEFORE COMPARING
            If intSearchValue = intCommission(intCount1) Then
                intMatchCount += 1
            Else
                intMatchCount = 1
            End If
            intCount2 += 1
        Loop

        Return intMatchCount
    End Function

    'text changed event Does not work. Returns 1.  NEED TO FIX FUNCTION AND RERUN
    Private Sub cboSearchValue_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValue.TextChanged
        Dim strInput As String = cboSearchValue.Text
        Dim intSearchValue As Integer
        Dim intCount As Integer

        'converts user input or comboBox selection into an integer
        Integer.TryParse(strInput, intSearchValue)

        'Checks for valid user input and if so... calls the CountValue Function otherwise it shows a message to user
        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            lblSearchCount.Text = CountValue(intCount).ToString

        Else
            MessageBox.Show("Please enter an integer between 0 and 1000", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class

