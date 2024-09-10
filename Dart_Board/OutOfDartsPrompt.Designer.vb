<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OutOfDartsPrompt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OutOfDartsPromptLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OutOfDartsPromptLabel
        '
        Me.OutOfDartsPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutOfDartsPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutOfDartsPromptLabel.ForeColor = System.Drawing.Color.Black
        Me.OutOfDartsPromptLabel.Location = New System.Drawing.Point(32, 27)
        Me.OutOfDartsPromptLabel.Name = "OutOfDartsPromptLabel"
        Me.OutOfDartsPromptLabel.Size = New System.Drawing.Size(238, 54)
        Me.OutOfDartsPromptLabel.TabIndex = 0
        Me.OutOfDartsPromptLabel.Text = "You're out of Darts!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please reset the game."
        Me.OutOfDartsPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OutOfDartsPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.OutOfDartsPromptLabel)
        Me.Name = "OutOfDartsPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutOfDartsPromptLabel As Label
End Class
