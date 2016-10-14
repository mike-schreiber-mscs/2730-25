<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpBoxFreeShipping = New System.Windows.Forms.GroupBox()
        Me.btnCalculateOr = New System.Windows.Forms.Button()
        Me.lblShippingAmount = New System.Windows.Forms.Label()
        Me.lblShippingCharge = New System.Windows.Forms.Label()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.lblSavannahCC = New System.Windows.Forms.Label()
        Me.lblOrderAmount = New System.Windows.Forms.Label()
        Me.txtOrderAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculateAnd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxCommissionSales = New System.Windows.Forms.GroupBox()
        Me.btnCalculateNotEqual = New System.Windows.Forms.Button()
        Me.lblCommissionAmount = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCalculateEqual = New System.Windows.Forms.Button()
        Me.grpBoxFreeShipping.SuspendLayout()
        Me.grpBoxCommissionSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxFreeShipping
        '
        Me.grpBoxFreeShipping.Controls.Add(Me.btnCalculateOr)
        Me.grpBoxFreeShipping.Controls.Add(Me.lblShippingAmount)
        Me.grpBoxFreeShipping.Controls.Add(Me.lblShippingCharge)
        Me.grpBoxFreeShipping.Controls.Add(Me.txtCreditCard)
        Me.grpBoxFreeShipping.Controls.Add(Me.lblSavannahCC)
        Me.grpBoxFreeShipping.Controls.Add(Me.lblOrderAmount)
        Me.grpBoxFreeShipping.Controls.Add(Me.txtOrderAmount)
        Me.grpBoxFreeShipping.Controls.Add(Me.btnCalculateAnd)
        Me.grpBoxFreeShipping.Location = New System.Drawing.Point(13, 22)
        Me.grpBoxFreeShipping.Name = "grpBoxFreeShipping"
        Me.grpBoxFreeShipping.Size = New System.Drawing.Size(469, 114)
        Me.grpBoxFreeShipping.TabIndex = 0
        Me.grpBoxFreeShipping.TabStop = False
        Me.grpBoxFreeShipping.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'btnCalculateOr
        '
        Me.btnCalculateOr.AutoSize = True
        Me.btnCalculateOr.Location = New System.Drawing.Point(332, 58)
        Me.btnCalculateOr.Name = "btnCalculateOr"
        Me.btnCalculateOr.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculateOr.TabIndex = 7
        Me.btnCalculateOr.Text = "Calculate (Or)"
        Me.btnCalculateOr.UseVisualStyleBackColor = True
        '
        'lblShippingAmount
        '
        Me.lblShippingAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingAmount.Location = New System.Drawing.Point(223, 42)
        Me.lblShippingAmount.Name = "lblShippingAmount"
        Me.lblShippingAmount.Size = New System.Drawing.Size(72, 20)
        Me.lblShippingAmount.TabIndex = 5
        Me.lblShippingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShippingCharge
        '
        Me.lblShippingCharge.AutoSize = True
        Me.lblShippingCharge.Location = New System.Drawing.Point(223, 26)
        Me.lblShippingCharge.Name = "lblShippingCharge"
        Me.lblShippingCharge.Size = New System.Drawing.Size(88, 13)
        Me.lblShippingCharge.TabIndex = 4
        Me.lblShippingCharge.Text = "Shipping Charge:"
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Location = New System.Drawing.Point(108, 42)
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(28, 20)
        Me.txtCreditCard.TabIndex = 3
        '
        'lblSavannahCC
        '
        Me.lblSavannahCC.AutoSize = True
        Me.lblSavannahCC.Location = New System.Drawing.Point(108, 26)
        Me.lblSavannahCC.Name = "lblSavannahCC"
        Me.lblSavannahCC.Size = New System.Drawing.Size(88, 13)
        Me.lblSavannahCC.TabIndex = 2
        Me.lblSavannahCC.Text = "&Savannah (Y/N):"
        '
        'lblOrderAmount
        '
        Me.lblOrderAmount.AutoSize = True
        Me.lblOrderAmount.Location = New System.Drawing.Point(6, 26)
        Me.lblOrderAmount.Name = "lblOrderAmount"
        Me.lblOrderAmount.Size = New System.Drawing.Size(75, 13)
        Me.lblOrderAmount.TabIndex = 0
        Me.lblOrderAmount.Text = "&Order Amount:"
        '
        'txtOrderAmount
        '
        Me.txtOrderAmount.Location = New System.Drawing.Point(9, 40)
        Me.txtOrderAmount.Name = "txtOrderAmount"
        Me.txtOrderAmount.Size = New System.Drawing.Size(72, 20)
        Me.txtOrderAmount.TabIndex = 1
        '
        'btnCalculateAnd
        '
        Me.btnCalculateAnd.AutoSize = True
        Me.btnCalculateAnd.Location = New System.Drawing.Point(332, 26)
        Me.btnCalculateAnd.Name = "btnCalculateAnd"
        Me.btnCalculateAnd.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculateAnd.TabIndex = 6
        Me.btnCalculateAnd.Text = "Calculate (And)"
        Me.btnCalculateAnd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(200, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpBoxCommissionSales
        '
        Me.grpBoxCommissionSales.Controls.Add(Me.btnCalculateNotEqual)
        Me.grpBoxCommissionSales.Controls.Add(Me.lblCommissionAmount)
        Me.grpBoxCommissionSales.Controls.Add(Me.lblCommission)
        Me.grpBoxCommissionSales.Controls.Add(Me.txtSales)
        Me.grpBoxCommissionSales.Controls.Add(Me.lblSales)
        Me.grpBoxCommissionSales.Controls.Add(Me.lblID)
        Me.grpBoxCommissionSales.Controls.Add(Me.txtID)
        Me.grpBoxCommissionSales.Controls.Add(Me.btnCalculateEqual)
        Me.grpBoxCommissionSales.Location = New System.Drawing.Point(8, 153)
        Me.grpBoxCommissionSales.Name = "grpBoxCommissionSales"
        Me.grpBoxCommissionSales.Size = New System.Drawing.Size(469, 114)
        Me.grpBoxCommissionSales.TabIndex = 1
        Me.grpBoxCommissionSales.TabStop = False
        Me.grpBoxCommissionSales.Text = "15 % commission for sales > 25000 with codes A1, B2, C3"
        '
        'btnCalculateNotEqual
        '
        Me.btnCalculateNotEqual.AutoSize = True
        Me.btnCalculateNotEqual.Location = New System.Drawing.Point(332, 58)
        Me.btnCalculateNotEqual.Name = "btnCalculateNotEqual"
        Me.btnCalculateNotEqual.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculateNotEqual.TabIndex = 7
        Me.btnCalculateNotEqual.Text = "Calculate (<>)"
        Me.btnCalculateNotEqual.UseVisualStyleBackColor = True
        '
        'lblCommissionAmount
        '
        Me.lblCommissionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionAmount.Location = New System.Drawing.Point(223, 42)
        Me.lblCommissionAmount.Name = "lblCommissionAmount"
        Me.lblCommissionAmount.Size = New System.Drawing.Size(72, 20)
        Me.lblCommissionAmount.TabIndex = 5
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(223, 26)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(65, 13)
        Me.lblCommission.TabIndex = 4
        Me.lblCommission.Text = "Commission:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(108, 42)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(72, 20)
        Me.txtSales.TabIndex = 3
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(108, 26)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(33, 13)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "&Sales"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(13, 26)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "&ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(13, 42)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(39, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculateEqual
        '
        Me.btnCalculateEqual.AutoSize = True
        Me.btnCalculateEqual.Location = New System.Drawing.Point(332, 26)
        Me.btnCalculateEqual.Name = "btnCalculateEqual"
        Me.btnCalculateEqual.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculateEqual.TabIndex = 6
        Me.btnCalculateEqual.Text = "Calculate (=)"
        Me.btnCalculateEqual.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 313)
        Me.Controls.Add(Me.grpBoxCommissionSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpBoxFreeShipping)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber2e1 AndAlso, OrElse"
        Me.grpBoxFreeShipping.ResumeLayout(False)
        Me.grpBoxFreeShipping.PerformLayout()
        Me.grpBoxCommissionSales.ResumeLayout(False)
        Me.grpBoxCommissionSales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxFreeShipping As GroupBox
    Friend WithEvents lblOrderAmount As Label
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents btnCalculateAnd As Button
    Friend WithEvents lblSavannahCC As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCreditCard As TextBox
    Friend WithEvents lblShippingAmount As Label
    Friend WithEvents lblShippingCharge As Label
    Friend WithEvents btnCalculateOr As Button
    Friend WithEvents grpBoxCommissionSales As GroupBox
    Friend WithEvents btnCalculateNotEqual As Button
    Friend WithEvents lblCommissionAmount As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents lblSales As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCalculateEqual As Button
End Class
