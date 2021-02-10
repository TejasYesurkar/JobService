Public Class ReportViewer
	Public PrintPrev As String

	Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DateTimePicker1.Hide()
	End Sub


	Public Sub DayReport(followupdate As Date)
		Me.Show()
		DateTimePicker1.Show()

		Try
			Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
			report.Load(Application.StartupPath + "\Report\CrystalReport1.rpt")

			Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo.ConnectionInfo.UserID = DBUserName  ' UserIDFromFile
			objTableLogonInfo.ConnectionInfo.Password = DBPass  ' PasswordFromFile
			objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress  ' ServerNameFromFile
			objTableLogonInfo.ConnectionInfo.DatabaseName = DBName  ' DatabaseNameFromFile
			For Each objDatabaseTable In report.Database.Tables
				objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
			Next objDatabaseTable
			MsgBox(followupdate)
			'{ActivityTable.ADate}=#" & Format(CDate(followupdate), "yyyy-MM-dd") & "# and 
			report.RecordSelectionFormula = "{job_services.job_date}=#" & Format(CDate(followupdate), "yyyy-MM-dd") & "#"
			'report.SetParameterValue("{JDATE}=#", Format(CDate(followupdate), "yyyy-MM-dd") & "#")
			'report.PrintToPrinter(1, False, 0, 0)
			CrystalReportViewer1.ReportSource = report
			CrystalReportViewer1.Refresh()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub



	Public Sub Followlist(followupdate As Date)
		Me.Show()
		Try
			Dim report As New followupCrystalReport
			report.Load(Application.StartupPath + "\Report\followupCrystalReport.rpt")

			Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo.ConnectionInfo.UserID = DBUserName  ' UserIDFromFile
			objTableLogonInfo.ConnectionInfo.Password = DBPass  ' PasswordFromFile
			objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress  ' ServerNameFromFile
			objTableLogonInfo.ConnectionInfo.DatabaseName = DBName  ' DatabaseNameFromFile
			For Each objDatabaseTable In report.Database.Tables
				objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
			Next objDatabaseTable

			report.RecordSelectionFormula = "{ActivityTable.ADate}=#" & Format(CDate(followupdate), "yyyy-MM-dd") & "#"
			'report.PrintToPrinter(1, False, 0, 0)
			CrystalReportViewer1.ReportSource = report
			CrystalReportViewer1.Refresh()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub




	Public Sub JobIDReportView(JobId As Double, PrinterName As String)
		Me.Show()

		Try
			Dim report As New jobLaserReport
			report.Load(Application.StartupPath + "\Report\jobLaserReport.rpt")

			Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo.ConnectionInfo.UserID = DBUserName  ' UserIDFromFile
			objTableLogonInfo.ConnectionInfo.Password = DBPass  ' PasswordFromFile
			objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress  ' ServerNameFromFile
			objTableLogonInfo.ConnectionInfo.DatabaseName = DBName  ' DatabaseNameFromFile
			For Each objDatabaseTable In report.Database.Tables
				objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
			Next objDatabaseTable
			report.RecordSelectionFormula = "{job_services.ID}=" & JobId

			report.PrintOptions.PrinterName = PrinterName
			If PrintPrev = False Then
				report.PrintToPrinter(1, False, 0, 0)
			End If

			CrystalReportViewer1.ReportSource = report
			CrystalReportViewer1.Refresh()
		Catch ex As Exception

		End Try

	End Sub





	Public Sub CustomerReport(custid As Integer)
		Me.Show()

		Try
			Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
			report.Load(Application.StartupPath + "\Report\CrystalReport3.rpt")

			Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
			objTableLogonInfo.ConnectionInfo.UserID = DBUserName  ' UserIDFromFile
			objTableLogonInfo.ConnectionInfo.Password = DBPass  ' PasswordFromFile
			objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress  ' ServerNameFromFile
			objTableLogonInfo.ConnectionInfo.DatabaseName = DBName  ' DatabaseNameFromFile
			For Each objDatabaseTable In report.Database.Tables
				objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
			Next objDatabaseTable

			report.RecordSelectionFormula = "{Customer_reg.cust_id}=" & CInt(custid)

			report.PrintOptions.PrinterName = printername

			CrystalReportViewer1.ReportSource = report
			CrystalReportViewer1.Refresh()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub



	Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
		DayReport(DateTimePicker1.Text)
	End Sub

End Class