Public Class ShowAllFollowUp

	Dim NewAddForm1 As New UpdateFollowup
	Sub DataGridCellFormatting()
		DataGridView1.Columns.Clear()


		'cmbjobst.Text = "Pending"
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

		Dim dgvClear As New DataGridViewButtonColumn()
		dgvClear.HeaderText = "Status"




		DataGridView1.Columns.Add(dgvProdnid) 'id
		DataGridView1.Columns.Add(dgvProdnm) 'cust name
		DataGridView1.Columns.Add(dgvSerila) 'Mob No.
		DataGridView1.Columns.Add(dgvcIndt) 'Date
		DataGridView1.Columns.Add(dgvoutDt) 'Time
		DataGridView1.Columns.Add(Status) 'Status
		DataGridView1.Columns.Add(Reason) 'Reason	
		DataGridView1.Columns.Add(Description) ' description
		DataGridView1.Columns.Add(Remark) 'Remark

		DataGridView1.Columns.Add(dgvClear)


		Reason.Width = 300
		'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView1.AllowUserToAddRows = False
		DataGridView1.ReadOnly = True
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
	End Sub


	Sub ShowData()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer

		OpenDatabaseObject()

		sql = "Select * from ActivityTable where status='Pending' Order By ADate ASC"

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

				If status = "Pending" Then
					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "yyyy-MMM-dd"), timee, Reason, status, decs, remark, "End Call")
				Else
					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "yyyy-MMM-dd"), timee, Reason, status, decs, remark, "Closed")
				End If


			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub ShowAllFollowUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ShowData()
	End Sub



	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

		'	MsgBox(e.ColumnIndex)




		If e.ColumnIndex = 9 And DataGridView1.CurrentRow.Cells(9).Value <> "Done" Then

			NewAddForm1.txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
			NewAddForm1.txtcustnm.Text = DataGridView1.CurrentRow.Cells(1).Value
			NewAddForm1.txtmob.Text = DataGridView1.CurrentRow.Cells(2).Value
			NewAddForm1.dpdate.Text = Format(Now(), "yyyy-MM-dd")
			NewAddForm1.txttime.Text = TimeOfDay.ToString("h:mm:ss tt")
			NewAddForm1.Res = DataGridView1.CurrentRow.Cells(3).Value
			NewAddForm1.Status = DataGridView1.CurrentRow.Cells(6).Value
			NewAddForm1.txtdecs.Text = DataGridView1.CurrentRow.Cells(4).Value
			NewAddForm1.txtremark.Text = DataGridView1.CurrentRow.Cells(5).Value

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
			NewAddForm1.Res = DataGridView1.CurrentRow.Cells(3).Value
			NewAddForm1.hh.Text = "11"
			NewAddForm1.mm.Text = "00"
			NewAddForm1.ss.Text = "00"
			NewAddForm1.Button2.Text = "AM"
			NewAddForm1.txtdecs.Enabled = False
			NewAddForm1.ShowDialog()
		End If
	End Sub
End Class