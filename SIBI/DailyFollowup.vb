
Public Class DailyFollowup

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

		Dim dgvclose As New DataGridViewTextBoxColumn()
		dgvclose.HeaderText = "CloseDate"

		Dim dgvcloseT As New DataGridViewTextBoxColumn()
		dgvcloseT.HeaderText = "CloseTime"

		Dim Reason As New DataGridViewTextBoxColumn()
		Reason.HeaderText = "Reason"

		Dim Status As New DataGridViewTextBoxColumn()
		Status.HeaderText = "Status"

		Dim Description As New DataGridViewTextBoxColumn()
		Description.HeaderText = "Description"

		Dim Remark As New DataGridViewTextBoxColumn()
		Remark.HeaderText = "Remark"

		Dim dgvClear As New DataGridViewButtonColumn()
		dgvClear.HeaderText = "Action"
		DataGridView1.Columns.Add(dgvProdnid) 'id
		DataGridView1.Columns.Add(dgvProdnm) 'cust name
		DataGridView1.Columns.Add(dgvSerila) 'Mob No.
		DataGridView1.Columns.Add(dgvcIndt) 'Date
		DataGridView1.Columns.Add(dgvoutDt) 'Time
		DataGridView1.Columns.Add(dgvclose) 'CloseDate
		DataGridView1.Columns.Add(dgvcloseT) 'CloseTime
		DataGridView1.Columns.Add(Reason) 'Status
		DataGridView1.Columns.Add(Status) 'Reason	
		DataGridView1.Columns.Add(Description) 'description
		DataGridView1.Columns.Add(Remark) 'Remark

		Reason.Width = 300
		Remark.Width = 300
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

		sql = "Select * from ActivityTable where CloseDate = '" & Format(CDate(dp.Text), "yyyy-MM-dd") & "' and status='Closed'  Order By ADate ASC"
		DataGridCellFormatting()
		DataGridView1.Rows.Clear()

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

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
				Dim closeDate = ds.Tables(0).Rows(i).Item("CloseDate")
				Dim closeTime = ds.Tables(0).Rows(i).Item("CloseTime")
				Dim NextSchedule As String
				If IsDBNull(ds.Tables(0).Rows(i).Item("PreviousID")) Then
					NextSchedule = " "
				Else
					NextSchedule = ds.Tables(0).Rows(i).Item("PreviousID")
				End If


				If status = "Pending" Then

					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "yyyy-MMM-dd"), timee, Format(CDate(closeDate)), closeTime, status, Reason, decs, remark)
				Else
					DataGridView1.Rows.Add(Aid, custname, Mob, Format(CDate(datee), "yyyy-MMM-dd"), timee, Format(CDate(closeDate)), closeTime, status, Reason, decs, remark)
				End If


			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub
	Private Sub DailyFollowup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ShowData()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'LoadReport()
		ReportViewer.Followlist(Format(CDate(dp.Text), "dd-MM-yyyy"))
		'DailyFollowupReport.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		ShowData()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		dp.Value = Format(dp.Value.AddDays(1), "yyyy-MM-dd")
		dp.Value = dp.Value
		Button2.PerformClick()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		dp.Value = Format(dp.Value.AddDays(-1), "yyyy-MM-dd")
		dp.Value = dp.Value
		Button2.PerformClick()
	End Sub

End Class