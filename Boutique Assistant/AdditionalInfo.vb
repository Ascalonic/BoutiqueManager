Imports System.Data.SQLite

Public Class AdditionalInfo

    Public Sub addComment(work_index As Integer, comment As String)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "INSERT INTO BT_COMMENTS(work_id, comment) VALUES(@work_id, @comment)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@work_id", work_index)
                cmd.Parameters.AddWithValue("@comment", comment)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Function getComment(work_index As Integer) As String

        Dim ret As String = ""

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT comment FROM BT_COMMENTS WHERE work_id=" + work_index.ToString

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

    Public Sub modifyComment(work_index As Integer, comment As String)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "UPDATE BT_COMMENTS SET comment=@comment WHERE work_id=@work_id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@comment", comment)
                cmd.Parameters.AddWithValue("@work_id", work_index)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub deleteComment(work_index As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "DELETE FROM BT_COMMENTS  WHERE work_id=@work_id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@work_id", work_index)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub addBMI(work_index As Integer, bmi As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "INSERT INTO BT_BMI(work_id, bmi) VALUES(@work_id, @bmi)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@work_id", work_index)
                cmd.Parameters.AddWithValue("@bmi", bmi)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Function getBMI(work_index As Integer) As Integer

        Dim ret As Integer

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT bmi FROM BT_BMI WHERE work_id=" + work_index.ToString

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        ret = rdr.GetInt32(0)

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Sub modifyBMI(work_index As Integer, bmi As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "UPDATE BT_BMI SET bmi=@bmi WHERE work_id=@work_id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@bmi", bmi)
                cmd.Parameters.AddWithValue("@work_id", work_index)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub deleteBMI(work_index As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "DELETE FROM BT_BMI WHERE work_id=@work_id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@work_id", work_index)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub

End Class
