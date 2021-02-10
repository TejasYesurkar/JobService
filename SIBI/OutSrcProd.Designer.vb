<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OutSrcProd
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnfetch = New System.Windows.Forms.Button()
		Me.ProductDetalis = New System.Windows.Forms.GroupBox()
		Me.txtservicetyp = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.dpoutdate = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtestmatevalue = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtoutremark = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtrepairMan = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtprblmdesc = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtcustNm = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ProductDetalis.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(32, 213)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(925, 294)
		Me.DataGridView1.TabIndex = 0
		'
		'txtjobid
		'
		Me.txtjobid.Location = New System.Drawing.Point(110, 21)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(141, 20)
		Me.txtjobid.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(57, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 18)
		Me.Label1.TabIndex = 100
		Me.Label1.Text = "Job ID:"
		'
		'btnfetch
		'
		Me.btnfetch.Location = New System.Drawing.Point(257, 17)
		Me.btnfetch.Name = "btnfetch"
		Me.btnfetch.Size = New System.Drawing.Size(75, 23)
		Me.btnfetch.TabIndex = 2
		Me.btnfetch.TabStop = False
		Me.btnfetch.Text = "&Fetch"
		Me.btnfetch.UseVisualStyleBackColor = True
		'
		'ProductDetalis
		'
		Me.ProductDetalis.Controls.Add(Me.txtservicetyp)
		Me.ProductDetalis.Controls.Add(Me.Label8)
		Me.ProductDetalis.Controls.Add(Me.dpoutdate)
		Me.ProductDetalis.Controls.Add(Me.Label7)
		Me.ProductDetalis.Controls.Add(Me.txtestmatevalue)
		Me.ProductDetalis.Controls.Add(Me.Label6)
		Me.ProductDetalis.Controls.Add(Me.txtoutremark)
		Me.ProductDetalis.Controls.Add(Me.Label5)
		Me.ProductDetalis.Controls.Add(Me.txtrepairMan)
		Me.ProductDetalis.Controls.Add(Me.Label4)
		Me.ProductDetalis.Controls.Add(Me.txtprblmdesc)
		Me.ProductDetalis.Controls.Add(Me.Label3)
		Me.ProductDetalis.Controls.Add(Me.txtcustNm)
		Me.ProductDetalis.Controls.Add(Me.Label2)
		Me.ProductDetalis.Controls.Add(Me.btnfetch)
		Me.ProductDetalis.Controls.Add(Me.txtjobid)
		Me.ProductDetalis.Controls.Add(Me.Label1)
		Me.ProductDetalis.Location = New System.Drawing.Point(32, 16)
		Me.ProductDetalis.Name = "ProductDetalis"
		Me.ProductDetalis.Size = New System.Drawing.Size(925, 180)
		Me.ProductDetalis.TabIndex = 5
		Me.ProductDetalis.TabStop = False
		Me.ProductDetalis.Text = "OutSrc-Product"
		'
		'txtservicetyp
		'
		Me.txtservicetyp.Location = New System.Drawing.Point(338, 140)
		Me.txtservicetyp.Name = "txtservicetyp"
		Me.txtservicetyp.Size = New System.Drawing.Size(103, 20)
		Me.txtservicetyp.TabIndex = 1127
		'
		'Label8
		'
		Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(247, 141)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 18)
		Me.Label8.TabIndex = 1126
		Me.Label8.Text = "Service Type:"
		'
		'dpoutdate
		'
		Me.dpoutdate.Location = New System.Drawing.Point(110, 140)
		Me.dpoutdate.Name = "dpoutdate"
		Me.dpoutdate.Size = New System.Drawing.Size(118, 20)
		Me.dpoutdate.TabIndex = 1125
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(41, 143)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(62, 18)
		Me.Label7.TabIndex = 1124
		Me.Label7.Text = "Out Date:"
		'
		'txtestmatevalue
		'
		Me.txtestmatevalue.Location = New System.Drawing.Point(571, 45)
		Me.txtestmatevalue.Name = "txtestmatevalue"
		Me.txtestmatevalue.Size = New System.Drawing.Size(331, 20)
		Me.txtestmatevalue.TabIndex = 6
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(468, 45)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(97, 18)
		Me.Label6.TabIndex = 34
		Me.Label6.Text = "Estimate Value:"
		'
		'txtoutremark
		'
		Me.txtoutremark.Location = New System.Drawing.Point(571, 67)
		Me.txtoutremark.Multiline = True
		Me.txtoutremark.Name = "txtoutremark"
		Me.txtoutremark.Size = New System.Drawing.Size(331, 67)
		Me.txtoutremark.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(491, 67)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(74, 18)
		Me.Label5.TabIndex = 432
		Me.Label5.Text = "OutRemark:"
		'
		'txtrepairMan
		'
		Me.txtrepairMan.Location = New System.Drawing.Point(571, 19)
		Me.txtrepairMan.Name = "txtrepairMan"
		Me.txtrepairMan.Size = New System.Drawing.Size(222, 20)
		Me.txtrepairMan.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(463, 21)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(102, 18)
		Me.Label4.TabIndex = 121
		Me.Label4.Text = "RepairManName:"
		'
		'txtprblmdesc
		'
		Me.txtprblmdesc.Location = New System.Drawing.Point(110, 74)
		Me.txtprblmdesc.Multiline = True
		Me.txtprblmdesc.Name = "txtprblmdesc"
		Me.txtprblmdesc.Size = New System.Drawing.Size(331, 60)
		Me.txtprblmdesc.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(19, 74)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(85, 18)
		Me.Label3.TabIndex = 1123
		Me.Label3.Text = "ProblemDesc:"
		'
		'txtcustNm
		'
		Me.txtcustNm.Location = New System.Drawing.Point(110, 47)
		Me.txtcustNm.Name = "txtcustNm"
		Me.txtcustNm.Size = New System.Drawing.Size(331, 20)
		Me.txtcustNm.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(91, 18)
		Me.Label2.TabIndex = 111
		Me.Label2.Text = "CutomerName:"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(256, 531)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(164, 54)
		Me.Button1.TabIndex = 8
		Me.Button1.Text = "Submit"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(581, 531)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(164, 54)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Clear"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'OutSrcProd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1195, 667)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ProductDetalis)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "OutSrcProd"
		Me.Text = "OutSrcProd"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ProductDetalis.ResumeLayout(False)
		Me.ProductDetalis.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnfetch As Button
	Friend WithEvents ProductDetalis As GroupBox
	Friend WithEvents txtcustNm As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtrepairMan As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtprblmdesc As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents txtoutremark As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtestmatevalue As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents dpoutdate As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents txtservicetyp As TextBox
	Friend WithEvents Label8 As Label
End Class
