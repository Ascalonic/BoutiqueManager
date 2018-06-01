Public Class Edit_Cloth

    Public cloth_id As Integer
    Private img_path As String = ""
    Private temp_bmp As Bitmap

    Private Sub Edit_Cloth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Bill Number:" + Settings.all_cloths.Item(cloth_id).getDBID.ToString

        txtClothName.Text = Settings.all_cloths.Item(cloth_id).getClothName
        txtPrice.Text = Settings.all_cloths.Item(cloth_id).getPrice
        comboStatus.SelectedIndex = Settings.all_cloths.Item(cloth_id).getStatus
        dateOrder.Value = Date.Parse(Settings.all_cloths.Item(cloth_id).getOrderDate)
        dateDelivery.Value = Date.Parse(Settings.all_cloths.Item(cloth_id).getDeliveryDate)

        Dim ad_info As New AdditionalInfo
        txtComments.Text = ad_info.getComment(Settings.all_cloths.Item(cloth_id).getDBID)

        Dim bmi As Integer = ad_info.getBMI(Settings.all_cloths.Item(cloth_id).getDBID)

        If bmi = 0 Then
            radioBMI0.Checked = True
        Else
            radioBMI1.Checked = True
        End If

        img_path = Settings.all_cloths.Item(cloth_id).getImgPath

        picImg.ImageLocation = "Photos/" + img_path
        picImg.Refresh()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim price As Single

        If txtClothName.Text = vbNullString Or txtPrice.Text = vbNullString Then
            MsgBox("Please enter all the fields", MsgBoxStyle.Exclamation, "Empty Fields")
            Return
        End If

        Try
            price = txtPrice.Text
        Catch ex As Exception
            MsgBox("Please enter a valid number as price", MsgBoxStyle.Exclamation, "Invalid Price")
            Return
        End Try

        Dim cloth As New ClothWork(Settings.all_cloths.Item(cloth_id).getDBID, txtClothName.Text, price, dateOrder.Value.Date.ToString,
                                   dateDelivery.Value.Date.ToString, comboStatus.SelectedIndex, img_path)

        Dim cw_ad As New ClothWorkAdapter
        cw_ad.modifyCloth(cloth)

        Dim ad_info As New AdditionalInfo
        ad_info.modifyComment(Settings.all_cloths.Item(cloth_id).getDBID, txtComments.Text)

        Dim bmi As Integer

        If radioBMI0.Checked Then
            bmi = 0
        Else
            bmi = 1
        End If

        ad_info.modifyBMI(Settings.all_cloths.Item(cloth_id).getDBID, bmi)

        MsgBox("Cloth Details Modified Successfully", MsgBoxStyle.Information, "Success")

        ViewCloths.initCloths()

        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdMeasure_Click(sender As Object, e As EventArgs) Handles cmdMeasure.Click
        EditMeasurements.work_id = cloth_id
        EditMeasurements.Show()
    End Sub

    Private Sub txtComments_TextChanged(sender As Object, e As EventArgs) Handles txtComments.TextChanged

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click

        openImg.ShowDialog()

        If (My.Computer.FileSystem.DirectoryExists("Photos") = False) Then
            My.Computer.FileSystem.CreateDirectory("Photos")
        End If

        If openImg.FileName <> vbNullString And My.Computer.FileSystem.FileExists(openImg.FileName) Then
            My.Computer.FileSystem.CopyFile(openImg.FileName, "Photos/" + img_path, True)
            picImg.ImageLocation = "Photos/" + img_path
            picImg.Refresh()
        Else
            MsgBox("Please enter a valid filename", MsgBoxStyle.Critical, "Invalid Filename")
        End If

    End Sub

    Private Sub Edit_Cloth_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub
End Class