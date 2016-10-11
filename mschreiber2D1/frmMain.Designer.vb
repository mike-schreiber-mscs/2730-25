<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAmericanDollar = New System.Windows.Forms.TextBox()
        Me.grpBoxCurrencyConversion = New System.Windows.Forms.GroupBox()
        Me.lblRandValue = New System.Windows.Forms.Label()
        Me.lblPoundValue = New System.Windows.Forms.Label()
        Me.lblEuroValue = New System.Windows.Forms.Label()
        Me.btnConvertNotEqual = New System.Windows.Forms.Button()
        Me.btnConvertEqual = New System.Windows.Forms.Button()
        Me.lblSouthAfricanRand = New System.Windows.Forms.Label()
        Me.lblBritishPound = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblAmericanDollar = New System.Windows.Forms.Label()
        Me.grpBoxTeaTime = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalculateTotalDue = New System.Windows.Forms.Button()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.lblPricePerPound = New System.Windows.Forms.Label()
        Me.txtPricePerPound = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.btnCalculateMonthlyBill = New System.Windows.Forms.Button()
        Me.lblMonthlyBill = New System.Windows.Forms.Label()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.grpBoxTriCountyElectric = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblQuotientValue = New System.Windows.Forms.Label()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.btnCalculateQuotient = New System.Windows.Forms.Button()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.grpBoxCurrencyConversion.SuspendLayout()
        Me.grpBoxTeaTime.SuspendLayout()
        Me.grpBoxTriCountyElectric.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAmericanDollar
        '
        Me.txtAmericanDollar.Location = New System.Drawing.Point(22, 52)
        Me.txtAmericanDollar.Name = "txtAmericanDollar"
        Me.txtAmericanDollar.Size = New System.Drawing.Size(95, 20)
        Me.txtAmericanDollar.TabIndex = 1
        '
        'grpBoxCurrencyConversion
        '
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblRandValue)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblPoundValue)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblEuroValue)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.btnConvertNotEqual)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.btnConvertEqual)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblSouthAfricanRand)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblBritishPound)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblEuro)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.lblAmericanDollar)
        Me.grpBoxCurrencyConversion.Controls.Add(Me.txtAmericanDollar)
        Me.grpBoxCurrencyConversion.Location = New System.Drawing.Point(25, 41)
        Me.grpBoxCurrencyConversion.Name = "grpBoxCurrencyConversion"
        Me.grpBoxCurrencyConversion.Size = New System.Drawing.Size(563, 97)
        Me.grpBoxCurrencyConversion.TabIndex = 0
        Me.grpBoxCurrencyConversion.TabStop = False
        Me.grpBoxCurrencyConversion.Text = "p 231 #1 Currency Converter"
        '
        'lblRandValue
        '
        Me.lblRandValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRandValue.Location = New System.Drawing.Point(453, 54)
        Me.lblRandValue.Name = "lblRandValue"
        Me.lblRandValue.Size = New System.Drawing.Size(95, 20)
        Me.lblRandValue.TabIndex = 9
        '
        'lblPoundValue
        '
        Me.lblPoundValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoundValue.Location = New System.Drawing.Point(348, 54)
        Me.lblPoundValue.Name = "lblPoundValue"
        Me.lblPoundValue.Size = New System.Drawing.Size(95, 20)
        Me.lblPoundValue.TabIndex = 7
        '
        'lblEuroValue
        '
        Me.lblEuroValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuroValue.Location = New System.Drawing.Point(243, 54)
        Me.lblEuroValue.Name = "lblEuroValue"
        Me.lblEuroValue.Size = New System.Drawing.Size(95, 20)
        Me.lblEuroValue.TabIndex = 5
        '
        'btnConvertNotEqual
        '
        Me.btnConvertNotEqual.Location = New System.Drawing.Point(150, 54)
        Me.btnConvertNotEqual.Name = "btnConvertNotEqual"
        Me.btnConvertNotEqual.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertNotEqual.TabIndex = 3
        Me.btnConvertNotEqual.Text = "&Convert <>"
        Me.btnConvertNotEqual.UseVisualStyleBackColor = True
        '
        'btnConvertEqual
        '
        Me.btnConvertEqual.Location = New System.Drawing.Point(150, 20)
        Me.btnConvertEqual.Name = "btnConvertEqual"
        Me.btnConvertEqual.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertEqual.TabIndex = 2
        Me.btnConvertEqual.Text = "&Convert ="
        Me.btnConvertEqual.UseVisualStyleBackColor = True
        '
        'lblSouthAfricanRand
        '
        Me.lblSouthAfricanRand.AutoSize = True
        Me.lblSouthAfricanRand.Location = New System.Drawing.Point(453, 39)
        Me.lblSouthAfricanRand.Name = "lblSouthAfricanRand"
        Me.lblSouthAfricanRand.Size = New System.Drawing.Size(98, 13)
        Me.lblSouthAfricanRand.TabIndex = 8
        Me.lblSouthAfricanRand.Text = "South African &rand:"
        '
        'lblBritishPound
        '
        Me.lblBritishPound.AutoSize = True
        Me.lblBritishPound.Location = New System.Drawing.Point(348, 39)
        Me.lblBritishPound.Name = "lblBritishPound"
        Me.lblBritishPound.Size = New System.Drawing.Size(71, 13)
        Me.lblBritishPound.TabIndex = 6
        Me.lblBritishPound.Text = "British &pound:"
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Location = New System.Drawing.Point(243, 39)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(35, 13)
        Me.lblEuro.TabIndex = 4
        Me.lblEuro.Text = " &Euro:"
        '
        'lblAmericanDollar
        '
        Me.lblAmericanDollar.AutoSize = True
        Me.lblAmericanDollar.Location = New System.Drawing.Point(22, 36)
        Me.lblAmericanDollar.Name = "lblAmericanDollar"
        Me.lblAmericanDollar.Size = New System.Drawing.Size(82, 13)
        Me.lblAmericanDollar.TabIndex = 0
        Me.lblAmericanDollar.Text = "American &dollar:"
        '
        'grpBoxTeaTime
        '
        Me.grpBoxTeaTime.Controls.Add(Me.lblTotalAmountDue)
        Me.grpBoxTeaTime.Controls.Add(Me.lblTotalDue)
        Me.grpBoxTeaTime.Controls.Add(Me.btnCalculateTotalDue)
        Me.grpBoxTeaTime.Controls.Add(Me.lblPounds)
        Me.grpBoxTeaTime.Controls.Add(Me.txtPounds)
        Me.grpBoxTeaTime.Controls.Add(Me.lblPricePerPound)
        Me.grpBoxTeaTime.Controls.Add(Me.txtPricePerPound)
        Me.grpBoxTeaTime.Location = New System.Drawing.Point(25, 158)
        Me.grpBoxTeaTime.Name = "grpBoxTeaTime"
        Me.grpBoxTeaTime.Size = New System.Drawing.Size(386, 97)
        Me.grpBoxTeaTime.TabIndex = 1
        Me.grpBoxTeaTime.TabStop = False
        Me.grpBoxTeaTime.Text = "p 231 #3 Tea Time"
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(284, 58)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(95, 20)
        Me.lblTotalAmountDue.TabIndex = 6
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(284, 43)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDue.TabIndex = 5
        Me.lblTotalDue.Text = "Total Due:"
        '
        'btnCalculateTotalDue
        '
        Me.btnCalculateTotalDue.AutoSize = True
        Me.btnCalculateTotalDue.Location = New System.Drawing.Point(194, 56)
        Me.btnCalculateTotalDue.Name = "btnCalculateTotalDue"
        Me.btnCalculateTotalDue.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateTotalDue.TabIndex = 4
        Me.btnCalculateTotalDue.Text = "Calculate"
        Me.btnCalculateTotalDue.UseVisualStyleBackColor = True
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(39, 43)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(46, 13)
        Me.lblPounds.TabIndex = 0
        Me.lblPounds.Text = "Pounds:"
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(39, 58)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(55, 20)
        Me.txtPounds.TabIndex = 1
        '
        'lblPricePerPound
        '
        Me.lblPricePerPound.AutoSize = True
        Me.lblPricePerPound.Location = New System.Drawing.Point(120, 43)
        Me.lblPricePerPound.Name = "lblPricePerPound"
        Me.lblPricePerPound.Size = New System.Drawing.Size(47, 13)
        Me.lblPricePerPound.TabIndex = 2
        Me.lblPricePerPound.Text = "Price/lb:"
        '
        'txtPricePerPound
        '
        Me.txtPricePerPound.Location = New System.Drawing.Point(123, 58)
        Me.txtPricePerPound.Name = "txtPricePerPound"
        Me.txtPricePerPound.Size = New System.Drawing.Size(55, 20)
        Me.txtPricePerPound.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 500)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(117, 55)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(55, 20)
        Me.txtCurrent.TabIndex = 3
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(114, 38)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(44, 13)
        Me.lblCurrent.TabIndex = 2
        Me.lblCurrent.Text = "Current:"
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(33, 55)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(55, 20)
        Me.txtPrevious.TabIndex = 1
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.Location = New System.Drawing.Point(33, 38)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(51, 13)
        Me.lblPrevious.TabIndex = 0
        Me.lblPrevious.Text = "Previous:"
        '
        'btnCalculateMonthlyBill
        '
        Me.btnCalculateMonthlyBill.AutoSize = True
        Me.btnCalculateMonthlyBill.Location = New System.Drawing.Point(188, 53)
        Me.btnCalculateMonthlyBill.Name = "btnCalculateMonthlyBill"
        Me.btnCalculateMonthlyBill.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateMonthlyBill.TabIndex = 4
        Me.btnCalculateMonthlyBill.Text = "Calculate"
        Me.btnCalculateMonthlyBill.UseVisualStyleBackColor = True
        '
        'lblMonthlyBill
        '
        Me.lblMonthlyBill.AutoSize = True
        Me.lblMonthlyBill.Location = New System.Drawing.Point(279, 41)
        Me.lblMonthlyBill.Name = "lblMonthlyBill"
        Me.lblMonthlyBill.Size = New System.Drawing.Size(57, 13)
        Me.lblMonthlyBill.TabIndex = 5
        Me.lblMonthlyBill.Text = "Montly Bill:"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBill.Location = New System.Drawing.Point(279, 57)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(95, 20)
        Me.lblTotalBill.TabIndex = 6
        '
        'grpBoxTriCountyElectric
        '
        Me.grpBoxTriCountyElectric.Controls.Add(Me.lblTotalBill)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.lblMonthlyBill)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.btnCalculateMonthlyBill)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.lblPrevious)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.txtPrevious)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.lblCurrent)
        Me.grpBoxTriCountyElectric.Controls.Add(Me.txtCurrent)
        Me.grpBoxTriCountyElectric.Location = New System.Drawing.Point(25, 275)
        Me.grpBoxTriCountyElectric.Name = "grpBoxTriCountyElectric"
        Me.grpBoxTriCountyElectric.Size = New System.Drawing.Size(386, 97)
        Me.grpBoxTriCountyElectric.TabIndex = 2
        Me.grpBoxTriCountyElectric.TabStop = False
        Me.grpBoxTriCountyElectric.Text = "p 232 #4 Tri County Electric w/validation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblQuotientValue)
        Me.GroupBox1.Controls.Add(Me.lblQuotient)
        Me.GroupBox1.Controls.Add(Me.btnCalculateQuotient)
        Me.GroupBox1.Controls.Add(Me.lblFirstNumber)
        Me.GroupBox1.Controls.Add(Me.txtFirstNumber)
        Me.GroupBox1.Controls.Add(Me.lblSecondNumber)
        Me.GroupBox1.Controls.Add(Me.txtSecondNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 97)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p 232 Division Calculator"
        '
        'lblQuotientValue
        '
        Me.lblQuotientValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotientValue.Location = New System.Drawing.Point(278, 57)
        Me.lblQuotientValue.Name = "lblQuotientValue"
        Me.lblQuotientValue.Size = New System.Drawing.Size(95, 20)
        Me.lblQuotientValue.TabIndex = 6
        '
        'lblQuotient
        '
        Me.lblQuotient.AutoSize = True
        Me.lblQuotient.Location = New System.Drawing.Point(278, 41)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(50, 13)
        Me.lblQuotient.TabIndex = 5
        Me.lblQuotient.Text = "Quotient:"
        '
        'btnCalculateQuotient
        '
        Me.btnCalculateQuotient.AutoSize = True
        Me.btnCalculateQuotient.Location = New System.Drawing.Point(188, 53)
        Me.btnCalculateQuotient.Name = "btnCalculateQuotient"
        Me.btnCalculateQuotient.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateQuotient.TabIndex = 4
        Me.btnCalculateQuotient.Text = "Calculate"
        Me.btnCalculateQuotient.UseVisualStyleBackColor = True
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Location = New System.Drawing.Point(33, 39)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblFirstNumber.TabIndex = 0
        Me.lblFirstNumber.Text = "First #:"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(33, 55)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(55, 20)
        Me.txtFirstNumber.TabIndex = 1
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Location = New System.Drawing.Point(114, 39)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(57, 13)
        Me.lblSecondNumber.TabIndex = 2
        Me.lblSecondNumber.Text = "Second #:"
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(117, 55)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(55, 20)
        Me.txtSecondNumber.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpBoxTriCountyElectric)
        Me.Controls.Add(Me.grpBoxTeaTime)
        Me.Controls.Add(Me.grpBoxCurrencyConversion)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber2d2"
        Me.grpBoxCurrencyConversion.ResumeLayout(False)
        Me.grpBoxCurrencyConversion.PerformLayout()
        Me.grpBoxTeaTime.ResumeLayout(False)
        Me.grpBoxTeaTime.PerformLayout()
        Me.grpBoxTriCountyElectric.ResumeLayout(False)
        Me.grpBoxTriCountyElectric.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAmericanDollar As TextBox
    Friend WithEvents grpBoxCurrencyConversion As GroupBox
    Friend WithEvents lblRandValue As Label
    Friend WithEvents lblPoundValue As Label
    Friend WithEvents lblEuroValue As Label
    Friend WithEvents btnConvertNotEqual As Button
    Friend WithEvents btnConvertEqual As Button
    Friend WithEvents lblSouthAfricanRand As Label
    Friend WithEvents lblBritishPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblAmericanDollar As Label
    Friend WithEvents grpBoxTeaTime As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPounds As Label
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents lblPricePerPound As Label
    Friend WithEvents txtPricePerPound As TextBox
    Friend WithEvents btnCalculateTotalDue As Button
    Friend WithEvents lblTotalAmountDue As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents lblCurrent As Label
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents lblPrevious As Label
    Friend WithEvents btnCalculateMonthlyBill As Button
    Friend WithEvents lblMonthlyBill As Label
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents grpBoxTriCountyElectric As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblQuotientValue As Label
    Friend WithEvents lblQuotient As Label
    Friend WithEvents btnCalculateQuotient As Button
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents txtSecondNumber As TextBox
End Class
