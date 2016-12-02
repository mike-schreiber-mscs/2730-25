<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonthNum = New System.Windows.Forms.TextBox()
        Me.btnDisplayDays = New System.Windows.Forms.Button()
        Me.lblNumDays = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLessThanAvg = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnWholesale = New System.Windows.Forms.Button()
        Me.lstWholesale = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstRetail = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonthNum)
        Me.GroupBox1.Controls.Add(Me.btnDisplayDays)
        Me.GroupBox1.Controls.Add(Me.lblNumDays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Days of Month"
        '
        'txtMonthNum
        '
        Me.txtMonthNum.Location = New System.Drawing.Point(98, 24)
        Me.txtMonthNum.Name = "txtMonthNum"
        Me.txtMonthNum.Size = New System.Drawing.Size(39, 20)
        Me.txtMonthNum.TabIndex = 4
        '
        'btnDisplayDays
        '
        Me.btnDisplayDays.AutoSize = True
        Me.btnDisplayDays.Location = New System.Drawing.Point(42, 87)
        Me.btnDisplayDays.Name = "btnDisplayDays"
        Me.btnDisplayDays.Size = New System.Drawing.Size(83, 23)
        Me.btnDisplayDays.TabIndex = 3
        Me.btnDisplayDays.Text = "&Displays Days"
        Me.btnDisplayDays.UseVisualStyleBackColor = True
        '
        'lblNumDays
        '
        Me.lblNumDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumDays.Location = New System.Drawing.Point(98, 52)
        Me.lblNumDays.Name = "lblNumDays"
        Me.lblNumDays.Size = New System.Drawing.Size(39, 20)
        Me.lblNumDays.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Days:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month Number:"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Location = New System.Drawing.Point(221, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLessThanAvg)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnDoLoop)
        Me.GroupBox2.Controls.Add(Me.btnForEachNext)
        Me.GroupBox2.Controls.Add(Me.btnForNext)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(185, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 116)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p522 #9 Avg. min sold"
        '
        'lblLessThanAvg
        '
        Me.lblLessThanAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLessThanAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLessThanAvg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLessThanAvg.Location = New System.Drawing.Point(83, 71)
        Me.lblLessThanAvg.Name = "lblLessThanAvg"
        Me.lblLessThanAvg.Size = New System.Drawing.Size(111, 28)
        Me.lblLessThanAvg.TabIndex = 11
        Me.lblLessThanAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Average:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "< avg:"
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(212, 74)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(111, 28)
        Me.btnDoLoop.TabIndex = 8
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(212, 44)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(111, 28)
        Me.btnForEachNext.TabIndex = 7
        Me.btnForEachNext.Text = "For &Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(212, 14)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(111, 28)
        Me.btnForNext.TabIndex = 6
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(83, 38)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(111, 28)
        Me.lblAvg.TabIndex = 10
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Values: 250 225 193 260"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnWholesale)
        Me.GroupBox3.Controls.Add(Me.lstWholesale)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lstRetail)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnRetail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 236)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p523 #13 Wholesale, Retail Prices"
        '
        'btnWholesale
        '
        Me.btnWholesale.Location = New System.Drawing.Point(163, 135)
        Me.btnWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWholesale.Name = "btnWholesale"
        Me.btnWholesale.Size = New System.Drawing.Size(85, 76)
        Me.btnWholesale.TabIndex = 8
        Me.btnWholesale.Text = "&Return Array to Wholesale Prices"
        '
        'lstWholesale
        '
        Me.lstWholesale.Enabled = False
        Me.lstWholesale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWholesale.FormattingEnabled = True
        Me.lstWholesale.ItemHeight = 16
        Me.lstWholesale.Location = New System.Drawing.Point(14, 47)
        Me.lstWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.lstWholesale.Name = "lstWholesale"
        Me.lstWholesale.Size = New System.Drawing.Size(59, 164)
        Me.lstWholesale.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Wholesale:"
        '
        'lstRetail
        '
        Me.lstRetail.Enabled = False
        Me.lstRetail.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRetail.FormattingEnabled = True
        Me.lstRetail.ItemHeight = 16
        Me.lstRetail.Location = New System.Drawing.Point(92, 47)
        Me.lstRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRetail.Name = "lstRetail"
        Me.lstRetail.Size = New System.Drawing.Size(59, 164)
        Me.lstRetail.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Retail :"
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(163, 47)
        Me.btnRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(85, 76)
        Me.btnRetail.TabIndex = 7
        Me.btnRetail.Text = "&Update Array to Retail Prices"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 416)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber3d3 Arrays, subscripts, loops"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMonthNum As TextBox
    Friend WithEvents btnDisplayDays As Button
    Friend WithEvents lblNumDays As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents btnForEachNext As Button
    Friend WithEvents btnForNext As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLessThanAvg As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnWholesale As Button
    Friend WithEvents lstWholesale As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstRetail As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRetail As Button
End Class
