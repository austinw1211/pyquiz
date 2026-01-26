Imports System.IO
Imports System.Text.Json

Module QuestionStore

    Private ReadOnly FilePath As String = "questions.json"

    Public Function LoadQuestions() As List(Of Question)
        If Not File.Exists(FilePath) Then
            Return New List(Of Question)
        End If

        Dim json = File.ReadAllText(FilePath)
        Return JsonSerializer.Deserialize(Of List(Of Question))(json)
    End Function

    Public Sub SaveQuestions(questions As List(Of Question))
        Dim json = JsonSerializer.Serialize(questions, New JsonSerializerOptions With {
            .WriteIndented = True
        })
        File.WriteAllText(FilePath, json)
    End Sub

End Module

