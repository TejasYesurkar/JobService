
Imports System.Data.SqlClient
Public Class OutSrcProd

	Private Sub OutSrcProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		RepairerNameAuto()

		dataGrid1Load()
		txtservicetyp.Enabled = False
		dpoutdate.Text = Format(CDate(Now()), "yyyy-MM-dd")

		txtcustNm.ReadOnly = False
		txtprblmdesc.ReadOnly = False

		txtcustNm.AutoCompleteMode = AutoCompleteMode.Suggest
		txtcustNm.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtcustNm.AutoCompleteCustomSource = DataCollection

		txtrepairMan.AutoCompleteMode = AutoCompleteMode.Suggest
		txtrepairMan.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtrepairMan.AutoCompleteCustomSource = DataCollectionRepairerName
		ClearTextBox()
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnfetch.Click

		FetchData()
	End Sub

	Public Sub FetchData()
		If String.IsNullOrWhiteSpace(txtjobid.Text) = True Then Exit Sub

		If CheckJobIDPresent(txtjobid.Text) = False Then
			MsgBox("Job Id Not Found").ToString()
			txtjobid.SelectionStart = 0
			txtjobid.SelectionLength = txtjobid.Text.Length
			txtjobid.Focus()
			ClearTextBox()
			'	clearAllTextBox()
		Else

			datagridLoad()

			LoadValues(txtjobid.Text)
			Exit Sub
		End If

	End Sub

	Sub datagridLoad()
		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
		Dim ds1 As New DataSet
		Dim sql As String

		Dim Flag As Boolean
		DataGridView1.Rows.Clear()


		OpenDatabaseObject()


		sql = "Select ProductName,SerialNo,RepairMan,RepairStatus,ProdOutSrcDate,ID,ProdINSrcDate,OutDate,Outward from OtherproductDetails where Jobid =" & txtjobid.Text & ""
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


				DataGridView1.Rows.Add(Flag, OutPrdoID, ProdName, SerialNo, OutSrcDate, InSrcDate)

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


	Private Sub LoadValues(jobid As Double)
		'MsgBox(jobid & " will be opened for Job  Done").ToString()
		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
		Dim ds2 As New DataSet
		Dim sql As String
		Dim sql2 As String

		'Dim i As Integer

		display_JOBDetails.Hide()

		sql = String.Empty
		OpenDatabaseObject()

		sql = "SELECT ID,cust_name ,service_type,prblm_comp,RepaireDone_by,Estimate_value  
			FROM job_services  where ID =" & jobid
		sql2 = "SELECT estimated_value,OutProduRemark FROM OutSrcProductDetails where Jobid=" & jobid
		'MsgBox(sql2)
		txtjobid.Text = jobid

		Try
			sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.Fill(ds)

			sqldbAdapter = New SqlClient.SqlDataAdapter(sql2, SQLConn)
			sqldbAdapter.Fill(ds2)

			With ds.Tables(0)
				txtcustNm.Text = .Rows(0).Item(.Columns.IndexOf("cust_name"))
				txtprblmdesc.Text = .Rows(0).Item(.Columns.IndexOf("prblm_comp"))
				txtservicetyp.Text = .Rows(0).Item(.Columns.IndexOf("service_type"))
				txtrepairMan.Text = .Rows(0).Item(.Columns.IndexOf("RepaireDone_by"))
				txtestmatevalue.Text = .Rows(0).Item(.Columns.IndexOf("Estimate_value"))

			End With

			'MsgBox(ds2.Tables.Count)
			If String.IsNullOrWhiteSpace(ds2.Tables(0).Rows(0).Item("OutProduRemark").ToString) Then
				txtoutremark.Text = ds2.Tables(0).Rows(0).Item("OutProduRemark")
			End If

		Catch ex As Exception
			'MsgBox(ex.ToString).ToString()
		End Try

	End Sub



	Private Sub dataGrid1Load()
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ProductName"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "SerialNo."
		Dim dgvcIndt As New DataGridViewTextBoxColumn()
		dgvcIndt.HeaderText = "InDate"
		Dim dgvoutDt As New DataGridViewTextBoxColumn()
		dgvoutDt.HeaderText = "OutDate"
		Dim dgvoutID As New DataGridViewTextBoxColumn()
		dgvoutID.HeaderText = "OutProductID"
		Dim dgvCheck As New DataGridViewCheckBoxColumn()
		dgvCheck.HeaderText = "CheckBox"

		DataGridView1.Columns.Add(dgvCheck)
		DataGridView1.Columns.Add(dgvoutID)
		DataGridView1.Columns.Add(dgvProdnm)
		DataGridView1.Columns.Add(dgvSerila)
		DataGridView1.Columns.Add(dgvoutDt)
		DataGridView1.Columns.Add(dgvcIndt)

		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView1.AllowUserToAddRows = False

		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim OutsrcStatus As String
		For aa = 0 To DataGridView1.Rows.Count - 1
			Dim Strst = DataGridView1.Rows(aa).Cells(0).Value
			Dim estmVal As Int16
			If Strst = "True" Then
				OutsrcStatus = "Pending"
				If String.IsNullOrWhiteSpace(txtrepairMan.Text) Then
					MsgBox("Please Enter RepairMan Name..!!").ToString()
					txtrepairMan.Focus()
					txtrepairMan.BackColor = WarningBackgound
					Exit Sub
				End If

				If String.IsNullOrWhiteSpace(txtestmatevalue.Text) Then
					estmVal = 0
				Else
					estmVal = txtestmatevalue.Text
				End If
				Dim InProdID = DataGridView1.Rows(aa).Cells(1).Value
				Dim ProdName = DataGridView1.Rows(aa).Cells(2).Value
				Dim SerialNo = DataGridView1.Rows(aa).Cells(3).Value

				Dim Sql = "INSERT INTO OutSrcProductDetails (OutDate,Jobid,ProductName,SerialNo,OutPersonName,OutProduRemark,InID,estimated_value,RetrunStatus,RepaireName)
                           VALUES('" & Format(CDate(Now()), "yyyy-MM-dd") & "'," & txtjobid.Text & ",'" & ProdName & "','" & SerialNo & "','" & session & "','" & txtoutremark.Text & "','" & InProdID & "','" & estmVal & "','Pending','" & txtrepairMan.Text & "')"

				Dim Sql2 = "update OtherproductDetails Set RepairMan='" & txtrepairMan.Text & "',RepairStatus='" & OutsrcStatus & "',ProdOutSrcDate='" & Format(CDate(Now()), "yyyy-MM-dd") & "',Outward='True' where ProductName = '" & ProdName & "' And Jobid = '" & txtjobid.Text & "'"
				Dim comm As New SqlClient.SqlCommand(Sql, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()

				comm = New SqlClient.SqlCommand(Sql2, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			Else
			End If
		Next
		MsgBox("OutWard Details Add Sucessfully!! ").ToString()
		ClearTextBox()

	End Sub
	Private Sub ClearTextBox()
		txtjobid.Clear()
		txtcustNm.Clear()
		txtestmatevalue.Clear()
		txtoutremark.Clear()
		txtprblmdesc.Clear()
		txtrepairMan.Clear()
		txtservicetyp.Clear()

		DataGridView1.Rows.Clear()


	End Sub


	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		If e.ColumnIndex = 0 Then
			DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value = Format(CDate(dpoutdate.Text), "yyyy-MMM-dd")
		End If

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		ClearTextBox()
		'Login.Show()
	End Sub

	Private Sub txtjobid_TextChanged(sender As Object, e As EventArgs) Handles txtjobid.TextChanged

	End Sub

	Private Sub txtjobid_LostFocus(sender As Object, e As EventArgs) Handles txtjobid.LostFocus
		If String.IsNullOrWhiteSpace(txtjobid.Text) Then btnfetch.TabStop = False Else btnfetch.TabStop = True
	End Sub

	Private Sub txtrepairMan_KeyUp(sender As Object, e As KeyEventArgs) Handles txtrepairMan.KeyUp
		txtrepairMan.BackColor = WhiteBackgound
	End Sub
End Class