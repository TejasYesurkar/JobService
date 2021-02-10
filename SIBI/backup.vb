Imports System.Data.SqlClient

Public Class backup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtfilepath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackUpData()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("Backup Done successfully..").ToString()
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub


    Private Sub BackUpData()

        Company_Name = RemoveSpecialChrforFolderName(Company_Name)
        If (Not System.IO.Directory.Exists(txtfilepath.Text & "\" & Company_Name)) Then
            System.IO.Directory.CreateDirectory(txtfilepath.Text & "\" & Company_Name)
        End If

        Timer1.Enabled = True
        ProgressBar1.Visible = True

        Try
            Dim dt As String = RemoveSpecialChrforFolderName(Format(Now(), "dd-MMM-yy-h:mm:ss tt"))
            OpenDatabaseObject()

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "BACKUP DATABASE " & DBName & " TO DISK='" & txtfilepath.Text & "/" & Company_Name & "/" & dt & ".bak'"
            cmd.Connection = SQLConn
            cmd.ExecuteNonQuery()

            SQLConn.Close()
            WriteINI("Backup", "DbPath_" & DBName, txtfilepath.Text)
            WriteINI("Backup", "DbCmpnyName", Company_Name)
            WriteINI("Backup", "LDbdate", Format(Now(), "dd-MMM-yy"))
            WriteINI("Backup", "LDbTime", Format(Now(), "h:mm:ss tt"))

        Catch ex As Exception
            MsgBox(ex.ToString).ToString()
        End Try

    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CpmnyName()
        txtdb.Text = DBName
        txtserver.Text = DBIPAddress
        txtfilepath.Text = ReadINI("Backup", "DbPath_" & DBName, "")
        txtbackup.Text = ReadINI("Backup", "LDbdate", "") & " " & ReadINI("Backup", "LDbTime", "")
    End Sub
End Class