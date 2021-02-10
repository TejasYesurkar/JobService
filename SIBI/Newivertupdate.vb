Imports System.Data.SqlClient

Public Class Newivertupdate
    Public JobID As String
    Public LoadPreviousValues As String
    Public LoadValueFromJobID As String
    Public Loading As Boolean = True

    Private Sub Newivertupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RepairerNameAuto()
        DataGridView1.Columns.Clear()
        datagridFormat()
        LoadCmbStatus()
        If LoadPreviousValues = True Then
            datagridLoad(LoadValueFromJobID)

        End If
        txtRep.AutoCompleteMode = AutoCompleteMode.Suggest
        txtRep.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtRep.AutoCompleteCustomSource = DataCollectionRepairerName
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
            cmbjobst.Items.Clear()
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
    Private Sub datagridFormat()
        DataGridView1.Columns.Clear()
        Dim dgvProdid As New DataGridViewTextBoxColumn()
        dgvProdid.HeaderText = "ProdID"

        Dim dgvinid As New DataGridViewTextBoxColumn()
        dgvinid.HeaderText = "InID"

        Dim dgvProdnm As New DataGridViewTextBoxColumn()
        dgvProdnm.HeaderText = "ProductName"
        Dim dgvSerila As New DataGridViewTextBoxColumn()
        dgvSerila.HeaderText = "SerialNo."
        Dim dgvoutID As New DataGridViewTextBoxColumn()
        dgvoutID.HeaderText = "Charge"
        Dim OutDate As New DataGridViewTextBoxColumn()
        OutDate.HeaderText = "OutDate"
        Dim RepairedMan As New DataGridViewTextBoxColumn()
        RepairedMan.HeaderText = "RepairedMan"
        Dim Retsatus As New DataGridViewTextBoxColumn()
        Retsatus.HeaderText = "Job Status"

        Dim ReturnRemark As New DataGridViewTextBoxColumn()
        ReturnRemark.HeaderText = "Return Remark"
        Dim dgvCheck As New DataGridViewCheckBoxColumn()
        dgvCheck.HeaderText = "CheckBox"
        Dim dgvClear As New DataGridViewButtonColumn()
        dgvClear.HeaderText = "Action"

        DataGridView1.Columns.Add(dgvCheck)
        DataGridView1.Columns.Add(dgvProdid)
        DataGridView1.Columns.Add(dgvProdnm)
        DataGridView1.Columns.Add(dgvSerila)
        DataGridView1.Columns.Add(RepairedMan)
        DataGridView1.Columns.Add(OutDate)
        DataGridView1.Columns.Add(dgvoutID)
        DataGridView1.Columns.Add(Retsatus)
        DataGridView1.Columns.Add(ReturnRemark)
        DataGridView1.Columns.Add(dgvinid)
        DataGridView1.Columns.Add(dgvClear)

        dgvinid.Visible = False



        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)

    End Sub
    Sub datagridLoad(Jobid As String)
        Dim sqldbAdapter As SqlDataAdapter
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim sql As String
        ' MsgBox(Jobid)
        Dim Flag As Boolean = False
        DataGridView1.Rows.Clear()


        OpenDatabaseObject()


        sql = "Select OutID,OutDate,ProductName,RetrunStatus,SerialNo,ReturnRemark,final_amt_taken,InID,RepaireName from OutSrcProductDetails where Jobid =" & txtjobid.Text & ""
        'MsgBox(sql)

        Try
            'connection.Open()
            sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            sqldbAdapter.SelectCommand.ExecuteNonQuery()
            sqldbAdapter.Fill(ds)
            sqldbAdapter.Dispose()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim OutID = ds.Tables(0).Rows(i).Item(columnName:="OutID")
                Dim ProdName = ds.Tables(0).Rows(i).Item(columnName:="ProductName")
                Dim SerialNo = ds.Tables(0).Rows(i).Item(columnName:="SerialNo")
                Dim charge = ds.Tables(0).Rows(i).Item(columnName:="final_amt_taken")
                Dim Repman = ds.Tables(0).Rows(i).Item(columnName:="RepaireName")
                Dim outdate = ds.Tables(0).Rows(i).Item(columnName:="OutDate")
                Dim ReturnRemark = ds.Tables(0).Rows(i).Item(columnName:="ReturnRemark")
                Dim RetrunStatus = ds.Tables(0).Rows(i).Item(columnName:="RetrunStatus")
                Dim InID = ds.Tables(0).Rows(i).Item(columnName:="InID")
                Dim Action As String
                If String.IsNullOrWhiteSpace(SerialNo) Then
                    SerialNo = ""
                End If
                If (RetrunStatus = "Pending") Then
                    Action = "Clear"
                Else
                    Action = "Already IN"
                End If

                DataGridView1.Rows.Add(Flag, OutID, ProdName, SerialNo, Repman, outdate, charge, RetrunStatus, ReturnRemark, InID, Action)

                If (RetrunStatus = "Pending") = False Then
                    DataGridView1.Rows(i).ReadOnly = True
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = deliveryLightBlue
                    DataGridView1.Rows(i).Cells(0).Value = False
                End If
            Next

            sqldbAdapter.Dispose()
            CloseDatabaseObject()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnfetch_Click(sender As Object, e As EventArgs)
        datagridLoad(txtjobid.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If (e.ColumnIndex.ToString() = 0) Then

            If String.IsNullOrWhiteSpace(txtRep.Text) Or String.IsNullOrWhiteSpace(txtamt.Text) Then

                MsgBox("Please Enter The Repaireman Name and Charge Amt ..", vbOKOnly + vbExclamation).ToString()
                txtRep.Focus()
                txtamt.BackColor = WarningBackgound
                txtRep.BackColor = WarningBackgound

                DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False

            ElseIf String.IsNullOrWhiteSpace(cmbjobst.Text) Then
                MsgBox("Please Select Job Status Of Product..", vbOKOnly + vbExclamation).ToString()
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False
            ElseIf String.IsNullOrWhiteSpace(txtremk.Text) Then
                MsgBox("Please Enter In - Remark Of Product..", vbOKOnly + vbExclamation).ToString()
                txtremk.Focus()
                txtremk.BackColor = WarningBackgound
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value = False

            End If
        End If


        If (e.ColumnIndex.ToString() = 0) Then
            If DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value = "Pending" Then
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(6).Value = txtamt.Text
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(5).Value = Format(CDate(DateTimePicker1.Value), "dd-MMM-yyyy")
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value = cmbjobst.Text
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(8).Value = txtremk.Text
                DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value = txtRep.Text

            End If
        End If

        If (e.ColumnIndex.ToString() = 10) Then

            If DataGridView1.Rows(e.RowIndex.ToString()).Cells(10).Value = "Clear" Then

                Dim result1 As Integer = MessageBox.Show(" You Really Want To Clear data", "?", MessageBoxButtons.YesNo)
                If result1 = DialogResult.No Then
                    Exit Sub
                ElseIf result1 = DialogResult.Yes Then
                    DataGridView1.Rows(e.RowIndex.ToString()).Cells(6).Value = "00"
                    DataGridView1.Rows(e.RowIndex.ToString()).Cells(5).Value = ""
                    DataGridView1.Rows(e.RowIndex.ToString()).Cells(7).Value = "Pending"
                    DataGridView1.Rows(e.RowIndex.ToString()).Cells(8).Value = ""
                    DataGridView1.Rows(e.RowIndex.ToString()).Cells(4).Value = ""

                Else
                    'MsgBox("Product is already Delivered.", vbOKOnly)
                End If


            End If
        End If

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim temp As Boolean = False
        For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(RCnt).Cells(0).Value = True Then
                temp = True
            End If
        Next
        If temp = False Then
            MsgBox("Please Select Product From list to invert").ToString()
            Exit Sub
        End If
        OpenDatabaseObject()
        For RCnt As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(RCnt).Cells(0).Value = True Then
                Dim Outid = DataGridView1.Rows(RCnt).Cells(1).Value
                Dim Prodname = DataGridView1.Rows(RCnt).Cells(2).Value
                Dim Repaireman = DataGridView1.Rows(RCnt).Cells(4).Value
                Dim Retstatus = DataGridView1.Rows(RCnt).Cells(7).Value
                Dim RetRemark = DataGridView1.Rows(RCnt).Cells(8).Value
                Dim RetDate = DataGridView1.Rows(RCnt).Cells(5).Value
                Dim Chrge = DataGridView1.Rows(RCnt).Cells(6).Value
                Dim INID = DataGridView1.Rows(RCnt).Cells(9).Value

                Dim Sql = "Update OutSrcProductDetails set Retrun='" & Format(CDate(RetDate), "yyyy-MM-dd") & "',RetrunStatus ='" & Retstatus & "',ReturnRemark ='" & RetRemark & "',ReceiverName ='" & session & "',final_amt_taken=" & Chrge & " where ProductName ='" & Prodname & "' and OutID = '" & Outid & "'"
                Dim Sql2 = "update OtherproductDetails Set statusRep ='True',RepairStatus='" & cmbjobst.Text & "',ProdRepairedDate='" & Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd") & "',ChrageableAmt=" & Chrge & ", RepairMan='" & txtRep.Text & "',Outward='False' ,ProdINSrcDate='" & Format(CDate(RetDate), "yyyy-MM-dd") & "'  where ProductName = '" & Prodname & "' And ID = '" & INID & "'"


                Dim Sql3 = "update job_services set Job_status='" & cmbjobst.Text & "',RepaireDone_by='" & txtRep.Text & "',Repaire_Done='" & txtreppart.Text & "',date_repaire='" & Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd") & "' where ID = " & txtjobid.Text & ""

                Dim comm As New SqlClient.SqlCommand(Sql, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                comm = New SqlClient.SqlCommand(Sql2, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                comm = New SqlClient.SqlCommand(Sql3, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
            End If
        Next

        MsgBox("Inverts Sucessfully").ToString()
        Me.Close()
        inverted_Form.btnfetch.PerformClick()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        datagridLoad(txtjobid.Text)
    End Sub

    Private Sub txtRep_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRep.KeyUp
        txtRep.BackColor = WhiteBackgound
    End Sub

    Private Sub txtamt_KeyUp(sender As Object, e As KeyEventArgs) Handles txtamt.KeyUp
        txtamt.BackColor = WhiteBackgound
    End Sub
End Class