<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintMeasure
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
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.billPreiew = New System.Windows.Forms.PrintPreviewControl()
        Me.billPageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'printDoc
        '
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'billPreiew
        '
        Me.billPreiew.Location = New System.Drawing.Point(21, 25)
        Me.billPreiew.Name = "billPreiew"
        Me.billPreiew.Size = New System.Drawing.Size(497, 595)
        Me.billPreiew.TabIndex = 2
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(524, 25)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(227, 29)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintMeasure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 635)
        Me.Controls.Add(Me.billPreiew)
        Me.Controls.Add(Me.cmdPrint)
        Me.Name = "PrintMeasure"
        Me.Text = "PrintMeasure"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents billPreiew As PrintPreviewControl
    Friend WithEvents billPageSetup As PageSetupDialog
    Friend WithEvents cmdPrint As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
