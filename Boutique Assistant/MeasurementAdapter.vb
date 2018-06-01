Imports System.Data.SQLite

Public Class MeasurementAdapter

    Public Function getMeasurements(work_index As Integer) As List(Of String)


        Dim ret As New List(Of String)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT m_value FROM BT_MEASURE WHERE work_id=" + work_index.ToString

                'MsgBox(cmd.CommandText)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr
                    While (rdr.Read())

                        ret.Add(rdr.GetString(0))

                    End While
                End Using
            End Using

            con.Close()
        End Using

        Return ret

    End Function

    Public Sub addMeasurement(work_index As Integer, m As Measure)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                Dim measure_values As New List(Of String)
                measure_values = m.getMeasures()

                For i As Integer = 0 To measure_values.Count - 1

                    cmd.CommandText = "INSERT INTO BT_MEASURE(work_id, type, m_value) VALUES(@work_id, @type, @m_value)"
                    cmd.Prepare()

                    cmd.Parameters.AddWithValue("@work_id", work_index)
                    cmd.Parameters.AddWithValue("@type", i)
                    cmd.Parameters.AddWithValue("@m_value", measure_values.Item(i))

                    cmd.ExecuteNonQuery()
                Next

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub modifyMeasurements(work_index As Integer, m As Measure)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                Dim measure_values As New List(Of String)
                measure_values = m.getMeasures()

                For i As Integer = 0 To measure_values.Count - 1

                    cmd.CommandText = "UPDATE BT_MEASURE SET m_value=@m_value WHERE work_id=@work_id AND type=@type"
                    cmd.Prepare()

                    cmd.Parameters.AddWithValue("@m_value", measure_values.Item(i))
                    cmd.Parameters.AddWithValue("@work_id", work_index)
                    cmd.Parameters.AddWithValue("@type", i)

                    cmd.ExecuteNonQuery()
                Next

            End Using

            con.Close()
        End Using

    End Sub

    Public Sub deleteMeasurements(work_index As Integer)

        Dim cs As String = DBCONN_STR

        Using con As New SQLiteConnection(cs)
            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "DELETE FROM BT_MEASURE WHERE work_id=@work_id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@work_id", work_index)

                cmd.ExecuteNonQuery()

            End Using

            con.Close()
        End Using

    End Sub



End Class
