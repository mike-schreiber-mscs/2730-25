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
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalcNestedIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelect = New System.Windows.Forms.Button()
        Me.grpBoxRates = New System.Windows.Forms.GroupBox()
        Me.lbl1to10 = New System.Windows.Forms.Label()
        Me.lbl11to15 = New System.Windows.Forms.Label()
        Me.lbl16to20 = New System.Windows.Forms.Label()
        Me.lblGreaterThan20 = New System.Windows.Forms.Label()
        Me.grpBoxSamples = New System.Windows.Forms.GroupBox()
        Me.lbl9Dollar = New System.Windows.Forms.Label()
        Me.lbl5Dollar = New System.Windows.Forms.Label()
        Me.lbl3Dollar = New System.Windows.Forms.Label()
        Me.lbl0Dollar = New System.Windows.Forms.Label()
        Me.grpBoxRates.SuspendLayout()
        Me.grpBoxSamples.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(77, 164)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(81, 189)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(81, 27)
        Me.txtPrice.TabIndex = 1
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(176, 165)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(68, 20)
        Me.lblQty.TabIndex = 2
        Me.lblQty.Text = "&Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(180, 189)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(81, 27)
        Me.txtQuantity.TabIndex = 3
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(275, 164)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(70, 20)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount:"
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountAmount.Location = New System.Drawing.Point(279, 189)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(81, 29)
        Me.lblDiscountAmount.TabIndex = 7
        Me.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(374, 164)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(75, 20)
        Me.lblTotalDue.TabIndex = 8
        Me.lblTotalDue.Text = "Total due:"
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(378, 189)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(81, 29)
        Me.lblTotalAmountDue.TabIndex = 9
        Me.lblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(53, 224)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 32)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 274)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalcNestedIf
        '
        Me.btnCalcNestedIf.AutoSize = True
        Me.btnCalcNestedIf.Location = New System.Drawing.Point(150, 224)
        Me.btnCalcNestedIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcNestedIf.Name = "btnCalcNestedIf"
        Me.btnCalcNestedIf.Size = New System.Drawing.Size(114, 32)
        Me.btnCalcNestedIf.TabIndex = 10
        Me.btnCalcNestedIf.Text = "Calc: Nested If"
        Me.btnCalcNestedIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.AutoSize = True
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(275, 224)
        Me.btnCalcIfElseIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(104, 32)
        Me.btnCalcIfElseIf.TabIndex = 11
        Me.btnCalcIfElseIf.Text = "Calc: If-ElseIf"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelect
        '
        Me.btnCalcSelect.AutoSize = True
        Me.btnCalcSelect.Location = New System.Drawing.Point(390, 224)
        Me.btnCalcSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcSelect.Name = "btnCalcSelect"
        Me.btnCalcSelect.Size = New System.Drawing.Size(94, 32)
        Me.btnCalcSelect.TabIndex = 12
        Me.btnCalcSelect.Text = "Calc: Select"
        Me.btnCalcSelect.UseVisualStyleBackColor = True
        '
        'grpBoxRates
        '
        Me.grpBoxRates.Controls.Add(Me.lblGreaterThan20)
        Me.grpBoxRates.Controls.Add(Me.lbl16to20)
        Me.grpBoxRates.Controls.Add(Me.lbl11to15)
        Me.grpBoxRates.Controls.Add(Me.lbl1to10)
        Me.grpBoxRates.Location = New System.Drawing.Point(67, 12)
        Me.grpBoxRates.Name = "grpBoxRates"
        Me.grpBoxRates.Size = New System.Drawing.Size(127, 127)
        Me.grpBoxRates.TabIndex = 13
        Me.grpBoxRates.TabStop = False
        Me.grpBoxRates.Text = "Discount Rates"
        '
        'lbl1to10
        '
        Me.lbl1to10.AutoSize = True
        Me.lbl1to10.Location = New System.Drawing.Point(6, 23)
        Me.lbl1to10.Name = "lbl1to10"
        Me.lbl1to10.Size = New System.Drawing.Size(90, 20)
        Me.lbl1to10.TabIndex = 0
        Me.lbl1to10.Text = "1 - 10:     0%"
        '
        'lbl11to15
        '
        Me.lbl11to15.AutoSize = True
        Me.lbl11to15.Location = New System.Drawing.Point(6, 50)
        Me.lbl11to15.Name = "lbl11to15"
        Me.lbl11to15.Size = New System.Drawing.Size(91, 20)
        Me.lbl11to15.TabIndex = 1
        Me.lbl11to15.Text = "11 - 15    2%"
        '
        'lbl16to20
        '
        Me.lbl16to20.AutoSize = True
        Me.lbl16to20.Location = New System.Drawing.Point(6, 77)
        Me.lbl16to20.Name = "lbl16to20"
        Me.lbl16to20.Size = New System.Drawing.Size(102, 20)
        Me.lbl16to20.TabIndex = 2
        Me.lbl16to20.Text = "16 - 20    2.5%"
        '
        'lblGreaterThan20
        '
        Me.lblGreaterThan20.AutoSize = True
        Me.lblGreaterThan20.Location = New System.Drawing.Point(6, 104)
        Me.lblGreaterThan20.Name = "lblGreaterThan20"
        Me.lblGreaterThan20.Size = New System.Drawing.Size(90, 20)
        Me.lblGreaterThan20.TabIndex = 3
        Me.lblGreaterThan20.Text = "> 20:       3%"
        '
        'grpBoxSamples
        '
        Me.grpBoxSamples.Controls.Add(Me.lbl9Dollar)
        Me.grpBoxSamples.Controls.Add(Me.lbl5Dollar)
        Me.grpBoxSamples.Controls.Add(Me.lbl3Dollar)
        Me.grpBoxSamples.Controls.Add(Me.lbl0Dollar)
        Me.grpBoxSamples.Location = New System.Drawing.Point(247, 12)
        Me.grpBoxSamples.Name = "grpBoxSamples"
        Me.grpBoxSamples.Size = New System.Drawing.Size(223, 127)
        Me.grpBoxSamples.TabIndex = 14
        Me.grpBoxSamples.TabStop = False
        Me.grpBoxSamples.Text = "Sample Results"
        '
        'lbl9Dollar
        '
        Me.lbl9Dollar.AutoSize = True
        Me.lbl9Dollar.Location = New System.Drawing.Point(6, 104)
        Me.lbl9Dollar.Name = "lbl9Dollar"
        Me.lbl9Dollar.Size = New System.Drawing.Size(118, 20)
        Me.lbl9Dollar.TabIndex = 3
        Me.lbl9Dollar.Text = "$10, Qty  30:   $9"
        '
        'lbl5Dollar
        '
        Me.lbl5Dollar.AutoSize = True
        Me.lbl5Dollar.Location = New System.Drawing.Point(6, 77)
        Me.lbl5Dollar.Name = "lbl5Dollar"
        Me.lbl5Dollar.Size = New System.Drawing.Size(118, 20)
        Me.lbl5Dollar.TabIndex = 2
        Me.lbl5Dollar.Text = "$10, Qty  20:   $5"
        '
        'lbl3Dollar
        '
        Me.lbl3Dollar.AutoSize = True
        Me.lbl3Dollar.Location = New System.Drawing.Point(6, 50)
        Me.lbl3Dollar.Name = "lbl3Dollar"
        Me.lbl3Dollar.Size = New System.Drawing.Size(118, 20)
        Me.lbl3Dollar.TabIndex = 1
        Me.lbl3Dollar.Text = "$10, Qty  15:   $3"
        '
        'lbl0Dollar
        '
        Me.lbl0Dollar.AutoSize = True
        Me.lbl0Dollar.Location = New System.Drawing.Point(6, 23)
        Me.lbl0Dollar.Name = "lbl0Dollar"
        Me.lbl0Dollar.Size = New System.Drawing.Size(118, 20)
        Me.lbl0Dollar.TabIndex = 0
        Me.lbl0Dollar.Text = "$10, Qty 10:    $0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 318)
        Me.Controls.Add(Me.grpBoxSamples)
        Me.Controls.Add(Me.grpBoxRates)
        Me.Controls.Add(Me.btnCalcSelect)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcNestedIf)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalAmountDue)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblDiscountAmount)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jetters"
        Me.grpBoxRates.ResumeLayout(False)
        Me.grpBoxRates.PerformLayout()
        Me.grpBoxSamples.ResumeLayout(False)
        Me.grpBoxSamples.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscountAmount As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalcNestedIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelect As Button
    Friend WithEvents grpBoxRates As GroupBox
    Friend WithEvents lblGreaterThan20 As Label
    Friend WithEvents lbl16to20 As Label
    Friend WithEvents lbl11to15 As Label
    Friend WithEvents lbl1to10 As Label
    Friend WithEvents grpBoxSamples As GroupBox
    Friend WithEvents lbl9Dollar As Label
    Friend WithEvents lbl5Dollar As Label
    Friend WithEvents lbl3Dollar As Label
    Friend WithEvents lbl0Dollar As Label
End Class
