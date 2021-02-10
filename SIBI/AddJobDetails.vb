Imports System.Data.SqlClient

Public Class AddJobDetails
	Public colInx
	Public rowInx
	Public customer_ID As Integer
	Public LoadPreviousValues As Boolean
	Public LoadForView As Boolean
	Public LoadValueFromJobID As Double
	Dim table As New DataTable("Table")
	Dim LastCreatedJobID As Double
	Dim LastCreatedProductsCount As Double
	Public ModificationState As Boolean = False


	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PrblmDescAutoComplete()
		AutoCompleteCompnyName()
		AutoProdComplete()
		GroupBox3.Hide()

		txtjobid.Enabled = True
		dpjobdate.Value = Format(CDate(Now()), "yyyy-MM-dd")
		dpestdate.Value = Format(CDate(Now()), "yyyy-MM-dd")
		dpamc.Value = Format(CDate(Now()), "yyyy-MM-dd")
		DataGridView1.ReadOnly = True

		LoadServiceType()
		LoadCmbStatus()

		jobidchk.Checked = False
		txtjobid.Enabled = False
		LoadProductGridView()
		txtcomp.AutoCompleteMode = AutoCompleteMode.Suggest
		txtcomp.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtcomp.AutoCompleteCustomSource = DataCollectionForProblmDesc

		txtcustname.AutoCompleteMode = AutoCompleteMode.Suggest
		txtcustname.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtcustname.AutoCompleteCustomSource = DataCollection

		txtcmpnynm.AutoCompleteMode = AutoCompleteMode.Suggest
		txtcmpnynm.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtcmpnynm.AutoCompleteCustomSource = DataCollectioncmpyName

		txtAccessoies.AutoCompleteMode = AutoCompleteMode.Suggest
		txtAccessoies.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtAccessoies.AutoCompleteCustomSource = DataCollectionForProdName

		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

		Dim dvgprod As New DataGridViewTextBoxColumn()
		dvgprod.HeaderText = "ProductName"
		Dim dvgserail As New DataGridViewTextBoxColumn()
		dvgserail.HeaderText = "SerialNo"


		'DataGridView2.AutoSizeColumnsMode = True
		'DataGridView2.AllowUserToAddRows = False
		DataGridView2.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView2.ReadOnly = True


		If String.IsNullOrWhiteSpace(txtjobid.Text) Then
			DataGridView2.Visible = False
		Else
			DataGridView2.Visible = True
		End If

		If LoadPreviousValues = True Then
			loadvalues(LoadValueFromJobID)
			customer_view.UpdatevIEW = True
			DataGridView2.Visible = True
		Else
			customer_view.UpdatevIEW = False
		End If


	End Sub

	Private Sub CheckJobid()
		Dim Sql As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim count As Integer = 0
		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If
		Sql = "Select max(id) from job_services "
		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(Sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "Customer_reg")
			Dim tmp = ds.Tables(0).Rows(0).Item(0)
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub


	Private Sub LoadProductGridView()
		If DataGridView1.Rows.Count > 0 Then
			DataGridView1.Rows.Clear()
		End If
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ProductName"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "SerialNo."
		DataGridView1.Columns.Add(dgvProdnm)
		DataGridView1.Columns.Add(dgvSerila)
		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView1.AllowUserToAddRows = False
	End Sub

	Private Sub LoadServiceType()
		cmbservicetyp.Items.Add("Paid")
		cmbservicetyp.Items.Add("AMC")
		cmbservicetyp.Items.Add("Warranty")
		cmbservicetyp.Text = "Paid"
	End Sub

	Sub LoadCmbStatus()

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds2 As New DataSet
		Dim sql2 As String
		'  Dim i As Integer
		sql2 = "Select status from Status "
		Try
			OpenDatabaseObject()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql2, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds2, "JobStatus2")
			SQLAdapter.Dispose()

			For i = 0 To ds2.Tables(0).Rows.Count - 1
				' MsgBox(ds.Tables(0).Rows(i).Item(0))
				cmbjobstatus.Items.Add(ds2.Tables(0).Rows(i).Item(0))
			Next
			cmbjobstatus.Text = "Pending"
			cmbjobstatus.Enabled = False
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub



	Private Sub cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs)
		If cmbservicetyp.Text = "Paid" Then
			dpamc.Text = String.Empty
			dpamc.Enabled = False
		Else
			dpamc.Enabled = True
		End If
	End Sub

	Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
		SaveJOb()

	End Sub

	Private Sub SaveJOb()
		If CheckValidation() = False Then Exit Sub
		Dim result1 As Integer = MessageBox.Show("Would you like to create this Job (Y/N)?", "Job Entry Confirmation.", MessageBoxButtons.YesNo)
		If result1 = DialogResult.No Then
			Exit Sub
		ElseIf result1 = DialogResult.Yes Then

		End If

		btnsave.Enabled = False
		If SaveNewJobDetails() = True Then
			AddAutoCompletePrblmdesc()
			AutoAddCompnyNameComplete()
			AddAutoCompleteProduct()
			AutoProdComplete()
			ClearData()
			MsgBox("Your Job ID " + LastCreatedJobID.ToString + " Added Sucessufully !! ").ToString()
			Dim result As Integer = MessageBox.Show("Would you like to Print Barcode Label?", "Barcode Print Message", MessageBoxButtons.YesNo)
			If result = DialogResult.No Then
			ElseIf result = DialogResult.Yes Then
				If Application.OpenForms().OfType(Of BarcodePrint).Any Then
					BarcodePrint.Close()
				End If

				BarcodePrint.txtjobid.Text = LastCreatedJobID
				BarcodePrint.txtqty.Text = LastCreatedProductsCount


				BarcodePrint.ShowDialog()
			End If
		End If

		jobidchk.Checked = False
		txtjobid.Focus()
		btnsave.Enabled = True
	End Sub

	Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnshow.Click
		display_JOBDetails.Show()
		display_JOBDetails.WindowState = FormWindowState.Maximized
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
		btnsave.Enabled = True

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
			cmbservicetyp.Text = ds.Tables(0).Rows(0).Item(columnName:="service_type")
			dpamc.Value = CDate(ds.Tables(0).Rows(0).Item(columnName:="warranty"))
			txtcomp.Text = ds.Tables(0).Rows(0).Item(columnName:="prblm_comp")
			txtobserv.Text = ds.Tables(0).Rows(0).Item(columnName:="prblm_observe")
			txtestval.Text = ds.Tables(0).Rows(0).Item(columnName:="Estimate_value")
			txtprejobid.Text = perviuosJobid
			cmbjobstatus.Text = ds.Tables(0).Rows(0).Item(columnName:="Job_status")
			txtdilverystatus.Text = ds.Tables(0).Rows(0).Item(columnName:="job_delivery")
			dpestdate.Value = CDate(ds.Tables(0).Rows(0).Item(columnName:="Estimate_date"))
			txtrmrk.Text = ds.Tables(0).Rows(0).Item(columnName:="Remark")

			If ds.Tables(0).Rows(0).Item(columnName:="job_delivery") = "Delivered" Then
				Dim Str = "Product is Delivered on " & Format(ds.Tables(0).Rows(0).Item(columnName:="job_delivery_date"), "dd-MMM-yyyy")
				deliveryLable.Text = Str
				deliveryLable.Visible = True
				btnadditem.Enabled = False
				txtAccessoies.Enabled = False
				txtserialaccess.Enabled = False

				DataGridView1.Visible = False
				btnremove.Enabled = False
				btnshow.Enabled = False
				btnremove.Visible = False
				btnshow.Visible = False
				DataGridView2.Width = 365
				DataGridView2.Height = 227
				DataGridView2.Left = 524
				DataGridView2.Top = 45
				DataGridView2.Visible = True
			Else
				deliveryLable.Text = " "
				deliveryLable.Visible = False
				btnremove.Enabled = True
				btnshow.Enabled = False
				btnremove.Visible = True
				btnadditem.Enabled = True
				txtAccessoies.Enabled = True
				txtserialaccess.Enabled = True
				DataGridView2.Visible = True

				DataGridView2.Width = 272
				DataGridView2.Height = 256
				DataGridView2.Left = 661
				DataGridView2.Top = 323


			End If

			datagridLoad()
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()


		End Try

		UpdateForViewMode()

	End Sub


	Sub datagridLoad()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()


		sql = "Select ID,ProductName,SerialNo,OutDate from OtherproductDetails where Jobid =" & txtjobid.Text & ""

		Try



			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			'DataGridView2.DataSource = ds
			'DataGridView2.DataMember = "customer_reg"
			Dim RecordCount As Double = ds.Tables(0).Rows.Count
			If RecordCount > 0 Then

				DataGridView2.Columns.Clear()
				DataGridView2.Rows.Clear()

				Dim dvgid As New DataGridViewTextBoxColumn()
				dvgid.HeaderText = "ID"
				Dim dgvProdnm As New DataGridViewTextBoxColumn()
				dgvProdnm.HeaderText = "ProductName"
				Dim dgvSerila As New DataGridViewTextBoxColumn()
				dgvSerila.HeaderText = "SerialNo"


				DataGridView2.Columns.Add(dvgid)
				DataGridView2.Columns.Add(dgvProdnm)
				DataGridView2.Columns.Add(dgvSerila)
				DataGridView2.Columns(0).Visible = False

				If (txtdilverystatus.Text = "Delivered") = False Then
					Dim dgvClear As New DataGridViewButtonColumn()
					dgvClear.HeaderText = "Action"
					DataGridView2.Columns.Add(dgvClear)
				End If
				For i = 0 To RecordCount - 1
					Dim OutDate = ds.Tables(0).Rows(i).Item(3)


					If txtdilverystatus.Text = "Delivered" And IsDBNull(ds.Tables(0).Rows(i).Item(3)) = False Then
						DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2))
					Else

						If LoadForView = True Then
							DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), "View Only")

						ElseIf IsDBNull(OutDate) = False Then
							DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), "Delivered")
						Else
							DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), "Change")
						End If
					End If


				Next

			End If

				Dim str = "ds"

			SQLAdapter.Dispose()
			CloseDatabaseObject()

			LoadPreviousValues = False

		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()


		End Try


	End Sub


	Private Sub UpdateForViewMode()
		btnsave.Enabled = False
		btnclear.Enabled = False
		'dpjobdate.Enabled = False
		txtjobid.ReadOnly = True
		'txtserialaccess.Enabled = False
		'txtAccessoies.Enabled = False
		'	cmbjobstatus.Enabled = False
	End Sub



	Private Sub btnsaveupdate_Click(sender As Object, e As EventArgs) Handles btnsaveupdate.Click

		If String.IsNullOrWhiteSpace(deliveryLable.Text) Then

		Else
			Dim result As Integer = MessageBox.Show("Would you like to Update : " & txtjobid.Text, "", MessageBoxButtons.YesNo)

			If result = DialogResult.No Then
				Exit Sub
			ElseIf result = DialogResult.Yes Then


			End If
		End If

		If txtdilverystatus.Text = "Delivered" Then
			'	MsgBox("Product Is Deliver.! Update Not Possible".ToString).ToString()
			'	Exit Sub

		End If

		Dim ds As New DataSet
		Dim sql As String
		Dim NewAddForm As New display_JOBDetails
		sql = "update job_services set mobile='" & txtmob.Text & "',job_date='" & Format(CDate(dpjobdate.Text), "yyyy-MM-dd") & "',cust_name='" & txtcustname.Text & "',product_service='" & txtprodrep.Text & "',service_type='" & cmbservicetyp.Text & "',prblm_comp='" & txtcomp.Text & "',prblm_observe='" & txtobserv.Text & "',Estimate_value=" & txtestval.Text & ", Estimate_date='" & Format(CDate(dpestdate.Text), "yyyy-MM-dd") & "', Job_status='" & cmbjobstatus.Text & "', Remark='" & txtrmrk.Text & "', modify_user_name='" & session & "' , date_of_modify='" & Format(CDate(Now()), "yyyy-MM-dd") & "',company_name='" & txtcmpnynm.Text & "',perviuosJobid='" & txtprejobid.Text & "' where ID = " & txtjobid.Text & ""
		'MsgBox(sql)
		Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			OpenDatabaseObject()
			dataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
			dataAdptr.UpdateCommand.ExecuteNonQuery()

			UpdateProdList()

			MsgBox("Row(s) updated !! ").ToString()
			ClearData()
			display_JOBDetails.Updated = True
			display_JOBDetails.UpdateIndividualRow(txtjobid.Text)
			'MsgBox(display_JOBDetails.DataGridView1.Rows(0).Cells(0).Value)

			btnclose.PerformClick()




		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub UpdateProdList()
		Dim prodnm As String
		Dim prodserial As String
		Dim jobid As Int16 = txtjobid.Text
		Dim Qy_JobDetails As String
		OpenDatabaseObject()
		For i As Integer = 0 To DataGridView1.Rows.Count - 1

			prodnm = DataGridView1.Rows(i).Cells(0).Value
			prodserial = DataGridView1.Rows(i).Cells(1).Value


			Qy_JobDetails = "INSERT INTO OtherproductDetails (Jobid,ProductName,SerialNo,InDate)
					VALUES(" & jobid.ToString.Trim & ",'" & prodnm.ToString.Trim & "','" & prodserial.ToString.Trim & "','" & Format(CDate(Now()), "yyyy-MM-dd") & "')"


			Dim comm As New SqlClient.SqlCommand(Qy_JobDetails, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()

		Next
	End Sub

	Private Sub crm_Click(sender As Object, e As EventArgs) Handles crm.Click
		customer_view.Close()
		If String.IsNullOrWhiteSpace(txtmob.Text) Then
			customer_view.EnableAutoClick = True
			'customer_view.btncust_update.Enabled = False
			'customer_view.btnshow.Enabled = False
			customer_view.handlerID = Me.Handle
			customer_view.Active = False
			customer_view.WhatsAppVIEW = False
			customer_view.ShowDialog()
			Exit Sub
		End If

		If txtmob.Text.Length > 10 Or txtmob.Text.Length < 10 Then
			MsgBox("Please Enter Valid Number.!!")
			Exit Sub
		End If

		If checkCustomerPresent() = False Then
			Exit Sub
		End If
		AddCustomerDetails.btncust_update.Visible = False

		If String.IsNullOrWhiteSpace(txtmob.Text) = False Then
			customer_view.txtsrchstr.Text = txtmob.Text
		End If
		customer_view.EnableAutoClick = True
		customer_view.btncust_update.Enabled = False
		customer_view.btnshow.Enabled = False
		customer_view.handlerID = Me.Handle
		customer_view.Active = False
		'customer_view.ShowDialog()

	End Sub
	Private Function checkCustomerPresent() As Boolean
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0
		'  Dim i As Integer

		OpenDatabaseObject()
		sql = "Select * from Customer_reg where cust_mobile ='" & txtmob.Text & "'"
		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()

			SQLAdapter.Fill(ds, "Customer_reg")

			For i = 0 To ds.Tables(0).Rows.Count - 1
				'txtmob.Text = ds.Tables(0).Rows(i).Item("cust_mobile")
				'txtcustname.Text = ds.Tables(0).Rows(i).Item("cust_name")
				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("cust_mobile").ToString) Then
					txtmob.Text = ""
				Else
					txtmob.Text = ds.Tables(0).Rows(i).Item("cust_mobile").ToString
				End If


				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("cust_name").ToString) Then
					txtcustname.Text = ""
				Else
					txtcustname.Text = ds.Tables(0).Rows(i).Item("cust_name").ToString
					txtcustname.BackColor = WhiteBackgound
				End If


				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("cust_id").ToString) Then
					txtcust_id.Text = ""
				Else
					txtcust_id.Text = ds.Tables(0).Rows(i).Item("cust_id").ToString
				End If
				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("CompanyName").ToString) Or IsDBNull(ds.Tables(0).Rows(i).Item("CompanyName").ToString) Then
					txtcmpnynm.Text = ""
				Else
					txtcmpnynm.Text = ds.Tables(0).Rows(i).Item("CompanyName").ToString
				End If

			Next
			count = ds.Tables(0).Rows.Count
			If count > 0 Then
				Return True
			Else
				Dim result As Integer = MessageBox.Show("Do You Want Add Customer Details.", "?", MessageBoxButtons.YesNo)
				If result = DialogResult.No Then


				ElseIf result = DialogResult.Yes Then
					AddCustomerDetails.txtmobp.Text = txtmob.Text

					AddCustomerDetails.Show()
					AddCustomerDetails.btncust_update.Visible = False
				End If

				Return False

			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()


		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
			Return False
		End Try
	End Function
	Private Sub cmbjobstatus_SelectedIndexChanged(sender As Object, e As EventArgs)
		' cmbjobstatus.Items.Clear()

	End Sub

	Private Function CheckValidation() As Boolean
		CheckValidation = False
		If jobidchk.Checked = True And (IsNumeric(txtjobid.Text) = False Or Val((txtjobid.Text)) = 0) Then
			MsgBox("Invalid Job ID Entered. Please enter a Numeric Value").ToString()
			txtjobid.Focus()
			txtjobid.BackColor = WarningBackgound
			Exit Function
		End If
		If String.IsNullOrWhiteSpace(txtcust_id.Text) Then
			MsgBox("Please Add Customer.!!").ToString()
			txtcust_id.Focus()
			txtcustname.BackColor = WarningBackgound
			Exit Function
		End If

		If Len(Trim(txtcustname.Text)) = 0 Then
			MsgBox("Please Enter Customer Name.", vbOKOnly + vbExclamation).ToString()
			txtcustname.Focus()
			txtcustname.BackColor = WarningBackgound
			Exit Function
		ElseIf Len(Trim(txtcomp.Text)) = 0 Then
			MsgBox("Please Enter Problems Reported by Customer.", vbOKOnly + vbExclamation).ToString()
			txtcomp.Focus()
			txtcomp.BackColor = WarningBackgound
			Exit Function
		ElseIf Len(Trim(txtmob.Text)) > 0 Then
			If IsNumeric(Trim(txtmob.Text)) = True Then
				If Len(Trim(txtmob.Text)) <> 10 Then
					If Len(Trim(txtmob.Text)) <> 7 Then
InvalidMobileNo:
						MsgBox("Please Enter Mobile No.", vbOKOnly + vbExclamation).ToString()
						txtmob.Focus()
						txtmob.BackColor = WarningBackgound
						Exit Function
					End If
				End If
			Else
				GoTo InvalidMobileNo
			End If

		End If

		CheckValidation = True

	End Function
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadditem.Click
		Try
			If String.IsNullOrWhiteSpace(txtAccessoies.Text) Then
				MsgBox("Please Enter ProductName...".ToString).ToString()
				txtAccessoies.Focus()
				txtAccessoies.BackColor = WarningBackgound

			Else
				DataGridView1.Rows.Add(txtAccessoies.Text, txtserialaccess.Text)
				txtAccessoies.Focus()
			End If
			'table.Rows.Add(txtAccessoies.Text, txtserialaccess.Text)
			txtserialaccess.Clear()
			txtAccessoies.Clear()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnremove.Click
		If (DataGridView1.Rows.Count) = 0 Then Exit Sub
		For Each row As DataGridViewRow In DataGridView1.SelectedRows
			DataGridView1.Rows.Remove(row)
		Next
		'  DataGridView1.Rows.RemoveAt(Rowindex)
	End Sub

	Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
		DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
	End Sub

	Private Sub jobidchk_CheckedChanged(sender As Object, e As EventArgs) Handles jobidchk.CheckedChanged
		If jobidchk.Checked = True Then
			txtjobid.Enabled = True
		Else
			txtjobid.Enabled = False
		End If
	End Sub

	Private Function SaveNewJobDetails() As Boolean

		SaveNewJobDetails = False
		CloseDatabaseObject()
		Dim job_date As Date = dpjobdate.Value
		Dim cust_name As String = Trim(txtcustname.Text)
		Dim mobile As String = Trim(txtmob.Text)
		Dim prod_repair As String = Trim(txtprodrep.Text)
		' Dim serialprod As String = Trim(txtserialprod.Text)
		Dim serives_type As String = Trim(cmbservicetyp.Text)
		Dim warranty As String = CDate(dpamc.Text)
		Dim prblm_comp As String = Trim(txtcomp.Text)
		Dim prblm_observe As String = Trim(txtobserv.Text)
		Dim Estmiated_value As Double = Val(txtestval.Text)
		Dim Estmiated_date As Date = CDate(dpestdate.Text)
		Dim cust_id As String = Trim(txtcust_id.Text)
		Dim job_status As String = Trim(cmbjobstatus.Text)
		Dim remrk As String = Trim(txtrmrk.Text)
		Dim cmpny As String = Trim(txtcmpnynm.Text)
		Dim previousJobid As String = Trim(txtprejobid.Text)
		'   Dim datee As String = CDate(dptp.Text)
		Dim prodnm As String
		Dim prodserial As String
		Dim jobid As Double
		AutoAddComplete(cust_name)
		AutoAddCompnyNameComplete(cmpny)
		AutoComplete()
		AutoCompleteCompnyName()

		OpenDatabaseObject()
		For i As Integer = 0 To DataGridView1.Rows.Count - 1
			prodnm = DataGridView1.Rows(i).Cells(0).Value
			AddAutoCompleteProduct(prodnm)
			AutoProdComplete()
		Next

		If String.IsNullOrWhiteSpace(previousJobid) Then
			previousJobid = vbNull
		Else
			If CheckPresviousJobIDPresent(previousJobid) = True Then
				MsgBox("This Previous JOBID is already Present.!!").ToString()
				Exit Function
			Else
				previousJobid = txtprejobid.Text
			End If
		End If

		If jobidchk.Checked = True Then
			If CheckJobIDPresent(txtjobid.Text) = True Then
				MsgBox("This JOBID is already Present.!!").ToString()
				Exit Function
			Else
				jobid = txtjobid.Text
			End If
		Else
			txtjobid.Text = Val(GetJobID())
			jobid = txtjobid.Text
		End If

		If Len(txtjobid.Text) = 0 Then
			MsgBox("Enter Job ID.").ToString()
			Exit Function
		End If
		Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			If DataGridView1.RowCount = 0 Then
				'	If prodnm = "" Then
				MsgBox("Please Add Product in List.").ToString()

				txtAccessoies.Focus()
				txtAccessoies.BackColor = WarningBackgound
				Exit Function
				'	End If
			End If
			' Begin the transaction.

			Dim trans As SqlTransaction = SQLConn.BeginTransaction(IsolationLevel.ReadCommitted)
			Try

				Dim dilveryStatus As String = "UnDelivered"
				Dim Qy_Job = "INSERT INTO job_services (ID,mobile,job_date,cust_name,product_service,service_type,warranty,prblm_comp,prblm_observe,Estimate_value, Estimate_date, Job_status,Remark,name_of_user,date_of_entry,company_name,job_delivery,perviuosJobid,customerid)
                               VALUES(" & jobid.ToString.Trim & ",'" & mobile.ToString.Trim & "','" & Format(CDate(job_date), "yyyy-MM-dd") & "','" & cust_name.ToString.Trim & "','" & txtprodrep.Text.ToString.Trim & "','" & serives_type.ToString.Trim & "','" & warranty & "','" & prblm_comp.ToString.Trim & "','" & prblm_observe.ToString.Trim & "'," & Estmiated_value.ToString.Trim & ",'" & Format(CDate(Estmiated_date), "yyyy-MM-dd") & "','" & job_status.ToString.Trim & "','" & remrk.ToString.Trim & "','" & session & "','" & Format(CDate(Now()), "yyyy-MM-dd") & "','" & cmpny.ToString.Trim & "','" & dilveryStatus.ToString.Trim & "'," & previousJobid.ToString.Trim & "," & cust_id & ")"
				Dim Qy_JobDetails As String
				Dim cmd_Job As New SqlCommand(Qy_Job, SQLConn, trans)
				cmd_Job.ExecuteNonQuery()

				LastCreatedProductsCount = DataGridView1.Rows.Count
				For i As Integer = 0 To DataGridView1.Rows.Count - 1

					prodnm = DataGridView1.Rows(i).Cells(0).Value
					prodserial = DataGridView1.Rows(i).Cells(1).Value

					'If prodnm = "" And prodserial = "" Then
					Qy_JobDetails = "INSERT INTO OtherproductDetails (Jobid,ProductName,SerialNo,InDate,RepairStatus,statusRep)
					VALUES(" & jobid.ToString.Trim & ",'" & prodnm.ToString.Trim & "','" & prodserial.ToString.Trim & "','" & Format(CDate(Now()), "yyyy-MM-dd") & "','Pending','False')"
					'MsgBox(SQLConn.State)
					Dim cmd_JobDetails As New SqlCommand(Qy_JobDetails, SQLConn, trans)
					cmd_JobDetails.ExecuteNonQuery()
				Next
				trans.Commit()
				LastCreatedJobID = jobid
				AddAutoCompletePrblmdesc(txtcomp.Text)
				SaveNewJobDetails = True
			Catch ex As Exception
				'trans.Rollback()
				MsgBox(ex.ToString).ToString()
				Exit Function
			End Try
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Function

	Private Sub ClearData()
		'MsgBox("Check clear data function")
		txtcustname.Clear()
		txtcust_id.Clear()
		txtmob.Clear()
		txtprodrep.Clear()
		txtcomp.Clear()
		txtobserv.Clear()
		txtestval.Clear()
		txtprejobid.Clear()
		txtrmrk.Clear()
		txtcmpnynm.Clear()
		txtjobid.Clear()
		txtAccessoies.Clear()
		txtserialaccess.Clear()
		DataGridView1.Rows.Clear()
	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnclear.Click
		Dim result As Integer = MessageBox.Show("Are You Want Really Want To Clear data", "?", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then

		ElseIf result = DialogResult.Yes Then
			ClearData()
		End If
	End Sub


	Private Sub txtAccessoies_LostFocus(sender As Object, e As EventArgs) Handles txtAccessoies.LostFocus
		If String.IsNullOrWhiteSpace(txtAccessoies.Text) Then btnadditem.TabStop = False Else btnadditem.TabStop = True
	End Sub


	Private Sub txtmob_LostFocus(sender As Object, e As EventArgs) Handles txtmob.LostFocus
		If String.IsNullOrWhiteSpace(txtmob.Text) Then crm.TabStop = False Else crm.TabStop = True
	End Sub

	Private Sub txtmob_TextChanged(sender As Object, e As EventArgs) Handles txtmob.TextChanged
		If String.IsNullOrWhiteSpace(txtmob.Text) Then crm.TabStop = False Else crm.TabStop = True
	End Sub

	Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
		Me.Close()
	End Sub

	Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
		If e.ColumnIndex.ToString() = 3 And DataGridView2.Rows(e.RowIndex.ToString()).Cells(3).Value = "Change" Then
			txtprodnm.Text = DataGridView2.Rows(e.RowIndex.ToString()).Cells(1).Value
			txtserialno.Text = DataGridView2.Rows(e.RowIndex.ToString()).Cells(2).Value
			txtprodid.Text = DataGridView2.Rows(e.RowIndex.ToString()).Cells(0).Value
			colInx = e.ColumnIndex
			rowInx = e.RowIndex
			GroupBox3.Show()
		End If
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Dim Sql As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim count As Integer = 0
		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If
		Sql = "Select cust_name,mobile,company_name from job_services where ID=" & txtprejobid.Text
		Try
			SQLAdapter = New SqlClient.SqlDataAdapter(Sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "Customer_reg")
			txtcustname.Text = ds.Tables(0).Rows(0).Item(0)
			txtmob.Text = ds.Tables(0).Rows(0).Item(1)
			txtcmpnynm.Text = ds.Tables(0).Rows(0).Item(2)
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
		GroupBox3.Hide()
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim sql As String
		Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		OpenDatabaseObject()
		Try
			sql = "update OtherproductDetails set ProductName='" & txtprodnm.Text.ToString.Trim & "', SerialNo='" & txtserialno.Text.ToString.Trim & "' where ID =" & txtprodid.Text

			dataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
			dataAdptr.UpdateCommand.ExecuteNonQuery()
			GroupBox3.Hide()
			MsgBox("Updated Successfully").ToString()
			DataGridView2.Rows(rowInx).Cells(1).Value = txtprodnm.Text
			DataGridView2.Rows(rowInx).Cells(2).Value = txtserialno.Text

		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub AddJobDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.Control AndAlso e.KeyCode = Keys.S Then
			SaveJOb()
		End If
	End Sub

	Private Sub txtcomp_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcomp.KeyUp
		txtcomp.BackColor = WhiteBackgound
	End Sub


	Private Sub txtAccessoies_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAccessoies.KeyUp
		txtAccessoies.BackColor = WhiteBackgound
	End Sub
End Class


