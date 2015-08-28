Imports System.Xml
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FroggDownloadOption

    Private defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Private dlPath As String
    Private dlFreq As Long
    Private downloads As New ArrayList


#Region "Form Load"

    Private Sub FroggDownloadOption_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'load default values
        loadData()
    End Sub

    Private Sub FroggDownloadOption_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'disaply status of the timer
        checkTimer()
    End Sub

#End Region

#Region "Buttons actions"

    '======[ ADD BUTTON ]======
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim userVal As String, alreadyExist As Boolean
        DLToolBarTxt.Text = "PLease wait while checking Link..."
        userVal = Func.displayMsg("", "Frogg Download - Option", "Add a link to download", 4)
        If Not Func.CheckURL(userVal) Then
            DLToolBarTxt.Text = "Unable to reach the link"
            Exit Sub
        Else
            DLToolBarTxt.Text = "Link available"
        End If
        'test if already exist in the list
        alreadyExist = False
        For Each r As DataGridViewRow In DataGridOptLink.Rows
            If userVal = r.Cells(0).Value Then alreadyExist = True
        Next
        'check if already exist
        If Not alreadyExist Then
            DataGridOptLink.Rows.Add(userVal)
            DataGridOptLink.Rows(DataGridOptLink.Rows.Count - 1).Selected = True
        Else
            Func.displayMsg(userVal & " Already exist in link list", "Frogg Download - Option", "", -1)
        End If
        'restore status bar text
        checkTimer()
    End Sub

    '======[ REMOVE BUTTON ]======
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If Func.displayMsg("Do you wish to remove selected items ?", "Frogg Download - Option", "", 3) Then
            For Each r As DataGridViewTextBoxCell In DataGridOptLink.SelectedCells
                If (DataGridOptLink.Rows.Count > 0) Then DataGridOptLink.Rows.RemoveAt(r.RowIndex)
            Next
        End If
    End Sub

    '======[ SAVE BUTTON ]======
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveData()
    End Sub

    '======[ PATH INPT BUTTON ]======
    Private Sub inptDLPath_Click(sender As System.Object, e As System.EventArgs) Handles inptDLPath.Click
        getDLPath()
    End Sub

    '======[ PATH BUTTON ]======
    Private Sub btnPath_Click(sender As System.Object, e As System.EventArgs) Handles btnPath.Click
        getDLPath()
    End Sub

#End Region



#Region "Download Function"

    'clear loaded datas
    Private Sub clearData()
        dlPath = ""
        dlFreq = 0
        If downloads IsNot Nothing Then downloads.Clear()
        'reset link list
        DataGridOptLink.Rows.Clear()
    End Sub

    'load datas
    Private Sub loadData()
        'clear already loaded datas
        clearData()
        'if config file exist
        Dim tmp As String
        If File.Exists(Conf.configDownloadFile) Then
            Using XmlFile As XmlReader = XmlReader.Create(Conf.configDownloadFile)
                While XmlFile.Read()
                    ' Check for start elements.
                    If XmlFile.IsStartElement() Then
                        Select Case XmlFile.Name
                            Case "dlPath"
                                tmp = XmlFile.ReadElementContentAsString()
                                inptDLPath.Text = tmp
                                dlPath = tmp
                            Case "dlFreq"
                                tmp = XmlFile.ReadElementContentAsString()
                                inptDateTime.Text = tmp
                                dlFreq = Func.stringToSec(tmp)
                                'TEMP VALUE !!!
                                dlFreq = 10000
                            Case "downloads"
                                tmp = XmlFile.ReadElementContentAsString()
                                DataGridOptLink.Rows.Add(tmp)
                                downloads.Add(tmp)
                        End Select
                    End If
                End While
            End Using
        Else
            'default values
            inptDLPath.Text = defaultFolder & "\"
            inptDateTime.Text = "01:00"
        End If
    End Sub

    'save datas
    Private Sub saveData()
        'if data are missing then exit
        If Not checkData() Then Exit Sub
        ' Create XmlWriterSettings
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        ' Create XmlWriter
        Using writer As XmlWriter = XmlWriter.Create(Conf.configDownloadFile, settings)
            writer.WriteStartDocument() ' Begin writing.
            writer.WriteStartElement("config") ' Root.
            'optionPath
            writer.WriteElementString("dlPath", inptDLPath.Text)
            'optionFreq
            writer.WriteElementString("dlFreq", inptDateTime.Text)
            'optionDownload
            writer.WriteStartElement("optionDownload")
            For Each r As DataGridViewRow In DataGridOptLink.Rows
                writer.WriteElementString("downloads", r.Cells(0).Value)
            Next
            writer.WriteEndElement() 'Close optionDownload
            writer.WriteEndDocument() 'Close root
        End Using
        'save confirmation
        Func.displayMsg("Configuration has been saved ", "Frogg Download", "", 1)
        'start timer !
        startTimer()
        'close option windows
        Me.Close()
    End Sub

    'check data validity
    Private Function checkData()
        Dim hasError As Boolean = False

        If inptDLPath.Text = "" Then
            Func.displayMsg("No folder selected !" & vbCrLf & "you need to select at least one folder", "Frogg Backup", "", -1)
            inptDLPath.BackColor = Color.Red
            inptDLPath.ForeColor = Color.White
            hasError = True
        Else
            inptDLPath.BackColor = SystemColors.Window
            inptDLPath.ForeColor = SystemColors.WindowText
        End If

        If Not Regex.Match(inptDateTime.Text, "^([2][0-3]|[0-1][0-9]):([0-5][0-9])$", RegexOptions.IgnoreCase).Success Then
            If Not hasError Then
                Func.displayMsg("Wrong format for frequency !" & vbCrLf & "format should be HH:MM", "Frogg Backup", "", -1)
            End If
            inptDateTime.BackColor = Color.Red
            inptDateTime.ForeColor = Color.White
            hasError = True
        Else
            If CInt(inptDateTime.Text.Replace(":", "")) < 1 Then
                If Not hasError Then
                    Func.displayMsg("Wrong frequency !" & vbCrLf & "frequency should be at least 1 min (00:01)", "Frogg Backup", "", -1)
                End If
                inptDateTime.BackColor = Color.Red
                inptDateTime.ForeColor = Color.White
                hasError = True
            Else
                inptDateTime.BackColor = SystemColors.Window
                inptDateTime.ForeColor = SystemColors.WindowText
            End If
        End If

        checkData = Not hasError
    End Function

    'ask for dl path
    Private Sub getDLPath()
        If (FolderBrowserDialogPath.ShowDialog() = DialogResult.OK) Then
            Dim selPath = FolderBrowserDialogPath.SelectedPath
            If Not selPath.EndsWith("\") Then selPath &= "\"
            inptDLPath.Text = selPath
        End If
    End Sub

#End Region


#Region "Download Timer"

    Public Class downloadObjClass
        ' Used to hold parameters for calls to TimerTask.
        Public downloads As ArrayList
        Public dlPath As String
        Public TimerReference As System.Threading.Timer
        Public TimerRunning As Boolean = False
    End Class

    'download service object info
    Public StateObj As New downloadObjClass

    'timer thread
    Private TimerItem As System.Threading.Timer

    'start timer call
    Public Sub startTimer()
        'reset timer if is running
        stopTimer()
        'load xml datas
        loadData()
        'if not download to do, no need to start download ticks
        If downloads Is Nothing Then Exit Sub
        'set obj values
        StateObj.downloads = downloads
        StateObj.dlPath = dlPath
        StateObj.TimerRunning = True
        Dim TimerDelegate As New System.Threading.TimerCallback(AddressOf DownloadTick)
        ' Create a timer that calls a procedure every "dlFreq" seconds.
        ' Note: There is no Start method; the timer starts running as soon as 
        ' the instance is created.
        TimerItem = New System.Threading.Timer(TimerDelegate, StateObj, dlFreq, dlFreq)
        ' Save a reference for Dispose.
        StateObj.TimerReference = TimerItem
        'show if timer is runing
        checkTimer()
    End Sub

    'timer tick
    Private Sub DownloadTick(ByVal StateObj As Object)
        Dim dlFile As String
        For Each download As String In StateObj.downloads
            dlFile = StateObj.dlPath & download.Substring(download.LastIndexOf("/") + 1)
            'if file already exist remove it !
            Try
                If My.Computer.FileSystem.FileExists(dlFile) Then My.Computer.FileSystem.DeleteFile(dlFile)
                My.Computer.Network.DownloadFile(download, dlFile)
                FroggNotification.notify("Frogg Download", "Downloaded : " & dlFile)
                Func.addTolog("Downloaded : " & dlFile)
            Catch ex As Exception
                FroggNotification.notify("Frogg Download", "Error while downloading : " & dlFile & " " & ex.Message)
                Func.addTolog("Error while downloading : " & dlFile & " " & ex.Message)
            End Try
        Next
    End Sub

    'timer stop
    Public Sub stopTimer()
        If TimerItem IsNot Nothing Then
            TimerItem.Dispose()
            StateObj.TimerRunning = False
        End If
    End Sub

    'timer status check
    Private Sub checkTimer()

        MsgBox("TEST1 IS INIT " & (TimerItem IsNot Nothing))
        MsgBox("TEST2 = " & StateObj.TimerRunning)
        If TimerItem IsNot Nothing Then
            DLToolBarTxt.Text = "Download service is running"
        Else
            DLToolBarTxt.Text = "Download service is NOT running"
        End If
    End Sub

#End Region


#Region "Tooltip Menu"

    Private Sub NotifyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotifyToolStripMenuItem.Click

        If NotifyToolStripMenuItem.CheckState Then
            NotifyToolStripMenuItem.CheckState = False
        Else
            NotifyToolStripMenuItem.CheckState = True
        End If

    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogToolStripMenuItem.Click

        If LogToolStripMenuItem.CheckState Then
            LogToolStripMenuItem.CheckState = False
        Else
            LogToolStripMenuItem.CheckState = True
        End If

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("TODO !")
    End Sub

#End Region


End Class