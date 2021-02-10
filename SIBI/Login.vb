Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text.Json
Imports Newtonsoft.Json.Linq

Public Class Login
    'Public myObj As JObject
    'Public myObj2 As JsonDocument

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If Len(DatabaseTypeName) = 0 Then
            MsgBox("Please Select Data Type.").ToString()
            Exit Sub
        End If

        ApplicationPath = Application.StartupPath

        If String.IsNullOrWhiteSpace(ReadINI("Database", "DatabasName", "")) Then
            MsgBox("Please Select Database From DB Setting").ToString()
            Exit Sub
        End If

        'CreateSystemIni()
        ReadDbSettingIni()

        Dim ds As New DataSet
        Dim sql As String
        Dim count As Integer = 0

        Try
            If Check_login_TableEmpty() = False Then
                Exit Sub
            End If


        Catch ex As Exception

        End Try





        sql = "Select * from Login where username= '" & txtuser.Text & "'"

        Try

            OpenDatabaseObject()

            Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.Fill(ds, "job_services_table")

            For i = 0 To ds.Tables(0).Rows.Count - 1
                count = count + 1

            Next


            If count = 0 Then

                MsgBox("Please Enter Correct Username").ToString()
                txtuser.SelectionStart = 0
                txtuser.SelectionLength = txtuser.Text.Length
                txtuser.Focus()
                count = 0
                Return
                ' and pswd= '" & txtpswd.Text & "'
            End If
            count = 0
            ds.Clear()
            sql = "Select * from Login where pswd= '" & txtpswd.Text & "'"
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.Fill(ds, "job_services_table")

            For i = 0 To ds.Tables(0).Rows.Count - 1
                count = count + 1

            Next

            If count = 0 Then

                MsgBox("Please Enter Correct Password").ToString()
                txtpswd.SelectionStart = 0
                txtpswd.SelectionLength = txtpswd.Text.Length
                txtpswd.Focus()
                count = 0
                Return
                ' and pswd= '" & txtpswd.Text & "'
            End If

            If count > 0 Then
                'MessageBox.Show("Login Sucessfully").ToString()
                session = txtuser.Text
                AutoComplete()
                'PrblmDescAutoComplete()
                AutoCompleteCompnyName()
                MDIParent1.Show()
                If ds.Tables(0).Rows(0).Item("role") = "user" Then
                    MDIParent1.ConfigToolStripMenuItem.Visible = False
                End If

                'MDIParent1.WindowState = 1
                Me.Hide()

            Else
                MsgBox("Incorrect Login").ToString()
                txtuser.Focus()
                'txtuser.Clear()
                'txtpswd.Clear()

            End If

            CloseDatabaseObject()

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

    End Sub
    Private Sub CheckIniFile()
        If System.IO.File.Exists("Config.ini") = False Then
            System.IO.File.Create("Config.ini")
            'MsgBox("config")
        End If
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckIniFile()
        GroupBox2.Enabled = False
        GroupBox1.Visible = False
        btnapply.Enabled = False

        txtdbName.Visible = False
        ApplicationPath = ReadINI("Database", "ApplcationPath", "")

        DatabaseTypeName = ReadINI("Database", "DatabasName", "")

        printername = ReadINI("Printer", "PrinterName", "")

        txtuser.Focus()


        ' ComboBox1.Items.Add("Access Database")
        ComboBox1.Items.Add("MSSQL Database")
        'ComboBox1.Text = "MSSQL Database"
        ComboBox1.Enabled = False

        'Dim strdbnm As String = kv("DatabasName").ToString
        Dim strdbnm As String = "MSSQL Database"
        ComboBox1.Text = strdbnm

        Dim strdb As String = ReadINI("Database", "DatabasPath", "")
        'txtdbfilepath.Text = strdb

        Dim strIp As String = ReadINI("SqlServer", "Ipaddress", "")
        txtipAdd.Text = strIp


        'load databases
        'FectchListofDataBases(txtipAdd.Text)



        'MsgBox(strIp)
        Dim strDBName As String
        Dim strUsernm As String
        Dim strpswd As String
        'If String.IsNullOrWhiteSpace(ReadINI("SqlServer", "DUP", "")) = False Then
        'Dim b As Byte() = Convert.FromBase64String(ReadINI("SqlServer", "DUP", ""))


        '            Dim strOriginal = System.Text.Encoding.UTF8.GetString(b)

        'myObj2 = JsonDocument.Parse(strOriginal)
        '
        '       strDBName = myObj2.RootElement.GetProperty("DbName").GetString 'ReadINI("SqlServer", "DbName", "")
        '        cmbDataBase.Text = strDBName
        '         strUsernm = myObj2.RootElement.GetProperty("UserName").GetString  ' ReadINI("SqlServer", "UserName", "")
        '          txtdbusername.Text = strUsernm
        '           strpswd = myObj2.RootElement.GetProperty("Pswd").GetString 'ReadINI("SqlServer", "Pswd", "")
        '            txtdbpassword.Text = strpswd
        '     End If
        strDBName = ReadINI("SqlServer", "DbName", "")
        cmbDataBase.Text = strDBName
        strUsernm = ReadINI("SqlServer", "UserName", "")
        txtdbusername.Text = strUsernm
        strpswd = ReadINI("SqlServer", "Pswd", "")
        txtdbpassword.Text = strpswd

        Dim strAuthType As String = ReadINI("Database", "AuthType", "")
        'MsgBox(strAuthType)
        If strAuthType = "Windows" Then
            windows.Checked = True
        ElseIf strAuthType = "SQL Server" Then
            RadioButton2.Checked = True
        Else
            windows.Checked = True
        End If


        DBUserName = strUsernm
        DBName = cmbDataBase.Text
        If String.IsNullOrWhiteSpace(ReadINI("SqlServer", "DUP", "")) = False Then
            If String.IsNullOrWhiteSpace(ReadINI("SqlServer", "DbName", "")) Then
                DBName = ReadINI("SqlServer", "DbName", "")
            End If

        End If



        DBPass = strpswd
        AuthenticationType = strAuthType
        DBIPAddress = strIp
        btnlogin.Visible = True
        btnlogin.Enabled = True
        btnNewUser.Visible = False

        ' CheckVersion()


        txtuser.Focus()
    End Sub

    Private Function CheckVersion()

        Dim ds As New DataSet
        Dim sql As String
        Dim count As Integer = 0


        sql = "Select * from DataVersion"

        Try

            OpenDatabaseObject()

            Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)

            SQLAdapter.Fill(ds, "data_version_table")
            If ds.Tables(0).Rows(0).Item(0) <> DataVersionRequired Then
                FectchListofDataBases(False)
            End If


            If count = 0 Then

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Function
    Private Function Check_login_TableEmpty() As Boolean



        Dim ds As New DataSet
        Dim sql As String
        Dim count As Integer = 0

        sql = "Select * from login"
        Try

            OpenDatabaseObject()

            Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.Fill(ds, "job_services_table")

            count = ds.Tables(0).Rows.Count

            If count > 0 Then
                btnNewUser.Visible = False
                Check_login_TableEmpty = True
                Return True
                Exit Function
            Else
                btnNewUser.Visible = True
                Check_login_TableEmpty = False
                Return False
                Exit Function
            End If
            'MsgBox(count)

            CloseDatabaseObject()

        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GroupBox_CS.Visible = True
        GroupBox_CS.BringToFront()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        OpenFileDialog1.OpenFile()
        'txtdbfilepath.Text = OpenFileDialog1.FileName.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CreateTables_Login(vbFalse)
        CreateTables_Status(vbFalse)
        CreateTables_Customer(vbFalse)
        CreateTables_OtherproductDetails(vbFalse)
        CreateTables_JobServices(vbFalse)


        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click


        If Len(DatabaseTypeName) = 0 Then
            MsgBox("Please Select Data Type.").ToString()
            Exit Sub
        End If
        'Me.Hide()
        Registration.Show()



    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        GroupBox_CS.Visible = False
        If cmbDataBase.Text.Length < 1 Then
            MsgBox("Please,Select Database").ToString()
        End If
        CheckTablesPresentOrNot(False)
        'Dim strOriginal As String = "{""DbName"":""" & cmbDataBase.Text & """,""UserName"":""" & txtdbusername.Text & """,""Pswd"":""" & txtdbpassword.Text & """}"
        'Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(strOriginal)
        'Dim strModified = Convert.ToBase64String(byt)

        'WriteINI("SqlServer", "DUP", strModified)
        WriteINI("SqlServer", "Ipaddress", txtipAdd.Text)
        WriteINI("SqlServer", "DbName", cmbDataBase.Text)
        WriteINI("SqlServer", "UserName", txtdbusername.Text)
        WriteINI("SqlServer", "Pswd", txtdbpassword.Text)
        WriteINI("Database", "ApplcationPath", ApplicationPath)
        WriteINI("Database", "DatabasName", ComboBox1.Text)
        WriteINI("Database", "DatabasPath", "")
        WriteINI("Database", "AuthType", AuthenticationType)
        WriteINI("Printer", "PrinterName", "")
        ReadDbSettingIni()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox_CS.Visible = False
    End Sub

    Private Sub btntest_Click(sender As Object, e As EventArgs) Handles btntest.Click

        If txtipAdd.TextLength < 1 Then
            MsgBox("Please enter IP Address").ToString()
            Exit Sub
        End If


        DBUserName = txtdbusername.Text
        DBName = txtdbName.Text
        DBPass = txtdbpassword.Text
        DBIPAddress = txtipAdd.Text


        '	MsgBox("Click On Test Connection.").ToString()

        If CheckIPAddress() = False Then
            MsgBox("Connection Invalid.").ToString()
            Exit Sub
        Else
            MsgBox("Connection valid.").ToString()
            GroupBox2.Enabled = True
            'CheckTablesPresentOrNot(False)
        End If
        'CreateDatabase(txtipAdd.Text, "SibiDB")




    End Sub
    Private Function CheckIPAddress() As Boolean
        Dim SecurityQuery As String
        SQLConn = New SqlConnection
        Try
            If AuthenticationType = "Windows" Then

                SecurityQuery = "Integrated Security = SSPI;"
            Else
                SecurityQuery = "User Id=" & DBUserName & ";Password = " & DBPass & ";"

            End If



            SQLConn.ConnectionString = "Server=" & DBIPAddress & ";" & SecurityQuery
            'SQLConn.ConnectionString = "Data Source=DS\SQLEXP;Network Library = DBMSSOCN;initial Catalog=sibi2;User ID =sa;Password=admin123"
            'MsgBox (SQLConn.ConnectionString)
            SQLConn.Open()
            CheckIPAddress = True
        Catch ex As Exception
            MsgBox(ex.ToString())
            CheckIPAddress = False
        End Try
    End Function
    Public Function FectchListofDataBases(ServerName As String) As Boolean
        Dim SecurityQuery As String
        Try

            If AuthenticationType = "Windows" Then

                SecurityQuery = "Integrated Security = SSPI;"
            Else
                SecurityQuery = "User Id=" & DBUserName & ";Password = " & DBPass & ";"

            End If


            Dim conStr As String
            'SQLConn.ConnectionString = "Server=" & DBIPAddress & ";" & SecurityQuery & "Database=;Trusted_Connection = yes"
            If trusted Then 'Trusted_Connection=Yes;
                conStr = "Server=" & ServerName & ";Database=;Trusted_Connection=Yes;" & SecurityQuery
            Else
                conStr = "Server=" & ServerName & ";Database=;" & SecurityQuery
            End If


            'MsgBox(conStr).ToString()
            Dim objCon As New SqlConnection(conStr)
            objCon.Open()

            Dim obj As SqlCommand = New SqlCommand("Select * From sys.databases Where database_id > 4", objCon)
            cmbDataBase.Items.Clear()

            Using RDR = obj.ExecuteReader()
                If RDR.HasRows Then
                    Do While RDR.Read
                        cmbDataBase.Items.Add(RDR.Item("Name"))
                    Loop
                End If
            End Using


            'Dim strDBName As String = ReadINI("SqlServer", "DUP", "")
            'If strDBName.Length > 0 Then cmbDataBase.Text = strDBName


        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
            'MsgBox("Check Your IP Address / Domain Name")
        End Try
        Return True
    End Function


    Public Sub CheckTablesPresentOrNot(ShowMsg As Boolean)

        If CheckTables("AutoComplete") = False Then
            CreateTables_Autocomplete(ShowMsg)
        End If

        If CheckTables("AMC_Table") = False Then
            CreateTables_AMC(ShowMsg)
        End If


        If CheckTables("AutoCompleteCmpnyName") = False Then
            CreateTables_AutocompnyName(ShowMsg)
        End If

        If CheckTables("WhatsAppMessage") = False Then
            CreateTables_WhatsAppMessage(ShowMsg)
        End If

        If CheckTables("AutocompleteProblem") = False Then
            CreateTables_AutocompleteProblem(ShowMsg)
        End If

        If CheckTables("followupstatus") = False Then
            CreateTables_FollowupStatus(ShowMsg)
        End If

        If CheckTables("columnFilter") = False Then
            CreateTables_colUmnFilter(ShowMsg)
        End If
        If CheckTables("ActivityTable") = False Then
            CreateTables_ActivityTable(ShowMsg)
        End If

        If CheckTables("Customer_reg") = False Then
            CreateTables_Customer(ShowMsg)
        End If

        If CheckTables("job_services") = False Then
            CreateTables_JobServices(ShowMsg)
        End If
        If CheckTables("CompanyDetails") = False Then
            CreateTables_CompnayDetails(ShowMsg)
        End If

        If CheckTables("login") = False Then
            CreateTables_Login(ShowMsg)
        End If
        If CheckTables("PrinterPageSetting") = False Then
            CreateTable_PrinterPageSetting(ShowMsg)
        End If

        If CheckTables("OtherproductDetails") = False Then
            CreateTables_OtherproductDetails(ShowMsg)
        End If
        If CheckTables("AutocompleteRepaier") = False Then
            CreateTables_AutoReapirerName(ShowMsg)
        End If
        If CheckTables("OutSrcProductDetails") = False Then
            CreateTables_OutSrcProductDetails(ShowMsg)
        End If
        If CheckTables("Status") = False Then
            CreateTables_Status(ShowMsg)
        End If
        If CheckTables("AutocompleteProduct") = False Then
            CreateTables_AutoProdcomplete(ShowMsg)
        End If

        If CheckTables("DataVersion") = False Then
            CreateTables_DataVersion(ShowMsg)
        End If


        OpenDatabaseObject()
        Try
            Dim Swq = "update DataVersion set  dataversion=" & DataVersionRequired
            Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
            comm.ExecuteNonQuery()
            comm.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        CloseDatabaseObject()



    End Sub

    Private Function CheckTables(tableName As String) As Boolean
        Dim ds As New DataSet
        Dim sql As String
        Dim count As Integer = 0
        CheckTables = False
        sql = "SELECT table_name FROM INFORMATION_SCHEMA.Tables WHERE table_name ='" & tableName & "'"
        Try
            OpenDatabaseObject()
            Dim SQLAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.Fill(ds, "job_services_table")

            If ds.Tables(0).Rows.Count > 0 Then
                CheckTables = True
            Else
                CheckTables = False
            End If
            CloseDatabaseObject()
        Catch ex As Exception
            MsgBox(ex.ToString()).ToString()
        End Try
    End Function


    Private Sub btntable_Click(sender As Object, e As EventArgs)
        CreateTables_Login(vbFalse)
        CreateTables_JobServices(vbFalse)
        CreateTables_OtherproductDetails(vbFalse)
        CreateTables_Status(vbFalse)
        CreateTables_Customer(vbFalse)
        CreateTables_colUmnFilter(vbFalse)
        CreateTables_OutSrcProductDetails(vbFalse)
        CreateTables_AutocompleteProblem(vbFalse)
        CreateTables_AutocompnyName(vbFalse)
        CreateTables_Autocomplete(vbFalse)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DatabaseTypeName = ComboBox1.Text
    End Sub

    Private Sub windows_CheckedChanged(sender As Object, e As EventArgs) Handles windows.CheckedChanged
        AuthenticationType = "Windows"
        GroupBox1.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        AuthenticationType = "SQL Server"
        GroupBox1.Visible = True
    End Sub

    Private Sub btnDb_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtdbName.Text) Then
            MsgBox("Please select database name from the list").ToString()
            Return
        End If
        'CreateDatabase(txtdbName.Text, txtipAdd.Text)

    End Sub



    Private Sub cmbDataBase_SelectedIndexChanged(sender As Object, e As EventArgs)
        WriteINI("SqlServer", "DbName", cmbDataBase.Text)
    End Sub

    Private Sub cmbDataBase_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        FectchListofDataBases(txtipAdd.Text)
        If cmbDataBase.Items.Count < 1 Then
            MsgBox("Please Create Database").ToString()
            btnDb.Visible = True
            createDb.ShowDialog()

            'txtdbName.Visible = True
            'cmbDataBase.Visible = False
            Return
        Else
            DBUserName = txtdbusername.Text
            DBName = cmbDataBase.Text
            DBPass = txtdbpassword.Text
            DBIPAddress = txtipAdd.Text
            MsgBox("Databases fetch from IP /Domain : " & DBIPAddress).ToString()
            btnapply.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CheckTablesPresentOrNot(False)
        MsgBox("Database verfied sucessfully").ToString()
    End Sub
    Private Sub cmbDataBase_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbDataBase.SelectedIndexChanged
        DBName = cmbDataBase.Text
    End Sub

    Private Sub btnDb_Click_1(sender As Object, e As EventArgs) Handles btnDb.Click
        If cmbDataBase.Items.Count > 0 Then
            Dim result1 As Integer = MessageBox.Show("Database already present, Would you like to create another database(Y/N)?", "Job Entry Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result1 = DialogResult.No Then
                Exit Sub
            ElseIf result1 = DialogResult.Yes Then

                createDb.ipAddress = txtipAdd.Text
                createDb.ShowDialog()
            End If
        Else
            createDb.ipAddress = txtipAdd.Text
            createDb.ShowDialog()
            'CreateDatabase(txtdbName.Text, txtipAdd.Text)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            trusted = True
        Else
            trusted = False
        End If
    End Sub
End Class