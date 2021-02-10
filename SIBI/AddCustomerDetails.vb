Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class AddCustomerDetails
    Private Sub popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim sqldbAdapter As SqlDataAdapter
		Dim ds As New DataSet
        Dim sql As String

		txtjobpid.Enabled = False
		OpenDatabaseObject()


		sql = "Select * from job_services where cust_id=" & AddJobDetails.txtmob.Text
        ' MsgBox(sql)
        Try

			sqldbAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.SelectCommand.ExecuteNonQuery()
			sqldbAdapter.Fill(ds)
			sqldbAdapter.Dispose()
			CloseDatabaseObject()

			txtjobpid.Text = ds.Tables(0).Rows(0).Item(0)
            txtmobp.Text = ds.Tables(0).Rows(0).Item(1)
            txtcustpname.Text = ds.Tables(0).Rows(0).Item(3)
			txtemailp.Text = ds.Tables(0).Rows(0).Item(13)
			txtmob2.Text = ds.Tables(0).Rows(0).Item(5)
		Catch ex As Exception
            ' MsgBox(ex.ToString())


        End Try
    End Sub


	Public Sub loadvalues(jobid As Double)

        customer_view.Hide()

		Dim sqldbAdapter As SqlDataAdapter

		Dim ds As New DataSet
        Dim sql As String

		' btnsave.Enabled = True


		OpenDatabaseObject()


		sql = "Select * from customer_reg where cust_id =" & jobid


        Try

			sqldbAdapter = New SqlDataAdapter(sql, SQLConn)
			sqldbAdapter.Fill(ds)

			txtjobpid.Text = ds.Tables(0).Rows(0).Item(0)
            txtcustpname.Text = ds.Tables(0).Rows(0).Item(1)
			txtmobp.Text = ds.Tables(0).Rows(0).Item(columnName:="cust_mobile")
			txtemailp.Text = ds.Tables(0).Rows(0).Item(3)
			txtaddrs.Text = ds.Tables(0).Rows(0).Item(4)
			txtmob2.Text = ds.Tables(0).Rows(0).Item(columnName:="Secondmobile")

			CloseDatabaseObject()

		Catch ex As Exception
			MsgBox("Can not open connection ! ").ToString()
		End Try


		'   Form.txtvalue.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
		'   Form1.dpestrepaire.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
		'   Form.txtrepairdone.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
		'   Form.cmbjobstatus.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
		'   Form.ShowDialog()

	End Sub



    Private Sub txtcustname(sender As Object, e As EventArgs)
        txtcustpname.BackColor = Color.FromArgb(125, 235, 250)
        txtmobp.BackColor = Color.White
        txtemailp.BackColor = Color.White
        txtaddrs.BackColor = Color.White

    End Sub

    Private Sub txtcust_mob(sender As Object, e As EventArgs)
        txtcustpname.BackColor = Color.White
        txtmobp.BackColor = Color.FromArgb(125, 235, 250)
        txtemailp.BackColor = Color.White
        txtaddrs.BackColor = Color.White
    End Sub

    Private Sub txtemail(sender As Object, e As EventArgs)
        txtcustpname.BackColor = Color.White
        txtmobp.BackColor = Color.White
        txtemailp.BackColor = Color.FromArgb(125, 235, 250)
        txtaddrs.BackColor = Color.White
    End Sub

    Private Sub txtadd(sender As Object, e As EventArgs)
        txtcustpname.BackColor = Color.White
        txtmobp.BackColor = Color.White
        txtemailp.BackColor = Color.White
        txtaddrs.BackColor = Color.FromArgb(125, 235, 250)
    End Sub

    Private Sub btncust_update_Click_1(sender As Object, e As EventArgs) Handles btncust_update.Click


        Dim ds As New DataSet
        Dim sql As String

		OpenDatabaseObject()
		sql = "update Customer_reg set cust_name='" & txtcustpname.Text & "',cust_mobile=" & txtmobp.Text & ",cust_email='" & txtemailp.Text & "',cust_address='" & txtaddrs.Text & "',CompanyName='" & txtcmpnay.Text & "',Secondmobile='" & txtmob2.Text & "' where cust_id = " & txtjobpid.Text & ""
		Dim sqldataAdptr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Try
			sqldataAdptr.UpdateCommand = New SqlCommand(sql, SQLConn)
			sqldataAdptr.UpdateCommand.ExecuteNonQuery()
			MsgBox("Row(s) updated !! ").ToString()
        Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

		Me.Close()

	End Sub

	Private Sub btnok_Click_1(sender As Object, e As EventArgs) Handles btnok.Click

		Dim jid As Integer = Val(txtjobpid.Text)
		Dim cust_name As String = Trim(txtcustpname.Text)
		Dim mobile As Double = Val(txtmobp.Text)
		Dim mobile2 As Double = Val(txtmob2.Text)
		Dim address As String = Trim(txtaddrs.Text)
		Dim email As String = Trim(txtemailp.Text)
		Dim cmpnyName As String = Trim(txtcmpnay.Text)

		If checkCustomerNameAvilable() = False Then
			Dim result As Integer = MessageBox.Show("This Phone Number Is Already Present", "Alert", MessageBoxButtons.OK)

			Exit Sub

		End If
		If checkCustomerNameAvilable() = False Then
			Dim result As Integer = MessageBox.Show("Same Name Of Customer Avilable .Do You Want Add Same name Customer Details.?", "Alert", MessageBoxButtons.YesNo)
			If result = DialogResult.No Then
				Exit Sub
			End If
		End If
		Dim Swq = "INSERT INTO Customer_reg (cust_name,cust_mobile,cust_email,cust_address,CompanyName,Secondmobile)
                   VALUES('" & cust_name & "'," & mobile & ",'" & email & "','" & address & "','" & cmpnyName & "','" & mobile2 & "')"
		OpenDatabaseObject()

		Try

			Dim comm As New SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			MsgBox("Row(s) Inserted !! ").ToString()
			'   Me.Hide()
			'  CloseDatabaseObject()
			Me.Close()

		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		OpenDatabaseObject()


	End Sub

	Function checkCustomerMobAvilable() As Boolean

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select * from customer_reg where cust_mobile='" & Trim(txtmobp.Text) & "'"

		Try
			OpenDatabaseObject()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			ds.Dispose()
			SQLAdapter.Dispose()
			CloseDatabaseObject()
			Dim count = ds.Tables(0).Rows.Count
			If count > 0 Then
				Return False
			Else
				Return True
			End If
		Catch ex As Exception
			MsgBox(ex).ToString()
			Return False
		End Try
	End Function
	Function checkCustomerNameAvilable() As Boolean


		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		sql = "Select * from customer_reg where cust_name='" & Trim(txtcustpname.Text) & "'"

		Try
			OpenDatabaseObject()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "customer_reg")
			ds.Dispose()
			SQLAdapter.Dispose()
			CloseDatabaseObject()
			Dim count = ds.Tables(0).Rows.Count

			If count > 0 Then
				Return False
			Else
				Return True
			End If

		Catch ex As Exception
			MsgBox(ex).ToString()
			Return False
		End Try


	End Function
	Private Sub AllTextBoxes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
    Handles _
        txtcustpname.KeyDown,
        txtaddrs.KeyDown,
        txtemailp.KeyDown,
        txtmobp.KeyDown,
        btnok.KeyDown


        If e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If
    End Sub

	Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

	End Sub


End Class
