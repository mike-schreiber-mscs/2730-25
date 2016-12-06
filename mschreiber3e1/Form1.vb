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
        cboSearchValue.SelectedIndex = 0
    End Sub

    'calculates the count value by interating thru the intcommissions value array and compares search value to 
    'each array element  Then increments the counter by 1 each time a match happens

    Private Function CountValue(ByVal intSearchValue As Integer) As Integer

        Dim intCount2 As Integer
        Dim intMatchCount As Integer
        Dim intsub1 As Integer

        For intCount2 = 0 To intCommission.Length - 1
            intsub1 = intCommission(intCount2)
            If intsub1 = intSearchValue Then
                intMatchCount += 1
            End If
        Next intCount2

        Return intMatchCount
    End Function

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        'add a for loop that checks to see if the current array element is greater than intSearch Min and less than intSearch Max See Func Count Value above

    End Function




    Private Sub cboSearchValue_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValue.TextChanged
        Dim strInput As String = cboSearchValue.Text
        Dim intSearchValue As Integer


        'converts user input or comboBox selection into an integer
        Integer.TryParse(strInput, intSearchValue)

        'Checks for valid user input and if so... calls the CountValue Function otherwise it shows a message to user
        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            lblSearchCount.Text = CountValue(intSearchValue).ToString

        Else
            MessageBox.Show("Please enter an integer between 0 and 1000", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cboSearchRange_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRange.TextChanged
        lblSearchRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRange.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRange.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRange.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRange.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblSearchRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If

    End Sub
End Class

