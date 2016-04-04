<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateNotification))
        Me.WhatsUp = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WhatsUp
        '
        Me.WhatsUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WhatsUp.BackColor = System.Drawing.Color.Transparent
        Me.WhatsUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhatsUp.ForeColor = System.Drawing.Color.Yellow
        Me.WhatsUp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.WhatsUp.Location = New System.Drawing.Point(356, 224)
        Me.WhatsUp.Name = "WhatsUp"
        Me.WhatsUp.Size = New System.Drawing.Size(140, 23)
        Me.WhatsUp.TabIndex = 3
        Me.WhatsUp.Text = "Updating Launcher"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.Yellow
        Me.ApplicationTitle.Location = New System.Drawing.Point(23, 161)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(475, 42)
        Me.ApplicationTitle.TabIndex = 4
        Me.ApplicationTitle.Text = "SWGEmu Generic Launcher"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'UpdateNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.LauncherUpdateHelper.My.Resources.Resources.logo_yellow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(532, 256)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.WhatsUp)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateNotification"
        Me.Text = "SWGEmu Laucher Update"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WhatsUp As Label
    Friend WithEvents ApplicationTitle As Label
End Class
