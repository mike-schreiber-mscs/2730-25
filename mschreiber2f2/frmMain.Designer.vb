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
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResortFeeChg = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTaxChg = New System.Windows.Forms.Label()
        Me.lblRoomChg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtRooms = New System.Windows.Forms.TextBox()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.lblRooms = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblResortFee = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpBoxBeds = New System.Windows.Forms.GroupBox()
        Me.grpBoxView = New System.Windows.Forms.GroupBox()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.radKing = New System.Windows.Forms.RadioButton()
        Me.radAtrium = New System.Windows.Forms.RadioButton()
        Me.radStand = New System.Windows.Forms.RadioButton()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.lblParkingChg = New System.Windows.Forms.Label()
        Me.chkParkingFee = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpBoxBeds.SuspendLayout()
        Me.grpBoxView.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(102, 160)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(93, 26)
        Me.lblTotalAmountDue.TabIndex = 9
        Me.lblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResortFeeChg
        '
        Me.lblResortFeeChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResortFeeChg.Location = New System.Drawing.Point(102, 98)
        Me.lblResortFeeChg.Name = "lblResortFeeChg"
        Me.lblResortFeeChg.Size = New System.Drawing.Size(93, 26)
        Me.lblResortFeeChg.TabIndex = 7
        Me.lblResortFeeChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(136, 355)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(97, 31)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Ca&lculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTaxChg
        '
        Me.lblTaxChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxChg.Location = New System.Drawing.Point(102, 67)
        Me.lblTaxChg.Name = "lblTaxChg"
        Me.lblTaxChg.Size = New System.Drawing.Size(93, 26)
        Me.lblTaxChg.TabIndex = 6
        Me.lblTaxChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomChg
        '
        Me.lblRoomChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomChg.Location = New System.Drawing.Point(102, 36)
        Me.lblRoomChg.Name = "lblRoomChg"
        Me.lblRoomChg.Size = New System.Drawing.Size(93, 26)
        Me.lblRoomChg.TabIndex = 5
        Me.lblRoomChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtChildren)
        Me.GroupBox1.Controls.Add(Me.txtAdults)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.txtRooms)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Controls.Add(Me.lblChildren)
        Me.GroupBox1.Controls.Add(Me.lblAdults)
        Me.GroupBox1.Controls.Add(Me.lblRooms)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of"
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(135, 129)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(40, 27)
        Me.txtChildren.TabIndex = 7
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(21, 129)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(40, 27)
        Me.txtAdults.TabIndex = 5
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(135, 61)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(40, 27)
        Me.txtNights.TabIndex = 3
        '
        'txtRooms
        '
        Me.txtRooms.Location = New System.Drawing.Point(21, 61)
        Me.txtRooms.Name = "txtRooms"
        Me.txtRooms.Size = New System.Drawing.Size(40, 27)
        Me.txtRooms.TabIndex = 1
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(131, 38)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(55, 20)
        Me.lblNights.TabIndex = 2
        Me.lblNights.Text = "&Nights:"
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.Location = New System.Drawing.Point(131, 106)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(67, 20)
        Me.lblChildren.TabIndex = 6
        Me.lblChildren.Text = "&Children:"
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.Location = New System.Drawing.Point(17, 106)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(94, 20)
        Me.lblAdults.TabIndex = 4
        Me.lblAdults.Text = "&Adults (18+):"
        '
        'lblRooms
        '
        Me.lblRooms.AutoSize = True
        Me.lblRooms.Location = New System.Drawing.Point(17, 38)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(58, 20)
        Me.lblRooms.TabIndex = 0
        Me.lblRooms.Text = "&Rooms:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(18, 167)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(75, 20)
        Me.lblTotalDue.TabIndex = 4
        Me.lblTotalDue.Text = "Total due:"
        '
        'lblResortFee
        '
        Me.lblResortFee.AutoSize = True
        Me.lblResortFee.Location = New System.Drawing.Point(18, 103)
        Me.lblResortFee.Name = "lblResortFee"
        Me.lblResortFee.Size = New System.Drawing.Size(79, 20)
        Me.lblResortFee.TabIndex = 2
        Me.lblResortFee.Text = "Resort fee:"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(18, 39)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(52, 20)
        Me.lblRoom.TabIndex = 0
        Me.lblRoom.Text = "Room:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tax:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mschreiber2f2.My.Resources.Resources.Tree
        Me.PictureBox1.Location = New System.Drawing.Point(21, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblParkingChg)
        Me.GroupBox2.Controls.Add(Me.lblParking)
        Me.GroupBox2.Controls.Add(Me.lblResortFeeChg)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmountDue)
        Me.GroupBox2.Controls.Add(Me.lblRoom)
        Me.GroupBox2.Controls.Add(Me.lblResortFee)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.lblRoomChg)
        Me.GroupBox2.Controls.Add(Me.lblTaxChg)
        Me.GroupBox2.Location = New System.Drawing.Point(365, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 189)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'grpBoxBeds
        '
        Me.grpBoxBeds.Controls.Add(Me.radKing)
        Me.grpBoxBeds.Controls.Add(Me.radQueen)
        Me.grpBoxBeds.Location = New System.Drawing.Point(21, 34)
        Me.grpBoxBeds.Name = "grpBoxBeds"
        Me.grpBoxBeds.Size = New System.Drawing.Size(138, 100)
        Me.grpBoxBeds.TabIndex = 3
        Me.grpBoxBeds.TabStop = False
        Me.grpBoxBeds.Text = "Type"
        '
        'grpBoxView
        '
        Me.grpBoxView.Controls.Add(Me.radAtrium)
        Me.grpBoxView.Controls.Add(Me.radStand)
        Me.grpBoxView.Location = New System.Drawing.Point(184, 34)
        Me.grpBoxView.Name = "grpBoxView"
        Me.grpBoxView.Size = New System.Drawing.Size(138, 100)
        Me.grpBoxView.TabIndex = 4
        Me.grpBoxView.TabStop = False
        Me.grpBoxView.Text = "View"
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Checked = True
        Me.radQueen.Location = New System.Drawing.Point(19, 23)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(100, 24)
        Me.radQueen.TabIndex = 0
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "Two &queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'radKing
        '
        Me.radKing.AutoSize = True
        Me.radKing.Location = New System.Drawing.Point(19, 53)
        Me.radKing.Name = "radKing"
        Me.radKing.Size = New System.Drawing.Size(86, 24)
        Me.radKing.TabIndex = 1
        Me.radKing.Text = "One &king"
        Me.radKing.UseVisualStyleBackColor = True
        '
        'radAtrium
        '
        Me.radAtrium.AutoSize = True
        Me.radAtrium.Location = New System.Drawing.Point(19, 56)
        Me.radAtrium.Name = "radAtrium"
        Me.radAtrium.Size = New System.Drawing.Size(72, 24)
        Me.radAtrium.TabIndex = 1
        Me.radAtrium.Text = "A&trium"
        Me.radAtrium.UseVisualStyleBackColor = True
        '
        'radStand
        '
        Me.radStand.AutoSize = True
        Me.radStand.Checked = True
        Me.radStand.Location = New System.Drawing.Point(19, 26)
        Me.radStand.Name = "radStand"
        Me.radStand.Size = New System.Drawing.Size(87, 24)
        Me.radStand.TabIndex = 0
        Me.radStand.TabStop = True
        Me.radStand.Text = "&Standard"
        Me.radStand.UseVisualStyleBackColor = True
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.Location = New System.Drawing.Point(18, 135)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(58, 20)
        Me.lblParking.TabIndex = 3
        Me.lblParking.Text = "Parking"
        '
        'lblParkingChg
        '
        Me.lblParkingChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParkingChg.Location = New System.Drawing.Point(102, 129)
        Me.lblParkingChg.Name = "lblParkingChg"
        Me.lblParkingChg.Size = New System.Drawing.Size(93, 26)
        Me.lblParkingChg.TabIndex = 8
        Me.lblParkingChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkParkingFee
        '
        Me.chkParkingFee.AutoSize = True
        Me.chkParkingFee.Location = New System.Drawing.Point(341, 57)
        Me.chkParkingFee.Name = "chkParkingFee"
        Me.chkParkingFee.Size = New System.Drawing.Size(155, 24)
        Me.chkParkingFee.TabIndex = 5
        Me.chkParkingFee.Text = "&Vehicle parking fee"
        Me.chkParkingFee.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 415)
        Me.Controls.Add(Me.chkParkingFee)
        Me.Controls.Add(Me.grpBoxView)
        Me.Controls.Add(Me.grpBoxBeds)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treeline Resort"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpBoxBeds.ResumeLayout(False)
        Me.grpBoxBeds.PerformLayout()
        Me.grpBoxView.ResumeLayout(False)
        Me.grpBoxView.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalAmountDue As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResortFeeChg As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTaxChg As Label
    Friend WithEvents lblRoomChg As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtChildren As TextBox
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents txtRooms As TextBox
    Friend WithEvents lblNights As Label
    Friend WithEvents lblChildren As Label
    Friend WithEvents lblAdults As Label
    Friend WithEvents lblRooms As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblResortFee As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblParkingChg As Label
    Friend WithEvents lblParking As Label
    Friend WithEvents grpBoxBeds As GroupBox
    Friend WithEvents radKing As RadioButton
    Friend WithEvents radQueen As RadioButton
    Friend WithEvents grpBoxView As GroupBox
    Friend WithEvents radAtrium As RadioButton
    Friend WithEvents radStand As RadioButton
    Friend WithEvents chkParkingFee As CheckBox
End Class
