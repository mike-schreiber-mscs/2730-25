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
        Me.lblNumElements = New System.Windows.Forms.Label()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumElements
        '
        Me.lblNumElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumElements.Location = New System.Drawing.Point(139, 9)
        Me.lblNumElements.Name = "lblNumElements"
        Me.lblNumElements.Size = New System.Drawing.Size(61, 23)
        Me.lblNumElements.TabIndex = 0
        '
        'lblUpperBound
        '
        Me.lblUpperBound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpperBound.Location = New System.Drawing.Point(139, 41)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(61, 23)
        Me.lblUpperBound.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(69, 85)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(17, 41)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(78, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Upper Bounds:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(17, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(105, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Number of Elements:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 120)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblUpperBound)
        Me.Controls.Add(Me.lblNumElements)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoIt_A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumElements As Label
    Friend WithEvents lblUpperBound As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
End Class
