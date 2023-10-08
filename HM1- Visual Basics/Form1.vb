Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim penna As New Pen(Color.Blue, 2)

        Dim larghezza As Integer = 200
        Dim x0 As Integer = (PictureBox1.Width / 2) - (larghezza / 2)
        Dim y0 As Integer = (PictureBox1.Height / 2)
        Dim x1 As Integer = (PictureBox1.Width / 2) + (larghezza / 2)
        Dim y1 As Integer = (PictureBox1.Height / 2)

        Dim p0 As New Point(x0, y0)
        Dim p1 As New Point(x1, y1)

        g.DrawLine(penna, p0, p1)
        g.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim pen As New Pen(Color.Blue, 2)

        Dim centerX As Integer = PictureBox1.Width / 2
        Dim centerY As Integer = PictureBox1.Height / 2
        Dim radius As Integer = 70

        g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
        g.Dispose()

    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim penna As New Pen(Color.Blue, 2)

        Dim larghezza As Integer = 200
        Dim altezza As Integer = 100
        Dim x As Integer = (PictureBox1.Width / 2) - (larghezza / 2)
        Dim y As Integer = (PictureBox1.Height / 2) - (altezza / 2)

        g.DrawRectangle(penna, x, y, larghezza, altezza)
        g.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim brush As New SolidBrush(Color.Blue)

        Dim centerX As Integer = PictureBox1.Width / 2
        Dim centerY As Integer = PictureBox1.Height / 2
        Dim radius As Integer = 4

        g.FillEllipse(brush, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
        g.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim sfondo As New SolidBrush(PictureBox1.BackColor)

        g.FillRectangle(sfondo, 0, 0, PictureBox1.Width, PictureBox1.Height)
        g.Dispose()

    End Sub
End Class
