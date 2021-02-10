Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop

Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class display_JOBDetails
    Dim NewAddForm As New AddJobDetails
    Dim sqlQuery As String
    Private IsFormLoading As Boolean
    Public ReportParameter As String = " "
    Dim crystalqueryCond As String = ""
    Public Updated As Boolean = False
    Public UpdatedJobID As Integer = 0
    Public rowIndx As Integer
    'Form Loading 
    Private Sub display_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsFormLoading = True
        SelectColumnNameFilter()

        queryCond = ""
        dpfromdate.Enabled = False
        dptodate.Enabled = False
        dpfromdate.Value = Format(CDate(Now()), "yyyy-MM-dd")
        dptodate.Value = Format(CDate(Now()), "yyyy-MM-dd")
        txtsearch.Enabled = False
        cmbjobst.Text = "Pending"
        cmbjobst.Items.Add("All")
        LoadCmbStatus()

        cmbfilter.Items.Clear()
        cmbfilter.Items.Add("Name")
        cmbfilter.Items.Add("Job_status")
        cmbfilter.Items.Add("MobileNo")
        cmbfilter.Items.Add("JobID")
        cmbfilter.Items.Add("ServiceType")
        cmbfilter.Items.Add("")

        cmbdilvery.Items.Clear()
        cmbdilvery.Items.Add("Delivered")
        cmbdilvery.Items.Add("Undelivered")
        cmbdilvery.Items.Add("Part Delivered")
        cmbdilvery.Items.Add("")

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Pending With Details")
        ComboBox1.Items.Add("Basic Report")

        ComboBox1.Items.Add("")

        DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)

        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView1.ReadOnly = True


        FetchandRefreshData()

        columnView.Button1.PerformClick()

        IsFormLoading = False

        cmbLaser.Visible = True
        cmbThermal.Visible = False
        LPrinterList()
        RPrinterList()

        Dim strStatus = ReadINI("Printer", "PrinterStatus", "")
        If strStatus = "Laser Print" Then
            Lprint.Checked = True
        Else
            Tprint.Checked = True
        End If
    End Sub

    Sub LoadCmbStatus()

        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        '  Dim i As Integer

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
            cmbjobst.Text = "Pending"
            SQLAdapter.Dispose()
            CloseDatabaseObject()
        Catch ex As Exception
            MsgBox(ex).ToString()

        End Try
    End Sub
    Private Sub LPrinterList()

        Dim strdb As String = ReadINI("LPrinter", "LPrinterName", "")
        'MsgBox(strdb)
        Dim sPrinters As String = ""

        ' POPULATE THE COMBO BOX.
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cmbLaser.Items.Add(sPrinters)
        Next
        cmbLaser.Text = strdb



        ' localip.Text = "Local IP:" + "127.0.0.1"
    End Sub

    Private Sub RPrinterList()

        Dim strdb As String = ReadINI("TPrinter", "TPrinterName", "")

        Dim sPrinters As String = ""

        ' POPULATE THE COMBO BOX.
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cmbThermal.Items.Add(sPrinters)
        Next
        cmbThermal.Text = strdb



        ' localip.Text = "Local IP:" + "127.0.0.1"
    End Sub
    Private Sub FetchandRefreshData()

        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        OpenDatabaseObject()
        'MsgBox(colName)
        sqlQuery = "Select " & colName & "  from job_services " & BuildQuery() & "   order By job_date ASC , ID ASC "
        'MsgBox(sql)
        Try
            DataGridView1.ClearSelection()
            DataGridView1.Refresh()
            SQLAdapter = New SqlClient.SqlDataAdapter(sqlQuery, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "job_services_table")
            SQLAdapter.Dispose()

            DataGridView1.DataSource = ds

            DataGridView1.DataMember = "job_services_table"

            Format_Datagridview1()
            'ds.Dispose()

        Catch ex As Exception
            'MsgBox(ex.ToString)


        End Try

    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        FetchandRefreshData()
    End Sub

    Function BuildQuery() As String
        BuildQuery = ""
        Dim queryCond As String

        Dim queryCondForCrystal As String
        queryCond = ""
        crystalqueryCond = ""
        Dim jobststs = cmbjobst.Text
        Dim NoStatusFilters As Boolean = False
        ReportParameter = " "
        If String.IsNullOrWhiteSpace(cmbfilter.Text.ToString) Then
            NoStatusFilters = False
            crystalqueryCond = ""
        Else
            If String.IsNullOrWhiteSpace(txtsearch.Text) = False Then
                ReportParameter = "(" & cmbfilter.Text.ToString
                Select Case cmbfilter.Text
                    Case "Name"
                        queryCond = queryCond & "cust_name Like '%" & txtsearch.Text & "%'"

                        crystalqueryCond = crystalqueryCond & "{cust_name Like '%" & txtsearch.Text & "%'}"
                        ReportParameter = ReportParameter & txtsearch.Text & " )"
                        NoStatusFilters = True
                    Case "Job_status"
                        queryCond = queryCond & " Job_status= '" & txtsearch.Text & "'"
                        queryCondForCrystal = queryCondForCrystal & " Job_status= '" & txtsearch.Text & "'"
                        crystalqueryCond = crystalqueryCond & "{job_services.Job_status}='" & txtsearch.Text & "'"
                        ReportParameter = ReportParameter & txtsearch.Text & " )"
                    Case "MobileNo"
                        queryCond = queryCond & " mobile= '" & txtsearch.Text & "'"
                        crystalqueryCond = crystalqueryCond & "{job_services.mobile}='" & txtsearch.Text & "'"
                        NoStatusFilters = True
                        ReportParameter = ReportParameter & txtsearch.Text & " )"
                    Case "JobID"
                        queryCond = queryCond & " ID = " & txtsearch.Text & ""
                        crystalqueryCond = crystalqueryCond & "{job_services.ID}='" & txtsearch.Text & "'"
                        NoStatusFilters = True
                        ReportParameter = ReportParameter & txtsearch.Text & " )"
                    Case "ServiceType"
                        queryCond = queryCond & " service_type= '" & txtsearch.Text & "'"
                        crystalqueryCond = crystalqueryCond & "{job_services.service_type}='" & txtsearch.Text & "'"
                        ReportParameter = " (" & ReportParameter & ":" & txtsearch.Text & " )"
                    Case Else

                End Select
            Else
                NoStatusFilters = False
            End If
        End If

        If Datefilter.Checked = False Then
        Else
            If String.IsNullOrWhiteSpace(queryCond) = True Then
            Else
                queryCond = queryCond & " and "
                crystalqueryCond = crystalqueryCond & " and "
            End If

            queryCond = queryCond + " job_date between  '" & Format(CDate(dpfromdate.Value), "yyyy-MM-dd") & "' and  '" & Format(CDate(dptodate.Value), "yyyy-MM-dd") & "' "

            Dim frmdt = Format(CDate(dpfromdate.Value), "yyyy-MM-dd")
            Dim todt = Format(CDate(dptodate.Value), "yyyy-MM-dd")

            crystalqueryCond = crystalqueryCond & "({job_services.job_date} >= '" & frmdt & "' and {job_services.job_date} <=  '" & todt & "')"
            'crystalqueryCond = crystalqueryCond & "{job_services.job_date} > { " & Format(CDate(dpfromdate.Value), "yyyy-MM-dd") & " }"
            'crystalqueryCond = crystalqueryCond & "{job_services.job_date} >= DateTime (" & Format(CDate(dpfromdate.Value), "dd") & "/" & Month(dpfromdate.Value) & "/" & Year(dpfromdate.Value) & " 12:00:00) AND {job_services.job_date} <= DateTime(" & Format(CDate(dptodate.Value), "dd") & "/" & Month(dptodate.Value) & "/" & Year(dptodate.Value) & " 12:00:00)"
            ReportParameter = ReportParameter & "( " & Format(CDate(dpfromdate.Value), "yyyy-MM-dd") & " To " & Format(CDate(dptodate.Value), "yyyy-MM-dd") & " )"
        End If



        If NoStatusFilters = False Then

            If LCase(jobststs) = LCase("All") Then
                'queryCond = queryCond + " Job_status= '" & jobststs & "'"
            Else
                If String.IsNullOrWhiteSpace(queryCond) = True Then
                Else
                    queryCond = queryCond & " and "
                    crystalqueryCond = crystalqueryCond & " and "

                End If

                queryCond = queryCond + " Job_status= '" & jobststs & "'"
                ReportParameter = ReportParameter & "( Job_status= " & jobststs & " )"
                crystalqueryCond = crystalqueryCond & "{job_services.Job_status}='" & jobststs & "'"
            End If

            If String.IsNullOrWhiteSpace(cmbdilvery.Text) Then

            Else

                If String.IsNullOrWhiteSpace(queryCond) Then
                    queryCond = queryCond + " job_delivery= '" & cmbdilvery.Text & "'"
                    crystalqueryCond = crystalqueryCond & "{job_services.job_delivery}='" & cmbdilvery.Text & "'"
                Else
                    queryCond = queryCond + " and job_delivery= '" & cmbdilvery.Text & "'"
                    crystalqueryCond = crystalqueryCond & " and {job_services.job_delivery}='" & cmbdilvery.Text & "'"
                End If
                ReportParameter = ReportParameter & "( Delivery Status= " & cmbdilvery.Text & ")"
            End If
        End If

        If String.IsNullOrWhiteSpace(queryCond) = False Then queryCond = " Where " & queryCond

        BuildQuery = queryCond

    End Function

    Private Sub Format_Datagridview1()


        On Error Resume Next
        DataGridView1.Columns("ID").HeaderText = "Job ID"
        DataGridView1.Columns("job_date").HeaderText = "Job Date"
        DataGridView1.Columns("cust_name").HeaderText = "Customer Name"
        DataGridView1.Columns("product_service").HeaderText = "Product For Repair/Services"
        DataGridView1.Columns("warranty").HeaderText = "Warranty/AMC Valid Till"
        DataGridView1.Columns("prblm_comp").HeaderText = "Problem Complained"
        DataGridView1.Columns("prblm_observe").HeaderText = "Problem Observed"
        DataGridView1.Columns("Estimate_value").HeaderText = "Estimated Value"
        'DataGridView1.Columns("Estimate_date").HeaderText = "Estimated Date"
        DataGridView1.Columns("Repaire_Done").HeaderText = "Repairs Done / Parts Used"
        DataGridView1.Columns("Remark").HeaderText = "Remarks"
        DataGridView1.Columns("name_of_user").HeaderText = "User name"
        DataGridView1.Columns("date_of_entry").HeaderText = "Date of Entry "
        DataGridView1.Columns("modify_user_name").HeaderText = "Data Modifed By"
        DataGridView1.Columns("date_of_modify").HeaderText = "Date Of Data Modify"
        DataGridView1.Columns("company_name").HeaderText = "Compnay Name "
        DataGridView1.Columns("date_repaire").HeaderText = "Date Of product Repair"
        DataGridView1.Columns("job_delivery").HeaderText = "Job Deliver Status"
        DataGridView1.Columns("job_delivery_date").HeaderText = "Job Deliver Date"
        DataGridView1.Columns("Receiver").HeaderText = "Receiver's Name"
        DataGridView1.Columns("Receiver_mobile").HeaderText = "Receiver's Mob.Number"
        DataGridView1.Columns("RepaireDone_by").HeaderText = "Repair Done By "
        DataGridView1.Columns("perviuosJobid").HeaderText = "Previous Jobid"
        DataGridView1.Columns("customaerid").HeaderText = "Customer ID"

        On Error GoTo 0
    End Sub



    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim JobidNo As String
        JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value.ToString()
        UpdatedJobID = JobidNo
        rowIndx = Me.DataGridView1.SelectedCells.Item(0).RowIndex

        'MsgBox(rowIndx)
        If Trim(Len(JobidNo)) = 0 Then Exit Sub

        NewAddjOB.jobidchk.Checked = False
        NewAddjOB.jobidchk.Enabled = False
        NewAddjOB.btnsave.Enabled = False
        NewAddjOB.btnsaveupdate.Enabled = True
        NewAddjOB.btnsaveupdate.Visible = True
        NewAddjOB.DataGridView1.Visible = True
        NewAddjOB.rowInx = rowIndx
        NewAddjOB.DataGridView1.Columns.Clear()
        NewAddjOB.DataGridView1.Rows.Clear()
        NewAddjOB.LoadPreviousValues = True
        NewAddjOB.LoadForView = False
        NewAddjOB.WindowState = FormWindowState.Maximized
        NewAddjOB.ModificationState = True
        NewAddjOB.LoadValueFromJobID = JobidNo
        NewAddjOB.BackColor = Color.FromArgb(240, 207, 217) 'FromArgb(204, 196, 217)
        'NewAddForm.CallingHandle = "1"
        'MsgBox(NewAddForm.Handle).ToString()
        NewAddjOB.ShowDialog()

    End Sub

    Private Sub cmbjobst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjobst.SelectedIndexChanged

        If IsFormLoading = False Then
            FetchandRefreshData()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles jobdone.Click
        Dim JobidNo As String
        rowIndx = Me.DataGridView1.SelectedCells.Item(0).RowIndex

        JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
        UpdatedJobID = JobidNo
        Dim Prblmcomp = DataGridView1.CurrentRow.Cells(columnName:="prblm_comp").Value
        Dim REMRK = DataGridView1.CurrentRow.Cells("Remark").Value
        If Trim(Len(JobidNo)) = 0 Then Exit Sub
        'AddJobDetails.Close()

        job_delivery.Show()
        job_delivery.txtjobid.Text = JobidNo
        job_delivery.txtcomp.Text = Prblmcomp
        job_delivery.txtremark.Text = REMRK.ToString
        job_delivery.FetchData()

    End Sub

    Private Sub Datafilter_CheckedChanged(sender As Object, e As EventArgs) Handles Datefilter.CheckedChanged
        If Datefilter.Checked = True Then
            dpfromdate.Enabled = True
            dptodate.Enabled = True
        Else
            dpfromdate.Enabled = False
            dptodate.Enabled = False
        End If
    End Sub

    Private Sub cmbfilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilter.SelectedIndexChanged
        txtsearch.Enabled = True
    End Sub

    Private Sub txtsearch_GotFocus(sender As Object, e As EventArgs) Handles txtsearch.GotFocus
        txtsearch.SelectAll()
    End Sub

    Private Sub txtsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtsearch.MouseClick
        txtsearch.SelectAll()
    End Sub

    Private Sub display_data_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        FetchandRefreshData()

        'Me.Refresh()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        columnView.Show()
    End Sub

    Private Sub btnbarcode_Click(sender As Object, e As EventArgs) Handles btnbarcode.Click
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        '  Dim i As Integer

        OpenDatabaseObject()
        Dim JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
        sql = "Select ProductName,SerialNo from OtherproductDetails where Jobid =" & JobidNo & ""


        Try
            '  connection.Open()
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "customer_reg")
            SQLAdapter.Dispose()

            Dim Count As String = ds.Tables(0).Rows.Count

            BarcodePrint.txtjobid.Text = JobidNo
            BarcodePrint.txtqty.Text = Count
            'Me.Close()
            BarcodePrint.Show()
            BarcodePrint.Focus()
            SQLAdapter.Dispose()
            CloseDatabaseObject()



        Catch ex As Exception
            MsgBox(ex.ToString()).ToString()

        End Try

    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim JobidNo As String


        JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value.ToString()
        JobDeatilsView.loadvalues(JobidNo)
        JobDeatilsView.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnimportToExcel.Click
        Try
            btnimportToExcel.Text = "Please Wait.."
            btnimportToExcel.Enabled = False
            SaveFileDialog1.Filter = "Excel Document(*.xlsx |*.xlsx"
            If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlworkbook.Sheets("Sheet1")


                'Add Headers
                For h As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, h) = DataGridView1.Columns(h - 1).HeaderText
                Next

                'for Data 
                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        'For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
                        'Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlworkbook.Close()
                xlApp.Quit()

                relaseObject(xlApp)
                relaseObject(xlworkbook)
                relaseObject(xlWorkSheet)

                MsgBox("File Saved Successfully.")

                'btnimportToExcel.Enabled = True

            End If
        Catch ex As Exception
            MsgBox("Failed To Save..!!")
        End Try

        btnimportToExcel.Text = "Export To Excel"
        btnimportToExcel.Enabled = True

    End Sub

    Private Sub relaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnjobRepaire_Click(sender As Object, e As EventArgs) Handles btnjobRepaire.Click
        Dim JobidNo As String
        RepairerNameAuto()
        JobidNo = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
        UpdatedJobID = JobidNo
        Dim Prblmcomp = Trim(DataGridView1.CurrentRow.Cells(columnName:="prblm_comp").Value)
        Dim REMRK = Trim(DataGridView1.CurrentRow.Cells("Remark").Value)
        ' Dim JobDeliverStatus = Trim(DataGridView1.CurrentRow.Cells("job_delivery").Value)
        rowIndx = Me.DataGridView1.SelectedCells.Item(0).RowIndex

        If Trim(Len(JobidNo)) = 0 Then Exit Sub
        'AddJobDetails.Close()
        ' If JobDeliverStatus.Trim = "Delivered" Then
        ' JobRepaire.cmbjobst.Enabled = False
        'JobRepaire.txtnamerep.Enabled = False
        'JobRepaire.dpdaterep.Enabled = False
        'JobRepaire.Button1.Enabled = False

        'End If
        JobRepaire.Show()
        JobRepaire.txtjobid.Text = JobidNo
        JobRepaire.txtcomp.Text = Prblmcomp
        JobRepaire.txtremark.Text = REMRK.ToString
        JobRepaire.FetchData()
    End Sub


    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

        MsgBox(DataGridView1.CurrentRow.Cells(columnName:="ID").Value).ToString()

        ReportViewer.JobIDReportView(DataGridView1.CurrentRow.Cells(columnName:="ID").Value, cmbLaser.Text)
        'PrintRecipt.TextBox1.Text = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
        'PrintRecipt.Button1.PerformClick()
        'PrintRecipt.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnprintjob.Click

        If ComboBox1.Text = "Pending With Details" Then
            PrintData(sqlQuery)
        ElseIf ComboBox1.Text = "Basic Report" Then
            PrintDataFull(sqlQuery, cmbjobst.Text, crystalqueryCond)
        Else
            MsgBox("Select Report Type").ToString()
        End If
    End Sub



    Function PrintData(sqlQuery As String)
        Dim SQLAdapter As SqlDataAdapter
        Dim ds As New DataSet2
        Dim dt As New DataTable
        Dim cmd As SqlCommand
        OpenDatabaseObject()


        'MsgBox(sqlQuery)
        Try
            cmd = New SqlCommand(sqlQuery, SQLConn)
            SQLAdapter = New SqlDataAdapter(cmd)
            SQLAdapter.Fill(ds, "job_services")

            'SQLAdapter.Dispose()
            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            report.Load(Application.StartupPath + "\Report\JobPending.rpt")

            Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
            Dim ConnInfo1 As New CrystalDecisions.Shared.ConnectionInfo
            ConnInfo1.UserID = DBUserName
            ConnInfo1.Password = DBPass
            ConnInfo1.ServerName = DBIPAddress
            ConnInfo1.DatabaseName = DBName
            ' report.SetSQLCommandTable(ConnInfo1, "hhhh", sqlQuery)

            objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
            objTableLogonInfo.ConnectionInfo.UserID = DBUserName ' UserIDFromFile
            objTableLogonInfo.ConnectionInfo.Password = DBPass ' PasswordFromFile
            objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress ' ServerNameFromFile
            objTableLogonInfo.ConnectionInfo.DatabaseName = DBName ' DatabaseNameFromFile
            For Each objDatabaseTable In report.Database.Tables
                objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
            Next objDatabaseTable
            report.RecordSelectionFormula = "{job_services.Job_status}='pending'"
            ReportViewer.CrystalReportViewer1.ReportSource = report
            ' report.SetParameterValue("HeadingText", ReportParameter)

            ReportViewer.CrystalReportViewer1.Refresh()
            ReportViewer.Show()
            SQLAdapter.Dispose()
            CloseDatabaseObject()
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Function

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click

        If Lprint.Checked = True Then
            ReportViewer.PrintPrev = False
            ReportViewer.JobIDReportView(DataGridView1.CurrentRow.Cells(columnName:="ID").Value, cmbLaser.Text)
        ElseIf Tprint.Checked = True Then
            frmPrinting.JobId = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
            frmPrinting.JobDate = DataGridView1.CurrentRow.Cells(columnName:="job_date").Value
            frmPrinting.PrinterNm = cmbThermal.SelectedItem
            frmPrinting.typeprinter = Tprint.Text
            frmPrinting.PrintPrev = False
            frmPrinting.Show()
        End If
    End Sub

    Private Sub Lprint_CheckedChanged(sender As Object, e As EventArgs) Handles Lprint.CheckedChanged
        cmbLaser.Visible = True
        cmbThermal.Visible = False
        WriteINI("Printer", "PrinterStatus", Lprint.Text)
    End Sub

    Private Sub Tprint_CheckedChanged(sender As Object, e As EventArgs) Handles Tprint.CheckedChanged
        cmbLaser.Visible = False
        cmbThermal.Visible = True
        WriteINI("Printer", "PrinterStatus", Tprint.Text)
    End Sub

    Private Sub cmbThermal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThermal.SelectedIndexChanged
        'MsgBox(cmbThermal.Text)
        WriteINI("TPrinter", "TPrinterName", cmbThermal.Text)
    End Sub

    Private Sub cmbLaser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLaser.SelectedIndexChanged
        'MsgBox(cmbLaser.Text)
        WriteINI("LPrinter", "LPrinterName", cmbLaser.Text)
    End Sub

    Public Sub UpdateIndividualRow(JobIDUpdate)
        If UpdatedJobID <> 0 Then
            'MsgBox("Update Opertion Is Perform on ID:" & UpdatedJobID & " " & Updated)

            Dim SQLAdapter As SqlClient.SqlDataAdapter
            Dim ds As New DataSet
            OpenDatabaseObject()

            sqlQuery = "Select " & colName & "  from job_services  where ID =" & UpdatedJobID
            'MsgBox(sqlQuery)
            Try

                SQLAdapter = New SqlClient.SqlDataAdapter(sqlQuery, SQLConn)
                SQLAdapter.SelectCommand.ExecuteNonQuery()
                SQLAdapter.Fill(ds, "job_services_table")
                SQLAdapter.Dispose()

                Dim cellindx = 0
                For i As Integer = 0 To DataGridView1.ColumnCount - 1
                    ' MsgBox(rowIndx)
                    DataGridView1.Rows(rowIndx).Cells(cellindx).Value = ds.Tables(0).Rows(0).Item(i)
                    cellindx = cellindx + 1
                Next
                UpdatedJobID = 0
            Catch ex As Exception
                MsgBox(ex.ToString).ToString()
            End Try

        End If
    End Sub



    Function PrintDataFull(sqlQuery As String, status As String, crystalParam As String)
        Dim SQLAdapter As SqlDataAdapter
        Dim ds As New DataSet2
        Dim dt As New DataTable
        Dim cmd As SqlCommand
        OpenDatabaseObject()

        Try
            cmd = New SqlCommand(sqlQuery, SQLConn)
            SQLAdapter = New SqlDataAdapter(cmd)
            SQLAdapter.Fill(ds, "job_services")

            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            report.Load(Application.StartupPath + "\Report\CrystalReport4.rpt")

            dt = ds.Tables(0)

            Dim objTableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo
            Dim ConnInfo1 As New CrystalDecisions.Shared.ConnectionInfo
            ConnInfo1.UserID = DBUserName
            ConnInfo1.Password = DBPass
            ConnInfo1.ServerName = DBIPAddress
            ConnInfo1.DatabaseName = DBName

            objTableLogonInfo = New CrystalDecisions.Shared.TableLogOnInfo
            objTableLogonInfo.ConnectionInfo.UserID = DBUserName ' UserIDFromFile
            objTableLogonInfo.ConnectionInfo.Password = DBPass ' PasswordFromFile
            objTableLogonInfo.ConnectionInfo.ServerName = DBIPAddress ' ServerNameFromFile
            objTableLogonInfo.ConnectionInfo.DatabaseName = DBName ' DatabaseNameFromFile
            For Each objDatabaseTable In report.Database.Tables
                objDatabaseTable.ApplyLogOnInfo(objTableLogonInfo)
            Next objDatabaseTable

            report.RecordSelectionFormula = crystalParam

            ReportViewer.CrystalReportViewer1.ReportSource = report
            report.SetParameterValue("HeadingText", ReportParameter)
            ReportViewer.CrystalReportViewer1.Refresh()
            ReportViewer.Show()
            SQLAdapter.Dispose()
            CloseDatabaseObject()
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Lprint.Checked = True Then
            ReportViewer.PrintPrev = True
            ReportViewer.JobIDReportView(DataGridView1.CurrentRow.Cells(columnName:="ID").Value, cmbLaser.Text)
        ElseIf Tprint.Checked = True Then
            frmPrinting.JobId = DataGridView1.CurrentRow.Cells(columnName:="ID").Value
            frmPrinting.JobDate = DataGridView1.CurrentRow.Cells(columnName:="job_date").Value
            frmPrinting.PrintPrev = True
            frmPrinting.typeprinter = Tprint.Text
            frmPrinting.PrinterNm = cmbThermal.SelectedItem
            frmPrinting.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ReportViewer.CustomerReport(DataGridView1.CurrentRow.Cells(columnName:="customerid").Value)
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Edit / Modify")
            item1.Tag = 1
            AddHandler item1.Click, AddressOf menuChoice
            Dim item2 = cms.Items.Add("Job Repaired")
            item2.Tag = 2
            AddHandler item2.Click, AddressOf menuChoice

            'cms.Show(PictureBox1, e.Location)
        End If
    End Sub
    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        btnupdate.PerformClick()
    End Sub

    Private Sub JobReapairedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobReapairedToolStripMenuItem.Click
        btnjobRepaire.PerformClick()
    End Sub

    Private Sub JobDeliveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobDeliveredToolStripMenuItem.Click
        jobdone.PerformClick()
    End Sub

    Private Sub JobDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobDeleteToolStripMenuItem.Click
        Dim jobID = DataGridView1.CurrentRow.Cells(columnName:="ID").Value.ToString

        If deleteJobID(jobID) = True Then btnshow.PerformClick()


    End Sub

End Class