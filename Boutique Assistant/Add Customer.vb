Public Class Add_Customer

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdCreateOnly_Click(sender As Object, e As EventArgs) Handles cmdCreateOnly.Click
        createCustomer()
        Me.Close()
    End Sub

    Private Sub createCustomer()

        Dim cust As Customer = New Customer(0, txtName.Text, txtPhone.Text, txtAddress.Text)

        Dim c_ad As New CustomerAdapter()
        c_ad.addCustomer(cust)

        Form1.initCustomers()

    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click

        createCustomer()
        Add_Cloth.cur_edit = Form1.customers.Item(Form1.customers.Count - 1).getDBID
        Add_Cloth.Show()

        Me.Close()

    End Sub

End Class