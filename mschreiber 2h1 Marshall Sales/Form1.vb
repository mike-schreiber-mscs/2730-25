'Name: Marshall Sales
'Purpose:  Calculate total sales income 
'Author: Mike Schreiber on Oct 26, 2016

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        'this will calculate the total owed to salesperson using if then statements

        Dim dblSales As Double
        Dim dblCommOnlyAmt As Double = 0.0
        Dim dblAddAmt As Double = 0.0
        Dim dblTotCommAmt As Double = 0.0
        Dim blnIsSalesOk As Boolean =
         Double.TryParse(txtBoxSales.Text, dblSales)

        lblCommOnlyAmt.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotCommAmt.Text = String.Empty


        If Not blnIsSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If blnIsSalesOk AndAlso dblSales < 1 Then
            dblCommOnlyAmt = 0.0
        End If

        If blnIsSalesOk AndAlso dblSales >= 1 AndAlso dblSales <= 6000 Then
            dblCommOnlyAmt = dblSales * 0.1
        End If

        If blnIsSalesOk AndAlso dblSales > 6000 AndAlso dblSales <= 30000 Then
            dblCommOnlyAmt = 120 + (dblSales - 6000) * 0.13
        End If

        If blnIsSalesOk AndAlso dblSales > 30000 Then
            dblCommOnlyAmt = 3120 + (dblSales - 30000) * 0.14
        End If

        If chkBox10Years.Checked Then
            dblAddAmt = dblAddAmt + 500
        End If

        If chkBoxTravel.Checked Then
            dblAddAmt = dblAddAmt + 700
        End If

        dblTotCommAmt = dblAddAmt + dblCommOnlyAmt

        If blnIsSalesOk Then
            lblCommOnlyAmt.Text = dblCommOnlyAmt.ToString("C2")
            lblAddAmt.Text = dblAddAmt.ToString("C2")
            lblTotCommAmt.Text = dblTotCommAmt.ToString("C2")
        End If

        txtBoxSales.Focus()

    End Sub

    Private Sub txtBoxSales_Enter(sender As Object, e As EventArgs) Handles txtBoxSales.Enter
        'selects all the text when textbox received focus

        txtBoxSales.SelectAll()
    End Sub

    Private Sub txtBoxSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel key
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtBoxSales.TextChanged, chkBox10Years.CheckedChanged, chkBoxTravel.CheckedChanged
        'clears the labels when a check box changes or new sales amount entered in text box. focus is then set to sales text box

        lblCommOnlyAmt.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotCommAmt.Text = String.Empty

        txtBoxSales.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form

        Me.Close()

    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        'this will calculate the total owed to salesperson using nested if then statements
        'DEBUG THIS SECTION (THE 6001 AND ABOVE DOES NOT WORK ASK PETER!)
        Dim dblSales As Double
        Dim dblCommOnlyAmt As Double = 0.0
        Dim dblAddAmt As Double = 0.0
        Dim dblTotCommAmt As Double = 0.0
        Dim blnIsSalesOk As Boolean =
         Double.TryParse(txtBoxSales.Text, dblSales)

        lblCommOnlyAmt.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotCommAmt.Text = String.Empty


        If Not blnIsSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If dblSales > 30000 Then
                dblCommOnlyAmt = 3120 + (dblSales - 30000) * 0.14
            Else
                If dblSales > 6000 Then
                    dblCommOnlyAmt = 120 + (dblSales - 6000) * 0.13
                Else
                    If dblSales >= 1 Then
                        dblCommOnlyAmt = dblSales * 0.1
                    Else
                        If dblSales < 1 Then
                            dblCommOnlyAmt = 0.0
                        End If
                    End If

                    If chkBox10Years.Checked Then
                        dblAddAmt = dblAddAmt + 500
                    End If

                    If chkBoxTravel.Checked Then
                        dblAddAmt = dblAddAmt + 700
                    End If

                    dblTotCommAmt = dblAddAmt + dblCommOnlyAmt

                    lblCommOnlyAmt.Text = dblCommOnlyAmt.ToString("C2")
                    lblAddAmt.Text = dblAddAmt.ToString("C2")
                    lblTotCommAmt.Text = dblTotCommAmt.ToString("C2")
                End If
            End If
        End If
    End Sub

    Private Sub btnIfElseIf_Click(sender As Object, e As EventArgs) Handles btnIfElseIf.Click
        'this will calculate the total owed to salesperson using  if else if then statements

        Dim dblSales As Double
        Dim dblCommOnlyAmt As Double = 0.0
        Dim dblAddAmt As Double = 0.0
        Dim dblTotCommAmt As Double = 0.0
        Dim blnIsSalesOk As Boolean =
         Double.TryParse(txtBoxSales.Text, dblSales)

        lblCommOnlyAmt.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotCommAmt.Text = String.Empty


        If Not blnIsSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If dblSales < 1 Then
                dblCommOnlyAmt = 0.0

            ElseIf dblSales <= 6000 Then
                dblCommOnlyAmt = dblSales * 0.1

            ElseIf dblSales <= 30000 Then
                dblCommOnlyAmt = 120 + (dblSales - 6000) * 0.13

            ElseIf dblSales > 30000 Then
                dblCommOnlyAmt = 3120 + (dblSales - 30000) * 0.14
            End If

            If chkBox10Years.Checked Then
                    dblAddAmt = dblAddAmt + 500
                End If

                If chkBoxTravel.Checked Then
                    dblAddAmt = dblAddAmt + 700
                End If

                dblTotCommAmt = dblAddAmt + dblCommOnlyAmt

                lblCommOnlyAmt.Text = dblCommOnlyAmt.ToString("C2")
                lblAddAmt.Text = dblAddAmt.ToString("C2")
                lblTotCommAmt.Text = dblTotCommAmt.ToString("C2")

            End If
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        'this will calculate the total owed to salesperson using  if else if then statements

        Dim dblSales As Double
        Dim dblCommOnlyAmt As Double = 0.0
        Dim dblAddAmt As Double = 0.0
        Dim dblTotCommAmt As Double = 0.0
        Dim blnIsSalesOk As Boolean =
         Double.TryParse(txtBoxSales.Text, dblSales)

        lblCommOnlyAmt.Text = String.Empty
        lblAddAmt.Text = String.Empty
        lblTotCommAmt.Text = String.Empty


        If Not blnIsSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Select Case dblSales

                Case < 1
                    dblCommOnlyAmt = 0.0

                Case 1 To 6000
                    dblCommOnlyAmt = dblSales * 0.1

                Case 6001 To 30000
                    dblCommOnlyAmt = 120 + (dblSales - 6000) * 0.13

                Case > 30000
                    dblCommOnlyAmt = 3120 + (dblSales - 30000) * 0.14
            End Select

            If chkBox10Years.Checked Then
                dblAddAmt = dblAddAmt + 500
            End If


            If chkBoxTravel.Checked Then
                dblAddAmt = dblAddAmt + 700
            End If

            dblTotCommAmt = dblAddAmt + dblCommOnlyAmt

            lblCommOnlyAmt.Text = dblCommOnlyAmt.ToString("C2")
            lblAddAmt.Text = dblAddAmt.ToString("C2")
            lblTotCommAmt.Text = dblTotCommAmt.ToString("C2")
        End If
    End Sub
End Class
