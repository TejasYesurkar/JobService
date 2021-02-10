<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class display_JOBDetails
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(display_JOBDetails))
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobReapairedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobDeliveredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.JobDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.btnshow = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Datefilter = New System.Windows.Forms.CheckBox()
		Me.cmbdilvery = New System.Windows.Forms.ComboBox()
		Me.dptodate = New System.Windows.Forms.DateTimePicker()
		Me.dpfromdate = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbfilter = New System.Windows.Forms.ComboBox()
		Me.txtsearch = New System.Windows.Forms.TextBox()
		Me.jobdone = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnbarcode = New System.Windows.Forms.Button()
		Me.btnimportToExcel = New System.Windows.Forms.Button()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.btnjobRepaire = New System.Windows.Forms.Button()
		Me.btnprint = New System.Windows.Forms.Button()
		Me.btnprintjob = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.cmbThermal = New System.Windows.Forms.ComboBox()
		Me.Tprint = New System.Windows.Forms.RadioButton()
		Me.Lprint = New System.Windows.Forms.RadioButton()
		Me.cmbLaser = New System.Windows.Forms.ComboBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
		Me.Button4 = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(1145, 429)
		Me.DataGridView1.TabIndex = 0
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.JobReapairedToolStripMenuItem, Me.JobDeliveredToolStripMenuItem, Me.JobDeleteToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 92)
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
		Me.EditToolStripMenuItem.Text = "Edit / Modify Job Entry"
		'
		'JobReapairedToolStripMenuItem
		'
		Me.JobReapairedToolStripMenuItem.Name = "JobReapairedToolStripMenuItem"
		Me.JobReapairedToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
		Me.JobReapairedToolStripMenuItem.Text = "Job Repaired"
		'
		'JobDeliveredToolStripMenuItem
		'
		Me.JobDeliveredToolStripMenuItem.Name = "JobDeliveredToolStripMenuItem"
		Me.JobDeliveredToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
		Me.JobDeliveredToolStripMenuItem.Text = "Job Delivered"
		'
		'JobDeleteToolStripMenuItem
		'
		Me.JobDeleteToolStripMenuItem.Name = "JobDeleteToolStripMenuItem"
		Me.JobDeleteToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
		Me.JobDeleteToolStripMenuItem.Text = "Job Delete"
		'
		'btnupdate
		'
		Me.btnupdate.Location = New System.Drawing.Point(12, 604)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(149, 23)
		Me.btnupdate.TabIndex = 1
		Me.btnupdate.Text = "Edit / Modify Job Entry"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'btnshow
		'
		Me.btnshow.Location = New System.Drawing.Point(874, 49)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(137, 23)
		Me.btnshow.TabIndex = 6
		Me.btnshow.Text = "RefreshData"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(408, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(126, 26)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Job Details"
		'
		'cmbjobst
		'
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(699, 49)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(154, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(699, 27)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 18)
		Me.Label2.TabIndex = 101
		Me.Label2.Text = "Job Status"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Datefilter)
		Me.GroupBox2.Controls.Add(Me.cmbdilvery)
		Me.GroupBox2.Controls.Add(Me.dptodate)
		Me.GroupBox2.Controls.Add(Me.dpfromdate)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.cmbfilter)
		Me.GroupBox2.Controls.Add(Me.txtsearch)
		Me.GroupBox2.Controls.Add(Me.cmbjobst)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.btnshow)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 75)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(1011, 77)
		Me.GroupBox2.TabIndex = 104
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Filters Options"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(6, 28)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(94, 18)
		Me.Label7.TabIndex = 119
		Me.Label7.Text = "Delivery Status"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(276, 32)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 18)
		Me.Label6.TabIndex = 113
		Me.Label6.Text = "ToDate"
		'
		'Datefilter
		'
		Me.Datefilter.AutoSize = True
		Me.Datefilter.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Datefilter.Location = New System.Drawing.Point(158, 12)
		Me.Datefilter.Name = "Datefilter"
		Me.Datefilter.Size = New System.Drawing.Size(84, 22)
		Me.Datefilter.TabIndex = 114
		Me.Datefilter.Text = "DataFilter"
		Me.Datefilter.UseVisualStyleBackColor = True
		'
		'cmbdilvery
		'
		Me.cmbdilvery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbdilvery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbdilvery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbdilvery.Location = New System.Drawing.Point(6, 50)
		Me.cmbdilvery.Name = "cmbdilvery"
		Me.cmbdilvery.Size = New System.Drawing.Size(143, 21)
		Me.cmbdilvery.TabIndex = 118
		'
		'dptodate
		'
		Me.dptodate.Location = New System.Drawing.Point(279, 51)
		Me.dptodate.Name = "dptodate"
		Me.dptodate.Size = New System.Drawing.Size(116, 20)
		Me.dptodate.TabIndex = 3
		'
		'dpfromdate
		'
		Me.dpfromdate.Location = New System.Drawing.Point(154, 51)
		Me.dpfromdate.Name = "dpfromdate"
		Me.dpfromdate.Size = New System.Drawing.Size(119, 20)
		Me.dpfromdate.TabIndex = 2
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(154, 32)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 18)
		Me.Label5.TabIndex = 112
		Me.Label5.Text = "FromDate"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(398, 32)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 18)
		Me.Label4.TabIndex = 105
		Me.Label4.Text = "Search By."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(547, 28)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 18)
		Me.Label3.TabIndex = 104
		Me.Label3.Text = "Search String"
		'
		'cmbfilter
		'
		Me.cmbfilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbfilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbfilter.Location = New System.Drawing.Point(401, 50)
		Me.cmbfilter.Name = "cmbfilter"
		Me.cmbfilter.Size = New System.Drawing.Size(143, 21)
		Me.cmbfilter.TabIndex = 4
		'
		'txtsearch
		'
		Me.txtsearch.Location = New System.Drawing.Point(550, 50)
		Me.txtsearch.Name = "txtsearch"
		Me.txtsearch.Size = New System.Drawing.Size(143, 20)
		Me.txtsearch.TabIndex = 5
		'
		'jobdone
		'
		Me.jobdone.Location = New System.Drawing.Point(169, 604)
		Me.jobdone.Name = "jobdone"
		Me.jobdone.Size = New System.Drawing.Size(167, 23)
		Me.jobdone.TabIndex = 105
		Me.jobdone.Text = "Job Delivered"
		Me.jobdone.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(327, 11)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(137, 23)
		Me.Button1.TabIndex = 120
		Me.Button1.Text = "Set Columns"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnbarcode
		'
		Me.btnbarcode.Location = New System.Drawing.Point(534, 604)
		Me.btnbarcode.Name = "btnbarcode"
		Me.btnbarcode.Size = New System.Drawing.Size(171, 23)
		Me.btnbarcode.TabIndex = 121
		Me.btnbarcode.Text = "Barcode Print"
		Me.btnbarcode.UseVisualStyleBackColor = True
		'
		'btnimportToExcel
		'
		Me.btnimportToExcel.Location = New System.Drawing.Point(327, 44)
		Me.btnimportToExcel.Name = "btnimportToExcel"
		Me.btnimportToExcel.Size = New System.Drawing.Size(137, 23)
		Me.btnimportToExcel.TabIndex = 122
		Me.btnimportToExcel.Text = "Export To Excel"
		Me.btnimportToExcel.UseVisualStyleBackColor = True
		'
		'btnjobRepaire
		'
		Me.btnjobRepaire.Location = New System.Drawing.Point(354, 604)
		Me.btnjobRepaire.Name = "btnjobRepaire"
		Me.btnjobRepaire.Size = New System.Drawing.Size(161, 23)
		Me.btnjobRepaire.TabIndex = 123
		Me.btnjobRepaire.Text = "Job Repaired "
		Me.btnjobRepaire.UseVisualStyleBackColor = True
		'
		'btnprint
		'
		Me.btnprint.Location = New System.Drawing.Point(714, 604)
		Me.btnprint.Name = "btnprint"
		Me.btnprint.Size = New System.Drawing.Size(166, 23)
		Me.btnprint.TabIndex = 124
		Me.btnprint.Text = "Print"
		Me.btnprint.UseVisualStyleBackColor = True
		'
		'btnprintjob
		'
		Me.btnprintjob.Location = New System.Drawing.Point(176, 18)
		Me.btnprintjob.Name = "btnprintjob"
		Me.btnprintjob.Size = New System.Drawing.Size(122, 23)
		Me.btnprintjob.TabIndex = 125
		Me.btnprintjob.Text = "Print Data"
		Me.btnprintjob.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button3)
		Me.GroupBox1.Controls.Add(Me.cmbThermal)
		Me.GroupBox1.Controls.Add(Me.Tprint)
		Me.GroupBox1.Controls.Add(Me.Lprint)
		Me.GroupBox1.Controls.Add(Me.cmbLaser)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(395, 66)
		Me.GroupBox1.TabIndex = 126
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Print"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(306, 37)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(84, 23)
		Me.Button3.TabIndex = 131
		Me.Button3.Text = "Print/Preview"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'cmbThermal
		'
		Me.cmbThermal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbThermal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbThermal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbThermal.Location = New System.Drawing.Point(103, 33)
		Me.cmbThermal.Name = "cmbThermal"
		Me.cmbThermal.Size = New System.Drawing.Size(195, 21)
		Me.cmbThermal.TabIndex = 130
		'
		'Tprint
		'
		Me.Tprint.AutoSize = True
		Me.Tprint.Location = New System.Drawing.Point(10, 37)
		Me.Tprint.Name = "Tprint"
		Me.Tprint.Size = New System.Drawing.Size(87, 17)
		Me.Tprint.TabIndex = 129
		Me.Tprint.TabStop = True
		Me.Tprint.Text = "Thermal Print"
		Me.Tprint.UseVisualStyleBackColor = True
		'
		'Lprint
		'
		Me.Lprint.AutoSize = True
		Me.Lprint.Location = New System.Drawing.Point(9, 14)
		Me.Lprint.Name = "Lprint"
		Me.Lprint.Size = New System.Drawing.Size(75, 17)
		Me.Lprint.TabIndex = 128
		Me.Lprint.TabStop = True
		Me.Lprint.Text = "Laser Print"
		Me.Lprint.UseVisualStyleBackColor = True
		'
		'cmbLaser
		'
		Me.cmbLaser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbLaser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbLaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbLaser.Location = New System.Drawing.Point(103, 25)
		Me.cmbLaser.Name = "cmbLaser"
		Me.cmbLaser.Size = New System.Drawing.Size(195, 21)
		Me.cmbLaser.TabIndex = 120
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(306, 8)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(84, 23)
		Me.Button2.TabIndex = 127
		Me.Button2.Text = "Print"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.ComboBox1)
		Me.GroupBox3.Controls.Add(Me.btnimportToExcel)
		Me.GroupBox3.Controls.Add(Me.Button1)
		Me.GroupBox3.Controls.Add(Me.btnprintjob)
		Me.GroupBox3.Location = New System.Drawing.Point(553, 2)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(470, 78)
		Me.GroupBox3.TabIndex = 127
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = " "
		'
		'ComboBox1
		'
		Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Location = New System.Drawing.Point(20, 18)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
		Me.ComboBox1.TabIndex = 131
		'
		'PrintPreviewDialog1
		'
		Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.PrintPreviewDialog1.Enabled = True
		Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
		Me.PrintPreviewDialog1.Visible = False
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(886, 604)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(157, 23)
		Me.Button4.TabIndex = 128
		Me.Button4.Text = "Customer Report"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'display_JOBDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1186, 750)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnprint)
		Me.Controls.Add(Me.btnjobRepaire)
		Me.Controls.Add(Me.btnbarcode)
		Me.Controls.Add(Me.jobdone)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnupdate)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "display_JOBDetails"
		Me.Text = "display_data"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbjobst As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents jobdone As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbfilter As ComboBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Datefilter As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dpfromdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dptodate As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents cmbdilvery As ComboBox
	Friend WithEvents Button1 As Button
	Friend WithEvents btnbarcode As Button
	Friend WithEvents btnimportToExcel As Button
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents btnjobRepaire As Button
	Friend WithEvents btnprint As Button
	Friend WithEvents btnprintjob As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Lprint As RadioButton
	Friend WithEvents cmbLaser As ComboBox
	Friend WithEvents Button2 As Button
    Friend WithEvents Tprint As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbThermal As ComboBox
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Drawing.Printing.PrintDocument
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobReapairedToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobDeliveredToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents JobDeleteToolStripMenuItem As ToolStripMenuItem
End Class
