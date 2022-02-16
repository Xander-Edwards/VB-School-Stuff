Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "password" And TextBox2.Text = "admin" Then
            PictureBox1.Visible = False
            Label3.Visible = True
        ElseIf TextBox1.Text = "bruhmoment420" And TextBox2.Text = "xander" Then
            PictureBox1.Visible = False
            Label3.Visible = False
        Else
            PictureBox1.Visible = True
            Label3.Visible = False
        End If
    End Sub
End Class
