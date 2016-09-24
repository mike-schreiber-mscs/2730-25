'Name:       Cranston Berries
'Purpose:   Calculate the projected sales for upcoming year
'Author:     Mike Schreiber on 08/31/2016


Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate the projected sales for each type of berry

        lblProjStraw.Text = Format(Val(txtProjIncrease.Text) * Val(txtStraw.Text) + Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format(Val(txtProjIncrease.Text) * Val(txtBlue.Text) + Val(txtBlue.Text), "currency")
        lblProjRas.Text = Format(Val(txtProjIncrease.Text) * Val(txtRas.Text) + Val(txtRas.Text), "currency")
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'make buttons invisible for printing
        btnCalc.Visible = False
        btnPrint.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False

        'print the form to preview
        PrintForm1.Print()

        'make buttons visible after printing
        btnCalc.Visible = True
        btnPrint.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
    End Sub
End Class
