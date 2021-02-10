Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class job_delivery
	Dim ChargeableAmt As Int16 = 0
	Sub LoadCmbStatus()

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		' Dim i As Integer

		OpenDatabaseObject()
		sql = "Select status from Status where status != 'Delivered'"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				' MsgBox(ds.Tables(0).Rows(i).Item(0))
				cmbjobst.Items.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex).ToString()


		End Try
	End Sub


	Private Sub SubmitClk()

		Dim ds As New DataSet
		Dim sql As String
		Dim sql2 As String
		'Dim Check As Integer
		Dim DeliveryFlag As Boolean
		Dim NotDeliveredFlag As Boolean
		Dim aa As Integer
		Dim flag As Int16 = 0
		Dim dilverstatus As String = ""
		Dim jobstatus As String = cmbjobst.Text

		If String.IsNullOrWhiteSpace(txtrecver_mob.Text) Then
			MsgBox("Please Enter Mobile Number")
			txtrecver_mob.BackColor = WarningBackgound
			Exit Sub
		End If


		For aa = 0 To DataGridView1.Rows.Count - 1
			Dim Strst = DataGridView1.Rows(aa).Cells(0).Value
			If Strst = "True" Then
				DeliveryFlag = True
				dilverstatus = "Delivered"
			Else
				NotDeliveredFlag = True
				dilverstatus = "Undelivered"
			End If
		Next

		If DeliveryFlag = True And NotDeliveredFlag = True Then dilverstatus = "Part Delivered"
		If DeliveryFlag = True And NotDeliveredFlag = False Then dilverstatus = "Delivered"
		If DeliveryFlag = False And NotDeliveredFlag = True Then dilverstatus = "UnDelivered"

		If chkpaid.Checked = True Then

		End If

		sql = "update job_services set job_delivery='" & dilverstatus & "',Repaire_Done='" & txtrepairdone.Text & "',job_delivery_date='" & Format(CDate(Dp_Deli_Date.Text), "yyyy-MM-dd") & "',Job_status='" & cmbjobst.Text & "',Receiver='" & txtreciver.Text & "',Paid='" & chkpaid.Checked & "' where ID = " & txtjobid.Text & ""
		'MsgBox(sql)
		AutoAddComplete(txtreciver.Text)

		AutoComplete()
		Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			OpenDatabaseObject()

			Dim status As Boolean
			Dim mobno As String
			For i As Integer = 0 To DataGridView1.Rows.Count - 1

				'Database Connection Open

				status = DataGridView1.Rows(i).Cells(0).Value
				Dim outdt = DataGridView1.Rows(i).Cells(5).Value

				If status = True And String.IsNullOrWhiteSpace(DataGridView1.Rows(i).Cells(5).Value) Then
					Dim prodId = DataGridView1.Rows(i).Cells(1).Value
					Dim prdnm = DataGridView1.Rows(i).Cells(2).Value
					'MsgBox(DataGridView1.Rows(i).Cells(2).Value)
					If String.IsNullOrWhiteSpace(txtreciver.Text) Then
						MsgBox("Please Enter Receiver Name And Mobile number..!!")

						Exit Sub
					End If

					If String.IsNullOrWhiteSpace(txtrecver_mob.Text) Then
						mobno = "0"
					Else
						mobno = txtrecver_mob.Text
					End If
					sql2 = "update OtherproductDetails Set OutDate='" & Format(CDate(Dp_Deli_Date.Text), "yyyy-MM-dd") & "',Receiver='" & txtreciver.Text & "',Receiver_mobile=" & txtrecver_mob.Text & " where ProductName = '" & prdnm & "' and ID = " & prodId & ""
					'MsgBox(sql2)
					dataAdptr.UpdateCommand = New SqlCommand(sql2, SQLConn)
					dataAdptr.UpdateCommand.ExecuteNonQuery()

				End If

			Next

			If cmbjobst.Text = "Pending" Then
				MsgBox("Please Chnage Job Status..").ToString()
				cmbjobst.BackColor = WarningBackgound
				Exit Sub
			Else

				dataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
				dataAdptr.UpdateCommand.ExecuteNonQuery()
				MsgBox("Job Updated").ToString()
				display_JOBDetails.UpdateIndividualRow(txtjobid.Text)

				AutoComplete(txtreciver.Text)
				AutoAddComplete(txtreciver.Text)
				AutoComplete()
				clearAllTextBox()
			End If

		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		'
		CloseDatabaseObject()



	End Sub



	Private Sub LoadValues(jobid As Double)
		'MsgBox(jobid & " will be opened for Job  Done").ToString()

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'Dim i As Integer

		'display_JOBDetails.Hide()



		sql = String.Empty
		'connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & DatabasePath & "\" & DatabaseFileName & "'"
		OpenDatabaseObject()


		sql = "Select cust_name,RepaireDone_by,Job_status,Repaire_Done,date_repaire,prblm_comp,product_service,Remark,job_delivery_date,Paid  from job_services where ID =" & jobid
		txtjobid.Text = jobid

		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")
			'MsgBox(ds.Tables(0).Rows(0).Item(24))
			With ds.Tables(0)
				txtCustnm.Text = .Rows(0).Item(.Columns.IndexOf("cust_name"))
				'	txtnamerep.Text = .Rows(0).Item(.Columns.IndexOf("RepaireDone_by"))
				cmbjobst.Text = .Rows(0).Item(.Columns.IndexOf("Job_status"))
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("Repaire_Done"))) Then
					txtrepairdone.Text = ""
				Else
					txtrepairdone.Text = .Rows(0).Item(.Columns.IndexOf("Repaire_Done"))

				End If
				'	dpdaterep.Value = CDate(.Rows(0).Item(.Columns.IndexOf("date_repaire")))
				txtcomp.Text = .Rows(0).Item(.Columns.IndexOf("prblm_comp"))
				txtremark.Text = .Rows(0).Item(.Columns.IndexOf("Remark"))
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("job_delivery_date"))) Then
					Dp_Deli_Date.Value = Format(CDate(Now), "dd-MMM-yyyy")
				Else
					Dp_Deli_Date.Value = CDate(.Rows(0).Item(.Columns.IndexOf("job_delivery_date")))

				End If
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("Paid"))) Then
					chkpaid.Checked = False
				Else
					If .Rows(0).Item(.Columns.IndexOf("Paid")) = "True" Then
						chkpaid.Checked = True
					Else
						chkpaid.Checked = False
					End If

				End If
			End With
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub

	Sub datagridLoad()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim ds2 As New DataSet
		Dim sql As String
		Dim sql2 As String
		Dim Flag As Boolean
		DataGridView1.Rows.Clear()

		OpenDatabaseObject()
		sql = "Select ProductName,SerialNo,InDate,OutDate,Receiver,Receiver_mobile,RepairStatus,ID,statusRep,ChrageableAmt from OtherproductDetails where Jobid =" & txtjobid.Text & " "
		sql2 = "Select job_date from job_services where ID =" & txtjobid.Text & " "
		'MsgBox(sql)
		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			SQLAdapter = New SqlClient.SqlDataAdapter(sql2, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds2, "customer_reg")
			SQLAdapter.Dispose()
			Dim InDate = ds2.Tables(0).Rows(0).Item(0)
			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim str = ds.Tables(0).Rows(i).Item(3)
				If String.IsNullOrWhiteSpace(str.ToString) Then
					Flag = False
				Else
					Flag = True
				End If



				Dim ProdName = ds.Tables(0).Rows(i).Item(0)
				Dim SerialNo = ds.Tables(0).Rows(i).Item(1)
				Dim OutDate = ds.Tables(0).Rows(i).Item(3)
				Dim ReciverName = ds.Tables(0).Rows(i).Item(4)
				Dim ReciverMobNO = ds.Tables(0).Rows(i).Item(5)
				Dim OutsrcProdStatus = ds.Tables(0).Rows(i).Item(6)
				Dim Productid = ds.Tables(0).Rows(i).Item(7)
				Dim RepairedStatus = ds.Tables(0).Rows(i).Item(8).ToString.Trim
				Dim statusRep = ds.Tables(0).Rows(i).Item("RepairStatus").ToString.Trim
				If IsDBNull(ds.Tables(0).Rows(i).Item(9)) = False Then
					ChargeableAmt = ChargeableAmt + ds.Tables(0).Rows(i).Item(9)

				End If
				If String.IsNullOrWhiteSpace(OutDate.ToString) Then
					OutDate = ""
					ReciverName = ""
					ReciverMobNO = ""
				Else
					OutDate = Format(CDate(OutDate), "dd-MMM-yyyy")
				End If


				DataGridView1.Rows.Add(Flag, Productid, ProdName, SerialNo, Format(CDate(InDate), "dd-MMM-yyyy"), OutDate, ReciverName, ReciverMobNO, statusRep)
				txtreciver.Text = ReciverName
				txtrecver_mob.Text = ReciverMobNO
				If String.IsNullOrWhiteSpace(str.ToString) Then
					If RepairedStatus = "False" Or String.IsNullOrWhiteSpace(RepairedStatus) Or IsDBNull(RepairedStatus) Then

						Flag = True
						DataGridView1.Rows(i).ReadOnly = True
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
					Else
						If RepairedStatus = "True" Then
							DataGridView1.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
						End If
						'MsgBox(RepairedStatus)
						Flag = False
					End If
				Else
					Flag = True

					DataGridView1.Rows(i).ReadOnly = True
					DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
				End If

				If IsDBNull(OutsrcProdStatus) = False Then
					If OutsrcProdStatus = "UnRepaire" Then
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireableRed
					End If
				End If

			Next
			txtxchargable.Text = "Chargeable Amt : " & ChargeableAmt
			SQLAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub


	Private Sub Button2_Click(sender As Object, e As EventArgs) 
		'clearAllTextBox()
		FetchData()
		txtjobid.Focus()

	End Sub

	Public Sub FetchData()
		If String.IsNullOrWhiteSpace(txtjobid.Text) = True Then Exit Sub
		If String.IsNullOrEmpty(txtjobid.Text) = True Then Exit Sub
		If CheckJobIDPresent(txtjobid.Text) = False Then
			MsgBox("Job Id Not Found").ToString()
			clearAllTextBox()
		Else
			LoadValues(txtjobid.Text)
			datagridLoad()

			Exit Sub
		End If

	End Sub
	Private Sub clearAllTextBox()
		txtCustnm.Clear()
		'txtnamerep.Clear()
		txtrepairdone.Clear()
		txtjobid.Clear()
		DataGridView1.Rows.Clear()
		txtremark.Clear()
		txtreciver.Clear()
		txtrecver_mob.Clear()
		'txtremark.Clear()
		txtcomp.Clear()
	End Sub
	Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
		DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub


	Private Sub txtjobid_LostFocus(sender As Object, e As EventArgs)
		If String.IsNullOrWhiteSpace(txtjobid.Text) Then btnfetch.TabStop = False Else btnfetch.TabStop = True
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
		SubmitClk()

		txtjobid.Focus()
	End Sub

	Private Sub btnfetch_Click(sender As Object, e As EventArgs) Handles btnfetch.Click
		FetchData()
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		If e.ColumnIndex = 0 And String.IsNullOrWhiteSpace(DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value) Then



			If String.IsNullOrWhiteSpace(txtreciver.Text) Then
				txtreciver.BackColor = WarningBackgound
				MsgBox("Please Enter The Receiver Name").ToString()

			End If
			If String.IsNullOrWhiteSpace(txtrecver_mob.Text) Then
				txtrecver_mob.BackColor = WarningBackgound
				MsgBox("Please Enter The Receiver Mobile No.").ToString()

			End If

			If DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor.ToString = "Color [LightBlue]" Then
				DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = RepaireGreen
			End If

			If DataGridView1.Rows(e.RowIndex.ToString()).Cells(8).Value <> "Pending" Then
				DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = deliveryLightBlue
			End If


		End If
	End Sub

	Private Sub job_done_Activated(sender As Object, e As EventArgs) Handles Me.Activated

	End Sub

	Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
		If String.IsNullOrWhiteSpace(txtreciver.Text) Or String.IsNullOrWhiteSpace(txtrecver_mob.Text) Then
			MsgBox("Please Enter The Receiver Name and Mobile No..", vbOKOnly + vbExclamation).ToString()
			txtreciver.BackColor = WarningBackgound
			txtrecver_mob.BackColor = WarningBackgound
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False
			e.Cancel = True
		End If
	End Sub

	Private Sub txtrecver_mob_KeyUp(sender As Object, e As KeyEventArgs) Handles txtrecver_mob.KeyUp
		txtrecver_mob.BackColor = WhiteBackgound
	End Sub

	Private Sub txtreciver_KeyUp(sender As Object, e As KeyEventArgs) Handles txtreciver.KeyUp
		txtreciver.BackColor = WhiteBackgound
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked Then
			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If String.IsNullOrWhiteSpace(DataGridView1.Rows(RCnt).Cells(7).Value) Then
					If DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor.ToString <> "Color [LightBlue]" Then
						If DataGridView1.Rows(RCnt).Cells(8).Value <> "Pending" Then
							DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor = deliveryLightBlue
							DataGridView1.Rows(RCnt).Cells(0).Value = True
						End If
					End If
				End If

			Next
		Else
			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If String.IsNullOrWhiteSpace(DataGridView1.Rows(RCnt).Cells(7).Value) Then
					If DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor.ToString = "Color [LightBlue]" Then
						If DataGridView1.Rows(RCnt).Cells(8).Value <> "Pending" Then
							DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor = RepaireGreen
							DataGridView1.Rows(RCnt).Cells(0).Value = False
						End If

					End If
				End If

			Next
		End If



	End Sub
End Class