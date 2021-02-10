Public Class PageSettingForm
    Private Sub printPageSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Thermal Print")
        ComboBox1.Items.Add("Laser Print")
        ComboBox1.Text = "Thermal Print"
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Legal")
        ComboBox2.Items.Add("A4")
        ComboBox2.Items.Add("A5")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsave.Click

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
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

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
            Else
                txtbot.Clear()
                txtpaperheight.Clear()
                txtleft.Clear()
                txtright.Clear()

                txttop.Clear()
                txtpaperwidth.Clear()
                txtwidth.Clear()
                ComboBox2.Text = " "
            End If
        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try
    End Sub
End Class

