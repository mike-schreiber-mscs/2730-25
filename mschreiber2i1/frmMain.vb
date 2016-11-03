'Name: String Methods
'Purpose: manipulation of string data
'Author: Mike Schreiber On 11/01/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        '03 Insert/Remove 
        Dim strWord As String = txtBox03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord


        '04 Remove
        Dim strItem As String = txtBox04.Text
        Dim strColor As String

        strColor = strItem.ToUpper.Substring(2, 4)
        lbl04.Text = strColor


        '05a Length
        Dim strMsg As String = txtBox05a.Text

        strMsg = strMsg.Length.ToString
        lbl05a.Text = strMsg


        '05b Trim  
        Dim strState As String = txtBox05b.Text

        strState = strState.Trim
        lbl05b.Text = strState


        '05c Remove / insert
        Dim strWord2 As String = txtBox05c.Text
        strWord2 = strWord2.Remove(1, 1)
        strWord2 = strWord2.Insert(1, "rit")
        lbl05c.Text = strWord2


        '05d Insert
        Dim strWord3 As String = txtBox05d.Text
        strWord3 = strWord3.Insert(0, "Mon")
        lbl05d.Text = strWord3


        '05e Pad
        Dim strPay As String
        Dim dblPay As Double
        Double.TryParse(txtBox05e.Text, dblPay)
        strPay = dblPay.ToString("N2").PadLeft(10, "*"c)
        lbl05e.Text = strPay


        '06 Remove 
        Dim strAmount As String = txtBox06.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06.Text = strAmount


        '07 Contains
        Dim strAddress As String = txtBox07.Text
        Dim blnIsContained As Boolean

        blnIsContained = strAddress.ToUpper.Contains("JEFFERSON STREET")

        If blnIsContained = True Then
            lbl07.Text = "ST Found"
        Else
            lbl07.Text = "ST Not Found"
        End If


        '12 Len/Remove
        Dim strTaxRate As String = txtBox12.Text
        Dim dblTaxRate As Double
        Dim intNumChar As Integer

        intNumChar = strTaxRate.Length
        strTaxRate = strTaxRate.Remove(intNumChar - 2, 2)

        Double.TryParse(strTaxRate, dblTaxRate)
        dblTaxRate = (dblTaxRate / 100) * 1000
        strTaxRate = dblTaxRate.ToString
        lbl12.Text = strTaxRate

        '13 Like
        Dim strZipCode As String = txtBox13.Text

        If strZipCode Like "605##" Then
            lbl13.Text = "Shipping $25"

        ElseIf strZipCode Like "606##" Then
            lbl13.Text = "Shipping $30"
        Else
            lbl13.Text = "Invalid Zip"
        End If
    End Sub
End Class
