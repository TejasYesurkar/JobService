Imports System.Data.SqlClient

Public Class UpdateFollowup
	Public Res As String
	Public Status As String

	Private Sub UpdateFollowup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dpclosedate.Text = Format(Now(), "yyyy-MM-dd")

		LoadAssignName()
		weekDays.Items.Add("None")
		weekDays.Items.Add("Sunday")
		weekDays.Items.Add("Monday")
		weekDays.Items.Add("Tuesday")
		weekDays.Items.Add("Wednesday")
		weekDays.Items.Add("Thrusday")
		weekDays.Items.Add("Friday")
		weekDays.Items.Add("Saturday")
		weekDays.Text = "Sunday"

	End Sub
	Sub LoadAssignName()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select * from [login]"
		Try
			OpenDatabaseObject()
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			ds.Dispose()
			SQLAdapter.Dispose()
			CloseDatabaseObject()
			For i = 0 To ds.Tables(0).Rows.Count - 1
				cmbassign.Items.Add(ds.Tables(0).Rows(i).Item(1))
			Next
			cmbassign.Items.Add("All")
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try
	End Sub

	Sub UpdateData()


		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()

		sql = "UPDATE ActivityTable SET [status]='Closed',[remark] ='" & txtremark.Text & "',CloseTime='" & txttime.Text & "',CloseDate='" & dpclosedate.Text & "'  WHERE Aid =" & txtid.Text & ""

		'MsgBox(sql)
		Dim sqldataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			'SQLConn.Open()
			sqldataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
			sqldataAdptr.UpdateCommand.ExecuteNonQuery()
			MsgBox("Row(s) updated !! ").ToString()

		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

	End Sub

	Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
		If String.IsNullOrWhiteSpace(txtremark.Text) Then
			MsgBox("Please Enter the Remark")
			Exit Sub
		End If

		UpdateData()
		ActivityAddForm.Button1.PerformClick()
		If nxtfollow.Checked = True Then
			If checkDate() Then
				AddData()
			End If

		End If
	End Sub
	Private Function checkDate() As Boolean

		Try

			If CDate(dpdate.Text).ToString("dddd").Equals(weekDays.Text.ToString) = True Then
				MsgBox("Please Select Another Date").ToString()
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

		Return True
	End Function
	Sub AddData()
		Dim Time = hh.Text & ":" & mm.Text & ":" & ss.Text & " " & Button2.Text
		Dim Swq = "INSERT INTO [ActivityTable] ([customerName],[Mobileno],[ADate],[ATime],[Reason],[status],[decs],[remark],[PreviousID],[taskAssign],[createdBy],[createdDate])
				   VALUES('" & txtcustnm.Text & "'," & txtmob.Text & ",'" & Format(CDate(DateTimePicker1.Value), "yyyy-MM-dd") & "','" & Time & "','" & Res & "','Pending','" & txteditDesc.Text & "','" & txtremark.Text & "'," & txtid.Text & ",'" & cmbassign.Text & "','" & session & "','" & Format(Now(), "yyyy-MM-dd") & "')"

		'MsgBox(Swq)
		OpenDatabaseObject()

		Try

			Dim comm As New SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			MsgBox("Row(s) Inserted !! ").ToString()

			Me.Close()
			ActivityAddForm.Button1.PerformClick()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	Private Sub nxtfollow_CheckedChanged_1(sender As Object, e As EventArgs) Handles nxtfollow.CheckedChanged
		If nxtfollow.Checked = True Then
			GroupBox2.Visible = True
			txteditDesc.Text = txtdecs.Text
		Else
			GroupBox2.Visible = False
		End If
	End Sub

	Private Sub txtdays_LostFocus(sender As Object, e As EventArgs) Handles txtdays.LostFocus

		If String.IsNullOrWhiteSpace(txtdays.Text) = False Then
			Dim Days = txtdays.Text

			DateTimePicker1.Value = Format(DateTime.Now.AddDays(Days), "yyyy-MM-dd")

		End If

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If Button2.Text = "AM" Then
			Button2.Text = "PM"
		Else
			Button2.Text = "AM"
		End If
	End Sub

	Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

	End Sub

	Private Sub cmbassign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbassign.SelectedIndexChanged

	End Sub
End Class