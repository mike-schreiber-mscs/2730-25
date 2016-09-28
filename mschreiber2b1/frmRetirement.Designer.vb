<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.lblGrossWeeklyPay = New System.Windows.Forms.Label()
        Me.lblEmployeeContRate = New System.Windows.Forms.Label()
        Me.lblEmployerContRate = New System.Windows.Forms.Label()
        Me.lblEmployeeAnnualRate = New System.Windows.Forms.Label()
        Me.lblEmployerAnnualRate = New System.Windows.Forms.Label()
        Me.lblTotalAnnualCont = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeContRate = New System.Windows.Forms.TextBox()
        Me.txtEmployerContRate = New System.Windows.Forms.TextBox()
        Me.lblEmployeeAnnualCont = New System.Windows.Forms.Label()
        Me.lblEmployerAnnualCont = New System.Windows.Forms.Label()
        Me.lblTotalCont = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGrossWeeklyPay
        '
        Me.lblGrossWeeklyPay.AutoSize = True
        Me.lblGrossWeeklyPay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossWeeklyPay.Location = New System.Drawing.Point(19, 20)
        Me.lblGrossWeeklyPay.Name = "lblGrossWeeklyPay"
        Me.lblGrossWeeklyPay.Size = New System.Drawing.Size(112, 17)
        Me.lblGrossWeeklyPay.TabIndex = 0
        Me.lblGrossWeeklyPay.Text = "&Gross weekly pay:"
        '
        'lblEmployeeContRate
        '
        Me.lblEmployeeContRate.AutoSize = True
        Me.lblEmployeeContRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeContRate.Location = New System.Drawing.Point(19, 49)
        Me.lblEmployeeContRate.Name = "lblEmployeeContRate"
        Me.lblEmployeeContRate.Size = New System.Drawing.Size(258, 17)
        Me.lblEmployeeContRate.TabIndex = 2
        Me.lblEmployeeContRate.Text = "&Employee contribution rate (decimal form):"
        '
        'lblEmployerContRate
        '
        Me.lblEmployerContRate.AutoSize = True
        Me.lblEmployerContRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerContRate.Location = New System.Drawing.Point(19, 78)
        Me.lblEmployerContRate.Name = "lblEmployerContRate"
        Me.lblEmployerContRate.Size = New System.Drawing.Size(256, 17)
        Me.lblEmployerContRate.TabIndex = 4
        Me.lblEmployerContRate.Text = "Employe&r contribution rate (decimal form):"
        '
        'lblEmployeeAnnualRate
        '
        Me.lblEmployeeAnnualRate.AutoSize = True
        Me.lblEmployeeAnnualRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAnnualRate.Location = New System.Drawing.Point(19, 107)
        Me.lblEmployeeAnnualRate.Name = "lblEmployeeAnnualRate"
        Me.lblEmployeeAnnualRate.Size = New System.Drawing.Size(184, 17)
        Me.lblEmployeeAnnualRate.TabIndex = 6
        Me.lblEmployeeAnnualRate.Text = "Employee annual contribution:"
        '
        'lblEmployerAnnualRate
        '
        Me.lblEmployerAnnualRate.AutoSize = True
        Me.lblEmployerAnnualRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerAnnualRate.Location = New System.Drawing.Point(19, 136)
        Me.lblEmployerAnnualRate.Name = "lblEmployerAnnualRate"
        Me.lblEmployerAnnualRate.Size = New System.Drawing.Size(182, 17)
        Me.lblEmployerAnnualRate.TabIndex = 8
        Me.lblEmployerAnnualRate.Text = "Employer annual contribution:"
        '
        'lblTotalAnnualCont
        '
        Me.lblTotalAnnualCont.AutoSize = True
        Me.lblTotalAnnualCont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnnualCont.Location = New System.Drawing.Point(19, 165)
        Me.lblTotalAnnualCont.Name = "lblTotalAnnualCont"
        Me.lblTotalAnnualCont.Size = New System.Drawing.Size(156, 17)
        Me.lblTotalAnnualCont.TabIndex = 10
        Me.lblTotalAnnualCont.Text = "Total annual contribution:"
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(60, 220)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 31)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(174, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(280, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(295, 20)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 1
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeeContRate
        '
        Me.txtEmployeeContRate.Location = New System.Drawing.Point(340, 49)
        Me.txtEmployeeContRate.Name = "txtEmployeeContRate"
        Me.txtEmployeeContRate.Size = New System.Drawing.Size(55, 20)
        Me.txtEmployeeContRate.TabIndex = 3
        Me.txtEmployeeContRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerContRate
        '
        Me.txtEmployerContRate.Location = New System.Drawing.Point(340, 78)
        Me.txtEmployerContRate.Name = "txtEmployerContRate"
        Me.txtEmployerContRate.Size = New System.Drawing.Size(55, 20)
        Me.txtEmployerContRate.TabIndex = 5
        Me.txtEmployerContRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmployeeAnnualCont
        '
        Me.lblEmployeeAnnualCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAnnualCont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAnnualCont.Location = New System.Drawing.Point(292, 104)
        Me.lblEmployeeAnnualCont.Name = "lblEmployeeAnnualCont"
        Me.lblEmployeeAnnualCont.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeAnnualCont.TabIndex = 7
        Me.lblEmployeeAnnualCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployerAnnualCont
        '
        Me.lblEmployerAnnualCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerAnnualCont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerAnnualCont.Location = New System.Drawing.Point(292, 133)
        Me.lblEmployerAnnualCont.Name = "lblEmployerAnnualCont"
        Me.lblEmployerAnnualCont.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployerAnnualCont.TabIndex = 9
        Me.lblEmployerAnnualCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCont
        '
        Me.lblTotalCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCont.Location = New System.Drawing.Point(292, 163)
        Me.lblTotalCont.Name = "lblTotalCont"
        Me.lblTotalCont.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCont.TabIndex = 11
        Me.lblTotalCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 278)
        Me.Controls.Add(Me.lblTotalCont)
        Me.Controls.Add(Me.lblEmployerAnnualCont)
        Me.Controls.Add(Me.lblEmployeeAnnualCont)
        Me.Controls.Add(Me.txtEmployerContRate)
        Me.Controls.Add(Me.txtEmployeeContRate)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalAnnualCont)
        Me.Controls.Add(Me.lblEmployerAnnualRate)
        Me.Controls.Add(Me.lblEmployeeAnnualRate)
        Me.Controls.Add(Me.lblEmployerContRate)
        Me.Controls.Add(Me.lblEmployeeContRate)
        Me.Controls.Add(Me.lblGrossWeeklyPay)
        Me.Name = "frmRetirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRetirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGrossWeeklyPay As Label
    Friend WithEvents lblEmployeeContRate As Label
    Friend WithEvents lblEmployerContRate As Label
    Friend WithEvents lblEmployeeAnnualRate As Label
    Friend WithEvents lblEmployerAnnualRate As Label
    Friend WithEvents lblTotalAnnualCont As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtEmployeeContRate As TextBox
    Friend WithEvents txtEmployerContRate As TextBox
    Friend WithEvents lblEmployeeAnnualCont As Label
    Friend WithEvents lblEmployerAnnualCont As Label
    Friend WithEvents lblTotalCont As Label
End Class
