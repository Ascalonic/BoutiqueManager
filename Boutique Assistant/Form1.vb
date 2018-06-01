Imports System.Data.SQLite

Public Enum CUST_SEARCH_FILTER
    NAME
    PHONE
    ADDRESS
End Enum

Public Class Form1

    Public customers As New List(Of Customer)
    Dim searchQuery As String
    Dim searchBy As CUST_SEARCH_FILTER


    Public Sub getCustomers()

        Dim c_ad As New CustomerAdapter()
        customers.Clear()
        customers = c_ad.getCustomers(searchQuery, searchBy)

    End Sub

    Public Sub initCustomers()

        getCustomers()

        FlowCustomers.Controls.Clear()

        For i As Integer = 0 To customers.Count - 1
            Dim c_info As New CustomerInfo
            c_info.Visible = True
            c_info.cust_index = i
            FlowCustomers.Controls.Add(c_info)
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        searchBy = CUST_SEARCH_FILTER.NAME
        searchQuery = ""
        initCustomers()

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchQuery = txtSearch.Text
            initCustomers()
        End If
    End Sub

    Private Sub setSearchBy()
        If radioName.Checked Then
            searchBy = CUST_SEARCH_FILTER.NAME
            'MsgBox("selecting name")
        ElseIf radioPhone.Checked Then
            'MsgBox("selecting phone")
            searchBy = CUST_SEARCH_FILTER.PHONE
        ElseIf radioAddress.Checked Then
            'MsgBox("selecting address")
            searchBy = CUST_SEARCH_FILTER.ADDRESS
        End If
    End Sub

    Private Sub radioName_CheckedChanged(sender As Object, e As EventArgs) Handles radioName.CheckedChanged
        searchQuery = txtSearch.Text
        setSearchBy()
        initCustomers()
    End Sub

    Private Sub radioPhone_CheckedChanged(sender As Object, e As EventArgs) Handles radioPhone.CheckedChanged
        searchQuery = txtSearch.Text
        setSearchBy()
        initCustomers()
    End Sub

    Private Sub radioAddress_CheckedChanged(sender As Object, e As EventArgs) Handles radioAddress.CheckedChanged
        searchQuery = txtSearch.Text
        setSearchBy()
        initCustomers()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnViewAllCust_Click(sender As Object, e As EventArgs) Handles btnViewAllCust.Click
        searchQuery = ""
        initCustomers()
    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        Add_Customer.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ViewCloths.cust_id = -1
        ViewCloths.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewCloths.cust_id = -2
        ViewCloths.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewCloths.cust_id = -3
        ViewCloths.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ViewCloths.cust_id = -4
        ViewCloths.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ViewCloths.deliv_date = searchDatePicker.Value.Date.ToString
        ViewCloths.cust_id = -5
        ViewCloths.Show()
    End Sub

    Private Sub ActivateProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateProductToolStripMenuItem.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        AppAdmin.Show()
    End Sub
End Class
