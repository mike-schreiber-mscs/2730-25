' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Mike Schreiber on 11/25/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    'converts user input inches to centimeters using a sub procedure
    Private Sub CalcCentimetersSub(ByVal dblMeasurement As Double,
                              ByRef dblResult As Double)
        dblResult = dblMeasurement * 2.54
    End Sub


    'converts user input centimeters to inches using a sub procedure
    Private Sub CalcInchesSub(ByVal dblMeasurement As Double,
                              ByRef dblResult As Double)
        dblResult = dblMeasurement / 2.54
    End Sub

    'converts user input inches to centimeters using a function
    Private Function CalcCentimetersFunc(ByVal dblMeasurement As Double) As Double

        Dim dblResult As Double = dblMeasurement * 2.54
        Return dblResult
    End Function

    'converts user input centimeters to inches using a sub procedure
    Private Function CalcInchesFunc(ByVal dblMeasurement As Double) As Double

        Dim dblResult As Double = dblMeasurement / 2.54
        Return dblResult
    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged,
        radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        'txtMeasurement.Text = dblMeasurement.ToString("n2")
        Double.TryParse(txtMeasurement.Text, dblMeasurement)



        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)

        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)

        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)

        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)

        End If

        'displays the converted result
        lblResult.Text = dblResult.ToString("n2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'uses 10.00 for the initial value for txtMeasreument.text
        txtMeasurement.Text = "10.00"
    End Sub
End Class

