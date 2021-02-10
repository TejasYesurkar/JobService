<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinting
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrinting))
		Me.txtfile = New System.Windows.Forms.TextBox()
		Me.tsOpenfile = New System.Windows.Forms.ToolStripLabel()
		Me.tsPrint = New System.Windows.Forms.ToolStripLabel()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PrintDialog = New System.Windows.Forms.PrintDialog()
		Me.txtcompany = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.txtprobobserve = New System.Windows.Forms.TextBox()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtfile
		'
		Me.txtfile.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtfile.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtfile.Location = New System.Drawing.Point(0, 25)
		Me.txtfile.Multiline = True
		Me.txtfile.Name = "txtfile"
		Me.txtfile.ReadOnly = True
		Me.txtfile.Size = New System.Drawing.Size(800, 425)
		Me.txtfile.TabIndex = 3
		'
		'tsOpenfile
		'
		Me.tsOpenfile.Name = "tsOpenfile"
		Me.tsOpenfile.Size = New System.Drawing.Size(57, 22)
		Me.tsOpenfile.Text = "Open File"
		'
		'tsPrint
		'
		Me.tsPrint.Name = "tsPrint"
		Me.tsPrint.Size = New System.Drawing.Size(32, 22)
		Me.tsPrint.Text = "Print"
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOpenfile, Me.tsPrint})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
		Me.ToolStrip1.TabIndex = 2
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'PrintDoc
		'
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
		'PrintDialog
		'
		Me.PrintDialog.UseEXDialog = True
		'
		'txtcompany
		'
		Me.txtcompany.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcompany.Location = New System.Drawing.Point(500, 55)
		Me.txtcompany.Name = "txtcompany"
		Me.txtcompany.Size = New System.Drawing.Size(267, 29)
		Me.txtcompany.TabIndex = 4
		Me.txtcompany.Text = "SAI INFOTECH"
		Me.txtcompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtAddress
		'
		Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.Location = New System.Drawing.Point(500, 90)
		Me.txtAddress.Multiline = True
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(267, 24)
		Me.txtAddress.TabIndex = 5
		Me.txtAddress.Text = "6, SpaceStar, MICO Cir, near Panchavati Hyundai,"
		Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(500, 207)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(267, 62)
		Me.TextBox1.TabIndex = 6
		Me.TextBox1.Text = "1)  Adapter"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(500, 275)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(267, 34)
		Me.TextBox2.TabIndex = 7
		Me.TextBox2.Text = "Problem Desc: Printer Not Working"
		'
		'TextBox3
		'
		Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!)
		Me.TextBox3.Location = New System.Drawing.Point(500, 120)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(267, 21)
		Me.TextBox3.TabIndex = 8
		Me.TextBox3.Text = " Tidke Colony, Nashik, Maharashtra 422001 "
		Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox4
		'
		Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!)
		Me.TextBox4.Location = New System.Drawing.Point(500, 147)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(267, 21)
		Me.TextBox4.TabIndex = 9
		Me.TextBox4.Text = "Contact Office : 0253 2576477 "
		Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox5
		'
		Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!)
		Me.TextBox5.Location = New System.Drawing.Point(500, 174)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(267, 21)
		Me.TextBox5.TabIndex = 10
		Me.TextBox5.Text = "Job Id:13124"
		Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtprobobserve
		'
		Me.txtprobobserve.Location = New System.Drawing.Point(500, 315)
		Me.txtprobobserve.Multiline = True
		Me.txtprobobserve.Name = "txtprobobserve"
		Me.txtprobobserve.Size = New System.Drawing.Size(267, 69)
		Me.txtprobobserve.TabIndex = 11
		Me.txtprobobserve.Text = "Problem Observe: Printer Not Working"
		'
		'frmPrinting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.txtprobobserve)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.txtcompany)
		Me.Controls.Add(Me.txtfile)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Name = "frmPrinting"
		Me.Text = "frmPrinting"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtfile As TextBox
	Friend WithEvents tsOpenfile As ToolStripLabel
	Friend WithEvents tsPrint As ToolStripLabel
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents PrintDoc As Drawing.Printing.PrintDocument
	Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
	Friend WithEvents PrintDialog As PrintDialog
	Friend WithEvents txtcompany As TextBox
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents txtprobobserve As TextBox
End Class
