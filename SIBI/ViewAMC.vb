Public Class ViewAMC
	Private Sub ViewAMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cmbjobst.Items.Clear()
		cmbjobst.Items.Add("All")
		cmbjobst.Items.Add("Active")
		cmbjobst.Items.Add("Expire")

		cmbjobst.Text = "Active"

		DataGridCellFormatting()
		ShowData(cmbjobst.Text)
	End Sub

	Private Sub DataGridCellFormatting()

		DataGridView1.Columns.Clear()

		Dim dgvProdnid As New DataGridViewTextBoxColumn()
		dgvProdnid.HeaderText = "AMC ID"
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "Customer Name"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "Mob.Number"
		Dim dgvprod As New DataGridViewTextBoxColumn()
		dgvprod.HeaderText = "Product Name"
		Dim dgvcIndt As New DataGridViewTextBoxColumn()
		dgvcIndt.HeaderText = "Start Date"
		Dim dgvoutDt As New DataGridViewTextBoxColumn()
		dgvoutDt.HeaderText = "End Date"
		Dim dgpending As New DataGridViewTextBoxColumn()
		dgpending.HeaderText = "Pending Days"
		Dim dgvClear As New DataGridViewTextBoxColumn()
		dgvClear.HeaderText = "Status"
		Dim dgvReminder As New DataGridViewButtonColumn()
		dgvReminder.HeaderText = "Reminder"
		Dim dgvUpdate As New DataGridViewButtonColumn()
		dgvUpdate.HeaderText = "Extend"

		DataGridView1.Columns.Add(dgvProdnid) 'Amc id
		DataGridView1.Columns.Add(dgvProdnm) 'cust name
		DataGridView1.Columns.Add(dgvSerila) 'Mob No.
		DataGridView1.Columns.Add(dgvprod) 'Mob No.
		DataGridView1.Columns.Add(dgvcIndt) 'Start Date
		DataGridView1.Columns.Add(dgvoutDt) 'End Date
		DataGridView1.Columns.Add(dgpending) 'Pending days
		DataGridView1.Columns.Add(dgvClear) 'status
		DataGridView1.Columns.Add(dgvReminder) ' reminder
		DataGridView1.Columns.Add(dgvUpdate) 'extend
		DataGridView1.ReadOnly = True

		DataGridView1.AllowUserToAddRows = False
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

	End Sub


	Sub ShowData(text As String)
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds, ds1 As New DataSet
		Dim sql As String

		OpenDatabaseObject()

		sql = "SELECT atTbl.Aid,atTbl.Cid,cust.cust_name,cust.cust_mobile,atTbl.productName,atTbl.startDate,
			   atTbl.endDate FROM AMC_Table  atTbl inner Join Customer_reg cust on atTbl.Aid  = cust.cust_id"
		DataGridCellFormatting()
		DataGridView1.Rows.Clear()

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim Aid = ds.Tables(0).Rows(i).Item("Aid")
				Dim custname = ds.Tables(0).Rows(i).Item("cust_name")
				Dim Mob = ds.Tables(0).Rows(i).Item("cust_mobile")
				Dim startDate = ds.Tables(0).Rows(i).Item("startDate")
				Dim endDate = ds.Tables(0).Rows(i).Item("endDate")
				Dim productName = ds.Tables(0).Rows(i).Item("productName")
				Dim days = DateDiff(DateInterval.Day, DateTime.Now, endDate)
				If cmbjobst.Text = "All" Then




					If days > 0 Then
						DataGridView1.Rows.Add(Aid, custname, Mob, productName, Format(CDate(startDate), "dd MMM yyyy"), Format(CDate(endDate), "dd MMM yyyy"), DateDiff(DateInterval.Day, DateTime.Now, endDate), "Active", "WA Message", "")
					Else
						DataGridView1.Rows.Add(Aid, custname, Mob, productName, Format(CDate(startDate), "dd MMM yyyy"), Format(CDate(endDate), "dd MMM yyyy"), DateDiff(DateInterval.Day, DateTime.Now, endDate), "Expire", "WA Message", "Update")
					End If
				Else
					If cmbjobst.Text = "Active" Then
						If days > 0 Then
							DataGridView1.Rows.Add(Aid, custname, Mob, productName, Format(CDate(startDate), "dd MMM yyyy"), Format(CDate(endDate), "dd MMM yyyy"), DateDiff(DateInterval.Day, DateTime.Now, endDate), "Active", "WA Message", "")
						End If
					Else
						If days < 0 Then
							DataGridView1.Rows.Add(Aid, custname, Mob, productName, Format(CDate(startDate), "dd MMM yyyy"), Format(CDate(endDate), "dd MMM yyyy"), DateDiff(DateInterval.Day, DateTime.Now, endDate), "Expired", "WA Message", "Update")
						End If
					End If

				End If


			Next


			'MsgBox(DataGridView1.RowCount).ToString()

			For i = 0 To DataGridView1.RowCount - 1
				If DataGridView1.Rows(i).Cells(7).Value = "Active" Then
					DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.LightGreen
				Else
					DataGridView1.Rows(i).Cells(7).Style.BackColor = NotRepaireLightPink
				End If
			Next


			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub cmbjobst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjobst.SelectedIndexChanged
		ShowData(cmbjobst.Text)
	End Sub
	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		If e.ColumnIndex = 8 Then
			SendMessage.Close()
			SendMessage.textBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
			SendMessage.txtcustName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
			If DataGridView1.CurrentRow.Cells(6).Value > 0 Then
				SendMessage.richTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value & " days are remaining.Please update Your " & DataGridView1.Rows(e.RowIndex).Cells(3).Value & " AMC"
			Else
				SendMessage.richTextBox1.Text = "Your AMC is Expired.Please update Your " & DataGridView1.Rows(e.RowIndex).Cells(3).Value & " AMC"
			End If
			SendMessage.ShowDialog()

		End If

		If e.ColumnIndex = 9 And DataGridView1.Rows(e.RowIndex).Cells(9).Value = "Update" Then
			AmcAdd.txtcustomer.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
			AmcAdd.txtmobile.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
			AmcAdd.txtprod.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
			AmcAdd.PrveAMCID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
			AmcAdd.ShowDialog()
		End If
	End Sub

	Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
		AmcAdd.ShowDialog()
	End Sub

End Class