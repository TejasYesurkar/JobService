Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Registration
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If

		Try

			Dim Swq = "INSERT INTO Login (username,pswd,role)
                    VALUES('" & txtuser.Text & "','" & txtpswd.Text & "','admin')"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()

			MsgBox("User " & txtuser.Text & " registered successfully.").ToString()
			Me.Close()

		Catch ex As Exception
			MsgBox(ex.ToString)
        End Try
        CloseDatabaseObject()

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs)

		Me.Hide()

		Show()

	End Sub

	Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class