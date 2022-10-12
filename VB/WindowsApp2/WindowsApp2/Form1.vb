Public Class Form1
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
        End If

        'Any BULLET pictures will be removed when they collide
        If p1.Name.ToUpper.StartsWith("BULLET") Then
            '(don't remove them if they collide with the player - like when they start out
            If Not p2.Name.ToUpper.StartsWith("PLAYER") Then 'remove bullets when they collide with others
                Remove(p1)
            End If
        End If

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
            Case Keys.Space
                'Add a bullet in the direction the player is facing
                AddAt(BulletPictureBox2, Player.Location, direction)
End Class
