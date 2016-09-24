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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTestScore1 = New System.Windows.Forms.Label()
        Me.lblTestScore2 = New System.Windows.Forms.Label()
        Me.lblTestScore3 = New System.Windows.Forms.Label()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.lblAverageTestScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(203, 49)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 30)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(203, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(203, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTestScore1
        '
        Me.lblTestScore1.AutoSize = True
        Me.lblTestScore1.Location = New System.Drawing.Point(19, 50)
        Me.lblTestScore1.Name = "lblTestScore1"
        Me.lblTestScore1.Size = New System.Drawing.Size(90, 20)
        Me.lblTestScore1.TabIndex = 0
        Me.lblTestScore1.Text = "Test score &1:"
        '
        'lblTestScore2
        '
        Me.lblTestScore2.AutoSize = True
        Me.lblTestScore2.Location = New System.Drawing.Point(19, 85)
        Me.lblTestScore2.Name = "lblTestScore2"
        Me.lblTestScore2.Size = New System.Drawing.Size(90, 20)
        Me.lblTestScore2.TabIndex = 2
        Me.lblTestScore2.Text = "Test score &2:"
        '
        'lblTestScore3
        '
        Me.lblTestScore3.AutoSize = True
        Me.lblTestScore3.Location = New System.Drawing.Point(19, 120)
        Me.lblTestScore3.Name = "lblTestScore3"
        Me.lblTestScore3.Size = New System.Drawing.Size(90, 20)
        Me.lblTestScore3.TabIndex = 4
        Me.lblTestScore3.Text = "Test score &3:"
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Location = New System.Drawing.Point(19, 168)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(134, 20)
        Me.lblAverageScore.TabIndex = 9
        Me.lblAverageScore.Text = "Average test score:"
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(115, 117)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(64, 27)
        Me.txtScore3.TabIndex = 5
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(115, 82)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(64, 27)
        Me.txtScore2.TabIndex = 3
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(115, 47)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(64, 27)
        Me.txtScore1.TabIndex = 1
        '
        'lblAverageTestScore
        '
        Me.lblAverageTestScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageTestScore.Location = New System.Drawing.Point(159, 167)
        Me.lblAverageTestScore.Name = "lblAverageTestScore"
        Me.lblAverageTestScore.Size = New System.Drawing.Size(64, 27)
        Me.lblAverageTestScore.TabIndex = 10
        Me.lblAverageTestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 238)
        Me.Controls.Add(Me.lblAverageTestScore)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.lblTestScore3)
        Me.Controls.Add(Me.lblTestScore2)
        Me.Controls.Add(Me.lblTestScore1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber1g1: Average Test Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTestScore1 As Label
    Friend WithEvents lblTestScore2 As Label
    Friend WithEvents lblTestScore3 As Label
    Friend WithEvents lblAverageScore As Label
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents lblAverageTestScore As Label
End Class
