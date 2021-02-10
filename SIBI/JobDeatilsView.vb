Public Class JobDeatilsView

	Private Sub JobDeatilsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim dvgprod As New DataGridViewTextBoxColumn()
		dvgprod.HeaderText = "ProductName"
		Dim dvgserail As New DataGridViewTextBoxColumn()
		dvgserail.HeaderText = "SerialNo"
		GroupBox4.Hide()
		LoadCmbStatus()
		LoadServiceType()
		FormatData()
		'DataGridView2.AutoSizeColumnsMode = True
		'DataGridView2.AllowUserToAddRows = False
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ReadOnly = True

		DataGridView2.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView2.ReadOnly = True

		DataGridView3.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView3.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView3.ReadOnly = True

		DataGridView4.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView4.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView4.ReadOnly = True

		'loadvalues(7)
	End Sub
	Sub FormatData()
		txtamt.ReadOnly = True
		txtcmpnynm.ReadOnly = True
		txtcomp.ReadOnly = True
		txtcustname.ReadOnly = True
		txtestval.ReadOnly = True
		txtjobid.ReadOnly = True
		txtmob.ReadOnly = True
		txtobserv.ReadOnly = True
		txtprodrep.ReadOnly = True
		txtrepairdone.ReadOnly = True
		dpamc.Enabled = False
		txtrepairdone.ReadOnly = True
		dpjobdate.Enabled = False

	End Sub
	Sub LoadCmbStatus()

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds2 As New DataSet
		Dim sql2 As String
		'  Dim i As Integer
		sql2 = "Select status from Status"
		Try
			OpenDatabaseObject()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql2, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds2, "JobStatus2")
			SQLAdapter.Dispose()

			For i = 0 To ds2.Tables(0).Rows.Count - 1
				' MsgBox(ds.Tables(0).Rows(i).Item(0))
				'txtjobstatus.Text = ds2.Tables(0).Rows(i).Item(0)
			Next
			txtjobstatus.Enabled = False
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub
	Private Sub LoadServiceType()
		cmbservicetyp.Items.Add("Paid")
		cmbservicetyp.Items.Add("AMC")
		cmbservicetyp.Items.Add("Warranty")
		cmbservicetyp.Text = "Paid"
	End Sub
	Public Sub loadvalues(jobid As Double)
		'MsgBox(jobid & " will be opened for modifications".ToString).ToString()

		Dim SQLAdapter As SqlClient.SqlDataAdapter

		Dim ds As New DataSet
		Dim ds2 As New DataSet
		Dim sql As String
		Dim sql2 As String

		Dim perviuosJobid As String
		'Dim i As Integer


		sql = String.Empty
		OpenDatabaseObject()

		sql = "Select * from job_services where ID =" & jobid.ToString
		sql2 = "Select ProductName,SerialNo from OtherproductDetails where Jobid =" & jobid.ToString & ""

		'MsgBox(sql)
		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			Dim prejob = ds.Tables(0).Rows(0).Item(columnName:="perviuosJobid")
			If String.IsNullOrWhiteSpace(prejob.ToString) Then
				perviuosJobid = "0"
			Else
				perviuosJobid = ds.Tables(0).Rows(0).Item(columnName:="perviuosJobid")
			End If
			txtjobid.Text = ds.Tables(0).Rows(0).Item(0)
			dpjobdate.Value = CDate(ds.Tables(0).Rows(0).Item(2))
			txtmob.Text = ds.Tables(0).Rows(0).Item(1)
			txtcustname.Text = ds.Tables(0).Rows(0).Item(3)
			txtprodrep.Text = ds.Tables(0).Rows(0).Item(4)
			txtcmpnynm.Text = ds.Tables(0).Rows(0).Item(columnName:="company_name")
			txtrepairdone.Text = ds.Tables(0).Rows(0).Item(columnName:="Repaire_Done").ToString

			txtcomp.Text = ds.Tables(0).Rows(0).Item(columnName:="prblm_comp")
			txtobserv.Text = ds.Tables(0).Rows(0).Item(columnName:="prblm_observe")
			txtestval.Text = ds.Tables(0).Rows(0).Item(columnName:="Estimate_value")

			txtjobstatus.Text = ds.Tables(0).Rows(0).Item(columnName:="Job_status")

			datagridLoad(True)
			RepaireGridView(True)
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()


		End Try



	End Sub
	Sub datagridLoad(Status)
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim chrge
		OpenDatabaseObject()


		sql = "Select ID,ProductName,SerialNo,OutDate,RepairStatus,RepairMan,Receiver,Receiver_mobile,ChrageableAmt,Outward,ProdRepairedDate,ProdOutSrcDate,ProdINSrcDate from OtherproductDetails where Jobid =" & txtjobid.Text

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			'DataGridView2.DataSource = ds
			'DataGridView2.DataMember = "customer_reg"
			Dim RecordCount As Double = ds.Tables(0).Rows.Count
			If RecordCount > 0 Then

				DataGridView1.Columns.Clear()
				DataGridView1.Rows.Clear()


				DataGridView3.Columns.Clear()
				DataGridView3.Rows.Clear()

				DataGridView4.Columns.Clear()
				DataGridView4.Rows.Clear()

				Dim dvgid As New DataGridViewTextBoxColumn()
				dvgid.HeaderText = "ID"
				Dim dgvProdnm As New DataGridViewTextBoxColumn()
				dgvProdnm.HeaderText = "ProductName"
				Dim dgvSerila As New DataGridViewTextBoxColumn()
				dgvSerila.HeaderText = "SerialNo"


				Dim dvgid2 As New DataGridViewTextBoxColumn()
				dvgid2.HeaderText = "ID"
				Dim dgvProdnm2 As New DataGridViewTextBoxColumn()
				dgvProdnm2.HeaderText = "ProductName"
				Dim dgvSerila2 As New DataGridViewTextBoxColumn()
				dgvSerila2.HeaderText = "SerialNo"

				Dim chrge1 As New DataGridViewTextBoxColumn()
				chrge1.HeaderText = "Chrage Amt."

				Dim dgvSerila33 As New DataGridViewTextBoxColumn()
				dgvSerila33.HeaderText = "Delivery Date"

				Dim Receiver As New DataGridViewTextBoxColumn()
				Receiver.HeaderText = "Receiver Name"
				Dim recmob As New DataGridViewTextBoxColumn()
				recmob.HeaderText = "Receiver No."


				Dim outid As New DataGridViewTextBoxColumn()
				outid.HeaderText = "ID"
				Dim outprod As New DataGridViewTextBoxColumn()
				outprod.HeaderText = "ProductName"
				Dim outserial As New DataGridViewTextBoxColumn()
				outserial.HeaderText = "SerialNo"
				Dim outrepaire As New DataGridViewTextBoxColumn()
				outrepaire.HeaderText = "RepairStatus"
				Dim Outdate1 As New DataGridViewTextBoxColumn()
				Outdate1.HeaderText = "Outdate"
				Dim indate As New DataGridViewTextBoxColumn()
				indate.HeaderText = "InDate"


				DataGridView1.Columns.Add(dvgid)
				DataGridView1.Columns.Add(dgvProdnm)
				DataGridView1.Columns.Add(dgvSerila)



				DataGridView3.Columns.Add(dvgid2)
				DataGridView3.Columns.Add(dgvProdnm2)
				DataGridView3.Columns.Add(dgvSerila2)
				DataGridView3.Columns.Add(chrge1)
				DataGridView3.Columns.Add(dgvSerila33)
				DataGridView3.Columns.Add(Receiver)
				DataGridView3.Columns.Add(recmob)


				DataGridView4.Columns.Add(outid)
				DataGridView4.Columns.Add(outprod)
				DataGridView4.Columns.Add(outserial)
				DataGridView4.Columns.Add(outrepaire)
				DataGridView4.Columns.Add(Outdate1)
				DataGridView4.Columns.Add(indate)


				For i = 0 To RecordCount - 1
					Dim OutDate = ds.Tables(0).Rows(i).Item(3)
					Dim OutwardStatus = ds.Tables(0).Rows(i).Item("Outward").ToString
					If IsDBNull(ds.Tables(0).Rows(i).Item(4)) = False Then
						If ds.Tables(0).Rows(i).Item("RepairStatus") = "Repaired" And String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item("RepairMan").ToString) = False Then
							DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2))
							DataGridView1.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
						ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") = "UnRepaired" Then
							DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2))
							DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireableRed
						Else
							DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2))
							DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
						End If
					Else
						DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2))
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
					End If


					If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("OutDate").ToString) = False Then
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
					End If

					If String.IsNullOrWhiteSpace(OutwardStatus.ToString) Then
						OutwardStatus = " "
					End If



					If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("OutDate").ToString) = False And Status = True Then
						DataGridView3.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), ds.Tables(0).Rows(i).Item(8), Format(CDate(ds.Tables(0).Rows(i).Item(3)), "dd-MMM-yyyy"), ds.Tables(0).Rows(i).Item(6), ds.Tables(0).Rows(i).Item(7))
						DataGridView3.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
					ElseIf Status = False Then
						Dim del_dt
						If IsDBNull(ds.Tables(0).Rows(i).Item(3)) Then
							del_dt = ""
						Else
							del_dt = Format(CDate(ds.Tables(0).Rows(i).Item(3)), "dd-MMM-yyyy")
						End If


						DataGridView3.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), ds.Tables(0).Rows(i).Item(8), del_dt, ds.Tables(0).Rows(i).Item(6), ds.Tables(0).Rows(i).Item(7))
						If IsDBNull(ds.Tables(0).Rows(i).Item("RepairStatus")) Then
							If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("OutDate").ToString) = False Then
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
							ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") = "Repaired" Then
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
							ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") = "UnRepaired" Then
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = NotRepaireableRed
							ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") = "Pending" Then
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
							Else
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
							End If

						Else
							DataGridView3.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink


						End If

						If OutwardStatus = "True" Then
								DataGridView3.Rows(i).DefaultCellStyle.BackColor = OutsrcLightYellow
							End If

						End If


						If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item(8).ToString) = False Then
						chrge = chrge + ds.Tables(0).Rows(i).Item(8)
					End If

					If OutwardStatus = "True" Then
						DataGridView1.Rows(i).ReadOnly = True
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = OutsrcLightYellow
					End If

					If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("OutDate").ToString) = False Then
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue

					End If

				Next
				txtamt.Text = chrge
			End If
			', ProdINSrcDate


			Dim str = "ds"

			SQLAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()


		End Try


	End Sub


	Sub RepaireGridView(status)
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim chrge
		OpenDatabaseObject()
		DataGridView2.Columns.Clear()
		DataGridView2.Rows.Clear()

		Dim dvgid1 As New DataGridViewTextBoxColumn()
		dvgid1.HeaderText = "ID"
		Dim dgvProdnm1 As New DataGridViewTextBoxColumn()
		dgvProdnm1.HeaderText = "ProductName"
		Dim dgvSerila1 As New DataGridViewTextBoxColumn()
		dgvSerila1.HeaderText = "SerialNo"
		Dim dgvRep As New DataGridViewTextBoxColumn()
		dgvRep.HeaderText = "RepairStatus"
		Dim dgvRep1 As New DataGridViewTextBoxColumn()
		dgvRep1.HeaderText = "Repaired Date"
		Dim dgvRep2 As New DataGridViewTextBoxColumn()
		dgvRep2.HeaderText = "Repair By"

		DataGridView2.Columns.Add(dvgid1)
		DataGridView2.Columns.Add(dgvProdnm1)
		DataGridView2.Columns.Add(dgvSerila1)
		DataGridView2.Columns.Add(dgvRep)
		DataGridView2.Columns.Add(dgvRep1)
		DataGridView2.Columns.Add(dgvRep2)
		sql = "Select ID,ProductName,SerialNo,OutDate,RepairStatus,RepairMan,Receiver,Receiver_mobile,ChrageableAmt,Outward,ProdRepairedDate,ProdOutSrcDate,ProdINSrcDate from OtherproductDetails where Jobid =" & txtjobid.Text

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			Dim RecordCount As Double = ds.Tables(0).Rows.Count


			For i = 0 To RecordCount - 1
				Dim OutDate = ds.Tables(0).Rows(i).Item(3)
				Dim OutwardStatus = ds.Tables(0).Rows(i).Item("Outward").ToString
				Dim Reapiredate
				Dim prodId = ds.Tables(0).Rows(i).Item("ID").ToString
				Dim ProdName = ds.Tables(0).Rows(i).Item("ProductName").ToString
				Dim serialNo = ds.Tables(0).Rows(i).Item("SerialNo").ToString
				Dim RepaireStatus = ds.Tables(0).Rows(i).Item("RepairStatus").ToString
				If IsDBNull(ds.Tables(0).Rows(i).Item("ProdRepairedDate")) = True Then
					Reapiredate = ""
				Else
					Reapiredate = Format(ds.Tables(0).Rows(i).Item("ProdRepairedDate"), "dd-MMM-yyyy").ToString
				End If
				Dim RepaireMan = ds.Tables(0).Rows(i).Item("RepairMan").ToString
				If IsDBNull(ds.Tables(0).Rows(i).Item("RepairStatus")) = False Then

					If ds.Tables(0).Rows(i).Item("RepairStatus") = "Repaired" And status = True And String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item("RepairMan").ToString) = False Then
						DataGridView2.Rows.Add(prodId, ProdName, serialNo, RepaireStatus, Reapiredate, RepaireMan)
						DataGridView2.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
					ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") <> "Pending" And status = False Then
						DataGridView2.Rows.Add(prodId, ProdName, serialNo, RepaireStatus, Reapiredate, RepaireMan)

						If ds.Tables(0).Rows(i).Item("RepairStatus") = "Repaired" And String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item("RepairMan").ToString) = False Then
							DataGridView2.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
						ElseIf ds.Tables(0).Rows(i).Item("RepairStatus") = "UnRepaired" Or ds.Tables(0).Rows(i).Item("RepairStatus") = "Not Repairable" Then
							DataGridView2.Rows(i).DefaultCellStyle.BackColor = NotRepaireableRed
						Else
							DataGridView2.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink
						End If
					End If
				End If
				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("ProdOutSrcDate").ToString) = False Then
					DataGridView4.Rows.Add(ds.Tables(0).Rows(i).Item("ID").ToString, ds.Tables(0).Rows(i).Item("ProductName").ToString, ds.Tables(0).Rows(i).Item("SerialNo").ToString, ds.Tables(0).Rows(i).Item("RepairStatus").ToString, Format((ds.Tables(0).Rows(i).Item("ProdOutSrcDate")), "dd-MMM-yyyy").ToString, Format((ds.Tables(0).Rows(i).Item("ProdOutSrcDate")), "dd-MMM-yyyy").ToString)
				End If
			Next
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GroupBox4.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		GroupBox4.Hide()
	End Sub

	Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
		Dim Prodid, prodname As String
		'MsgBox(DataGridView4.CurrentRow.Cells(0).Value)
		Prodid = txtjobid.Text



		prodname = DataGridView4.CurrentRow.Cells(1).Value
		OutwardDetails.loadvalues(Prodid, prodname)
		OutwardDetails.ShowDialog()
	End Sub

	Private Sub DataGridView4_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentDoubleClick

	End Sub

	Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
		If CheckBox3.Checked = True Then
			RepaireGridView(False)
		Else
			RepaireGridView(True)
		End If
	End Sub

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

		If CheckBox2.Checked = True Then
			datagridLoad(False)
		Else
			datagridLoad(True)
		End If
	End Sub
End Class