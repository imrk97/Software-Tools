Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

       





    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim temp1 As Double
        Dim temp2 As Double
        Dim r1 As Double
        Dim r2 As Double
        Dim temp3 As Double
        a = CDbl(MaskedTextBox1.Text)
        
        b = CDbl(MaskedTextBox2.Text)
        c = CDbl(MaskedTextBox3.Text)
        If (a = 0) Then
            MsgBox("!!ERROR!!")
            Return
        End If
        temp1 = ((b * b) - (4 * a * c))
        If (temp1 > 0) Then
            temp2 = Math.Sqrt(temp1)
            r1 = (-b / (2 * a)) + (temp2 / (2 * a))
            r2 = (-b / (2 * a)) - (temp2 / (2 * a))
            Label6.Text = r1
            Label7.Text = r2
        ElseIf (temp1 = 0) Then
            r1 = (-b / (2 * a))
            r2 = (-b / (2 * a))
            Label6.Text = r1
            Label7.Text = r2
        ElseIf (temp1 < 0) Then
            temp3 = -temp1
            temp2 = Math.Sqrt(temp3)
            r1 = (-b / (2 * a))
            r2 = temp3 / (2 * a)

            Label6.Text = r1 & "+" & r2 & "(i)"
            Label7.Text = r1 & "-" & r2 & "(i)"
        Else




        End If
    End Sub
End Class
