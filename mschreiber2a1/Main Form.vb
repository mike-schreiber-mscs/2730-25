' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Mike Schreiber on 09/23/2016

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    'Private strClerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' calculate number of items sold and total sales
        Const decItem_Price As Decimal = 0.5D
        Const decTax_Rate As Decimal = 0.02D

        'get the salesclerk name
        Const strPrompt As String = "Salesclerk name:"
        Const strTitle As String = "Name Entry"

        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        ''assign name to class strclerk class level variable
        strClerk = InputBox(strPrompt, strTitle, strClerk)



        'calculate total number of items sold
        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)

        'calculate total items sold
        intTotalItems = intDonuts + intMuffins

        'calculate the subtotal
        decSubtotal = intTotalItems * decItem_Price

        'calc sales tax
        decSalesTax = decTax_Rate * decSubtotal

        'calc total sales
        decTotalSales = decSalesTax + decSubtotal

        'display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        'display tax and salesclerk's name
        lblMsg.Text = "The sales tax was " &
                      decSalesTax.ToString("C2") & "." &
                      ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ''get the salesclerk name
        'Const strPrompt As String = "Salesclerk name:"
        'Const strTitle As String = "Name Entry"

        ''assign name to class strclerk class level variable
        'strClerk = InputBox(strPrompt, strTitle)

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtDonuts.TextChanged, txtMuffins.TextChanged

        'clear the total items, total sales, and message
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty

    End Sub
End Class
