Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim f As Integer
        Dim i As Integer
        f = 1
        n = CInt(MaskedTextBox1.Text)

        For i = 1 To n
            f = f * i
            TextBox1.Text = f

        Next
        If (n < 0) Then
            TextBox1.Text = ("error")
            MsgBox("Factorial of negative number does not exist.")

        ElseIf (n = 0) Then
            TextBox1.Text = 1

        End If
    End Sub
End Class
