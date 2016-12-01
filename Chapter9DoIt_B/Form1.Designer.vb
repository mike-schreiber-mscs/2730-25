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
        Me.lstBoxForEach = New System.Windows.Forms.ListBox()
        Me.lstBoxDoLoop = New System.Windows.Forms.ListBox()
        Me.lstBoxForNext = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxForEach
        '
        Me.lstBoxForEach.FormattingEnabled = True
        Me.lstBoxForEach.Location = New System.Drawing.Point(16, 12)
        Me.lstBoxForEach.Name = "lstBoxForEach"
        Me.lstBoxForEach.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxForEach.TabIndex = 0
        '
        'lstBoxDoLoop
        '
        Me.lstBoxDoLoop.FormattingEnabled = True
        Me.lstBoxDoLoop.Location = New System.Drawing.Point(142, 12)
        Me.lstBoxDoLoop.Name = "lstBoxDoLoop"
        Me.lstBoxDoLoop.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxDoLoop.TabIndex = 1
        '
        'lstBoxForNext
        '
        Me.lstBoxForNext.FormattingEnabled = True
        Me.lstBoxForNext.Location = New System.Drawing.Point(268, 12)
        Me.lstBoxForNext.Name = "lstBoxForNext"
        Me.lstBoxForNext.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxForNext.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(124, 141)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 179)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstBoxForNext)
        Me.Controls.Add(Me.lstBoxDoLoop)
        Me.Controls.Add(Me.lstBoxForEach)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoI_B"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxForEach As ListBox
    Friend WithEvents lstBoxDoLoop As ListBox
    Friend WithEvents lstBoxForNext As ListBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
