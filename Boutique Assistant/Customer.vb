Public Class Customer

    Private db_id As Integer
    Private cust_name As String
    Private cust_phone As String
    Private cust_address As String

    Public Sub New()
        db_id = -1
        cust_name = ""
        cust_phone = ""
        cust_address = ""
    End Sub

    Public Sub New(id As Integer, name As String, phone As String, address As String)
        db_id = id
        cust_name = name
        cust_phone = phone
        cust_address = address
    End Sub

    Public Function getName() As String
        Return cust_name
    End Function

    Public Function getPhone() As String
        Return cust_phone
    End Function

    Public Function getAddress() As String
        Return cust_address
    End Function

    Public Function getDBID() As Integer
        Return db_id
    End Function

    Public Sub setName(name As String)
        cust_name = name
    End Sub

    Public Sub setPhone(phone As String)
        cust_phone = phone
    End Sub

    Public Sub setAddress(address As String)
        cust_address = address
    End Sub

    Public Sub setDBID(id As Integer)
        db_id = id
    End Sub

End Class
