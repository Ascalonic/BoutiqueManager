Public Class AddInfo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If radioBMI0.Checked Then
            ret_bmi = 0
        Else
            ret_bmi = 1
        End If

        ret_comments = txtComments.Text

        Me.Close()

    End Sub

    Private Sub AddInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class