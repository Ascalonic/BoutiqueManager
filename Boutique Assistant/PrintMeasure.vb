Public Class PrintMeasure

    Public bill_no As Integer
    Public customer_name As String
    Public customer_phone As String
    Public rate As String

    Public cloth_name As String
    Public delivery_date As String
    Public comment As String

    Dim max_width As Double = 590
    Dim shop_name As String = My.Settings.shop_name
    Dim shop_address As String = My.Settings.shop_address


    Dim page_settings As New Printing.PageSettings
    Dim printer_settings As Printing.PrinterSettings

    Public work_id As Integer

    Dim ms As New List(Of String)

    Dim m_names As New List(Of String)

    Private Sub PrintMeasure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            billPreiew.Document = printDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub populateMNames()

        m_names = New List(Of String)

        m_names.Add("Shoulder")
        m_names.Add("Upper Chest")
        m_names.Add("Center Bust")
        m_names.Add("Lower Bust")
        m_names.Add("Arm Hole")
        m_names.Add("Neck Front")
        m_names.Add("Neck Back")
        m_names.Add("Front-Width")
        m_names.Add("Back-Width")
        m_names.Add("Shoulder to Point")

        m_names.Add("Point to Point")
        m_names.Add("Side to Point")
        m_names.Add("Shoulder to Waist")
        m_names.Add("Shoulder to Stomach")
        m_names.Add("Length")
        m_names.Add("Sleeve Length")
        m_names.Add("Sleeve Width")
        m_names.Add("------------")
        m_names.Add("------------")
        m_names.Add("------------")

        m_names.Add("Waist")
        m_names.Add("Hip")
        m_names.Add("Thighs")
        m_names.Add("Knee")
        m_names.Add("Ankle")
        m_names.Add("Ankle Lock")
        m_names.Add("Bottom Length")
        m_names.Add("Slit")
        m_names.Add("Flair")
        m_names.Add("Bottom Elastic")

        m_names.Add("Loop")
        m_names.Add("Button")
        m_names.Add("Back Loop")
        m_names.Add("Princess Cut")
        m_names.Add("Front Open")
        m_names.Add("Back Open")
        m_names.Add("Border")
        m_names.Add("Thread Piping")
        m_names.Add("-------------")
        m_names.Add("Lace")

        m_names.Add("Saree Fall")
        m_names.Add("Ladkan")
        m_names.Add("Neck Piping")
        m_names.Add("Sleeve Piping")
        m_names.Add("Slit Piping")
        m_names.Add("Flair Piping")
        m_names.Add("Patta")
        m_names.Add("-----")
        m_names.Add("Back Zip")
        m_names.Add("Side Zip")

        m_names.Add("Lining")
        m_names.Add("Peako")
        m_names.Add("Anarkali")
        m_names.Add("Umbrella")
        m_names.Add("Phasing")
        m_names.Add("Churi Bottom")
        m_names.Add("Normal")
        m_names.Add("Pattiala")


    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        Dim m_ad As New MeasurementAdapter
        ms = m_ad.getMeasurements(Settings.all_cloths.Item(work_id).getDBID)
        populateMNames()


        Dim small_font As New Font("Segoe UI", 11)
        Dim title_font As New Font("Segoe UI", 14, FontStyle.Bold)

        Dim small_font_bold As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim small_font_italic As New Font("Segoe UI", 11, FontStyle.Italic)

        e.Graphics.DrawString("Bill No : " + Settings.all_cloths.Item(work_id).getDBID().ToString,
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

        height_offset += 15

        Dim temp = height_offset

        '-------------------------------------------------------

        For i As Integer = 0 To 29

            e.Graphics.DrawString(m_names.Item(i) + ":", small_font, New SolidBrush(Color.Black), New Point(10, height_offset))
            e.Graphics.DrawString(ms.Item(i), small_font, New SolidBrush(Color.Black), New Point(165, height_offset))

            height_offset += 25
        Next

        height_offset = temp

        For i As Integer = 30 To 57
            e.Graphics.DrawString(m_names.Item(i) + ":", small_font, New SolidBrush(Color.Black), New Point(380, height_offset))
            e.Graphics.DrawString(ms.Item(i), small_font, New SolidBrush(Color.Black), New Point(540, height_offset))
            height_offset += 25
        Next


        save_bill(height_offset + 60)

        e.HasMorePages = False

    End Sub

    Private Sub save_bill(h As Integer)

        Dim bill As Bitmap = New Bitmap(Convert.ToInt32(max_width), h)

        Dim gr As Graphics = Graphics.FromImage(bill)

        Dim small_font As New Font("Segoe UI", 11)
        Dim title_font As New Font("Segoe UI", 14, FontStyle.Bold)

        Dim small_font_bold As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim small_font_italic As New Font("Segoe UI", 11, FontStyle.Italic)

        gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        gr.Clear(Color.White)

        gr.DrawString("Bill No : " + Settings.all_cloths.Item(work_id).getDBID().ToString,
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
            Dim t = TextRenderer.MeasureText(addr_arr(i), small_font).Height

            gr.DrawString(addr_arr(i), small_font, Brushes.Black, (max_width - w) / 2, height_offset)
            height_offset += t + 1

        Next

        gr.DrawRectangle(New Pen(New SolidBrush(Color.Black)), New Rectangle(10, 10, max_width - 20, height_offset + 5))

        height_offset += 15

        Dim temp = height_offset

        '-------------------------------------------------------

        For i As Integer = 0 To 29

            gr.DrawString(m_names.Item(i) + ":", small_font, New SolidBrush(Color.Black), New Point(10, height_offset))
            gr.DrawString(ms.Item(i), small_font, New SolidBrush(Color.Black), New Point(165, height_offset))

            height_offset += 25
        Next

        height_offset = temp

        For i As Integer = 30 To 57
            gr.DrawString(m_names.Item(i) + ":", small_font, New SolidBrush(Color.Black), New Point(380, height_offset))
            gr.DrawString(ms.Item(i), small_font, New SolidBrush(Color.Black), New Point(540, height_offset))
            height_offset += 25
        Next


        If My.Computer.FileSystem.DirectoryExists("Bills") = False Then
            My.Computer.FileSystem.CreateDirectory("Bills")
        End If

        bill.Save("Bills/" + Settings.all_cloths.Item(work_id).getDBID().ToString + "_measure.jpg")
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

    Private Sub PrintMeasure_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ViewCloths.Show()
        Edit_Cloth.Show()
        EditMeasurements.Show()

    End Sub
End Class