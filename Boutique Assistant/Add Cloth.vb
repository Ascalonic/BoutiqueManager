Public Class Add_Cloth

    Public cur_edit As Integer
    Private img_path As String = ""

    Private temp_bmp As Bitmap

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click

        If txtClothName.Text = vbNullString Or txtPrice.Text = vbNullString Then
            MsgBox("Please enter all the fields", MsgBoxStyle.Exclamation, "Empty Fields")
            Return
        End If

        Try
            Measurements.price = txtPrice.Text
        Catch ex As Exception
            MsgBox("Please enter a valid number as price", MsgBoxStyle.Exclamation, "Invalid Price")
            Return
        End Try

        Measurements.cloth_name = txtClothName.Text
        Measurements.status = comboStatus.SelectedIndex
        Measurements.order_date = dateOrder.Value.Date.ToString
        Measurements.delivery_date = dateDelivery.Value.Date.ToString
        Measurements.cur_edit = cur_edit
        Measurements.img_path = img_path

        Measurements.Show()

        'Dim cw_ad As New ClothWorkAdapter
        'cw_ad.addClothWork(New ClothWork(-1, cloth_name, price, order_date, delivery_date, status), cur_edit)

    End Sub

    Private Sub Add_Cloth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click

        Dim cad As New ClothWorkAdapter()
        Dim file_name = "" + (cad.getLastClothID() + 1).ToString + ".jpg"

        openImg.ShowDialog()

        If (My.Computer.FileSystem.DirectoryExists("Photos") = False) Then
            My.Computer.FileSystem.CreateDirectory("Photos")
        End If

        If openImg.FileName <> vbNullString And My.Computer.FileSystem.FileExists(openImg.FileName) Then

            My.Computer.FileSystem.CopyFile(openImg.FileName, "Photos/" + file_name, True)
            img_path = file_name

            picImg.ImageLocation = "Photos/" + file_name
            picImg.Refresh()
        Else
            MsgBox("Please enter a valid filename", MsgBoxStyle.Critical, "Invalid Filename")
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class