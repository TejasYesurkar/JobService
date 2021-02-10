Imports System.Data.SqlClient

Public Class config
    Public role As String
    Public WhatsAppID As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text.Trim = "Save" Then
            AddCompany()
        Else
            UpdateCompnay()

        End If
    End Sub

    Private Sub UpdateCompnay()
        Dim Swq = "Update CompanyDetails set name='" & txtcmpy.Text & "',mobileNo='" & txtmob.Text & "',Address='" & txtAddress.Text & "'"
        OpenDatabaseObject()

        Try

            Dim comm As New SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            MsgBox("Company Updated Successfully.!! ").ToString()
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub

    Private Sub AddCompany()
        Dim Swq = "INSERT INTO CompanyDetails (name,mobileNo,Address)VALUES('" & txtcmpy.Text & "','" & txtmob.Text & "','" & txtAddress.Text & "')"
        OpenDatabaseObject()

        Try
            Dim comm As New SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            MsgBox("Company Add Successfully.!! ").ToString()


        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub
    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lableold.Visible = False
        txtoldpswd.Visible = False
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Thermal Print")
        ComboBox1.Items.Add("Laser Print")
        ComboBox1.Text = "Thermal Print"
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Legal")
        ComboBox2.Items.Add("A4")
        ComboBox2.Items.Add("A5")
        If onCompanyDetailsLoad() = True Then
            Button1.Text = "Update"
        End If
        txtport.Text = ReadINI("PortNo", "Port", "")
        txturl.Text = ReadINI("PortNo", "url", "")
        DataGridFormatLoad()
    End Sub
    Sub addUserlist()
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "Select * from [login]"
        Try
            DataGridView3.Rows.Clear()


            OpenDatabaseObject()
            '  connection.Open()
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "customer_reg")
            ds.Dispose()
            SQLAdapter.Dispose()

            ' DataGridView1.Rows.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i).Item("role") <> "admin" Then
                    DataGridView3.Rows.Add(ds.Tables(0).Rows(i).Item("id"), ds.Tables(0).Rows(i).Item("username"), ds.Tables(0).Rows(i).Item("role"), "Remove")
                Else
                    DataGridView3.Rows.Add(ds.Tables(0).Rows(i).Item("id"), ds.Tables(0).Rows(i).Item("username"), ds.Tables(0).Rows(i).Item("role"), "Delete")
                End If

            Next
            'Cmbreason.Items.Add("")

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

            DataGridView1.Rows.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                DataGridView1.Rows.Add(ds.Tables(0).Rows(i).Item("fid"), ds.Tables(0).Rows(i).Item("status"), "Remove")
            Next
            'Cmbreason.Items.Add("")

        Catch ex As Exception
            MsgBox(ex).ToString()
        End Try

    End Sub
    Sub addStatus()
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "Select * from [Status]"
        Try

            OpenDatabaseObject()
            '  connection.Open()
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "customer_reg")
            ds.Dispose()
            SQLAdapter.Dispose()

            DataGridView2.Rows.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item("ID"), ds.Tables(0).Rows(i).Item("status"), "Remove")
            Next
            'Cmbreason.Items.Add("")

        Catch ex As Exception
            MsgBox(ex).ToString()
        End Try

    End Sub
    Private Sub DataGridFormatLoad()
        DataGridView1.Columns.Clear()

        Dim dgvjobid As New DataGridViewTextBoxColumn()
        dgvjobid.HeaderText = "ID"
        Dim dgvoutid As New DataGridViewTextBoxColumn()
        dgvoutid.HeaderText = "FollowUp Reason"

        Dim dvgchng As New DataGridViewButtonColumn()
        dvgchng.HeaderText = "Action"


        DataGridView1.Columns.Add(dgvjobid)
        DataGridView1.Columns.Add(dgvoutid)
        DataGridView1.Columns.Add(dvgchng)

        dgvoutid.Width = 240
        dgvjobid.Width = 40

        '	DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)


        DataGridView2.Columns.Clear()

        Dim dgvjobid2 As New DataGridViewTextBoxColumn()
        dgvjobid2.HeaderText = "ID"
        Dim dgvoutid2 As New DataGridViewTextBoxColumn()
        dgvoutid2.HeaderText = "Job Status"

        Dim dvgchng2 As New DataGridViewButtonColumn()
        dvgchng2.HeaderText = "Action"


        DataGridView2.Columns.Add(dgvjobid2)
        DataGridView2.Columns.Add(dgvoutid2)
        DataGridView2.Columns.Add(dvgchng2)

        dgvoutid2.Width = 240
        dgvjobid2.Width = 40

        '	DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.ReadOnly = True
        DataGridView2.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)



        DataGridView3.Columns.Clear()

        Dim dgvjobid3 As New DataGridViewTextBoxColumn()
        dgvjobid3.HeaderText = "ID"
        Dim dgvoutid3 As New DataGridViewTextBoxColumn()
        dgvoutid3.HeaderText = "Username"

        Dim dgvoutid33 As New DataGridViewTextBoxColumn()
        dgvoutid33.HeaderText = "Role"


        Dim dvgchng3 As New DataGridViewButtonColumn()
        dvgchng3.HeaderText = "Action"


        DataGridView3.Columns.Add(dgvjobid3)
        DataGridView3.Columns.Add(dgvoutid3)
        DataGridView3.Columns.Add(dgvoutid33)
        DataGridView3.Columns.Add(dvgchng3)

        dgvoutid3.Width = 180
        dgvjobid3.Width = 40

        '	DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.ReadOnly = True
        DataGridView3.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView3.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)





        DataGridView4.Columns.Clear()

        Dim dgvjobid1 As New DataGridViewTextBoxColumn()
        dgvjobid1.HeaderText = "ID"
        Dim dgvoutid1 As New DataGridViewTextBoxColumn()
        dgvoutid1.HeaderText = "Status"

        Dim dvgchng1 As New DataGridViewTextBoxColumn()
        dvgchng1.HeaderText = "Message"


        DataGridView4.Columns.Add(dgvjobid1)
        DataGridView4.Columns.Add(dgvoutid1)
        DataGridView4.Columns.Add(dvgchng1)

        dgvoutid1.Width = 240
        dgvjobid1.Width = 40

        '	DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView4.AllowUserToAddRows = False
        DataGridView4.ReadOnly = True
        DataGridView4.DefaultCellStyle.Font = New Font("Trebuchet MS", 9, FontStyle.Bold, GraphicsUnit.Point)
        DataGridView4.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS,", 10, FontStyle.Bold, GraphicsUnit.Point)



        addReasonsCmb()
        addStatus()
        addUserlist()
        WhatsAppMessageLoad()


    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Button1.Text.Trim = "Save" Then
            AddPrinter()
        Else
            UpdatePrinter()
        End If
    End Sub
    Private Sub UpdatePrinter()
        Dim Swq = "update PrinterPageSetting  set [printertype]='" & ComboBox1.SelectedItem & "',[papertype]='" & ComboBox2.SelectedItem & "',[topMar]='" & txttop.Text & "',[bottommar]='" & txtbot.Text & "',[leftmar]='" & txtleft.Text & "',[rightmar]='" & txtright.Text & "',[paperwidth]='" & txtpaperwidth.Text & "',[paperheight]='" & txtpaperheight.Text & "',[textwidth]='" & txtwidth.Text & "'  where [printertype]='" & ComboBox1.SelectedItem & "'"
        OpenDatabaseObject()

        Try

            Dim comm As New SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            MsgBox("Printer Configuration Updated Successfully.!! ").ToString()
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub

    Private Sub AddPrinter()

        If OpenDatabaseObject() = False Then
            MsgBox("Connection Invalid.").ToString()
            Exit Sub
        End If
        Try
            Dim Swq = "INSERT INTO [dbo].[PrinterPageSetting]([printertype],[papertype],[topMar],[bottommar],[leftmar],[rightmar],[paperwidth],[paperheight],[textwidth])     VALUES
                     ('" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & txttop.Text & "','" & txtbot.Text & "','" & txtleft.Text & "','" & txtright.Text & "','" & txtpaperwidth.Text & "','" & txtpaperheight.Text & "','" & txtwidth.Text & "')"

            Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            comm.Dispose()
            MsgBox("Updated Successfully").ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
    Private Sub OnLoadValuPrinter(printerNam As String)
        Dim ds As New DataSet
        Dim sql As String
        Dim count As Integer = 0

        sql = "Select * from PrinterPageSetting where printertype ='" & printerNam & "'"
        Try

            OpenDatabaseObject()
            Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.Fill(ds, "job_services_table")

            count = ds.Tables(0).Rows.Count

            If count > 0 Then
                txtbot.Text = ds.Tables(0).Rows(0).Item("topMar")
                txtpaperheight.Text = ds.Tables(0).Rows(0).Item("paperheight")
                txtleft.Text = ds.Tables(0).Rows(0).Item("leftmar")
                txtright.Text = ds.Tables(0).Rows(0).Item("rightmar")

                txttop.Text = ds.Tables(0).Rows(0).Item("topMar")
                txtpaperwidth.Text = ds.Tables(0).Rows(0).Item("paperwidth")
                txtwidth.Text = ds.Tables(0).Rows(0).Item("textwidth")
                ComboBox2.Text = ds.Tables(0).Rows(0).Item("papertype")
                btnsave.Text = "Update"
            Else
                txtbot.Clear()
                txtpaperheight.Clear()
                txtleft.Clear()
                txtright.Clear()

                txttop.Clear()
                txtpaperwidth.Clear()
                txtwidth.Clear()
                ComboBox2.Text = " "
                btnsave.Text = "Save"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        OnLoadValuPrinter(ComboBox1.SelectedItem)
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        If onCompanyDetailsLoad() = True Then
            Button1.Text = "Update"
        End If
    End Sub




    Private Function onCompanyDetailsLoad() As Boolean

        Dim sql As String
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        OpenDatabaseObject()
        sql = "Select * from CompanyDetails "
        Try
            '  connection.Open()
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "customer_reg")
            SQLAdapter.Dispose()

            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    txtcmpy.Text = ds.Tables(0).Rows(i).Item("name")
                    txtAddress.Text = ds.Tables(0).Rows(i).Item("Address")
                    txtmob.Text = ds.Tables(0).Rows(i).Item("mobileNo")
                Next
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString()).ToString()
            Return False
        End Try
    End Function

    Private Function WhatsAppMessageLoad() As Boolean

        Dim sql As String
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        OpenDatabaseObject()
        sql = "Select * from WhatsAppMessage "
        Try

            DataGridView4.Rows.Clear()

            '  connection.Open()
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "customer_reg")
            ds.Dispose()
            SQLAdapter.Dispose()

            ' DataGridView1.Rows.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                DataGridView4.Rows.Add(ds.Tables(0).Rows(i).Item("ID"), ds.Tables(0).Rows(i).Item("status"), ds.Tables(0).Rows(i).Item("textMsg"))

            Next

        Catch ex As Exception
            MsgBox(ex.ToString()).ToString()
            Return False
        End Try
    End Function

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)

        If OpenDatabaseObject() = False Then
            MsgBox("Connection Invalid.").ToString()
            Exit Sub
        End If

        Try

            Dim Swq = "INSERT INTO Login (username,pswd)
                    VALUES('" & txtuser.Text & "','" & txtpswd.Text & "')"
            Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            comm.Dispose()

            MsgBox("Register Sucessfully!! ").ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim result1 As Integer = MessageBox.Show("Would you like to Remove this Item (Y/N)?", "FollowRemove Confirmation.", MessageBoxButtons.YesNo)
            If result1 = DialogResult.No Then
                Exit Sub
            ElseIf result1 = DialogResult.Yes Then

            End If

            Try

                Dim Swq = "delete from [followupstatus] where [fid] = " & DataGridView1.Rows(e.RowIndex.ToString()).Cells(0).Value
                Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                addReasonsCmb()
                MsgBox("Remove Successfully").ToString()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
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
            addReasonsCmb()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If OpenDatabaseObject() = False Then
            MsgBox("Connection Invalid.").ToString()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtstatus.Text) Then
            MsgBox("Please Enter The Status name.!").ToString()
            Exit Sub
        End If
        Try

            Dim Swq = "INSERT INTO Status (status )VALUES('" & txtstatus.Text & "')"
            MsgBox(Swq)
            Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            comm.Dispose()

            MsgBox("Add Sucessfully!! ").ToString()
            addStatus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim result1 As Integer = MessageBox.Show("Would you like to Remove this Item (Y/N)?", "FollowRemove Confirmation.", MessageBoxButtons.YesNo)
            If result1 = DialogResult.No Then
                Exit Sub
            ElseIf result1 = DialogResult.Yes Then

            End If

            Try

                Dim Swq = "delete from [Status] where [ID] = " & DataGridView2.Rows(e.RowIndex.ToString()).Cells(0).Value
                Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                addStatus()
                MsgBox("Remove Successfully").ToString()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.ColumnIndex = 3 And DataGridView3.Rows(e.RowIndex.ToString()).Cells(2).Value = "admin" Then
            If DataGridView3.Rows.Count > 1 Then
                MsgBox("Please Delete All User First.!").ToString()
                Exit Sub
            Else
                Dim Swq = "delete from login "
                Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
            End If
        End If

        If e.ColumnIndex = 3 And DataGridView3.Rows(e.RowIndex.ToString()).Cells(2).Value <> "admin" Then
            Dim result1 As Integer = MessageBox.Show("Would you like to Remove this Item (Y/N)?", "FollowRemove Confirmation.", MessageBoxButtons.YesNo)
            If result1 = DialogResult.No Then
                Exit Sub
            ElseIf result1 = DialogResult.Yes Then
            End If
            Try
                Dim Swq = "delete from login where ID = " & DataGridView3.Rows(e.RowIndex.ToString()).Cells(0).Value
                Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                addUserlist()
                MsgBox("Remove Successfully").ToString()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnupdate_Click_1(sender As Object, e As EventArgs) Handles btnupdate.Click
        If OpenDatabaseObject() = False Then
            MsgBox("Connection Invalid.").ToString()
            Exit Sub
        End If

        If btnupdate.Text = "Register" Then
            Try
                Dim Swq = "INSERT INTO Login (username,pswd,role)
                    VALUES('" & txtuser.Text & "','" & txtpswd.Text & "','user')"
                Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
                comm.ExecuteNonQuery()
                comm.Dispose()
                txtuser.Clear()
                txtpswd.Clear()
                MsgBox("Register Sucessfully!! ").ToString()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            Dim SQLAdapter As SqlClient.SqlDataAdapter
            Dim ds As New DataSet
            Dim sql As String
            Try
                If role = "admin" Then
                    Dim Swq = "Select * from login where username='" & txtuser.Text & "' and pswd='" & txtoldpswd.Text & "'"
                    SQLAdapter = New SqlClient.SqlDataAdapter(Swq, SQLConn)
                    SQLAdapter.SelectCommand.ExecuteNonQuery()
                    SQLAdapter.Fill(ds, "customer_reg")
                    ds.Dispose()
                    SQLAdapter.Dispose()


                    sql = "Update Login set pswd = '" & txtpswd.Text & "' where username='" & txtuser.Text & "'"
                    Dim comm As New SqlClient.SqlCommand(sql, SQLConn)
                    comm.ExecuteNonQuery()
                    comm.Dispose()

                    MsgBox("Password change Successfully.!")
                    txtuser.Clear()
                    txtpswd.Clear()
                    labletitle.Text = "Register User"
                    btnupdate.Text = "Register"
                    lableold.Visible = False
                    txtoldpswd.Visible = False

                Else

                    sql = "Update Login set pswd = '" & txtpswd.Text & "' where username='" & txtuser.Text & "'"
                    Dim comm As New SqlClient.SqlCommand(sql, SQLConn)
                    comm.ExecuteNonQuery()
                    comm.Dispose()

                    MsgBox("Password change Successfully.!")
                    txtuser.Clear()
                    txtpswd.Clear()
                    labletitle.Text = "Register User"
                    btnupdate.Text = "Register"
                    lableold.Visible = False
                    txtoldpswd.Visible = False

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        addUserlist()
    End Sub

    Private Sub DataGridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        role = DataGridView3.Rows(e.RowIndex.ToString()).Cells(2).Value
        If DataGridView3.Rows(e.RowIndex.ToString()).Cells(2).Value = "admin" Then
            lableold.Visible = True
            txtoldpswd.Visible = True
        End If

        txtuser.Text = DataGridView3.Rows(e.RowIndex.ToString()).Cells(1).Value
        labletitle.Text = "Change Password"
        btnupdate.Text = "Update"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtuser.Clear()
        txtpswd.Clear()
        labletitle.Text = "Register User"
        btnupdate.Text = "Register"
        lableold.Visible = False
        txtoldpswd.Visible = False
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        WhatsAppMessageLoad()
    End Sub

    Private Sub DataGridView4_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentDoubleClick
        WhatsAppID = DataGridView4.CurrentRow.Cells(0).Value
        txtwStatus.Text = DataGridView4.CurrentRow.Cells(1).Value
        txtwMessage.Text = DataGridView4.CurrentRow.Cells(2).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim Swq = "UPDATE WhatsAppMessage SET textMsg ='" & txtwMessage.Text & "' WHERE id = " & WhatsAppID
            Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            comm.Dispose()
            txtwStatus.Clear()
            txtwMessage.Clear()
            WhatsAppMessageLoad()
            MsgBox("Update Sucessfully!! ").ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WriteINI("PortNo", "Port", txtport.Text)
        WriteINI("PortNo", "url", txturl.Text)
        MsgBox("WA Setting Updated Successfully").ToString()
    End Sub
End Class
