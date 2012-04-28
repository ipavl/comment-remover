<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommentRemover
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSrcFile = New System.Windows.Forms.TextBox()
        Me.rdoVB = New System.Windows.Forms.RadioButton()
        Me.gpbLanguage = New System.Windows.Forms.GroupBox()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.rdoJava = New System.Windows.Forms.RadioButton()
        Me.rdoCS = New System.Windows.Forms.RadioButton()
        Me.rdoCPP = New System.Windows.Forms.RadioButton()
        Me.cmdRemoveComments = New System.Windows.Forms.Button()
        Me.cmdOpenFileDialog = New System.Windows.Forms.Button()
        Me.gpbCustom = New System.Windows.Forms.GroupBox()
        Me.lnkNotCustom = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomComment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomExt = New System.Windows.Forms.TextBox()
        Me.gpbLanguage.SuspendLayout()
        Me.gpbCustom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source file:"
        '
        'txtSrcFile
        '
        Me.txtSrcFile.Location = New System.Drawing.Point(76, 6)
        Me.txtSrcFile.Name = "txtSrcFile"
        Me.txtSrcFile.Size = New System.Drawing.Size(250, 20)
        Me.txtSrcFile.TabIndex = 1
        '
        'rdoVB
        '
        Me.rdoVB.AutoSize = True
        Me.rdoVB.Location = New System.Drawing.Point(12, 17)
        Me.rdoVB.Name = "rdoVB"
        Me.rdoVB.Size = New System.Drawing.Size(82, 17)
        Me.rdoVB.TabIndex = 2
        Me.rdoVB.TabStop = True
        Me.rdoVB.Text = "Visual Basic"
        Me.rdoVB.UseVisualStyleBackColor = True
        '
        'gpbLanguage
        '
        Me.gpbLanguage.Controls.Add(Me.rdoOther)
        Me.gpbLanguage.Controls.Add(Me.rdoJava)
        Me.gpbLanguage.Controls.Add(Me.rdoCS)
        Me.gpbLanguage.Controls.Add(Me.rdoCPP)
        Me.gpbLanguage.Controls.Add(Me.rdoVB)
        Me.gpbLanguage.Location = New System.Drawing.Point(14, 36)
        Me.gpbLanguage.Name = "gpbLanguage"
        Me.gpbLanguage.Size = New System.Drawing.Size(336, 43)
        Me.gpbLanguage.TabIndex = 3
        Me.gpbLanguage.TabStop = False
        Me.gpbLanguage.Text = "Programming Language"
        '
        'rdoOther
        '
        Me.rdoOther.AutoSize = True
        Me.rdoOther.Location = New System.Drawing.Point(273, 17)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(51, 17)
        Me.rdoOther.TabIndex = 6
        Me.rdoOther.TabStop = True
        Me.rdoOther.Text = "Other"
        Me.rdoOther.UseVisualStyleBackColor = True
        '
        'rdoJava
        '
        Me.rdoJava.AutoSize = True
        Me.rdoJava.Location = New System.Drawing.Point(208, 17)
        Me.rdoJava.Name = "rdoJava"
        Me.rdoJava.Size = New System.Drawing.Size(48, 17)
        Me.rdoJava.TabIndex = 5
        Me.rdoJava.TabStop = True
        Me.rdoJava.Text = "Java"
        Me.rdoJava.UseVisualStyleBackColor = True
        '
        'rdoCS
        '
        Me.rdoCS.AutoSize = True
        Me.rdoCS.Location = New System.Drawing.Point(163, 17)
        Me.rdoCS.Name = "rdoCS"
        Me.rdoCS.Size = New System.Drawing.Size(39, 17)
        Me.rdoCS.TabIndex = 4
        Me.rdoCS.TabStop = True
        Me.rdoCS.Text = "C#"
        Me.rdoCS.UseVisualStyleBackColor = True
        '
        'rdoCPP
        '
        Me.rdoCPP.AutoSize = True
        Me.rdoCPP.Location = New System.Drawing.Point(113, 17)
        Me.rdoCPP.Name = "rdoCPP"
        Me.rdoCPP.Size = New System.Drawing.Size(44, 17)
        Me.rdoCPP.TabIndex = 3
        Me.rdoCPP.TabStop = True
        Me.rdoCPP.Text = "C++"
        Me.rdoCPP.UseVisualStyleBackColor = True
        '
        'cmdRemoveComments
        '
        Me.cmdRemoveComments.Location = New System.Drawing.Point(117, 92)
        Me.cmdRemoveComments.Name = "cmdRemoveComments"
        Me.cmdRemoveComments.Size = New System.Drawing.Size(130, 24)
        Me.cmdRemoveComments.TabIndex = 4
        Me.cmdRemoveComments.Text = "Remove Comments"
        Me.cmdRemoveComments.UseVisualStyleBackColor = True
        '
        'cmdOpenFileDialog
        '
        Me.cmdOpenFileDialog.Location = New System.Drawing.Point(332, 4)
        Me.cmdOpenFileDialog.Name = "cmdOpenFileDialog"
        Me.cmdOpenFileDialog.Size = New System.Drawing.Size(23, 23)
        Me.cmdOpenFileDialog.TabIndex = 5
        Me.cmdOpenFileDialog.Text = "..."
        Me.cmdOpenFileDialog.UseVisualStyleBackColor = True
        '
        'gpbCustom
        '
        Me.gpbCustom.Controls.Add(Me.lnkNotCustom)
        Me.gpbCustom.Controls.Add(Me.Label4)
        Me.gpbCustom.Controls.Add(Me.Label3)
        Me.gpbCustom.Controls.Add(Me.txtCustomComment)
        Me.gpbCustom.Controls.Add(Me.Label2)
        Me.gpbCustom.Controls.Add(Me.txtCustomExt)
        Me.gpbCustom.Location = New System.Drawing.Point(14, 36)
        Me.gpbCustom.Name = "gpbCustom"
        Me.gpbCustom.Size = New System.Drawing.Size(336, 43)
        Me.gpbCustom.TabIndex = 9
        Me.gpbCustom.TabStop = False
        Me.gpbCustom.Text = "Custom Language"
        '
        'lnkNotCustom
        '
        Me.lnkNotCustom.AutoSize = True
        Me.lnkNotCustom.Location = New System.Drawing.Point(102, 0)
        Me.lnkNotCustom.Name = "lnkNotCustom"
        Me.lnkNotCustom.Size = New System.Drawing.Size(71, 13)
        Me.lnkNotCustom.TabIndex = 5
        Me.lnkNotCustom.TabStop = True
        Me.lnkNotCustom.Text = "(Non-Custom)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Comment Syntax:"
        '
        'txtCustomComment
        '
        Me.txtCustomComment.Location = New System.Drawing.Point(259, 16)
        Me.txtCustomComment.Name = "txtCustomComment"
        Me.txtCustomComment.Size = New System.Drawing.Size(47, 20)
        Me.txtCustomComment.TabIndex = 2
        Me.txtCustomComment.Text = "//"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "File extension:"
        '
        'txtCustomExt
        '
        Me.txtCustomExt.Location = New System.Drawing.Point(111, 16)
        Me.txtCustomExt.Name = "txtCustomExt"
        Me.txtCustomExt.Size = New System.Drawing.Size(47, 20)
        Me.txtCustomExt.TabIndex = 0
        '
        'CommentRemover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 128)
        Me.Controls.Add(Me.cmdOpenFileDialog)
        Me.Controls.Add(Me.cmdRemoveComments)
        Me.Controls.Add(Me.txtSrcFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbLanguage)
        Me.Controls.Add(Me.gpbCustom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CommentRemover"
        Me.Text = "Comment Remover"
        Me.gpbLanguage.ResumeLayout(False)
        Me.gpbLanguage.PerformLayout()
        Me.gpbCustom.ResumeLayout(False)
        Me.gpbCustom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSrcFile As System.Windows.Forms.TextBox
    Friend WithEvents rdoVB As System.Windows.Forms.RadioButton
    Friend WithEvents gpbLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemoveComments As System.Windows.Forms.Button
    Friend WithEvents cmdOpenFileDialog As System.Windows.Forms.Button
    Friend WithEvents rdoJava As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCS As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCPP As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOther As System.Windows.Forms.RadioButton
    Friend WithEvents gpbCustom As System.Windows.Forms.GroupBox
    Friend WithEvents lnkNotCustom As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomComment As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomExt As System.Windows.Forms.TextBox

End Class
