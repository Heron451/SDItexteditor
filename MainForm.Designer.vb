<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.openDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ttpHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(800, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Allows you to Open, Save, Create new files and, exit the application"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Creates a new text file"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Allows you to open an existing text file"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Allows you to Save the text file"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileSaveAs.Text = "Save &As"
        Me.mnuFileSaveAs.ToolTipText = "Allows you to save a new copy of the files with a new name"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exits the application"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "This menu is for options to edit files"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        Me.CopyToolStripMenuItem.ToolTipText = "Copies the highlighted text"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        Me.CutToolStripMenuItem.ToolTipText = "Deletes/Cuts the highlighted text"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        Me.PasteToolStripMenuItem.ToolTipText = "Pastes whatever data is in the clipboard"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "This section is about the software and the author of it"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 17)
        Me.lblStatus.Text = "Welcome!"
        Me.lblStatus.ToolTipText = "Displays application related messages"
        '
        'txtArea
        '
        Me.txtArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArea.Location = New System.Drawing.Point(0, 24)
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArea.Size = New System.Drawing.Size(800, 404)
        Me.txtArea.TabIndex = 1
        Me.ttpHelp.SetToolTip(Me.txtArea, "Enter text here")
        '
        'openDialog
        '
        Me.openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'saveDialog
        '
        Me.saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
	Friend WithEvents mnuFile As ToolStripMenuItem
	Friend WithEvents mnuFileNew As ToolStripMenuItem
	Friend WithEvents mnuFileOpen As ToolStripMenuItem
	Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents txtArea As TextBox
	Friend WithEvents openDialog As OpenFileDialog
	Friend WithEvents saveDialog As SaveFileDialog
	Friend WithEvents mnuFileSave As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ttpHelp As ToolTip
End Class
