'Name: Chapter 4 Lesson : If statements, message Boxes
'Purpose: Currency, Tea, Electric, Quotient
'Author: Mike Schreiber On 10/09/2016
Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form

        Me.Close()
    End Sub

    Private Sub btnConvertEqual_Click(sender As Object, e As EventArgs) Handles btnConvertEqual.Click
        'converts dollar to euro, pound, and rand

        Const dblEuroRate As Double = 0.9
        Const dblBritPoundRate As Double = 0.81
        Const dblSouthAfricanRandRate As Double = 13.79

        Dim dblAmericanDollar As Double
        Dim dblEuro As Double
        Dim dblBritPound As Double
        Dim dblSouthAfricanRand As Double

        If txtAmericanDollar.Text = String.Empty Then
            MessageBox.Show("Enter a dollar amount for American Dollar", "Currency Calculator",
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Double.TryParse(txtAmericanDollar.Text, dblAmericanDollar)
        End If

        dblEuro = dblAmericanDollar * dblEuroRate
        lblEuroValue.Text = dblEuro.ToString("C2")

        dblBritPound = dblAmericanDollar * dblBritPoundRate
        lblPoundValue.Text = dblBritPound.ToString("C2")

        dblSouthAfricanRand = dblAmericanDollar * dblSouthAfricanRandRate
        lblRandValue.Text = dblSouthAfricanRand.ToString("C2")
    End Sub

    Private Sub btnConvertNotEqual_Click(sender As Object, e As EventArgs) Handles btnConvertNotEqual.Click
        'converts dollar to euro, pound, and rand

        Const dblEuroRate As Double = 0.9
        Const dblBritPoundRate As Double = 0.81
        Const dblSouthAfricanRandRate As Double = 13.79

        Dim dblAmericanDollar As Double
        Dim dblEuro As Double
        Dim dblBritPound As Double
        Dim dblSouthAfricanRand As Double

        If txtAmericanDollar.Text <> String.Empty Then
            Double.TryParse(txtAmericanDollar.Text, dblAmericanDollar)

        Else
            MessageBox.Show("Enter a dollar amount for American Dollar", "Currency Calculator",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dblEuro = dblAmericanDollar * dblEuroRate
        lblEuroValue.Text = dblEuro.ToString("C2")

        dblBritPound = dblAmericanDollar * dblBritPoundRate
        lblPoundValue.Text = dblBritPound.ToString("C2")

        dblSouthAfricanRand = dblAmericanDollar * dblSouthAfricanRandRate
        lblRandValue.Text = dblSouthAfricanRand.ToString("C2")
    End Sub

    Private Sub btnCalculateTotalDue_Click(sender As Object, e As EventArgs) Handles btnCalculateTotalDue.Click
        'calculates total price of pounds purchased

        Dim dblPounds As Double
        Dim dblPricePerPound As Double
        Dim dblTotalDue As Double
        Dim dblshippingCharge As Double
        Dim dlgButton As DialogResult

        dblshippingCharge = 15

        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPricePerPound.Text, dblPricePerPound)

        If MessageBox.Show("Do you want to add shipping charges?", "Shipping",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            dblTotalDue = dblPricePerPound * dblPounds + dblshippingCharge
            lblTotalAmountDue.Text = dblTotalDue.ToString("C2")

        Else
            dblTotalDue = dblPounds * dblPricePerPound
            lblTotalAmountDue.Text = dblTotalDue.ToString("C2")
        End If
    End Sub

    Private Sub btnCalculateMonthlyBill_Click(sender As Object, e As EventArgs) Handles btnCalculateMonthlyBill.Click
        'calculates monthly bill

        Const dblChargePerUnit As Double = 0.13
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblMonthlyBill As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)

        If dblCurrent < dblPrevious OrElse
            txtCurrent.Text = String.Empty OrElse
            txtPrevious.Text = String.Empty Then
            MessageBox.Show("The current  reading must be larger than the previous", "Tri County Electric",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dblMonthlyBill = (dblCurrent - dblPrevious) * dblChargePerUnit
            lblTotalBill.Text = dblMonthlyBill.ToString("C2")
        End If

    End Sub

    Private Sub btnCalculateQuotient_Click(sender As Object, e As EventArgs) Handles btnCalculateQuotient.Click
        'calculates the quotient of two numbers

        Dim dblFirstNum As Double
        Dim dblSecondNum As Double
        Dim dblQuotient As Double
        Dim dblTemp As Double

        Double.TryParse(txtFirstNumber.Text, dblFirstNum)
        Double.TryParse(txtSecondNumber.Text, dblSecondNum)

        If dblSecondNum > dblFirstNum Then
            dblTemp = dblSecondNum
            dblSecondNum = dblFirstNum
            dblFirstNum = dblTemp
        End If

        If dblSecondNum = 0 Then
            MessageBox.Show("Cannot divide by 0", "Division Calculator",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            dblQuotient = dblFirstNum / dblSecondNum
            lblQuotientValue.Text = dblQuotient.ToString("N2")
        End If
    End Sub

    Private Sub txtAmericanDollar_TextChanged(sender As Object, e As EventArgs) Handles txtAmericanDollar.TextChanged
        'clears all the conversions for euro, pound, and rand when somehting new is entered in the american dollar text box

        lblEuroValue.Text = String.Empty
        lblPoundValue.Text = String.Empty
        lblRandValue.Text = String.Empty
    End Sub

    Private Sub ClearLables(sender As Object, e As EventArgs) _
        Handles txtPounds.TextChanged, txtPricePerPound.TextChanged
        'clears the total amount due label

        lblTotalAmountDue.Text = String.Empty
    End Sub

    Private Sub ClearMonthlyBillLabel(sender As Object, e As EventArgs) _
        Handles txtCurrent.TextChanged, txtPrevious.TextChanged

        lblTotalBill.Text = String.Empty
    End Sub

    Private Sub ClearQuotientLabel(sender As Object, e As EventArgs) _
        Handles txtFirstNumber.TextChanged, txtSecondNumber.TextChanged
        'clears the quotient value label if a new value is entered in the  text boxes

        lblQuotientValue.Text = String.Empty
    End Sub
End Class
