Public Class QuizForm
    Private questions As List(Of Question)
    Private currentIndex As Integer = 0
    Private score As Integer = 0

    Private lblQuestion As Label
    Private rb1 As RadioButton
    Private rb2 As RadioButton
    Private rb3 As RadioButton
    Private rb4 As RadioButton
    Private WithEvents btnSubmit As Button

    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        questions = QuestionStore.LoadQuestions()

        If questions.Count = 0 Then
            MessageBox.Show("No questions available.")
            Me.Close()
            Return
        End If

        lblQuestion = New Label() With {.Name = "lblQuestion", .AutoSize = True, .Location = New Point(20, 20)}
        rb1 = New RadioButton() With {.Name = "rb1", .AutoSize = True, .Location = New Point(20, 60)}
        rb2 = New RadioButton() With {.Name = "rb2", .AutoSize = True, .Location = New Point(20, 90)}
        rb3 = New RadioButton() With {.Name = "rb3", .AutoSize = True, .Location = New Point(20, 120)}
        rb4 = New RadioButton() With {.Name = "rb4", .AutoSize = True, .Location = New Point(20, 150)}
        btnSubmit = New Button() With {.Name = "btnSubmit", .Text = "Submit", .AutoSize = True, .Location = New Point(20, 190)}

        Me.Controls.Add(lblQuestion)
        Me.Controls.Add(rb1)
        Me.Controls.Add(rb2)
        Me.Controls.Add(rb3)
        Me.Controls.Add(rb4)
        Me.Controls.Add(btnSubmit)

        LoadQuestion()
    End Sub

    Private Sub LoadQuestion()
        Dim q = questions(currentIndex)

        lblQuestion.Text = q.Question
        rb1.Text = q.Choices(0)
        rb2.Text = q.Choices(1)
        rb3.Text = q.Choices(2)
        rb4.Text = q.Choices(3)

        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim selected As Integer = -1

        If rb1.Checked Then selected = 0
        If rb2.Checked Then selected = 1
        If rb3.Checked Then selected = 2
        If rb4.Checked Then selected = 3

        If selected = questions(currentIndex).AnswerIndex Then
            score += 1
        End If

        currentIndex += 1

        If currentIndex >= questions.Count Then
            MessageBox.Show($"Final Score: {score}/{questions.Count}")
            Me.Close()
        Else
            LoadQuestion()
        End If
    End Sub

End Class