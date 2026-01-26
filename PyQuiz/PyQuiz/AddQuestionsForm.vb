Public Class AddQuestionsForm
    ' Declare WithEvents for controls to use Handles clause
    Private WithEvents btnSave As Button
    Private txtQuestion As TextBox
    Private cmbCorrect As ComboBox
    Private txtChoice1 As TextBox
    Private txtChoice2 As TextBox
    Private txtChoice3 As TextBox
    Private txtChoice4 As TextBox

    Private Sub AddQuestionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create labels
        Dim lblQuestion As New Label With {.Text = "Question:", .Location = New Point(20, 20), .AutoSize = True}
        Dim lblChoice1 As New Label With {.Text = "Choice 1:", .Location = New Point(20, 60), .AutoSize = True}
        Dim lblChoice2 As New Label With {.Text = "Choice 2:", .Location = New Point(20, 100), .AutoSize = True}
        Dim lblChoice3 As New Label With {.Text = "Choice 3:", .Location = New Point(20, 140), .AutoSize = True}
        Dim lblChoice4 As New Label With {.Text = "Choice 4:", .Location = New Point(20, 180), .AutoSize = True}
        Dim lblCorrect As New Label With {.Text = "Correct Answer:", .Location = New Point(20, 220), .AutoSize = True}

        ' Initialize controls
        txtQuestion = New TextBox With {.Location = New Point(120, 17), .Width = 300}
        txtChoice1 = New TextBox With {.Location = New Point(120, 57), .Width = 300}
        txtChoice2 = New TextBox With {.Location = New Point(120, 97), .Width = 300}
        txtChoice3 = New TextBox With {.Location = New Point(120, 137), .Width = 300}
        txtChoice4 = New TextBox With {.Location = New Point(120, 177), .Width = 300}
        cmbCorrect = New ComboBox With {.Location = New Point(150, 217), .Width = 300}
        cmbCorrect.Items.AddRange(New String() {"Choice 1", "Choice 2", "Choice 3", "Choice 4"})
        btnSave = New Button With {.Location = New Point(120, 260), .Text = "Save", .Width = 100, .Height = 100}

        ' Add controls to form
        Me.Controls.AddRange({lblQuestion, txtQuestion, lblChoice1, txtChoice1, lblChoice2, txtChoice2, lblChoice3, txtChoice3, lblChoice4, txtChoice4, lblCorrect, cmbCorrect, btnSave})

        cmbCorrect.SelectedIndex = 0
    End Sub

    ' Fix IDE1006: Use PascalCase for method name
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtQuestion.Text = "" Then
            MessageBox.Show("Please enter a question.")
            Return
        End If

        Dim questions = QuestionStore.LoadQuestions()

        Dim q As New Question With {
            .Question = txtQuestion.Text,
            .Choices = New List(Of String) From {
                txtChoice1.Text,
                txtChoice2.Text,
                txtChoice3.Text,
                txtChoice4.Text
            },
            .AnswerIndex = cmbCorrect.SelectedIndex
        }

        questions.Add(q)
        QuestionStore.SaveQuestions(questions)

        MessageBox.Show("Question saved!")
        Me.Close()
    End Sub
End Class