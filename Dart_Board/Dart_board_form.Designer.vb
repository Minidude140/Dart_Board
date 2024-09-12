<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dart_board_form
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
        Me.components = New System.ComponentModel.Container()
        Me.ThrowDartButton = New System.Windows.Forms.Button()
        Me.DartBoardToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ResetGameButton = New System.Windows.Forms.Button()
        Me.ThrowsLabel = New System.Windows.Forms.Label()
        Me.OutOfLabel = New System.Windows.Forms.Label()
        Me.NumberOfThrowLabel = New System.Windows.Forms.Label()
        Me.OptionsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThrowDartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportPreviousSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DartBoardPictureBox = New System.Windows.Forms.PictureBox()
        Me.GameThrowLabel = New System.Windows.Forms.Label()
        Me.GameThrowsCounterLabel = New System.Windows.Forms.Label()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.OptionsMenuStrip.SuspendLayout()
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThrowDartButton
        '
        Me.ThrowDartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ThrowDartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowDartButton.Location = New System.Drawing.Point(16, 640)
        Me.ThrowDartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ThrowDartButton.Name = "ThrowDartButton"
        Me.ThrowDartButton.Size = New System.Drawing.Size(372, 62)
        Me.ThrowDartButton.TabIndex = 1
        Me.ThrowDartButton.Text = "Throw Dart"
        Me.DartBoardToolTip.SetToolTip(Me.ThrowDartButton, "This Button Will Generate a Random Dart Throw")
        Me.ThrowDartButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(1155, 639)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(169, 62)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit"
        Me.DartBoardToolTip.SetToolTip(Me.QuitButton, "This Button Will Exit the Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetGameButton
        '
        Me.ResetGameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetGameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetGameButton.Location = New System.Drawing.Point(977, 639)
        Me.ResetGameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetGameButton.Name = "ResetGameButton"
        Me.ResetGameButton.Size = New System.Drawing.Size(169, 62)
        Me.ResetGameButton.TabIndex = 2
        Me.ResetGameButton.Text = "Reset"
        Me.DartBoardToolTip.SetToolTip(Me.ResetGameButton, "This Button Will Reset the Game")
        Me.ResetGameButton.UseVisualStyleBackColor = True
        '
        'ThrowsLabel
        '
        Me.ThrowsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ThrowsLabel.AutoSize = True
        Me.ThrowsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowsLabel.Location = New System.Drawing.Point(432, 640)
        Me.ThrowsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ThrowsLabel.Name = "ThrowsLabel"
        Me.ThrowsLabel.Size = New System.Drawing.Size(178, 25)
        Me.ThrowsLabel.TabIndex = 5
        Me.ThrowsLabel.Text = "Number of Throws:"
        '
        'OutOfLabel
        '
        Me.OutOfLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OutOfLabel.AutoSize = True
        Me.OutOfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutOfLabel.Location = New System.Drawing.Point(517, 679)
        Me.OutOfLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OutOfLabel.Name = "OutOfLabel"
        Me.OutOfLabel.Size = New System.Drawing.Size(52, 24)
        Me.OutOfLabel.TabIndex = 3
        Me.OutOfLabel.Text = "/   I I I"
        '
        'NumberOfThrowLabel
        '
        Me.NumberOfThrowLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NumberOfThrowLabel.AutoSize = True
        Me.NumberOfThrowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfThrowLabel.Location = New System.Drawing.Point(476, 679)
        Me.NumberOfThrowLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumberOfThrowLabel.Name = "NumberOfThrowLabel"
        Me.NumberOfThrowLabel.Size = New System.Drawing.Size(32, 24)
        Me.NumberOfThrowLabel.TabIndex = 4
        Me.NumberOfThrowLabel.Text = "I I I"
        '
        'OptionsMenuStrip
        '
        Me.OptionsMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OptionsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.OptionsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.OptionsMenuStrip.Name = "OptionsMenuStrip"
        Me.OptionsMenuStrip.Size = New System.Drawing.Size(1339, 30)
        Me.OptionsMenuStrip.TabIndex = 6
        Me.OptionsMenuStrip.Text = "Options"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThrowDartToolStripMenuItem, Me.ResetGameToolStripMenuItem, Me.ImportPreviousSaveToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ThrowDartToolStripMenuItem
        '
        Me.ThrowDartToolStripMenuItem.Name = "ThrowDartToolStripMenuItem"
        Me.ThrowDartToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ThrowDartToolStripMenuItem.Text = "ThrowDart"
        '
        'ResetGameToolStripMenuItem
        '
        Me.ResetGameToolStripMenuItem.Name = "ResetGameToolStripMenuItem"
        Me.ResetGameToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ResetGameToolStripMenuItem.Text = "Reset Game"
        '
        'ImportPreviousSaveToolStripMenuItem
        '
        Me.ImportPreviousSaveToolStripMenuItem.Name = "ImportPreviousSaveToolStripMenuItem"
        Me.ImportPreviousSaveToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ImportPreviousSaveToolStripMenuItem.Text = "Import Previous Save"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.AutoToolTip = True
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "Press This Button to Learn About This Program"
        '
        'DartBoardPictureBox
        '
        Me.DartBoardPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DartBoardPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DartBoardPictureBox.Location = New System.Drawing.Point(16, 33)
        Me.DartBoardPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DartBoardPictureBox.Name = "DartBoardPictureBox"
        Me.DartBoardPictureBox.Size = New System.Drawing.Size(1307, 598)
        Me.DartBoardPictureBox.TabIndex = 7
        Me.DartBoardPictureBox.TabStop = False
        '
        'GameThrowLabel
        '
        Me.GameThrowLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GameThrowLabel.AutoSize = True
        Me.GameThrowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameThrowLabel.Location = New System.Drawing.Point(684, 640)
        Me.GameThrowLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameThrowLabel.Name = "GameThrowLabel"
        Me.GameThrowLabel.Size = New System.Drawing.Size(141, 25)
        Me.GameThrowLabel.TabIndex = 9
        Me.GameThrowLabel.Text = "Game Throws:"
        '
        'GameThrowsCounterLabel
        '
        Me.GameThrowsCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GameThrowsCounterLabel.AutoSize = True
        Me.GameThrowsCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameThrowsCounterLabel.Location = New System.Drawing.Point(654, 678)
        Me.GameThrowsCounterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameThrowsCounterLabel.Name = "GameThrowsCounterLabel"
        Me.GameThrowsCounterLabel.Size = New System.Drawing.Size(170, 25)
        Me.GameThrowsCounterLabel.TabIndex = 10
        Me.GameThrowsCounterLabel.Text = "(X,Y)  (X,Y)  (X,Y)"
        Me.GameThrowsCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(383, 18)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(36, 17)
        Me.testLabel.TabIndex = 11
        Me.testLabel.Text = "Test"
        '
        'Dart_board_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 716)
        Me.Controls.Add(Me.testLabel)
        Me.Controls.Add(Me.GameThrowsCounterLabel)
        Me.Controls.Add(Me.GameThrowLabel)
        Me.Controls.Add(Me.ResetGameButton)
        Me.Controls.Add(Me.DartBoardPictureBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.NumberOfThrowLabel)
        Me.Controls.Add(Me.OutOfLabel)
        Me.Controls.Add(Me.ThrowsLabel)
        Me.Controls.Add(Me.ThrowDartButton)
        Me.Controls.Add(Me.OptionsMenuStrip)
        Me.MainMenuStrip = Me.OptionsMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1357, 300)
        Me.Name = "Dart_board_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dart Board"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.OptionsMenuStrip.ResumeLayout(False)
        Me.OptionsMenuStrip.PerformLayout()
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThrowDartButton As Button
    Friend WithEvents DartBoardToolTip As ToolTip
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
    Friend WithEvents DartBoardPictureBox As PictureBox
    Friend WithEvents ResetGameButton As Button
    Friend WithEvents GameThrowLabel As Label
    Friend WithEvents GameThrowsCounterLabel As Label
    Friend WithEvents testLabel As Label
End Class
