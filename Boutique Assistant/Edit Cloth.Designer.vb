<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Cloth
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.dateDelivery = New System.Windows.Forms.DateTimePicker()
        Me.dateOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClothName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdMeasure = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.radioBMI1 = New System.Windows.Forms.RadioButton()
        Me.radioBMI0 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.openImg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(243, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "₹"
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(768, 415)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(186, 28)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Text = "No Modifications"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(665, 415)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(97, 28)
        Me.cmdOK.TabIndex = 24
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'dateDelivery
        '
        Me.dateDelivery.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDelivery.Location = New System.Drawing.Point(158, 218)
        Me.dateDelivery.Name = "dateDelivery"
        Me.dateDelivery.Size = New System.Drawing.Size(186, 27)
        Me.dateDelivery.TabIndex = 23
        '
        'dateOrder
        '
        Me.dateOrder.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateOrder.Location = New System.Drawing.Point(158, 175)
        Me.dateOrder.Name = "dateOrder"
        Me.dateOrder.Size = New System.Drawing.Size(186, 27)
        Me.dateOrder.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Delivery Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Order Date:"
        '
        'comboStatus
        '
        Me.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboStatus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Pending", "Ongoing", "Completed", "Delivered"})
        Me.comboStatus.Location = New System.Drawing.Point(158, 125)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(141, 28)
        Me.comboStatus.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Status:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(158, 82)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(79, 27)
        Me.txtPrice.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Price:"
        '
        'txtClothName
        '
        Me.txtClothName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClothName.Location = New System.Drawing.Point(158, 39)
        Me.txtClothName.Name = "txtClothName"
        Me.txtClothName.Size = New System.Drawing.Size(179, 27)
        Me.txtClothName.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cloth Name:"
        '
        'cmdMeasure
        '
        Me.cmdMeasure.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMeasure.Location = New System.Drawing.Point(664, 369)
        Me.cmdMeasure.Name = "cmdMeasure"
        Me.cmdMeasure.Size = New System.Drawing.Size(290, 28)
        Me.cmdMeasure.TabIndex = 27
        Me.cmdMeasure.Text = "View/Edit Measurements"
        Me.cmdMeasure.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(158, 260)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(186, 90)
        Me.txtComments.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Comments:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Boutique_Assistant.My.Resources.Resources.Chart
        Me.PictureBox1.Location = New System.Drawing.Point(497, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'radioBMI1
        '
        Me.radioBMI1.AutoSize = True
        Me.radioBMI1.Location = New System.Drawing.Point(818, 23)
        Me.radioBMI1.Name = "radioBMI1"
        Me.radioBMI1.Size = New System.Drawing.Size(14, 13)
        Me.radioBMI1.TabIndex = 32
        Me.radioBMI1.UseVisualStyleBackColor = True
        '
        'radioBMI0
        '
        Me.radioBMI0.AutoSize = True
        Me.radioBMI0.Checked = True
        Me.radioBMI0.Location = New System.Drawing.Point(611, 23)
        Me.radioBMI0.Name = "radioBMI0"
        Me.radioBMI0.Size = New System.Drawing.Size(14, 13)
        Me.radioBMI0.TabIndex = 31
        Me.radioBMI0.TabStop = True
        Me.radioBMI0.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(368, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Body Mass Index:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmdBrowse.Location = New System.Drawing.Point(158, 364)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(85, 27)
        Me.cmdBrowse.TabIndex = 37
        Me.cmdBrowse.Text = "Change"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'picImg
        '
        Me.picImg.BackColor = System.Drawing.Color.Silver
        Me.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImg.Location = New System.Drawing.Point(158, 397)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(277, 216)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 36
        Me.picImg.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Photo of Cloth:"
        '
        'openImg
        '
        Me.openImg.FileName = "OpenFileDialog1"
        Me.openImg.Filter = "GIF Files|*.gif|JPG Files|*.jpg|JPEG Files|*.jpeg|PNG Files|*.png|All Files |*.*"
        '
        'Edit_Cloth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 630)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.radioBMI1)
        Me.Controls.Add(Me.radioBMI0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdMeasure)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.dateDelivery)
        Me.Controls.Add(Me.dateOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClothName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Cloth"
        Me.Text = "Edit Cloth"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents dateDelivery As DateTimePicker
    Friend WithEvents dateOrder As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClothName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdMeasure As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents radioBMI1 As RadioButton
    Friend WithEvents radioBMI0 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents picImg As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents openImg As OpenFileDialog
End Class
