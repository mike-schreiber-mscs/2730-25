<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboSearchValue = New System.Windows.Forms.ComboBox()
        Me.cboSearchRange = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCommissionValues = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSearchCount = New System.Windows.Forms.Label()
        Me.lblSearchRangeCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSearchValue
        '
        Me.cboSearchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValue.FormattingEnabled = True
        Me.cboSearchValue.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValue.Location = New System.Drawing.Point(122, 104)
        Me.cboSearchValue.Name = "cboSearchValue"
        Me.cboSearchValue.Size = New System.Drawing.Size(121, 85)
        Me.cboSearchValue.TabIndex = 0
        '
        'cboSearchRange
        '
        Me.cboSearchRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRange.FormattingEnabled = True
        Me.cboSearchRange.Items.AddRange(New Object() {"   0 - 200", "100 - 300", "700  - 800"})
        Me.cboSearchRange.Location = New System.Drawing.Point(122, 201)
        Me.cboSearchRange.Name = "cboSearchRange"
        Me.cboSearchRange.Size = New System.Drawing.Size(121, 72)
        Me.cboSearchRange.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Commission values:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search for value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search for range:"
        '
        'lblCommissionValues
        '
        Me.lblCommissionValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionValues.Location = New System.Drawing.Point(122, 11)
        Me.lblCommissionValues.Name = "lblCommissionValues"
        Me.lblCommissionValues.Size = New System.Drawing.Size(266, 74)
        Me.lblCommissionValues.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Count:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Count:"
        '
        'lblSearchCount
        '
        Me.lblSearchCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSearchCount.Location = New System.Drawing.Point(299, 106)
        Me.lblSearchCount.Name = "lblSearchCount"
        Me.lblSearchCount.Size = New System.Drawing.Size(89, 30)
        Me.lblSearchCount.TabIndex = 8
        '
        'lblSearchRangeCount
        '
        Me.lblSearchRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSearchRangeCount.Location = New System.Drawing.Point(299, 204)
        Me.lblSearchRangeCount.Name = "lblSearchRangeCount"
        Me.lblSearchRangeCount.Size = New System.Drawing.Size(89, 30)
        Me.lblSearchRangeCount.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 278)
        Me.Controls.Add(Me.lblSearchRangeCount)
        Me.Controls.Add(Me.lblSearchCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommissionValues)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSearchRange)
        Me.Controls.Add(Me.cboSearchValue)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mschreiber3e1 Arrays, Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSearchValue As ComboBox
    Friend WithEvents cboSearchRange As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCommissionValues As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSearchCount As Label
    Friend WithEvents lblSearchRangeCount As Label
End Class
