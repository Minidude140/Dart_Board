<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dart_board_form
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
        Me.components = New System.ComponentModel.Container()
        Me.ThrowDartButton = New System.Windows.Forms.Button()
        Me.ThrowDartButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ThrowsLabel = New System.Windows.Forms.Label()
        Me.OutOfLabel = New System.Windows.Forms.Label()
        Me.NumberOfThrowLabel = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.OptionsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThrowDartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportPreviousSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThrowDartButton
        '
        Me.ThrowDartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowDartButton.Location = New System.Drawing.Point(12, 520)
        Me.ThrowDartButton.Name = "ThrowDartButton"
        Me.ThrowDartButton.Size = New System.Drawing.Size(384, 50)
        Me.ThrowDartButton.TabIndex = 0
        Me.ThrowDartButton.Text = "Throw Dart"
        Me.ThrowDartButton.UseVisualStyleBackColor = True
        '
        'ThrowDartButtonToolTip
        '
        Me.ThrowDartButtonToolTip.ToolTipTitle = "This Button Will Throw a Dart"
        '
        'ThrowsLabel
        '
        Me.ThrowsLabel.AutoSize = True
        Me.ThrowsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowsLabel.Location = New System.Drawing.Point(429, 520)
        Me.ThrowsLabel.Name = "ThrowsLabel"
        Me.ThrowsLabel.Size = New System.Drawing.Size(142, 20)
        Me.ThrowsLabel.TabIndex = 2
        Me.ThrowsLabel.Text = "Number of Throws:"
        '
        'OutOfLabel
        '
        Me.OutOfLabel.AutoSize = True
        Me.OutOfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutOfLabel.Location = New System.Drawing.Point(503, 551)
        Me.OutOfLabel.Name = "OutOfLabel"
        Me.OutOfLabel.Size = New System.Drawing.Size(41, 18)
        Me.OutOfLabel.TabIndex = 3
        Me.OutOfLabel.Text = "/   I I I"
        '
        'NumberOfThrowLabel
        '
        Me.NumberOfThrowLabel.AutoSize = True
        Me.NumberOfThrowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfThrowLabel.Location = New System.Drawing.Point(472, 551)
        Me.NumberOfThrowLabel.Name = "NumberOfThrowLabel"
        Me.NumberOfThrowLabel.Size = New System.Drawing.Size(25, 18)
        Me.NumberOfThrowLabel.TabIndex = 4
        Me.NumberOfThrowLabel.Text = "I I I"
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(866, 519)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(205, 50)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'OptionsMenuStrip
        '
        Me.OptionsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.OptionsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.OptionsMenuStrip.Name = "OptionsMenuStrip"
        Me.OptionsMenuStrip.Size = New System.Drawing.Size(1083, 24)
        Me.OptionsMenuStrip.TabIndex = 6
        Me.OptionsMenuStrip.Text = "Options"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThrowDartToolStripMenuItem, Me.ResetGameToolStripMenuItem, Me.ImportPreviousSaveToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ThrowDartToolStripMenuItem
        '
        Me.ThrowDartToolStripMenuItem.Name = "ThrowDartToolStripMenuItem"
        Me.ThrowDartToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ThrowDartToolStripMenuItem.Text = "ThrowDart"
        '
        'ResetGameToolStripMenuItem
        '
        Me.ResetGameToolStripMenuItem.Name = "ResetGameToolStripMenuItem"
        Me.ResetGameToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ResetGameToolStripMenuItem.Text = "Reset Game"
        '
        'ImportPreviousSaveToolStripMenuItem
        '
        Me.ImportPreviousSaveToolStripMenuItem.Name = "ImportPreviousSaveToolStripMenuItem"
        Me.ImportPreviousSaveToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ImportPreviousSaveToolStripMenuItem.Text = "Import Previous Save"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Dart_board_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 582)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.NumberOfThrowLabel)
        Me.Controls.Add(Me.OutOfLabel)
        Me.Controls.Add(Me.ThrowsLabel)
        Me.Controls.Add(Me.ThrowDartButton)
        Me.Controls.Add(Me.OptionsMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.OptionsMenuStrip
        Me.MaximizeBox = False
        Me.Name = "Dart_board_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dart Board"
        Me.OptionsMenuStrip.ResumeLayout(False)
        Me.OptionsMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThrowDartButton As Button
    Friend WithEvents ThrowDartButtonToolTip As ToolTip
    Friend WithEvents ThrowsLabel As Label
    Friend WithEvents OutOfLabel As Label
    Friend WithEvents NumberOfThrowLabel As Label
    Friend WithEvents QuitButton As Button
    Friend WithEvents OptionsMenuStrip As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThrowDartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportPreviousSaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
