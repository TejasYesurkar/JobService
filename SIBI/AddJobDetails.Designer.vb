<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddJobDetails
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtcust_id = New System.Windows.Forms.TextBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.txtprodid = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtserialno = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.txtprodnm = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.deliveryLable = New System.Windows.Forms.Label()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.txtdilverystatus = New System.Windows.Forms.TextBox()
		Me.txtcomp = New System.Windows.Forms.TextBox()
		Me.txtserialaccess = New System.Windows.Forms.TextBox()
		Me.jobidchk = New System.Windows.Forms.CheckBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnremove = New System.Windows.Forms.Button()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.btnadditem = New System.Windows.Forms.Button()
		Me.txtAccessoies = New System.Windows.Forms.TextBox()
		Me.txtcmpnynm = New System.Windows.Forms.TextBox()
		Me.firm = New System.Windows.Forms.Label()
		Me.crm = New System.Windows.Forms.Button()
		Me.cmbservicetyp = New System.Windows.Forms.ComboBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.cmbjobstatus = New System.Windows.Forms.ComboBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtprejobid = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.dpestdate = New System.Windows.Forms.DateTimePicker()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtestval = New System.Windows.Forms.TextBox()
		Me.dpamc = New System.Windows.Forms.DateTimePicker()
		Me.txtrmrk = New System.Windows.Forms.RichTextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtobserv = New System.Windows.Forms.RichTextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtprodrep = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtmob = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtcustname = New System.Windows.Forms.TextBox()
		Me.lable1 = New System.Windows.Forms.Label()
		Me.dpjobdate = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnclear = New System.Windows.Forms.Button()
		Me.btnshow = New System.Windows.Forms.Button()
		Me.btnsaveupdate = New System.Windows.Forms.Button()
		Me.btnsave = New System.Windows.Forms.Button()
		Me.btnclose = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.GroupBox1.Controls.Add(Me.txtcust_id)
		Me.GroupBox1.Controls.Add(Me.GroupBox3)
		Me.GroupBox1.Controls.Add(Me.deliveryLable)
		Me.GroupBox1.Controls.Add(Me.DataGridView2)
		Me.GroupBox1.Controls.Add(Me.txtdilverystatus)
		Me.GroupBox1.Controls.Add(Me.txtcomp)
		Me.GroupBox1.Controls.Add(Me.txtserialaccess)
		Me.GroupBox1.Controls.Add(Me.jobidchk)
		Me.GroupBox1.Controls.Add(Me.DataGridView1)
		Me.GroupBox1.Controls.Add(Me.btnremove)
		Me.GroupBox1.Controls.Add(Me.Label16)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.btnadditem)
		Me.GroupBox1.Controls.Add(Me.txtAccessoies)
		Me.GroupBox1.Controls.Add(Me.txtcmpnynm)
		Me.GroupBox1.Controls.Add(Me.firm)
		Me.GroupBox1.Controls.Add(Me.crm)
		Me.GroupBox1.Controls.Add(Me.cmbservicetyp)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Controls.Add(Me.dpamc)
		Me.GroupBox1.Controls.Add(Me.txtrmrk)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.txtobserv)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.txtprodrep)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtmob)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtcustname)
		Me.GroupBox1.Controls.Add(Me.lable1)
		Me.GroupBox1.Controls.Add(Me.dpjobdate)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtjobid)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(90, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(950, 590)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Details"
		'
		'txtcust_id
		'
		Me.txtcust_id.Location = New System.Drawing.Point(408, 84)
		Me.txtcust_id.Name = "txtcust_id"
		Me.txtcust_id.ReadOnly = True
		Me.txtcust_id.Size = New System.Drawing.Size(43, 20)
		Me.txtcust_id.TabIndex = 5771
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.GroupBox3.Controls.Add(Me.txtprodid)
		Me.GroupBox3.Controls.Add(Me.Label17)
		Me.GroupBox3.Controls.Add(Me.txtserialno)
		Me.GroupBox3.Controls.Add(Me.Label18)
		Me.GroupBox3.Controls.Add(Me.Button2)
		Me.GroupBox3.Controls.Add(Me.btnAdd)
		Me.GroupBox3.Controls.Add(Me.txtprodnm)
		Me.GroupBox3.Controls.Add(Me.Label19)
		Me.GroupBox3.Location = New System.Drawing.Point(656, 322)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(277, 257)
		Me.GroupBox3.TabIndex = 25
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Product Name"
		'
		'txtprodid
		'
		Me.txtprodid.Enabled = False
		Me.txtprodid.Location = New System.Drawing.Point(47, 56)
		Me.txtprodid.Name = "txtprodid"
		Me.txtprodid.Size = New System.Drawing.Size(191, 20)
		Me.txtprodid.TabIndex = 506
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(44, 28)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(76, 15)
		Me.Label17.TabIndex = 505
		Me.Label17.Text = "Product Id:"
		'
		'txtserialno
		'
		Me.txtserialno.Location = New System.Drawing.Point(47, 169)
		Me.txtserialno.Name = "txtserialno"
		Me.txtserialno.Size = New System.Drawing.Size(191, 20)
		Me.txtserialno.TabIndex = 504
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(44, 141)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(75, 15)
		Me.Label18.TabIndex = 503
		Me.Label18.Text = "Serial No.:"
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
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(47, 209)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 2
		Me.btnAdd.Text = "Update"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'txtprodnm
		'
		Me.txtprodnm.Location = New System.Drawing.Point(47, 117)
		Me.txtprodnm.Name = "txtprodnm"
		Me.txtprodnm.Size = New System.Drawing.Size(191, 20)
		Me.txtprodnm.TabIndex = 1
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(44, 89)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(102, 15)
		Me.Label19.TabIndex = 0
		Me.Label19.Text = "Product Name:"
		'
		'deliveryLable
		'
		Me.deliveryLable.AutoSize = True
		Me.deliveryLable.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.deliveryLable.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.deliveryLable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.deliveryLable.Location = New System.Drawing.Point(520, 281)
		Me.deliveryLable.Name = "deliveryLable"
		Me.deliveryLable.Size = New System.Drawing.Size(106, 20)
		Me.deliveryLable.TabIndex = 5770
		Me.deliveryLable.Text = "deliveryLable"
		Me.deliveryLable.Visible = False
		'
		'DataGridView2
		'
		Me.DataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(661, 323)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(272, 256)
		Me.DataGridView2.TabIndex = 493
		'
		'txtdilverystatus
		'
		Me.txtdilverystatus.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtdilverystatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtdilverystatus.Location = New System.Drawing.Point(493, 337)
		Me.txtdilverystatus.Name = "txtdilverystatus"
		Me.txtdilverystatus.Size = New System.Drawing.Size(125, 21)
		Me.txtdilverystatus.TabIndex = 5769
		Me.txtdilverystatus.Visible = False
		'
		'txtcomp
		'
		Me.txtcomp.Location = New System.Drawing.Point(23, 359)
		Me.txtcomp.Multiline = True
		Me.txtcomp.Name = "txtcomp"
		Me.txtcomp.Size = New System.Drawing.Size(440, 64)
		Me.txtcomp.TabIndex = 13
		'
		'txtserialaccess
		'
		Me.txtserialaccess.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtserialaccess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtserialaccess.Location = New System.Drawing.Point(206, 249)
		Me.txtserialaccess.Name = "txtserialaccess"
		Me.txtserialaccess.Size = New System.Drawing.Size(164, 21)
		Me.txtserialaccess.TabIndex = 9
		'
		'jobidchk
		'
		Me.jobidchk.AutoSize = True
		Me.jobidchk.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.jobidchk.Location = New System.Drawing.Point(217, 36)
		Me.jobidchk.Name = "jobidchk"
		Me.jobidchk.Size = New System.Drawing.Size(113, 22)
		Me.jobidchk.TabIndex = 492
		Me.jobidchk.Text = "Manually JobID"
		Me.jobidchk.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(524, 45)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(409, 227)
		Me.DataGridView1.TabIndex = 491
		'
		'btnremove
		'
		Me.btnremove.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.btnremove.Location = New System.Drawing.Point(524, 278)
		Me.btnremove.Name = "btnremove"
		Me.btnremove.Size = New System.Drawing.Size(75, 23)
		Me.btnremove.TabIndex = 488
		Me.btnremove.TabStop = False
		Me.btnremove.Text = "&Remove Product"
		Me.btnremove.UseVisualStyleBackColor = True
		'
		'Label16
		'
		Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label16.Location = New System.Drawing.Point(521, 24)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(159, 18)
		Me.Label16.TabIndex = 487
		Me.Label16.Text = "List of Products Submitted"
		'
		'Label15
		'
		Me.Label15.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label15.Location = New System.Drawing.Point(203, 233)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(114, 18)
		Me.Label15.TabIndex = 485
		Me.Label15.Text = "Serial No./IMEI No."
		'
		'btnadditem
		'
		Me.btnadditem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.btnadditem.Location = New System.Drawing.Point(376, 247)
		Me.btnadditem.Name = "btnadditem"
		Me.btnadditem.Size = New System.Drawing.Size(75, 23)
		Me.btnadditem.TabIndex = 10
		Me.btnadditem.TabStop = False
		Me.btnadditem.Text = "&Add Product"
		Me.btnadditem.UseVisualStyleBackColor = True
		'
		'txtAccessoies
		'
		Me.txtAccessoies.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtAccessoies.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtAccessoies.Location = New System.Drawing.Point(23, 249)
		Me.txtAccessoies.Name = "txtAccessoies"
		Me.txtAccessoies.Size = New System.Drawing.Size(177, 21)
		Me.txtAccessoies.TabIndex = 8
		'
		'txtcmpnynm
		'
		Me.txtcmpnynm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtcmpnynm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtcmpnynm.Location = New System.Drawing.Point(23, 126)
		Me.txtcmpnynm.Name = "txtcmpnynm"
		Me.txtcmpnynm.Size = New System.Drawing.Size(428, 21)
		Me.txtcmpnynm.TabIndex = 6
		'
		'firm
		'
		Me.firm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.firm.AutoSize = True
		Me.firm.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.firm.Location = New System.Drawing.Point(24, 110)
		Me.firm.Name = "firm"
		Me.firm.Size = New System.Drawing.Size(94, 18)
		Me.firm.TabIndex = 479
		Me.firm.Text = "Company Name"
		'
		'crm
		'
		Me.crm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.crm.Location = New System.Drawing.Point(148, 82)
		Me.crm.Name = "crm"
		Me.crm.Size = New System.Drawing.Size(75, 23)
		Me.crm.TabIndex = 4
		Me.crm.TabStop = False
		Me.crm.Text = "&Check CRM"
		Me.crm.UseVisualStyleBackColor = True
		'
		'cmbservicetyp
		'
		Me.cmbservicetyp.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.cmbservicetyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbservicetyp.FormattingEnabled = True
		Me.cmbservicetyp.ItemHeight = 13
		Me.cmbservicetyp.Location = New System.Drawing.Point(23, 308)
		Me.cmbservicetyp.Name = "cmbservicetyp"
		Me.cmbservicetyp.Size = New System.Drawing.Size(115, 21)
		Me.cmbservicetyp.TabIndex = 11
		'
		'GroupBox2
		'
		Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.cmbjobstatus)
		Me.GroupBox2.Controls.Add(Me.Label13)
		Me.GroupBox2.Controls.Add(Me.txtprejobid)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.dpestdate)
		Me.GroupBox2.Controls.Add(Me.Label11)
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.txtestval)
		Me.GroupBox2.Location = New System.Drawing.Point(493, 364)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(157, 219)
		Me.GroupBox2.TabIndex = 31
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Other Details"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(82, 178)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(59, 23)
		Me.Button1.TabIndex = 5769
		Me.Button1.Text = "Fetch"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'cmbjobstatus
		'
		Me.cmbjobstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobstatus.FormattingEnabled = True
		Me.cmbjobstatus.Location = New System.Drawing.Point(15, 93)
		Me.cmbjobstatus.Name = "cmbjobstatus"
		Me.cmbjobstatus.Size = New System.Drawing.Size(126, 21)
		Me.cmbjobstatus.Sorted = True
		Me.cmbjobstatus.TabIndex = 17
		'
		'Label13
		'
		Me.Label13.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(13, 159)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(90, 18)
		Me.Label13.TabIndex = 5768
		Me.Label13.Text = "Previous JobId"
		'
		'txtprejobid
		'
		Me.txtprejobid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtprejobid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtprejobid.Location = New System.Drawing.Point(16, 180)
		Me.txtprejobid.Name = "txtprejobid"
		Me.txtprejobid.Size = New System.Drawing.Size(63, 21)
		Me.txtprejobid.TabIndex = 19
		'
		'Label14
		'
		Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(13, 72)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(66, 18)
		Me.Label14.TabIndex = 5766
		Me.Label14.Text = "Job Status"
		'
		'dpestdate
		'
		Me.dpestdate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.dpestdate.Location = New System.Drawing.Point(16, 41)
		Me.dpestdate.Name = "dpestdate"
		Me.dpestdate.Size = New System.Drawing.Size(125, 20)
		Me.dpestdate.TabIndex = 16
		'
		'Label11
		'
		Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(13, 20)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(94, 18)
		Me.Label11.TabIndex = 24
		Me.Label11.Text = "Estimated Date"
		'
		'Label12
		'
		Me.Label12.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label12.Location = New System.Drawing.Point(13, 125)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(124, 18)
		Me.Label12.TabIndex = 22
		Me.Label12.Text = "Estimated Job Value"
		'
		'txtestval
		'
		Me.txtestval.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtestval.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtestval.Location = New System.Drawing.Point(16, 138)
		Me.txtestval.Name = "txtestval"
		Me.txtestval.Size = New System.Drawing.Size(125, 21)
		Me.txtestval.TabIndex = 18
		'
		'dpamc
		'
		Me.dpamc.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.dpamc.Location = New System.Drawing.Point(334, 308)
		Me.dpamc.Name = "dpamc"
		Me.dpamc.Size = New System.Drawing.Size(117, 20)
		Me.dpamc.TabIndex = 12
		'
		'txtrmrk
		'
		Me.txtrmrk.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtrmrk.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtrmrk.Location = New System.Drawing.Point(27, 516)
		Me.txtrmrk.Name = "txtrmrk"
		Me.txtrmrk.Size = New System.Drawing.Size(440, 50)
		Me.txtrmrk.TabIndex = 15
		Me.txtrmrk.Text = ""
		'
		'Label10
		'
		Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.Location = New System.Drawing.Point(24, 499)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(55, 18)
		Me.Label10.TabIndex = 20
		Me.Label10.Text = "Remarks"
		'
		'txtobserv
		'
		Me.txtobserv.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtobserv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtobserv.Location = New System.Drawing.Point(27, 443)
		Me.txtobserv.Name = "txtobserv"
		Me.txtobserv.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.txtobserv.Size = New System.Drawing.Size(440, 46)
		Me.txtobserv.TabIndex = 14
		Me.txtobserv.Text = ""
		'
		'Label9
		'
		Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label9.Location = New System.Drawing.Point(24, 426)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(115, 18)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "Problem Observed "
		'
		'Label8
		'
		Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(20, 337)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(191, 18)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Problems Reported by Customer"
		'
		'Label7
		'
		Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(331, 292)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(146, 18)
		Me.Label7.TabIndex = 66
		Me.Label7.Text = "Warranty/AMC Valid Till"
		'
		'Label3
		'
		Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(24, 292)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 18)
		Me.Label3.TabIndex = 476
		Me.Label3.Text = "Service Type"
		'
		'Label6
		'
		Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(20, 233)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(114, 18)
		Me.Label6.TabIndex = 55
		Me.Label6.Text = "Product Submitted"
		'
		'txtprodrep
		'
		Me.txtprodrep.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtprodrep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtprodrep.Location = New System.Drawing.Point(23, 175)
		Me.txtprodrep.Multiline = True
		Me.txtprodrep.Name = "txtprodrep"
		Me.txtprodrep.Size = New System.Drawing.Size(428, 49)
		Me.txtprodrep.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(20, 159)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(121, 18)
		Me.Label5.TabIndex = 56
		Me.Label5.Text = "Product Description"
		'
		'txtmob
		'
		Me.txtmob.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtmob.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtmob.Location = New System.Drawing.Point(23, 84)
		Me.txtmob.Name = "txtmob"
		Me.txtmob.Size = New System.Drawing.Size(119, 21)
		Me.txtmob.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(20, 68)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 18)
		Me.Label4.TabIndex = 66
		Me.Label4.Text = "Mobile No."
		'
		'txtcustname
		'
		Me.txtcustname.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtcustname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtcustname.Location = New System.Drawing.Point(229, 84)
		Me.txtcustname.Name = "txtcustname"
		Me.txtcustname.Size = New System.Drawing.Size(172, 21)
		Me.txtcustname.TabIndex = 5
		'
		'lable1
		'
		Me.lable1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.lable1.AutoSize = True
		Me.lable1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.lable1.Location = New System.Drawing.Point(226, 68)
		Me.lable1.Name = "lable1"
		Me.lable1.Size = New System.Drawing.Size(96, 18)
		Me.lable1.TabIndex = 45
		Me.lable1.Text = "Customer Name"
		'
		'dpjobdate
		'
		Me.dpjobdate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.dpjobdate.Location = New System.Drawing.Point(332, 36)
		Me.dpjobdate.Name = "dpjobdate"
		Me.dpjobdate.Size = New System.Drawing.Size(119, 20)
		Me.dpjobdate.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(329, 20)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 18)
		Me.Label2.TabIndex = 435
		Me.Label2.Text = "Job Date In"
		'
		'txtjobid
		'
		Me.txtjobid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtjobid.AllowDrop = True
		Me.txtjobid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtjobid.Location = New System.Drawing.Point(23, 36)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(188, 21)
		Me.txtjobid.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(20, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(43, 18)
		Me.Label1.TabIndex = 100
		Me.Label1.Text = "Job ID"
		'
		'btnclear
		'
		Me.btnclear.Location = New System.Drawing.Point(492, 608)
		Me.btnclear.Name = "btnclear"
		Me.btnclear.Size = New System.Drawing.Size(75, 23)
		Me.btnclear.TabIndex = 23
		Me.btnclear.Text = "Clear"
		Me.btnclear.UseVisualStyleBackColor = True
		'
		'btnshow
		'
		Me.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.btnshow.Location = New System.Drawing.Point(389, 608)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(85, 23)
		Me.btnshow.TabIndex = 22
		Me.btnshow.Text = "Show Data"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'btnsaveupdate
		'
		Me.btnsaveupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.btnsaveupdate.Location = New System.Drawing.Point(252, 608)
		Me.btnsaveupdate.Name = "btnsaveupdate"
		Me.btnsaveupdate.Size = New System.Drawing.Size(107, 23)
		Me.btnsaveupdate.TabIndex = 21
		Me.btnsaveupdate.Text = "Update"
		Me.btnsaveupdate.UseVisualStyleBackColor = True
		Me.btnsaveupdate.Visible = False
		'
		'btnsave
		'
		Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.btnsave.Location = New System.Drawing.Point(113, 608)
		Me.btnsave.Name = "btnsave"
		Me.btnsave.Size = New System.Drawing.Size(103, 23)
		Me.btnsave.TabIndex = 20
		Me.btnsave.Text = "&Save (Alt + S)"
		Me.btnsave.UseVisualStyleBackColor = True
		'
		'btnclose
		'
		Me.btnclose.Location = New System.Drawing.Point(598, 608)
		Me.btnclose.Name = "btnclose"
		Me.btnclose.Size = New System.Drawing.Size(75, 23)
		Me.btnclose.TabIndex = 24
		Me.btnclose.Text = "Close"
		Me.btnclose.UseVisualStyleBackColor = True
		'
		'AddJobDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1052, 655)
		Me.Controls.Add(Me.btnclose)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnsaveupdate)
		Me.Controls.Add(Me.btnsave)
		Me.Controls.Add(Me.btnshow)
		Me.Controls.Add(Me.btnclear)
		Me.Name = "AddJobDetails"
		Me.Text = "Add Job Details"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtmob As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtcustname As TextBox
	Friend WithEvents lable1 As Label
	Friend WithEvents dpjobdate As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtrmrk As RichTextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtobserv As RichTextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents txtestval As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents dpamc As DateTimePicker
	Friend WithEvents dpestdate As DateTimePicker
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnshow As Button
	Friend WithEvents btnsaveupdate As Button
	Friend WithEvents btnsave As Button
	Friend WithEvents Label14 As Label
	Friend WithEvents cmbservicetyp As ComboBox
	Friend WithEvents crm As Button
	Friend WithEvents txtcmpnynm As TextBox
	Friend WithEvents firm As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents btnadditem As Button
	Friend WithEvents txtserialaccess As TextBox
	Friend WithEvents txtAccessoies As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents btnremove As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents jobidchk As CheckBox
	Friend WithEvents btnclear As Button
	Friend WithEvents txtprodrep As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtcomp As TextBox
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents Label13 As Label
	Friend WithEvents txtprejobid As TextBox
	Friend WithEvents cmbjobstatus As ComboBox
	Friend WithEvents txtdilverystatus As TextBox
	Friend WithEvents deliveryLable As Label
	Friend WithEvents btnclose As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents txtprodid As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents txtserialno As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents txtprodnm As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents txtcust_id As TextBox
End Class
