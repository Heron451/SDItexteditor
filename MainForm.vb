'-----------------------------------------------------------------
'Author: Robin Hammond
'Student Number: 100773359
'Date: July 29, 2020.
'Last Modified: July 29, 2020.
'Course: NETD-2202-01 Net Development I
'Assignment: Lab 5
'File Name: MainForm.vb
'Description: In this lab we created a text editing application 
'from scratch. We created a form where users can create new files,
'open existing files and save existing or new files. We also created
'editing utilities for copy, cut and paste in the application.
'An about button was also created which displays a form with information
'about the creator of the application.
'-----------------------------------------------------------------

Option Strict On
Imports System.IO

Public Class MainForm
#Region "Variables"
	Dim docLocation As String = String.Empty 'This is a variable to hold the file location
	Dim docName As String  'This holds the document name
	Dim txtEdit As String = "Text Editor - " 'This variable holds the name of the application for the title bar
#End Region

#Region "Event Handlers"
	'This event handles the creating a new file 
	Private Sub NewFileClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click
		txtArea.Text = String.Empty
		lblStatus.Text = "New File Started"
		Me.Text = txtEdit
	End Sub
	'This event handler handles opening an existing text file
	Private Sub OpenFileClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
		Dim inputStream As StreamReader

		If openDialog.ShowDialog() = DialogResult.OK Then
			inputStream = New StreamReader(openDialog.FileName)
			txtArea.Text = inputStream.ReadToEnd()
			docName = openDialog.SafeFileName
			docLocation = openDialog.FileName
			inputStream.Close()
			lblStatus.Text = "Loaded File Successfully " & openDialog.FileName
			Me.Text = txtEdit & docName
		End If
	End Sub
	'This event handler handles the Save button event
	Private Sub SaveFileClick(sender As Object, e As EventArgs) Handles mnuFileSave.Click

		If docLocation = String.Empty Then
			If saveDialog.ShowDialog = DialogResult.OK Then
				docLocation = saveDialog.FileName
				FileSaved(docLocation)
			End If
		Else
			FileSaved(docLocation)
		End If

	End Sub

	'This event handler handles the Save As button event
	Private Sub SaveAsFileClick(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
		If saveDialog.ShowDialog() = DialogResult.OK Then
			docLocation = saveDialog.FileName
			FileSaved(docLocation)
		End If
	End Sub
	'This event handler handles the About button event and launches the About Form
	Private Sub AboutClick(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		Dim aboutModal As New AboutForm
		aboutModal.ShowDialog()
	End Sub
	'This event handler handles the Copy button event and copies the selected text to the clipboard
	Private Sub CopyItemClick(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
		If Me.txtArea.Text.Length > 0 Then
			Clipboard.SetDataObject(Me.txtArea.SelectedText)
			Me.txtArea.Copy()
			lblStatus.Text = "Copy Successful"
		End If
	End Sub
	'This event handler handles the Cut button event and makes a copy to the clipboard before cutting the selected text
	Private Sub CutItemClick(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
		If Me.txtArea.Text.Length > 0 Then
			Clipboard.SetDataObject(Me.txtArea.SelectedText)
			Me.txtArea.Cut()
			lblStatus.Text = "Cut Successful"
		End If
	End Sub
	'This event handler handles the Paste button event and pastes what's in the clipboard
	Private Sub PasteItemClick(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
		If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
			Me.txtArea.Paste()
			lblStatus.Text = "Paste Successful"
		End If
	End Sub
	'This event handler handles the Exit button event and closes the form
	Private Sub ExitClick(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub

#End Region

#Region "Functions and Sub Procedures"
	'This Sub Routine handles saving files
	Public Sub FileSaved(ByVal text As String)
		Dim outputStream As StreamWriter
		outputStream = New StreamWriter(text)
		outputStream.Write(txtArea.Text)
		docName = Path.GetFileName(text)
		outputStream.Close()
		lblStatus.Text = "File has been Saved"
		Me.Text = txtEdit & docName
	End Sub
#End Region


End Class
