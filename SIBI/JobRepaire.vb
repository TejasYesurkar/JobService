Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class JobRepaire
	Dim adapter As SqlDataAdapter
	Dim SQLAdapter As SqlClient.SqlDataAdapter
	Dim changes As DataSet
	Dim ds As New DataSet
	Dim cmdBuilder As SqlCommandBuilder
	Dim JobDelivery As String
	Public chrge
	Dim JobDate As String
	Dim CustomerMobileNo As String
	Dim JobDescription As String
	Dim LoadedValue As Boolean = True

	Private Sub btnfetch_Click(sender As Object, e As EventArgs) Handles btnfetch.Click
		DataGridView1.Rows.Clear()

		FetchData()
		txtjobid.Focus()
	End Sub

	Public Sub FetchData()
		If String.IsNullOrWhiteSpace(txtjobid.Text) = True Then Exit Sub
		If CheckJobIDPresent(txtjobid.Text) = False Then
			MsgBox("Job Id Not Found").ToString()
			clearAllTextBox()
			DataGridView1.Rows.Clear()
		Else
			DataGridView1.Rows.Clear()
			LoadValues(txtjobid.Text)
			Exit Sub
		End If
	End Sub

	Sub datagridLoad()
		DataGridView1.Rows.Clear()
		'Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim sql As String
		Dim Flag As Boolean
		OpenDatabaseObject()
		sql = "Select ProductName,SerialNo,ProdRepairedDate,ChrageableAmt,ID,OutDate,RepairStatus,RepairMan,statusRep,Outward from OtherproductDetails where Jobid =" & txtjobid.Text & ""
		DataGridView1.Rows.Clear()

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			DataGridView1.Rows.Clear()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim str = ds.Tables(0).Rows(i).Item("statusRep")
				If String.IsNullOrWhiteSpace(str.ToString) Or str.ToString = "False" Then
					Flag = False
				Else
					Flag = True
				End If

				Dim ProdName = ds.Tables(0).Rows(i).Item("ProductName")
				Dim SerialNo = ds.Tables(0).Rows(i).Item("SerialNo")
				Dim ProdRepaireDate = ds.Tables(0).Rows(i).Item("ProdRepairedDate")
				Dim ChrgeAmt = ds.Tables(0).Rows(i).Item("ChrageableAmt")
				Dim ProdId = ds.Tables(0).Rows(i).Item("ID")
				Dim DilveryDate = ds.Tables(0).Rows(i).Item("OutDate")
				Dim ProdOutStatus = ds.Tables(0).Rows(i).Item("RepairStatus")
				Dim RepaireMan = ds.Tables(0).Rows(i).Item("RepairMan")
				Dim ReapireFlag = ds.Tables(0).Rows(i).Item("statusRep")
				Dim OutwardStatus = ds.Tables(0).Rows(i).Item("Outward")

				If String.IsNullOrWhiteSpace(ChrgeAmt.ToString) Then
					ChrgeAmt = 0
				End If
				If String.IsNullOrWhiteSpace(OutwardStatus.ToString) Or IsDBNull(OutwardStatus) Then
					OutwardStatus = " "
				End If
				If String.IsNullOrWhiteSpace(ProdRepaireDate.ToString) Then
					ProdRepaireDate = ""
				Else
					ProdRepaireDate = Format(CDate(ProdRepaireDate), "dd-MMM-yyyy")
				End If
				DataGridView1.Rows.Add(Flag, ProdId, ProdName, SerialNo, ProdRepaireDate, ChrgeAmt, RepaireMan, "Clear")
				DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireLightPink


				If IsDBNull(ReapireFlag) = False Then
					If ReapireFlag = "True" Then
						DataGridView1.Rows(i).Cells(7).ReadOnly = False
						DataGridView1.Rows(i).Cells(0).ReadOnly = True
					End If

				End If



				If OutwardStatus = "True" Then
					DataGridView1.Rows(i).ReadOnly = True
					DataGridView1.Rows(i).DefaultCellStyle.BackColor = OutsrcLightYellow

					DataGridView1.Rows(i).Cells(0).ReadOnly = False
					DataGridView1.Rows(i).Cells(7).ReadOnly = True
					DataGridView1.Rows(i).Cells(7).Value = "Outward"
				End If

				If IsDBNull(ProdOutStatus) <> True Then

					If ProdOutStatus = "Repaired" Then

						Flag = True

						DataGridView1.Rows(i).ReadOnly = True
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = RepaireGreen
					ElseIf ProdOutStatus = "UnRepaired" Then

						Flag = True

						DataGridView1.Rows(i).ReadOnly = True
						DataGridView1.Rows(i).DefaultCellStyle.BackColor = NotRepaireableRed

					End If
				End If

				If IsDBNull(DilveryDate) = False Then
					DataGridView1.Rows(i).ReadOnly = True
					DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue

					DataGridView1.Rows(i).Cells(0).ReadOnly = False
					DataGridView1.Rows(i).Cells(7).ReadOnly = True
					DataGridView1.Rows(i).Cells(7).Value = "Delivered"

				End If
			Next
			Dim sum As Integer = 0
			For i As Integer = 0 To DataGridView1.Rows.Count() - 1
				sum = sum + DataGridView1.Rows(i).Cells(5).Value
				txttotalamt.Text = sum
			Next
			CloseDatabaseObject()
			ds.Clear()
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try

		LoadedValue = False

	End Sub

	Private Sub LoadValues(jobid As Double)

		Dim ds As New DataSet
		Dim sql As String
		sql = String.Empty
		OpenDatabaseObject()
		'sql = "Select cust_name,mobile,RepaireDone_by,Job_status,Repaire_Done,prblm_comp,product_service,Remark,job_delivery,job_delivery_date,Estimate_date,Estimate_value  from job_services where ID =" & jobid
		sql = "Select cust_name,job_date,mobile,perviuosJobid,prblm_observe,RepaireDone_by,Job_status,Repaire_Done,prblm_comp,product_service,Remark,job_delivery,job_delivery_date,Estimate_date,Estimate_value,mobile  from job_services where ID =" & jobid
		txtjobid.Text = jobid

		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			With ds.Tables(0)
				txtCustnm.Text = .Rows(0).Item(.Columns.IndexOf("cust_name"))
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("job_delivery"))) Then
					JobDelivery = ""
				Else
					JobDelivery = .Rows(0).Item(.Columns.IndexOf("job_delivery"))
				End If
				JobDate = .Rows(0).Item(.Columns.IndexOf("job_date"))
				txtcomp.Text = Trim(.Rows(0).Item(.Columns.IndexOf("prblm_comp")))
				txtremark.Text = Trim(.Rows(0).Item(.Columns.IndexOf("Remark")))
				txtprblobserve.Text = Trim(.Rows(0).Item(.Columns.IndexOf("prblm_observe")))
				cmbjobst.Text = Trim(.Rows(0).Item(.Columns.IndexOf("Job_status")))
				'	Dim str As String = .Rows(0).Item(.Columns.IndexOf("RepaireDone_by"))
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("RepaireDone_by"))) Then
					txtnamerep.Text = ""
					txtrepairdone.Text = ""
				Else
					txtnamerep.Text = .Rows(0).Item(.Columns.IndexOf("RepaireDone_by"))
					txtrepairdone.Text = .Rows(0).Item(.Columns.IndexOf("Repaire_Done"))
				End If
				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("perviuosJobid"))) Then
					txtprjobid.Text = ""
				Else
					txtprjobid.Text = .Rows(0).Item(.Columns.IndexOf("perviuosJobid"))
				End If
				CustomerMobileNo = .Rows(0).Item(.Columns.IndexOf("mobile"))
				'JobDescription = .Rows(0).Item(.Columns.IndexOf("Repaire_Done"))

				If IsDBNull(.Rows(0).Item(.Columns.IndexOf("Repaire_Done"))) Then
					JobDescription = ""
				Else
					JobDescription = .Rows(0).Item(.Columns.IndexOf("Repaire_Done"))
				End If
			End With
			datagridLoad()

		Catch ex As Exception
			MsgBox(ex.StackTrace).ToString()
		End Try

	End Sub
	Private Sub clearAllTextBox()

		txtjobid.Clear()
		txtprjobid.Clear()
		txtCustnm.Clear()
		txtremark.Clear()
		txtcomp.Clear()
		txtnamerep.Clear()
		txtrepairdone.Clear()
		txttotalamt.Clear()
		DataGridView1.Rows.Clear()

	End Sub
	Public Function CheckJobIDPresent(jobid As Double) As Boolean

		CheckJobIDPresent = False
		Dim ds As New DataSet
		Dim sql As String

		sql = "Select ID from job_services Where ID=" & jobid
		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Function
		End If

		SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
		SQLAdapter.SelectCommand.ExecuteNonQuery()

		SQLAdapter.Fill(ds, "job_services_table")
		'MsgBox((ds.Tables(0).Rows.Count))
		If (ds.Tables(0).Rows.Count) = 0 Then
			CheckJobIDPresent = False
		Else
			CheckJobIDPresent = True
		End If
		Return CheckJobIDPresent

	End Function

	Private Sub JobRepaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'dpestDate.Value = Format(Now(), "dd-MMM-yyyy")
		LoadCmbStatus()
		RepairerNameAuto()
		txtcomp.Enabled = False
		txtremark.Enabled = False
		txtnamerep.AutoCompleteMode = AutoCompleteMode.Suggest
		txtnamerep.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtnamerep.AutoCompleteCustomSource = DataCollectionRepairerName

		DataGridCellFormatting()
	End Sub
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
			MsgBox(ex.ToString).ToString()


		End Try
	End Sub
	Private Sub DataGridCellFormatting()

		Dim dgvProdnid As New DataGridViewTextBoxColumn()
		dgvProdnid.HeaderText = "ProductId"
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ProductName"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "Serial No."
		Dim dgvcIndt As New DataGridViewTextBoxColumn()
		dgvcIndt.HeaderText = "Repaired Date"
		Dim dgvoutDt As New DataGridViewTextBoxColumn()
		dgvoutDt.HeaderText = "Chargeable Amount"
		Dim dgvRepaire As New DataGridViewTextBoxColumn()
		dgvRepaire.HeaderText = "Repaired By"
		Dim dgvClear As New DataGridViewButtonColumn()
		dgvClear.HeaderText = "Status"
		Dim dgvCheck As New DataGridViewCheckBoxColumn()
		dgvCheck.HeaderText = "Select"

		DataGridView1.Columns.Clear()

		DataGridView1.Columns.Add(dgvCheck)
		DataGridView1.Columns.Add(dgvProdnid)
		DataGridView1.Columns.Add(dgvProdnm)
		DataGridView1.Columns.Add(dgvSerila)
		DataGridView1.Columns.Add(dgvcIndt)
		DataGridView1.Columns.Add(dgvoutDt)
		DataGridView1.Columns.Add(dgvRepaire)
		DataGridView1.Columns.Add(dgvClear)

		DataGridView1.Columns(1).ReadOnly = True
		DataGridView1.Columns(2).ReadOnly = True
		DataGridView1.Columns(3).ReadOnly = True
		DataGridView1.Columns(4).ReadOnly = True
		DataGridView1.Columns(5).ReadOnly = True
		DataGridView1.Columns(6).ReadOnly = True
		DataGridView1.Columns(7).ReadOnly = True


		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

		DataGridView1.AllowUserToAddRows = False
		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

	End Sub


	Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
		Dim sum As Integer = 0
		For i As Integer = 0 To DataGridView1.Rows.Count() - 1
			If String.IsNullOrWhiteSpace(DataGridView1.Rows(i).Cells(5).Value) Then

			Else
				sum = sum + DataGridView1.Rows(i).Cells(5).Value
				txttotalamt.Text = sum
			End If
		Next

	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



		If e.ColumnIndex = 0 Then

			If DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value <> "Delivered" Or DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value <> "Outward" Then
				If String.IsNullOrWhiteSpace(txtnamerep.Text) Then Exit Sub

				Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter

					Dim str = DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value
				If String.IsNullOrWhiteSpace(str) Then
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(6).Value = txtnamerep.Text
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value = Format(CDate(dpdaterep.Value), "dd-MMM-yyyy")
					DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = RepaireGreen

				End If

				chrge = DataGridView1.Rows(e.RowIndex).Cells(5).Value

				If chrge = 0 And DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value <> "Delivered" Then
					chargeAmt.Label2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
					chargeAmt.rowindx = e.RowIndex
					chargeAmt.ShowDialog()

				End If

			Else

			End If
		End If

			If (e.ColumnIndex.ToString() = 7) Then
			If DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value <> "Delivered" Then

				Dim result1 As Integer = MessageBox.Show(" You Really Want To Clear data", "?", MessageBoxButtons.YesNo)
				If result1 = DialogResult.No Then
					Exit Sub
				ElseIf result1 = DialogResult.Yes Then
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(5).Value = "0"
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value = ""
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(6).Value = ""
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False
					DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = NotRepaireLightPink
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).ReadOnly = False
					DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).ReadOnly = False
				Else
					'MsgBox("Product is already Delivered.", vbOKOnly)
				End If


			End If
		End If

		If (DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = True) Then
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(5).ReadOnly = False
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).ReadOnly = False
		Else
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(5).ReadOnly = True
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).ReadOnly = True
		End If
		DataGridView1.Refresh()
	End Sub

	'Validates a string of alpha characters
	Function CheckForAlphaCharacters(ByVal StringToCheck As String)
		For i = 0 To StringToCheck.Length - 1

			If Char.IsLetter(StringToCheck.Chars(i)) Then
				Return False
			End If
		Next

		Return True 'Return true if all elements are characters
	End Function


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim flag As Boolean = False

		If cmbjobst.Text = "Pending" Then
			cmbjobst.Focus()
			cmbjobst.BackColor = WarningBackgound
			MsgBox("Please Chnage Job Status").ToString()
			Exit Sub
		End If

		If CheckForAlphaCharacters(txttotalamt.Text) = False Then
			MsgBox("Please Enter Charge amount in number").ToString()
			txttotalamt.BackColor = WarningBackgound
			txttotalamt.Focus()
			Exit Sub
		End If


		JobDescription = txtrepairdone.Text

		Dim sql As String
		Dim sql2 As String
		Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		OpenDatabaseObject()
		Try


			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(RCnt).Cells(0).Value = True Then
					flag = True
				End If
			Next


			If flag = False Then
				MsgBox("Please Select product").ToString()
				Exit Sub
			End If

			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(RCnt).Cells(0).Value = True Then
					chrge = DataGridView1.Rows(RCnt).Cells(5).Value

					If Date.Parse(DataGridView1.Rows(RCnt).Cells(4).Value) < Date.Parse(JobDate) Then
						MsgBox("Repaired date is before in-date, please update repairing date.")

						Return
					End If


					sql = "update job_services set Job_status='" & cmbjobst.Text & "',RepaireDone_by='" & txtnamerep.Text & "',Repaire_Done='" & txtrepairdone.Text & "',date_repaire='" & DataGridView1.Rows(RCnt).Cells(4).Value & "' where ID = " & txtjobid.Text & ""
					sql2 = "update OtherproductDetails set RepairStatus='" & cmbjobst.Text & "', RepairMan='" & DataGridView1.Rows(RCnt).Cells(6).Value & "',statusRep ='True', ChrageableAmt=" & chrge & ",ProdRepairedDate='" & DataGridView1.Rows(RCnt).Cells(4).Value & "' where ID =" & DataGridView1.Rows(RCnt).Cells(1).Value
					AutoAddRepaireComplete(txtnamerep.Text)
					RepairerNameAuto()
					'MsgBox(sql2)
					dataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
					dataAdptr.UpdateCommand.ExecuteNonQuery()
					dataAdptr.UpdateCommand = New SqlCommand(sql2, SQLConn)
					dataAdptr.UpdateCommand.ExecuteNonQuery()
					display_JOBDetails.Refresh()
				End If
			Next
			MsgBox("Update Sucessfully")


			Dim result1 As Integer = MessageBox.Show("Would you like to send WhatsApp message to customer (Y/N)?", "Job Entry Confirmation.", MessageBoxButtons.YesNo)
			If result1 = DialogResult.No Then

			ElseIf result1 = DialogResult.Yes Then
				SendMessage.textBox1.Text = CustomerMobileNo
				SendMessage.JobStatus = cmbjobst.Text

				SendMessage.ShowDialog()


			End If

			display_JOBDetails.UpdateIndividualRow(txtjobid.Text)
			clearAllTextBox()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Function expiryvalidate(ByVal myDate As Date) As Boolean

		Return Date.Parse(JobDate) < myDate

	End Function

	Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
		If DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value = "Delivered" Or DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value = "Outward" Then
			e.Cancel = True
		End If

		If String.IsNullOrWhiteSpace(txtnamerep.Text) And LoadedValue = False Then
			txtnamerep.Focus()
			txtnamerep.BackColor = NotRepaireLightPink
			MsgBox("Please enter the name of person who carried out Repairing work.", vbOKOnly + vbExclamation).ToString()
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False
			e.Cancel = True
		End If
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If String.IsNullOrWhiteSpace(txtnamerep.Text)  Then
			txtnamerep.Focus()
			txtnamerep.BackColor = WarningBackgound
			MsgBox("Please enter the name of person who carried out Repairing work.", vbOKOnly + vbExclamation).ToString()
			CheckBox1.Checked = False
			Return
		End If


		If CheckBox1.Checked Then

			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(RCnt).Cells(7).Value.ToString.Trim = "Outward" Then
					GoTo InvalidMobileNo
				End If
				If DataGridView1.Rows(RCnt).Cells(7).Value <> "Delivered" Or DataGridView1.Rows(RCnt).Cells(7).Value.ToString.Trim <> "Outward" Then
					Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
					Dim str = DataGridView1.Rows(RCnt).Cells(4).Value
					If String.IsNullOrWhiteSpace(str) Then
						DataGridView1.Rows(RCnt).Cells(0).Value = True
						DataGridView1.Rows(RCnt).Cells(6).Value = txtnamerep.Text
						DataGridView1.Rows(RCnt).Cells(4).Value = Format(CDate(dpdaterep.Value), "dd-MMM-yyyy")
						DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor = RepaireGreen

					End If

					chrge = DataGridView1.Rows(RCnt).Cells(5).Value

					If chrge = 0 And DataGridView1.Rows(RCnt).Cells(7).Value <> "Delivered" Then
						chargeAmt.Label2.Text = DataGridView1.Rows(RCnt).Cells(2).Value
						chargeAmt.rowindx = RCnt
						chargeAmt.ShowDialog()

					End If

				Else


				End If
InvalidMobileNo:
			Next
		Else

			For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(RCnt).Cells(7).Value = "Delivered" Then
					GoTo NextValue
				End If

				If DataGridView1.Rows(RCnt).Cells(7).Value = "Outward" Then
					GoTo NextValue
				End If
				If DataGridView1.Rows(RCnt).Cells(7).Value <> "Delivered" Or DataGridView1.Rows(RCnt).Cells(7).Value <> "Outward" Then
					DataGridView1.Rows(RCnt).Cells(0).Value = False
					DataGridView1.Rows(RCnt).Cells(6).Value = ""
					DataGridView1.Rows(RCnt).Cells(5).Value = ""
					DataGridView1.Rows(RCnt).Cells(4).Value = ""
					DataGridView1.Rows(RCnt).DefaultCellStyle.BackColor = NotRepaireLightPink
				End If
NextValue:
			Next



		End If



	End Sub

	Private Sub txtnamerep_KeyUp(sender As Object, e As KeyEventArgs) Handles txtnamerep.KeyUp
		txtnamerep.BackColor = WhiteBackgound
	End Sub


	Private Sub txttotalamt_KeyUp(sender As Object, e As KeyEventArgs) Handles txttotalamt.KeyUp
		txttotalamt.BackColor = WhiteBackgound
	End Sub

	Private Sub cmbjobst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjobst.SelectedIndexChanged
		cmbjobst.BackColor = WhiteBackgound
	End Sub
End Class