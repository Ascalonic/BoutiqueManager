Public Class CustomerInfo

    Public cust_index As Integer

    Public Sub updateValues()
        Try
            labCustName.Text = Form1.customers.Item(cust_index).getName()
            labCustPhone.Text = Form1.customers.Item(cust_index).getPhone()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEditCust_Click(sender As Object, e As EventArgs) Handles btnEditCust.Click
        EditCustomer.curEdit = cust_index
        EditCustomer.Show()
    End Sub

    Private Sub btnDeleteCust_Click(sender As Object, e As EventArgs) Handles btnDeleteCust.Click
        Dim c_ad As New CustomerAdapter()
        c_ad.removeCustomer(Form1.customers.Item(cust_index))
        Form1.initCustomers()
    End Sub

    Private Sub CustomerInfo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        updateValues()
    End Sub

    Private Sub btnAddCloth_Click(sender As Object, e As EventArgs) Handles btnAddCloth.Click
        Add_Cloth.cur_edit = Form1.customers.Item(cust_index).getDBID
        Add_Cloth.Show()
    End Sub

    Private Sub btnViewCloths_Click(sender As Object, e As EventArgs) Handles btnViewCloths.Click
        ViewCloths.cust_id = cust_index
        ViewCloths.Show()
    End Sub
End Class
