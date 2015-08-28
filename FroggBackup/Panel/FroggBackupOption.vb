Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml

'[ ADD ]===========================
'TODO : [1] backup destination
'TODO : [2] start with windows
'[ OPT ]===========================
'TODO : open/close folder icon
'TODO : Lang management (context menu)
'TODO : test if save destination has been removed
'TODO : autorun usb
'Task bar notification
'[ BUG ]===========================
'TODO : if check (click) too fast
'TODO : if not enough right to open folder
'TODO : remove selection on list & tree
'TODO : Close all form before open
'[ END ]===========================

'show logs
'global options (start with windows, lang, do notify, do log , enable functions)
'if process is running

Public Class FroggBackupOption

#Region "Form Load/unload"

    Private Sub FroggBackupOption_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'load tree
        loadTree()
        'load default values
        loadData()
        'add tree event
        loadTreeEvent(True)
    End Sub

    Private Sub Option_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'nothing special atm
    End Sub

    Private Sub loadData()
        If File.Exists(Conf.configBackupFile) Then loadFileData() Else loadDefaultData()
    End Sub

    Private Sub loadFileData()
        Dim tmp As String
        Using XmlFile As XmlReader = XmlReader.Create(Conf.configBackupFile)
            While XmlFile.Read()
                ' Check for start elements.
                If XmlFile.IsStartElement() Then
                    Select Case XmlFile.Name
                        Case "optionType"
                            Select Case XmlFile.ReadElementContentAsString()
                                Case "0"
                                    optType0.Checked = True
                                Case "1"
                                    optType1.Checked = True
                                Case "2"
                                    optType2.Checked = True
                            End Select
                        Case "date"
                            optDateDate.Text = XmlFile.ReadElementContentAsString()
                        Case "time"
                            optDateTime.Text = XmlFile.ReadElementContentAsString()
                        Case "repeat"
                            optDateRepeat1.Checked = XmlFile.ReadElementContentAsString()
                        Case "repeatTime"
                            optDateRepeatTime.Text = XmlFile.ReadElementContentAsString()
                        Case "month1"
                            optDateMonth1.Checked = XmlFile.ReadElementContentAsString()
                        Case "month2"
                            optDateMonth2.Checked = XmlFile.ReadElementContentAsString()
                        Case "month3"
                            optDateMonth3.Checked = XmlFile.ReadElementContentAsString()
                        Case "month4"
                            optDateMonth4.Checked = XmlFile.ReadElementContentAsString()
                        Case "month5"
                            optDateMonth5.Checked = XmlFile.ReadElementContentAsString()
                        Case "month6"
                            optDateMonth6.Checked = XmlFile.ReadElementContentAsString()
                        Case "month7"
                            optDateMonth7.Checked = XmlFile.ReadElementContentAsString()
                        Case "month8"
                            optDateMonth8.Checked = XmlFile.ReadElementContentAsString()
                        Case "month9"
                            optDateMonth9.Checked = XmlFile.ReadElementContentAsString()
                        Case "month10"
                            optDateMonth10.Checked = XmlFile.ReadElementContentAsString()
                        Case "month11"
                            optDateMonth11.Checked = XmlFile.ReadElementContentAsString()
                        Case "month12"
                            optDateMonth12.Checked = XmlFile.ReadElementContentAsString()
                        Case "day1"
                            optDateDay1.Checked = XmlFile.ReadElementContentAsString()
                        Case "day2"
                            optDateDay2.Checked = XmlFile.ReadElementContentAsString()
                        Case "day3"
                            optDateDay3.Checked = XmlFile.ReadElementContentAsString()
                        Case "day4"
                            optDateDay4.Checked = XmlFile.ReadElementContentAsString()
                        Case "day5"
                            optDateDay5.Checked = XmlFile.ReadElementContentAsString()
                        Case "day6"
                            optDateDay6.Checked = XmlFile.ReadElementContentAsString()
                        Case "day7"
                            optDateDay7.Checked = XmlFile.ReadElementContentAsString()
                        Case "selectedItem"
                            tmp = XmlFile.ReadElementContentAsString()
                            ListSelected.Items.Add(tmp)
                            'only root case
                            If Regex.Match(tmp, "^[a-z]:\\$", RegexOptions.IgnoreCase).Success Then treeLocalPath.Nodes(UCase(tmp)).Checked = True
                        Case "excludedItem"
                            ListExcluded.Items.Add(XmlFile.ReadElementContentAsString())
                    End Select
                End If
            End While
        End Using
    End Sub

    Private Sub loadDefaultData()
        '===Option Source list
        'ListSelected
        'ListExcluded
        '===Option type
        optType0.Checked = True
        '===Option date
        'start date
        optDateDate.Text = Now()
        'start time
        optDateTime.Text = "0000"
        'month
        optDateMonth1.Checked = True
        optDateMonth2.Checked = True
        optDateMonth3.Checked = True
        optDateMonth4.Checked = True
        optDateMonth5.Checked = True
        optDateMonth6.Checked = True
        optDateMonth7.Checked = True
        optDateMonth8.Checked = True
        optDateMonth9.Checked = True
        optDateMonth10.Checked = True
        optDateMonth11.Checked = True
        optDateMonth12.Checked = True
        'day
        optDateDay1.Checked = True
        optDateDay2.Checked = True
        optDateDay3.Checked = True
        optDateDay4.Checked = True
        optDateDay5.Checked = True
        optDateDay6.Checked = True
        optDateDay7.Checked = True
        'repeat
        optDateRepeat1.Checked = False
        optDateRepeatTime.Text = "0100"
    End Sub

    Private Sub saveData()
        ' Create XmlWriterSettings
        Dim settings As XmlWriterSettings = New XmlWriterSettings(), optionType As Integer
        settings.Indent = True
        'check datas
        If Not checkData() Then
            Exit Sub
        End If
        ' Create XmlWriter
        Using writer As XmlWriter = XmlWriter.Create(Conf.configBackupFile, settings)
            writer.WriteStartDocument() ' Begin writing.
            writer.WriteStartElement("config") ' Root.
            'optionType
            Select Case True
                Case optType0.Checked
                    optionType = 0
                Case optType1.Checked
                    optionType = 1
                Case optType2.Checked
                    optionType = 2
            End Select
            writer.WriteElementString("optionType", optionType)
            'OptionDate
            writer.WriteStartElement("optionDate")
            writer.WriteElementString("date", optDateDate.Text)
            writer.WriteElementString("time", optDateTime.Text)
            writer.WriteElementString("repeat", optDateRepeat1.Checked)
            writer.WriteElementString("repeatTime", optDateRepeatTime.Text)
            writer.WriteElementString("month1", optDateMonth1.Checked)
            writer.WriteElementString("month2", optDateMonth2.Checked)
            writer.WriteElementString("month3", optDateMonth3.Checked)
            writer.WriteElementString("month4", optDateMonth4.Checked)
            writer.WriteElementString("month5", optDateMonth5.Checked)
            writer.WriteElementString("month6", optDateMonth6.Checked)
            writer.WriteElementString("month7", optDateMonth7.Checked)
            writer.WriteElementString("month8", optDateMonth8.Checked)
            writer.WriteElementString("month9", optDateMonth9.Checked)
            writer.WriteElementString("month10", optDateMonth10.Checked)
            writer.WriteElementString("month11", optDateMonth11.Checked)
            writer.WriteElementString("month12", optDateMonth12.Checked)
            writer.WriteElementString("day1", optDateDay1.Checked)
            writer.WriteElementString("day2", optDateDay2.Checked)
            writer.WriteElementString("day3", optDateDay3.Checked)
            writer.WriteElementString("day4", optDateDay4.Checked)
            writer.WriteElementString("day5", optDateDay5.Checked)
            writer.WriteElementString("day6", optDateDay6.Checked)
            writer.WriteElementString("day7", optDateDay7.Checked)
            writer.WriteEndElement() 'Close optionDate
            'optionSource
            writer.WriteStartElement("optionSource")
            writer.WriteStartElement("selected")
            For i As Integer = 0 To ListSelected.Items.Count - 1
                writer.WriteElementString("selectedItem", ListSelected.Items(i))
            Next
            writer.WriteEndElement()
            writer.WriteStartElement("excluded")
            For i As Integer = 0 To ListExcluded.Items.Count - 1
                writer.WriteElementString("excludedItem", ListExcluded.Items(i))
            Next
            writer.WriteEndElement()
            writer.WriteEndElement() 'Close optionSource
            writer.WriteEndDocument() 'Close root
        End Using

        Func.displayMsg("Configuration has been saved ", "Frogg Backup", "", 1)

        Me.Close()
    End Sub

    Private Function checkData()
        Dim hasError As Boolean = False

        If ListSelected.Items.Count = 0 Then
            Func.displayMsg("No folder selected !" & vbCrLf & "you need to select at least one folder", "Frogg Backup", "", -1)
            TabOption.SelectedTab = TabOption.TabPages(0)
            optFileTxtSel.ForeColor = Color.Red
            hasError = True
        Else
            optFileTxtSel.ForeColor = SystemColors.WindowText
        End If

        If Not optDateMonth1.Checked And Not optDateMonth2.Checked And Not optDateMonth3.Checked And Not optDateMonth4.Checked And Not optDateMonth5.Checked And Not optDateMonth6.Checked And Not optDateMonth7.Checked And Not optDateMonth8.Checked And Not optDateMonth9.Checked And Not optDateMonth10.Checked And Not optDateMonth11.Checked And Not optDateMonth12.Checked Then
            If Not hasError Then
                Func.displayMsg("No month selected !" & vbCrLf & "you need to select at least one month", "Frogg Backup", "", -1)
                TabOption.SelectedTab = TabOption.TabPages(2)
            End If
            optDateMonth.ForeColor = Color.Red
            hasError = True
        Else
            optDateMonth.ForeColor = SystemColors.WindowText
        End If

        If Not optDateDay1.Checked And Not optDateDay2.Checked And Not optDateDay3.Checked And Not optDateDay4.Checked And Not optDateDay5.Checked And Not optDateDay6.Checked And Not optDateDay7.Checked Then
            If Not hasError Then
                Func.displayMsg("No day selected !" & vbCrLf & "you need to select at least one day", "Frogg Backup", "", -1)
                TabOption.SelectedTab = TabOption.TabPages(2)
            End If
            optDateDay.ForeColor = Color.Red
            hasError = True
        Else
            optDateDay.ForeColor = SystemColors.WindowText
        End If

        If Not Regex.Match(optDateTime.Text, "^([2][0-3]|[0-1][0-9]):([0-5][0-9])$", RegexOptions.IgnoreCase).Success Then
            If Not hasError Then
                Func.displayMsg("Wrong format for start hour !" & vbCrLf & "format should be HH:MM", "Frogg Backup", "", -1)
                TabOption.SelectedTab = TabOption.TabPages(2)
            End If
            optDateTime.ForeColor = Color.Red
            hasError = True
        Else
            optDateTime.ForeColor = SystemColors.WindowText
        End If

        If Not Regex.Match(optDateRepeatTime.Text, "^([2][0-3]|[0-1][0-9]):([0-5][0-9])$", RegexOptions.IgnoreCase).Success Then
            If Not hasError Then
                Func.displayMsg("Wrong format for repeat hour !" & vbCrLf & "format should be HH:MM", "Frogg Backup", "", -1)
                TabOption.SelectedTab = TabOption.TabPages(2)
            End If
            optDateRepeatTime.ForeColor = Color.Red
            hasError = True
        Else
            optDateRepeatTime.ForeColor = SystemColors.WindowText
        End If

        checkData = Not hasError
    End Function

#End Region

#Region "Tree Load"

    'init tree
    Private Sub loadTree()
        'Counter for our Physical Drives
        Dim x As Integer
        'set treeview image list
        'treeLocalPath.ImageList = TreeImgList
        'Start looping through the Drives
        For x = 0 To My.Computer.FileSystem.Drives.Count - 1
            'make sure the drive is ready
            If My.Computer.FileSystem.Drives(x).IsReady = True Then
                'add the Drive to the Tree Node use the Drive Name as the "Key" and "Text"
                treeLocalPath.Nodes.Add(My.Computer.FileSystem.Drives(x).Name, My.Computer.FileSystem.Drives(x).Name)
                'set the Tag Property to the Drive Name for Identification Later On
                treeLocalPath.Nodes(My.Computer.FileSystem.Drives(x).Name).Tag = My.Computer.FileSystem.Drives(x).Name
                'add the first level of sub directories to the TreeView
                For Each SubDirectory As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.Drives(x).Name)
                    'The Mid Function is used so our Node does not include something like
                    '"c:\Windows" it should rather read something like "Windows".
                    'However the Key (in our case the first part of the Add() will
                    'have the whole path. This will be used later for Finding the 
                    'Sub Directories)
                    treeLocalPath.Nodes(x).Nodes.Add(SubDirectory, Mid(SubDirectory, 4))
                    'Here we add the Whole path to the Tag Property for Identification
                    'later on
                    treeLocalPath.Nodes(x).Nodes(SubDirectory).Tag = SubDirectory
                Next
            End If
        Next
    End Sub

#End Region

#Region "Tree Functions"

    ' Updates all child tree nodes recursively.
    Private Sub CheckAllChildNodes(treeNode As TreeNode)
        'init vars
        Dim node As TreeNode
        If treeNode.Nodes.Count > 0 Then
            For Each node In treeNode.Nodes
                'check current node
                node.Checked = treeNode.Checked

                'verify if is really checked
                If ListSelected.Items.Contains(node.Tag) Then
                    node.Checked = True
                Else
                    If ListExcluded.Items.Contains(node.Tag) Then node.Checked = False
                End If

                'prevent call if not childrens else the current node has child nodes, call the CheckAllChildsNodes method recursively.
                If node.Nodes.Count > 0 And Not node.NextNode Is Nothing Then Me.CheckAllChildNodes(node)
            Next node
        End If
    End Sub

    'add/remove tree event
    Private Sub loadTreeEvent(doLoad As Boolean)
        If doLoad Then
            'add after check event
            AddHandler treeLocalPath.AfterCheck, AddressOf treeLocalPath_AfterCheck
        Else
            ' remove handler to prevent extra trigger while expanding
            RemoveHandler treeLocalPath.AfterCheck, AddressOf treeLocalPath_AfterCheck
        End If
    End Sub

    ' Add to selected item list
    Private Sub addToSelection(treeNode As TreeNode)
        'if it is root node
        If treeNode.Parent Is Nothing Then
            If treeNode.Checked Then
                Func.removeIfAlreadyExist(ListExcluded, treeNode.Tag)
                Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                ListSelected.Items.Add(treeNode.Tag)
            Else
                Func.removeIfAlreadyExist(ListExcluded, treeNode.Tag)
                Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                ListSelected.Items.Remove(treeNode.Tag)
            End If
        Else
            If treeNode.Parent.Checked Then
                'case parent node is checked
                If treeNode.Checked Then
                    Func.removeIfAlreadyExist(ListExcluded, treeNode.Tag)
                    Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                    ListExcluded.Items.Remove(treeNode.Tag)
                Else
                    Func.removeIfAlreadyExist(ListExcluded, treeNode.Tag)
                    Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                    ListExcluded.Items.Add(treeNode.Tag)
                End If
            Else
                'case parent node is not checked
                If treeNode.Checked Then
                    Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                    ListSelected.Items.Add(treeNode.Tag)
                Else
                    Func.removeIfAlreadyExist(ListSelected, treeNode.Tag)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Tree Events"

    ' After a tree node's expand/collapse event
    Private Sub treeLocalPath_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles treeLocalPath.BeforeExpand
        'init vars
        Dim dirInfo As System.IO.DirectoryInfo, subdirInfo As System.IO.DirectoryInfo, tmpNode As TreeNode
        'Clear the Sub Directories first
        e.Node.Nodes.Clear()
        ' remove handler to prevent extra trigger while expanding
        loadTreeEvent(False)
        'Now we loop through our directories as "TopDirectory" and Get it's Name and Full Path with
        'GetDirectoryInfo() and reading the "Tag" property
        For Each TopDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Tag)
            dirInfo = My.Computer.FileSystem.GetDirectoryInfo(TopDirectory)

            ' if is system folder then ignore
            If (dirInfo.Attributes And FileAttributes.System) = FileAttributes.System Then Continue For
            ' if is hidden folder then ignore
            If (dirInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then Continue For

            'adding the Node
            tmpNode = e.Node.Nodes.Add(TopDirectory, dirInfo.Name, 0)
            'setting its tag property to the full path
            tmpNode.Tag = dirInfo.FullName

            'TROUBLE OF RIGHTS HERE !!!
            'repeat the process for the sub directories
            For Each SubDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Nodes(TopDirectory).Tag)
                subdirInfo = My.Computer.FileSystem.GetDirectoryInfo(SubDirectory)

                ' if is system folder then ignore
                If (subdirInfo.Attributes And FileAttributes.System) = FileAttributes.System Then Continue For
                ' if is hidden folder then ignore
                If (subdirInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then Continue For

                'add the node
                tmpNode = e.Node.Nodes(TopDirectory).Nodes.Add(SubDirectory, dirInfo.Name)
                'settting the Tag of the Sub Directory to the full path
                tmpNode.Tag = dirInfo.FullName
            Next
        Next
        'restore checked status if parent is checked
        CheckAllChildNodes(e.Node)
        ' once all nodes are expanded & checked restore trigger
        loadTreeEvent(True)
    End Sub

    ' After a tree node's check/uncheck event
    Private Sub treeLocalPath_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        ' remove handler to prevent extra trigger
        loadTreeEvent(False)
        ' exec children nodes check
        Me.CheckAllChildNodes(e.Node)
        ' once all nodes are checked restore trigger
        loadTreeEvent(True)
        'add to selection/exeption list
        addToSelection(e.Node)
    End Sub

#End Region

#Region "Tab Events"

    Private Sub changeTab(ByVal sender As System.Object, e As System.EventArgs) Handles TabOption.Selecting
        If TabOption.SelectedTab Is TabOption.TabPages(2) Then btnNext.Text = "Save" Else btnNext.Text = "Next >>"
    End Sub

    Private Sub nextTab(ByVal sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If TabOption.SelectedTab Is TabOption.TabPages(2) Then saveData() Else TabOption.SelectedTab = TabOption.TabPages(TabOption.SelectedIndex + 1)
    End Sub

#End Region

End Class