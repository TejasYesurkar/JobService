<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodePrint
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
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtqty = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtjobid = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Printcmb = New System.Windows.Forms.ComboBox()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Button2)
		Me.GroupBox3.Controls.Add(Me.Label3)
		Me.GroupBox3.Controls.Add(Me.txtqty)
		Me.GroupBox3.Controls.Add(Me.Label2)
		Me.GroupBox3.Controls.Add(Me.txtjobid)
		Me.GroupBox3.Controls.Add(Me.Label1)
		Me.GroupBox3.Controls.Add(Me.Label13)
		Me.GroupBox3.Controls.Add(Me.Button1)
		Me.GroupBox3.Controls.Add(Me.Printcmb)
		Me.GroupBox3.Location = New System.Drawing.Point(192, 40)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(418, 381)
		Me.GroupBox3.TabIndex = 2135
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Bar code "
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(226, 252)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(90, 29)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(160, 42)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(179, 31)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "Barcode Print"
		'
		'txtqty
		'
		Me.txtqty.Location = New System.Drawing.Point(129, 187)
		Me.txtqty.MaxLength = 2
		Me.txtqty.Name = "txtqty"
		Me.txtqty.Size = New System.Drawing.Size(81, 20)
		Me.txtqty.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(43, 187)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(74, 13)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Print Copies"
		'
		'txtjobid
		'
		Me.txtjobid.Location = New System.Drawing.Point(129, 92)
		Me.txtjobid.Name = "txtjobid"
		Me.txtjobid.Size = New System.Drawing.Size(187, 20)
		Me.txtjobid.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(55, 92)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Job ID:"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(43, 140)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(84, 13)
		Me.Label13.TabIndex = 9
		Me.Label13.Text = "Printer Name:"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(94, 252)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(90, 29)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Barcode Print"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Printcmb
		'
		Me.Printcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Printcmb.FormattingEnabled = True
		Me.Printcmb.Location = New System.Drawing.Point(129, 137)
		Me.Printcmb.Name = "Printcmb"
		Me.Printcmb.Size = New System.Drawing.Size(187, 21)
		Me.Printcmb.TabIndex = 2
		'
		'BarcodePrint
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(762, 498)
		Me.Controls.Add(Me.GroupBox3)
		Me.Name = "BarcodePrint"
		Me.Text = "BarcodePrint"
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Printcmb As ComboBox
    Friend WithEvents txtjobid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
	Friend WithEvents Button2 As Button
End Class
