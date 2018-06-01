Public Class ViewCloths

    Public cust_id As Integer
    Public deliv_date As String

    Public Sub getCloths()

        Dim cw_ad As New ClothWorkAdapter()
        all_cloths.Clear()

        If cust_id >= 0 Then
            all_cloths = cw_ad.getClothWorks(Form1.customers.Item(cust_id).getDBID())
        ElseIf deliv_date <> "" Then
            all_cloths = cw_ad.getClothWorksDate(deliv_date)
            deliv_date = ""
        Else
            all_cloths = cw_ad.getClothWorks(cust_id)
        End If


    End Sub


    Public Sub initCloths()

        getCloths()

        FlowCloths.Controls.Clear()

        For i As Integer = 0 To all_cloths.Count - 1
            Dim c_info As New ClothInfo
            c_info.Visible = True
            c_info.cloth_id = i
            FlowCloths.Controls.Add(c_info)
        Next

    End Sub

    Private Sub ViewCloths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initCloths()
    End Sub


End Class