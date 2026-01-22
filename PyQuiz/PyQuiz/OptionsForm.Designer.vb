<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        DontButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 90)
        Label1.TabIndex = 0
        Label1.Text = "You are here wayyyyyyyy too early" & vbCrLf & " for this to have actual options. " & vbCrLf & "But since you found this anyways. " & vbCrLf & vbCrLf & "Don't click this button!" & vbCrLf & "You will regret it!"
        ' 
        ' DontButton
        ' 
        DontButton.Location = New Point(101, 138)
        DontButton.Name = "DontButton"
        DontButton.Size = New Size(106, 23)
        DontButton.TabIndex = 1
        DontButton.Text = "Don't push me!"
        DontButton.UseVisualStyleBackColor = True
        ' 
        ' OptionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 173)
        Controls.Add(DontButton)
        Controls.Add(Label1)
        Name = "OptionsForm"
        Text = "OptionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DontButton As Button
End Class
