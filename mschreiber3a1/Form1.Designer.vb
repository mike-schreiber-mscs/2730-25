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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPreFor = New System.Windows.Forms.Button()
        Me.btnPostUntil = New System.Windows.Forms.Button()
        Me.btnPostWhile = New System.Windows.Forms.Button()
        Me.btnPreDoUntil = New System.Windows.Forms.Button()
        Me.btnPreDoWhile = New System.Windows.Forms.Button()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumUntil = New System.Windows.Forms.Button()
        Me.btnSumWhile = New System.Windows.Forms.Button()
        Me.txtBoxNum = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPreFor)
        Me.GroupBox1.Controls.Add(Me.btnPostUntil)
        Me.GroupBox1.Controls.Add(Me.btnPostWhile)
        Me.GroupBox1.Controls.Add(Me.btnPreDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnPreDoWhile)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347#13 Loop 2-20"
        '
        'btnPreFor
        '
        Me.btnPreFor.Location = New System.Drawing.Point(138, 166)
        Me.btnPreFor.Name = "btnPreFor"
        Me.btnPreFor.Size = New System.Drawing.Size(124, 30)
        Me.btnPreFor.TabIndex = 5
        Me.btnPreFor.Text = "Pretest: For"
        Me.btnPreFor.UseVisualStyleBackColor = True
        '
        'btnPostUntil
        '
        Me.btnPostUntil.Location = New System.Drawing.Point(138, 130)
        Me.btnPostUntil.Name = "btnPostUntil"
        Me.btnPostUntil.Size = New System.Drawing.Size(124, 30)
        Me.btnPostUntil.TabIndex = 4
        Me.btnPostUntil.Text = "Posttest: Loop until"
        Me.btnPostUntil.UseVisualStyleBackColor = True
        '
        'btnPostWhile
        '
        Me.btnPostWhile.Location = New System.Drawing.Point(138, 94)
        Me.btnPostWhile.Name = "btnPostWhile"
        Me.btnPostWhile.Size = New System.Drawing.Size(124, 30)
        Me.btnPostWhile.TabIndex = 3
        Me.btnPostWhile.Text = "Posttest: Loop While"
        Me.btnPostWhile.UseVisualStyleBackColor = True
        '
        'btnPreDoUntil
        '
        Me.btnPreDoUntil.Location = New System.Drawing.Point(138, 58)
        Me.btnPreDoUntil.Name = "btnPreDoUntil"
        Me.btnPreDoUntil.Size = New System.Drawing.Size(124, 30)
        Me.btnPreDoUntil.TabIndex = 2
        Me.btnPreDoUntil.Text = "Pretest: Do Until"
        Me.btnPreDoUntil.UseVisualStyleBackColor = True
        '
        'btnPreDoWhile
        '
        Me.btnPreDoWhile.Location = New System.Drawing.Point(138, 22)
        Me.btnPreDoWhile.Name = "btnPreDoWhile"
        Me.btnPreDoWhile.Size = New System.Drawing.Size(124, 30)
        Me.btnPreDoWhile.TabIndex = 1
        Me.btnPreDoWhile.Text = "Pretest: Do While"
        Me.btnPreDoWhile.UseVisualStyleBackColor = True
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(11, 19)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(121, 177)
        Me.lblEven.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.txtBoxNum)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumWhile)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p348 #22 Addition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Count:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Average:"
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(117, 142)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(99, 30)
        Me.btnSumForNext.TabIndex = 6
        Me.btnSumForNext.Text = "p332:  For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumUntil
        '
        Me.btnSumUntil.Location = New System.Drawing.Point(117, 106)
        Me.btnSumUntil.Name = "btnSumUntil"
        Me.btnSumUntil.Size = New System.Drawing.Size(99, 30)
        Me.btnSumUntil.TabIndex = 5
        Me.btnSumUntil.Text = "p332: Loop Until"
        Me.btnSumUntil.UseVisualStyleBackColor = True
        '
        'btnSumWhile
        '
        Me.btnSumWhile.Location = New System.Drawing.Point(117, 70)
        Me.btnSumWhile.Name = "btnSumWhile"
        Me.btnSumWhile.Size = New System.Drawing.Size(99, 30)
        Me.btnSumWhile.TabIndex = 4
        Me.btnSumWhile.Text = "p332: Do While"
        Me.btnSumWhile.UseVisualStyleBackColor = True
        '
        'txtBoxNum
        '
        Me.txtBoxNum.Location = New System.Drawing.Point(11, 25)
        Me.txtBoxNum.Multiline = True
        Me.txtBoxNum.Name = "txtBoxNum"
        Me.txtBoxNum.ReadOnly = True
        Me.txtBoxNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxNum.Size = New System.Drawing.Size(100, 147)
        Me.txtBoxNum.TabIndex = 9
        Me.txtBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(117, 41)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 23)
        Me.lblAverage.TabIndex = 10
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(169, 41)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(50, 23)
        Me.lblCount.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 239)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber3a1 Loops, sum, count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPreFor As Button
    Friend WithEvents btnPostUntil As Button
    Friend WithEvents btnPostWhile As Button
    Friend WithEvents btnPreDoUntil As Button
    Friend WithEvents btnPreDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumUntil As Button
    Friend WithEvents btnSumWhile As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxNum As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAverage As Label
End Class
