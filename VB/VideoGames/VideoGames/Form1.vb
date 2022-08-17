Public Class Form1
    Private Sub UntilDawnButton_Click(sender As Object, e As EventArgs) Handles UntilDawnButton.Click
        displayPictureBox.Image = UntilDawnpicturebox.Image
        Namelabel.Text = "Until Dawn"
        genrelabel.Text = "Horror"
        ReleasedLabel.Text = "2015"
        DesignerLabel.Text = "Supermassive Games"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Namelabel.Click
        Namelabel.Text = "Until Dawn"
        genrelabel.Text = "Horror"
        ReleasedLabel.Text = "2015"
        DesignerLabel.Text = "Supermassive Games"
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Uncharted_Click(sender As Object, e As EventArgs) Handles Uncharted.Click
        displayPictureBox.Image = PictureBoxuncharted.Image
        Namelabel.Text = "Uncharted 4"
        genrelabel.Text = "Action/Adventure"
        ReleasedLabel.Text = "2016"
        DesignerLabel.Text = "Naughty Dog"

    End Sub

    Private Sub TLOUbutton_Click(sender As Object, e As EventArgs) Handles TLOUbutton.Click
        displayPictureBox.Image = TLOUpicturebox.Image
        Namelabel.Text = "The Last of Us"
        genrelabel.Text = "Surival Horror/ Action"
        ReleasedLabel.Text = "2011"
        DesignerLabel.Text = "Naughty Dog"
    End Sub

    Private Sub DBHbutton_Click(sender As Object, e As EventArgs) Handles DBHbutton.Click
        displayPictureBox.Image = DBHpicture.Image
        Namelabel.Text = "Detroit Become Human"
        genrelabel.Text = "Action/ Adventure"
        ReleasedLabel.Text = "2018"
        DesignerLabel.Text = "Quantic Dream"
    End Sub

    Private Sub Quarrybutton_Click(sender As Object, e As EventArgs) Handles Quarrybutton.Click
        displayPictureBox.Image = thequarrypicturebox.Image
        Namelabel.Text = "The Quarry"
        genrelabel.Text = "Horror"
        ReleasedLabel.Text = "2022"
        DesignerLabel.Text = "Supermassive Games"
    End Sub
End Class
