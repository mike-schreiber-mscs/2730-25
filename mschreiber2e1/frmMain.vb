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

    Private Sub btnCalculateEqual_Click(sender As Object, e As EventArgs) Handles btnCalculateEqual.Click
        'this will calculate a salesperson's monthly commission amount, if monthly sales amount is = or > than 25000 and commission id = a1 b2 or c3

        Dim strID As String
        Dim dblMonthlySales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblMonthlySales)
        strID = txtID.Text


        If (strID.ToUpper = "A1" OrElse strID.ToUpper = "B2" OrElse strID.ToUpper = "C3") AndAlso
                (dblMonthlySales = 25000 OrElse dblMonthlySales > 25000) Then
            dblCommission = 0.15
            lblCommissionAmount.Text = dblCommission.ToString("P2")
        Else
            dblCommission = 0.12
            lblCommissionAmount.Text = dblCommission.ToString("P2")
        End If
    End Sub

    Private Sub btnCalculateNotEqual_Click(sender As Object, e As EventArgs) Handles btnCalculateNotEqual.Click
        'this will calculate a salesperson's monthly commission amount, if monthly sales amount and commission id not equalling A1, B2, C3 or less than 25000 

        Dim strID As String
        Dim dblMonthlySales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblMonthlySales)
        strID = txtID.Text


        If (strID.ToUpper <> "A1" AndAlso strID.ToUpper <> "B2" AndAlso strID.ToUpper <> "C3") OrElse
                dblMonthlySales < 25000 Then
            dblCommission = 0.12
            lblCommissionAmount.Text = dblCommission.ToString("P2")
        Else
            dblCommission = 0.15
            lblCommissionAmount.Text = dblCommission.ToString("P2")
        End If
    End Sub

    Private Sub ClearLabels2(sender As Object, e As EventArgs) _
        Handles txtID.TextChanged, txtSales.TextChanged
        'this will clear the commission amount result lable if new values are entered in the text boxes
        lblCommissionAmount.Text = String.Empty
    End Sub
End Class
