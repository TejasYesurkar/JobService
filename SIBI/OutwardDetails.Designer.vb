<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutwardDetails
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
		Me.txtprodid = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtserialno = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtprodnm = New System.Windows.Forms.TextBox()
		Me.Lable1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtoutremark = New System.Windows.Forms.TextBox()
		Me.txtoutrmrk = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtrepaireman = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtestval = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtchrg = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtprodid
		'
		Me.txtprodid.Location = New System.Drawing.Point(47, 46)
		Me.txtprodid.Name = "txtprodid"
		Me.txtprodid.Size = New System.Drawing.Size(226, 20)
		Me.txtprodid.TabIndex = 506
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(44, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 15)
		Me.Label2.TabIndex = 505
		Me.Label2.Text = "Product Id:"
		'
		'txtserialno
		'
		Me.txtserialno.Location = New System.Drawing.Point(47, 153)
		Me.txtserialno.Name = "txtserialno"
		Me.txtserialno.Size = New System.Drawing.Size(226, 20)
		Me.txtserialno.TabIndex = 504
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(44, 135)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 15)
		Me.Label1.TabIndex = 503
		Me.Label1.Text = "Serial No.:"
		'
		'txtprodnm
		'
		Me.txtprodnm.Location = New System.Drawing.Point(47, 102)
		Me.txtprodnm.Name = "txtprodnm"
		Me.txtprodnm.Size = New System.Drawing.Size(226, 20)
		Me.txtprodnm.TabIndex = 1
		'
		'Lable1
		'
		Me.Lable1.AutoSize = True
		Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lable1.Location = New System.Drawing.Point(44, 84)
		Me.Lable1.Name = "Lable1"
		Me.Lable1.Size = New System.Drawing.Size(102, 15)
		Me.Lable1.TabIndex = 0
		Me.Lable1.Text = "Product Name:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtchrg)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.txtestval)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.txtrepaireman)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtoutrmrk)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtoutremark)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtprodid)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtserialno)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtprodnm)
		Me.GroupBox1.Controls.Add(Me.Lable1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(691, 327)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Outward Details"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(45, 190)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 15)
		Me.Label3.TabIndex = 507
		Me.Label3.Text = "Out Remark:"
		'
		'txtoutremark
		'
		Me.txtoutremark.Location = New System.Drawing.Point(48, 208)
		Me.txtoutremark.Multiline = True
		Me.txtoutremark.Name = "txtoutremark"
		Me.txtoutremark.Size = New System.Drawing.Size(225, 66)
		Me.txtoutremark.TabIndex = 508
		'
		'txtoutrmrk
		'
		Me.txtoutrmrk.Location = New System.Drawing.Point(371, 153)
		Me.txtoutrmrk.Multiline = True
		Me.txtoutrmrk.Name = "txtoutrmrk"
		Me.txtoutrmrk.Size = New System.Drawing.Size(225, 66)
		Me.txtoutrmrk.TabIndex = 510
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(368, 135)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(77, 15)
		Me.Label4.TabIndex = 509
		Me.Label4.Text = "In Remark:"
		'
		'txtrepaireman
		'
		Me.txtrepaireman.Location = New System.Drawing.Point(371, 46)
		Me.txtrepaireman.Name = "txtrepaireman"
		Me.txtrepaireman.Size = New System.Drawing.Size(226, 20)
		Me.txtrepaireman.TabIndex = 514
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(368, 28)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(132, 15)
		Me.Label5.TabIndex = 513
		Me.Label5.Text = "Repaireman Name:"
		'
		'txtestval
		'
		Me.txtestval.Location = New System.Drawing.Point(371, 98)
		Me.txtestval.Name = "txtestval"
		Me.txtestval.Size = New System.Drawing.Size(99, 20)
		Me.txtestval.TabIndex = 516
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(368, 80)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(99, 15)
		Me.Label7.TabIndex = 515
		Me.Label7.Text = "Estimated Val:"
		'
		'txtchrg
		'
		Me.txtchrg.Location = New System.Drawing.Point(493, 98)
		Me.txtchrg.Name = "txtchrg"
		Me.txtchrg.Size = New System.Drawing.Size(104, 20)
		Me.txtchrg.TabIndex = 518
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(495, 80)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 15)
		Me.Label8.TabIndex = 517
		Me.Label8.Text = "Chargeable:"
		'
		'OutwardDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(754, 370)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "OutwardDetails"
		Me.Text = "OutwardDetails"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents txtprodid As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtserialno As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtprodnm As TextBox
	Friend WithEvents Lable1 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtchrg As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtestval As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtrepaireman As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtoutrmrk As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtoutremark As TextBox
	Friend WithEvents Label3 As Label
End Class
