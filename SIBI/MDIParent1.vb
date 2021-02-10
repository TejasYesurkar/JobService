Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class MDIParent1

	'Public Shared SQLConn As SqlClient.SqlConnection 'OleDb.OleDbConnection

	Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click

		AddToolStripMenuItem.PerformClick()

	End Sub

	Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
		'Dim OpenFileDialog As New OpenFileDialog
		'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		'OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
		'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
		'Dim FileName As String = OpenFileDialog.FileName
		' TODO: Add code here to open the file.
		'End If

		' Create a new instance of the child form.
		Dim ChildForm As New display_JOBDetails
		' Make it a child of this MDI form before showing it.
		ChildForm.MdiParent = Me

		m_ChildFormNumber += 1
		ChildForm.Text = "Window " & m_ChildFormNumber

		ChildForm.Show()
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim SaveFileDialog As New SaveFileDialog
		SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

		If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
			Dim FileName As String = SaveFileDialog.FileName
			' TODO: Add code here to save the current contents of the form to a file.
		End If
	End Sub


	Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

		UNLOAD_ALL_FORMS()
		Me.Close()

	End Sub

	Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
	End Sub

	Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
	End Sub

	Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
	End Sub




	Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.ArrangeIcons)
	End Sub

	Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		' Close all child forms of the parent.
		For Each ChildForm As Form In Me.MdiChildren
			ChildForm.Close()
		Next
	End Sub

	Private m_ChildFormNumber As Integer

	Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
		Dim ChildFor As New AddJobDetails
		' Make it a child of this MDI form before showing it.
		AddJobDetails.MdiParent = Me

		m_ChildFormNumber += 2
		'ChildFor.Text = "Window " & m_ChildFormNumber

		AddJobDetails.Show()
		'  Form1.Show()

		' Form1.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		AddJobDetails.WindowState = FormWindowState.Maximized

		' Form1.btnupdate.Visible = False
	End Sub




	Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
		Dim ChildFor As New display_JOBDetails
		' Make it a child of this MDI form before showing it.
		display_JOBDetails.MdiParent = Me

		m_ChildFormNumber += 3
		'ChildFor.Text = "Window " & m_ChildFormNumber

		display_JOBDetails.Show()
		'  Form1.Show()

		'   display_data.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		display_JOBDetails.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub TransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem.Click

	End Sub

	Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New AddCustomerDetails
		AddCustomerDetails.btncust_update.Enabled = False
		AddCustomerDetails.btncust_update.Visible = False

		AddCustomerDetails.btnok.Enabled = True
		AddCustomerDetails.btnok.Visible = True
		' Make it a child of this MDI form before showing it.
		AddCustomerDetails.MdiParent = Me

		m_ChildFormNumber += 4
		'ChildFor.Text = "Window " & m_ChildFormNumber

		AddCustomerDetails.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		AddCustomerDetails.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New customer_view
		' Make it a child of this MDI form before showing it.
		customer_view.MdiParent = Me

		m_ChildFormNumber += 9
		'ChildFor.Text = "Window " & m_ChildFormNumber

		customer_view.Show()
		'  Form1.Show()

		'        customer_view.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		customer_view.WindowState = FormWindowState.Maximized

	End Sub

	Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If String.IsNullOrWhiteSpace(ReadINI("PortNo", "Port", "")) Then
			WriteINI("PortNo", "Port", defultPort)
			WriteINI("PortNo", "url", "http://localhost:" & defultPort)
		End If

		Me.IsMdiContainer = True
		Me.WindowState = FormWindowState.Maximized

		Dim ChildFor As New Dashboard

		' Make it a child of this MDI form before showing it.
		Dashboard.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		Dashboard.Show()

		Dashboard.WindowState = FormWindowState.Maximized
		'Login.ShowDialog()
		If Len(session) = 0 Then Me.Close()
		MsgBox("Hello  " & session & " !").ToString()

	End Sub

	Private Sub JobRepaireToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New JobRepaire


		' Make it a child of this MDI form before showing it.
		JobRepaire.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		JobRepaire.Show()

		JobRepaire.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'Dim ChildForm As New PrintRecipt
		' Make it a child of this MDI form before showing it.
		'ChildForm.MdiParent = Me

		'm_ChildFormNumber += 1
		'ChildForm.Text = "Window " & m_ChildFormNumber

		'ChildForm.Show()
	End Sub

	Private Sub UNLOAD_ALL_FORMS()

		Dim objforms As Form
		'Try
		On Error Resume Next
		For Each objforms In Application.OpenForms
			MsgBox(objforms.Name).ToString()
			objforms.Close()
		Next

		'Catch ex As Exception
		'MsgBox(ex).ToString()

		'End Try

	End Sub


	Private Sub MDIParent1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
		UNLOAD_ALL_FORMS()
		Me.Close()
		CloseDatabaseObject()
		End
	End Sub

	Private Sub BarcodePrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New BarcodePrint

		' Make it a child of this MDI form before showing it.
		BarcodePrint.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		BarcodePrint.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		BarcodePrint.WindowState = FormWindowState.Maximized

	End Sub


	Private Sub OutwardDetalisAddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutwardDetalisAddToolStripMenuItem.Click
		Dim ChildFor As New OutSrcProd

		' Make it a child of this MDI form before showing it.
		OutSrcProd.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		OutSrcProd.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		OutSrcProd.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub InvertedDetalisAddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertedDetalisAddToolStripMenuItem.Click
		Dim ChildFor As New inverted_Form

		' Make it a child of this MDI form before showing it.
		inverted_Form.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		inverted_Form.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		inverted_Form.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ModifyUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New ModifyUser
		'	ModifyUser.MdiParent = Me

		'm_ChildFormNumber += 8


		ModifyUser.ShowDialog()


		'ModifyUser.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New Registration


		' Make it a child of this MDI form before showing it.
		Registration.MdiParent = Me

		m_ChildFormNumber += 8
		'ChildFor.Text = "Window " & m_ChildFormNumber

		Registration.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		Registration.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub MDIParent1_Closed(sender As Object, e As EventArgs) Handles Me.Closed





		For Each f As Form In My.Application.OpenForms
			'MsgBox(f.Name)

			f.Close()

		Next
		End


	End Sub

	Private Sub MDIParent1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If (MsgBox("Would you like to close the application (Y/N)?", vbApplicationModal + vbYesNo, "Quit....")) = vbNo Then
			e.Cancel = True
		Else
			If (Format(Now(), "dd-MMM-yy") = ReadINI("Backup", "LDbdate", "")) = False Then
				If (MsgBox("Last Backup date:" & ReadINI("Backup", "LDbdate", "") & vbNewLine & " Would you like to take Backup of application (Y/N)?", vbApplicationModal + vbYesNo + vbExclamation, "Backup")) = vbYes Then
					backup.ShowDialog()
				Else
					Try
						Dim dt1 As DateTime = Convert.ToDateTime(Format(Now(), "dd-MMM-yy"))
						Dim dt2 As DateTime = Convert.ToDateTime(ReadINI("Backup", "LDbdate", ""))
						If Convert.ToInt32(dt1.Subtract(dt2).Days) >= 3 Then
							MsgBox("Back Is Not taken From " & Convert.ToInt32(dt1.Subtract(dt2).Days) & " Days", vbExclamation, "Alert.!!")
						End If
					Catch ex As Exception
						'MsgBox(ex.ToString).ToString()
					End Try
				End If
			End If
		End If
	End Sub

	Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

	End Sub

	Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New Dashboard

		' Make it a child of this MDI form before showing it.
		Dashboard.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		Dashboard.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		Dashboard.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New ActivityAddForm

		' Make it a child of this MDI form before showing it.
		ActivityAddForm.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		ActivityAddForm.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		ActivityAddForm.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub AddActivityItemToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New AddActivtyItem

		AddActivtyItem.Show()

	End Sub

	Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New frmPrinting

		frmPrinting.Show()

	End Sub

	Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
		Dim ChildFor As New AddCustomerDetails
		AddCustomerDetails.btncust_update.Enabled = False
		AddCustomerDetails.btncust_update.Visible = False

		AddCustomerDetails.btnok.Enabled = True
		AddCustomerDetails.btnok.Visible = True
		' Make it a child of this MDI form before showing it.
		AddCustomerDetails.MdiParent = Me

		m_ChildFormNumber += 4
		'ChildFor.Text = "Window " & m_ChildFormNumber

		AddCustomerDetails.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		AddCustomerDetails.WindowState = FormWindowState.Maximized

	End Sub

	Private Sub DayReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayReportToolStripMenuItem.Click
		Dim ChildFor As New customer_view
		' Make it a child of this MDI form before showing it.
		customer_view.MdiParent = Me

		m_ChildFormNumber += 9
		'ChildFor.Text = "Window " & m_ChildFormNumber

		customer_view.Show()
		'  Form1.Show()

		'        customer_view.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		customer_view.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click

	End Sub

	Private Sub HelpMenu_Click(sender As Object, e As EventArgs) Handles HelpMenu.Click
		Dim ChildFor As New Dashboard

		' Make it a child of this MDI form before showing it.
		Dashboard.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		Dashboard.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		Dashboard.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub JobRepiredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobRepiredToolStripMenuItem.Click
		Dim ChildFor As New JobRepaire

		' Make it a child of this MDI form before showing it.
		JobRepaire.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		JobRepaire.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		JobRepaire.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub JobDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobDeliveryToolStripMenuItem.Click
		Dim ChildFor As New job_delivery


		' Make it a child of this MDI form before showing it.
		job_delivery.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		job_delivery.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		job_delivery.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub BarcodePrintToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BarcodePrintToolStripMenuItem.Click
		Dim ChildFor As New BarcodePrint

		' Make it a child of this MDI form before showing it.
		BarcodePrint.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		BarcodePrint.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		BarcodePrint.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub DataBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBackupToolStripMenuItem.Click
		Dim ChildFor As New backup

		backup.ShowDialog()

	End Sub

	Private Sub TodayFollowUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodayFollowUpToolStripMenuItem.Click
		Dim ChildFor As New ActivityAddForm


		' Make it a child of this MDI form before showing it.
		ActivityAddForm.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		ActivityAddForm.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		ActivityAddForm.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub AddFollowUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFollowUpToolStripMenuItem.Click
		Dim ChildFor As New followupAdd


		' Make it a child of this MDI form before showing it.
		followupAdd.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		followupAdd.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		followupAdd.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
		Dim ChildFor As New ShowAllFollowUp

		' Make it a child of this MDI form before showing it.
		ShowAllFollowUp.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		ShowAllFollowUp.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		ShowAllFollowUp.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
		Dim ChildFor As New ActivityAddForm


		' Make it a child of this MDI form before showing it.
		ActivityAddForm.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		ActivityAddForm.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		ActivityAddForm.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub PageSettingToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New PageSettingForm

		PageSettingForm.ShowDialog()
	End Sub

	Private Sub AddCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New AddCompanyDetails

		AddCompanyDetails.ShowDialog()

	End Sub

	Private Sub ConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigToolStripMenuItem.Click
		Dim ChildFor As New config

		config.ShowDialog()
	End Sub


	Private Sub ResponisveToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim ChildFor As New JobResponsive



		' Make it a child of this MDI form before showing it.
		JobResponsive.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		JobResponsive.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		JobResponsive.WindowState = FormWindowState.Maximized
	End Sub



	Private Sub WhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsAppToolStripMenuItem.Click
		Dim ChildFor As New SendMessage

		' Make it a child of this MDI form before showing it.
		SendMessage.MdiParent = Me

		m_ChildFormNumber += 7
		'ChildFor.Text = "Window " & m_ChildFormNumber

		SendMessage.Show()
		'  Form1.Show()

		'  popup.btnupdate.Enabled = False

		' Make it a child of this MDI form before showing it.
		SendMessage.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub FollowUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FollowUpToolStripMenuItem.Click

	End Sub

	Private Sub AddAMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAMCToolStripMenuItem.Click
		Dim ChildFor As New AmcAdd

		SendMessage.MdiParent = Me

		m_ChildFormNumber += 7

		AmcAdd.ShowDialog()

		AmcAdd.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub ViewAMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAMCToolStripMenuItem.Click
		Dim ChildFor As New ViewAMC

		SendMessage.MdiParent = Me

		m_ChildFormNumber += 7

		ViewAMC.ShowDialog()

		ViewAMC.WindowState = FormWindowState.Maximized
	End Sub
End Class


