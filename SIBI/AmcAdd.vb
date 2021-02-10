Imports System.Data.SqlClient

Public Class AmcAdd
	Public PrveAMCID As String = 0
	Public customerID As String

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		customer_view.Close()
		If String.IsNullOrWhiteSpace(txtmobile.Text) Then
			customer_view.EnableAutoClick = True
			'customer_view.btncust_update.Enabled = False
			'customer_view.btnshow.Enabled = False
			customer_view.handlerID = Me.Handle
			customer_view.AMCView = True
			customer_view.ShowDialog()
			Exit Sub
		End If

		If txtmobile.Text.Length > 10 Or txtmobile.Text.Length < 10 Then
			MsgBox("Please Enter Valid Number.!!")
			txtcustName.Text = "Please Enter Valid Number.!!"
			Exit Sub
		End If

		If checkCustomerPresent() = False Then
			Exit Sub
		End If
	End Sub
	Private Function checkCustomerPresent() As Boolean
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim count As Integer = 0
		'  Dim i As Integer

		OpenDatabaseObject()
		sql = "Select * from Customer_reg where cust_mobile ='" & txtmobile.Text & "'"
		Try

			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()

			SQLAdapter.Fill(ds, "Customer_reg")

			For i = 0 To ds.Tables(0).Rows.Count - 1
				'txtmob.Text = ds.Tables(0).Rows(i).Item("cust_mobile")
				'txtcustname.Text = ds.Tables(0).Rows(i).Item("cust_name")
				If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("cust_mobile").ToString) Then
					txtmobile.Text = ""
				Else
					customer_view.EnableAutoClick = True
					customer_view.txtsrchstr.Text = txtmobile.Text

					customer_view.handlerID = Me.Handle
					customer_view.WhatsAppVIEW = True
					customer_view.ShowDialog()
				End If


			Next
			count = ds.Tables(0).Rows.Count
			If count > 0 Then
				Return True
			Else
				Dim result As Integer = MessageBox.Show("Do You Want Add Customer Details.", "?", MessageBoxButtons.YesNo)
				If result = DialogResult.No Then


				ElseIf result = DialogResult.Yes Then
					AddCustomerDetails.txtmobp.Text = txtmobile.Text
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

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
		DateTimePicker2.Value = Format(DateTimePicker1.Value.AddDays(365), "yyyy-MM-dd")
	End Sub

	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		DateTimePicker2.Value = Format(DateTimePicker1.Value.AddDays(365 * 2), "yyyy-MM-dd")
	End Sub


	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
		DateTimePicker2.Value = Format(DateTimePicker1.Value.AddDays(365 * 3), "yyyy-MM-dd")
	End Sub

	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

		Dim flag As Boolean = False
		If String.IsNullOrWhiteSpace(txtmobile.Text) Then
			MsgBox("Please Enter Customer Mobile No.").ToString()
			txtmobile.BackColor = WarningBackgound
			Return
		End If
		If String.IsNullOrWhiteSpace(txtcustomer.Text) Then
			MsgBox("Please Enter Customer Name").ToString()
			txtcustomer.BackColor = WarningBackgound
			Return
		End If

		If String.IsNullOrWhiteSpace(txtprod.Text) Then
			MsgBox("Please Enter Product Name").ToString()
			txtprod.BackColor = WarningBackgound
			Return
		End If

		If RadioButton1.Checked = True And flag = False Then
			flag = True
		End If

		If RadioButton2.Checked = True And flag = False Then
			flag = True
		End If

		If RadioButton3.Checked = True And flag = False Then
			flag = True
		End If

		If flag = False Then
			MsgBox("Please Select Years Option").ToString()
			Return
		End If


		Dim Swq = "INSERT INTO [AMC_Table]([Cid],[productName],[startDate],[endDate],[prveAID])VALUES
				(" & customerID & ",'" & txtprod.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'," & PrveAMCID & ")"

		OpenDatabaseObject()
		Try
			Dim comm As New SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			MsgBox("AMC ADDED !! ").ToString()
			Me.Close()
			ActivityAddForm.Button1.PerformClick()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
	End Sub

	Private Sub AmcAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	End Sub

	Private Sub AmcAdd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		txtcustName.Text = ""
		txtcustomer.Text = ""
		txtmobile.Text = ""
		PrveAMCID = 0
	End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub

	Private Sub txtmobile_TextChanged(sender As Object, e As EventArgs) Handles txtmobile.TextChanged
		txtmobile.BackColor = WhiteBackgound
	End Sub

	Private Sub txtcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtcustomer.TextChanged
		txtcustomer.BackColor = WhiteBackgound
	End Sub

	Private Sub txtprod_TextChanged(sender As Object, e As EventArgs) Handles txtprod.TextChanged
		txtprod.BackColor = WhiteBackgound
	End Sub
End Class