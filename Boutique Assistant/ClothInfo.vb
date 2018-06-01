Public Class ClothInfo

    Public cloth_id As Integer
    Dim customer_name As String = ""

    Public Sub updateValues()

        Dim cw_ad As New ClothWorkAdapter
        customer_name = cw_ad.getCustomer(Settings.all_cloths.Item(cloth_id).getDBID())

        Try

            labClothName.Text = Settings.all_cloths.Item(cloth_id).getClothName() + "(" + customer_name + ")"
            labClothPrice.Text = Settings.all_cloths.Item(cloth_id).getPrice().ToString + " ₹"
            labOrderDate.Text = Settings.all_cloths.Item(cloth_id).getOrderDate().Split(" ")(0)
            labDeliveryDate.Text = Settings.all_cloths.Item(cloth_id).getDeliveryDate().Split(" ")(0)

            Dim stat = Settings.all_cloths.Item(cloth_id).getStatus()

            Select Case stat

                Case 0
                    labClothStatus.Text = "Pending"
                Case 1
                    labClothStatus.Text = "Ongoing"
                Case 2
                    labClothStatus.Text = "Completed"
                Case 3
                    labClothStatus.Text = "Delivered"

            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClothInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClothInfo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        updateValues()

    End Sub

    Private Sub btnEditCloth_Click(sender As Object, e As EventArgs) Handles btnEditCloth.Click
        Edit_Cloth.cloth_id = cloth_id
        Edit_Cloth.Show()
    End Sub

    Private Sub btnDeleteCloth_Click(sender As Object, e As EventArgs) Handles btnDeleteCloth.Click

        Dim res = MsgBox("Are you sure you want to delete this cloth. The associated measurements will be deleted alongside", MsgBoxStyle.YesNo, "Delete Cloth")

        If res = MsgBoxResult.Yes Then

            Dim m_ad As New MeasurementAdapter
            m_ad.deleteMeasurements(Settings.all_cloths.Item(cloth_id).getDBID())

            Dim cw_ad As New ClothWorkAdapter
            cw_ad.deleteWork(Settings.all_cloths.Item(cloth_id).getDBID())

            Dim ad_info As New AdditionalInfo
            ad_info.deleteBMI(Settings.all_cloths.Item(cloth_id).getDBID())
            ad_info.deleteComment(Settings.all_cloths.Item(cloth_id).getDBID())

        End If

        ViewCloths.initCloths()

    End Sub

    Private Sub btnPrintCloth_Click(sender As Object, e As EventArgs) Handles btnPrintCloth.Click

        Dim cw_ad As New ClothWorkAdapter
        Dim phone_num = cw_ad.getCustomerPhone(Settings.all_cloths.Item(cloth_id).getDBID())

        Dim add_info_ad As New AdditionalInfo

        PrintBill.bill_no = Settings.all_cloths.Item(cloth_id).getDBID()
        PrintBill.customer_name = customer_name
        PrintBill.customer_phone = phone_num
        PrintBill.rate = Settings.all_cloths.Item(cloth_id).getPrice().ToString + " ₹"
        PrintBill.cloth_name = Settings.all_cloths.Item(cloth_id).getClothName()
        PrintBill.delivery_date = Settings.all_cloths.Item(cloth_id).getDeliveryDate().Split(" ")(0)
        PrintBill.comment = add_info_ad.getComment(Settings.all_cloths.Item(cloth_id).getDBID())

        PrintBill.Show()

    End Sub
End Class
