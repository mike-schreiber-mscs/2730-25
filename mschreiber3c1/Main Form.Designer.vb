<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radSubCentimeters = New System.Windows.Forms.RadioButton()
        Me.radSubInches = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radFuncCentimeters = New System.Windows.Forms.RadioButton()
        Me.radFuncInches = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radFunc = New System.Windows.Forms.RadioButton()
        Me.radSub = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCalculatedWeight = New System.Windows.Forms.Label()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSubCentimeters
        '
        Me.radSubCentimeters.Checked = True
        Me.radSubCentimeters.Location = New System.Drawing.Point(129, 39)
        Me.radSubCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubCentimeters.Name = "radSubCentimeters"
        Me.radSubCentimeters.Size = New System.Drawing.Size(236, 24)
        Me.radSubCentimeters.TabIndex = 2
        Me.radSubCentimeters.TabStop = True
        Me.radSubCentimeters.Text = "Sub: Inches to &Centimeters"
        '
        'radSubInches
        '
        Me.radSubInches.Location = New System.Drawing.Point(129, 78)
        Me.radSubInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radSubInches.Name = "radSubInches"
        Me.radSubInches.Size = New System.Drawing.Size(236, 24)
        Me.radSubInches.TabIndex = 3
        Me.radSubInches.Text = "Sub: Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(11, 71)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(55, 27)
        Me.txtMeasurement.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(11, 140)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(81, 30)
        Me.lblResult.TabIndex = 7
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 419)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'radFuncCentimeters
        '
        Me.radFuncCentimeters.Location = New System.Drawing.Point(129, 117)
        Me.radFuncCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncCentimeters.Name = "radFuncCentimeters"
        Me.radFuncCentimeters.Size = New System.Drawing.Size(236, 24)
        Me.radFuncCentimeters.TabIndex = 8
        Me.radFuncCentimeters.Text = "Function: Inches to &Centimeters"
        '
        'radFuncInches
        '
        Me.radFuncInches.Location = New System.Drawing.Point(129, 156)
        Me.radFuncInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radFuncInches.Name = "radFuncInches"
        Me.radFuncInches.Size = New System.Drawing.Size(236, 24)
        Me.radFuncInches.TabIndex = 9
        Me.radFuncInches.Text = "Function: Centimeters to &Inches"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSubInches)
        Me.GroupBox1.Controls.Add(Me.radFuncInches)
        Me.GroupBox1.Controls.Add(Me.radSubCentimeters)
        Me.GroupBox1.Controls.Add(Me.radFuncCentimeters)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 207)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p418 #15-16 Measurement Converter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFunc)
        Me.GroupBox2.Controls.Add(Me.radSub)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblCalculatedWeight)
        Me.GroupBox2.Controls.Add(Me.cboPlanets)
        Me.GroupBox2.Controls.Add(Me.txtWeight)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 167)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p426-427 #4-6 Weight on Different Planets"
        '
        'radFunc
        '
        Me.radFunc.AutoSize = True
        Me.radFunc.Location = New System.Drawing.Point(243, 89)
        Me.radFunc.Name = "radFunc"
        Me.radFunc.Size = New System.Drawing.Size(83, 24)
        Me.radFunc.TabIndex = 7
        Me.radFunc.Text = "Function"
        Me.radFunc.UseVisualStyleBackColor = True
        '
        'radSub
        '
        Me.radSub.AutoSize = True
        Me.radSub.Checked = True
        Me.radSub.Location = New System.Drawing.Point(243, 59)
        Me.radSub.Name = "radSub"
        Me.radSub.Size = New System.Drawing.Size(52, 24)
        Me.radSub.TabIndex = 6
        Me.radSub.TabStop = True
        Me.radSub.Text = "Sub"
        Me.radSub.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Calculate Using:"
        '
        'lblCalculatedWeight
        '
        Me.lblCalculatedWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalculatedWeight.Location = New System.Drawing.Point(135, 107)
        Me.lblCalculatedWeight.Name = "lblCalculatedWeight"
        Me.lblCalculatedWeight.Size = New System.Drawing.Size(93, 27)
        Me.lblCalculatedWeight.TabIndex = 4
        '
        'cboPlanets
        '
        Me.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanets.FormattingEnabled = True
        Me.cboPlanets.Location = New System.Drawing.Point(135, 55)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.Size = New System.Drawing.Size(97, 28)
        Me.cboPlanets.TabIndex = 3
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(23, 55)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(93, 27)
        Me.txtWeight.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Weight on:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Earth weight:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 460)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber3c1: Measurement Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radSubCentimeters As System.Windows.Forms.RadioButton
    Friend WithEvents radSubInches As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radFuncCentimeters As RadioButton
    Friend WithEvents radFuncInches As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radFunc As RadioButton
    Friend WithEvents radSub As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCalculatedWeight As Label
    Friend WithEvents cboPlanets As ComboBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
