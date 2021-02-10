Imports System.Drawing.Printing

Public Class frmPrinting
	Public JobId As String
	Public JobDate As String
	Public cmpnyName As String
	Public EstimatedVal As Integer
	Public EstimatedDate As String
	Public problmComplain As String
	Public prblm_observe As String
	Public CustomerName, CustomerMob As String
	Public cmpnyAddress As String
	Public cmpnyMobile As String
	Public typeprinter As String
	Public Address As String
	Public PrintPrev As Boolean
	Public PrinterNm As String
	Dim lstLineToPrint As New List(Of String)

	Dim topmar, botmar, leftmar, rightmar, txtsize, pprHeight, pprwidth As Integer
	Dim typeofpaper As String
	Dim sql As String
	Dim SQLAdapter As SqlClient.SqlDataAdapter
	Dim ds As New DataSet
	Private Sub tsOpenfile_Click(sender As Object, e As EventArgs) Handles tsOpenfile.Click

		Dim strPrint As String = ""
		strPrint = cmpnyAddress & vbCrLf & "-------------------------------------------------" & vbCrLf
		strPrint = strPrint & "Customer Name:" & CustomerName & vbCrLf
		strPrint = strPrint & "Customer Mobile No.:" & CustomerMob & vbCrLf & "-------------------------------------------------" & vbCrLf

		strPrint = strPrint & "JobID:" & JobId & "	 JobDate:" & JobDate & vbCrLf
		strPrint = strPrint & "-------------------------------------------------" & vbCrLf
		strPrint = strPrint & "ProductName          SerialNo" & vbCrLf
		strPrint = strPrint & "-------------------------------------------------" & vbCrLf


		OpenDatabaseObject()
		sql = "Select ProductName,SerialNo from OtherproductDetails where Jobid =" & JobId & ""
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim ProdName = ds.Tables(0).Rows(i).Item("ProductName")
				Dim SerialNo = ds.Tables(0).Rows(i).Item("SerialNo")

				strPrint = strPrint & ProdName & i & "     " & SerialNo & vbCrLf

			Next
			strPrint = strPrint & "-------------------------------------------------" & vbCrLf
			strPrint = strPrint & "Problem Complain: " & problmComplain & vbCrLf

			If EstimatedVal > 0 Then
				strPrint = strPrint & "Estimated Value: " & EstimatedVal & vbCrLf
				If EstimatedDate.Equals(JobDate) = False Then
					strPrint = strPrint & "Estimated Date: " & JobDate & vbCrLf
				End If
			End If
			strPrint = strPrint & vbNewLine
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
		txtfile.Text = strPrint



	End Sub
	Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles tsPrint.Click
		PrintDialog.PrinterSettings = PrintDoc.PrinterSettings
		'If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
		'PrintDoc.PrinterSettings = PrintDialog.PrinterSettings

		Dim xCustomSize As New PaperSize(typeofpaper, pprwidth, pprHeight)
		Dim PageSetup As New PageSettings
		With PageSetup
			.Margins.Left = leftmar
			.Margins.Right = rightmar
			.Margins.Top = topmar
			.Margins.Bottom = botmar
			.Landscape = False
			.PaperSize = xCustomSize
		End With

		'Me.PrintDoc.DefaultPageSettings.PaperSize = xCustomSize
		PrintDoc.DefaultPageSettings = PageSetup

		If PrintPrev = False Then
			PrintDoc.Print()
			Dim builder As New System.Text.StringBuilder()
			builder.Append(Chr(27) & Chr(64))
			builder.Append(Chr(27) & Chr(97) & Chr(49))
			builder.Append(Chr(27) & Chr(33) & Chr(16))
			builder.Append(Chr(&H1D) & "V" & Chr(66) & Chr(0))
			'MsgBox(builder.ToString())
			RawPrinterHelper.SendStringToPrinter(PrinterNm, builder.ToString(), "x")
		Else
			PrintPreviewDialog1.Document = PrintDoc
			PrintPreviewDialog1.PrintPreviewControl.AutoZoom = True
			PrintPreviewDialog1.ShowDialog()
		End If
	End Sub

	Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtprobobserve.TextChanged

	End Sub

	Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

	End Sub

	Private Sub PrintDoc_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDoc.BeginPrint

	End Sub

	Private Sub PrintDoc_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDoc.EndPrint
		Me.Close()
	End Sub

	Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage


		Static intStart As Integer
		Dim fntText As Font = txtfile.Font
		Dim txtHeight As Integer
		Dim LeftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
		Dim RightMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Right
		Dim TopMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top
		txtHeight = PrintDoc.DefaultPageSettings.PaperSize.Height - PrintDoc.DefaultPageSettings.Margins.Top - PrintDoc.DefaultPageSettings.Margins.Bottom
		Dim LinesPerPage As Integer = CInt(Math.Round(txtHeight / (fntText.Height + 0.025)))

		'e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)

		Dim TitleFont As Font = New Font(ThermalPrintFont, 20, FontStyle.Bold, ContentAlignment.TopCenter)
		Dim AddressFont As Font = New Font(ThermalPrintFont, 10, FontStyle.Regular)
		Dim myFont3 As Font = New Font(ThermalPrintFont, 15, FontStyle.Regular, ContentAlignment.TopCenter)
		Dim myBrush As Brush = Brushes.Black


		Dim format As StringFormat = New StringFormat(StringFormatFlags.DirectionRightToLeft)
		Me.Width = 1000


		Dim intLineNumber As Integer

		Dim pt As New Point(0, 45)
		Dim pt1 As New Point(300, 45)

		Dim pt2 As New Point(0, 95)
		Dim pt3 As New Point(300, 95)

		Dim pt4 As New Point(0, 145)
		Dim pt5 As New Point(300, 145)
		Dim a = 165
		Dim txt = ""

		e.Graphics.DrawString(txtcompany.Text, TitleFont, myBrush, 75, 20)
		e.Graphics.DrawLine(Pens.Black, pt, pt1)
		e.Graphics.DrawString(txtAddress.Text, AddressFont, myBrush, 0, 47)

		'e.Graphics.DrawString(   txtAddress.Text, AddressFont, myBrush, e.PageBounds.Width / 2 - e.Graphics.MeasureString(txtAddress.Text, AddressFont).Width / 2, 60)

		e.Graphics.DrawString(TextBox3.Text, AddressFont, myBrush, 20, 60)
		e.Graphics.DrawString(TextBox4.Text, AddressFont, myBrush, 40, 75)
		e.Graphics.DrawLine(Pens.Black, pt2, pt3)
		e.Graphics.DrawString("Job Id:"& JobId, myFont3, myBrush, 0, 105)
		e.Graphics.DrawString(JobDate, myFont3, myBrush, 180, 105)
		e.Graphics.DrawLine(Pens.Black, pt4, pt5)

		'For dt = 0 To 4

		'e.Graphics.DrawString(dt + 1 & ") Hp Printer", myFont3, myBrush, 20, a)
		'a += 35
		'Next
		e.Graphics.DrawString("Given Products:", myFont3, myBrush, 0, 155)
		For i = 0 To ds.Tables(0).Rows.Count - 1
			Dim ProdName = ds.Tables(0).Rows(i).Item("ProductName")
			Dim SerialNo = ds.Tables(0).Rows(i).Item("SerialNo")

			e.Graphics.DrawString(i + 1 & ")" & ProdName, myFont3, myBrush, 16, a)
			a += 20
			'MsgBox(a & ")" & ProdName)
		Next





		Dim pt6 As New Point(0, a)
		Dim pt7 As New Point(300, a)

		e.Graphics.DrawLine(Pens.Black, pt6, pt7)
		a += 20
		e.Graphics.DrawString("Problem Desc:" & problmComplain, myFont3, myBrush, 20, a)
		a += 35
		e.Graphics.DrawString("Problem Observe:" & prblm_observe, myFont3, myBrush, 20, a)

		a += 35
		Dim pt8 As New Point(0, a)
		Dim pt9 As New Point(300, a)

		e.Graphics.DrawLine(Pens.Black, pt8, pt9)
		a += 35

		'	For intCounter = intStart To lstLineToPrint.Count - 1
		'	If intCounter = 0 Then
		'	'e.Graphics.DrawString("Name OF Company", myFont, myBrush, 50, 10)
		'	e.Graphics.DrawString(txtcompany.Text, myFont, myBrush, 75, 20)
		'	End If
		'	e.Graphics.DrawString(lstLineToPrint(intCounter), fntText, Brushes.Black, LeftMargin, fntText.Height * intLineNumber + 100)
		'	intLineNumber += 1
		'	intCounter += 1
		'	If intLineNumber > LinesPerPage - 1 Then
		'	intStart = intCounter
		'	e.HasMorePages = True
		'
		'End If
		'Next

	End Sub


	Private Sub frmPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		OnLoadValuPrinter(typeprinter)
		compnayDetails()
		productLoad()
		tsOpenfile.PerformClick()
		tsPrint.PerformClick()

	End Sub
	Private Sub OnLoadValuPrinter(printerNam As String)
		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0

		sql = "Select * from PrinterPageSetting where printertype ='" & printerNam & "'"
		'MsgBox(sql)
		Try

			OpenDatabaseObject()
			Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.Fill(ds, "job_services_table")

			count = ds.Tables(0).Rows.Count

			If count > 0 Then
				botmar = ds.Tables(0).Rows(0).Item("topMar")
				pprHeight = ds.Tables(0).Rows(0).Item("paperheight")
				leftmar = ds.Tables(0).Rows(0).Item("leftmar")
				rightmar = ds.Tables(0).Rows(0).Item("rightmar")
				topmar = ds.Tables(0).Rows(0).Item("topMar")
				pprwidth = ds.Tables(0).Rows(0).Item("paperwidth")
				txtsize = ds.Tables(0).Rows(0).Item("textwidth")
				typeofpaper = ds.Tables(0).Rows(0).Item("papertype")
			Else

			End If
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub productLoad()
		OpenDatabaseObject()
		sql = "Select ProductName,SerialNo from OtherproductDetails where Jobid =" & JobId & ""
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1
				Dim ProdName = ds.Tables(0).Rows(i).Item("ProductName")
				Dim SerialNo = ds.Tables(0).Rows(i).Item("SerialNo")
			Next

		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub
	Private Sub compnayDetails()

		Dim sql, sql2 As String
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim SQLAdapter2 As SqlClient.SqlDataAdapter
		Dim ds2 As New DataSet
		OpenDatabaseObject()
		sql = "Select * from CompanyDetails "
		sql2 = "SELECT job_date,prblm_comp,prblm_observe,mobile,cust_name,Estimate_value,Estimate_date FROM job_services where id =" & JobId & ""
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			SQLAdapter.Dispose()

			SQLAdapter2 = New SqlClient.SqlDataAdapter(sql2, SQLConn)
			SQLAdapter2.SelectCommand.ExecuteNonQuery()
			SQLAdapter2.Fill(ds2, "customer_reg")
			SQLAdapter2.Dispose()

			For i = 0 To ds2.Tables(0).Rows.Count - 1
				problmComplain = ds2.Tables(0).Rows(i).Item("prblm_comp")
				EstimatedVal = ds2.Tables(0).Rows(i).Item("Estimate_value")
				EstimatedDate = Format(ds2.Tables(0).Rows(i).Item("Estimate_date"), "dd-MMM-yyyy").ToString
				JobDate = Format(ds2.Tables(0).Rows(i).Item("job_date"), "dd-MMM-yyyy").ToString
				CustomerName = ds2.Tables(0).Rows(i).Item("cust_name")
				CustomerMob = ds2.Tables(0).Rows(i).Item("mobile")
				prblm_observe = ds2.Tables(0).Rows(i).Item("prblm_observe")

			Next


			For i = 0 To ds.Tables(0).Rows.Count - 1
				cmpnyName = ds.Tables(0).Rows(i).Item("name")
				cmpnyAddress = ds.Tables(0).Rows(i).Item("Address")
				cmpnyMobile = ds.Tables(0).Rows(i).Item("mobileNo")
			Next
		Catch ex As Exception
			MsgBox(ex.ToString()).ToString()
		End Try
	End Sub
End Class
