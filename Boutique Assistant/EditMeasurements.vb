Imports System.ComponentModel

Public Class EditMeasurements

    Public work_id As Integer

    Public ms As New List(Of String)

    Private Sub EditMeasurements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form.CheckForIllegalCrossThreadCalls = False
        progressInsertion.Visible = True
        BackgroundRetrieve.RunWorkerAsync()

    End Sub

    Private Sub BackgroundRetrieve_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundRetrieve.DoWork

        Dim m_ad As New MeasurementAdapter
        Dim ms As New List(Of String)

        ms = m_ad.getMeasurements(Settings.all_cloths.Item(work_id).getDBID)

        m1.Text = ms.Item(0)
        m2.Text = ms.Item(1)
        m3.Text = ms.Item(2)
        m4.Text = ms.Item(3)
        m5.Text = ms.Item(4)
        m6.Text = ms.Item(5)
        m7.Text = ms.Item(6)
        m8.Text = ms.Item(7)
        m9.Text = ms.Item(8)
        m10.Text = ms.Item(9)

        m11.Text = ms.Item(10)
        m12.Text = ms.Item(11)
        m13.Text = ms.Item(12)
        m14.Text = ms.Item(13)
        m15.Text = ms.Item(14)
        m16.Text = ms.Item(15)
        m17.Text = ms.Item(16)
        m18.Text = ms.Item(17)
        m19.Text = ms.Item(18)
        m20.Text = ms.Item(19)

        m21.Text = ms.Item(20)
        m22.Text = ms.Item(21)
        m23.Text = ms.Item(22)
        m24.Text = ms.Item(23)
        m25.Text = ms.Item(24)
        m26.Text = ms.Item(25)
        m27.Text = ms.Item(26)
        m28.Text = ms.Item(27)
        m29.Text = ms.Item(28)
        m30.Text = ms.Item(29)

        m31.Text = ms.Item(30)
        m32.Text = ms.Item(31)
        m33.Text = ms.Item(32)
        m34.Text = ms.Item(33)
        m35.Text = ms.Item(34)
        m36.Text = ms.Item(35)
        m37.Text = ms.Item(36)
        m38.Text = ms.Item(37)
        m39.Text = ms.Item(38)
        m40.Text = ms.Item(39)

        m41.Text = ms.Item(40)
        m42.Text = ms.Item(41)
        m43.Text = ms.Item(42)
        m44.Text = ms.Item(43)
        m45.Text = ms.Item(44)
        m46.Text = ms.Item(45)
        m47.Text = ms.Item(46)
        m48.Text = ms.Item(47)
        m49.Text = ms.Item(48)
        m50.Text = ms.Item(49)

        m51.Text = ms.Item(50)
        m52.Text = ms.Item(51)
        m53.Text = ms.Item(52)
        m54.Text = ms.Item(53)
        m55.Text = ms.Item(54)
        m56.Text = ms.Item(55)
        m57.Text = ms.Item(56)
        m58.Text = ms.Item(57)

    End Sub

    Private Sub BackgroundRetrieve_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundRetrieve.RunWorkerCompleted
        progressInsertion.Visible = False
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        MS.Add(m1.Text)
        MS.Add(m2.Text)
        MS.Add(m3.Text)
        MS.Add(m4.Text)
        MS.Add(m5.Text)
        MS.Add(m6.Text)
        MS.Add(m7.Text)
        MS.Add(m8.Text)
        MS.Add(m9.Text)
        MS.Add(m10.Text)
        MS.Add(m11.Text)
        MS.Add(m12.Text)
        MS.Add(m13.Text)
        MS.Add(m14.Text)
        MS.Add(m15.Text)
        MS.Add(m16.Text)
        MS.Add(m17.Text)
        MS.Add(m18.Text)
        MS.Add(m19.Text)
        MS.Add(m20.Text)
        MS.Add(m21.Text)
        MS.Add(m22.Text)
        MS.Add(m23.Text)
        MS.Add(m24.Text)
        MS.Add(m25.Text)
        MS.Add(m26.Text)
        MS.Add(m27.Text)
        MS.Add(m28.Text)
        MS.Add(m29.Text)
        MS.Add(m30.Text)
        MS.Add(m31.Text)
        MS.Add(m32.Text)
        MS.Add(m33.Text)
        MS.Add(m34.Text)
        MS.Add(m35.Text)
        MS.Add(m36.Text)
        MS.Add(m37.Text)
        MS.Add(m38.Text)
        MS.Add(m39.Text)
        MS.Add(m40.Text)
        MS.Add(m41.Text)
        MS.Add(m42.Text)
        MS.Add(m43.Text)
        MS.Add(m44.Text)
        MS.Add(m45.Text)
        MS.Add(m46.Text)
        MS.Add(m47.Text)
        MS.Add(m48.Text)
        MS.Add(m49.Text)
        MS.Add(m50.Text)
        MS.Add(m51.Text)
        MS.Add(m52.Text)
        MS.Add(m53.Text)
        MS.Add(m54.Text)
        MS.Add(m55.Text)
        MS.Add(m56.Text)
        MS.Add(m57.Text)
        MS.Add(m58.Text)

        progressInsertion.Visible = True

        backgroundCloth.RunWorkerAsync()

    End Sub

    Private Sub backgroundCloth_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundCloth.DoWork

        Dim m_ad As New MeasurementAdapter
        m_ad.modifyMeasurements(Settings.all_cloths.Item(work_id).getDBID, New Measure(ms))

    End Sub

    Private Sub backgroundCloth_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundCloth.RunWorkerCompleted

        progressInsertion.Visible = False
        MsgBox("Measurements Updated", MsgBoxStyle.Information, "Success")
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PrintMeasure.work_id = work_id

        ViewCloths.Hide()
        Edit_Cloth.Hide()
        Me.Hide()
        PrintMeasure.Show()

    End Sub
End Class