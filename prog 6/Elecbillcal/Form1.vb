Public Class Form1

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click, Label26.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        name = CStr(TextBox1.Text)
        Label16.Text = name

        Dim addr As String
        addr = CStr(TextBox2.Text)
        Label17.Text = addr
        Dim ID As Integer
        ID = CInt(TextBox3.Text)
        Label18.Text = ID
        Dim bmnth As String
        bmnth = CStr(TextBox4.Text)
        Label19.Text = bmnth
        Dim duedt As String
        duedt = CStr(TextBox5.Text)
        Label20.Text = duedt
        Dim bdt As String
        bdt = CStr(TextBox6.Text)
        Label21.Text = bdt
        Dim punit, cunit, unit As Integer
        punit = CInt(TextBox7.Text)
        cunit = CInt(TextBox8.Text)
        unit = cunit - punit
        Label22.Text = punit
        Label23.Text = cunit
        Label27.Text = unit
        Dim amt As Integer
        If (unit < 100) Then
            amt = amt + unit * 1.2
        ElseIf (unit > 100 & unit < 300) Then
            amt = amt + 120 + (unit - 100) * 2.4
        ElseIf (unit > 300 & unit < 600) Then
            amt = amt + 500 + (amt * 0.35)


        End If
        If (amt < 600) Then
            MsgBox("The Ammount must be more than 600 Rupees")
        Else
            Label26.Text = amt
        End If
    End Sub
End Class
