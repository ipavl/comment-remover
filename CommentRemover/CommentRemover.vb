'***************************************************'
'          Comment Remover for Programming          '
'                   Author: Ian P                   '
'  Description: Removes commented lines from code.  '
'                 Date: August 2011                 '
'***************************************************'

Imports System.IO
Imports System.DateTime
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class CommentRemover

    Private SourceFile, SourcePath As String

    Private OpenFileDialog As New OpenFileDialog

    Private VisualBasic, CVariant, Custom As Boolean
    Private CSharp, CPlusPlus, Java As Boolean

    Private Function SetVars()
        'This will set our variables appropriately.
        If rdoVB.Checked = True Then
            VisualBasic = True
            CVariant = False
            'Variables for Open File dialog
            CPlusPlus = False
            CSharp = False
            Java = False
        ElseIf rdoCPP.Checked = True Then
            VisualBasic = False
            'CVariant is from the old form design but the code still applies for simplicity.
            CVariant = True
            'Variables for Open File dialog
            CPlusPlus = True
            CSharp = False
            Java = False
        ElseIf rdoCS.Checked = True Then
            VisualBasic = False
            'CVariant is from the old form design but the code still applies for simplicity.
            CVariant = True
            'Variables for Open File dialog
            CPlusPlus = False
            CSharp = True
            Java = False
        ElseIf rdoJava.Checked = True Then
            VisualBasic = False
            'CVariant is from the old form design but the code still applies for simplicity.
            CVariant = True
            'Variables for Open File dialog
            CPlusPlus = False
            CSharp = False
            Java = True
        ElseIf rdoOther.Checked = True Then
            Custom = True
            gpbLanguage.Visible = False
            gpbCustom.Visible = True

            VisualBasic = False
            'CVariant is from the old form design but the code still applies for simplicity.
            CVariant = False
            'Variables for Open File dialog
            CPlusPlus = False
            CSharp = False
            Java = False
        End If
        Return Nothing
    End Function

    Private Function ShowOpenDialog()
        'Set variables
        SetVars()
        'Dialog settings
        With OpenFileDialog
            If Not Custom Then
                .Filter = "Visual Basic source file (*.vb)|*.vb|Java source file (*.java)|*.java|" & _
                    "C++ source file (*.c)|*.c|C# source file (*.cs)|*.cs|All files(*.*)|*.*"  'Shown formats
            Else
                .Filter = "Custom source file (*." & txtCustomExt.Text & ")|*." & txtCustomExt.Text & "|All files (*.*)|*.*"
            End If
            If VisualBasic = True Then
                .FilterIndex = 1    'Default file format choice
            ElseIf CVariant = True Then
                If Java = True Then
                    .FilterIndex = 2    'Default file format choice
                ElseIf CPlusPlus = True Then
                    .FilterIndex = 3
                ElseIf CSharp = True Then
                    .FilterIndex = 4
                ElseIf Custom = True Then
                    'This will be the custom index from above.
                    .FilterIndex = 1
                End If
            End If
        End With

        'Open the dialog
        OpenFileDialog.ShowDialog()
        'Fill the textbox with the file path
        txtSrcFile.Text = OpenFileDialog.FileName
        Return Nothing
    End Function

    Private Sub CommentRemover_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rdoVB.Checked = True
        VisualBasic = True
        gpbCustom.Visible = False
    End Sub

    Private Sub cmdOpenFileDialog_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenFileDialog.Click
        'Call the function we made earlier.
        ShowOpenDialog()
    End Sub

    Private Sub txtSrcFile_Click(sender As Object, e As System.EventArgs) Handles txtSrcFile.Click
        'We can just call our function since the dialog will do the checks for if the file exists for us.
        ShowOpenDialog()
    End Sub

    Private Sub cmdRemoveComments_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemoveComments.Click
        Try
            'Set variables
            SetVars()

            If txtSrcFile.Text <> Nothing Then
                'Set the SourceFile/Path variables to the value of the source file textbox, if it has something in it.
                SourcePath = txtSrcFile.Text
                'Just the filename with extension.
                SourceFile = Path.GetFileName(SourcePath)
            Else
                'Otherwise tell the user to specify a source file.
                MessageBox.Show("You didn't specify a source file!", "Information")
                'Return will skip the rest of the code for us since we can't do anything without a source file.
                Return
            End If

            If Not FileExists(SourcePath) Then
                'If the chosen file does not exist, stop doing everything in this sub.
                MessageBox.Show("The file " & SourcePath & " does not exist.", "File does not exist.")
                Exit Sub
            End If

            'This is purely aesthetics to show the example comments based on the programming language.
            'The If statement is not needed and the MessageBox.Show would only need to be present once.
            If VisualBasic = True Then
                'We should inform the user of what the program does and does not do before doing it.
                MessageBox.Show("At this time, the program will only delete commented lines if they are not following any code. " & _
                                "For example, this would be removed:" & vbNewLine & vbNewLine & _
                                "'this is a comment" & vbNewLine & vbNewLine & "but this would not be:" & vbNewLine & vbNewLine & _
                                "Dim data as Integer   'Declare a variable" & vbNewLine & vbNewLine & "The source file will be backed up to '" & _
                                SourceFile & ".commented'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CVariant = True Then
                'We should inform the user of what the program does and does not do before doing it.
                MessageBox.Show("At this time, the program will only delete commented lines if they are not following any code. " & _
                                "For example, this would be removed:" & vbNewLine & vbNewLine & _
                                "//this is a comment" & vbNewLine & vbNewLine & "but this would not be:" & vbNewLine & vbNewLine & _
                                "int Variable;   //Declare a variable" & vbNewLine & vbNewLine & "It also currently does not remove 'block' " & _
                                "comments (those in the format of /* TEXT */. The source file will be backed up to '" & SourceFile & ".commented'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Custom = True Then
                'We should inform the user of what the program does and does not do before doing it.
                MessageBox.Show("At this time, the program will only delete commented lines if they are not following any code. " & _
                                "For example, this would be removed:" & vbNewLine & vbNewLine & _
                                txtCustomComment.Text & "this is a comment" & vbNewLine & vbNewLine & "but this would not be:" & vbNewLine & vbNewLine & _
                                "int Variable;   " & txtCustomComment.Text & "Declare a variable" & vbNewLine & vbNewLine & "The source file will be backed up to '" & _
                                SourceFile & ".commented'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            If FileExists(SourcePath & ".commented") Then
                'If there's already a .commented version of the source file, it will give us an error.
                'We can deal with that in various ways; have the user delete the file/prompt to delete it ourself or we
                'could append some form of text onto the end/elsewhere in the file. Either loop until a suitable file is
                'found using standard numbers, or insert something that is hard to have multiple of the same file name as,
                'such as the date/time. This can also help the user distingiush between files.
                FileCopy(SourcePath, SourcePath & Now().ToString("_M-dd-yy_HH-mm-ss") & ".commented")
            Else
                'Backup the original file.
                File.Copy(SourcePath, SourcePath & ".commented")
            End If

            'Now that all that is done, we should be set to actually remove the comments from the source file.

            Dim fileLines As New List(Of String)(File.ReadAllLines(SourcePath))

            If VisualBasic = True Then
                fileLines.RemoveAll(Function(s) s.Trim.StartsWith("'"))
            ElseIf CVariant = True Then
                fileLines.RemoveAll(Function(s) s.Trim.StartsWith("//"))
            ElseIf Custom = True Then
                fileLines.RemoveAll(Function(s) s.Trim.StartsWith(txtCustomComment.Text))
            End If

            'Write text back to file.
            File.WriteAllLines(SourcePath, fileLines.ToArray)

            'MessageBox.Show("Commented lines removed: " & counter, "Information")
            MessageBox.Show("Comments removed from file (hopefully!)", "Information")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub lnkNotCustom_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNotCustom.LinkClicked
        gpbLanguage.Visible = True
        gpbCustom.Visible = False
        Custom = False
        rdoVB.Checked = True
        SetVars()
    End Sub

    Private Sub rdoOther_Click(sender As Object, e As System.EventArgs) Handles rdoOther.Click
        gpbLanguage.Visible = False
        gpbCustom.Visible = True
        Custom = True
        SetVars()
    End Sub
End Class
