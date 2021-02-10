<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddActivtyItem
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
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.txtitem = New System.Windows.Forms.TextBox()
		Me.Lable1 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.btnAdd)
		Me.GroupBox1.Controls.Add(Me.txtitem)
		Me.GroupBox1.Controls.Add(Me.Lable1)
		Me.GroupBox1.Location = New System.Drawing.Point(47, 38)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(300, 226)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Enter Password"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(166, 131)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 502
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(50, 131)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 2
		Me.btnAdd.Text = "Delete"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'txtitem
		'
		Me.txtitem.Location = New System.Drawing.Point(50, 85)
		Me.txtitem.Name = "txtitem"
		Me.txtitem.Size = New System.Drawing.Size(191, 20)
		Me.txtitem.TabIndex = 1
		'
		'Lable1
		'
		Me.Lable1.AutoSize = True
		Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lable1.Location = New System.Drawing.Point(47, 57)
		Me.Lable1.Name = "Lable1"
		Me.Lable1.Size = New System.Drawing.Size(131, 15)
		Me.Lable1.TabIndex = 0
		Me.Lable1.Text = "Enter the Password"
		'
		'AddActivtyItem
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(383, 291)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "AddActivtyItem"
		Me.Text = "AddActivtyItem"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtitem As TextBox
	Friend WithEvents Lable1 As Label
	Friend WithEvents btnAdd As Button
	Friend WithEvents Button2 As Button

End Class
