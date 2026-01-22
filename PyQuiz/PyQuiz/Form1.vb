Public Class Form1

    Private Sub ButtonQuiz_Click(sender As Object, e As EventArgs) Handles ButtonQuiz.Click
        Dim quizWindow As New QuizForm()
        quizWindow.Show()
    End Sub

    Private Sub ButtonAddQuestions_Click(sender As Object, e As EventArgs) Handles ButtonAddQuestions.Click
        Dim addWindow As New AddQuestionsForm()
        addWindow.Show()
    End Sub

    Private Sub ButtonEditQuestions_Click(sender As Object, e As EventArgs) Handles ButtonEditQuestions.Click
        Dim editWindow As New EditQuestionsForm()
        editWindow.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim optionsWindow As New OptionsForm()
        optionsWindow.Show()
    End Sub
End Class
