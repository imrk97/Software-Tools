Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2, temp, n, i As Integer
        num1 = -1
        num2 = 1
        n = CInt(TextBox1.Text)
        If (n <= 0) Then
            MsgBox("ERROR: Wrong input!!")
        Else


            For i = 1 To n
                temp = num1 + num2
                num1 = num2
                num2 = temp
                ListBox1.Items.Add(temp)

            Next

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
