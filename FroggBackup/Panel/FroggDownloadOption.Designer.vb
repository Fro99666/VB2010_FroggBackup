<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggDownloadOption
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggDownloadOption))
        Me.DataGridOptLink = New System.Windows.Forms.DataGridView()
        Me.ProcessList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.inptDLPath = New System.Windows.Forms.TextBox()
        Me.downloadPath = New System.Windows.Forms.Label()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.inptDateTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialogPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.DLStatusBar = New System.Windows.Forms.StatusStrip()
        Me.DLToolBarTxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuDL = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgTitleDlOpt = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridOptLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DLStatusBar.SuspendLayout()
        Me.MenuDL.SuspendLayout()
        CType(Me.imgTitleDlOpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridOptLink
        '
        Me.DataGridOptLink.AllowUserToAddRows = False
        Me.DataGridOptLink.AllowUserToResizeColumns = False
        Me.DataGridOptLink.AllowUserToResizeRows = False
        Me.DataGridOptLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridOptLink.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridOptLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOptLink.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcessList})
        Me.DataGridOptLink.Location = New System.Drawing.Point(12, 171)
        Me.DataGridOptLink.Name = "DataGridOptLink"
        Me.DataGridOptLink.RowHeadersVisible = False
        Me.DataGridOptLink.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridOptLink.Size = New System.Drawing.Size(245, 190)
        Me.DataGridOptLink.TabIndex = 20
        '
        'ProcessList
        '
        Me.ProcessList.Frozen = True
        Me.ProcessList.HeaderText = "Link List To Download"
        Me.ProcessList.Name = "ProcessList"
        Me.ProcessList.ReadOnly = True
        Me.ProcessList.Width = 270
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(265, 171)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 50)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(265, 227)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(50, 50)
        Me.btnDel.TabIndex = 24
        Me.btnDel.Text = "-"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(265, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 50)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'inptDLPath
        '
        Me.inptDLPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inptDLPath.Location = New System.Drawing.Point(12, 95)
        Me.inptDLPath.Name = "inptDLPath"
        Me.inptDLPath.Size = New System.Drawing.Size(245, 20)
        Me.inptDLPath.TabIndex = 26
        '
        'downloadPath
        '
        Me.downloadPath.AutoSize = True
        Me.downloadPath.Location = New System.Drawing.Point(12, 77)
        Me.downloadPath.Name = "downloadPath"
        Me.downloadPath.Size = New System.Drawing.Size(79, 13)
        Me.downloadPath.TabIndex = 27
        Me.downloadPath.Text = "Download path"
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(265, 95)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(50, 23)
        Me.btnPath.TabIndex = 28
        Me.btnPath.Text = "Path"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'inptDateTime
        '
        Me.inptDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inptDateTime.Location = New System.Drawing.Point(12, 139)
        Me.inptDateTime.Mask = "00:00"
        Me.inptDateTime.Name = "inptDateTime"
        Me.inptDateTime.Size = New System.Drawing.Size(75, 20)
        Me.inptDateTime.TabIndex = 30
        Me.inptDateTime.Text = "0000"
        Me.inptDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inptDateTime.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Download Frequence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Hour(s) : Minute(s)"
        '
        'DLStatusBar
        '
        Me.DLStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DLToolBarTxt})
        Me.DLStatusBar.Location = New System.Drawing.Point(0, 370)
        Me.DLStatusBar.Name = "DLStatusBar"
        Me.DLStatusBar.Size = New System.Drawing.Size(325, 22)
        Me.DLStatusBar.SizingGrip = False
        Me.DLStatusBar.TabIndex = 33
        Me.DLStatusBar.Text = "StatusBar"
        '
        'DLToolBarTxt
        '
        Me.DLToolBarTxt.Name = "DLToolBarTxt"
        Me.DLToolBarTxt.Size = New System.Drawing.Size(0, 17)
        '
        'MenuDL
        '
        Me.MenuDL.AutoSize = False
        Me.MenuDL.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuDL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LanguageToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuDL.Location = New System.Drawing.Point(0, 47)
        Me.MenuDL.Name = "MenuDL"
        Me.MenuDL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuDL.Size = New System.Drawing.Size(327, 24)
        Me.MenuDL.TabIndex = 34
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.NotifyToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LogToolStripMenuItem.Checked = True
        Me.LogToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        Me.LogToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotifyToolStripMenuItem
        '
        Me.NotifyToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NotifyToolStripMenuItem.Checked = True
        Me.NotifyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotifyToolStripMenuItem.Name = "NotifyToolStripMenuItem"
        Me.NotifyToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NotifyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotifyToolStripMenuItem.Text = "Notify"
        Me.NotifyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgTitleDlOpt
        '
        Me.imgTitleDlOpt.Image = Global.FroggBackup.My.Resources.Resources.downloadoption
        Me.imgTitleDlOpt.Location = New System.Drawing.Point(0, 0)
        Me.imgTitleDlOpt.Name = "imgTitleDlOpt"
        Me.imgTitleDlOpt.Size = New System.Drawing.Size(325, 50)
        Me.imgTitleDlOpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgTitleDlOpt.TabIndex = 35
        Me.imgTitleDlOpt.TabStop = False
        '
        'FroggDownloadOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 392)
        Me.Controls.Add(Me.imgTitleDlOpt)
        Me.Controls.Add(Me.DLStatusBar)
        Me.Controls.Add(Me.MenuDL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inptDateTime)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.downloadPath)
        Me.Controls.Add(Me.inptDLPath)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridOptLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuDL
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FroggDownloadOption"
        Me.Text = "FroggDownload - Options"
        CType(Me.DataGridOptLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DLStatusBar.ResumeLayout(False)
        Me.DLStatusBar.PerformLayout()
        Me.MenuDL.ResumeLayout(False)
        Me.MenuDL.PerformLayout()
        CType(Me.imgTitleDlOpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridOptLink As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents ProcessList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents inptDLPath As System.Windows.Forms.TextBox
    Friend WithEvents downloadPath As System.Windows.Forms.Label
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents inptDateTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialogPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DLStatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents DLToolBarTxt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuDL As System.Windows.Forms.MenuStrip
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgTitleDlOpt As System.Windows.Forms.PictureBox
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
