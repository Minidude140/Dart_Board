Option Explicit On
Option Strict On
'Zachary Christensen
'Spring 2024
'Dart Board VB Review
'

Imports System.ComponentModel

'To DO
'[*]Close application functions
'[*]Draw Quadrants
'[]Random number saved x, y 
'[]Draw Target on x,y coordinates
'[*]Count throws
'[]Save previous throws
'[]Export previous throws
Public Class Dart_board_form
    Dim Numberofthrows As Integer

    'Custom Methods

    ''' <summary>
    ''' Draws a Cross in the center of the Dart Board to create quadrants
    ''' </summary>
    Sub DrawQuadrants()
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

    'Event Handlers
    Private Sub Dart_board_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        DrawQuadrants()
        Numberofthrows = 0
        UpdateNumberOfThrows(Numberofthrows)

    End Sub
    Private Sub ThrowDartButton_Click(sender As Object, e As EventArgs) Handles ThrowDartButton.Click,
                                                                                ThrowDartToolStripMenuItem.Click
        'Throw Random Dart Location here


        'Check if number of throws is over the max and update label
        If Numberofthrows < 3 Then
            Numberofthrows += 1
            UpdateNumberOfThrows(Numberofthrows)
        Else
        End If

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click,
                                                                           QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
