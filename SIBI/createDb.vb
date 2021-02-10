Imports System.Data.SqlClient

Public Class createDb
    Public ipAddress As String

    Private Sub createDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CreateDatabase(DatabaseName As String, ServerName As String)

        Try
            Dim conStr As String = "Server=" & ServerName & ";Database=;Trusted_Connection = yes"
            Dim objCon As New SqlConnection(conStr)
            objCon.Open()
            Dim obj As SqlCommand
            Dim strSQL As String
            obj = objCon.CreateCommand()
            strSQL = "CREATE DATABASE " & DatabaseName
            ' Execute

            obj.CommandText = strSQL
            obj.ExecuteNonQuery()
            objCon.Close()

            'Create NEW Blank Database
            MsgBox("Database Created : " & DatabaseName).ToString()
            WriteINI("SqlServer", "DbName", DatabaseName)
            Login.FectchListofDataBases(ipAddress)
            'Create Tables for New Database
            DBName = DatabaseName
            Login.CheckTablesPresentOrNot(False)
            MsgBox("Verified database tables structures, and created missing tables.").ToString()

            Login.btnapply.Enabled = True
            Login.txtdbName.Visible = False
            Login.cmbDataBase.Visible = True
            Me.Hide()
        Catch ex As Exception
            Me.Hide()
            MsgBox("Please check your IP Address / Domain Name.").ToString()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateDatabase(TextBox1.Text, ipAddress)
    End Sub
End Class