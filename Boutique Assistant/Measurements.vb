Imports System.ComponentModel

Public Class Measurements

    Public ms As New List(Of String)

    Public cloth_name As String
    Public status As Integer
    Public order_date As String
    Public price As Single
    Public delivery_date As String
    Public cur_edit As Integer
    Public img_path As String

    Private Sub Measurements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressInsertion.Visible = False
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        ms.Add(m1.Text)
        ms.Add(m2.Text)
        ms.Add(m3.Text)
        ms.Add(m4.Text)
        ms.Add(m5.Text)
        ms.Add(m6.Text)
        ms.Add(m7.Text)
        ms.Add(m8.Text)
        ms.Add(m9.Text)
        ms.Add(m10.Text)
        ms.Add(m11.Text)
        ms.Add(m12.Text)
        ms.Add(m13.Text)
        ms.Add(m14.Text)
        ms.Add(m15.Text)
        ms.Add(m16.Text)
        ms.Add(m17.Text)
        ms.Add(m18.Text)
        ms.Add(m19.Text)
        ms.Add(m20.Text)
        ms.Add(m21.Text)
        ms.Add(m22.Text)
        ms.Add(m23.Text)
        ms.Add(m24.Text)
        ms.Add(m25.Text)
        ms.Add(m26.Text)
        ms.Add(m27.Text)
        ms.Add(m28.Text)
        ms.Add(m29.Text)
        ms.Add(m30.Text)
        ms.Add(m31.Text)
        ms.Add(m32.Text)
        ms.Add(m33.Text)
        ms.Add(m34.Text)
        ms.Add(m35.Text)
        ms.Add(m36.Text)
        ms.Add(m37.Text)
        ms.Add(m38.Text)
        ms.Add(m39.Text)
        ms.Add(m40.Text)
        ms.Add(m41.Text)
        ms.Add(m42.Text)
        ms.Add(m43.Text)
        ms.Add(m44.Text)
        ms.Add(m45.Text)
        ms.Add(m46.Text)
        ms.Add(m47.Text)
        ms.Add(m48.Text)
        ms.Add(m49.Text)
        ms.Add(m50.Text)
        ms.Add(m51.Text)
        ms.Add(m52.Text)
        ms.Add(m53.Text)
        ms.Add(m54.Text)
        ms.Add(m55.Text)
        ms.Add(m56.Text)
        ms.Add(m57.Text)
        ms.Add(m58.Text)

        AddInfo.ShowDialog()

        progressInsertion.Visible = True

        cmdOK.Enabled = False
        cmdCancel.Enabled = False
        cmdClear.Enabled = False

        backgroundCloth.RunWorkerAsync()

    End Sub

    Private Sub backgroundCloth_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundCloth.DoWork

        Dim cw_ad As New ClothWorkAdapter
        cw_ad.addClothWork(New ClothWork(-1, cloth_name, price, order_date, delivery_date, status, img_path), cur_edit)
        Dim work_index = cw_ad.getLastClothID

        Dim m_ad As New MeasurementAdapter
        m_ad.addMeasurement(work_index, New Measure(ms))

        Dim c_ad As New AdditionalInfo
        c_ad.addComment(work_index, Settings.ret_comments)
        c_ad.addBMI(work_index, Settings.ret_bmi)


    End Sub

    Private Sub backgroundCloth_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundCloth.RunWorkerCompleted

        progressInsertion.Visible = False
        MsgBox("Cloth and measurements added successfully", MsgBoxStyle.Information, "Success")

        cmdOK.Enabled = True
        cmdCancel.Enabled = True
        cmdClear.Enabled = True

        Me.Close()
        Add_Cloth.Close()

    End Sub
End Class