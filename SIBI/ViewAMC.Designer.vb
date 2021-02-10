<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAMC
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
		Me.btnshow = New System.Windows.Forms.Button()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.btnshow)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.cmbjobst)
		Me.GroupBox1.Controls.Add(Me.DataGridView1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1054, 511)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "AMC List"
		'
		'btnshow
		'
		Me.btnshow.Location = New System.Drawing.Point(891, 44)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(137, 23)
		Me.btnshow.TabIndex = 131
		Me.btnshow.Text = "Add AMC"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(16, 22)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(42, 18)
		Me.Label14.TabIndex = 130
		Me.Label14.Text = "Status"
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(16, 44)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 129
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(16, 81)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1012, 412)
		Me.DataGridView1.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(434, 22)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 25)
		Me.Label3.TabIndex = 132
		Me.Label3.Text = "AMC List"
		'
		'ViewAMC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1078, 537)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "ViewAMC"
		Me.Text = "ViewAMC"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label14 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents btnshow As Button
	Friend WithEvents Label3 As Label
End Class
