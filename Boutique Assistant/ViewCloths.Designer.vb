<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCloths
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
        Me.FlowCloths = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowCloths
        '
        Me.FlowCloths.AutoScroll = True
        Me.FlowCloths.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowCloths.Location = New System.Drawing.Point(0, 0)
        Me.FlowCloths.Name = "FlowCloths"
        Me.FlowCloths.Size = New System.Drawing.Size(1019, 611)
        Me.FlowCloths.TabIndex = 0
        '
        'ViewCloths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 611)
        Me.Controls.Add(Me.FlowCloths)
        Me.Name = "ViewCloths"
        Me.Text = "View Cloths"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowCloths As FlowLayoutPanel
End Class
