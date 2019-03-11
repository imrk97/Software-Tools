Public Class Form1
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Double
        f = CDbl(MaskedTextBox1.Text)
        Label2.Text = 5 / 9 * (f - 32)
        Label4.Text = 5 / 9 * (f - 32) - 273

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
