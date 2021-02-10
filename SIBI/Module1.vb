
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.Json
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
'Shared SQLConn As OleDbConnection
'Dim SQLConn As OleDb.OleDbConnection
'Shared SQLConn As SqlConnection

Module CreateConnection
	Public NewAddjOB As New AddJobDetails
	Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
				ByVal lpKeyName As String,
				ByVal lpDefault As String,
				ByVal lpReturnedString As StringBuilder,
				ByVal nSize As Integer,
				ByVal lpFileName As String) As Integer


	Private Declare Function WritePrivateProfileString _
   Lib "kernel32" Alias "WritePrivateProfileStringA" _
  (ByVal lpSectionName As String,
   ByVal lpKeyName As String,
   ByVal lpString As String,
   ByVal lpFileName As String) As Long
	Public DataVersionRequired As Double = 1

	'Public SQLConn As OleDbConnection
	Public queryCond As String

	Public ThermalPrintFont As String = "Times New Roman"

	Public swq As String
	'  Application.StartupPath
	Public trusted As Boolean = False
	Public IniFileName As String = AppDomain.CurrentDomain.BaseDirectory & "\Config.ini"
	Public SQLConn As SqlConnection
	'Public OLEconn As OleDbConnection
	Public session As String
	Public ApplicationPath As String = Application.StartupPath
	Public Company_Name As String = "Sai Infotech"
	Public DBUserName As String
	Public DBPass As String
	Public DBIPAddress As String
	Public DBName As String
	Public AuthenticationType As String
	Public DatabasePath As String
	Public DatabaseFileName As String
	Public printername As String
	Public DatabaseTypeName As String
	Public cmd As SqlCommand
	Public defultPort As Integer = 4305
	Public DataCollection As New AutoCompleteStringCollection() 'Customer Name Autocompelete
	Public DataCollectionRepairerName As New AutoCompleteStringCollection() 'Repair Name Autocompelete
	Public DataCollectionForProblmDesc As New AutoCompleteStringCollection() 'Problem Description Autocompelete
	Public DataCollectioncmpyName As New AutoCompleteStringCollection() 'Problem Description Autocompelete
	Public DataCollectionForProdName As New AutoCompleteStringCollection() 'Problem Description Autocompelete

	Public deliveryLightBlue = Color.LightBlue
	Public OutsrcLightYellow = Color.LightYellow
	Public NotRepaireLightPink = Color.LightPink
	Public RepaireGreen = Color.LightGreen
	Public NotRepaireableRed = ColorTranslator.FromHtml("#FE4D4D")
	Public WhiteBackgound = ColorTranslator.FromHtml("#FFF")
	Public WarningBackgound = ColorTranslator.FromHtml("#EA3C53")
	Public outsandPendingcolor = Color.Gray


	Public Function CreateAccessconnection(Optional DatabaseName As String = "", Optional UserName As String = "", Optional Pass As String = "", Optional IPAddress As String = "") As Boolean

		'	DatabasePath = Application.StartupPath
		'	DatabaseFileName = "job_data.accdb"

		'	SQLConn = New OleDb.OleDbConnection

		'	SQLConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & DatabasePath & "\" & DatabaseFileName & "'"

		'	SQLConn.Open()
		'	CreateAccessconnection = True
		Return False
	End Function



	Public Function CloseDatabaseObject() As Boolean

		CloseDatabaseObject = False
		If SQLConn.State = 1 Then SQLConn.Close()
		SQLConn.Dispose()
		CloseDatabaseObject = True

	End Function


	Public Function OpenDatabaseObject() As Boolean


		Select Case DatabaseTypeName
			Case "Access Database"
				'  MsgBox("Access database.").ToString()
				If CreateAccessconnection() = True Then
					'MsgBox("Connection Invalid.").ToString()
					OpenDatabaseObject = True
					Return True
					Exit Function
				End If
			Case "MSSQL Database"
				' MsgBox("Mssql database.").ToString()
				If CreateMssqlconnection() = True Then
					'MsgBox("Connection Invalid.").ToString()
					OpenDatabaseObject = True
					Return True
					Exit Function

				End If

			Case Else
				MsgBox("Database Not Selected.").ToString()
				OpenDatabaseObject = False
				Return False
		End Select

		Return False
	End Function


	Public Function CheckJobIDPresent(jobid As Double) As Boolean

		CheckJobIDPresent = False
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String



		'cmd.Transaction.Begin()


		'cmd.Transaction.Commit()


		sql = "Select ID from job_services Where ID=" & jobid



		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Function
		End If


		SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
		SQLAdapter.SelectCommand.ExecuteNonQuery()

		SQLAdapter.Fill(ds, "job_services_table")
		'MsgBox((ds.Tables(0).Rows.Count))
		If (ds.Tables(0).Rows.Count) = 0 Then
			CheckJobIDPresent = False
		Else
			CheckJobIDPresent = True
		End If


		Return CheckJobIDPresent

	End Function
	Public Function CheckPresviousJobIDPresent(jobid As Double) As Boolean

		CheckPresviousJobIDPresent = False
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		sql = "Select ID from job_services Where perviuosJobid=" & jobid

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Function
		End If


		SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
		SQLAdapter.SelectCommand.ExecuteNonQuery()

		SQLAdapter.Fill(ds, "job_services_table")
		'MsgBox((ds.Tables(0).Rows.Count))
		If (ds.Tables(0).Rows.Count) = 0 Then
			CheckPresviousJobIDPresent = False
		Else
			CheckPresviousJobIDPresent = True
		End If


		Return CheckPresviousJobIDPresent

	End Function


	Public Function GetJobID() As Double

		'GetJobID = ""

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String
		Dim COUNT As Double

		sql = "Select max(ID) from job_services "


		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Return False
			Exit Function
		End If


		SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
		SQLAdapter.SelectCommand.ExecuteNonQuery()

		SQLAdapter.Fill(ds, "job_services_table")
		If IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
			COUNT = 0
		Else
			COUNT = ds.Tables(0).Rows(0).Item(0)
		End If


		Return COUNT + 1
		Return True
	End Function

	Public Function ReadDbSettingIni()
		'Dim b As Byte() = Convert.FromBase64String(ReadINI("SqlServer", "DUP", ""))


		'Dim strOriginal = System.Text.Encoding.UTF8.GetString(b)



		DBName = ReadINI("SqlServer", "DbName", "")
			DBUserName = ReadINI("SqlServer", "UserName", "")
			DBPass = ReadINI("SqlServer", "Pswd", "")

		DBIPAddress = ReadINI("SqlServer", "Ipaddress", "")
		AuthenticationType = ReadINI("Database", "AuthType", "")
		ApplicationPath = ReadINI("Database", "ApplcationPath", "")
		DatabasePath = ReadINI("Database", "DatabasPath", "")
		DatabaseTypeName = ReadINI("Database", "DatabasName", "")

		printername = ReadINI("Printer", "PrinterName", "")



		'WriteINI("", "", "")

		Return True
	End Function

	Public Function WriteINI(SectionName As String, KeyName As String, Value As String) As Boolean
		Try
			Dim str As Boolean = WritePrivateProfileString(SectionName, KeyName, Value, IniFileName)
			Return True
			Exit Try
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
			Return False
		End Try


	End Function


	Public Function ReadINI(SectionName As String, KeyName As String, DefaultValue As String) As String

		Dim sb As StringBuilder
		Dim result As String

		sb = New StringBuilder(500)


		GetPrivateProfileString(SectionName, KeyName, "", sb, sb.Capacity, IniFileName)
		result = sb.ToString

		Return result
	End Function


	Public Function CreateMssqlconnection() As Boolean
		'MsgBox(DBName)
		Dim SecurityQuery As String
		SQLConn = New SqlConnection
		Try
			If AuthenticationType = "Windows" Then

				SecurityQuery = "Integrated Security = SSPI;"
			Else
				SecurityQuery = "User Id=" & DBUserName & ";Password = " & DBPass & ";"

			End If


			SQLConn.ConnectionString = "Server=" & DBIPAddress & ";Database=" & DBName & ";" & SecurityQuery
			SQLConn.Open()
			CreateMssqlconnection = True
		Catch ex As Exception
			MsgBox(ex.ToString())
			CreateMssqlconnection = False
		End Try

	End Function


	Public Function AutoComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutoComplete"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				DataCollection.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

		Return True
	End Function

	Public Function AutoAddComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutoComplete where Name='" & autoString & "'"

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			If ds.Tables(0).Rows.Count = 0 Then
				Dim Swq = "INSERT INTO AutoComplete (Name)
                    VALUES('" & autoString & "')"

				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

		Return True
	End Function

	Public Function AutoCompleteCompnyName(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select name from AutoCompleteCmpnyName"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				DataCollectioncmpyName.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		Return True

	End Function


	Public Function AutoAddRepaireComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutocompleteRepaier where Name='" & autoString & "'"

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			If ds.Tables(0).Rows.Count = 0 Then
				Dim Swq = "INSERT INTO AutocompleteRepaier (name)
                    VALUES('" & autoString & "')"

				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try

		Return True
	End Function

	Public Function RepairerNameAuto(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutocompleteRepaier "
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				DataCollectionRepairerName.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			'CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

		Return True
	End Function
	Public Function AutoAddCompnyNameComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutoCompleteCmpnyName where name='" & autoString & "'"

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			If ds.Tables(0).Rows.Count = 0 Then
				Dim Swq = "INSERT INTO AutoCompleteCmpnyName (name)
                    VALUES('" & autoString & "')"
				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		Return True

	End Function



	Public Function PrblmDescAutoComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutocompleteProblem "
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				DataCollectionForProblmDesc.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

		Return True
	End Function
	Public Function AddAutoCompletePrblmdesc(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutocompleteProblem  where name='" & autoString & "'"

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			If ds.Tables(0).Rows.Count = 0 Then
				Dim Swq = "INSERT INTO AutocompleteProblem (name)
                    VALUES('" & autoString & "')"
				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		Return True

	End Function






	Public Function AutoProdComplete(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select name from AutocompleteProduct"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				DataCollectionForProdName.Add(ds.Tables(0).Rows(i).Item(0))
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

		Return True
	End Function
	Public Function AddAutoCompleteProduct(Optional autoString As String = "")

		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from AutocompleteProduct  where name='" & autoString & "'"

		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "AutoName_table")
			SQLAdapter.Dispose()

			If ds.Tables(0).Rows.Count = 0 Then
				Dim Swq = "INSERT INTO AutocompleteProduct (name)
                    VALUES('" & autoString & "')"
				Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
				comm.ExecuteNonQuery()
				comm.Dispose()
			End If

			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex.ToString).ToString()
		End Try
		Return True

	End Function

	Public Function CpmnyName()
		Dim SQLAdapter As SqlClient.SqlDataAdapter
		Dim ds As New DataSet
		Dim sql As String

		OpenDatabaseObject()
		sql = "Select Name from CompanyDetails"
		Try
			'  connection.Open()
			SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
			SQLAdapter.SelectCommand.ExecuteNonQuery()
			SQLAdapter.Fill(ds, "CompanyDetails")
			SQLAdapter.Dispose()

			For i = 0 To ds.Tables(0).Rows.Count - 1

				Company_Name = ds.Tables(0).Rows(i).Item(0)
			Next
			SQLAdapter.Dispose()
			CloseDatabaseObject()
		Catch ex As Exception
			MsgBox(ex).ToString()
		End Try

		Return True
	End Function
	Public Function RemoveSpecialChrforFolderName(NameString As String) As String
		Dim a As Integer
		Dim NewName As String

		NewName = Regex.Replace(NameString, "[^A-Za-z0-9\-/]", "_")

		RemoveSpecialChrforFolderName = NewName
	End Function

End Module
