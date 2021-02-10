<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JobResponsive
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobResponsive))
		Me.btnprint = New System.Windows.Forms.Button()
		Me.cmbdilvery = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cmbfilter = New System.Windows.Forms.ComboBox()
		Me.btnshow = New System.Windows.Forms.Button()
		Me.cmbjobst = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtsearch = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnjobRepaire = New System.Windows.Forms.Button()
		Me.jobdone = New System.Windows.Forms.Button()
		Me.btnupdate = New System.Windows.Forms.Button()
		Me.btnbarcode = New System.Windows.Forms.Button()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Datefilter = New System.Windows.Forms.CheckBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EditModifyJobEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.dpfromdate = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.dptodate = New System.Windows.Forms.DateTimePicker()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.cmbThermal = New System.Windows.Forms.ComboBox()
		Me.cmbLaser = New System.Windows.Forms.ComboBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Tprint = New System.Windows.Forms.RadioButton()
		Me.Lprint = New System.Windows.Forms.RadioButton()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.btnprintjob = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.btnimportToExcel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
		Me.Panel7.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnprint
		'
		Me.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnprint.Location = New System.Drawing.Point(671, 3)
		Me.btnprint.Name = "btnprint"
		Me.btnprint.Size = New System.Drawing.Size(161, 23)
		Me.btnprint.TabIndex = 126
		Me.btnprint.Text = "Print"
		Me.btnprint.UseVisualStyleBackColor = True
		'
		'cmbdilvery
		'
		Me.cmbdilvery.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.cmbdilvery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbdilvery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbdilvery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbdilvery.Location = New System.Drawing.Point(5, 47)
		Me.cmbdilvery.Name = "cmbdilvery"
		Me.cmbdilvery.Size = New System.Drawing.Size(129, 21)
		Me.cmbdilvery.TabIndex = 120
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(2, 28)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 18)
		Me.Label4.TabIndex = 107
		Me.Label4.Text = "Search By."
		'
		'cmbfilter
		'
		Me.cmbfilter.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.cmbfilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbfilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbfilter.Location = New System.Drawing.Point(5, 46)
		Me.cmbfilter.Name = "cmbfilter"
		Me.cmbfilter.Size = New System.Drawing.Size(129, 21)
		Me.cmbfilter.TabIndex = 106
		'
		'btnshow
		'
		Me.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnshow.Location = New System.Drawing.Point(3, 46)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(137, 23)
		Me.btnshow.TabIndex = 7
		Me.btnshow.Text = "RefreshData"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'cmbjobst
		'
		Me.cmbjobst.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.cmbjobst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbjobst.FormattingEnabled = True
		Me.cmbjobst.Location = New System.Drawing.Point(5, 45)
		Me.cmbjobst.Name = "cmbjobst"
		Me.cmbjobst.Size = New System.Drawing.Size(129, 21)
		Me.cmbjobst.Sorted = True
		Me.cmbjobst.TabIndex = 102
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(5, 23)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(66, 18)
		Me.Label6.TabIndex = 103
		Me.Label6.Text = "Job Status"
		'
		'Panel7
		'
		Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel7.Controls.Add(Me.txtsearch)
		Me.Panel7.Controls.Add(Me.Label8)
		Me.Panel7.Location = New System.Drawing.Point(579, 3)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(138, 71)
		Me.Panel7.TabIndex = 9
		'
		'txtsearch
		'
		Me.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txtsearch.Location = New System.Drawing.Point(5, 46)
		Me.txtsearch.Name = "txtsearch"
		Me.txtsearch.Size = New System.Drawing.Size(129, 20)
		Me.txtsearch.TabIndex = 108
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(7, 28)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(86, 18)
		Me.Label8.TabIndex = 107
		Me.Label8.Text = "Search String."
		'
		'Label7
		'
		Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(2, 28)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(48, 18)
		Me.Label7.TabIndex = 115
		Me.Label7.Text = "ToDate"
		'
		'Panel6
		'
		Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel6.Controls.Add(Me.cmbjobst)
		Me.Panel6.Controls.Add(Me.Label6)
		Me.Panel6.Location = New System.Drawing.Point(723, 3)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(138, 71)
		Me.Panel6.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(8, 26)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(94, 18)
		Me.Label3.TabIndex = 121
		Me.Label3.Text = "Delivery Status"
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.ColumnCount = 6
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel3.Controls.Add(Me.Button1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.btnprint, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.btnjobRepaire, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.jobdone, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.btnupdate, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.btnbarcode, 3, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(11, 206)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(1007, 34)
		Me.TableLayoutPanel3.TabIndex = 7
		'
		'Button1
		'
		Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button1.Location = New System.Drawing.Point(506, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(157, 23)
		Me.Button1.TabIndex = 129
		Me.Button1.Text = "Customer Report"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnjobRepaire
		'
		Me.btnjobRepaire.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnjobRepaire.Location = New System.Drawing.Point(337, 3)
		Me.btnjobRepaire.Name = "btnjobRepaire"
		Me.btnjobRepaire.Size = New System.Drawing.Size(161, 23)
		Me.btnjobRepaire.TabIndex = 124
		Me.btnjobRepaire.Text = "Job Repaired "
		Me.btnjobRepaire.UseVisualStyleBackColor = True
		'
		'jobdone
		'
		Me.jobdone.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.jobdone.Location = New System.Drawing.Point(3, 3)
		Me.jobdone.Name = "jobdone"
		Me.jobdone.Size = New System.Drawing.Size(161, 23)
		Me.jobdone.TabIndex = 106
		Me.jobdone.Text = "Job Delivered"
		Me.jobdone.UseVisualStyleBackColor = True
		'
		'btnupdate
		'
		Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnupdate.Location = New System.Drawing.Point(176, 3)
		Me.btnupdate.Name = "btnupdate"
		Me.btnupdate.Size = New System.Drawing.Size(149, 23)
		Me.btnupdate.TabIndex = 2
		Me.btnupdate.Text = "Edit / Modify Job Entry"
		Me.btnupdate.UseVisualStyleBackColor = True
		'
		'btnbarcode
		'
		Me.btnbarcode.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnbarcode.Location = New System.Drawing.Point(838, 3)
		Me.btnbarcode.Name = "btnbarcode"
		Me.btnbarcode.Size = New System.Drawing.Size(166, 23)
		Me.btnbarcode.TabIndex = 125
		Me.btnbarcode.Text = "Barcode Print"
		Me.btnbarcode.UseVisualStyleBackColor = True
		'
		'Panel5
		'
		Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel5.Controls.Add(Me.btnshow)
		Me.Panel5.Location = New System.Drawing.Point(867, 3)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(140, 71)
		Me.Panel5.TabIndex = 7
		'
		'Panel4
		'
		Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.cmbfilter)
		Me.Panel4.Location = New System.Drawing.Point(435, 3)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(138, 71)
		Me.Panel4.TabIndex = 6
		'
		'Datefilter
		'
		Me.Datefilter.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Datefilter.AutoSize = True
		Me.Datefilter.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Datefilter.Location = New System.Drawing.Point(8, 4)
		Me.Datefilter.Name = "Datefilter"
		Me.Datefilter.Size = New System.Drawing.Size(84, 22)
		Me.Datefilter.TabIndex = 115
		Me.Datefilter.Text = "DataFilter"
		Me.Datefilter.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.DataGridView1.Location = New System.Drawing.Point(11, 246)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1010, 177)
		Me.DataGridView1.TabIndex = 6
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditModifyJobEntryToolStripMenuItem, Me.ToolStripMenuItem1})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 48)
		'
		'EditModifyJobEntryToolStripMenuItem
		'
		Me.EditModifyJobEntryToolStripMenuItem.Name = "EditModifyJobEntryToolStripMenuItem"
		Me.EditModifyJobEntryToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
		Me.EditModifyJobEntryToolStripMenuItem.Text = "Edit / Modify Job Entry"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
		Me.ToolStripMenuItem1.Text = "Job Repaired"
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel2.Controls.Add(Me.Datefilter)
		Me.Panel2.Controls.Add(Me.dpfromdate)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(147, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(138, 71)
		Me.Panel2.TabIndex = 4
		'
		'dpfromdate
		'
		Me.dpfromdate.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.dpfromdate.Location = New System.Drawing.Point(5, 48)
		Me.dpfromdate.Name = "dpfromdate"
		Me.dpfromdate.Size = New System.Drawing.Size(119, 20)
		Me.dpfromdate.TabIndex = 113
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(5, 29)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 18)
		Me.Label2.TabIndex = 114
		Me.Label2.Text = "FromDate"
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.dptodate)
		Me.Panel1.Location = New System.Drawing.Point(291, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(138, 71)
		Me.Panel1.TabIndex = 3
		'
		'dptodate
		'
		Me.dptodate.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.dptodate.Location = New System.Drawing.Point(5, 47)
		Me.dptodate.Name = "dptodate"
		Me.dptodate.Size = New System.Drawing.Size(116, 20)
		Me.dptodate.TabIndex = 114
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.ColumnCount = 7
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
		Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 110)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1010, 83)
		Me.TableLayoutPanel2.TabIndex = 5
		'
		'Panel3
		'
		Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.cmbdilvery)
		Me.Panel3.Location = New System.Drawing.Point(3, 3)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(138, 71)
		Me.Panel3.TabIndex = 5
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.cmbThermal)
		Me.GroupBox1.Controls.Add(Me.cmbLaser)
		Me.GroupBox1.Controls.Add(Me.Button3)
		Me.GroupBox1.Controls.Add(Me.Tprint)
		Me.GroupBox1.Controls.Add(Me.Lprint)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(436, 66)
		Me.GroupBox1.TabIndex = 127
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Print"
		'
		'cmbThermal
		'
		Me.cmbThermal.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.cmbThermal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbThermal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbThermal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbThermal.Location = New System.Drawing.Point(107, 27)
		Me.cmbThermal.Name = "cmbThermal"
		Me.cmbThermal.Size = New System.Drawing.Size(195, 21)
		Me.cmbThermal.TabIndex = 133
		'
		'cmbLaser
		'
		Me.cmbLaser.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.cmbLaser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbLaser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbLaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbLaser.Location = New System.Drawing.Point(107, 19)
		Me.cmbLaser.Name = "cmbLaser"
		Me.cmbLaser.Size = New System.Drawing.Size(195, 21)
		Me.cmbLaser.TabIndex = 132
		'
		'Button3
		'
		Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button3.Location = New System.Drawing.Point(310, 37)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(84, 23)
		Me.Button3.TabIndex = 131
		Me.Button3.Text = "Print/Preview"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Tprint
		'
		Me.Tprint.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Tprint.AutoSize = True
		Me.Tprint.Location = New System.Drawing.Point(14, 37)
		Me.Tprint.Name = "Tprint"
		Me.Tprint.Size = New System.Drawing.Size(87, 17)
		Me.Tprint.TabIndex = 129
		Me.Tprint.TabStop = True
		Me.Tprint.Text = "Thermal Print"
		Me.Tprint.UseVisualStyleBackColor = True
		'
		'Lprint
		'
		Me.Lprint.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Lprint.AutoSize = True
		Me.Lprint.Location = New System.Drawing.Point(13, 14)
		Me.Lprint.Name = "Lprint"
		Me.Lprint.Size = New System.Drawing.Size(75, 17)
		Me.Lprint.TabIndex = 128
		Me.Lprint.TabStop = True
		Me.Lprint.Text = "Laser Print"
		Me.Lprint.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button2.Location = New System.Drawing.Point(310, 8)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(84, 23)
		Me.Button2.TabIndex = 127
		Me.Button2.Text = "Print"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(453, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 54)
		Me.Label1.TabIndex = 129
		Me.Label1.Text = "Job Details"
		'
		'Button5
		'
		Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button5.Location = New System.Drawing.Point(314, 10)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(119, 23)
		Me.Button5.TabIndex = 120
		Me.Button5.Text = "Set Columns"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'btnprintjob
		'
		Me.btnprintjob.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnprintjob.Location = New System.Drawing.Point(163, 17)
		Me.btnprintjob.Name = "btnprintjob"
		Me.btnprintjob.Size = New System.Drawing.Size(104, 23)
		Me.btnprintjob.TabIndex = 125
		Me.btnprintjob.Text = "Print Data"
		Me.btnprintjob.UseVisualStyleBackColor = True
		'
		'ComboBox1
		'
		Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Location = New System.Drawing.Point(7, 17)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(132, 21)
		Me.ComboBox1.TabIndex = 131
		'
		'btnimportToExcel
		'
		Me.btnimportToExcel.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnimportToExcel.Location = New System.Drawing.Point(314, 43)
		Me.btnimportToExcel.Name = "btnimportToExcel"
		Me.btnimportToExcel.Size = New System.Drawing.Size(119, 23)
		Me.btnimportToExcel.TabIndex = 122
		Me.btnimportToExcel.Text = "Export To Excel"
		Me.btnimportToExcel.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.86318!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.97183!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.26559!))
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 21)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1010, 72)
		Me.TableLayoutPanel1.TabIndex = 4
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.ComboBox1)
		Me.GroupBox2.Controls.Add(Me.btnimportToExcel)
		Me.GroupBox2.Controls.Add(Me.Button5)
		Me.GroupBox2.Controls.Add(Me.btnprintjob)
		Me.GroupBox2.Location = New System.Drawing.Point(565, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(442, 66)
		Me.GroupBox2.TabIndex = 128
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = " "
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
		'JobResponsive
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1033, 445)
		Me.Controls.Add(Me.TableLayoutPanel3)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "JobResponsive"
		Me.Text = "JobResponsive"
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnprint As Button
	Friend WithEvents cmbdilvery As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents cmbfilter As ComboBox
	Friend WithEvents btnshow As Button
	Friend WithEvents cmbjobst As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtsearch As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Panel6 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents Button1 As Button
	Friend WithEvents btnjobRepaire As Button
	Friend WithEvents jobdone As Button
	Friend WithEvents btnupdate As Button
	Friend WithEvents btnbarcode As Button
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Datefilter As CheckBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Panel2 As Panel
	Friend WithEvents dpfromdate As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents dptodate As DateTimePicker
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button3 As Button
	Friend WithEvents Tprint As RadioButton
	Friend WithEvents Lprint As RadioButton
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Button5 As Button
	Friend WithEvents btnprintjob As Button
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents btnimportToExcel As Button
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents cmbThermal As ComboBox
	Friend WithEvents cmbLaser As ComboBox
	Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
	Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
	Friend WithEvents PrintDocument2 As Drawing.Printing.PrintDocument
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents EditModifyJobEntryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
