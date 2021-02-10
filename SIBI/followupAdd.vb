Imports System.Data.SqlClient
Public Class followupAdd
	Public LoadPreviousValues As Boolean
	Public LoadValueFromJobID As String
	Public CustName As String
	Public CustMob As String
	Private Sub followupAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Init()
		txtcustnm.AutoCompleteMode = AutoCompleteMode.Suggest
		txtcustnm.AutoCompleteSource = AutoCompleteSource.CustomSource
		txtcustnm.AutoCompleteCustomSource = DataCollectioncmpyName

	End Sub
	Sub Init()
		txtid.Enabled = False
		Cmbreason.Items.Clear()
		addReasonsCmb()
		Label2.Text = "Login User:" & session

		cmbstatus.Items.Clear()
		cmbstatus.Items.Add("Pending")
		cmbstatus.Items.Add("Closed")
		cmbstatus.Items.Add("")
		cmbstatus.Text = "Pending"
		cmbstatus.Enabled = False
		weekDays.Items.Add("None")
		weekDays.Items.Add("Sunday")
		weekDays.Items.Add("Monday")
		weekDays.Items.Add("Tuesday")
		weekDays.Items.Add("Wednesday")
		weekDays.Items.Add("Thrusday")
		weekDays.Items.Add("Friday")
		weekDays.Items.Add("Saturday")
		weekDays.Text = "Sunday"


		LoadAssignName()
		hh.Text = "11"
		mm.Text = "00"
		ss.Text = "00"
		Button1.Text = "AM"
		If LoadPreviousValues = True Then
			txttime.Visible = True
		Else
			txttime.Visible = False
		End If
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
			cmbassign.Text = "All"

		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try
	End Sub

	Sub addReasonsCmb()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select * from [followupstatus]"
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
				Cmbreason.Items.Add(ds.Tables(0).Rows(i).Item(1))
			Next
			Cmbreason.Items.Add("")

		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

	End Sub

	Sub clearTextBox()
		txtid.Clear()
		txtcustnm.Clear()
		txtmob.Clear()
		dpdate.Text = Format(CDate(Now()), "yyyy-MM-dd")
		hh.Text = "11"
		mm.Text = "00"
		ss.Text = "00"
		Button1.Text = "PM"
		Cmbreason.Text = ""
		txtdecs.Clear()
		txtremark.Clear()
	End Sub
	Sub AddData()

		Dim Time = hh.Text & ":" & mm.Text & ":" & ss.Text & " " & Button1.Text

		Dim Swq = "INSERT INTO [ActivityTable] ([customerName],[Mobileno],[ADate],[ATime],[Reason],[status],[decs],[remark],[taskAssign],[createdBy],[createdDate])
				   VALUES('" & txtcustnm.Text & "'," & txtmob.Text & ",'" & Format(CDate(dpdate.Value), "yyyy-MM-dd") & "','" & Time & "','" & Cmbreason.Text & "','" & cmbstatus.Text & "','" & txtdecs.Text & "','" & txtremark.Text & "','" & cmbassign.Text & "','" & session & "','" & Format(Now(), "yyyy-MM-dd") & "')"

		'MsgBox(Swq)
		OpenDatabaseObject()

		Try

			Dim comm As New SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			MsgBox("Row(s) Inserted !! ").ToString()

			btnadd.Text = "Add"

			clearTextBox()
			Me.Close()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

		If checkDate() Then
			AddData()
			ActivityAddForm.Button1.PerformClick()
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
	Private Sub btnupdate_Click(sender As Object, e As EventArgs)

		clearTextBox()
		Me.Close()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Button1.Text = "AM" Then
			Button1.Text = "PM"
		Else
			Button1.Text = "AM"
		End If
	End Sub

	Private Sub btncrm_Click(sender As Object, e As EventArgs) Handles btncrm.Click

		If checkCustomerPresent() = False Then
			Exit Sub
		End If
		'MsgBox(customer_view.Active)
		AddCustomerDetails.btncust_update.Visible = False

		If String.IsNullOrWhiteSpace(txtmob.Text) = False Then
			customer_view.txtsrchstr.Text = txtmob.Text
		End If

		customer_view.Active = True
		customer_view.WhatsAppVIEW = False
		customer_view.ShowDialog()

	End Sub
	Private Function checkCustomerPresent() As Boolean
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0
		'  Dim i As Integer

		OpenDatabaseObject()
		sql = "Select * from Customer_reg where cust_mobile LIKE '%" & txtmob.Text & "%'"
		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "Customer_reg")

			For i = 0 To ds.Tables(0).Rows.Count - 1
				count = count + 1
			Next
			' MsgBox(count)
			If count > 0 Then
				Return True
			Else
				Dim result As Integer = MessageBox.Show("Do You Want Add Customer Details.", "?", MessageBoxButtons.YesNo)
				If result = DialogResult.No Then


				ElseIf result = DialogResult.Yes Then
					AddCustomerDetails.txtmobp.Text = txtmob.Text
					AddCustomerDetails.Show()
					AddCustomerDetails.btncust_update.Visible = False
				End If

				Return False

			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()


		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
			Return False
		End Try
	End Function

End Class