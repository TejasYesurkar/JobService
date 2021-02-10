Imports System.Data.SqlClient
Public Class ActivityAddForm
	Dim NewAddForm As New followupAdd
	Dim NewAddForm1 As New UpdateFollowup

	Private Sub ActivityAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Init()
	End Sub

	Sub Init()

		cmbjobst.Items.Clear()
		cmbjobst.Items.Add("Pending")
		cmbjobst.Items.Add("Closed")
		cmbjobst.Text = "Pending"

		DataGridCellFormatting()
		ShowData(cmbjobst.Text)

	End Sub

	Private Sub DataGridCellFormatting()

		DataGridView1.Columns.Clear()
		Dim dgvProdnid As New DataGridViewTextBoxColumn()
		dgvProdnid.HeaderText = "ID"

		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "Customer Name"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "Mob.Number"
		Dim dgvcIndt As New DataGridViewTextBoxColumn()
		dgvcIndt.HeaderText = "Date"
		Dim dgvoutDt As New DataGridViewTextBoxColumn()
		dgvoutDt.HeaderText = "Time"

		Dim Reason As New DataGridViewTextBoxColumn()
		Reason.HeaderText = "Reason"

		Dim Status As New DataGridViewTextBoxColumn()
		Status.HeaderText = "Status"

		Dim Description As New DataGridViewTextBoxColumn()
		Description.HeaderText = "Description"

		Dim Remark As New DataGridViewTextBoxColumn()
		Remark.HeaderText = "Remark"

		Dim Clsdt As New DataGridViewTextBoxColumn()
		Clsdt.HeaderText = "Close date"

		Dim dgvClear As New DataGridViewButtonColumn()
		dgvClear.HeaderText = "Status"

		DataGridView1.Columns.Add(dgvProdnid) 'id
		DataGridView1.Columns.Add(dgvProdnm) 'cust name
		DataGridView1.Columns.Add(dgvSerila) 'Mob No.
		DataGridView1.Columns.Add(dgvcIndt) 'Date
		DataGridView1.Columns.Add(Clsdt) 'Close date
		DataGridView1.Columns.Add(Reason) 'Reason	
		DataGridView1.Columns.Add(Description) ' description
		DataGridView1.Columns.Add(Remark) 'Remark
		DataGridView1.Columns.Add(dgvoutDt) 'Time
		DataGridView1.Columns.Add(Status) 'Status

		DataGridView1.Columns.Add(dgvClear)
		DataGridView1.ReadOnly = True
		dgvProdnid.Width = 25
		Status.Width = 50
		Description.Width = 300
		Remark.Width = 300

		DataGridView1.AllowUserToAddRows = False
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

	End Sub




	Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
		followupAdd.Show()
		followupAdd.Focus()


	End Sub

	Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


		If e.ColumnIndex = 9 And DataGridView1.CurrentRow.Cells(9).Value <> "Done" Then

			NewAddForm1.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
			NewAddForm1.txtcustnm.Text = DataGridView1.CurrentRow.Cells(1).Value
			NewAddForm1.txtmob.Text = DataGridView1.CurrentRow.Cells(2).Value
			NewAddForm1.dpdate.Text = Format(Now(), "dd-MM-yyyy")
			NewAddForm1.txttime.Text = TimeOfDay.ToString("h:mm:ss tt")
			NewAddForm1.Res = DataGridView1.CurrentRow.Cells(5).Value
			NewAddForm1.Status = DataGridView1.CurrentRow.Cells(6).Value
			NewAddForm1.txtdecs.Text = DataGridView1.CurrentRow.Cells(7).Value
			NewAddForm1.txtremark.Text = DataGridView1.CurrentRow.Cells(8).Value
			NewAddForm1.ShowDialog()
		Else

			NewAddForm.LoadPreviousValues = True
			NewAddForm.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
			NewAddForm.txtcustnm.Text = DataGridView1.CurrentRow.Cells(1).Value
			NewAddForm.txtmob.Text = DataGridView1.CurrentRow.Cells(2).Value
			NewAddForm.dpdate.Text = DataGridView1.CurrentRow.Cells(3).Value
			NewAddForm.txttime.Text = DataGridView1.CurrentRow.Cells(8).Value
			NewAddForm.Cmbreason.Text = DataGridView1.CurrentRow.Cells(5).Value
			NewAddForm.cmbstatus.Text = DataGridView1.CurrentRow.Cells(9).Value
			NewAddForm.txtdecs.Text = DataGridView1.CurrentRow.Cells(6).Value
			NewAddForm.txtremark.Text = DataGridView1.CurrentRow.Cells(7).Value
			NewAddForm.btncrm.Visible = False
			NewAddForm.btnclear.Visible = False
			NewAddForm.btnadd.Visible = False
			NewAddForm.GroupBox2.Enabled = False
			NewAddForm.txttime.Visible = True
			NewAddForm.ss.Visible = False
			NewAddForm.Button1.Visible = False


			'0	DataGridView1.Columns.Add(dgvProdnid) 'id 
			'1	DataGridView1.Columns.Add(dgvProdnm) 'cust name
			'2	DataGridView1.Columns.Add(dgvSerila) 'Mob No.
			'3	DataGridView1.Columns.Add(dgvcIndt) 'Date
			'4	DataGridView1.Columns.Add(Clsdt) 'Close date
			'5	DataGridView1.Columns.Add(Reason) 'Reason	
			'6	DataGridView1.Columns.Add(Description) ' description
			'7	DataGridView1.Columns.Add(Remark) 'Remark
			'8	DataGridView1.Columns.Add(dgvoutDt) 'Time
			'9	DataGridView1.Columns.Add(Status) 'Status
			NewAddForm.BackColor = Color.FromArgb(240, 207, 217) 'FromArgb(204, 196, 217)
			NewAddForm.ShowDialog()

		End If
	End Sub


	Private Sub cmbjobst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjobst.SelectedIndexChanged
		ShowData(cmbjobst.Text)
	End Sub

	Sub ShowData(text As String)
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds, ds1 As New DataSet
		Dim sql, sql2 As String
		'  Dim i As Integer

		OpenDatabaseObject()

		sql = "Select * from ActivityTable where status='" & text & "' and (taskAssign ='" & session & "' or taskAssign ='All') and ADate  <= CAST(GETDATE() AS DATE) Order By ADate ASC"

		DataGridCellFormatting()
		DataGridView1.Rows.Clear()

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			'DataGridView1.DataSource = ds
			'DataGridView1.DataMember = "customer_reg"

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim Aid = ds.Tables(0).Rows(i).Item("Aid")
				Dim custname = ds.Tables(0).Rows(i).Item("customerName")
				Dim Mob = ds.Tables(0).Rows(i).Item("Mobileno")
				Dim datee = ds.Tables(0).Rows(i).Item("ADate")
				Dim timee = ds.Tables(0).Rows(i).Item("ATime")
				Dim Reason = ds.Tables(0).Rows(i).Item("Reason")
				Dim status = ds.Tables(0).Rows(i).Item("status")
				Dim decs = ds.Tables(0).Rows(i).Item("decs")
				Dim remark = ds.Tables(0).Rows(i).Item("remark")
				Dim privId = ds.Tables(0).Rows(i).Item("PreviousID").ToString
				Dim clzDate = ds.Tables(0).Rows(i).Item("CloseDate").ToString
				If text = "Pending" Then
					If String.IsNullOrWhiteSpace(privId) = False Then

						sql2 = "Select CloseDate from ActivityTable where Aid = " & privId

						'MsgBox(sql2)
						SQLAdapter = New SqlClient.SqlDataAdapter(sql2, SQLConn)
						SQLAdapter.SelectCommand.ExecuteNonQuery()
						SQLAdapter.Fill(ds1, "customer_reg")
						SQLAdapter.Dispose()


						If String.IsNullOrWhiteSpace(ds1.Tables(0).Rows(0).Item("CloseDate")) = False Then
							clzDate = Format(CDate(ds1.Tables(0).Rows(0).Item("CloseDate")), "dd MMM yyyy")

						End If


					End If
				End If

				'MsgBox(privId)
				If status = "Pending" Then
					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "dd MMM yyyy"), clzDate, Reason, decs, remark, timee, status, "End Call")
				Else
					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "dd MMM yyyy"), clzDate, Reason, decs, remark, timee, status, "Done")
				End If
			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

		If e.ColumnIndex = 10 And DataGridView1.CurrentRow.Cells(10).Value <> "Done" Then

			'0	DataGridView1.Columns.Add(dgvProdnid) 'id 
			'1	DataGridView1.Columns.Add(dgvProdnm) 'cust name
			'2	DataGridView1.Columns.Add(dgvSerila) 'Mob No.
			'3	DataGridView1.Columns.Add(dgvcIndt)     'Date
			'4	DataGridView1.Columns.Add(Clsdt)      'Close date
			'5	DataGridView1.Columns.Add(Reason)        'Reason	
			'6	DataGridView1.Columns.Add(Description) ' description
			'7	DataGridView1.Columns.Add(Remark)       'Remark
			'8	DataGridView1.Columns.Add(dgvoutDt) 'Time
			'9	DataGridView1.Columns.Add(Status) 'Status

			NewAddForm1.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
			NewAddForm1.txtcustnm.Text = DataGridView1.CurrentRow.Cells(1).Value
			NewAddForm1.txtmob.Text = DataGridView1.CurrentRow.Cells(2).Value
			NewAddForm1.dpdate.Text = Format(Now(), "yyyy-MM-dd")
			NewAddForm1.txttime.Text = TimeOfDay.ToString("h:mm:ss tt")
			NewAddForm1.Res = DataGridView1.CurrentRow.Cells(5).Value
			NewAddForm1.Status = DataGridView1.CurrentRow.Cells(9).Value
			NewAddForm1.txtdecs.Text = DataGridView1.CurrentRow.Cells(6).Value
			NewAddForm1.txtremark.Text = DataGridView1.CurrentRow.Cells(7).Value

			NewAddForm1.GroupBox2.Visible = False

			NewAddForm1.txtid.Enabled = False
			NewAddForm1.txtcustnm.Enabled = False
			NewAddForm1.txtmob.Enabled = False
			NewAddForm1.dpdate.Enabled = False
			NewAddForm1.txttime.Enabled = False
			NewAddForm1.dpdate.Text = Format(Now(), "yyyy-MM-dd")
			NewAddForm1.nxtfollow.Checked = False
			NewAddForm1.DateTimePicker1.Value = Format(DateTime.Now.AddDays(1), "yyyy-MM-dd")
			NewAddForm1.txttime.Text = TimeOfDay.ToString("h:mm:ss tt")
			NewAddForm1.Res = DataGridView1.CurrentRow.Cells(5).Value
			NewAddForm1.hh.Text = "11"
			NewAddForm1.mm.Text = "00"
			NewAddForm1.ss.Text = "00"
			NewAddForm1.Button2.Text = "AM"
			NewAddForm1.txtdecs.Enabled = False
			NewAddForm1.ShowDialog()
		End If
	End Sub

	Private Sub ActivityAddForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
		ShowData(cmbjobst.Text)
	End Sub

	Private Sub ActivityAddForm_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
		ShowData(cmbjobst.Text)
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ShowData(cmbjobst.Text)
	End Sub

	Private Sub showall_Click(sender As Object, e As EventArgs) Handles showall.Click
		ShowAllFollowUp.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		DailyFollowup.Show()
	End Sub
End Class