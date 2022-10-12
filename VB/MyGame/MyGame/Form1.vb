Public Class Form1
    Const Speed As Integer = 10
    Dim direction As Point
    Dim score As Integer

    'This is where you can handle any collisions in the game
    '
    '  p1 has collided with p2
    '  you can return true to let it go through it
    '  or 
    '  you can return false to not let it go through
    '
    '  you could also do other actions like change directions or add points etc.
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
            score = score + 1
            pointslabel.Text = score
        End If
        'Any picture boxes whose name starts with TARGET cannot move
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
        End If
        'anything that runs into a wall will stop

        Return True
    End Function

    'Handle the keyboard - you could add your own keys if you wanted
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.W
                direction = New Point(0, -Speed)
                moveto(Player, 0, -Speed)
            Case Keys.S
                direction = New Point(0, Speed)
                moveto(Player, 0, Speed)
            Case Keys.A
                direction = New Point(-Speed, 0)
                moveto(Player, -Speed, 0)
            Case Keys.D
                direction = New Point(Speed, 0)
                moveto(Player, Speed, 0)


        End Select
    End Sub

    'You can make items appear using a time
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        AddAt(Target, New Point(345, 70), New Point(0, 0))


    End Sub


    'Don't mess with the code below, this updates the game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGame()
    End Sub





    Dim r As New Random

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        AddAt(Target, New Point(76, 267), New Point(0, 0))
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        AddAt(Target, New Point(240, 61), New Point(0, 0))
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        AddAt(Target, New Point(532, 206), New Point(0, 0))
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        AddAt(Target, New Point(229, 70), New Point(0, 0))

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        AddAt(Target, New Point(67, 61), New Point(0, 0))

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick

        AddAt(Target, New Point(347, 71), New Point(0, 0))
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        AddAt(Target, New Point(532, 125), New Point(0, 0))
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        AddAt(Target, New Point(219, 137), New Point(0, 0))
    End Sub

    Private Sub pointslabel_Click(sender As Object, e As EventArgs) Handles pointslabel.Click


    End Sub
End Class
