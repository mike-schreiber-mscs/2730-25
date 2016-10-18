﻿' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Mike Schreiber on 10/04/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged, radAtrium.CheckedChanged, radKing.CheckedChanged, radStand.CheckedChanged,
        radQueen.CheckedChanged, chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTaxChg.Text = String.Empty
        lblResortFeeChg.Text = String.Empty
        lblTotalAmountDue.Text = String.Empty
        lblParkingChg.Text = String.Empty


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate and display the total room charge,
        'tax, total resort fee, and total due

        Const intMaxPerRoom As Integer = 6
        Const dblDaily_Room_Chg_Queen_Stand As Double = 225.5
        Const dblDaily_Room_Chg_Queen_Atrium As Double = 275.0
        Const dblDaily_Room_Chg_King_Stand As Double = 245.5
        Const dblDaily_Room_Chg_King_Atrium As Double = 325
        Const dblDaily_Parking_Fee As Double = 8.5
        Const dblTaxRate As Double = 0.1625
        Const dblResortFee As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum number of guests per room"

        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblParkingFee As Double
        Dim dblDailyRoomCharge As Double
        Dim dblTotalRoomCharge As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double

        'store input values
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        'calculate the number of guests
        intNumGuests = intAdults + intChildren

        'calculate the number of rooms required
        dblRoomsRequired = intNumGuests / intMaxPerRoom


        'determine whether number of rooms reserved rooms is
        'adequate and then either display a message or
        'calculate and display the charges
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            'calculate charges
            If radQueen.Checked Then
                If radStand.Checked Then
                    dblDailyRoomCharge = dblDaily_Room_Chg_Queen_Stand
                Else
                    dblDailyRoomCharge = dblDaily_Room_Chg_Queen_Atrium
                End If
            Else
                If radStand.Checked Then
                    dblDailyRoomCharge = dblDaily_Room_Chg_King_Stand
                Else
                    dblDailyRoomCharge = dblDaily_Room_Chg_King_Atrium
                End If
            End If
                dblTotalRoomCharge = intRoomsReserved *
                intNights * dblDailyRoomCharge

                dblTax = dblTotalRoomCharge * dblTaxRate

            dblTotalResortFee = intRoomsReserved *
                intNights * dblResortFee

            If chkParkingFee.Checked Then
                dblParkingFee = intNights * dblDaily_Parking_Fee
            End If

            dblTotalDue = dblTotalRoomCharge +
                dblTax + dblTotalResortFee + dblParkingFee

            'display charges
            lblRoomChg.Text = dblTotalRoomCharge.ToString("n2")
            lblTaxChg.Text = dblTax.ToString("n2")
            lblResortFeeChg.Text = dblTotalResortFee.ToString("n2")
            lblTotalAmountDue.Text = dblTotalDue.ToString("c2")
            lblParkingChg.Text = dblParkingFee.ToString("c2")
        End If
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
        ) Handles txtRooms.KeyPress, txtNights.KeyPress, txtAdults.KeyPress, txtChildren.KeyPress
        'allows the text box to accept only numbers and the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel key
            e.Handled = True
        End If
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        'select contents when text box receives focus

        txtRooms.SelectAll()

    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        'select contents when text box receives focus

        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        'select contents when text box receives focus

        txtChildren.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        'select contents when text box receives focus

        txtChildren.SelectAll()
    End Sub
End Class
