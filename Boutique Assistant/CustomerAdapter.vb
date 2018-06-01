Imports System.Data.SQLite

Public Class CustomerAdapter

    Public Function getCustomers(searchQuery As String, searchFilter As CUST_SEARCH_FILTER) As List(Of Customer)

        Dim searchStr As String = ""

        If searchQuery = "" Then
            searchStr = "SELECT * FROM BT_USERS"
        ElseIf searchFilter = CUST_SEARCH_FILTER.NAME Then
            searchStr = "SELECT * FROM BT_USERS WHERE name like '%" + searchQuery + "%'"
        ElseIf searchFilter = CUST_SEARCH_FILTER.PHONE Then
            searchStr = "SELECT * FROM BT_USERS WHERE phone like '%" + searchQuery + "%'"
        ElseIf searchFilter = CUST_SEARCH_FILTER.ADDRESS Then
            searchStr = "SELECT * FROM BT_USERS WHERE address like '%" + searchQuery + "%'"
        End If

        'MsgBox(searchStr)


        Dim ret As New List(Of Customer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = searchStr

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        Dim cust As New Customer()

                        cust.setDBID(rdr.GetInt32(0))
                        cust.setName(rdr.GetString(1))
                        cust.setPhone(rdr.GetString(2))
                        cust.setAddress(rdr.GetString(3))

                        ret.Add(cust)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Sub addCustomer(cust As Customer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "INSERT INTO BT_USERS(name, phone, address) VALUES(@name, @phone, @address)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@name", cust.getName)
                cmd.Parameters.AddWithValue("@phone", cust.getPhone)
                cmd.Parameters.AddWithValue("@address", cust.getAddress)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub modifyCustomer(cust As Customer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "UPDATE BT_USERS SET name=@name, phone=@phone, address=@address WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@name", cust.getName)
                cmd.Parameters.AddWithValue("@phone", cust.getPhone)
                cmd.Parameters.AddWithValue("@address", cust.getAddress)
                cmd.Parameters.AddWithValue("@id", cust.getDBID)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub removeCustomer(cust As Customer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)


                cmd.CommandText = "DELETE FROM BT_USERS WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", cust.getDBID)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

End Class
