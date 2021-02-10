Imports System.Data.Sql
Imports System.Data.SqlClient

Module CreateTables

	Public Sub CreateTable_PrinterPageSetting(ShowMsg As Boolean)

		Dim Sql = "CREATE TABLE [PrinterPageSetting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[printertype] [varchar](255) NOT NULL,
	[papertype] [varchar](255) Not NULL,
	[topMar] [int],
	[bottommar] [int],
	[leftmar] [int],
	[rightmar] [int],
	[paperwidth] [int],
	[paperheight] [int],
	[textwidth] [int]
) ON [PRIMARY]"

		Create_Table(Sql, "PrinterPageSetting", ShowMsg)
	End Sub

	Public Sub CreateTables_JobServices(ShowMsg As Boolean)

		Dim Sql = "CREATE TABLE [dbo].[job_services](
	[ID] [int] NOT NULL,
	[mobile] [varchar](10) NULL,
	[job_date] [date] NULL,
	[cust_name] [varchar](50) NULL,
	[product_service] [varchar](100) NULL,
	[service_type] [varchar](20) NULL,
	[warranty] [varchar](20) NULL,
	[prblm_comp] [varchar](255) NULL,
	[prblm_observe] [varchar](255) NULL,
	[Estimate_value] [decimal](10, 1) NULL,
	[Estimate_date] [date] NULL,
	[Repaire_Done] [varchar](255) NULL,
	[Job_status] [varchar](20) NULL,
	[Remark] [varchar](100) NULL,
	[name_of_user] [varchar](20) NULL,
	[date_of_entry] [date] NULL,
	[modify_user_name] [varchar](20) NULL,
	[date_of_modify] [date] NULL,
	[company_name] [varchar](50) NULL,
	[date_repaire] [varchar](20) NULL,
	[job_delivery] [varchar](20) NULL,
	[job_delivery_date] [date] NULL,
	[Receiver] [varchar](50) NULL,
	[RepaireDone_by] [varchar](50) NULL,
	[Receiver_mobile] [varchar](10) NULL,
	[perviuosJobid] [int] NULL,
	[Paid] [varchar](20) NULL,
	[customerid] [int]
)"

		Create_Table(Sql, "Job Services", ShowMsg)
	End Sub
	Public Sub Create_Table(Sql_stm As String, TableName As String, ShowMsg As Boolean)


		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If


		Dim NonQuery As String = ""
		Using cmd As New SqlCommand()
			cmd.Connection = SQLConn
			cmd.CommandText = Sql_stm
			Try
				cmd.ExecuteNonQuery()
				If ShowMsg = True Then MsgBox("Created  " & TableName & "  Table Sucessfully.").ToString()
			Catch ex As Exception
				MsgBox(ex.Message).ToString()
			End Try
		End Using

	End Sub

	Public Sub CreateTables_OtherproductDetails(ShowMsg As Boolean)

		Dim Sql = "CREATE TABLE [dbo].[OtherproductDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Jobid] [int] NULL,
	[ProductName] [varchar](50) NULL,
	[SerialNo] [varchar](20) NULL,
	[InDate] [date] NULL,
	[OutDate] [date] NULL,
	[Receiver] [varchar](20) NULL,
	[Receiver_mobile] [varchar](10) NULL,
	[RepairMan] [varchar](100) NULL,
	[RepairStatus] [varchar](50) NULL,
	[ProdOutSrcDate] [date] NULL,
	[ProdINSrcDate] [date] NULL,
	[ProdRepairedDate] [date],
	[ChrageableAmt] [int],
	[statusRep] [varchar](10)NULL,
	[Outward] [varchar](10)NULL
)"

		Create_Table(Sql, "OtherproductDetails", ShowMsg)
	End Sub


	Public Sub CreateTables_FollowupStatus(ShowMsg As Boolean)

		Dim sql = "CREATE TABLE [dbo].[followupstatus](
					[fid] [int] IDENTITY(1,1) NOT NULL,
					[status] [varchar](100) NULL) ON [PRIMARY]"
		Create_Table(sql, "followupstatus", ShowMsg)

		OpenDatabaseObject()
		Try
			Dim Swq = "INSERT INTO followupstatus (status )VALUES
									('Followup'),
									('Support Call')"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
		CloseDatabaseObject()

	End Sub

	Public Sub CreateTables_Status(ShowMsg As Boolean)

		Dim sql = " CREATE TABLE [Status](
					[ID] [int] IDENTITY(1,1) NOT NULL,
					[status] [varchar](20) NULL)"
		Create_Table(sql, "Status", ShowMsg)

		OpenDatabaseObject()
		Try
			Dim Swq = "INSERT INTO Status (status )VALUES
									('Pending'),
									('Repaired'),
									('UnRepaired' ),
									('Not Repairable'),
									( 'Partial Repaired' )
"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
		CloseDatabaseObject()

	End Sub

	Public Sub CreateTables_WhatsAppMessage(ShowMsg As Boolean)

		Dim sql = "CREATE TABLE [WhatsAppMessage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](20) NULL,
	[textMsg] [varchar](255) NULL
) ON [PRIMARY]"
		Create_Table(sql, "Status", ShowMsg)

		OpenDatabaseObject()
		Try
			Dim Swq = "INSERT INTO WhatsAppMessage (status,textMsg )VALUES
									('Pending','Peding'),
									('Repaired','Repaired'),
									('UnRepaired','UnRepaired' ),
									('Not Repairable','Not Repaired'),
									( 'Partial Repaired','Partial Repired' )"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
		CloseDatabaseObject()

	End Sub

	Public Sub CreateTables_CompnayDetails(ShowMsg As Boolean)

		Dim sql = "CREATE TABLE [CompanyDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[mobileNo] [varchar](20) NULL,
	[Address] [varchar](225) NULL
)"
		Create_Table(sql, "CompanyDetails", ShowMsg)


	End Sub



	Public Sub CreateTables_Customer(ShowMsg As Boolean)
		Dim sql = "
CREATE TABLE Customer_reg(
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_name] [varchar](255) NULL,
	[cust_mobile] [varchar](10) NULL,
	[cust_email] [varchar](255) NULL,
	[cust_address] [varchar](255) NULL,
	[CompanyName] [varchar](255) NULL,
	[Secondmobile] [varchar](255) NULL)"
		Create_Table(sql, "CustomerRegistration", ShowMsg)
	End Sub

	Public Sub CreateTables_ActivityTable(ShowMsg As Boolean)
		Dim sql = "CREATE TABLE ActivityTable(
	Aid int  IDENTITY(1,1) NOT NULL,
	customerName  varchar(255) NOT NULL,
	Mobileno bigint NOT NULL,
	ADate Date,
	ATime varchar(20),
	Reason varchar(50),
	status varchar(50),
	decs varchar(255),
	remark varchar(255),
	CloseDate Date,
	CloseTime varchar(255),
	PreviousID varchar(255),
	taskAssign varchar(255),
    createdBy varchar(255),
    createdDate Date
) ON [PRIMARY]"
		Create_Table(sql, "ActivityTable", ShowMsg)
	End Sub

	Public Sub CreateTables_Login(ShowMsg As Boolean)

		Dim Sql = " CREATE TABLE login(" &
				   "ID INT NOT NULL IDENTITY(1,1)," &
				   " username  varchar(20)," &
				   " pswd  varchar(20)," &
					" role  varchar(20));"

		Create_Table(Sql, "login", ShowMsg)
	End Sub



	Public Sub CreateTables_colUmnFilter(ShowMsg As Boolean)

		Dim Sql = "CREATE TABLE [columnFilter](
	[id] [int] NULL,
	[ColName] [varchar](255) NULL,
	[ColStatus] [varchar](10) NULL,
	[DisplayName] [varchar](50) NULL) "

		Create_Table(Sql, "columnFilter", ShowMsg)

		OpenDatabaseObject()
		Try

			Dim Swq = "insert into columnFilter (id,ColName,ColStatus,DisplayName) VALUES
						(1,'ID','True','Job ID'),
						(2,'mobile','True','Mobile Number'),
						(3,'job_date','True','Job Date'),
						(4,'cust_name','True','Customer Name'),
						(5,'product_service','True','Product Services'),
						(6,'service_type','False','Services Type'),
						(7,'warranty','False','Warranty / AMC'),
						(8,'prblm_comp','True','Problem Complained'),
						(9,'prblm_observe','False','Problem Observed'),
						(10,'Estimate_value','False','Estimated Value'),
						( 11,'Estimate_date','False','Estimated Date'),
						(12,'Repaire_Done','True','Repair Status'),
						(13,'Job_status','True','Job Status'),
						(14,'Remark','True','Remarks'),
						(15,'name_of_user','True','Job Created by'),
						(16,'date_of_entry','False','Job Date'),
						(17,'modify_user_name','True','Job Modified'),
						(18,'date_of_modify','True','Modification Date'),
						(19,'company_name','False','Company Name'),
						(20,'date_repaire','False','Job Repaired Date'),
						(21,'job_delivery','False','Delivery Status'),
						(22,'job_delivery_date','False','Delivery Date'),
						(23,'Receiver','False','Job Received by'),
						(24,'RepaireDone_by','True','Repairing Done By'),
						(25,'Receiver_mobile','False','Receiver Mobile Number')"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
		CloseDatabaseObject()


	End Sub

	Public Sub CreateTables_OutSrcProductDetails(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [OutSrcProductDetails](
			[OutID] [int] IDENTITY(1,1) NOT NULL,
			[OutDate] [date] NULL,
			[Jobid] [int] NULL,
			[ProductName] [varchar](255) NULL,
			[SerialNo] [varchar](50) NULL,
			[OutPersonName] [varchar](50) NULL,
			[OutProduRemark] [varchar](255) NULL,
			[Retrun] [date] NULL,
			[RetrunStatus] [varchar](255) NULL,
			[ReturnRemark] [varchar](255) NULL,
			[ReceiverName] [varchar](100) NULL,
			[InID] [int] NULL,
			[estimated_value] [decimal](10, 6) NULL,
			[final_amt_taken] [decimal](10, 6) NULL,
			[RepaireName] [varchar](255)) "

		Create_Table(Sql, "OutSrcProductDetails", ShowMsg)
	End Sub


	Public Sub CreateTables_AutocompleteProblem(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [AutocompleteProblem](
					[id] [int] IDENTITY(1,1) NOT NULL,
					[name] [varchar](255) NULL)"
		Try
			Create_Table(Sql, "AutocompleteProblem", ShowMsg)

		Catch ex As Exception
			MsgBox("Error Creating Table AutoCompleteProblem").ToString()
		End Try
	End Sub

	Public Sub CreateTables_AutocompnyName(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [dbo].[AutoCompleteCmpnyName](
					[id] [int] IDENTITY(1,1) NOT NULL,
					[name] [varchar](255) NULL)"

		Create_Table(Sql, "AutoCompleteCmpnyName", ShowMsg)
	End Sub

	Public Sub CreateTables_AutoReapirerName(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [dbo].[AutocompleteRepaier](
				[id] [int] IDENTITY(1,1) NOT NULL,
				[name] [varchar](255) NULL)"

		Create_Table(Sql, "AutocompleteRepaier", ShowMsg)
	End Sub



	Public Sub CreateTables_Autocomplete(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [dbo].[AutoComplete](
					[ID] [int] IDENTITY(1,1) NOT NULL,
					[Name] [varchar](20) NULL)"

		Create_Table(Sql, "AutoComplete", ShowMsg)
	End Sub


	Public Sub CreateTables_AMC(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE [dbo].[AMC_Table]([Aid] [int] IDENTITY(1,1) NOT NULL,
		[Cid] [int] NOT NULL,[productName] [varchar](225) NULL,	[startDate] [date], [prveAID] [int] NULL,
	[endDate] [date] NULL) ON [PRIMARY]"

		Create_Table(Sql, "AMC_Table", ShowMsg)
	End Sub


	Public Sub CreateTables_DataVersion(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE DataVersion(
					[id] [int] IDENTITY(1,1) NOT NULL,
					[dataversion] [float] )"

		Create_Table(Sql, "DataVersion", ShowMsg)


		OpenDatabaseObject()
		Try

			Dim Swq = "INSERT INTO DataVersion (dataversion)VALUES
									(" & DataVersionRequired & ")"
			Dim comm As New SqlClient.SqlCommand(Swq, SQLConn)
			comm.ExecuteNonQuery()
			comm.Dispose()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try

		CloseDatabaseObject()


	End Sub



	Public Sub CreateTables_AutoProdcomplete(ShowMsg As Boolean)
		Dim Sql = "CREATE TABLE AutocompleteProduct(
					[id] [int] IDENTITY(1,1) NOT NULL,
					[name] [varchar](255) NULL)"

		Create_Table(Sql, "AutoComplete",ShowMsg)
	End Sub

	Public Sub Create_Table0(Sql_stm As String, TableName As String)

		If OpenDatabaseObject() = False Then
			MsgBox("Connection Invalid.").ToString()
			Exit Sub
		End If


		Dim NonQuery As String = ""
		Using cmd As New SqlCommand()
			cmd.Connection = SQLConn
			cmd.CommandText = Sql_stm
			Try
				cmd.ExecuteNonQuery()
				MsgBox("Create " & TableName & " Table Sucessfully.").ToString()
			Catch ex As Exception
				MsgBox(ex.Message).ToString()
			End Try
		End Using
	End Sub
End Module
