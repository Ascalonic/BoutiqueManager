Public Class PrintBill

    Public bill_no As Integer
    Public customer_name As String
    Public customer_phone As String
    Public rate As String

    Public cloth_name As String
    Public delivery_date As String
    Public comment As String

    Dim max_width As Double = My.Settings.bill_width
    Dim shop_name As String = My.Settings.shop_name
    Dim shop_address As String = My.Settings.shop_address


    Dim page_settings As New Printing.PageSettings
    Dim printer_settings As Printing.PrinterSettings

    Private Sub PrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            billPreiew.Document = printDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub billPreiew_Click(sender As Object, e As EventArgs) Handles billPreiew.Click

    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        Dim small_font As New Font("Segoe UI", 11)
        Dim title_font As New Font("Segoe UI", 14, FontStyle.Bold)

        Dim small_font_bold As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim small_font_italic As New Font("Segoe UI", 11, FontStyle.Italic)

        e.Graphics.DrawString("Bill No : " + bill_no.ToString,
                small_font, Brushes.Black, 20, 20)

        Dim date_line = "Date : " + Date.Today.ToShortDateString
        Dim w = TextRenderer.MeasureText(date_line, small_font).Width

        e.Graphics.DrawString(date_line, small_font, Brushes.Black, max_width - w - 30, 20)


        w = TextRenderer.MeasureText(shop_name, title_font).Width
        e.Graphics.DrawString(shop_name, title_font, Brushes.Black, (max_width - w) / 2, 45)

        Dim addr_arr() As String
        addr_arr = shop_address.Split("-")

        Dim height_offset = 75

        For i As Integer = 0 To addr_arr.Length - 1

            w = TextRenderer.MeasureText(addr_arr(i), small_font).Width
            Dim h = TextRenderer.MeasureText(addr_arr(i), small_font).Height

            e.Graphics.DrawString(addr_arr(i), small_font, Brushes.Black, (max_width - w) / 2, height_offset)
            height_offset += h + 1

        Next

        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(10, 10, max_width - 20, height_offset + 5))

        height_offset += 5

        '-------------------------------------------------------

        Dim h_off = height_offset

        e.Graphics.DrawString(cloth_name.ToUpper(), small_font_bold, New SolidBrush(Color.Black), New Point(20, height_offset + 20))
        e.Graphics.DrawString(rate, small_font, New SolidBrush(Color.Black), New Point(max_width - 90, height_offset + 20))

        height_offset += 20

        e.Graphics.DrawString(customer_name.ToUpper, small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        e.Graphics.DrawString("(" + customer_phone + ")", small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        e.Graphics.DrawString("Delivery by : " + delivery_date, small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        e.Graphics.DrawString("Comments:", small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        Dim comments_words As String()

        comment = comment.Replace(vbCr, "").Replace(vbLf, "")

        comments_words = comment.Split(" ")

        Dim x_start = 20

        For i As Integer = 0 To comments_words.Length - 1

            e.Graphics.DrawString(comments_words(i), small_font_italic, New SolidBrush(Color.Black), New Point(x_start, height_offset + 20))

            If i = comments_words.Length - 1 Then
                Exit For
            End If

            w = TextRenderer.MeasureText(comments_words(i + 1), small_font_italic).Width

            If x_start + w > max_width - 110 Then
                x_start = 20
                height_offset += 20
            Else
                x_start += TextRenderer.MeasureText(comments_words(i), small_font_italic).Width
            End If

        Next

        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(10, h_off, max_width - 100, height_offset - h_off + 45))
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(max_width - 90, h_off, 80, height_offset - h_off + 45))

        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(max_width - 90, height_offset + 50, 80, 30))

        e.Graphics.DrawString(rate, small_font_bold, New SolidBrush(Color.Black), New Point(max_width - 85, height_offset + 55))

        save_bill(height_offset + 60)

        e.HasMorePages = False

    End Sub

    Private Sub save_bill(h As Integer)


        Dim bill As Bitmap = New Bitmap(Convert.ToInt32(max_width), h)

        Dim gr As Graphics = Graphics.FromImage(bill)

        gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        gr.Clear(Color.White)

        Dim small_font As New Font("Segoe UI", 11)
        Dim title_font As New Font("Segoe UI", 14, FontStyle.Bold)

        Dim small_font_bold As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim small_font_italic As New Font("Segoe UI", 11, FontStyle.Italic)

        gr.DrawString("Bill No : " + bill_no.ToString,
                small_font, Brushes.Black, 20, 20)

        Dim date_line = "Date : " + Date.Today.ToShortDateString
        Dim w = TextRenderer.MeasureText(date_line, small_font).Width

        gr.DrawString(date_line, small_font, Brushes.Black, max_width - w - 30, 20)


        w = TextRenderer.MeasureText(shop_name, title_font).Width
        gr.DrawString(shop_name, title_font, Brushes.Black, (max_width - w) / 2, 45)

        Dim addr_arr() As String
        addr_arr = shop_address.Split("-")

        Dim height_offset = 75

        For i As Integer = 0 To addr_arr.Length - 1

            w = TextRenderer.MeasureText(addr_arr(i), small_font).Width
            Dim temp = TextRenderer.MeasureText(addr_arr(i), small_font).Height

            gr.DrawString(addr_arr(i), small_font, Brushes.Black, (max_width - w) / 2, height_offset)
            height_offset += temp + 1

        Next

        gr.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(10, 10, max_width - 20, height_offset + 5))

        height_offset += 5

        '-------------------------------------------------------

        Dim h_off = height_offset

        gr.DrawString(cloth_name.ToUpper(), small_font_bold, New SolidBrush(Color.Black), New Point(20, height_offset + 20))
        gr.DrawString(rate, small_font, New SolidBrush(Color.Black), New Point(max_width - 90, height_offset + 20))

        height_offset += 20

        gr.DrawString(customer_name.ToUpper, small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        gr.DrawString("(" + customer_phone + ")", small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        gr.DrawString("Delivery by : " + delivery_date, small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        gr.DrawString("Comments:", small_font, New SolidBrush(Color.Black), New Point(20, height_offset + 20))

        height_offset += 20

        Dim comments_words As String()

        comment = comment.Replace(vbCr, "").Replace(vbLf, "")

        comments_words = comment.Split(" ")

        Dim x_start = 20

        For i As Integer = 0 To comments_words.Length - 1

            gr.DrawString(comments_words(i), small_font_italic, New SolidBrush(Color.Black), New Point(x_start, height_offset + 20))

            If i = comments_words.Length - 1 Then
                Exit For
            End If

            w = TextRenderer.MeasureText(comments_words(i + 1), small_font_italic).Width

            If x_start + w > max_width - 110 Then
                x_start = 20
                height_offset += 20
            Else
                x_start += TextRenderer.MeasureText(comments_words(i), small_font_italic).Width
            End If

        Next

        gr.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(10, h_off, max_width - 100, height_offset - h_off + 45))
        gr.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(max_width - 90, h_off, 80, height_offset - h_off + 45))

        gr.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(max_width - 90, height_offset + 50, 80, 30))

        gr.DrawString(rate, small_font_bold, New SolidBrush(Color.Black), New Point(max_width - 85, height_offset + 55))


        If My.Computer.FileSystem.DirectoryExists("Bills") = False Then
            My.Computer.FileSystem.CreateDirectory("Bills")
        End If

        bill.Save("Bills/" + bill_no.ToString + ".jpg")

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Try
            billPageSetup.PageSettings = page_settings
            billPageSetup.ShowDialog()

            printDialog.PrinterSettings = printer_settings
            If printDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try

                    printDoc.PrinterSettings = printDialog.PrinterSettings
                    printDoc.DefaultPageSettings = page_settings
                    printDoc.Print()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class