'Name:      Photo Workshop
'Purpose:   Calculate gross pay and taxes withheld in order to display an employee's net pay
'Author:      Mike Schreiber on 09/09/2016

Option Strict On

Public Class frmMain
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblGross.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'this will close the program
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'this will calculate the net pay by using hours worked times the pay rate.  This amount gross income and tax withholding amounts 
        'will calculate the Net pay by subtracting the total tax withholding from the gross

        lblGrossTotal.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "Fixed")
        lblFwtTotal.Text = Format(Val(lblGrossTotal.Text) * 0.2, "Fixed")
        lblFicaTotal.Text = Format(Val(lblGrossTotal.Text) * 0.08, "Fixed")
        lblStateTotal.Text = Format(Val(lblGrossTotal.Text) * 0.03, "Fixed")
        lblNetTotal.Text = Format(Val(lblGrossTotal.Text) - Val(lblFwtTotal.Text) - Val(lblFicaTotal.Text) - Val(lblStateTotal.Text), "Fixed")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this will clear the text boxes and lbl totals 
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPayRate.Text = String.Empty
        lblGrossTotal.Text = String.Empty
        lblFwtTotal.Text = String.Empty
        lblFicaTotal.Text = String.Empty
        lblStateTotal.Text = String.Empty
        lblNetTotal.Text = String.Empty

        'this will place the focus back on the name text box
        txtHours.Focus()




    End Sub


End Class
