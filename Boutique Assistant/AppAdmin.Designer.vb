<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtShopAddr = New System.Windows.Forms.TextBox()
        Me.txtBillWidth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shop Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shop Address:"
        '
        'txtShopName
        '
        Me.txtShopName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopName.Location = New System.Drawing.Point(129, 21)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(192, 25)
        Me.txtShopName.TabIndex = 2
        '
        'txtShopAddr
        '
        Me.txtShopAddr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopAddr.Location = New System.Drawing.Point(129, 52)
        Me.txtShopAddr.Multiline = True
        Me.txtShopAddr.Name = "txtShopAddr"
        Me.txtShopAddr.Size = New System.Drawing.Size(192, 84)
        Me.txtShopAddr.TabIndex = 3
        '
        'txtBillWidth
        '
        Me.txtBillWidth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillWidth.Location = New System.Drawing.Point(129, 142)
        Me.txtBillWidth.Multiline = True
        Me.txtBillWidth.Name = "txtBillWidth"
        Me.txtBillWidth.Size = New System.Drawing.Size(192, 23)
        Me.txtBillWidth.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bill Width:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 214)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBillWidth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShopAddr)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AppAdmin"
        Me.Text = "Admin Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtShopAddr As TextBox
    Friend WithEvents txtBillWidth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
