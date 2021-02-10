Imports System.IO
Imports System.Net
Public Class SendMessage
    Public JobStatus As String
    Public MobileNoStatus As String
    Public fileExtension As String
    Public filePath As String

    Dim portNo As String
    Dim Url As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        portNo = ReadINI("PortNo", "Port", defultPort)
        Url = ReadINI("PortNo", "url", "")
        Dim Message As String = richTextBox1.Text.Replace(vbNewLine, "")

        Dim MobileNo As String = textBox1.Text

        If String.IsNullOrWhiteSpace(MobileNo) Then
            MsgBox("Please Enter Mobile No ").ToString()
            textBox1.BackColor = WarningBackgound
        End If

        Try
            If MobileNoStatus.Equals("India") Then
                MobileNo = "91" & MobileNo
            End If
            If String.IsNullOrWhiteSpace(filePath) = False Then
                If filePath.Contains("\\") = False Then
                    filePath = Replace(filePath, "\", "\\")
                    MsgBox(filePath)
                End If
            End If


            Dim JsonData As String = "{""filePath"":""" & filePath & """,""number"":""" & MobileNo & """,""msg"":""" & Message & """}"
            'MsgBox(JsonData)

            JsonData = WebUtility.UrlEncode(JsonData)
            Dim myRequest As HttpWebRequest = PostJSON(JsonData)
            'MsgBox("Response of Request:{0}", GetResponse(myRequest))
            GetResponse(myRequest)




            ' Dim inStream As StreamReader
            'Dim webRequest As WebRequest
            'Dim webresponse As WebResponse
            'WebRequest = WebRequest.Create("http://localhost:" & portNo & "/Send?WAPIMsg=" & Message & "&number=91" & MobileNo)


            'webresponse = webRequest.GetResponse()
            'inStream = New StreamReader(webresponse.GetResponseStream())
            ' Dim AvailCode As String = inStream.ReadToEnd()
            'MsgBox("AvailCode: " + AvailCode)


            '  Dim url As Uri = New Uri("http://localhost:" & portNo & "/Send?WAPIMsg=" & Message & "&number=" & MobileNo)
            'Dim webClient As New System.Net.WebClient
            'WebClient.DownloadStringAsync(url, "ddd")
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try

    End Sub

    Private Sub SendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Checked = True
        MobileNoStatus = "India"
        If String.IsNullOrWhiteSpace(ReadINI("PortNo", "Port", "")) Then
            WriteINI("PortNo", "Port", "4350")
        End If
        If String.IsNullOrWhiteSpace(JobStatus) = False Then
            LoadMessage()

        End If
    End Sub

    Private Function LoadMessage()
        Dim SQLAdapter As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        '  Dim i As Integer

        OpenDatabaseObject()

        sql = "Select * from WhatsAppMessage where status='" & JobStatus & "'"
        Try

            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()
            SQLAdapter.Fill(ds, "whatsapp_table")
            SQLAdapter.Dispose()
            richTextBox1.Text = ds.Tables(0).Rows(0).Item(2)

            SQLAdapter.Dispose()
            CloseDatabaseObject()
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Function





    Private Function PostJSON(ByVal JsonData As String) As HttpWebRequest

        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create("http://localhost:" & portNo & "/Send?Data=" + JsonData), HttpWebRequest)
            httpWebRequest.ContentType = "text/json"
            httpWebRequest.Method = "POST"
            httpWebRequest.Timeout = 2000

            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
                'streamWriter.Write(JsonData)
                streamWriter.Flush()
                streamWriter.Close()
            End Using
            objhttpWebRequest = httpWebRequest

        Catch ex As Exception
            'MsgBox("Send Request Error[{0}]", ex.Message).ToString()

            Return Nothing
        End Try

        Return objhttpWebRequest

    End Function

    Private Function GetResponse(ByVal httpWebRequest As HttpWebRequest) As String
        Dim strResponse As String = "Bad Request:400"
        Try
            Dim httpResponse = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                Dim result = streamReader.ReadToEnd()

                strResponse = result.ToString()
            End Using
        Catch ex As Exception
            ' MsgBox("GetResponse Error[{0}]", ex.Message)

            Return strResponse
        End Try

        Return strResponse

    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MobileNoStatus = "India"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        MobileNoStatus = "Other"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        customer_view.Close()
        If String.IsNullOrWhiteSpace(textBox1.Text) Then
            customer_view.EnableAutoClick = True
            'customer_view.btncust_update.Enabled = False
            'customer_view.btnshow.Enabled = False
            customer_view.handlerID = Me.Handle
            customer_view.WhatsAppVIEW = True
            customer_view.ShowDialog()
            Exit Sub
        End If

        If textBox1.Text.Length > 10 Or textBox1.Text.Length < 10 Then
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
        sql = "Select * from Customer_reg where cust_mobile ='" & textBox1.Text & "'"
        Try

            SQLAdapter = New SqlClient.SqlDataAdapter(sql, SQLConn)
            SQLAdapter.SelectCommand.ExecuteNonQuery()

            SQLAdapter.Fill(ds, "Customer_reg")

            For i = 0 To ds.Tables(0).Rows.Count - 1
                'txtmob.Text = ds.Tables(0).Rows(i).Item("cust_mobile")
                'txtcustname.Text = ds.Tables(0).Rows(i).Item("cust_name")
                If String.IsNullOrWhiteSpace(ds.Tables(0).Rows(i).Item("cust_mobile").ToString) Then
                    textBox1.Text = ""
                Else
                    customer_view.EnableAutoClick = True
                    customer_view.txtsrchstr.Text = textBox1.Text

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
                    AddCustomerDetails.txtmobp.Text = textBox1.Text
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtfileName_Click(sender As Object, e As EventArgs) Handles txtfileName.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "Image Files (JPG,PNG,PDF)|*.JPG;*.PNG;*.GIF;*.pdf"
        OpenFileDialog1.ShowDialog()
        filePath = OpenFileDialog1.FileName
        fileExtension = Path.GetExtension(OpenFileDialog1.FileName)

        TextBox2.Text = filePath
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        textBox1.BackColor = WhiteBackgound
    End Sub
End Class

