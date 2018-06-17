Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each oFont As FontFamily In FontFamily.Families
            ComboBox1.Items.Add(oFont.Name)
        Next
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim oFont As New FontFamily(ComboBox1.Text)

        If oFont.IsStyleAvailable(FontStyle.Bold) Then
            BoldButton.Enabled = True
        Else
            BoldButton.Enabled = False
        End If

        If oFont.IsStyleAvailable(FontStyle.Italic) Then
            ItalicButton.Enabled = True
        Else
            ItalicButton.Enabled = False
        End If

        If oFont.IsStyleAvailable(FontStyle.Regular) Then
            'ComboBox2.Items.Add("Regular")
        End If

        If oFont.IsStyleAvailable(FontStyle.Strikeout) Then
            StrikethroughButton.Enabled = True
        Else
            StrikethroughButton.Enabled = False
        End If

        If oFont.IsStyleAvailable(FontStyle.Underline) Then
            UnderlineButton.Enabled = True
        Else
            UnderlineButton.Enabled = False
        End If
    End Sub

    Private Sub BoldButton_Click(sender As Object, e As EventArgs) Handles BoldButton.Click

    End Sub
End Class
