Imports System.Data.SqlClient

Public Class InvertProdView
    Public LoadValueFromJobID As Double
    Public LoadJobID As Double
    Public LoadPreviousValues As Boolean
    Private Sub InvertProdView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If LoadPreviousValues = True Then
            loadvalues(LoadValueFromJobID)

        End If
        formatedata()
    End Sub

    Private Sub formatedata()
        txtamt.ReadOnly = True
        txtestval.ReadOnly = True
        txtjobid.ReadOnly = True
        txtjobstatus.ReadOnly = True
        txtoutremark.ReadOnly = True
        txtprodid.ReadOnly = True
        txtprodName.ReadOnly = True
        txtrepairMan.ReadOnly = True
        txtretrunremark.ReadOnly = True
        txtserialno.ReadOnly = True
        txtretrunremark.ReadOnly = True
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False

    End Sub

    Private Sub loadvalues(loadValueFromJobID As Double)
        Dim sqldbAdapter1 As SqlDataAdapter
        Dim ds, ds2, d3 As New DataSet
        Dim Sql2 As String


        OpenDatabaseObject()

        Sql2 = "SELECT ID,Jobid,ProductName,SerialNo,OutDate,RepairMan,RepairStatus
      ,ProdOutSrcDate,ProdOutSrcDate FROM OtherproductDetails where ID = " & loadValueFromJobID

        Dim Sql3 = "SELECT OutPersonName,ReturnRemark,final_amt_taken,RepaireName,estimated_value,OutProduRemark,Retrun,RetrunStatus FROM OutSrcProductDetails where InID = " & loadValueFromJobID
        Dim sql = "SELECT Job_status,mobile,job_date,cust_name,prblm_comp,prblm_observe FROM job_services where ID=" & LoadJobID
        Try

            'MsgBox(Sql2)
            sqldbAdapter1 = New SqlClient.SqlDataAdapter(Sql2, SQLConn)
            sqldbAdapter1.Fill(ds, "job_services_table")

            sqldbAdapter1 = New SqlClient.SqlDataAdapter(sql, SQLConn)
            sqldbAdapter1.Fill(d3, "job_services_table")

            sqldbAdapter1 = New SqlClient.SqlDataAdapter(Sql3, SQLConn)
            sqldbAdapter1.Fill(ds2, "job_services_table")
            If ds.Tables(0).Rows.Count > 0 Then


                txtcustomername.Text = d3.Tables(0).Rows(0).Item("cust_name") & "(" & d3.Tables(0).Rows(0).Item("mobile") & ")"

                txtprblmcomp.Text = d3.Tables(0).Rows(0).Item("prblm_comp")
                txtprblcomp.Text = d3.Tables(0).Rows(0).Item("prblm_observe")


                txtprodid.Text = ds.Tables(0).Rows(0).Item("ID")
                txtjobid.Text = ds.Tables(0).Rows(0).Item("Jobid")
                txtretrunstatus.Text = ds2.Tables(0).Rows(0).Item("RetrunStatus")
                txtjobstatus.Text = "pending"

                txtrepairMan.Text = ds.Tables(0).Rows(0).Item("RepairMan")
                txtrep.Text = ds.Tables(0).Rows(0).Item("RepairMan")
                txtprodName.Text = ds.Tables(0).Rows(0).Item("ProductName")
                Dim STR = ds2.Tables(0).Rows(0).Item("ReturnRemark").ToString
                txtestval.Text = ds2.Tables(0).Rows(0).Item("estimated_value").ToString
                txtoutremark.Text = ds2.Tables(0).Rows(0).Item("OutProduRemark").ToString
                txtserialno.Text = ds.Tables(0).Rows(0).Item("SerialNo")
                txtoutby.Text = ds2.Tables(0).Rows(0).Item("OutPersonName")
                txtinby.Text = ds2.Tables(0).Rows(0).Item("OutPersonName")


                If String.IsNullOrEmpty(ds.Tables(0).Rows(0).Item("ProdOutSrcDate").ToString) Then

                Else
                    DateTimePicker1.Text = CDate(ds.Tables(0).Rows(0).Item("ProdOutSrcDate"))
                End If



                If String.IsNullOrEmpty(ds2.Tables(0).Rows(0).Item("Retrun").ToString) Then

                    DateTimePicker2.Hide()
                Else
                    Label12.Show()
                    DateTimePicker2.Show()
                    DateTimePicker2.Text = CDate(ds2.Tables(0).Rows(0).Item("Retrun"))
                End If

                If String.IsNullOrEmpty(STR) Then
                    txtretrunremark.Text = ""
                Else
                    txtretrunremark.Text = ds2.Tables(0).Rows(0).Item("ReturnRemark")
                End If

                txtamt.Text = ds2.Tables(0).Rows(0).Item("final_amt_taken").ToString
                txtretrunremark.Text = ds2.Tables(0).Rows(0).Item("ReturnRemark").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString()).ToString()
        End Try
    End Sub

End Class