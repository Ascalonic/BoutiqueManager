Public Class ClothWork

    Private db_id As Integer
    Private cloth_name As String
    Private price As Single
    Private order_date As String
    Private delivery_date As String
    Private status As Integer
    Private img_path As String

    Public Sub New()
        db_id = -1
        cloth_name = ""
        price = 0.0
        order_date = ""
        delivery_date = ""
        status = -1
        img_path = ""
    End Sub

    Public Sub New(id As Integer, _cloth_name As String, _price As Single, _order_date As String, _delivery_date As String, _status As Integer, _img_path As String)
        db_id = id
        cloth_name = _cloth_name
        price = _price
        order_date = _order_date
        delivery_date = _delivery_date
        status = _status
        img_path = _img_path
    End Sub

    Public Sub setDBID(id As Integer)
        db_id = id
    End Sub

    Public Sub setClothName(_cloth_name As String)
        cloth_name = _cloth_name
    End Sub

    Public Sub setPrice(_price As Single)
        price = _price
    End Sub

    Public Sub setOrderDate(_order_date As String)
        order_date = _order_date
    End Sub

    Public Sub setDeliveryDate(_delivery_date As String)
        delivery_date = _delivery_date
    End Sub

    Public Sub setStatus(_status As Integer)
        status = _status
    End Sub

    Public Sub setImgPath(path As String)
        img_path = path
    End Sub

    Public Function getDBID() As Integer
        Return db_id
    End Function

    Public Function getClothName() As String
        Return cloth_name
    End Function

    Public Function getPrice() As Single
        Return price
    End Function

    Public Function getOrderDate() As String
        Return order_date
    End Function

    Public Function getDeliveryDate() As String
        Return delivery_date
    End Function

    Public Function getStatus() As Integer
        Return status
    End Function

    Public Function getImgPath() As String
        Return img_path
    End Function

End Class
