﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chargeAmt
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.txtamt = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.txtamt)
		Me.GroupBox1.Location = New System.Drawing.Point(51, 27)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(259, 147)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(78, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(199, 15)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Enter The Chargeable Amount"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(133, 89)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(70, 23)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(39, 89)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(62, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Submit"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'txtamt
		'
		Me.txtamt.Location = New System.Drawing.Point(39, 45)
		Me.txtamt.Name = "txtamt"
		Me.txtamt.Size = New System.Drawing.Size(164, 20)
		Me.txtamt.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(125, 26)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(42, 16)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Label2"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(36, 26)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 16)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Product Name:"
		'
		'chargeAmt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(360, 203)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "chargeAmt"
		Me.Text = "chargeAmt"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents txtamt As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
