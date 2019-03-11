Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nam As String
        Dim key As String
        Dim count As Integer
        Dim length As Integer
        nam = CStr(TextBox3.Text)

        key = CStr(TextBox4.Text)
        length = nam.Length()

        

        count = nam.Split(key).Length - 1

        Label4.Text = count
        Label5.Text = "The number of " & key & "'s is  : "


    End Sub
End Class
