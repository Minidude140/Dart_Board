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
'[1/2]Add player prompt when out of turns (kinda Broken)
'[*]Save previous throws
'[*]Fix tool tips
'[*]Fix tab stops
'[]Fix Drawing quadrants on the picture box at the form load
'[]Export previous throws
'[]Load old game

'**TO ASK TEACH**
'-Why can't I see my label on my "out of darts" prompt? Better way to pop-up prompt?
'-Why won't my quadrants draw on form load? why can't I dim my Xmax and Ymax globally? (I think it's related to when the picture box is drawn)

Option Explicit On
Option Strict On

Imports System.Threading

Public Class Dart_board_form
    Dim numberOfThrows As Integer
    Dim currentX As Integer
    Dim currentY As Integer
    Dim throwMessage As String
    Dim totalThrows(,) As Integer = {{0, 0}, {0, 0}, {0, 0}}
    Dim fileName As String = "...\...\Game" + CStr(Date.Now.Date) + CStr(Date.Now.Hour) + CStr(Date.Now.Date.Minute) + CStr(Date.Now.Date.Second) + ".txt"


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
        testLabel.Text = fileName
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

    Sub ExportGameScores()
        Dim fileName As String = "..\..\..\Game" '+ CStr(Date.Now.Date) + CStr(Date.Now.Hour) + CStr(Date.Now.Date.Minute) + CStr(Date.Now.Date.Second) + ".txt"
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Append)
        Write(fileNumber, "This worked?")
        FileClose(fileNumber)
    End Sub

    'Event Handlers
    Private Sub Dart_board_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MsgBox("Welcome to The Simulated Game of Darts.  Let's See How You Throw.")
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
        ExportGameScores()
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
End Class
