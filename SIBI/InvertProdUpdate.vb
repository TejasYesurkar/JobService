Imports System.Data.SqlClient
Public Class InvertProdUpdate
	Public LoadValueFromJobID As Double
	Public LoadPreviousValues As Boolean
	Public OUTIDProd As String
	Private Sub InvertProdUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cmbjobst.Items.Clear()
		cmbjobst.Items.Add("Pending")
		cmbjobst.Items.Add("Repaired")
		cmbjobst.Items.Add("UnRepaired")

		If LoadPreviousValues = True Then
			loadvalues(LoadValueFromJobID)

		End If
		datagridLoad()
	End Sub

	Sub datagridLoad()
		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
		Dim ds1 As New DataSet
		Dim sql As String

		Dim Flag As Boolean = False
		DataGridView1.Rows.Clear()


		OpenDatabaseObject()


		sql = "Select ProductName,SerialNo,RepairMan,RepairStatus,ProdOutSrcDate,ID,ProdINSrcDate,OutDate,Outward from OtherproductDetails where Jobid =" & TextBox1.Text & ""
		'MsgBox(sql)

		Try
			'connection.Open()
			sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.SelectCommand.ExecuteNonQuery()
			sqldbAdapter.Fill(ds)
			sqldbAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim ProdName = ds.Tables(0).Rows(i).Item(columnName:="ProductName")
				Dim SerialNo = ds.Tables(0).Rows(i).Item(columnName:="SerialNo")
				Dim OutSrcDate = ds.Tables(0).Rows(i).Item(columnName:="ProdOutSrcDate")
				Dim InSrcDate = ds.Tables(0).Rows(i).Item(columnName:="ProdINSrcDate")
				Dim OutSrcStatus = ds.Tables(0).Rows(i).Item(columnName:="RepairStatus")
				Dim OutPrdoID = ds.Tables(0).Rows(i).Item(columnName:="ID")
				Dim StatusDelivery = ds.Tables(0).Rows(i).Item(columnName:="OutDate")

				If String.IsNullOrWhiteSpace(SerialNo) Then
					SerialNo = ""
				End If

				If OutSrcDate.ToString = "" Then
					InSrcDate = ""
				Else

					OutSrcDate = Format(OutSrcDate, "yyyy-MMM-dd")
				End If
				If InSrcDate.ToString = "" Then
					InSrcDate = ""
				Else
					InSrcDate = Format(InSrcDate, "yyyy-MMM-dd")
				End If


				DataGridView1.Rows.Add(Flag, OutPrdoID, ProdName, SerialNo, chargeAmt)

				If String.IsNullOrWhiteSpace(OutSrcStatus.ToString) Or OutSrcStatus.ToString = "False" Then
					If String.IsNullOrWhiteSpace(StatusDelivery.ToString) Then

						Flag = False

					Else
						DataGridView1.Rows(i).ReadOnly = True
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
						DataGridView1.Rows(i).Cells(0).Value = False
					End If


				ElseIf OutSrcStatus.ToString = "Pending" Then
					Flag = False
					If IsDBNull(ds.Tables(0).Rows(i).Item(columnName:="Outward")) = False Then
						If ds.Tables(0).Rows(i).Item(columnName:="Outward") = "True" Then

							Flag = True

							DataGridView1.Rows(i).ReadOnly = True
							DataGridView1.Rows(i).DefaultCellStyle.BackColor = outsandPendingcolor
							DataGridView1.Rows(i).Cells(0).Value = False
						End If
					End If

				Else

					Flag = True


					DataGridView1.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
					DataGridView1.Rows(i).Cells(0).Value = False

				End If
			Next

			sqldbAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex.ToString())
		End Try
	End Sub

	Sub loadvalues(OUTID As String)


		Dim sqldbAdapter1 As SqlDataAdapter
		Dim ds, ds2 As New DataSet
		Dim Sql2 As String
		OUTIDProd = OUTID

		OpenDatabaseObject()

		txtjobid.Text = OUTID
		Sql2 = "SELECT ID,Jobid,ProductName,SerialNo,OutDate,RepairMan,RepairStatus
      ,ProdOutSrcDate FROM OtherproductDetails where Jobid = " & OUTID

		'	Dim Sql3 = "SELECT ReturnRemark,final_amt_taken,RepaireName FROM OutSrcProductDetails where InID = " & OUTID
		Try

			'MsgBox(Sql2)
			sqldbAdapter1 = New SqlClient.SqlDataAdapter(Sql2, SQLConn)
			sqldbAdapter1.Fill(ds, "job_services_table")

			'		sqldbAdapter1 = New SqlClient.SqlDataAdapter(Sql3, SQLConn)
			'	sqldbAdapter1.Fill(ds2, "job_services_table")
			If ds.Tables(0).Rows.Count > 0 Then


				txtjobid.Text = ds.Tables(0).Rows(0).Item("ID")
				cmbjobst.Text = ds.Tables(0).Rows(0).Item("RepairStatus")
				txtrepairMan.Text = ds.Tables(0).Rows(0).Item("RepairMan")
				txtprodName.Text = ds.Tables(0).Rows(0).Item("ProductName")

				txtamt.Text = ds2.Tables(0).Rows(0).Item("final_amt_taken").ToString
				'txtretrunremark.Text = ds2.Tables(0).Rows(0).Item("ReturnRemark").ToString
			End If
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
		datagridLoad()
	End Sub

	Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
		Me.Close()

	End Sub

	Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click


		OpenDatabaseObject()

		Dim Sql = "Update OutSrcProductDetails set Retrun='" & Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd") & "',RetrunStatus ='" & cmbjobst.Text & "',ReturnRemark ='" & txtretrunremark.Text & "',ReceiverName ='" & session & "',final_amt_taken=" & txtamt.Text & " where ProductName ='" & txtprodName.Text & "' and InId = '" & txtjobid.Text & "'"
		Dim Sql2 = "update OtherproductDetails Set RepairStatus='" & cmbjobst.Text & "',Outward='False' ,ProdINSrcDate='" & Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd") & "'  where ProductName = '" & txtprodName.Text & "' And ID = '" & txtjobid.Text & "'"

		Dim comm As New SqlClient.SqlCommand(Sql, SQLConn)
		comm.ExecuteNonQuery()
		comm.Dispose()

		comm = New SqlClient.SqlCommand(Sql2, SQLConn)
		comm.ExecuteNonQuery()
		comm.Dispose()

		Dim Sql3 = "update OtherproductDetails Set RepairStatus='" & cmbjobst.Text & "',ProdINSrcDate='" & Format(CDate(DateTimePicker1.Text), "dd-MMM-yyyy") & "',Outward='False'  where ProductName = '" & txtprodName.Text & "' And ID = '" & OUTIDProd & "'"
		Dim com As New SqlClient.SqlCommand(Sql3, SQLConn)
		com.ExecuteNonQuery()
		com.Dispose()


		MsgBox("Inverted Details Add Sucessfully!! ").ToString()
		inverted_Form.btnfetch.PerformClick()
		Me.Close()
	End Sub
End Class