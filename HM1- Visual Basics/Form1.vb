Public Class Form1
    Dim bmp As New Bitmap(800, 350)
    Dim xOffset As Integer = 20 ' Imposta una distanza iniziale orizzontale tra gli elementi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim penna As New Pen(Color.Blue, 2)

        Dim larghezza As Integer = 200
        Dim x0 As Integer = xOffset
        Dim y0 As Integer = (bmp.Height / 2)
        Dim x1 As Integer = xOffset + larghezza
        Dim y1 As Integer = (bmp.Height / 2)

        Dim p0 As New Point(x0, y0)
        Dim p1 As New Point(x1, y1)

        g.DrawLine(penna, p0, p1)
        g.Dispose()

        PictureBox1.Image = bmp
        xOffset += larghezza + 20 ' Incrementa xOffset per separare le linee
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim pen As New Pen(Color.Blue, 2)

        Dim centerX As Integer = xOffset + 70
        Dim centerY As Integer = bmp.Height / 2
        Dim radius As Integer = 70

        g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
        g.Dispose()

        PictureBox1.Image = bmp
        xOffset += 2 * (radius + 20) ' Incrementa xOffset per separare i cerchi
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim penna As New Pen(Color.Blue, 2)

        Dim larghezza As Integer = 200
        Dim altezza As Integer = 100
        Dim x As Integer = xOffset
        Dim y As Integer = (bmp.Height / 2) - (altezza / 2)

        g.DrawRectangle(penna, x, y, larghezza, altezza)
        g.Dispose()

        PictureBox1.Image = bmp
        xOffset += larghezza + 20 ' Incrementa xOffset per separare i rettangoli
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim brush As New SolidBrush(Color.Blue)

        Dim centerX As Integer = xOffset + 4
        Dim centerY As Integer = bmp.Height / 2
        Dim radius As Integer = 4

        g.FillEllipse(brush, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
        g.Dispose()

        PictureBox1.Image = bmp
        xOffset += 2 * (radius + 20) ' Incrementa xOffset per separare i cerchi pieni
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim sfondo As New SolidBrush(PictureBox1.BackColor)

        g.FillRectangle(sfondo, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()

        PictureBox1.Image = bmp
        xOffset = 20 ' Reimposta xOffset
    End Sub
End Class
