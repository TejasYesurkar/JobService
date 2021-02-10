<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_view
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
		Me.btncust_update = New System.Windows.Forms.Button()
		Me.btnshow = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnsrch = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtsrchstr = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btncust_update
		'
		Me.btncust_update.Location = New System.Drawing.Point(104, 425)
		Me.btncust_update.Name = "btncust_update"
		Me.btncust_update.Size = New System.Drawing.Size(138, 23)
		Me.btncust_update.TabIndex = 2
		Me.btncust_update.Text = "Update Customer"
		Me.btncust_update.UseVisualStyleBackColor = True
		'
		'btnshow
		'
		Me.btnshow.Location = New System.Drawing.Point(709, 425)
		Me.btnshow.Name = "btnshow"
		Me.btnshow.Size = New System.Drawing.Size(121, 23)
		Me.btnshow.TabIndex = 3
		Me.btnshow.Text = "View Customer"
		Me.btnshow.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(306, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 35)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Customer Details"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.btnsrch)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.txtsrchstr)
		Me.GroupBox2.Location = New System.Drawing.Point(104, 110)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(726, 65)
		Me.GroupBox2.TabIndex = 105
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Search Options"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(572, 32)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(102, 23)
		Me.Button1.TabIndex = 105
		Me.Button1.Text = "View History"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'btnsrch
		'
		Me.btnsrch.Location = New System.Drawing.Point(240, 34)
		Me.btnsrch.Name = "btnsrch"
		Me.btnsrch.Size = New System.Drawing.Size(75, 23)
		Me.btnsrch.TabIndex = 104
		Me.btnsrch.Text = "Search"
		Me.btnsrch.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(3, 14)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(182, 13)
		Me.Label3.TabIndex = 103
		Me.Label3.Text = "Search Mobile/CustomerName:"
		'
		'txtsrchstr
		'
		Me.txtsrchstr.Location = New System.Drawing.Point(6, 36)
		Me.txtsrchstr.Name = "txtsrchstr"
		Me.txtsrchstr.Size = New System.Drawing.Size(171, 20)
		Me.txtsrchstr.TabIndex = 102
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(104, 178)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(726, 228)
		Me.DataGridView1.TabIndex = 0
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(396, 425)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(141, 23)
		Me.Button2.TabIndex = 106
		Me.Button2.Text = "Add Customer"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'customer_view
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(868, 558)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnshow)
		Me.Controls.Add(Me.btncust_update)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "customer_view"
		Me.Text = "customer_view"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btncust_update As Button
	Friend WithEvents btnshow As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtsrchstr As TextBox
	Friend WithEvents btnsrch As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
