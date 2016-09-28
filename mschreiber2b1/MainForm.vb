'Name:       Cranston Berries
'Purpose:   Calculate the projected sales for upcoming year
'Author:     Mike Schreiber on 09/28/2016


Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'define variables
        Dim decProjSalesIncrease As Decimal
        Dim decStrawCurrentSales As Decimal
        Dim decBlueCurrentSales As Decimal
        Dim decRaspCurrentSales As Decimal

        'calculate the projected sales for each type of berry
        Decimal.TryParse(txtProjIncrease.Text, decProjSalesIncrease)
        Decimal.TryParse(txtStraw.Text, decStrawCurrentSales)
        Decimal.TryParse(txtBlue.Text, decBlueCurrentSales)
        Decimal.TryParse(txtRas.Text, decRaspCurrentSales)

        Dim declblStrawProjSalesIncrease As Decimal
        Dim declblBlueProjSalesIncrease As Decimal
        Dim declblrasProjSalesIncrease As Decimal
        Dim declblTotalStrawProjSales As Decimal
        Dim declblTotalBlueProjSales As Decimal
        Dim declblTotalRasProjSales As Decimal

        declblStrawProjSalesIncrease = decProjSalesIncrease * decStrawCurrentSales
        declblBlueProjSalesIncrease = decProjSalesIncrease * decBlueCurrentSales
        declblrasProjSalesIncrease = decProjSalesIncrease * decRaspCurrentSales

        declblTotalStrawProjSales = declblStrawProjSalesIncrease + decStrawCurrentSales
        declblTotalBlueProjSales = declblBlueProjSalesIncrease + decBlueCurrentSales
        declblTotalRasProjSales = declblrasProjSalesIncrease + decRaspCurrentSales


        lblProjStraw.Text = Convert.ToString(declblTotalStrawProjSales)
        lblProjBlue.Text = Convert.ToString(declblTotalBlueProjSales)
        lblProjRas.Text = Convert.ToString(declblTotalRasProjSales)

        'lblProjStraw.Text = Format(Val(txtProjIncrease.Text) * Val(txtStraw.Text) + Val(txtStraw.Text), "currency")
        'lblProjBlue.Text = Format(Val(txtProjIncrease.Text) * Val(txtBlue.Text) + Val(txtBlue.Text), "currency")
        'lblProjRas.Text = Format(Val(txtProjIncrease.Text) * Val(txtRas.Text) + Val(txtRas.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the form's user entries
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRas.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRas.Text = String.Empty
        txtProjIncrease.Text = String.Empty

        'place the focus to the projected increase text box
        txtProjIncrease.Focus()
        txtProjIncrease.Text = "0.05"

    End Sub

    Private Sub btnRetirement_Click(sender As Object, e As EventArgs) Handles btnRetirement.Click
        'opens the retirement form
        frmRetirement.Show()

    End Sub

    Private Sub txtProjIncrease_TextChanged(sender As Object, e As EventArgs) Handles txtProjIncrease.TextChanged

    End Sub
End Class
