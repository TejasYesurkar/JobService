Imports System.Data.SqlClient

Module ModulesFunctions

	Public colName As String = ""

	Public Sub SelectColumnNameFilter()

		OpenDatabaseObject()

		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0


		sql = "Select  * from columnFilter "

		colName = ""
		Try

			Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			For i = 0 To ds.Tables(0).Rows.Count - 1
				If ds.Tables(0).Rows(i).Item(2) = True Then
					colName = colName & ds.Tables(0).Rows(i).Item(1) & ","
				End If
			Next

			colName = colName.Substring(0, Len(colName) - 1)


			'MsgBox(count)

		Catch ex As Exception
			MsgBox(ex.ToString())

		End Try

		CloseDatabaseObject()


	End Sub



	Public Function deleteJobID(jobid As String) As Boolean


		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim ds1 As New DataSet
		OpenDatabaseObject()
		Dim Sql = "Select Job_status,date_repaire,job_delivery,job_delivery_date from job_services  where ID =" & jobid
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(Sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			Sql = "Select ProdOutSrcDate,Outward from OtherproductDetails  where  Outward = 'true'  and Jobid =" & jobid
			SQLAdapter = New SqlClient.SqlDataAdapter(Sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds1, "customer_reg")
			SQLAdapter.Dispose()
			If ds1.Tables(0).Rows.Count > 0 Then
				MsgBox("Product is Outward on date " + Format(CDate(ds1.Tables(0).Rows(0).Item(0)), "dd-MMM-yyyy")).ToString()
				Return False
			End If

			If ds.Tables(0).Rows(0).Item(0).Equals("Pending") = False Then
				Dim str = "Unable To delete Job Stauts is " + ds.Tables(0).Rows(0).Item(0) + " on date " + Format(CDate(ds.Tables(0).Rows(0).Item("date_repaire")), "dd-MMM-yyyy")

				If ds.Tables(0).Rows(0).Item("job_delivery").Equals("Delivered") = True Then
					str = str + vbNewLine + "Job Delivered on " + Format(CDate(ds.Tables(0).Rows(0).Item("job_delivery_date")), "dd-MMM-yyyy")

				End If
				MsgBox(str).ToString()
			Else

				Try

					Dim dcmd As SqlCommand = New SqlCommand("Delete from job_services  where Job_status = 'Pending' and ID =" & jobid, SQLConn)
					Dim dcmd2 As SqlCommand = New SqlCommand("Delete from OtherproductDetails  where  Outward IS Null and Jobid =" & jobid, SQLConn)
					Dim dcmd3 As SqlCommand = New SqlCommand("DELETE FROM OutSrcProductDetails WHERE Jobid =" & jobid, SQLConn)
					dcmd.ExecuteNonQuery()
					dcmd2.ExecuteNonQuery()
					dcmd3.ExecuteNonQuery()
					MsgBox("Job Deleted Successfully").ToString()


				Catch ex As Exception
					MsgBox(ex.ToString).ToString()
					Return False
				End Try
			End If

		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try


		Return True
	End Function




End Module
