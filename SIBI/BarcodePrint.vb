

Imports System.Runtime
Imports System.Runtime.InteropServices
Imports System.IO


Public Class BarcodePrint
    Dim filenm As String
    Dim ipaddres As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If Len(Trim(txtjobid.Text)) = 0 Then
			txtjobid.Focus()
			txtjobid.BackColor = WarningBackgound
			MsgBox("Please enter JobID").ToString()

			Exit Sub
		End If

		If CheckJobIDPresent(txtjobid.Text) = False Then
			MsgBox("Job Id Not Found").ToString()
			txtjobid.Focus()
			Exit Sub
		End If

		If String.IsNullOrWhiteSpace(Printcmb.Text.Trim) Then
			MsgBox("Please select Printer Name").ToString()
			Exit Sub
		End If


		If String.IsNullOrWhiteSpace(txtqty.Text) Or txtqty.Text = "0" Then
			MsgBox("Please enter QTY 1 or more").ToString()
			txtqty.BackColor = WarningBackgound
			txtqty.Focus()
			Exit Sub
		End If


		If (Not System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "BARCODE\")) Then
			System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "BARCODE\")
		End If


		Dim ReadPRN As String = "BARCODE\Job.PRN"
		Dim Stream As IO.StreamWriter = Nothing
		Dim Report As String
		Dim processCmd As Process = Nothing
		Dim CompanyName As String = "Sai Infotech"



		'Replace FileJobid
		Using TR As IO.StreamReader = New IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + ReadPRN, True)
			Report = TR.ReadToEnd()
			Report = Replace(Report, "<JobID>", txtjobid.Text, 1,, False)
			Report = Replace(Report, "<CompanyName>", UCase(CompanyName), 1,, CompareMethod.Text)

		End Using

		'Replace File content copy into another file

		If (Not System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "tmp\")) Then
			System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "tmp\")
		End If

		Dim FinalPRNFfile As String = Format(Now(), "yyyyddMMhhmmss") + ".txt"
		Dim TempFilePath As String = AppDomain.CurrentDomain.BaseDirectory + "tmp\"
		Dim FileNamePath As String = (TempFilePath + FinalPRNFfile)

		Stream = New IO.StreamWriter(FileNamePath, True)
		Stream.Write(Report)
		Stream.Flush()
		Stream.Close()

		'printername = Printcmb.Text
		Dim DeleteFlag As Boolean = False
		'MsgBox(Printcmb.Text + " " + FileNamePath)
		Dim count As Int16 = txtqty.Text
		printername = Printcmb.Text
		Dim i = 0
		While i < count

			If (RawPrinterHelper.SendFileToPrinter(printername, FileNamePath, FinalPRNFfile)) = True Then DeleteFlag = True
			i = i + 1
		End While
		'ReadDbSettingIni()

		'Dim CmdStr As String = "cmd.exe /k copy /b " & Chr(34) & FileNamePath & Chr(34) & "  " & Chr(34) & "\\" & ipaddres & "\" & Printcmb.Text & "" & Chr(34) & ""
		'MsgBox(CmdStr).ToString()
		'Dim ID = Shell(CmdStr,, vbTrue, 1000)

		If DeleteFlag = True Then My.Computer.FileSystem.DeleteFile(FileNamePath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
		'FileIO.RecycleOption.SendToRecycleBin

		'MsgBox(ID.ToString)
		''Delete File



	End Sub

	Private Sub PrinterList()

		Dim strdb As String = ReadINI("Printer", "PrinterName", "")

		Printcmb.Text = strdb
        Dim sPrinters As String = ""

		For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
			Printcmb.Items.Add(sPrinters)
		Next
		' localip.Text = "Local IP:" + "127.0.0.1"
	End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PrinterList()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub

	Private Sub Printcmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Printcmb.SelectedIndexChanged
		WriteINI("Printer", "PrinterName", Printcmb.SelectedItem)
	End Sub

	Private Sub txtjobid_KeyUp(sender As Object, e As KeyEventArgs) Handles txtjobid.KeyUp
		txtjobid.BackColor = WhiteBackgound
	End Sub
	Private Sub txtqty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtqty.KeyUp
		txtqty.BackColor = WhiteBackgound
	End Sub
End Class