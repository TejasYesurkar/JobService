<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class job_delivery
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
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtreciver = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.chkpaid = New System.Windows.Forms.CheckBox()
		Me.txtxchargable = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.txtrepairdone = New System.Windows.Forms.RichTextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtcomp = New System.Windows.Forms.RichTextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtremark = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.txtCustnm = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.btnfetch = New System.Windows.Forms.Button()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnsubmit = New System.Windows.Forms.Button()
		Me.Dp_Deli_Date = New System.Windows.Forms.DateTimePicker()
		Me.txtrecver_mob = New System.Windows.Forms.TextBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.GroupBox4.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label11.Location = New System.Drawing.Point(653, 124)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(70, 18)
		Me.Label11.TabIndex = 153
		Me.Label11.Text = "Mobile No:"
		'
		'txtreciver
		'
		Me.txtreciver.Location = New System.Drawing.Point(656, 94)
		Me.txtreciver.Name = "txtreciver"
		Me.txtreciver.Size = New System.Drawing.Size(257, 20)
		Me.txtreciver.TabIndex = 11
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(653, 172)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(114, 18)
		Me.Label7.TabIndex = 148
		Me.Label7.Text = "Job Delivery Date:"
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label19.Location = New System.Drawing.Point(325, 16)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(222, 35)
		Me.Label19.TabIndex = 135
		Me.Label19.Text = " Delivery Details"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label9.Location = New System.Drawing.Point(658, 69)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(255, 18)
		Me.Label9.TabIndex = 150
		Me.Label9.Text = "Name of person who received the material:"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.CheckBox1)
		Me.GroupBox4.Controls.Add(Me.chkpaid)
		Me.GroupBox4.Controls.Add(Me.txtxchargable)
		Me.GroupBox4.Controls.Add(Me.cmbjobst)
		Me.GroupBox4.Controls.Add(Me.Label8)
		Me.GroupBox4.Controls.Add(Me.DataGridView1)
		Me.GroupBox4.Controls.Add(Me.txtrepairdone)
		Me.GroupBox4.Controls.Add(Me.Label13)
		Me.GroupBox4.Controls.Add(Me.txtcomp)
		Me.GroupBox4.Controls.Add(Me.Label14)
		Me.GroupBox4.Controls.Add(Me.txtremark)
		Me.GroupBox4.Controls.Add(Me.Label16)
		Me.GroupBox4.Controls.Add(Me.txtCustnm)
		Me.GroupBox4.Controls.Add(Me.Label10)
		Me.GroupBox4.Controls.Add(Me.Label12)
		Me.GroupBox4.Controls.Add(Me.btnfetch)
		Me.GroupBox4.Controls.Add(Me.txtjobid)
		Me.GroupBox4.Controls.Add(Me.Button1)
		Me.GroupBox4.Controls.Add(Me.btnsubmit)
		Me.GroupBox4.Controls.Add(Me.txtreciver)
		Me.GroupBox4.Controls.Add(Me.Dp_Deli_Date)
		Me.GroupBox4.Controls.Add(Me.Label7)
		Me.GroupBox4.Controls.Add(Me.txtrecver_mob)
		Me.GroupBox4.Controls.Add(Me.Label11)
		Me.GroupBox4.Controls.Add(Me.Label19)
		Me.GroupBox4.Controls.Add(Me.Label9)
		Me.GroupBox4.Location = New System.Drawing.Point(62, 35)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(1064, 638)
		Me.GroupBox4.TabIndex = 156
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Details of Product and Serial No"
		'
		'chkpaid
		'
		Me.chkpaid.AutoSize = True
		Me.chkpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
		Me.chkpaid.Location = New System.Drawing.Point(31, 520)
		Me.chkpaid.Name = "chkpaid"
		Me.chkpaid.Size = New System.Drawing.Size(59, 20)
		Me.chkpaid.TabIndex = 200
		Me.chkpaid.Text = "Paid"
		Me.chkpaid.UseVisualStyleBackColor = True
		'
		'txtxchargable
		'
		Me.txtxchargable.AutoSize = True
		Me.txtxchargable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtxchargable.Location = New System.Drawing.Point(736, 517)
		Me.txtxchargable.Name = "txtxchargable"
		Me.txtxchargable.Size = New System.Drawing.Size(58, 16)
		Me.txtxchargable.TabIndex = 199
		Me.txtxchargable.Text = "Charge"
		'
		'cmbjobst
		'
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(656, 45)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(257, 21)
		Me.cmbjobst.TabIndex = 197
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label8.Location = New System.Drawing.Point(653, 17)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(70, 18)
		Me.Label8.TabIndex = 198
		Me.Label8.Text = "Job Status:"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(6, 260)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(895, 254)
		Me.DataGridView1.TabIndex = 196
		'
		'txtrepairdone
		'
		Me.txtrepairdone.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtrepairdone.Location = New System.Drawing.Point(31, 144)
		Me.txtrepairdone.Name = "txtrepairdone"
		Me.txtrepairdone.Size = New System.Drawing.Size(284, 75)
		Me.txtrepairdone.TabIndex = 195
		Me.txtrepairdone.Text = ""
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(28, 123)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(158, 18)
		Me.Label13.TabIndex = 194
		Me.Label13.Text = "Repairs Done / Parts Used:"
		'
		'txtcomp
		'
		Me.txtcomp.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtcomp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtcomp.Location = New System.Drawing.Point(331, 165)
		Me.txtcomp.Name = "txtcomp"
		Me.txtcomp.Size = New System.Drawing.Size(281, 54)
		Me.txtcomp.TabIndex = 185
		Me.txtcomp.Text = ""
		'
		'Label14
		'
		Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(328, 144)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(195, 18)
		Me.Label14.TabIndex = 187
		Me.Label14.Text = "Problems Reported by Customer:"
		'
		'txtremark
		'
		Me.txtremark.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.txtremark.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtremark.Location = New System.Drawing.Point(331, 90)
		Me.txtremark.Multiline = True
		Me.txtremark.Name = "txtremark"
		Me.txtremark.Size = New System.Drawing.Size(284, 51)
		Me.txtremark.TabIndex = 184
		'
		'Label16
		'
		Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label16.Location = New System.Drawing.Point(330, 69)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(54, 18)
		Me.Label16.TabIndex = 188
		Me.Label16.Text = "Remark:"
		'
		'txtCustnm
		'
		Me.txtCustnm.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtCustnm.Location = New System.Drawing.Point(31, 90)
		Me.txtCustnm.Name = "txtCustnm"
		Me.txtCustnm.Size = New System.Drawing.Size(248, 20)
		Me.txtCustnm.TabIndex = 183
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label10.Location = New System.Drawing.Point(28, 69)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(116, 18)
		Me.Label10.TabIndex = 186
		Me.Label10.Text = "Name Of Customer:"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label12.Location = New System.Drawing.Point(23, 32)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(47, 18)
		Me.Label12.TabIndex = 180
		Me.Label12.Text = "Job ID:"
		'
		'btnfetch
		'
		Me.btnfetch.Location = New System.Drawing.Point(200, 27)
		Me.btnfetch.Name = "btnfetch"
		Me.btnfetch.Size = New System.Drawing.Size(75, 23)
		Me.btnfetch.TabIndex = 179
		Me.btnfetch.TabStop = False
		Me.btnfetch.Text = "&Fetch"
		Me.btnfetch.UseVisualStyleBackColor = True
		'
		'txtjobid
		'
		Me.txtjobid.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
		Me.txtjobid.Location = New System.Drawing.Point(71, 29)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(123, 20)
		Me.txtjobid.TabIndex = 178
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(521, 544)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(120, 23)
		Me.Button1.TabIndex = 160
		Me.Button1.Text = "Close"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnsubmit
		'
		Me.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.btnsubmit.Location = New System.Drawing.Point(254, 544)
		Me.btnsubmit.Name = "btnsubmit"
		Me.btnsubmit.Size = New System.Drawing.Size(130, 23)
		Me.btnsubmit.TabIndex = 14
		Me.btnsubmit.Text = "Save"
		Me.btnsubmit.UseVisualStyleBackColor = True
		'
		'Dp_Deli_Date
		'
		Me.Dp_Deli_Date.Location = New System.Drawing.Point(656, 193)
		Me.Dp_Deli_Date.Name = "Dp_Deli_Date"
		Me.Dp_Deli_Date.Size = New System.Drawing.Size(121, 20)
		Me.Dp_Deli_Date.TabIndex = 10
		'
		'txtrecver_mob
		'
		Me.txtrecver_mob.Location = New System.Drawing.Point(656, 145)
		Me.txtrecver_mob.Name = "txtrecver_mob"
		Me.txtrecver_mob.Size = New System.Drawing.Size(248, 20)
		Me.txtrecver_mob.TabIndex = 12
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(74, 237)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
		Me.CheckBox1.TabIndex = 201
		Me.CheckBox1.Text = "Select All"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'job_delivery
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1201, 698)
		Me.Controls.Add(Me.GroupBox4)
		Me.Name = "job_delivery"
		Me.Text = "job_done"
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents txtreciver As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents Button1 As Button
	Friend WithEvents btnsubmit As Button
	Friend WithEvents Dp_Deli_Date As DateTimePicker
	Friend WithEvents txtrecver_mob As TextBox

	Private Sub job_done_Load(sender As Object, e As EventArgs) Handles MyBase.Load



		txtreciver.AutoCompleteMode = AutoCompleteMode.Suggest
		txtreciver.AutoCompleteSource = AutoCompleteSource.CustomSource

		txtreciver.AutoCompleteCustomSource = DataCollection

		LoadCmbStatus()
		clearAllTextBox()

		txtCustnm.Enabled = False
		txtremark.Enabled = False
		txtrepairdone.Enabled = False
		txtcomp.Enabled = False


		Dp_Deli_Date.Value = Format(Now(), "dd-MMM-yyyy")


		Dim dgvProdnid As New DataGridViewTextBoxColumn()
		dgvProdnid.HeaderText = "PId"
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ProductName"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "SerialNo."
		Dim dgvcIndt As New DataGridViewTextBoxColumn()
		dgvcIndt.HeaderText = "InDate"
		Dim dgvoutDt As New DataGridViewTextBoxColumn()
		dgvoutDt.HeaderText = "OutDate"
		Dim dgvCheck As New DataGridViewCheckBoxColumn()
		dgvCheck.HeaderText = ""
		Dim dgvRecivername As New DataGridViewTextBoxColumn()
		dgvRecivername.HeaderText = "ReceiverName"
		Dim dgvReciverMob As New DataGridViewTextBoxColumn()
		dgvReciverMob.HeaderText = "ReceiverMobile"
		Dim dgvRepairedStatus As New DataGridViewTextBoxColumn()
		dgvRepairedStatus.HeaderText = "Repaired Status"

		DataGridView1.Columns.Add(dgvCheck)
		DataGridView1.Columns.Add(dgvProdnid)
		DataGridView1.Columns.Add(dgvProdnm)
		DataGridView1.Columns.Add(dgvSerila)
		DataGridView1.Columns.Add(dgvcIndt)
		DataGridView1.Columns.Add(dgvoutDt)
		DataGridView1.Columns.Add(dgvRecivername)
		DataGridView1.Columns.Add(dgvReciverMob)
		DataGridView1.Columns.Add(dgvRepairedStatus)

		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView1.AllowUserToAddRows = False

		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)

		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		'  Dim i As Integer
		OpenDatabaseObject()

		sql = "Select * from customer_reg "

		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex).ToString()


		End Try
	End Sub

	Friend WithEvents Label12 As Label
	Friend WithEvents btnfetch As Button
	Friend WithEvents txtjobid As TextBox
	Friend WithEvents txtcomp As RichTextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents txtremark As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents txtCustnm As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtrepairdone As RichTextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtxchargable As Label
	Friend WithEvents chkpaid As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
End Class
