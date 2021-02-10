<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvertProdUpdate
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
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtprodName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnclose = New System.Windows.Forms.Button()
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtamt = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtrepairMan = New System.Windows.Forms.TextBox()
		Me.txtretrunremark = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(338, 35)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
		Me.DateTimePicker1.TabIndex = 113
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(335, 13)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(52, 18)
		Me.Label7.TabIndex = 112
		Me.Label7.Text = "In Date:"
		'
		'txtprodName
		'
		Me.txtprodName.BackColor = System.Drawing.SystemColors.Info
		Me.txtprodName.Location = New System.Drawing.Point(176, 91)
		Me.txtprodName.Name = "txtprodName"
		Me.txtprodName.Size = New System.Drawing.Size(141, 20)
		Me.txtprodName.TabIndex = 110
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(173, 70)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 18)
		Me.Label3.TabIndex = 111
		Me.Label3.Text = "ProductName:"
		'
		'btnclose
		'
		Me.btnclose.Location = New System.Drawing.Point(208, 335)
		Me.btnclose.Name = "btnclose"
		Me.btnclose.Size = New System.Drawing.Size(75, 23)
		Me.btnclose.TabIndex = 109
		Me.btnclose.Text = "Close"
		Me.btnclose.UseVisualStyleBackColor = True
		'
		'btnupdate
		'
		Me.btnupdate.Location = New System.Drawing.Point(31, 335)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(75, 23)
		Me.btnupdate.TabIndex = 108
		Me.btnupdate.Text = "Update"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'txtjobid
		'
		Me.txtjobid.BackColor = System.Drawing.SystemColors.Info
		Me.txtjobid.Location = New System.Drawing.Point(12, 91)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(141, 20)
		Me.txtjobid.TabIndex = 106
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(9, 70)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 18)
		Me.Label1.TabIndex = 107
		Me.Label1.Text = "ProductID:"
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(680, 34)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 104
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(677, 14)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 18)
		Me.Label2.TabIndex = 105
		Me.Label2.Text = "Job Status:"
		'
		'txtamt
		'
		Me.txtamt.BackColor = System.Drawing.SystemColors.Info
		Me.txtamt.Location = New System.Drawing.Point(510, 35)
		Me.txtamt.Name = "txtamt"
		Me.txtamt.Size = New System.Drawing.Size(141, 20)
		Me.txtamt.TabIndex = 45
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(507, 14)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(59, 18)
		Me.Label5.TabIndex = 46
		Me.Label5.Text = "Charges :"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(173, 14)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(102, 18)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "RepairManName:"
		'
		'txtrepairMan
		'
		Me.txtrepairMan.BackColor = System.Drawing.SystemColors.Info
		Me.txtrepairMan.Location = New System.Drawing.Point(176, 35)
		Me.txtrepairMan.Name = "txtrepairMan"
		Me.txtrepairMan.Size = New System.Drawing.Size(141, 20)
		Me.txtrepairMan.TabIndex = 39
		'
		'txtretrunremark
		'
		Me.txtretrunremark.BackColor = System.Drawing.SystemColors.Info
		Me.txtretrunremark.Location = New System.Drawing.Point(18, 209)
		Me.txtretrunremark.Multiline = True
		Me.txtretrunremark.Name = "txtretrunremark"
		Me.txtretrunremark.Size = New System.Drawing.Size(331, 67)
		Me.txtretrunremark.TabIndex = 41
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(15, 188)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(68, 18)
		Me.Label6.TabIndex = 42
		Me.Label6.Text = "In-Remark:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.TextBox1)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.cmbjobst)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.txtprodName)
		Me.GroupBox2.Controls.Add(Me.txtamt)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.txtjobid)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.txtrepairMan)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(866, 143)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "GroupBox2"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(393, 188)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(487, 170)
		Me.DataGridView1.TabIndex = 110
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
		Me.TextBox1.Location = New System.Drawing.Point(19, 35)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(141, 20)
		Me.TextBox1.TabIndex = 111
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(14, 16)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(47, 18)
		Me.Label8.TabIndex = 112
		Me.Label8.Text = "Job ID:"
		'
		'InvertProdUpdate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(908, 447)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.btnclose)
		Me.Controls.Add(Me.btnupdate)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.txtretrunremark)
		Me.Controls.Add(Me.Label6)
		Me.Name = "InvertProdUpdate"
		Me.Text = "InvertProdUpdate"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtamt As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtrepairMan As TextBox
	Friend WithEvents txtretrunremark As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnclose As Button
	Friend WithEvents btnupdate As Button
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtprodName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label8 As Label
End Class
