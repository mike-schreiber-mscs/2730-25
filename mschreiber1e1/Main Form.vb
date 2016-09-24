'Name:      Tax Calculations
'Purpose:   Calculates annual property tax based on assessed value
'Author:    Mike Schreiber on 08/31/2016



Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate annual property tax
        lblTax.Text = (Val(taxAssessed.Text) / 100) * 1.5
        lblTax.Text = Format(lblTax.Text, "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears the assessed value and property tax
        lblTax.Text = String.Empty
        taxAssessed.Text = String.Empty
        'sends the focus back to Assessed value
        taxAssessed.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'print the annual tax amount

        btnCalc.Visible = False
        btnPrint.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False

        PrintForm1.Print()

        btnCalc.Visible = True
        btnPrint.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True

    End Sub

    Private Sub taxAssessed_TextChanged(sender As Object, e As EventArgs) Handles taxAssessed.TextChanged

    End Sub
End Class
