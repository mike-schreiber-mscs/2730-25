' Name:         Jetters Project
' Purpose:      Display the discount and total due
' Programmer:   Mike Schreiber on 10/19/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQuantity.TextChanged
        lblDiscountAmount.Text = String.Empty
        lblTotalAmountDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        End If

        If intQuantity < 20 AndAlso intQuantity > 15 Then
            dblRate = 0.025
        End If

        If intQuantity < 16 AndAlso intQuantity > 10 Then
            dblRate = 0.02
        End If

        If intQuantity > 0 AndAlso intQuantity < 10 Then
                dblRate = 0.00
            End If



        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscountAmount.Text = dblDiscount.ToString("C2")
        lblTotalAmountDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        'allows the text box to accept only numbers ,the  Backspace and decimal point
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel key
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        'allows the text box to accept only numbers or the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel key
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcNestedIf_Click(sender As Object, e As EventArgs) Handles btnCalcNestedIf.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        Else
            If intQuantity > 15 Then
                dblRate = 0.025
            Else
                If intQuantity > 10 Then
                    dblRate = 0.02
                Else
                    If intQuantity > 0 AndAlso intQuantity < 10 Then
                        dblRate = 0.00
                    End If
                End If
            End If
        End If
        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscountAmount.Text = dblDiscount.ToString("C2")
                    lblTotalAmountDue.Text = dblTotalDue.ToString("C2")
    End Sub
End Class
