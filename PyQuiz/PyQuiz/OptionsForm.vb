Public Class OptionsForm
    Private Sub DontButton_Click(sender As Object, e As EventArgs) Handles DontButton.Click
        MessageBox.Show("Stop pressing this.", "I warned you.")

        Dim r As New Random()
        DontButton.Location = New Point(
            r.Next(0, Me.ClientSize.Width - DontButton.Width),
            r.Next(0, Me.ClientSize.Height - DontButton.Height)
        )
    End Sub


End Class