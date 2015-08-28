Public Class FroggNotification

    Private Sub FroggNotification_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Hide()
        'Me.Location = New System.Drawing.Point(SystemInformation.WorkingArea.Size.Width - Size.Width - 16, SystemInformation.WorkingArea.Size.Height - Size.Height - 4)
    End Sub

    'Private notifyT As Thread

    Public Sub notify(title As String, msg As String)
        'set parameter
        'Me.Text = title
        'Me.txtNotify.Text = msg
        'create thread
        'notifyT = New Thread(AddressOf notifyThread)
        'notifyT.IsBackground = True
        'notifyT.Start(Me)
    End Sub

    Public Sub notifyThread(form As FroggNotification)
        'disaply windows
        'form.Show()
        'close after 3 sec
        'Threading.Thread.Sleep(3000)
        'Me.Close()
    End Sub

End Class