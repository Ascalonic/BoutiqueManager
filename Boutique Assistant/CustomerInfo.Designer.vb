<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.labCustName = New System.Windows.Forms.Label()
        Me.labCustPhone = New System.Windows.Forms.Label()
        Me.btnViewCloths = New System.Windows.Forms.Button()
        Me.btnAddCloth = New System.Windows.Forms.Button()
        Me.btnDeleteCust = New System.Windows.Forms.Button()
        Me.btnEditCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labCustName
        '
        Me.labCustName.AutoSize = True
        Me.labCustName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCustName.ForeColor = System.Drawing.Color.White
        Me.labCustName.Location = New System.Drawing.Point(17, 20)
        Me.labCustName.Name = "labCustName"
        Me.labCustName.Size = New System.Drawing.Size(179, 22)
        Me.labCustName.TabIndex = 0
        Me.labCustName.Text = "<Customer Name>"
        '
        'labCustPhone
        '
        Me.labCustPhone.AutoSize = True
        Me.labCustPhone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCustPhone.ForeColor = System.Drawing.Color.White
        Me.labCustPhone.Location = New System.Drawing.Point(17, 54)
        Me.labCustPhone.Name = "labCustPhone"
        Me.labCustPhone.Size = New System.Drawing.Size(159, 18)
        Me.labCustPhone.TabIndex = 1
        Me.labCustPhone.Text = "<Customer Phone>"
        '
        'btnViewCloths
        '
        Me.btnViewCloths.BackColor = System.Drawing.Color.White
        Me.btnViewCloths.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.view_works
        Me.btnViewCloths.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnViewCloths.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewCloths.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnViewCloths.Location = New System.Drawing.Point(79, 92)
        Me.btnViewCloths.Name = "btnViewCloths"
        Me.btnViewCloths.Size = New System.Drawing.Size(52, 48)
        Me.btnViewCloths.TabIndex = 5
        Me.btnViewCloths.UseVisualStyleBackColor = False
        '
        'btnAddCloth
        '
        Me.btnAddCloth.BackColor = System.Drawing.Color.White
        Me.btnAddCloth.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.add_cust
        Me.btnAddCloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddCloth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCloth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddCloth.Location = New System.Drawing.Point(21, 92)
        Me.btnAddCloth.Name = "btnAddCloth"
        Me.btnAddCloth.Size = New System.Drawing.Size(52, 48)
        Me.btnAddCloth.TabIndex = 4
        Me.btnAddCloth.UseVisualStyleBackColor = False
        '
        'btnDeleteCust
        '
        Me.btnDeleteCust.BackColor = System.Drawing.Color.White
        Me.btnDeleteCust.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.delete_cust
        Me.btnDeleteCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCust.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteCust.Location = New System.Drawing.Point(257, 92)
        Me.btnDeleteCust.Name = "btnDeleteCust"
        Me.btnDeleteCust.Size = New System.Drawing.Size(52, 48)
        Me.btnDeleteCust.TabIndex = 3
        Me.btnDeleteCust.UseVisualStyleBackColor = False
        '
        'btnEditCust
        '
        Me.btnEditCust.BackColor = System.Drawing.Color.White
        Me.btnEditCust.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.edit_cust
        Me.btnEditCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCust.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditCust.Location = New System.Drawing.Point(199, 92)
        Me.btnEditCust.Name = "btnEditCust"
        Me.btnEditCust.Size = New System.Drawing.Size(52, 48)
        Me.btnEditCust.TabIndex = 2
        Me.btnEditCust.UseVisualStyleBackColor = False
        '
        'CustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnViewCloths)
        Me.Controls.Add(Me.btnAddCloth)
        Me.Controls.Add(Me.btnDeleteCust)
        Me.Controls.Add(Me.btnEditCust)
        Me.Controls.Add(Me.labCustPhone)
        Me.Controls.Add(Me.labCustName)
        Me.Name = "CustomerInfo"
        Me.Size = New System.Drawing.Size(322, 153)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labCustName As Label
    Friend WithEvents labCustPhone As Label
    Friend WithEvents btnEditCust As Button
    Friend WithEvents btnDeleteCust As Button
    Friend WithEvents btnAddCloth As Button
    Friend WithEvents btnViewCloths As Button
End Class
