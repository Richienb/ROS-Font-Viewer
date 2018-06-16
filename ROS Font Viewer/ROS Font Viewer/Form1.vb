Public Class Form1
    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
        Me.BackColor = Color.FromArgb(33, 33, 33)
        My.Settings.BackgroundColour = Color.FromArgb(33, 33, 33)
        Me.ForeColor = Color.FromArgb(250, 250, 250)
        My.Settings.ForegrondColour = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub OvalShape2_Click(sender As Object, e As EventArgs) Handles OvalShape2.Click
        Me.ForeColor = Color.FromArgb(33, 33, 33)
        My.Settings.ForegrondColour = Color.FromArgb(33, 33, 33)
        Me.BackColor = Color.FromArgb(250, 250, 250)
        My.Settings.BackgroundColour = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
