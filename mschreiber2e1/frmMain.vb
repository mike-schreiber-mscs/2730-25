'Name:  mschreiber2e1 AndAlso, OrElse
'Purpose: Decides whether or not the customer receives free shipping based on credit card and purchase amount
' Part 2 calculates commission percentage based on sales And ID
'Author: Mike Schreiber on October 12, 2016

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'this will exit the program

        Me.Close()
    End Sub

    Private Sub btnCalculateAnd_Click(sender As Object, e As EventArgs) Handles btnCalculateAnd.Click
        'calculates free shipping if Savannah credit card is  used and if order amount >100
        'test
        Dim dblShippingAmount As Double
        Dim dblOrderAmount As Double
        Dim strCreditCardUsed As String
        Double.TryParse(txtOrderAmount.Text, dblOrderAmount)

        strCreditCardUsed = txtCreditCard.Text

        If (dblOrderAmount > 100 OrElse dblOrderAmount = 100) AndAlso strCreditCardUsed.ToUpper = "Y" Then
            dblShippingAmount = 0
            lblShippingAmount.Text = dblShippingAmount.ToString("C2")
        Else
            dblShippingAmount = 9
            lblShippingAmount.Text = dblShippingAmount.ToString("C2")
        End If
    End Sub

    Private Sub txtOrderAmount_TextChanged(sender As Object, e As EventArgs) _
        Handles txtOrderAmount.TextChanged, txtCreditCard.TextChanged
        'clears the shipping lable if a text value is changed in one of the input textboxes
        lblShippingAmount.Text = String.Empty
    End Sub

    Private Sub btnCalculateOr_Click(sender As Object, e As EventArgs) Handles btnCalculateOr.Click
        'calculates shipping charge if Savannah credit card is not used or if order amount < 100

        Dim dblShippingAmount As Double
        Dim dblOrderAmount As Double
        Dim strCreditCardUsed As String
        Double.TryParse(txtOrderAmount.Text, dblOrderAmount)

        strCreditCardUsed = txtCreditCard.Text

        If dblOrderAmount < 100 OrElse strCreditCardUsed.ToUpper <> "Y" Then
            dblShippingAmount = 9
            lblShippingAmount.Text = dblShippingAmount.ToString("C2")
        Else
            dblShippingAmount = 0
            lblShippingAmount.Text = dblShippingAmount.ToString("C2")
        End If
    End Sub
End Class
