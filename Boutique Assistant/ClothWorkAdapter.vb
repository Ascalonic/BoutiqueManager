Imports System.Data.SQLite

Public Class ClothWorkAdapter

    Public Function getClothWorks(customer_id As Integer) As List(Of ClothWork)

        Dim qstr As String = "SELECT * FROM BT_WORK WHERE cust_id=" + customer_id.ToString

        If customer_id = -1 Then
            qstr = "SELECT * FROM BT_WORK WHERE status=0"
        ElseIf customer_id = -2 Then
            qstr = "SELECT * FROM BT_WORK WHERE status=1"
        ElseIf customer_id = -3 Then
            qstr = "SELECT * FROM BT_WORK WHERE status=2"
        ElseIf customer_id = -4 Then
            qstr = "SELECT * FROM BT_WORK WHERE status=3"
        End If

        Dim ret As New List(Of ClothWork)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = qstr

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        Dim work As New ClothWork()

                        work.setDBID(rdr.GetInt32(0))
                        work.setClothName(rdr.GetString(2))
                        work.setPrice(rdr.GetFloat(3))
                        work.setStatus(rdr.GetInt32(4))
                        work.setOrderDate(rdr.GetString(5))
                        work.setDeliveryDate(rdr.GetString(6))
                        work.setImgPath(rdr.GetString(7))
                        ret.Add(work)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Function getClothWorksDate(deliv_date As String) As List(Of ClothWork)

        Dim qstr As String = "SELECT * FROM BT_WORK WHERE delivery_date=@delivery_date"

        Dim ret As New List(Of ClothWork)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = qstr
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@delivery_date", deliv_date)

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        Dim work As New ClothWork()

                        work.setDBID(rdr.GetInt32(0))
                        work.setClothName(rdr.GetString(2))
                        work.setPrice(rdr.GetFloat(3))
                        work.setStatus(rdr.GetInt32(4))
                        work.setOrderDate(rdr.GetString(5))
                        work.setDeliveryDate(rdr.GetString(6))
                        work.setImgPath(rdr.GetString(7))
                        ret.Add(work)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Function getCustomer(work_id As Integer) As String

        Dim qstr As String = "SELECT name FROM BT_USERS WHERE id=(SELECT cust_id FROM BT_WORK WHERE BT_WORK.id=" + work_id.ToString + ")"

        Dim ret As String = ""

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = qstr

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        ret = rdr.GetString(0)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Function getCustomerPhone(work_id As Integer) As String

        Dim qstr As String = "SELECT phone FROM BT_USERS WHERE id=(SELECT cust_id FROM BT_WORK WHERE BT_WORK.id=" + work_id.ToString + ")"

        Dim ret As String = ""

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = qstr

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        ret = rdr.GetString(0)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Sub addClothWork(work As ClothWork, customer_id As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "INSERT INTO BT_WORK(cust_id, cloth_name, price, status, order_date, delivery_date, img_path) 
                                VALUES(@cust_id, @cloth_name, @price, @status, @order_date, @delivery_date, @img_path)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@cust_id", customer_id)
                cmd.Parameters.AddWithValue("@cloth_name", work.getClothName)
                cmd.Parameters.AddWithValue("@price", work.getPrice)
                cmd.Parameters.AddWithValue("@status", work.getStatus)
                cmd.Parameters.AddWithValue("@order_date", work.getOrderDate)
                cmd.Parameters.AddWithValue("@delivery_date", work.getDeliveryDate)
                cmd.Parameters.AddWithValue("@img_path", work.getImgPath)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Function getLastClothID() As Integer


        Dim ret As Integer = 0

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT max(id) FROM BT_WORK"

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        Try
                            ret = rdr.GetInt32(0)
                        Catch ex As Exception

                        End Try

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function


    Public Sub modifyCloth(cloth As ClothWork)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "UPDATE BT_WORK SET cloth_name=@cloth_name, price=@price, status=@status, order_date=@order_date, delivery_date=@delivery_date WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@cloth_name", cloth.getClothName)
                cmd.Parameters.AddWithValue("@price", cloth.getPrice)
                cmd.Parameters.AddWithValue("@status", cloth.getStatus)
                cmd.Parameters.AddWithValue("@order_date", cloth.getOrderDate)
                cmd.Parameters.AddWithValue("@delivery_date", cloth.getDeliveryDate)
                cmd.Parameters.AddWithValue("@id", cloth.getDBID)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub deleteWork(work_id As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "DELETE FROM BT_WORK WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", work_id)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

End Class
