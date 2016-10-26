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
        Me.chkBox10Years = New System.Windows.Forms.CheckBox()
        Me.chkBoxTravel = New System.Windows.Forms.CheckBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblCommissionOnly = New System.Windows.Forms.Label()
        Me.lblCommOnlyAmt = New System.Windows.Forms.Label()
        Me.lblAdditionalAmount = New System.Windows.Forms.Label()
        Me.txtBoxSales = New System.Windows.Forms.TextBox()
        Me.lblAddAmt = New System.Windows.Forms.Label()
        Me.btnIfThen = New System.Windows.Forms.Button()
        Me.btnNestedIf = New System.Windows.Forms.Button()
        Me.lblTotCommAmt = New System.Windows.Forms.Label()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.btnIfElseIf = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBox10Years
        '
        Me.chkBox10Years.AutoSize = True
        Me.chkBox10Years.Location = New System.Drawing.Point(7, 69)
        Me.chkBox10Years.Name = "chkBox10Years"
        Me.chkBox10Years.Size = New System.Drawing.Size(92, 17)
        Me.chkBox10Years.TabIndex = 2
        Me.chkBox10Years.Text = "&Over 10 years"
        Me.chkBox10Years.UseVisualStyleBackColor = True
        '
        'chkBoxTravel
        '
        Me.chkBoxTravel.AutoSize = True
        Me.chkBoxTravel.Location = New System.Drawing.Point(7, 92)
        Me.chkBoxTravel.Name = "chkBoxTravel"
        Me.chkBoxTravel.Size = New System.Drawing.Size(70, 17)
        Me.chkBoxTravel.TabIndex = 3
        Me.chkBoxTravel.Text = "&Traveling"
        Me.chkBoxTravel.UseVisualStyleBackColor = True
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(7, 23)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(36, 13)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "&Sales:"
        '
        'lblCommissionOnly
        '
        Me.lblCommissionOnly.AutoSize = True
        Me.lblCommissionOnly.Location = New System.Drawing.Point(7, 118)
        Me.lblCommissionOnly.Name = "lblCommissionOnly"
        Me.lblCommissionOnly.Size = New System.Drawing.Size(87, 13)
        Me.lblCommissionOnly.TabIndex = 4
        Me.lblCommissionOnly.Text = "Commission only:"
        '
        'lblCommOnlyAmt
        '
        Me.lblCommOnlyAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommOnlyAmt.Location = New System.Drawing.Point(7, 131)
        Me.lblCommOnlyAmt.Name = "lblCommOnlyAmt"
        Me.lblCommOnlyAmt.Size = New System.Drawing.Size(100, 20)
        Me.lblCommOnlyAmt.TabIndex = 5
        Me.lblCommOnlyAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditionalAmount
        '
        Me.lblAdditionalAmount.AutoSize = True
        Me.lblAdditionalAmount.Location = New System.Drawing.Point(7, 166)
        Me.lblAdditionalAmount.Name = "lblAdditionalAmount"
        Me.lblAdditionalAmount.Size = New System.Drawing.Size(95, 13)
        Me.lblAdditionalAmount.TabIndex = 6
        Me.lblAdditionalAmount.Text = "Additional Amount:"
        '
        'txtBoxSales
        '
        Me.txtBoxSales.Location = New System.Drawing.Point(7, 39)
        Me.txtBoxSales.Name = "txtBoxSales"
        Me.txtBoxSales.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxSales.TabIndex = 1
        Me.txtBoxSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAddAmt
        '
        Me.lblAddAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddAmt.Location = New System.Drawing.Point(7, 179)
        Me.lblAddAmt.Name = "lblAddAmt"
        Me.lblAddAmt.Size = New System.Drawing.Size(100, 20)
        Me.lblAddAmt.TabIndex = 7
        Me.lblAddAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIfThen
        '
        Me.btnIfThen.Location = New System.Drawing.Point(126, 60)
        Me.btnIfThen.Name = "btnIfThen"
        Me.btnIfThen.Size = New System.Drawing.Size(75, 23)
        Me.btnIfThen.TabIndex = 10
        Me.btnIfThen.Text = "If Then"
        Me.btnIfThen.UseVisualStyleBackColor = True
        '
        'btnNestedIf
        '
        Me.btnNestedIf.Location = New System.Drawing.Point(126, 92)
        Me.btnNestedIf.Name = "btnNestedIf"
        Me.btnNestedIf.Size = New System.Drawing.Size(75, 23)
        Me.btnNestedIf.TabIndex = 11
        Me.btnNestedIf.Text = "Nested If"
        Me.btnNestedIf.UseVisualStyleBackColor = True
        '
        'lblTotCommAmt
        '
        Me.lblTotCommAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotCommAmt.Location = New System.Drawing.Point(7, 227)
        Me.lblTotCommAmt.Name = "lblTotCommAmt"
        Me.lblTotCommAmt.Size = New System.Drawing.Size(100, 20)
        Me.lblTotCommAmt.TabIndex = 9
        Me.lblTotCommAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.AutoSize = True
        Me.lblTotalCommission.Location = New System.Drawing.Point(7, 214)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(91, 13)
        Me.lblTotalCommission.TabIndex = 8
        Me.lblTotalCommission.Text = "Total commission:"
        '
        'btnIfElseIf
        '
        Me.btnIfElseIf.Location = New System.Drawing.Point(126, 124)
        Me.btnIfElseIf.Name = "btnIfElseIf"
        Me.btnIfElseIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIfElseIf.TabIndex = 12
        Me.btnIfElseIf.Text = "If Else If"
        Me.btnIfElseIf.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(126, 156)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCase.TabIndex = 13
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(126, 188)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 208)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission calculations"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "$700"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(92, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "$500"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Traveling"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(127, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(202, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "$3,120 plus 14% of the sales over 30,000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "$120 plus 13% of the sales over 6,000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "10% of sales"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(127, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Commission"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "> 10 years"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Additional Amounts"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "> 30,000"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "6,001 - 30,000"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1 - 6,000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales ($)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 273)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnIfElseIf)
        Me.Controls.Add(Me.lblTotCommAmt)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.btnNestedIf)
        Me.Controls.Add(Me.btnIfThen)
        Me.Controls.Add(Me.lblAddAmt)
        Me.Controls.Add(Me.txtBoxSales)
        Me.Controls.Add(Me.lblAdditionalAmount)
        Me.Controls.Add(Me.lblCommOnlyAmt)
        Me.Controls.Add(Me.lblCommissionOnly)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.chkBoxTravel)
        Me.Controls.Add(Me.chkBox10Years)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber 2h1 Marshall Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBox10Years As CheckBox
    Friend WithEvents chkBoxTravel As CheckBox
    Friend WithEvents lblSales As Label
    Friend WithEvents lblCommissionOnly As Label
    Friend WithEvents lblCommOnlyAmt As Label
    Friend WithEvents lblAdditionalAmount As Label
    Friend WithEvents txtBoxSales As TextBox
    Friend WithEvents lblAddAmt As Label
    Friend WithEvents btnIfThen As Button
    Friend WithEvents btnNestedIf As Button
    Friend WithEvents lblTotCommAmt As Label
    Friend WithEvents lblTotalCommission As Label
    Friend WithEvents btnIfElseIf As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
