Public Class EditQuestionsForm
    Private questions As List(Of Question)
    Private WithEvents lstQuestions As ListBox
    Private WithEvents txtQuestion As TextBox
    Private WithEvents txtChoice1 As TextBox
    Private WithEvents txtChoice2 As TextBox
    Private WithEvents txtChoice3 As TextBox
    Private WithEvents txtChoice4 As TextBox
    Private WithEvents cmbCorrect As ComboBox
    Private WithEvents btnSave As Button

    Private Sub EditQuestionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize list
        lstQuestions = New ListBox With {.Location = New Point(20, 20), .Width = 250, .Height = 400}

        ' Create labels
        Dim lblQuestion As New Label With {.Text = "Question:", .Location = New Point(290, 20), .AutoSize = True}
        Dim lblChoice1 As New Label With {.Text = "Choice 1:", .Location = New Point(290, 80), .AutoSize = True}
        Dim lblChoice2 As New Label With {.Text = "Choice 2:", .Location = New Point(290, 120), .AutoSize = True}
        Dim lblChoice3 As New Label With {.Text = "Choice 3:", .Location = New Point(290, 160), .AutoSize = True}
        Dim lblChoice4 As New Label With {.Text = "Choice 4:", .Location = New Point(290, 200), .AutoSize = True}
        Dim lblCorrect As New Label With {.Text = "Correct Answer:", .Location = New Point(290, 240), .AutoSize = True}

        ' Initialize edit controls
        txtQuestion = New TextBox With {.Location = New Point(420, 17), .Width = 350, .Multiline = True, .Height = 50}
        txtChoice1 = New TextBox With {.Location = New Point(420, 77), .Width = 350}
        txtChoice2 = New TextBox With {.Location = New Point(420, 117), .Width = 350}
        txtChoice3 = New TextBox With {.Location = New Point(420, 157), .Width = 350}
        txtChoice4 = New TextBox With {.Location = New Point(420, 197), .Width = 350}
        cmbCorrect = New ComboBox With {.Location = New Point(420, 237), .Width = 350}
        cmbCorrect.Items.AddRange(New String() {"Choice 1", "Choice 2", "Choice 3", "Choice 4"})

        btnSave = New Button With {.Location = New Point(420, 280), .Text = "Save Changes", .Width = 120}

        ' Add controls to form
        Me.Controls.AddRange({lstQuestions, lblQuestion, txtQuestion, lblChoice1, txtChoice1, lblChoice2, txtChoice2, lblChoice3, txtChoice3, lblChoice4, txtChoice4, lblCorrect, cmbCorrect, btnSave})

        ' Set form size
        Me.ClientSize = New Size(800, 450)

        questions = QuestionStore.LoadQuestions()
        lstQuestions.DataSource = questions
        lstQuestions.DisplayMember = "Question"
    End Sub

    Private Sub lstQuestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuestions.SelectedIndexChanged
        If lstQuestions.SelectedIndex >= 0 Then
            Dim q = questions(lstQuestions.SelectedIndex)

            ' Populate all fields
            txtQuestion.Text = q.Question
            txtChoice1.Text = If(q.Choices.Count > 0, q.Choices(0), "")
            txtChoice2.Text = If(q.Choices.Count > 1, q.Choices(1), "")
            txtChoice3.Text = If(q.Choices.Count > 2, q.Choices(2), "")
            txtChoice4.Text = If(q.Choices.Count > 3, q.Choices(3), "")
            cmbCorrect.SelectedIndex = q.AnswerIndex
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lstQuestions.SelectedIndex >= 0 Then
            Dim q = questions(lstQuestions.SelectedIndex)

            ' Update all fields
            q.Question = txtQuestion.Text
            q.Choices = New List(Of String) From {
                txtChoice1.Text,
                txtChoice2.Text,
                txtChoice3.Text,
                txtChoice4.Text
            }
            q.AnswerIndex = cmbCorrect.SelectedIndex

            QuestionStore.SaveQuestions(questions)

            ' Refresh the list to show updated question text
            lstQuestions.DataSource = Nothing
            lstQuestions.DataSource = questions
            lstQuestions.DisplayMember = "Question"

            MessageBox.Show("Question updated!")
        End If
    End Sub

End Class