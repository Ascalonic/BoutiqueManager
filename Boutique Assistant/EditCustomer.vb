Public Class EditCustomer

    Public curEdit As Integer = -1

    Public Sub initFields()

        txtName.Text = Form1.customers.Item(curEdit).getName()
        txtPhone.Text = Form1.customers.Item(curEdit).getPhone()
        txtAddress.Text = Form1.customers.Item(curEdit).getAddress()

    End Sub

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initFields()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        curEdit = 0
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Form1.customers.Item(curEdit).setName(txtName.Text)
        Form1.customers.Item(curEdit).setPhone(txtPhone.Text)
        Form1.customers.Item(curEdit).setAddress(txtAddress.Text)

        Dim c_ad As New CustomerAdapter()
        c_ad.modifyCustomer(Form1.customers.Item(curEdit))

        Form1.initCustomers()

        Me.Close()

    End Sub
End Class