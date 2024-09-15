'Zachary Christensen
'Spring 2024
'Dart Board VB Review
'https://github.com/Minidude140/Dart_Board

'To DO
'[*]Close application functions
'[*]Draw Quadrants
'[*]Random number saved x, y 
'[*]Draw Target on x,y coordinates
'[*]Count throws
'[*] Add Reset Game Function
'[*]Add player prompt when out of turns (kinda Broken)
'[*]Save previous throws
'[*]Fix tool tips
'[*]Fix tab stops
'[*]Fix Drawing quadrants on the picture box at the form load
'[*]Export previous throws
'[*]Load old game
'[]Check user selected file is ok

Option Explicit On
Option Strict On

Imports System.Threading

Public Class Dart_board_form
    Dim numberOfThrows As Integer
    Dim currentX As Integer
    Dim currentY As Integer
    Dim throwMessage As String
    Dim totalThrows(,) As Integer = {{0, 0}, {0, 0}, {0, 0}}
    Dim importedThrows As New List(Of String)


    'Custom Methods

    ''' <summary>
    ''' Refreshes Dart Board and Draws a Cross in the center of the Dart Board to create quadrants
    ''' </summary>
    Sub DrawQuadrants()
        DartBoardPictureBox.Refresh()
        Dim Xmax As Integer = CInt(DartBoardPictureBox.Width)
        Dim Ymax As Integer = CInt(DartBoardPictureBox.Height)
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        'initialize pen as color black and pen size
        Dim pen As New Pen(Color.Black, 5)
        'Draw Vertical Line(x,y) to (x,y); (0,0) in upper left hand corner
        g.DrawLine(pen, CInt(Xmax / 2), 0, CInt(Xmax / 2), Ymax)
        'Draw Horizontal Line
        g.DrawLine(pen, 0, CInt(Ymax / 2), Xmax, CInt(Ymax / 2))
        'dispose of the pen and graphics object to clear memory
        pen.Dispose()
        g.Dispose()
    End Sub

    ''' <summary>
    ''' Updates the label for number of throws to the corresponding throw count
    ''' </summary>
    ''' <param name="Throwcount"></param>
    Sub UpdateNumberOfThrows(Throwcount As Integer)
        Select Case Throwcount
            'Update Form label to corresponding case
            Case = 0
                NumberOfThrowLabel.Text = " "
            Case = 1
                NumberOfThrowLabel.Text = "I"
            Case = 2
                NumberOfThrowLabel.Text = "I I"
            Case = 3
                NumberOfThrowLabel.Text = "I I I"
            Case Else
                NumberOfThrowLabel.Text = " "
        End Select
    End Sub

    ''' <summary>
    ''' Draws a target on the given X and Y locations
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    Sub DrawTarget(X As Integer, Y As Integer)
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        'initialize pen as color REd and pen size
        Dim pen As New Pen(Color.Red, 6)
        'Draw Center Dot
        g.DrawEllipse(pen, (X - 3), (Y - 3), 6, 6)
        'Draw Circle Around Dot
        g.DrawEllipse(pen, (X - 15), (Y - 15), 30, 30)
    End Sub

    ''' <summary>
    ''' Sets Current X, Y to a random number within the Dart board picture box
    ''' </summary>
    Sub RandomXY()
        Dim Xmax As Integer = (DartBoardPictureBox.Width - 30)
        Dim Ymax As Integer = (DartBoardPictureBox.Height - 30)
        Randomize()
        currentX = CInt((Rnd() * Xmax - 1) + 15)
        currentY = CInt((Rnd() * Ymax - 1) + 15)
    End Sub

    ''' <summary>
    ''' Concatenates throwMessage with latest throw X and Y values.  Updates label
    ''' </summary>
    Sub UpdateGameThrowsLabel()
        'Add current throw with new throw X and Y
        throwMessage = throwMessage + "(" + CStr(currentX) + "," + CStr(currentY) + ") "
        'Update Label with new throw
        GameThrowsCounterLabel.Text = throwMessage
    End Sub

    ''' <summary>
    ''' Saves the current throw into an array called "totalThrows"
    ''' </summary>
    Sub SaveThrow()
        totalThrows(numberOfThrows, 0) = currentX
        totalThrows(numberOfThrows, 1) = currentY
    End Sub

    ''' <summary>
    ''' Draws a Target on Random Coordinates, Increments throws, Saves Throw in array, and updates labels
    ''' </summary>
    Sub ThrowDart()
        'Create Random X, Y
        RandomXY()
        'Draw current random X, Y
        DrawTarget(currentX, currentY)
        'Save current throw to array
        SaveThrow()
        'increment the number of throws and Update label
        numberOfThrows += 1
        UpdateNumberOfThrows(numberOfThrows)
        'Update current throws label
        UpdateGameThrowsLabel()
    End Sub

    ''' <summary>
    ''' Clears Board, Resets Number of Throws, Updates Labels, Clears Array
    ''' </summary>
    Sub ResetGame()
        'ReDraw the cross quadrants and erase board
        DrawQuadrants()
        'Update number of throws count and label
        numberOfThrows = 0
        UpdateNumberOfThrows(numberOfThrows)
        'Reset total throw Array
        totalThrows = {{0, 0}, {0, 0}, {0, 0}}
        'Reset Game throws totals
        throwMessage = ""
        'Reset Game throws label
        GameThrowsCounterLabel.Text = "(X,Y) (X,Y) (X,Y)"
    End Sub

    ''' <summary>
    ''' Saves Data of totalThrows Array into a new text file prompts user of file name
    ''' </summary>
    Sub ExportGameScores()
        'Name file and open
        Dim fileName As String = "..\..\..\Game" & DateTime.Now.ToString("yyyMMddhhmmssmm") & ".txt"
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Append)
        'Write scores to file
        For I = 0 To 2
            Write(fileNumber, totalThrows(I, 0))
            Write(fileNumber, totalThrows(I, 1))
            WriteLine(fileNumber)
        Next
        FileClose(fileNumber)
        'remove the . in the fileName (except the .txt)
        fileName = Replace(fileName, ".", "", 1, 6)
        'Remove the \ in the file name
        fileName = Replace(fileName, "\", "", 1, -1)
        'Prompt user that the game has been saved
        MsgBox("Your Game Has Been Saved as: " + fileName)
    End Sub

    ''' <summary>
    ''' OPens File Dialog for user to select previous Game save and imports data into list
    ''' </summary>
    Sub ImportGame()
        Dim currentRecord As String
        Dim fileNumber As Integer = FreeFile()

        Try
            'Opens a file dialog for the user to select previous game
            'OpenFileDialog1.InitialDirectory("..\..\..\")
            OpenFileDialog1.Filter = "text files (*.txt) |*.txt"
            OpenFileDialog1.ShowDialog()
            Dim fileName As String = OpenFileDialog1.FileName
            'open user selected file and load records into imported throws list
            FileOpen(FreeFile, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord)
                'check if the current record is blank
                If currentRecord = "" Then
                    'do not add to list
                Else
                    'add record to list
                    importedThrows.Add(currentRecord)
                End If
            Loop
            FileClose(fileNumber)
            'test imported throws to see if valid  if not raise an exception
            Select Case importedThrows.Count
            'Check if 
                Case < 6
                    Throw New Exception()
                Case > 6

            End Select

            'Redraw loaded game throws
            LoadGame()
            'Show user the inputs score
            PreviousGameMessage()
        Catch ex As Exception
            MsgBox("Sorry We Could Not Find or Read Your Selected File")
        End Try
    End Sub

    ''' <summary>
    ''' Redraws Dart throws from imported list values
    ''' </summary>
    Sub LoadGame()
        'Clears Dart Board and Redraws Quadrants
        DartBoardPictureBox.Refresh()
        DrawQuadrants()
        'Redraw Previous 3 throws
        DrawTarget(CInt(importedThrows(0)), CInt(importedThrows(1)))
        DrawTarget(CInt(importedThrows(2)), CInt(importedThrows(3)))
        DrawTarget(CInt(importedThrows(4)), CInt(importedThrows(5)))
        'Update number of throws
        numberOfThrows = 3
        UpdateNumberOfThrows(numberOfThrows)
    End Sub

    ''' <summary>
    ''' Writes a message box to the user about the imported game
    ''' </summary>
    Sub PreviousGameMessage()
        Dim userMessage As String
        userMessage = "The Previous Game Has Been Loaded.  The Throws of This Game Were: ("
        'Add First Throw
        userMessage = userMessage + importedThrows(0) + "," + importedThrows(1) + ") ("
        'Add Second Throw
        userMessage = userMessage + importedThrows(2) + "," + importedThrows(3) + ") ("
        'Add Final Throw
        userMessage = userMessage + importedThrows(4) + "," + importedThrows(5) + ") "
        userMessage = userMessage + "These Throws Will Be Redrawn on Screen Now."
        MsgBox(userMessage)
    End Sub

    Function UserInputValidation() As Boolean

    End Function

    'Event Handlers
    Private Sub Dart_board_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetGame()
    End Sub

    Private Sub ThrowDartButton_Click(sender As Object, e As EventArgs) Handles ThrowDartButton.Click,
                                                                                ThrowDartToolStripMenuItem.Click
        'Check if number of throws is over the max and update label
        If numberOfThrows < 3 Then
            ThrowDart()
        Else 'The number of throws exceeds the number of darts given
            'OutOfDartsPrompt.Show()
            'System.Threading.Thread.Sleep(1000)
            'OutOfDartsPrompt.Close()
            MsgBox("You're Out of Darts!  Please Reset the Game")
        End If

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click,
                                                                           QuitToolStripMenuItem.Click
        'Quit application
        Me.Close()
    End Sub

    Private Sub ResetGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetGameToolStripMenuItem.Click,
                                                                                           ResetGameButton.Click
        ResetGame()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show about this program form
        AboutForm.Show()
    End Sub

    Private Sub spacepress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ThrowDartButton.PerformClick()
    End Sub

    Private Sub Dart_board_form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        DrawQuadrants()
    End Sub

    Private Sub LoadDealyTimer_Tick(sender As Object, e As EventArgs) Handles LoadDealyTimer.Tick
        LoadDealyTimer.Enabled = False
        DrawQuadrants()
    End Sub

    Private Sub ImportPreviousSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportPreviousSaveToolStripMenuItem.Click

        'Load File throw saves into list (including user input validation)
        ImportGame()

        'Clear list for next import
        importedThrows.Clear()
    End Sub

    Private Sub ExportGameButton_Click(sender As Object, e As EventArgs) Handles ExportGameButton.Click, ExportCurrentThrowsToolStripMenuItem.Click
        ExportGameScores()
    End Sub
End Class
