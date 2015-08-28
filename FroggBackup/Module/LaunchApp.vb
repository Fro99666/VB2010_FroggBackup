Public Module LaunchApp

    Public Sub Main(ByVal cmdArgs() As String)

        Application.EnableVisualStyles()
        Application.Run(New AppContext)

        'Dim UseTray As Boolean = False

        'For Each Cmd As String In cmdArgs
        'If Cmd.ToLower = "-tray" Then
        'UseTray = True
        'Exit For
        'End If
        'Next

        'If UseTray Then
        'Application.Run(New AppContext)
        'Else
        'Application.Run(New MainForm)
        'End If



    End Sub


End Module
