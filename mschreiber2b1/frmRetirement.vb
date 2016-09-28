'Name:       Cranston Berries
'Purpose:   Calculate the total annual contribution using employer and employee annual contribution amounts
'Author:     Mike Schreiber on 09/28/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmRetirement
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the form's user entries
        txtGrossPay.Text = String.Empty
        txtEmployeeContRate.Text = String.Empty
        txtEmployerContRate.Text = String.Empty
        lblEmployeeAnnualCont.Text = String.Empty
        lblEmployerAnnualCont.Text = String.Empty
        lblTotalCont.Text = String.Empty


        'place the focus to the projected increase text box
        txtGrossPay.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'calculates the annual contributions
        Dim decGrossPay As Decimal
        Dim decEmployeeContRate As Decimal
        Dim decEmployerContRate As Decimal
        Dim decEmployeeAnnualContRate As Decimal
        Dim decEmployerAnnualContRate As Decimal
        Dim decTotalCont As Decimal

        Decimal.TryParse(txtGrossPay.Text, decGrossPay)
        Decimal.TryParse(txtEmployeeContRate.Text, decEmployeeContRate)
        Decimal.TryParse(txtEmployerContRate.Text, decEmployerContRate)
        Decimal.TryParse(lblEmployeeAnnualCont.Text, decEmployeeAnnualContRate)
        Decimal.TryParse(lblEmployerAnnualCont.Text, decEmployerAnnualContRate)
        Decimal.TryParse(lblTotalCont.Text, decTotalCont)

        'Calculates the annual rates for employer and employee
        decEmployeeAnnualContRate = decGrossPay * 52 * decEmployeeContRate
        decEmployerAnnualContRate = decGrossPay * 52 * decEmployerContRate

        lblEmployeeAnnualCont.Text = Convert.ToString(decEmployeeAnnualContRate)
        lblEmployerAnnualCont.Text = Convert.ToString(decEmployerAnnualContRate)

        'Calculates the total annual contribution
        decTotalCont = decEmployerAnnualContRate + decEmployeeAnnualContRate

        lblTotalCont.Text = Convert.ToString(decTotalCont)

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtGrossPay.TextChanged, txtEmployeeContRate.TextChanged, txtEmployerContRate.TextChanged
        'this will clear the text boxes and labels if another values is entered by the user in any text box
        lblEmployeeAnnualCont.Text = String.Empty
        lblEmployerAnnualCont.Text = String.Empty
        lblTotalCont.Text = String.Empty

    End Sub
End Class