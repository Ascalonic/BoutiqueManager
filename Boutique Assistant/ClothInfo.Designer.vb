<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClothInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labClothPrice = New System.Windows.Forms.Label()
        Me.labClothName = New System.Windows.Forms.Label()
        Me.labClothStatus = New System.Windows.Forms.Label()
        Me.labOrderDate = New System.Windows.Forms.Label()
        Me.labDeliveryDate = New System.Windows.Forms.Label()
        Me.btnPrintCloth = New System.Windows.Forms.Button()
        Me.btnDeleteCloth = New System.Windows.Forms.Button()
        Me.btnEditCloth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labClothPrice
        '
        Me.labClothPrice.AutoSize = True
        Me.labClothPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClothPrice.ForeColor = System.Drawing.Color.White
        Me.labClothPrice.Location = New System.Drawing.Point(13, 47)
        Me.labClothPrice.Name = "labClothPrice"
        Me.labClothPrice.Size = New System.Drawing.Size(68, 18)
        Me.labClothPrice.TabIndex = 7
        Me.labClothPrice.Text = "<Price>"
        '
        'labClothName
        '
        Me.labClothName.AutoSize = True
        Me.labClothName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClothName.ForeColor = System.Drawing.Color.White
        Me.labClothName.Location = New System.Drawing.Point(13, 13)
        Me.labClothName.Name = "labClothName"
        Me.labClothName.Size = New System.Drawing.Size(138, 22)
        Me.labClothName.TabIndex = 6
        Me.labClothName.Text = "<Cloth Name>"
        '
        'labClothStatus
        '
        Me.labClothStatus.AutoSize = True
        Me.labClothStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClothStatus.ForeColor = System.Drawing.Color.White
        Me.labClothStatus.Location = New System.Drawing.Point(203, 47)
        Me.labClothStatus.Name = "labClothStatus"
        Me.labClothStatus.Size = New System.Drawing.Size(78, 18)
        Me.labClothStatus.TabIndex = 12
        Me.labClothStatus.Text = "<Status>"
        '
        'labOrderDate
        '
        Me.labOrderDate.AutoSize = True
        Me.labOrderDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labOrderDate.ForeColor = System.Drawing.Color.LawnGreen
        Me.labOrderDate.Location = New System.Drawing.Point(14, 80)
        Me.labOrderDate.Name = "labOrderDate"
        Me.labOrderDate.Size = New System.Drawing.Size(108, 18)
        Me.labOrderDate.TabIndex = 13
        Me.labOrderDate.Text = "<Oder Date>"
        '
        'labDeliveryDate
        '
        Me.labDeliveryDate.AutoSize = True
        Me.labDeliveryDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDeliveryDate.ForeColor = System.Drawing.Color.Sienna
        Me.labDeliveryDate.Location = New System.Drawing.Point(203, 80)
        Me.labDeliveryDate.Name = "labDeliveryDate"
        Me.labDeliveryDate.Size = New System.Drawing.Size(133, 18)
        Me.labDeliveryDate.TabIndex = 14
        Me.labDeliveryDate.Text = "<Delivery Date>"
        '
        'btnPrintCloth
        '
        Me.btnPrintCloth.BackColor = System.Drawing.Color.White
        Me.btnPrintCloth.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.print
        Me.btnPrintCloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrintCloth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCloth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrintCloth.Location = New System.Drawing.Point(206, 112)
        Me.btnPrintCloth.Name = "btnPrintCloth"
        Me.btnPrintCloth.Size = New System.Drawing.Size(52, 48)
        Me.btnPrintCloth.TabIndex = 15
        Me.btnPrintCloth.UseVisualStyleBackColor = False
        '
        'btnDeleteCloth
        '
        Me.btnDeleteCloth.BackColor = System.Drawing.Color.White
        Me.btnDeleteCloth.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.delete_cust
        Me.btnDeleteCloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteCloth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCloth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteCloth.Location = New System.Drawing.Point(132, 112)
        Me.btnDeleteCloth.Name = "btnDeleteCloth"
        Me.btnDeleteCloth.Size = New System.Drawing.Size(52, 48)
        Me.btnDeleteCloth.TabIndex = 9
        Me.btnDeleteCloth.UseVisualStyleBackColor = False
        '
        'btnEditCloth
        '
        Me.btnEditCloth.BackColor = System.Drawing.Color.White
        Me.btnEditCloth.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.edit_cust
        Me.btnEditCloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditCloth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCloth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditCloth.Location = New System.Drawing.Point(74, 112)
        Me.btnEditCloth.Name = "btnEditCloth"
        Me.btnEditCloth.Size = New System.Drawing.Size(52, 48)
        Me.btnEditCloth.TabIndex = 8
        Me.btnEditCloth.UseVisualStyleBackColor = False
        '
        'ClothInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.Controls.Add(Me.btnPrintCloth)
        Me.Controls.Add(Me.labDeliveryDate)
        Me.Controls.Add(Me.labOrderDate)
        Me.Controls.Add(Me.labClothStatus)
        Me.Controls.Add(Me.btnDeleteCloth)
        Me.Controls.Add(Me.btnEditCloth)
        Me.Controls.Add(Me.labClothPrice)
        Me.Controls.Add(Me.labClothName)
        Me.Name = "ClothInfo"
        Me.Size = New System.Drawing.Size(353, 175)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteCloth As Button
    Friend WithEvents btnEditCloth As Button
    Friend WithEvents labClothPrice As Label
    Friend WithEvents labClothName As Label
    Friend WithEvents labClothStatus As Label
    Friend WithEvents labOrderDate As Label
    Friend WithEvents labDeliveryDate As Label
    Friend WithEvents btnPrintCloth As Button
End Class
