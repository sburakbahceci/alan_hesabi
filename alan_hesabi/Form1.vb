Public Class Form1
    Public kısa_kenar, uzun_kenar, yükseklik, yaricap, alan As Double

    Public Const pi As Single = 3.14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            kısa_kenar = TextBox1.Text
            alan = kısa_kenar * kısa_kenar
            TextBox5.Text = alan
        End If
        If RadioButton2.Checked Then
            kısa_kenar = TextBox1.Text
            uzun_kenar = TextBox2.Text
            alan = kısa_kenar * uzun_kenar
            TextBox5.Text = alan
        End If
        If RadioButton3.Checked Then
            kısa_kenar = TextBox1.Text
            yükseklik = TextBox3.Text
            alan = kısa_kenar * yükseklik / 2
            TextBox5.Text = alan
        End If
        If RadioButton4.Checked Then
            yaricap = TextBox4.Text
            alan = pi * yaricap * yaricap
            TextBox5.Text = alan
        End If
    End Sub
End Class
