Public Class DashboardResult
	Public RepoType As String
	Dim SDate As String
	Dim EDate As String
	Private Sub DashboardResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)

		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ReadOnly = True
		cmbRepotyp.Items.Clear()
		cmbRepotyp.Items.Add("Pending Report")
		cmbRepotyp.Items.Add("Repaired Report")
		cmbRepotyp.Items.Add("Delivery Jobs Report")
		cmbRepotyp.Items.Add("New Job Report")
		cmbRepotyp.Items.Add("")
		dpfromdate.Value = Format(CDate(Now()), "yyyy-MM-dd")
		dptodate.Value = Format(CDate(Now()), "yyyy-MM-dd")

		If RepoType = "P" Then
			cmbRepotyp.Text = "Pending Report"
		ElseIf RepoType = "N" Then
			cmbRepotyp.Text = "New Job Report"
		ElseIf RepoType = "R" Then
			cmbRepotyp.Text = "Repaired Report"
		ElseIf RepoType = "D" Then
			cmbRepotyp.Text = "Delivery Jobs Report"

		End If
		'PendingJobs()
	End Sub

	Function PendingJobs() As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim SDate As Date = dpfromdate.Value
		Dim EDate As Date = dptodate.Value

		'  Dim i As Integer
		PendingJobs = ""
		OpenDatabaseObject()
		sql = "SELECT  " & colName & "  FROM job_services where Job_status ='Pending'"

		Try
			DataGridView1.ClearSelection()
			DataGridView1.Refresh()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "job_services_table")
			SQLAdapter.Dispose()

			DataGridView1.DataSource = ds

			DataGridView1.DataMember = "job_services_table"

			Format_Datagridview1()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()

		End Try
	End Function
	Function NewJobAsOnDate() As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim SDate As Date = dpfromdate.Value
		Dim EDate As Date = dptodate.Value


		NewJobAsOnDate = ""
		OpenDatabaseObject()
		sql = "SELECT  " & colName & " FROM job_services where job_date  between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "

		Try
			DataGridView1.ClearSelection()
			DataGridView1.Refresh()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "job_services_table")
			SQLAdapter.Dispose()

			DataGridView1.DataSource = ds

			DataGridView1.DataMember = "job_services_table"

			Format_Datagridview1()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Function


	Function JobsRepairedforDates() As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer

		Dim SDate As Date = dpfromdate.Value
		Dim EDate As Date = dptodate.Value


		JobsRepairedforDates = ""
		OpenDatabaseObject()
		sql = "SELECT " & colName & " FROM job_services Where date_repaire between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "

		Try
			DataGridView1.ClearSelection()
			DataGridView1.Refresh()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "job_services_table")
			SQLAdapter.Dispose()

			DataGridView1.DataSource = ds

			DataGridView1.DataMember = "job_services_table"

			Format_Datagridview1()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Function

	Function JobsDeliveryforDates() As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer
		Dim SDate As Date = dpfromdate.Value
		Dim EDate As Date = dptodate.Value

		OpenDatabaseObject()
		sql = "SELECT " & colName & " FROM job_services Where job_delivery_date between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "


		Try
			DataGridView1.ClearSelection()
			DataGridView1.Refresh()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "job_services_table")
			SQLAdapter.Dispose()

			DataGridView1.DataSource = ds

			DataGridView1.DataMember = "job_services_table"

			Format_Datagridview1()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		'Return JobsDeliveryforDates
	End Function

	Private Sub Format_Datagridview1()


		On Error Resume Next
		DataGridView1.Columns("ID").HeaderText = "Job ID"
		DataGridView1.Columns("job_date").HeaderText = "Job Date"
		DataGridView1.Columns("cust_name").HeaderText = "Customer Name"
		DataGridView1.Columns("product_service").HeaderText = "Product For Repair/Services"
		DataGridView1.Columns("warranty").HeaderText = "Warranty/AMC Valid Till"
		DataGridView1.Columns("prblm_comp").HeaderText = "Problem Complained"
		DataGridView1.Columns("prblm_observe").HeaderText = "Problem Observed"
		DataGridView1.Columns("Estimate_value").HeaderText = "Estimated Value"
		'DataGridView1.Columns("Estimate_date").HeaderText = "Estimated Date"
		DataGridView1.Columns("Repaire_Done").HeaderText = "Repairs Done / Parts Used"
		DataGridView1.Columns("Remark").HeaderText = "Remarks"
		DataGridView1.Columns("name_of_user").HeaderText = "User name"
		DataGridView1.Columns("date_of_entry").HeaderText = "Date of Entry "
		DataGridView1.Columns("modify_user_name").HeaderText = "Data Modifed By"
		DataGridView1.Columns("date_of_modify").HeaderText = "Date Of Data Modify"
		DataGridView1.Columns("company_name").HeaderText = "Compnay Name "
		DataGridView1.Columns("date_repaire").HeaderText = "Date Of product Repair"
		DataGridView1.Columns("job_delivery").HeaderText = "Job Deliver Status"
		DataGridView1.Columns("job_delivery_date").HeaderText = "Job Deliver Date"
		DataGridView1.Columns("Receiver").HeaderText = "Receiver's Name"
		DataGridView1.Columns("Receiver_mobile").HeaderText = "Receiver's Mob.Number"
		DataGridView1.Columns("RepaireDone_by").HeaderText = "Repair Done By "
		DataGridView1.Columns("perviuosJobid").HeaderText = "Previous Jobid"


		On Error GoTo 0
	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		SDate = Format(CDate(dpfromdate.Value), "yyyy-MM-dd")
		EDate = Format(CDate(dptodate.Value), "yyyy-MM-dd")

		If RepoType = "P" Then
			PendingJobs()
		ElseIf RepoType = "N" Then
			NewJobAsOnDate()
		ElseIf RepoType = "R" Then
			JobsRepairedforDates()
		ElseIf RepoType = "D" Then
			JobsDeliveryforDates()
		Else
			MsgBox("Invalid Report Type")
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		dpfromdate.Value = Format(dpfromdate.Value.AddDays(1), "yyyy-MM-dd")
		dptodate.Value = dpfromdate.Value
		Button1.PerformClick()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		dpfromdate.Value = Format(dpfromdate.Value.AddDays(-1), "yyyy-MM-dd")
		dptodate.Value = dpfromdate.Value
		Button1.PerformClick()
	End Sub

	Private Sub dpfromdate_ValueChanged(sender As Object, e As EventArgs) Handles dpfromdate.ValueChanged

	End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub

	Private Sub cmbRepotyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRepotyp.SelectedIndexChanged
		If cmbRepotyp.Text = "Pending Report" Then
			PendingJobs()
			txtpending.Text = "Pending List"
			RepoType = "P"
		ElseIf cmbRepotyp.text = "New Job Report" Then
			NewJobAsOnDate()
			txtpending.Text = "New Jobs List"
			RepoType = "N"
		ElseIf cmbRepotyp.text = "Repaired Report" Then
			JobsRepairedforDates()
			txtpending.Text = "Today Repaired Job "
			RepoType = "R"
		ElseIf cmbRepotyp.text = "Delivery Jobs Report" Then
			JobsDeliveryforDates()
			txtpending.Text = "Delivery Job List"
			RepoType = "D"
		Else
			MsgBox("Invalid Report Type")
		End If
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		Dim JobidNo As String
		JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value.ToString()
		JobDeatilsView.loadvalues(JobidNo)
		JobDeatilsView.ShowDialog()
	End Sub
End Class