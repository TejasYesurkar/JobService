<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btndel = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnRep = New System.Windows.Forms.Button()
		Me.btnNew = New System.Windows.Forms.Button()
		Me.btnpending = New System.Windows.Forms.Button()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.btndel)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.btnRep)
		Me.GroupBox1.Controls.Add(Me.btnNew)
		Me.GroupBox1.Controls.Add(Me.btnpending)
		Me.GroupBox1.Location = New System.Drawing.Point(48, 34)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1230, 491)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button2.Location = New System.Drawing.Point(618, 70)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(212, 143)
		Me.Button2.TabIndex = 13
		Me.Button2.Text = "Day Report"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'btndel
		'
		Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.btndel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btndel.Location = New System.Drawing.Point(346, 280)
		Me.btndel.Name = "btndel"
		Me.btndel.Size = New System.Drawing.Size(212, 143)
		Me.btndel.TabIndex = 12
		Me.btndel.Text = "Today Delivery Jobs"
		Me.btndel.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(28, 14)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(199, 39)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "DashBoard"
		'
		'btnRep
		'
		Me.btnRep.BackColor = System.Drawing.Color.LimeGreen
		Me.btnRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.btnRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnRep.Location = New System.Drawing.Point(346, 72)
		Me.btnRep.Name = "btnRep"
		Me.btnRep.Size = New System.Drawing.Size(212, 139)
		Me.btnRep.TabIndex = 11
		Me.btnRep.Text = "Today Repaired Job "
		Me.btnRep.UseVisualStyleBackColor = False
		'
		'btnNew
		'
		Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnNew.Location = New System.Drawing.Point(36, 280)
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(216, 143)
		Me.btnNew.TabIndex = 10
		Me.btnNew.Text = "New Jobs Count"
		Me.btnNew.UseVisualStyleBackColor = False
		'
		'btnpending
		'
		Me.btnpending.BackColor = System.Drawing.Color.Brown
		Me.btnpending.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.btnpending.ForeColor = System.Drawing.SystemColors.Menu
		Me.btnpending.Location = New System.Drawing.Point(36, 72)
		Me.btnpending.Name = "btnpending"
		Me.btnpending.Size = New System.Drawing.Size(216, 139)
		Me.btnpending.TabIndex = 9
		Me.btnpending.Text = "Pending Job Counts"
		Me.btnpending.UseVisualStyleBackColor = False
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
		'Dashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(1290, 537)
		Me.Controls.Add(Me.GroupBox1)
		Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Name = "Dashboard"
		Me.Text = "JobStatusDetails"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btndel As Button
	Friend WithEvents btnRep As Button
	Friend WithEvents btnNew As Button
	Friend WithEvents btnpending As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
	Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
End Class
