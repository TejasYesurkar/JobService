Public Class OutwardDetails
    Private Sub OutwardDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Sub loadvalues(prodid As String, prodname As String)
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = String.Empty
		OpenDatabaseObject()
		sql = "Select * from OutSrcProductDetails where jobid =" & prodid & " and ProductName='" & prodname & "'"

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			If ds.Tables(0).Rows.Count > 0 Then

				txtprodid.Text = prodid
				txtprodnm.Text = ds.Tables(0).Rows(0).Item("ProductName")
				txtserialno.Text = ds.Tables(0).Rows(0).Item("SerialNo")
				txtoutremark.Text = ds.Tables(0).Rows(0).Item("OutProduRemark")
				txtrepaireman.Text = ds.Tables(0).Rows(0).Item("RepaireName")
				txtestval.Text = ds.Tables(0).Rows(0).Item("estimated_value").ToString

				txtchrg.Text = ds.Tables(0).Rows(0).Item(columnName:="final_amt_taken")
				txtoutrmrk.Text = ds.Tables(0).Rows(0).Item(columnName:="ReturnRemark")

			End If

		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()


		End Try

	End Sub
End Class