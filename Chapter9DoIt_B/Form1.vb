Option Strict On
Option Explicit On
Option Infer On

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim strGuitars() As String = {"EC1000", "EC401B", "KM7", "Banshee"}

        'For Each loop populates listbox 1
        For Each strGuitar In strGuitars
            lstBoxForEach.Items.Add(strGuitar)
        Next strGuitar

        'Do while loop populates listbox 2
        Dim intHighSub As Integer = strGuitars.Length - 1
            Dim intSub As Integer
            Do While intSub <= intHighSub
                lstBoxDoLoop.Items.Add(strGuitars(intSub))
                intSub += 1
            Loop

        'For Next loop populates listbox 3

        For intSub2 As Integer = 0 To strGuitars.GetUpperBound(0)
            lstBoxForNext.Items.Add(strGuitars(intSub2))
        Next intSub2
    End Sub
End Class
