Public Class Func

#Region "Application Function"

    'exit the application
    Public Shared Sub ExitApplication()
        Application.Exit()
    End Sub

    'Display msg
    Public Shared Function displayMsg(ByVal msg As String, ByVal msgTitle As String, ByVal defaultVal As String, ByVal lvl As Integer)
        'lvl -1 = error
        'lvl  0 = ok
        'lvl  1 = info
        'lvl  2 = waring
        'lvl  3 = confirm
        'lvl  4 = user input

        'define msg box title depending in lvl value
        Select Case lvl
            Case -1
                MsgBox(msg, Nothing, msgTitle & " : Error occured")
                displayMsg = True
            Case 1
                displayMsg = True
            Case 2
                MsgBox(msg, Nothing, msgTitle & " : Warning occured")
                displayMsg = True
            Case 3
                Dim answer As DialogResult
                answer = MsgBox(msg, MessageBoxButtons.YesNo, msgTitle)
                If answer = vbYes Then displayMsg = True Else displayMsg = False
            Case 4
                displayMsg = InputBox(msg, msgTitle, defaultVal)
            Case Else
                displayMsg = "NOT DEFINED"
        End Select
    End Function

#End Region

#Region "ListBox Function"

    'Remove if already exist element (starting with) in listbox
    Public Shared Sub removeIfAlreadyExist(lb As ListBox, s As String)
        For i = lb.Items.Count - 1 To 0 Step -1
            If InStr(1, lb.Items(i), s) = 1 Then lb.Items.RemoveAt(i)
        Next
    End Sub

#End Region

#Region "Web Function"

    Public Shared Function CheckURL(ByVal urltocheck As String)
        If Not urltocheck.Contains("http") Then
            Func.displayMsg("The url must start with http", "Frogg Tool", "", -1)
            Return False
        End If

        Dim url As New System.Uri(urltocheck), req As System.Net.WebRequest, resp As System.Net.WebResponse

        req = System.Net.WebRequest.Create(url)
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Func.displayMsg("URL " & urltocheck & " not found" & vbCrLf & "Please check your url", "Frogg Tool", "", -1)
            Return False
        End Try
    End Function

#End Region


#Region "Date / Time Function"

    Public Shared Function stringToSec(timeStr)
        Dim t = Split(timeStr, ":")
        stringToSec = (CInt(t(0)) * 60 + CInt(t(1))) * 60 * 1000
    End Function

    Public Shared Function getTime()
        getTime = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
    End Function

#End Region


#Region "File Function"

    'Create a file
    Public Shared Sub writeFile(ByVal fileName As String, ByVal lines As ArrayList)
        'create stream file
        Dim streamFile As New System.IO.StreamWriter(fileName, False)
        'add each line
        For Each line In lines
            streamFile.WriteLine(line)
        Next
        'end file stream
        streamFile.Close()
    End Sub

    Public Shared Sub addTolog(ByVal msg As String)
        'If saveLog = 1 Then
        If Not My.Computer.FileSystem.FileExists(Conf.configLogFile) Then
            Dim lines As New ArrayList
            'lines.Add("#### [ " & Func.getTime() & " ] LogFile created ####")
            Func.writeFile(Conf.configLogFile, lines)
        End If
        'append to file
        My.Computer.FileSystem.WriteAllText(Conf.configLogFile, "[" & Func.getTime() & "] " & msg & vbCrLf, True)
        'End If
    End Sub

#End Region

End Class
