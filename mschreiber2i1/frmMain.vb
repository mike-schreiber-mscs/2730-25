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

        '05c Remove / insert START HERE





        '05d Insert
        '05e Pad
        '06 Remove
        '07 Contains
        '12 Len/Remove
        '13 Like






    End Sub
End Class
