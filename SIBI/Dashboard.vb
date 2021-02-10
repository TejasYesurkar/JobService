Public Class Dashboard
	Dim SDate As String = Format(CDate(Now()), "yyyy-MM-dd")
	Dim EDate As String = Format(CDate(Now()), "yyyy-MM-dd")
	Private Sub JobStatusDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SelectColumnNameFilter()
	End Sub

	Private Sub JobStatusDetails_Activated(sender As Object, e As EventArgs) Handles Me.Activated


		btnpending.Text = "Pending Job Counts :" & PendingJobs()
		btnNew.Text = "New Jobs Count:" & NewJobAsOnDate(SDate, EDate)
		btnRep.Text = "Today Repaired Job: " & JobsRepairedforDates(SDate, EDate)
		btndel.Text = "Today Delivery Jobs:" & JobsDeliveryforDates(SDate, EDate)
	End Sub

	Function PendingJobs() As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer
		PendingJobs = ""
		OpenDatabaseObject()
		sql = "SELECT count(*) FROM job_services where Job_status ='Pending'"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				PendingJobs = ds.Tables(0).Rows(i).Item(0)
			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()

		End Try
	End Function

	Function NewJobAsOnDate(SDate As Date, EDate As Date) As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String


		NewJobAsOnDate = ""
		OpenDatabaseObject()
		sql = "SELECT count(*) FROM job_services where job_date  between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()
			If ds.Tables(0).Rows.Count = 0 Then
				btnRep.Text = 0
			End If

			For i = 0 To ds.Tables(0).Rows.Count - 1
				NewJobAsOnDate = ds.Tables(0).Rows(i).Item(0)
			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()

		End Try
	End Function


	Function JobsRepairedforDates(SDate As Date, EDate As Date) As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer
		JobsRepairedforDates = ""
		OpenDatabaseObject()
		sql = "SELECT count(*) FROM job_services Where  date_repaire between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "


		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				JobsRepairedforDates = ds.Tables(0).Rows(i).Item(0)
			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

	End Function

	Function JobsDeliveryforDates(SDate As Date, EDate As Date) As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		'  Dim i As Integer

		OpenDatabaseObject()
		sql = "SELECT count(*) as count FROM job_services Where  job_delivery_date between '" & Format(CDate(SDate), "yyyy-MM-dd") & "' and '" & Format(CDate(EDate), "yyyy-MM-dd") & "' "


		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				JobsDeliveryforDates = ds.Tables(0).Rows(i).Item(0)
			Next

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()

		End Try
		'Return JobsDeliveryforDates
	End Function

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpending.Click
		DashboardResult.txtpending.Text = "Pending List"
		DashboardResult.cmbRepotyp.Text = "Pending Report"
		DashboardResult.Button1.PerformClick()
		DashboardResult.RepoType = "P"
		DashboardResult.ShowDialog()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		DashboardResult.txtpending.Text = "New Jobs List"
		DashboardResult.cmbRepotyp.Text = "New Job Report"
		DashboardResult.Button1.PerformClick()
		DashboardResult.RepoType = "N"
		DashboardResult.ShowDialog()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRep.Click
		DashboardResult.txtpending.Text = "Today Repaired Job "
		DashboardResult.RepoType = "R"
		DashboardResult.cmbRepotyp.Text = "Repaired Report"
		DashboardResult.Button1.PerformClick()
		DashboardResult.ShowDialog()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btndel.Click
		DashboardResult.txtpending.Text = "Delivery Job List"
		DashboardResult.cmbRepotyp.Text = "Delivery Jobs Report"
		DashboardResult.Button1.PerformClick()
		DashboardResult.RepoType = "D"
		DashboardResult.ShowDialog()
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs)

	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		ReportViewer.DayReport(Format(CDate(Now()), "dd-MM-yyyy"))
	End Sub

	Private Sub Button1_Click_2(sender As Object, e As EventArgs) 
		JobResponsive.Show()

	End Sub

	Private Sub Button1_Click_3(sender As Object, e As EventArgs) 
		Dim PrintPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog

		Dim PrintDocument1 As Printing.PrintDocument = New Printing.PrintDocument

		PrintPreviewDialog1.Document = PrintDocument1

		PrintPreviewDialog1.ShowDialog()

		AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage

		PrintDocument1.Print()
	End Sub

	Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)



		'Dim newImage As Image = Image.FromFile("E:\VBproject\Gap.bmp")

		'e.Graphics.DrawImage(newImage, 100, 100)

		' You also can reference an image to PictureBox1.Image.



		Dim txtReader As System.IO.StreamReader = New System.IO.StreamReader("D:\USER\Desktop\temp.txt")

		Dim textOfFile As String = txtReader.ReadToEnd

		txtReader.Close()

		e.Graphics.DrawString(textOfFile, New Font("Arial", 16), Brushes.Black, 100, 500)

		' You also can reference some text to RichTextBox1.Text, etc.



	End Sub
End Class