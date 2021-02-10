<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateProdName
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
		Me.Lable1 = New System.Windows.Forms.Label()
		Me.txtprodnm = New System.Windows.Forms.TextBox()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtserialno = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtprodid = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Lable1
		'
		Me.Lable1.AutoSize = True
		Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lable1.Location = New System.Drawing.Point(44, 89)
		Me.Lable1.Name = "Lable1"
		Me.Lable1.Size = New System.Drawing.Size(102, 15)
		Me.Lable1.TabIndex = 0
		Me.Lable1.Text = "Product Name:"
		'
		'txtprodnm
		'
		Me.txtprodnm.Location = New System.Drawing.Point(47, 117)
		Me.txtprodnm.Name = "txtprodnm"
		Me.txtprodnm.Size = New System.Drawing.Size(191, 20)
		Me.txtprodnm.TabIndex = 1
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(47, 209)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 2
		Me.btnAdd.Text = "Update"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(163, 209)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 502
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(44, 141)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 15)
		Me.Label1.TabIndex = 503
		Me.Label1.Text = "Serial No.:"
		'
		'txtserialno
		'
		Me.txtserialno.Location = New System.Drawing.Point(47, 169)
		Me.txtserialno.Name = "txtserialno"
		Me.txtserialno.Size = New System.Drawing.Size(191, 20)
		Me.txtserialno.TabIndex = 504
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
		'txtprodid
		'
		Me.txtprodid.Location = New System.Drawing.Point(47, 56)
		Me.txtprodid.Name = "txtprodid"
		Me.txtprodid.Size = New System.Drawing.Size(191, 20)
		Me.txtprodid.TabIndex = 506
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(78, 238)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(191, 20)
		Me.TextBox1.TabIndex = 507
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.txtprodid)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtserialno)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.btnAdd)
		Me.GroupBox1.Controls.Add(Me.txtprodnm)
		Me.GroupBox1.Controls.Add(Me.Lable1)
		Me.GroupBox1.Location = New System.Drawing.Point(61, 22)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(327, 271)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Product Name"
		'
		'updateProdName
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(425, 321)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "updateProdName"
		Me.Text = "updateProdName"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Lable1 As Label
	Friend WithEvents txtprodnm As TextBox
	Friend WithEvents btnAdd As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents txtserialno As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtprodid As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents GroupBox1 As GroupBox
End Class
