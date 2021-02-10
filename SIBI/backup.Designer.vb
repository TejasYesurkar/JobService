<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
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
		Me.components = New System.ComponentModel.Container()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.txtdb = New System.Windows.Forms.TextBox()
		Me.txtserver = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtfilepath = New System.Windows.Forms.TextBox()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtbackup = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ProgressBar1)
		Me.GroupBox1.Controls.Add(Me.txtdb)
		Me.GroupBox1.Controls.Add(Me.txtserver)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtfilepath)
		Me.GroupBox1.Location = New System.Drawing.Point(27, 23)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(542, 270)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Back-up"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(61, 202)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(426, 23)
		Me.ProgressBar1.TabIndex = 23
		Me.ProgressBar1.Visible = False
		'
		'txtdb
		'
		Me.txtdb.Location = New System.Drawing.Point(205, 65)
		Me.txtdb.Name = "txtdb"
		Me.txtdb.ReadOnly = True
		Me.txtdb.Size = New System.Drawing.Size(223, 20)
		Me.txtdb.TabIndex = 22
		'
		'txtserver
		'
		Me.txtserver.Location = New System.Drawing.Point(205, 32)
		Me.txtserver.Name = "txtserver"
		Me.txtserver.ReadOnly = True
		Me.txtserver.Size = New System.Drawing.Size(223, 20)
		Me.txtserver.TabIndex = 21
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(100, 33)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(99, 16)
		Me.Label3.TabIndex = 20
		Me.Label3.Text = "Server Name"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(123, 65)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(76, 16)
		Me.Label4.TabIndex = 19
		Me.Label4.Text = "Database"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(277, 149)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(151, 25)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Backup Data"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(103, 149)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(151, 25)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Change path"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(114, 104)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 15)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Folder Path"
		'
		'txtfilepath
		'
		Me.txtfilepath.Location = New System.Drawing.Point(205, 104)
		Me.txtfilepath.Name = "txtfilepath"
		Me.txtfilepath.Size = New System.Drawing.Size(223, 20)
		Me.txtfilepath.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(346, 7)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(123, 15)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Last Backup Date:"
		'
		'txtbackup
		'
		Me.txtbackup.AutoSize = True
		Me.txtbackup.Location = New System.Drawing.Point(475, 9)
		Me.txtbackup.Name = "txtbackup"
		Me.txtbackup.Size = New System.Drawing.Size(39, 13)
		Me.txtbackup.TabIndex = 5
		Me.txtbackup.Text = "Label3"
		'
		'Timer1
		'
		'
		'backup
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(598, 318)
		Me.Controls.Add(Me.txtbackup)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "backup"
		Me.Text = "backup"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents txtfilepath As TextBox
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents Label2 As Label
	Friend WithEvents txtbackup As Label
	Friend WithEvents txtdb As TextBox
	Friend WithEvents txtserver As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Timer1 As Timer
End Class
