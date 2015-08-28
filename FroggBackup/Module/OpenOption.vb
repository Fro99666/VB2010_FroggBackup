Friend Module OpenOption

    Public FBO As FroggBackupOption
    Public FDO As FroggDownloadOption

    'close all forms if opened
    'BUG => not working ....
    Public Sub closeForm()
        For Each f As Form In Application.OpenForms
            f.Close()
        Next
    End Sub

    Public Sub ExitApplication()
        'exit the application if user confirm
        If Func.displayMsg("Do you wish to close FroggBackup ?", "Frogg Download - Option", "", 3) Then
            Application.Exit()
        End If
    End Sub

    Public Sub ShowBackupOption()

        'close opened form
        closeForm()

        If FBO IsNot Nothing AndAlso Not FBO.IsDisposed Then Exit Sub

        Dim CloseApp As Boolean = False

        FBO = New FroggBackupOption
        FBO.ShowDialog()
        CloseApp = (FBO.DialogResult = DialogResult.Abort)
        FBO = Nothing

        If CloseApp Then Application.Exit()
    End Sub

    Public Sub ShowDownloadOption()

        'close opened form
        closeForm()

        If FDO IsNot Nothing AndAlso Not FDO.IsDisposed Then Exit Sub

        Dim CloseApp As Boolean = False

        FDO = New FroggDownloadOption
        FDO.ShowDialog()
        CloseApp = (FDO.DialogResult = DialogResult.Abort)
        FDO = Nothing

        If CloseApp Then Application.Exit()
    End Sub

End Module
