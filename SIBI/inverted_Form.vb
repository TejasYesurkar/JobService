Imports System.Data.SqlClient
Public Class inverted_Form
	Private ReadOnly dgvoutid As String

	Private Sub inverted_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridFormatLoad()
		datagridDataLoad2()

		cmbjobst.Items.Clear()
		cmbjobst.Items.Add("All")
		cmbjobst.Items.Add("Pending")
		cmbjobst.Items.Add("Repaired")
		cmbjobst.Items.Add("UnRepaired")
		cmbjobst.Text = "Pending"
		cmbfilter.Items.Clear()
		cmbfilter.Items.Add("")
		cmbfilter.Items.Add("JobID")
		cmbfilter.Items.Add("RepaireName")
		cmbjobst.Items.Add("")
		BuildQuery()
		btnfetch.PerformClick()
	End Sub

	Private Sub DataGridFormatLoad()

		Dim dgvjobid As New DataGridViewTextBoxColumn()
		dgvjobid.HeaderText = "JobID"
		Dim dgvoutid As New DataGridViewTextBoxColumn()
		dgvoutid.HeaderText = "OutID"
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ProductName"
		Dim dgvSerila As New DataGridViewTextBoxColumn()
		dgvSerila.HeaderText = "SerialNo."
		Dim dgvOutrmk As New DataGridViewTextBoxColumn()
		dgvOutrmk.HeaderText = "OutRemark"
		Dim devgoutDate As New DataGridViewTextBoxColumn()
		devgoutDate.HeaderText = "Out Date"
		Dim dgvStatus As New DataGridViewTextBoxColumn()
		dgvStatus.HeaderText = "Status"

		Dim dvgchng As New DataGridViewButtonColumn()
		dvgchng.HeaderText = "Action"

		Dim devgInDate As New DataGridViewTextBoxColumn()
		devgInDate.HeaderText = "In Date"

		Dim dgvCheck As New DataGridViewCheckBoxColumn()
		dgvCheck.HeaderText = "Check Box"

		DataGridView2.Columns.Add(dgvCheck)
		DataGridView2.Columns.Add(dgvjobid)
		DataGridView2.Columns.Add(dgvoutid)
		DataGridView2.Columns.Add(dgvProdnm)
		DataGridView2.Columns.Add(devgoutDate)
		DataGridView2.Columns.Add(devgInDate)
		DataGridView2.Columns.Add(dgvSerila)
		DataGridView2.Columns.Add(dgvOutrmk)
		DataGridView2.Columns.Add(dgvStatus)
		DataGridView2.Columns.Add(dvgchng)

		dgvCheck.Visible = False
		dgvOutrmk.Width = 300
		'	DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView2.AllowUserToAddRows = False
		DataGridView2.ReadOnly = True
		DataGridView2.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)


	End Sub
	Sub datagridDataLoad2()
		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		Dim Flag As Boolean
		DataGridView2.Rows.Clear()


		OpenDatabaseObject()

		If (String.IsNullOrWhiteSpace(BuildQuery())) Then
			sql = "Select ProductName,SerialNo,OutProduRemark,RetrunStatus,Jobid,InID,OutDate,Retrun from OutSrcProductDetails "
		Else
			sql = "Select ProductName,SerialNo,OutProduRemark,RetrunStatus,Jobid,InID,OutDate,Retrun from OutSrcProductDetails " & BuildQuery()

		End If


		Try
			'connection.Open()
			sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.SelectCommand.ExecuteNonQuery()
			sqldbAdapter.Fill(ds)
			sqldbAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim ProdName = ds.Tables(0).Rows(i).Item(0)
				Dim SerialNo = ds.Tables(0).Rows(i).Item(1)
				Dim OutProduRemark = ds.Tables(0).Rows(i).Item(2)
				Dim status = ds.Tables(0).Rows(i).Item(3)
				Dim jobID = ds.Tables(0).Rows(i).Item(4)
				Dim InID = ds.Tables(0).Rows(i).Item(5)
				Dim OutDate = ds.Tables(0).Rows(i).Item(6)
				Dim InDate = ds.Tables(0).Rows(i).Item(7)
				Dim action



				Dim outStatus = ds.Tables(0).Rows(i).Item("RetrunStatus")
				If String.IsNullOrWhiteSpace(status.ToString) Then
					Flag = True
				Else
					Flag = False
				End If

				If String.IsNullOrWhiteSpace(InDate.ToString) Then
					OutDate = Format(OutDate, "dd-MMM-yyy")
				Else
					OutDate = Format(OutDate, "dd-MMM-yyy")
					InDate = Format(InDate, "dd-MMM-yyy")
				End If
				If status.ToString = "Pending" Then
					Flag = False
					action = "Get-IN"
				Else
					Flag = True
					action = "Received"
				End If

				If String.IsNullOrWhiteSpace(OutProduRemark.ToString) Then
					OutProduRemark = ""
				End If
				DataGridView2.Rows.Add(Flag, jobID, InID, ProdName, OutDate, InDate, SerialNo, OutProduRemark, outStatus, action)

				If status.ToString = "Pending" Then
					Flag = False

				Else
					Flag = True

					DataGridView2.Rows(i).ReadOnly = True
					DataGridView2.Rows(i).DefaultCellStyle.BackColor = outsandPendingcolor
					DataGridView2.Rows(i).Cells(0).Value = False
				End If

				If status.ToString = "Repaired" Or status.ToString = "UnRepaired" Then
					DataGridView2.Rows(i).ReadOnly = True
					DataGridView2.Rows(i).DefaultCellStyle.BackColor = OutsrcLightYellow
					DataGridView2.Rows(i).Cells(0).Value = False
				End If
			Next

			sqldbAdapter.Dispose()
			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox(ex.ToString())
		End Try
	End Sub
	Public Sub FetchData()
		If String.IsNullOrWhiteSpace(txtsearch.Text) = True Then Exit Sub


		datagridDataLoad2()
		LoadValues(txtsearch.Text)



	End Sub

	Function BuildQuery() As String

		BuildQuery = ""
		Dim queryCond As String
		queryCond = ""
		Dim jobststs = cmbjobst.Text

		If String.IsNullOrWhiteSpace(cmbfilter.Text.ToString) Then

		Else
			If String.IsNullOrWhiteSpace(txtsearch.Text) = False Then
				Select Case cmbfilter.Text
					Case "RepaireName"
						queryCond = queryCond & "RepaireName = '" & txtsearch.Text & "'"

					Case "JobID"
						queryCond = queryCond & " Jobid= '" & txtsearch.Text & "'"

					Case Else

				End Select
			Else

			End If


		End If

		If LCase(jobststs) = LCase("All") Then

			'queryCond = queryCond + " Job_status= '" & jobststs & "'"
		Else

			If String.IsNullOrWhiteSpace(queryCond) = True Then
			Else
				queryCond = queryCond & " and "
			End If


			queryCond = queryCond + " RetrunStatus= '" & jobststs & "'"

		End If
		If Datefilter.Checked = False Then
		Else
			If String.IsNullOrWhiteSpace(queryCond) = True Then
			Else
				queryCond = queryCond & " and "
			End If


			queryCond = queryCond + " OutDate between  '" & Format(CDate(dpfromdate.Value), "dd-MMM-yyyy") & "' and  '" & Format(CDate(dptodate.Value), "dd-MMM-yyyy") & "' "
			' MsgBox(sql.ToString)
		End If
		If String.IsNullOrWhiteSpace(queryCond) = False Then queryCond = " Where " & queryCond

		BuildQuery = queryCond

		'MsgBox(queryCond)
	End Function

	Private Sub LoadValues(jobid As Double)
		'MsgBox(jobid & " will be opened for Job  Done").ToString()
		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'Dim i As Integer

		display_JOBDetails.Hide()



		sql = String.Empty
		'connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & DatabasePath & "\" & DatabaseFileName & "'"
		OpenDatabaseObject()


		sql = "Select RepairMan,RepairStatus,cust_name from OtherproductDetails where ID =" & jobid
		txtsearch.Text = jobid

		Try

			sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.Fill(ds)
			'MsgBox(ds.Tables(0).Rows(0).Item(24))
			With ds.Tables(0)
				'txtrepairMan = .Rows(0).Item(.Columns.IndexOf("RepairMan"))
				'txtrepaireStatus = .Rows(0).Item(.Columns.IndexOf("RepairStatus"))
				'cmbjobst.Text = .Rows(0).Item(.Columns.IndexOf("Job_status"))
				'txtrepairdone.Text = .Rows(0).Item(.Columns.IndexOf("Repaire_Done"))
				'dpdaterep.Value = CDate(.Rows(0).Item(.Columns.IndexOf("date_repaire")))
			End With
		Catch ex As Exception
			'' MsgBox("Can not open connection ! ").ToString()
		End Try

	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnfetch.Click
		FetchData()
		datagridDataLoad2()
	End Sub

	Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
		Dim NewAddForm As New InvertProdView
		Dim OutID = DataGridView2.CurrentRow.Cells(2).Value.ToString()
		Dim JobidNo = DataGridView2.CurrentRow.Cells(1).Value.ToString()

		NewAddForm.LoadPreviousValues = True
		NewAddForm.LoadValueFromJobID = OutID
		NewAddForm.LoadJobID = JobidNo

		If String.IsNullOrEmpty(DataGridView2.CurrentRow.Cells(4).Value.ToString) Then

		Else
			NewAddForm.DateTimePicker1.Text = CDate(DataGridView2.CurrentRow.Cells(4).Value)
		End If

		NewAddForm.ShowDialog()

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim OutsrcStatus As String
		For aa = 0 To DataGridView2.Rows.Count - 1
			Dim Strst = DataGridView2.Rows(aa).Cells(0).Value
			If Strst = "True" Then
				OutsrcStatus = "False"

				Dim ProdName = DataGridView2.Rows(aa).Cells(3).Value
				Dim SerialNo = DataGridView2.Rows(aa).Cells(4).Value
				Dim InID = DataGridView2.Rows(aa).Cells(2).Value
				Dim ProdOutStatusFromInvert = DataGridView2.Rows(aa).Cells(0).Value
				OpenDatabaseObject()

				If Strst = "True" Then
					'Dim Sql = "Update OutSrcProductDetails set Retrun='" & Format(Now(), "dd-MMM-yyyy") & "',RetrunStatus ='" & txtrepaireStatus.Text & "',ReturnRemark ='" & txtretrunremark.Text & "',ReceiverName ='" & session & "',final_amt_taken=" & txtamt.Text & " where Jobid ='" & txtjobid.Text & "' and ProductName ='" & ProdName & "' and InId = '" & InID & "'"

					Dim Sql2 = "update OtherproductDetails Set RepairStatus='" & OutsrcStatus & "',ProdINSrcDate='" & Format(CDate(Now()), "dd-MMM-yyyy") & "',Outward='False'  where ProductName = '" & ProdName & "' And ID = '" & InID & "'"


					Dim comm As New SqlClient.SqlCommand(Sql2, SQLConn)
					comm.ExecuteNonQuery()
					comm.Dispose()
				End If
			Else
			End If
		Next
		MsgBox("Inverted Details Add Sucessfully!! ").ToString()
	End Sub

	Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick


		If (e.ColumnIndex.ToString() = 9) Then



			If DataGridView2.Rows(e.RowIndex.ToString()).Cells(8).Value = "Pending" Then
				Newivertupdate.txtjobid.Text = DataGridView2.Rows(e.RowIndex.ToString()).Cells(1).Value
				Newivertupdate.LoadPreviousValues = True
				Newivertupdate.LoadValueFromJobID = DataGridView2.Rows(e.RowIndex.ToString()).Cells(1).Value
				Newivertupdate.txtamt.Clear()
				Newivertupdate.txtremk.Clear()
				Newivertupdate.txtRep.Clear()
				Newivertupdate.ShowDialog()


				'InvertProdUpdate.LoadPreviousValues = True
				''InvertProdUpdate.TextBox1.Text = DataGridView2.Rows(e.RowIndex.ToString()).Cells(1).Value
				'InvertProdUpdate.loadvalues(DataGridView2.Rows(e.RowIndex.ToString()).Cells(1).Value)
				'InvertProdUpdate.ShowDialog()

			End If
		End If
	End Sub

	Private Sub cmbjobst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjobst.SelectedIndexChanged
		btnfetch.PerformClick()
	End Sub
End Class