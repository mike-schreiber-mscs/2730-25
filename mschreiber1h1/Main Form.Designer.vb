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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFwt = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblGrossTotal = New System.Windows.Forms.Label()
        Me.lblFwtTotal = New System.Windows.Forms.Label()
        Me.lblFicaTotal = New System.Windows.Forms.Label()
        Me.lblStateTotal = New System.Windows.Forms.Label()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(93, 232)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(157, 27)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(280, 232)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(157, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(467, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 27)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(159, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(534, 68)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(51, 20)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "&Hours:"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Location = New System.Drawing.Point(625, 68)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(65, 20)
        Me.lblPayRate.TabIndex = 4
        Me.lblPayRate.Text = "Pay &rate:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(21, 143)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(48, 20)
        Me.lblGross.TabIndex = 9
        Me.lblGross.Text = "Gross:"
        '
        'lblFwt
        '
        Me.lblFwt.AutoSize = True
        Me.lblFwt.Location = New System.Drawing.Point(159, 143)
        Me.lblFwt.Name = "lblFwt"
        Me.lblFwt.Size = New System.Drawing.Size(41, 20)
        Me.lblFwt.TabIndex = 11
        Me.lblFwt.Text = "FWT:"
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Location = New System.Drawing.Point(297, 143)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(42, 20)
        Me.lblFica.TabIndex = 13
        Me.lblFica.Text = "FICA:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(435, 143)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 20)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(573, 143)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(36, 20)
        Me.lblNet.TabIndex = 17
        Me.lblNet.Text = "Net:"
        '
        'lblGrossTotal
        '
        Me.lblGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossTotal.Location = New System.Drawing.Point(21, 177)
        Me.lblGrossTotal.Name = "lblGrossTotal"
        Me.lblGrossTotal.Size = New System.Drawing.Size(122, 27)
        Me.lblGrossTotal.TabIndex = 10
        Me.lblGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFwtTotal
        '
        Me.lblFwtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFwtTotal.Location = New System.Drawing.Point(159, 177)
        Me.lblFwtTotal.Name = "lblFwtTotal"
        Me.lblFwtTotal.Size = New System.Drawing.Size(122, 27)
        Me.lblFwtTotal.TabIndex = 12
        Me.lblFwtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFicaTotal
        '
        Me.lblFicaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFicaTotal.Location = New System.Drawing.Point(297, 177)
        Me.lblFicaTotal.Name = "lblFicaTotal"
        Me.lblFicaTotal.Size = New System.Drawing.Size(122, 27)
        Me.lblFicaTotal.TabIndex = 14
        Me.lblFicaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStateTotal
        '
        Me.lblStateTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStateTotal.Location = New System.Drawing.Point(435, 177)
        Me.lblStateTotal.Name = "lblStateTotal"
        Me.lblStateTotal.Size = New System.Drawing.Size(122, 27)
        Me.lblStateTotal.TabIndex = 16
        Me.lblStateTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetTotal
        '
        Me.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetTotal.Location = New System.Drawing.Point(573, 177)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(122, 27)
        Me.lblNetTotal.TabIndex = 18
        Me.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(163, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 27)
        Me.txtName.TabIndex = 1
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(534, 91)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(75, 27)
        Me.txtHours.TabIndex = 3
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(625, 91)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(75, 27)
        Me.txtPayRate.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 332)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNetTotal)
        Me.Controls.Add(Me.lblStateTotal)
        Me.Controls.Add(Me.lblFicaTotal)
        Me.Controls.Add(Me.lblFwtTotal)
        Me.Controls.Add(Me.lblGrossTotal)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.lblFwt)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber1h1:Photo Workshop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblPayRate As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFwt As Label
    Friend WithEvents lblFica As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblGrossTotal As Label
    Friend WithEvents lblFwtTotal As Label
    Friend WithEvents lblFicaTotal As Label
    Friend WithEvents lblStateTotal As Label
    Friend WithEvents lblNetTotal As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPayRate As TextBox
End Class
