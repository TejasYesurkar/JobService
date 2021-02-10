Public Class AddActivtyItem


	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If

		Try

			Dim Swq = "INSERT INTO followupstatus (status)
                    VALUES('" & txtitem.Text & "')"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()

			MsgBox("Add Sucessfully!! ").ToString()
			Me.Close()

		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
		CloseDatabaseObject()

	End Sub

	Private Sub txtitem_TextChanged(sender As Object, e As EventArgs) Handles txtitem.TextChanged

	End Sub

	Private Sub Lable1_Click(sender As Object, e As EventArgs) Handles Lable1.Click

	End Sub
End Class