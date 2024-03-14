Public Class Form1

    ' StrikeOut label.
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, Label1.Font.Style Xor FontStyle.Strikeout)
    End Sub

    ' Underline label.
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, Label1.Font.Style Xor FontStyle.Underline)
    End Sub
End Class
