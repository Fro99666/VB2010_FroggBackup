<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggNotification))
        Me.txtNotify = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNotify
        '
        Me.txtNotify.BackColor = System.Drawing.Color.Transparent
        Me.txtNotify.Location = New System.Drawing.Point(13, 9)
        Me.txtNotify.Name = "txtNotify"
        Me.txtNotify.Size = New System.Drawing.Size(259, 34)
        Me.txtNotify.TabIndex = 0
        Me.txtNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FroggNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 52)
        Me.Controls.Add(Me.txtNotify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FroggNotification"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNotify As System.Windows.Forms.Label
End Class
