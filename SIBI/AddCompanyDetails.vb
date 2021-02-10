Imports System.Data.SqlClient

Public Class AddCompanyDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Swq = "INSERT INTO CompanyDetails (name,mobileNo,Address)VALUES('" & txtcmpy.Text & "','" & txtmob.Text & "','" & txtAddress.Text & "')"
        OpenDatabaseObject()

        Try

            Dim comm As New SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            MsgBox("Company Add Successfully.!! ").ToString()
            Me.Close()
            '  CloseDatabaseObject()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub

    Private Sub AddCompanyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class