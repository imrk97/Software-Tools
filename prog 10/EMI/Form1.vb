Public Class Form1
    Dim t As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        t = HScrollBar1.Value()
        TextBox2.Text = t

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULATE.Click
        Dim p, emi As Integer
        Dim famt, temp As Double
        p = CInt(TextBox1.Text)
        temp = Math.Pow(1.095, t)
        famt = p * temp
        emi = (famt / (12 * t))
        ListBox1.Items.Add(emi & " Rupees")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEAR.Click
        ListBox1.Items.Clear()
    End Sub
End Class
