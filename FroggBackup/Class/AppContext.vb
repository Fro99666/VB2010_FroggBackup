
Public Class AppContext
    Inherits ApplicationContext

#Region " Storage "

    Private WithEvents Tray As NotifyIcon
    Private WithEvents MainMenu As ContextMenuStrip
    Private WithEvents mnuDisplayForm1 As ToolStripMenuItem
    Private WithEvents mnuDisplayForm2 As ToolStripMenuItem
    Private WithEvents mnuSep As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem

#End Region

#Region "Constructor"

    Public Sub New()
        'Initialize the menus
        mnuDisplayForm1 = New ToolStripMenuItem("Download options")
        mnuDisplayForm2 = New ToolStripMenuItem("Backup options")
        mnuSep = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem("Exit")
        MainMenu = New ContextMenuStrip
        MainMenu.Items.AddRange(New ToolStripItem() {mnuDisplayForm1, mnuSep, mnuDisplayForm2, mnuSep, mnuExit})

        'Initialize the tray
        Tray = New NotifyIcon
        Tray.Icon = My.Resources.TrayIcon
        Tray.ContextMenuStrip = MainMenu
        Tray.Text = "Frogg Tools"

        'Display
        Tray.Visible = True

        'start download process
        FroggDownloadOption.startTimer()
    End Sub

#End Region

#Region "Event handlers"

    Private Sub AppContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ThreadExit
        'Guarantees that the icon will not linger.
        Tray.Visible = False
    End Sub

    Private Sub mnuDisplayForm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDisplayForm1.Click
        'open download form
        ShowDownloadOption()
    End Sub

    Private Sub mnuDisplayForm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDisplayForm2.Click
        'open backup form
        ShowBackupOption()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        ExitApplication()
    End Sub

    'Private Sub Tray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.DoubleClick
    'ShowBackupOption()
    'End Sub

#End Region

End Class





