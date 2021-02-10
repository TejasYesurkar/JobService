Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class customer_view
    Public DatabasePath = Application.StartupPath
    Public DatabaseFileName = "job_data.accdb"
	Public EnableAutoClick As Boolean
	Public Active As Boolean
	Public handlerID As String
	Public UpdatevIEW As String
	Public WhatsAppVIEW As Boolean
	Public AMCView As Boolean


	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Private Sub customer_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView1.ReadOnly = True

		shoWCust_data()
		If EnableAutoClick = True Then
			btnsrch.PerformClick()
		End If

		If txtsrchstr.Text.Length > 0 Then
			SearchCustomer()
			txtsrchstr.SelectionStart = 0
			txtsrchstr.SelectionLength = txtsrchstr.Text.Length


		End If

		txtsrchstr.Focus()

	End Sub
	Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
		shoWCust_data()
	End Sub

	Private Sub shoWCust_data()


		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select * from customer_reg"



		Try
			OpenDatabaseObject()

			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			ds.Dispose()
			SQLAdapter.Dispose()
			CloseDatabaseObject()

			DataGridView1.DataSource = ds

			DataGridView1.DataMember = "customer_reg"

			For i = 0 To ds.Tables(0).Rows.Count - 1
				'cmbcustname.Items.Add(ds.Tables(0).Rows(i).Item(1))
			Next
			'    SQLAdapter.Dispose()
			'      connection.Close()


		Catch ex As Exception
			MsgBox(ex).ToString()


		End Try

	End Sub

	Private Sub btncust_update_Click(sender As Object, e As EventArgs) Handles btncust_update.Click
		Dim JobidNo As String

		JobidNo = DataGridView1.CurrentRow.Cells(0).Value.ToString()

		If Trim(Len(JobidNo)) = 0 Then Exit Sub

		AddCustomerDetails.loadvalues(JobidNo)
		AddCustomerDetails.btnok.Enabled = False
		AddCustomerDetails.btnok.Visible = False

		AddCustomerDetails.btncust_update.Enabled = True
		AddCustomerDetails.btncust_update.Visible = True
		'display_JOBDetails.Close()
		'AddJobDetails.Close()

		AddCustomerDetails.Show()
	End Sub



	Private Sub cmbcustname_SelectedIndexChanged(sender As Object, e As EventArgs)
		' MsgBox(cmbcustname.Text)

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer

		OpenDatabaseObject()

		sql = "Select * from customer_reg"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			DataGridView1.DataSource = ds
			DataGridView1.DataMember = "customer_reg"
			For i = 0 To ds.Tables(0).Rows.Count - 1
				'   MsgBox(ds.Tables(0).Rows(i).Item(0) & "  --  " & ds.Tables(0).Rows(i).Item(1))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try
	End Sub


	Private Sub txtsrchstr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsrchstr.KeyPress


		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer

		OpenDatabaseObject()

		sql = "Select * from customer_reg where cust_name LIKE  '%" & txtsrchstr.Text & "%' OR  cust_mobile LIKE '%" & txtsrchstr.Text & "%'"


		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			DataGridView1.DataSource = ds
			DataGridView1.DataMember = "customer_reg"
			For i = 0 To ds.Tables(0).Rows.Count - 1
				'   MsgBox(ds.Tables(0).Rows(i).Item(0) & "  --  " & ds.Tables(0).Rows(i).Item(1))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub


	Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

		If WhatsAppVIEW Then
			SendMessage.textBox1.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_mobile").Value.ToString
			SendMessage.txtcustName.Text = "Customer Name: " & DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString
			Me.Close()
			Exit Sub
		End If
		If AMCView Then
			AmcAdd.txtmobile.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_mobile").Value.ToString
			AmcAdd.txtcustomer.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString
			AmcAdd.customerID = DataGridView1.CurrentRow.Cells(columnName:="cust_id").Value.ToString
			Me.Close()
			Exit Sub
		End If


		If String.IsNullOrWhiteSpace(UpdatevIEW) = False Then
			If UpdatevIEW = True Then
				NewAddjOB.txtcust_id.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_id").Value.ToString
				NewAddjOB.txtcustname.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString()
				NewAddjOB.txtmob.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_mobile").Value.ToString()
				NewAddjOB.txtcmpnynm.Text = DataGridView1.CurrentRow.Cells(columnName:="CompanyName").Value.ToString()
			End If
		End If


		If EnableAutoClick = True Then

			AddJobDetails.txtcust_id.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_id").Value.ToString
			AddJobDetails.txtcustname.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString()
			AddJobDetails.txtcustname.BackColor = WhiteBackgound
			AddJobDetails.txtmob.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_mobile").Value.ToString()
			AddJobDetails.txtcmpnynm.Text = DataGridView1.CurrentRow.Cells(columnName:="CompanyName").Value.ToString()
		End If
		If Active = True Then
			Try

				followupAdd.txtcustnm.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString()
				followupAdd.txtmob.Text = DataGridView1.CurrentRow.Cells(columnName:="cust_mobile").Value.ToString()

				Active = False
				MsgBox(DataGridView1.CurrentRow.Cells(columnName:="cust_name").Value.ToString())
			Catch ex As Exception
				MsgBox(ex.ToString).ToString()

			End Try

		End If

		Me.Hide()
	End Sub

	Private Sub btnsrch_Click(sender As Object, e As EventArgs) Handles btnsrch.Click

		SearchCustomer()
	End Sub


	Private Function SearchCustomer()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()

		sql = "Select * from customer_reg where cust_name LIKE  '%" & txtsrchstr.Text & "%' OR  cust_mobile LIKE '%" & txtsrchstr.Text & "%'"

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			DataGridView1.DataSource = ds
			DataGridView1.DataMember = "customer_reg"

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Function
	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ReportViewer.CustomerReport(DataGridView1.CurrentRow.Cells(0).Value.ToString())
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		AddCustomerDetails.btncust_update.Enabled = False
		AddCustomerDetails.btncust_update.Visible = False
		AddCustomerDetails.btnok.Enabled = True
		AddCustomerDetails.btnok.Visible = True
		AddCustomerDetails.Show()
	End Sub
End Class