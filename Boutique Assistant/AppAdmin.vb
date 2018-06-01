Public Class AppAdmin

    Private Sub AppAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtShopName.Text = My.Settings.shop_name
        txtShopAddr.Text = My.Settings.shop_address
        txtBillWidth.Text = My.Settings.bill_width

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.shop_name = txtShopName.Text
        My.Settings.shop_address = txtShopAddr.Text
        My.Settings.bill_width = txtBillWidth.Text

        Me.Close()
    End Sub

End Class