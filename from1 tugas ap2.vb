Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
         Lbl_Font.Font.Style Xor FontStyle.Regular)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif", Lbl_Font.Font.Size,
        Lbl_Font.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif",
        Lbl_Font.Font.Size, Lbl_Font.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Lbl_Font.Font = New Font("Microsoft sans Serif",
        Lbl_Font.Font.Size, Lbl_Font.Font.Style Xor FontStyle.Bold Xor FontStyle.Italic)
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        Lbl_Font.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Lbl_Font.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Lbl_Font.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Lbl_Font.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Lbl_Font.Font = New Font("Lbl_Font", 10)
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        Lbl_Font.Font = New Font("Lbl_Font", 13)
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Lbl_Font.Font = New Font("Lbl_Font", 15)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Lbl_Font.Font = New Font("Lbl_Font", 17)
    End Sub
End Class