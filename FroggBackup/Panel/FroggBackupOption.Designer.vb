<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggBackupOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggBackupOption))
        Me.TabOption = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.optFileTxtEx = New System.Windows.Forms.Label()
        Me.optFileTxtSel = New System.Windows.Forms.Label()
        Me.optFileTxtSrc = New System.Windows.Forms.Label()
        Me.treeLocalPath = New System.Windows.Forms.TreeView()
        Me.ListSelected = New System.Windows.Forms.ListBox()
        Me.ListExcluded = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.optTypeImg1 = New System.Windows.Forms.PictureBox()
        Me.optTypeImg2 = New System.Windows.Forms.PictureBox()
        Me.optTypeTxt2 = New System.Windows.Forms.RichTextBox()
        Me.optTypeTxt1 = New System.Windows.Forms.RichTextBox()
        Me.optTypeTxt0 = New System.Windows.Forms.RichTextBox()
        Me.optTypeTitle = New System.Windows.Forms.Label()
        Me.optType2 = New System.Windows.Forms.RadioButton()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.optType0 = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.optDateTime = New System.Windows.Forms.MaskedTextBox()
        Me.optDateRepeat = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.optDateRepeatHour = New System.Windows.Forms.Label()
        Me.optDateRepeatTime = New System.Windows.Forms.MaskedTextBox()
        Me.optDateRepeat1 = New System.Windows.Forms.CheckBox()
        Me.optDateTitle = New System.Windows.Forms.Label()
        Me.optDateText = New System.Windows.Forms.Label()
        Me.optDateDay = New System.Windows.Forms.GroupBox()
        Me.optDateDay1 = New System.Windows.Forms.CheckBox()
        Me.optDateDay2 = New System.Windows.Forms.CheckBox()
        Me.optDateDay7 = New System.Windows.Forms.CheckBox()
        Me.optDateDay3 = New System.Windows.Forms.CheckBox()
        Me.optDateDay6 = New System.Windows.Forms.CheckBox()
        Me.optDateDay4 = New System.Windows.Forms.CheckBox()
        Me.optDateDay5 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth = New System.Windows.Forms.GroupBox()
        Me.optDateMonth2 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth12 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth1 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth11 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth3 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth10 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth4 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth9 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth5 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth8 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth6 = New System.Windows.Forms.CheckBox()
        Me.optDateMonth7 = New System.Windows.Forms.CheckBox()
        Me.optDateDate = New System.Windows.Forms.DateTimePicker()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.TabOption.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optTypeImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optTypeImg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.optDateRepeat.SuspendLayout()
        Me.optDateDay.SuspendLayout()
        Me.optDateMonth.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabOption
        '
        Me.TabOption.Controls.Add(Me.TabPage1)
        Me.TabOption.Controls.Add(Me.TabPage2)
        Me.TabOption.Controls.Add(Me.TabPage3)
        Me.TabOption.Location = New System.Drawing.Point(12, 12)
        Me.TabOption.Name = "TabOption"
        Me.TabOption.SelectedIndex = 0
        Me.TabOption.Size = New System.Drawing.Size(576, 352)
        Me.TabOption.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.optFileTxtEx)
        Me.TabPage1.Controls.Add(Me.optFileTxtSel)
        Me.TabPage1.Controls.Add(Me.optFileTxtSrc)
        Me.TabPage1.Controls.Add(Me.treeLocalPath)
        Me.TabPage1.Controls.Add(Me.ListSelected)
        Me.TabPage1.Controls.Add(Me.ListExcluded)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(568, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Backup Folder List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'optFileTxtEx
        '
        Me.optFileTxtEx.AutoSize = True
        Me.optFileTxtEx.Location = New System.Drawing.Point(287, 207)
        Me.optFileTxtEx.Name = "optFileTxtEx"
        Me.optFileTxtEx.Size = New System.Drawing.Size(51, 13)
        Me.optFileTxtEx.TabIndex = 7
        Me.optFileTxtEx.Text = "Excluded"
        '
        'optFileTxtSel
        '
        Me.optFileTxtSel.AutoSize = True
        Me.optFileTxtSel.Location = New System.Drawing.Point(287, 2)
        Me.optFileTxtSel.Name = "optFileTxtSel"
        Me.optFileTxtSel.Size = New System.Drawing.Size(49, 13)
        Me.optFileTxtSel.TabIndex = 6
        Me.optFileTxtSel.Text = "Selected"
        '
        'optFileTxtSrc
        '
        Me.optFileTxtSrc.AutoSize = True
        Me.optFileTxtSrc.Location = New System.Drawing.Point(6, 3)
        Me.optFileTxtSrc.Name = "optFileTxtSrc"
        Me.optFileTxtSrc.Size = New System.Drawing.Size(41, 13)
        Me.optFileTxtSrc.TabIndex = 5
        Me.optFileTxtSrc.Text = "Source"
        '
        'treeLocalPath
        '
        Me.treeLocalPath.CheckBoxes = True
        Me.treeLocalPath.Location = New System.Drawing.Point(6, 20)
        Me.treeLocalPath.Name = "treeLocalPath"
        Me.treeLocalPath.Size = New System.Drawing.Size(275, 299)
        Me.treeLocalPath.TabIndex = 0
        '
        'ListSelected
        '
        Me.ListSelected.FormattingEnabled = True
        Me.ListSelected.Location = New System.Drawing.Point(287, 19)
        Me.ListSelected.Name = "ListSelected"
        Me.ListSelected.Size = New System.Drawing.Size(275, 186)
        Me.ListSelected.TabIndex = 3
        '
        'ListExcluded
        '
        Me.ListExcluded.FormattingEnabled = True
        Me.ListExcluded.Location = New System.Drawing.Point(287, 224)
        Me.ListExcluded.Name = "ListExcluded"
        Me.ListExcluded.Size = New System.Drawing.Size(275, 95)
        Me.ListExcluded.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.optTypeImg1)
        Me.TabPage2.Controls.Add(Me.optTypeImg2)
        Me.TabPage2.Controls.Add(Me.optTypeTxt2)
        Me.TabPage2.Controls.Add(Me.optTypeTxt1)
        Me.TabPage2.Controls.Add(Me.optTypeTxt0)
        Me.TabPage2.Controls.Add(Me.optTypeTitle)
        Me.TabPage2.Controls.Add(Me.optType2)
        Me.TabPage2.Controls.Add(Me.optType1)
        Me.TabPage2.Controls.Add(Me.optType0)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(568, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Backup Type"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FroggBackup.My.Resources.Resources.bkTypeMirror
        Me.PictureBox1.Location = New System.Drawing.Point(321, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'optTypeImg1
        '
        Me.optTypeImg1.Image = Global.FroggBackup.My.Resources.Resources.bkTypeSync
        Me.optTypeImg1.Location = New System.Drawing.Point(321, 141)
        Me.optTypeImg1.Name = "optTypeImg1"
        Me.optTypeImg1.Size = New System.Drawing.Size(222, 69)
        Me.optTypeImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.optTypeImg1.TabIndex = 11
        Me.optTypeImg1.TabStop = False
        '
        'optTypeImg2
        '
        Me.optTypeImg2.Image = Global.FroggBackup.My.Resources.Resources.bkTypeFull
        Me.optTypeImg2.Location = New System.Drawing.Point(321, 55)
        Me.optTypeImg2.Name = "optTypeImg2"
        Me.optTypeImg2.Size = New System.Drawing.Size(222, 69)
        Me.optTypeImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.optTypeImg2.TabIndex = 10
        Me.optTypeImg2.TabStop = False
        '
        'optTypeTxt2
        '
        Me.optTypeTxt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.optTypeTxt2.Location = New System.Drawing.Point(51, 78)
        Me.optTypeTxt2.Name = "optTypeTxt2"
        Me.optTypeTxt2.Size = New System.Drawing.Size(258, 44)
        Me.optTypeTxt2.TabIndex = 9
        Me.optTypeTxt2.Text = "Save backup is a one direction save, al files from sources are sent to destinatio" & _
    "n. If the file no more exist in source, this file will be kept on destination."
        '
        'optTypeTxt1
        '
        Me.optTypeTxt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.optTypeTxt1.Location = New System.Drawing.Point(51, 151)
        Me.optTypeTxt1.Name = "optTypeTxt1"
        Me.optTypeTxt1.Size = New System.Drawing.Size(258, 59)
        Me.optTypeTxt1.TabIndex = 8
        Me.optTypeTxt1.Text = "Synchronize two folders (source and destination), updated files are copied in bot" & _
    "h directions, usually with the purpose of keeping the two locations identical to" & _
    " each other."
        '
        'optTypeTxt0
        '
        Me.optTypeTxt0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.optTypeTxt0.Location = New System.Drawing.Point(51, 239)
        Me.optTypeTxt0.Name = "optTypeTxt0"
        Me.optTypeTxt0.Size = New System.Drawing.Size(258, 67)
        Me.optTypeTxt0.TabIndex = 7
        Me.optTypeTxt0.Text = resources.GetString("optTypeTxt0.Text")
        '
        'optTypeTitle
        '
        Me.optTypeTitle.AutoSize = True
        Me.optTypeTitle.Location = New System.Drawing.Point(11, 20)
        Me.optTypeTitle.Name = "optTypeTitle"
        Me.optTypeTitle.Size = New System.Drawing.Size(111, 13)
        Me.optTypeTitle.TabIndex = 3
        Me.optTypeTitle.Text = "Choose backup type :"
        '
        'optType2
        '
        Me.optType2.AutoSize = True
        Me.optType2.Location = New System.Drawing.Point(22, 55)
        Me.optType2.Name = "optType2"
        Me.optType2.Size = New System.Drawing.Size(80, 17)
        Me.optType2.TabIndex = 2
        Me.optType2.Text = "Full backup"
        Me.optType2.UseVisualStyleBackColor = True
        '
        'optType1
        '
        Me.optType1.AutoSize = True
        Me.optType1.Location = New System.Drawing.Point(22, 128)
        Me.optType1.Name = "optType1"
        Me.optType1.Size = New System.Drawing.Size(88, 17)
        Me.optType1.TabIndex = 1
        Me.optType1.Text = "Sync backup"
        Me.optType1.UseVisualStyleBackColor = True
        '
        'optType0
        '
        Me.optType0.AutoSize = True
        Me.optType0.Checked = True
        Me.optType0.Location = New System.Drawing.Point(22, 216)
        Me.optType0.Name = "optType0"
        Me.optType0.Size = New System.Drawing.Size(90, 17)
        Me.optType0.TabIndex = 0
        Me.optType0.TabStop = True
        Me.optType0.Text = "Mirror backup"
        Me.optType0.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.optDateTime)
        Me.TabPage3.Controls.Add(Me.optDateRepeat)
        Me.TabPage3.Controls.Add(Me.optDateTitle)
        Me.TabPage3.Controls.Add(Me.optDateText)
        Me.TabPage3.Controls.Add(Me.optDateDay)
        Me.TabPage3.Controls.Add(Me.optDateMonth)
        Me.TabPage3.Controls.Add(Me.optDateDate)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(568, 326)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backup planification"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'optDateTime
        '
        Me.optDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optDateTime.Location = New System.Drawing.Point(181, 61)
        Me.optDateTime.Mask = "00:00"
        Me.optDateTime.Name = "optDateTime"
        Me.optDateTime.Size = New System.Drawing.Size(75, 20)
        Me.optDateTime.TabIndex = 29
        Me.optDateTime.Text = "0000"
        Me.optDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.optDateTime.ValidatingType = GetType(Date)
        '
        'optDateRepeat
        '
        Me.optDateRepeat.Controls.Add(Me.RichTextBox1)
        Me.optDateRepeat.Controls.Add(Me.optDateRepeatHour)
        Me.optDateRepeat.Controls.Add(Me.optDateRepeatTime)
        Me.optDateRepeat.Controls.Add(Me.optDateRepeat1)
        Me.optDateRepeat.Location = New System.Drawing.Point(396, 93)
        Me.optDateRepeat.Name = "optDateRepeat"
        Me.optDateRepeat.Size = New System.Drawing.Size(154, 216)
        Me.optDateRepeat.TabIndex = 26
        Me.optDateRepeat.TabStop = False
        Me.optDateRepeat.Text = "Repeat"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(124, 112)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = "if the repeat option is selected, the back up will be repeat all x hour(s) only f" & _
    "or month(s) and day(s) selected. backup will not be started for unselected dates" & _
    "."
        '
        'optDateRepeatHour
        '
        Me.optDateRepeatHour.AutoSize = True
        Me.optDateRepeatHour.Location = New System.Drawing.Point(104, 31)
        Me.optDateRepeatHour.Name = "optDateRepeatHour"
        Me.optDateRepeatHour.Size = New System.Drawing.Size(39, 13)
        Me.optDateRepeatHour.TabIndex = 29
        Me.optDateRepeatHour.Text = "hour(s)"
        '
        'optDateRepeatTime
        '
        Me.optDateRepeatTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optDateRepeatTime.Location = New System.Drawing.Point(62, 28)
        Me.optDateRepeatTime.Mask = "00:00"
        Me.optDateRepeatTime.Name = "optDateRepeatTime"
        Me.optDateRepeatTime.Size = New System.Drawing.Size(36, 20)
        Me.optDateRepeatTime.TabIndex = 28
        Me.optDateRepeatTime.Text = "0100"
        Me.optDateRepeatTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.optDateRepeatTime.ValidatingType = GetType(Date)
        '
        'optDateRepeat1
        '
        Me.optDateRepeat1.AutoSize = True
        Me.optDateRepeat1.Location = New System.Drawing.Point(12, 30)
        Me.optDateRepeat1.Name = "optDateRepeat1"
        Me.optDateRepeat1.Size = New System.Drawing.Size(50, 17)
        Me.optDateRepeat1.TabIndex = 0
        Me.optDateRepeat1.Text = "each"
        Me.optDateRepeat1.UseVisualStyleBackColor = True
        '
        'optDateTitle
        '
        Me.optDateTitle.AutoSize = True
        Me.optDateTitle.Location = New System.Drawing.Point(11, 20)
        Me.optDateTitle.Name = "optDateTitle"
        Me.optDateTitle.Size = New System.Drawing.Size(138, 13)
        Me.optDateTitle.TabIndex = 25
        Me.optDateTitle.Text = "Choose backup frequency :"
        '
        'optDateText
        '
        Me.optDateText.AutoSize = True
        Me.optDateText.Location = New System.Drawing.Point(17, 64)
        Me.optDateText.Name = "optDateText"
        Me.optDateText.Size = New System.Drawing.Size(55, 13)
        Me.optDateText.TabIndex = 23
        Me.optDateText.Text = "Date Start"
        '
        'optDateDay
        '
        Me.optDateDay.Controls.Add(Me.optDateDay1)
        Me.optDateDay.Controls.Add(Me.optDateDay2)
        Me.optDateDay.Controls.Add(Me.optDateDay7)
        Me.optDateDay.Controls.Add(Me.optDateDay3)
        Me.optDateDay.Controls.Add(Me.optDateDay6)
        Me.optDateDay.Controls.Add(Me.optDateDay4)
        Me.optDateDay.Controls.Add(Me.optDateDay5)
        Me.optDateDay.Location = New System.Drawing.Point(241, 93)
        Me.optDateDay.Name = "optDateDay"
        Me.optDateDay.Size = New System.Drawing.Size(145, 217)
        Me.optDateDay.TabIndex = 22
        Me.optDateDay.TabStop = False
        Me.optDateDay.Text = "Day"
        '
        'optDateDay1
        '
        Me.optDateDay1.AutoSize = True
        Me.optDateDay1.Location = New System.Drawing.Point(18, 30)
        Me.optDateDay1.Name = "optDateDay1"
        Me.optDateDay1.Size = New System.Drawing.Size(64, 17)
        Me.optDateDay1.TabIndex = 2
        Me.optDateDay1.Text = "Monday"
        Me.optDateDay1.UseVisualStyleBackColor = True
        '
        'optDateDay2
        '
        Me.optDateDay2.AutoSize = True
        Me.optDateDay2.Location = New System.Drawing.Point(18, 55)
        Me.optDateDay2.Name = "optDateDay2"
        Me.optDateDay2.Size = New System.Drawing.Size(67, 17)
        Me.optDateDay2.TabIndex = 3
        Me.optDateDay2.Text = "Tuesday"
        Me.optDateDay2.UseVisualStyleBackColor = True
        '
        'optDateDay7
        '
        Me.optDateDay7.AutoSize = True
        Me.optDateDay7.Location = New System.Drawing.Point(18, 180)
        Me.optDateDay7.Name = "optDateDay7"
        Me.optDateDay7.Size = New System.Drawing.Size(62, 17)
        Me.optDateDay7.TabIndex = 8
        Me.optDateDay7.Text = "Sunday"
        Me.optDateDay7.UseVisualStyleBackColor = True
        '
        'optDateDay3
        '
        Me.optDateDay3.AutoSize = True
        Me.optDateDay3.Location = New System.Drawing.Point(18, 80)
        Me.optDateDay3.Name = "optDateDay3"
        Me.optDateDay3.Size = New System.Drawing.Size(83, 17)
        Me.optDateDay3.TabIndex = 4
        Me.optDateDay3.Text = "Wednesday"
        Me.optDateDay3.UseVisualStyleBackColor = True
        '
        'optDateDay6
        '
        Me.optDateDay6.AutoSize = True
        Me.optDateDay6.Location = New System.Drawing.Point(18, 155)
        Me.optDateDay6.Name = "optDateDay6"
        Me.optDateDay6.Size = New System.Drawing.Size(68, 17)
        Me.optDateDay6.TabIndex = 7
        Me.optDateDay6.Text = "Saturday"
        Me.optDateDay6.UseVisualStyleBackColor = True
        '
        'optDateDay4
        '
        Me.optDateDay4.AutoSize = True
        Me.optDateDay4.Location = New System.Drawing.Point(18, 105)
        Me.optDateDay4.Name = "optDateDay4"
        Me.optDateDay4.Size = New System.Drawing.Size(70, 17)
        Me.optDateDay4.TabIndex = 5
        Me.optDateDay4.Text = "Thursday"
        Me.optDateDay4.UseVisualStyleBackColor = True
        '
        'optDateDay5
        '
        Me.optDateDay5.AutoSize = True
        Me.optDateDay5.Location = New System.Drawing.Point(18, 130)
        Me.optDateDay5.Name = "optDateDay5"
        Me.optDateDay5.Size = New System.Drawing.Size(54, 17)
        Me.optDateDay5.TabIndex = 6
        Me.optDateDay5.Text = "Friday"
        Me.optDateDay5.UseVisualStyleBackColor = True
        '
        'optDateMonth
        '
        Me.optDateMonth.BackColor = System.Drawing.Color.Transparent
        Me.optDateMonth.Controls.Add(Me.optDateMonth2)
        Me.optDateMonth.Controls.Add(Me.optDateMonth12)
        Me.optDateMonth.Controls.Add(Me.optDateMonth1)
        Me.optDateMonth.Controls.Add(Me.optDateMonth11)
        Me.optDateMonth.Controls.Add(Me.optDateMonth3)
        Me.optDateMonth.Controls.Add(Me.optDateMonth10)
        Me.optDateMonth.Controls.Add(Me.optDateMonth4)
        Me.optDateMonth.Controls.Add(Me.optDateMonth9)
        Me.optDateMonth.Controls.Add(Me.optDateMonth5)
        Me.optDateMonth.Controls.Add(Me.optDateMonth8)
        Me.optDateMonth.Controls.Add(Me.optDateMonth6)
        Me.optDateMonth.Controls.Add(Me.optDateMonth7)
        Me.optDateMonth.ForeColor = System.Drawing.Color.Black
        Me.optDateMonth.Location = New System.Drawing.Point(17, 93)
        Me.optDateMonth.Name = "optDateMonth"
        Me.optDateMonth.Size = New System.Drawing.Size(215, 217)
        Me.optDateMonth.TabIndex = 21
        Me.optDateMonth.TabStop = False
        Me.optDateMonth.Text = "Month"
        '
        'optDateMonth2
        '
        Me.optDateMonth2.AutoSize = True
        Me.optDateMonth2.Location = New System.Drawing.Point(18, 60)
        Me.optDateMonth2.Name = "optDateMonth2"
        Me.optDateMonth2.Size = New System.Drawing.Size(67, 17)
        Me.optDateMonth2.TabIndex = 10
        Me.optDateMonth2.Text = "February"
        Me.optDateMonth2.UseVisualStyleBackColor = True
        '
        'optDateMonth12
        '
        Me.optDateMonth12.AutoSize = True
        Me.optDateMonth12.Location = New System.Drawing.Point(120, 180)
        Me.optDateMonth12.Name = "optDateMonth12"
        Me.optDateMonth12.Size = New System.Drawing.Size(75, 17)
        Me.optDateMonth12.TabIndex = 20
        Me.optDateMonth12.Text = "December"
        Me.optDateMonth12.UseVisualStyleBackColor = True
        '
        'optDateMonth1
        '
        Me.optDateMonth1.AutoSize = True
        Me.optDateMonth1.Location = New System.Drawing.Point(18, 30)
        Me.optDateMonth1.Name = "optDateMonth1"
        Me.optDateMonth1.Size = New System.Drawing.Size(63, 17)
        Me.optDateMonth1.TabIndex = 9
        Me.optDateMonth1.Text = "January"
        Me.optDateMonth1.UseVisualStyleBackColor = True
        '
        'optDateMonth11
        '
        Me.optDateMonth11.AutoSize = True
        Me.optDateMonth11.Location = New System.Drawing.Point(120, 150)
        Me.optDateMonth11.Name = "optDateMonth11"
        Me.optDateMonth11.Size = New System.Drawing.Size(75, 17)
        Me.optDateMonth11.TabIndex = 19
        Me.optDateMonth11.Text = "November"
        Me.optDateMonth11.UseVisualStyleBackColor = True
        '
        'optDateMonth3
        '
        Me.optDateMonth3.AutoSize = True
        Me.optDateMonth3.Location = New System.Drawing.Point(18, 90)
        Me.optDateMonth3.Name = "optDateMonth3"
        Me.optDateMonth3.Size = New System.Drawing.Size(56, 17)
        Me.optDateMonth3.TabIndex = 11
        Me.optDateMonth3.Text = "March"
        Me.optDateMonth3.UseVisualStyleBackColor = True
        '
        'optDateMonth10
        '
        Me.optDateMonth10.AutoSize = True
        Me.optDateMonth10.Location = New System.Drawing.Point(120, 120)
        Me.optDateMonth10.Name = "optDateMonth10"
        Me.optDateMonth10.Size = New System.Drawing.Size(77, 17)
        Me.optDateMonth10.TabIndex = 18
        Me.optDateMonth10.Text = "September"
        Me.optDateMonth10.UseVisualStyleBackColor = True
        '
        'optDateMonth4
        '
        Me.optDateMonth4.AutoSize = True
        Me.optDateMonth4.Location = New System.Drawing.Point(18, 120)
        Me.optDateMonth4.Name = "optDateMonth4"
        Me.optDateMonth4.Size = New System.Drawing.Size(46, 17)
        Me.optDateMonth4.TabIndex = 12
        Me.optDateMonth4.Text = "April"
        Me.optDateMonth4.UseVisualStyleBackColor = True
        '
        'optDateMonth9
        '
        Me.optDateMonth9.AutoSize = True
        Me.optDateMonth9.Location = New System.Drawing.Point(120, 90)
        Me.optDateMonth9.Name = "optDateMonth9"
        Me.optDateMonth9.Size = New System.Drawing.Size(59, 17)
        Me.optDateMonth9.TabIndex = 17
        Me.optDateMonth9.Text = "August"
        Me.optDateMonth9.UseVisualStyleBackColor = True
        '
        'optDateMonth5
        '
        Me.optDateMonth5.AutoSize = True
        Me.optDateMonth5.Location = New System.Drawing.Point(18, 150)
        Me.optDateMonth5.Name = "optDateMonth5"
        Me.optDateMonth5.Size = New System.Drawing.Size(46, 17)
        Me.optDateMonth5.TabIndex = 13
        Me.optDateMonth5.Text = "May"
        Me.optDateMonth5.UseVisualStyleBackColor = True
        '
        'optDateMonth8
        '
        Me.optDateMonth8.AutoSize = True
        Me.optDateMonth8.Location = New System.Drawing.Point(120, 60)
        Me.optDateMonth8.Name = "optDateMonth8"
        Me.optDateMonth8.Size = New System.Drawing.Size(59, 17)
        Me.optDateMonth8.TabIndex = 16
        Me.optDateMonth8.Text = "August"
        Me.optDateMonth8.UseVisualStyleBackColor = True
        '
        'optDateMonth6
        '
        Me.optDateMonth6.AutoSize = True
        Me.optDateMonth6.Location = New System.Drawing.Point(18, 180)
        Me.optDateMonth6.Name = "optDateMonth6"
        Me.optDateMonth6.Size = New System.Drawing.Size(49, 17)
        Me.optDateMonth6.TabIndex = 14
        Me.optDateMonth6.Text = "June"
        Me.optDateMonth6.UseVisualStyleBackColor = True
        '
        'optDateMonth7
        '
        Me.optDateMonth7.AutoSize = True
        Me.optDateMonth7.Location = New System.Drawing.Point(120, 30)
        Me.optDateMonth7.Name = "optDateMonth7"
        Me.optDateMonth7.Size = New System.Drawing.Size(44, 17)
        Me.optDateMonth7.TabIndex = 15
        Me.optDateMonth7.Text = "July"
        Me.optDateMonth7.UseVisualStyleBackColor = True
        '
        'optDateDate
        '
        Me.optDateDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.optDateDate.Location = New System.Drawing.Point(73, 61)
        Me.optDateDate.Name = "optDateDate"
        Me.optDateDate.Size = New System.Drawing.Size(102, 20)
        Me.optDateDate.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(483, 371)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next >>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'FroggBackupOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(599, 403)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.TabOption)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FroggBackupOption"
        Me.Text = "FroggBackup - Options"
        Me.TabOption.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optTypeImg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optTypeImg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.optDateRepeat.ResumeLayout(False)
        Me.optDateRepeat.PerformLayout()
        Me.optDateDay.ResumeLayout(False)
        Me.optDateDay.PerformLayout()
        Me.optDateMonth.ResumeLayout(False)
        Me.optDateMonth.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabOption As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents optFileTxtEx As System.Windows.Forms.Label
    Friend WithEvents optFileTxtSel As System.Windows.Forms.Label
    Friend WithEvents optFileTxtSrc As System.Windows.Forms.Label
    Friend WithEvents treeLocalPath As System.Windows.Forms.TreeView
    Friend WithEvents ListSelected As System.Windows.Forms.ListBox
    Friend WithEvents ListExcluded As System.Windows.Forms.ListBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents optTypeImg1 As System.Windows.Forms.PictureBox
    Friend WithEvents optTypeImg2 As System.Windows.Forms.PictureBox
    Friend WithEvents optTypeTxt2 As System.Windows.Forms.RichTextBox
    Friend WithEvents optTypeTxt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents optTypeTxt0 As System.Windows.Forms.RichTextBox
    Friend WithEvents optTypeTitle As System.Windows.Forms.Label
    Friend WithEvents optType2 As System.Windows.Forms.RadioButton
    Friend WithEvents optType1 As System.Windows.Forms.RadioButton
    Friend WithEvents optType0 As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents optDateTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents optDateRepeat As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents optDateRepeatHour As System.Windows.Forms.Label
    Friend WithEvents optDateRepeatTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents optDateRepeat1 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateTitle As System.Windows.Forms.Label
    Friend WithEvents optDateText As System.Windows.Forms.Label
    Friend WithEvents optDateDay As System.Windows.Forms.GroupBox
    Friend WithEvents optDateDay1 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay2 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay7 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay3 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay6 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay4 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDay5 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth As System.Windows.Forms.GroupBox
    Friend WithEvents optDateMonth2 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth12 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth1 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth11 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth3 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth10 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth4 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth9 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth5 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth8 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth6 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateMonth7 As System.Windows.Forms.CheckBox
    Friend WithEvents optDateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
