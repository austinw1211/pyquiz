<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonQuiz = New Button()
        ButtonAddQuestions = New Button()
        ButtonEditQuestions = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SaveNonfunctionalOnBuild1ToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonQuiz
        ' 
        ButtonQuiz.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonQuiz.Location = New Point(196, 542)
        ButtonQuiz.Name = "ButtonQuiz"
        ButtonQuiz.Size = New Size(158, 66)
        ButtonQuiz.TabIndex = 0
        ButtonQuiz.Text = "Quiz"
        ButtonQuiz.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddQuestions
        ' 
        ButtonAddQuestions.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonAddQuestions.Location = New Point(500, 542)
        ButtonAddQuestions.Name = "ButtonAddQuestions"
        ButtonAddQuestions.Size = New Size(158, 66)
        ButtonAddQuestions.TabIndex = 1
        ButtonAddQuestions.Text = "Add Questions"
        ButtonAddQuestions.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditQuestions
        ' 
        ButtonEditQuestions.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonEditQuestions.Location = New Point(812, 542)
        ButtonEditQuestions.Name = "ButtonEditQuestions"
        ButtonEditQuestions.Size = New Size(158, 66)
        ButtonEditQuestions.TabIndex = 2
        ButtonEditQuestions.Text = "Edit Questions"
        ButtonEditQuestions.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1206, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SaveNonfunctionalOnBuild1ToolStripMenuItem, QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' SaveNonfunctionalOnBuild1ToolStripMenuItem
        ' 
        SaveNonfunctionalOnBuild1ToolStripMenuItem.Name = "SaveNonfunctionalOnBuild1ToolStripMenuItem"
        SaveNonfunctionalOnBuild1ToolStripMenuItem.Size = New Size(242, 22)
        SaveNonfunctionalOnBuild1ToolStripMenuItem.Text = "Save (Nonfunctional on build 1)"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(242, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OptionsToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(304, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(577, 112)
        Label1.TabIndex = 4
        Label1.Text = "Self Quiz!"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(180, 22)
        OptionsToolStripMenuItem.Text = "Options"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1817
        ClientSize = New Size(1206, 733)
        Controls.Add(Label1)
        Controls.Add(ButtonEditQuestions)
        Controls.Add(ButtonAddQuestions)
        Controls.Add(ButtonQuiz)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonQuiz As Button
    Friend WithEvents ButtonAddQuestions As Button
    Friend WithEvents ButtonEditQuestions As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveNonfunctionalOnBuild1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem

End Class
