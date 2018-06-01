Public Class Measure

    Private ms As New List(Of String)

    Public Sub New(measures As List(Of String))
        ms = measures
    End Sub

    Public Sub setMeasurements(measures As List(Of String))
        ms = measures
    End Sub

    Public Function getMeasures() As List(Of String)
        Return ms
    End Function

End Class
