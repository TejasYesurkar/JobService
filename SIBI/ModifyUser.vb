Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ModifyUser
	Private Sub ModifyUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtuser.Text = session
		txtuser.Enabled = True

	End Sub

	Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

		If checkOldPswd(txtold.Text) = True Then

			UpdatePswd(txtnewpswd.Text)
		Else
			MsgBox("Old Password Is Not Match.!")
			txtold.BackColor = Color.LightYellow
		End If

	End Sub

	Public Sub UpdatePswd(usernm As String)

		If String.Compare(txtconfirm.Text, txtnewpswd.Text) = 0 Then

			MsgBox("New Password And Confirm Password Not Match.!")
			Exit Sub
		End If
		Dim ds As New DataSet
		Dim sql As String
		sql = "update login set pswd='" & txtnewpswd.Text & "' where username = " & session & ""

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If
		Dim sqldataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			'   SQLConn.Open()
			sqldataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
			sqldataAdptr.UpdateCommand.ExecuteNonQuery()
			MsgBox("Password updated Succesfully!! ").ToString()
			Me.Close()

		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try

	End Sub
	Public Function checkOldPswd(usernm As String) As Boolean

		checkOldPswd = False
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select pswd from login Where username= " & txtuser.Text & " and pswd =" & txtold.Text & ""

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Function
		End If
		SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
		SQLAdapter.SelectCommand.ExecuteNonQuery()
		SQLAdapter.Fill(ds, "Login_table")
		If (ds.Tables(0).Rows.Count) = 0 Then
			checkOldPswd = False
		Else
			checkOldPswd = True
		End If
		'Return OldPswdChcek()
	End Function

End Class