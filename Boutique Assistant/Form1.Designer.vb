<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitMain = New System.Windows.Forms.SplitContainer()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.searchDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.panelSearch = New System.Windows.Forms.Panel()
        Me.radioAddress = New System.Windows.Forms.RadioButton()
        Me.radioPhone = New System.Windows.Forms.RadioButton()
        Me.radioName = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewAllCust = New System.Windows.Forms.Button()
        Me.FlowCustomers = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ActivateProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitMain.Panel1.SuspendLayout()
        Me.SplitMain.Panel2.SuspendLayout()
        Me.SplitMain.SuspendLayout()
        Me.panelSearch.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitMain
        '
        Me.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitMain.Name = "SplitMain"
        Me.SplitMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitMain.Panel1
        '
        Me.SplitMain.Panel1.BackColor = System.Drawing.Color.Azure
        Me.SplitMain.Panel1.Controls.Add(Me.Button5)
        Me.SplitMain.Panel1.Controls.Add(Me.searchDatePicker)
        Me.SplitMain.Panel1.Controls.Add(Me.Label7)
        Me.SplitMain.Panel1.Controls.Add(Me.Button4)
        Me.SplitMain.Panel1.Controls.Add(Me.Label6)
        Me.SplitMain.Panel1.Controls.Add(Me.Button3)
        Me.SplitMain.Panel1.Controls.Add(Me.Label5)
        Me.SplitMain.Panel1.Controls.Add(Me.Button2)
        Me.SplitMain.Panel1.Controls.Add(Me.Label4)
        Me.SplitMain.Panel1.Controls.Add(Me.Button1)
        Me.SplitMain.Panel1.Controls.Add(Me.Label3)
        Me.SplitMain.Panel1.Controls.Add(Me.btnAddCust)
        Me.SplitMain.Panel1.Controls.Add(Me.panelSearch)
        Me.SplitMain.Panel1.Controls.Add(Me.Label1)
        Me.SplitMain.Panel1.Controls.Add(Me.btnViewAllCust)
        '
        'SplitMain.Panel2
        '
        Me.SplitMain.Panel2.Controls.Add(Me.FlowCustomers)
        Me.SplitMain.Size = New System.Drawing.Size(1350, 729)
        Me.SplitMain.SplitterDistance = 122
        Me.SplitMain.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(1162, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 66)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Search works to be delivered"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'searchDatePicker
        '
        Me.searchDatePicker.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.searchDatePicker.Location = New System.Drawing.Point(1162, 16)
        Me.searchDatePicker.Name = "searchDatePicker"
        Me.searchDatePicker.Size = New System.Drawing.Size(163, 25)
        Me.searchDatePicker.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1016, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Delivered Works"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.delivered
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(1035, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 78)
        Me.Button4.TabIndex = 14
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(884, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Completed Works"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.completed
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(906, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 78)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(772, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ongoing Works"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.ongoing
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(786, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 78)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(657, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pending Works"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.pending
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(670, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 78)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(507, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Add Customer"
        '
        'btnAddCust
        '
        Me.btnAddCust.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCust.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.add_cust_big
        Me.btnAddCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCust.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddCust.Location = New System.Drawing.Point(516, 10)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(82, 78)
        Me.btnAddCust.TabIndex = 6
        Me.btnAddCust.UseVisualStyleBackColor = False
        '
        'panelSearch
        '
        Me.panelSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSearch.Controls.Add(Me.radioAddress)
        Me.panelSearch.Controls.Add(Me.radioPhone)
        Me.panelSearch.Controls.Add(Me.radioName)
        Me.panelSearch.Controls.Add(Me.txtSearch)
        Me.panelSearch.Controls.Add(Me.Label2)
        Me.panelSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSearch.Location = New System.Drawing.Point(10, 10)
        Me.panelSearch.Name = "panelSearch"
        Me.panelSearch.Size = New System.Drawing.Size(357, 104)
        Me.panelSearch.TabIndex = 5
        '
        'radioAddress
        '
        Me.radioAddress.AutoSize = True
        Me.radioAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAddress.Location = New System.Drawing.Point(163, 70)
        Me.radioAddress.Name = "radioAddress"
        Me.radioAddress.Size = New System.Drawing.Size(80, 22)
        Me.radioAddress.TabIndex = 4
        Me.radioAddress.Text = "Address"
        Me.radioAddress.UseVisualStyleBackColor = True
        '
        'radioPhone
        '
        Me.radioPhone.AutoSize = True
        Me.radioPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioPhone.Location = New System.Drawing.Point(88, 70)
        Me.radioPhone.Name = "radioPhone"
        Me.radioPhone.Size = New System.Drawing.Size(69, 22)
        Me.radioPhone.TabIndex = 3
        Me.radioPhone.Text = "Phone"
        Me.radioPhone.UseVisualStyleBackColor = True
        '
        'radioName
        '
        Me.radioName.AutoSize = True
        Me.radioName.Checked = True
        Me.radioName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioName.Location = New System.Drawing.Point(16, 70)
        Me.radioName.Name = "radioName"
        Me.radioName.Size = New System.Drawing.Size(66, 22)
        Me.radioName.TabIndex = 2
        Me.radioName.TabStop = True
        Me.radioName.Text = "Name"
        Me.radioName.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(16, 33)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(324, 26)
        Me.txtSearch.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search Customers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "All Customers"
        '
        'btnViewAllCust
        '
        Me.btnViewAllCust.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAllCust.BackgroundImage = Global.Boutique_Assistant.My.Resources.Resources.disp_all_cust
        Me.btnViewAllCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnViewAllCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAllCust.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnViewAllCust.Location = New System.Drawing.Point(400, 10)
        Me.btnViewAllCust.Name = "btnViewAllCust"
        Me.btnViewAllCust.Size = New System.Drawing.Size(82, 78)
        Me.btnViewAllCust.TabIndex = 3
        Me.btnViewAllCust.UseVisualStyleBackColor = False
        '
        'FlowCustomers
        '
        Me.FlowCustomers.AutoScroll = True
        Me.FlowCustomers.BackColor = System.Drawing.Color.GhostWhite
        Me.FlowCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowCustomers.Location = New System.Drawing.Point(0, 0)
        Me.FlowCustomers.Name = "FlowCustomers"
        Me.FlowCustomers.Size = New System.Drawing.Size(1350, 603)
        Me.FlowCustomers.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivateProductToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.ToolStripSeparator2, Me.SettingsToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Boutique_Assistant.My.Resources.Resources.settings
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ActivateProductToolStripMenuItem
        '
        Me.ActivateProductToolStripMenuItem.Name = "ActivateProductToolStripMenuItem"
        Me.ActivateProductToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ActivateProductToolStripMenuItem.Text = "Activate Product"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Boutique Manager | Your Customers"
        Me.SplitMain.Panel1.ResumeLayout(False)
        Me.SplitMain.Panel1.PerformLayout()
        Me.SplitMain.Panel2.ResumeLayout(False)
        CType(Me.SplitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitMain.ResumeLayout(False)
        Me.panelSearch.ResumeLayout(False)
        Me.panelSearch.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitMain As SplitContainer
    Friend WithEvents FlowCustomers As FlowLayoutPanel
    Friend WithEvents btnViewAllCust As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents panelSearch As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents radioAddress As RadioButton
    Friend WithEvents radioPhone As RadioButton
    Friend WithEvents radioName As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddCust As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents searchDatePicker As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ActivateProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
