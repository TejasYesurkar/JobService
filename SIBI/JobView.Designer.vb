<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobView
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtjobid = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtjobdate = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtcustname = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtcomp = New System.Windows.Forms.RichTextBox()
		Me.txtremk = New System.Windows.Forms.RichTextBox()
		Me.s = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Algerian", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(133, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(82, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Job View"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(42, 16)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "JobID:"
		'
		'txtjobid
		'
		Me.txtjobid.AutoSize = True
		Me.txtjobid.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtjobid.Location = New System.Drawing.Point(56, 16)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(0, 16)
		Me.txtjobid.TabIndex = 2
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(185, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(56, 16)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "JobDate:"
		'
		'txtjobdate
		'
		Me.txtjobdate.AutoSize = True
		Me.txtjobdate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtjobdate.Location = New System.Drawing.Point(247, 16)
		Me.txtjobdate.Name = "txtjobdate"
		Me.txtjobdate.Size = New System.Drawing.Size(0, 16)
		Me.txtjobdate.TabIndex = 6
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(8, 46)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(92, 16)
		Me.Label7.TabIndex = 5
		Me.Label7.Text = "CustomerName:"
		'
		'txtcustname
		'
		Me.txtcustname.AutoSize = True
		Me.txtcustname.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcustname.Location = New System.Drawing.Point(106, 46)
		Me.txtcustname.Name = "txtcustname"
		Me.txtcustname.Size = New System.Drawing.Size(0, 16)
		Me.txtcustname.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtjobdate)
		Me.GroupBox1.Controls.Add(Me.txtcustname)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtjobid)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Location = New System.Drawing.Point(15, 52)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(325, 82)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "JobDetails"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(23, 152)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(115, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Complain By Customer:"
		'
		'txtcomp
		'
		Me.txtcomp.Location = New System.Drawing.Point(26, 168)
		Me.txtcomp.Name = "txtcomp"
		Me.txtcomp.Size = New System.Drawing.Size(314, 45)
		Me.txtcomp.TabIndex = 10
		Me.txtcomp.Text = ""
		'
		'txtremk
		'
		Me.txtremk.Location = New System.Drawing.Point(26, 241)
		Me.txtremk.Name = "txtremk"
		Me.txtremk.Size = New System.Drawing.Size(314, 45)
		Me.txtremk.TabIndex = 12
		Me.txtremk.Text = ""
		'
		's
		'
		Me.s.AutoSize = True
		Me.s.Location = New System.Drawing.Point(23, 225)
		Me.s.Name = "s"
		Me.s.Size = New System.Drawing.Size(47, 13)
		Me.s.TabIndex = 11
		Me.s.Text = "Remark:"
		'
		'JobView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(352, 344)
		Me.Controls.Add(Me.txtremk)
		Me.Controls.Add(Me.s)
		Me.Controls.Add(Me.txtcomp)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "JobView"
		Me.Text = "JobView"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtjobid As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtjobdate As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtcustname As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtcomp As RichTextBox
	Friend WithEvents txtremk As RichTextBox
	Friend WithEvents s As Label
End Class
