Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, i, ans As Integer
        Dim fans As String
        n = CInt(ComboBox1.Text)
        For i = 1 To 10
            ans = n * i
            fans = (n & "*" & i & "=" & ans)
            ListBox1.Items.Add(fans)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
