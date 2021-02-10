Public Class columnView
	Dim rowIndexFromMouseDown As Int16
	Dim rw As DataGridViewRow
	Dim bMouseIsDown As Boolean = False
	Private Sub columnView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dataGrid1Load()
		AddDataInGrid()
	End Sub
	Private Sub AddDataInGrid()

		OpenDatabaseObject()

		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0


		sql = "Select * from columnFilter "
		colName = ""
		Try

			OpenDatabaseObject()
			Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			For i = 0 To ds.Tables(0).Rows.Count - 1
				If ds.Tables(0).Rows(i).Item(1) = "Remark" Or ds.Tables(0).Rows(i).Item(1) = "prblm_comp" Or ds.Tables(0).Rows(i).Item(1) = "product_service" Or ds.Tables(0).Rows(i).Item(1) = "ID" Or ds.Tables(0).Rows(i).Item(1) = "cust_name" Or ds.Tables(0).Rows(i).Item(1) = "Job_status" Then
					DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(3), ds.Tables(0).Rows(i).Item(2))
					DataGridView1.Rows(i).ReadOnly = True


				Else
					DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item(0), ds.Tables(0).Rows(i).Item(3), ds.Tables(0).Rows(i).Item(2))
				End If
				'MsgBox(ds.Tables(0).Rows(i).Item(1))


			Next

		Catch ex As Exception
			MsgBox(ex.ToString())

		End Try


	End Sub

	Private Sub dataGrid1Load()
		Dim dgvProdnm As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ColumnName"

		Dim dgvcolid As New DataGridViewTextBoxColumn()
		dgvProdnm.HeaderText = "ColumnID"

		Dim dgvCheck As New DataGridViewCheckBoxColumn()
		dgvCheck.HeaderText = "CheckBox"

		DataGridView1.Columns.Add(dgvcolid)
		DataGridView1.Columns.Add(dgvProdnm)
		DataGridView1.Columns.Add(dgvCheck)

		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		DataGridView1.AllowUserToAddRows = False

		DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)


	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub



	Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
		If DataGridView1.SelectedRows.Count = 1 Then

			If e.Button = MouseButtons.Left Then

				rw = DataGridView1.SelectedRows(0)
				rowIndexFromMouseDown = DataGridView1.SelectedRows(0).Index
				DataGridView1.DoDragDrop(rw, DragDropEffects.Move)
			End If
		End If

	End Sub

	Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove
		If DataGridView1.SelectedRows.Count > 0 Then
			If bMouseIsDown Then
				Dim path As String = DataGridView1.SelectedRows(0).Cells(1).Value
				DataGridView1.DoDragDrop(path, DragDropEffects.Copy)
			End If
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		colName = ""
		Try
			Dim temp As Int16 = DataGridView1.Rows.Count - 1

			'Dim Swq = "delete columnFilter "
			'Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			'comm.ExecuteNonQuery()
			'comm.Dispose()
			For aa = 0 To DataGridView1.Rows.Count - 1
				Dim Strst = DataGridView1.Rows(aa).Cells(0).Value
				' MsgBox(Strst)
				Dim Swq = "Update columnFilter set ColStatus  ='" & DataGridView1.Rows(aa).Cells(2).Value & "'  where id='" & DataGridView1.Rows(aa).Cells(0).Value & "'"
				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)

				comm.ExecuteNonQuery()
				comm.Dispose()

			Next
			SelectColumnNameFilter()

			display_JOBDetails.btnshow.PerformClick()
			Me.Close()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub
End Class