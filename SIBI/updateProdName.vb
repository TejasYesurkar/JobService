Imports System.Data.SqlClient

Public Class updateProdName
    Public colInx As Integer
    Public rowInx As Integer
    Public FormName As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sql As String
        Dim dataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
        OpenDatabaseObject()
        Try
            sql = "update OtherproductDetails set ProductName='" & txtprodnm.Text & "', SerialNo='" & txtserialno.Text & "' where ID =" & txtprodid.Text

            dataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
            dataAdptr.UpdateCommand.ExecuteNonQuery()

            MsgBox("Updated Successfully").ToString()
            Me.Hide()
            MsgBox(FormName)
            'MsgBox(AddJobDetails.DataGridView2.Rows(rowInx).Cells(1).Value.ToString) '= txtprodnm.Text.ToString
            ' AddJobDetails.DataGridView2.Rows(rowInx).Cells("SerialNo").Value = txtserialno.Text.ToString
            'AddJobDetails.DataGridView2.Rows(rowInx).Cells(1).Value = txtprodnm.Text
            'AddJobDetails.DataGridView2.Rows(rowInx).Cells(2).Value = txtserialno.Text
            MsgBox(AddJobDetails.DataGridView2.Rows(rowInx).Cells(1).Value)
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try

    End Sub

    Private Sub updateProdName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprodid.Enabled = False
        TextBox1.Text = colInx & "," & rowInx & ", " & FormName
    End Sub
End Class