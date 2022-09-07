Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim opper As String
    Dim mem As Decimal
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click, Buttonperiod.Click
        Displaytextbox.Text = Displaytextbox.Text + sender.text

    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        Displaytextbox.Clear()
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Clear()

        opper = sender.text
    End Sub

    Private Sub Buttonequal_Click(sender As Object, e As EventArgs) Handles Buttonequal.Click

        If opper = "+" Then
            Decimal.TryParse(Displaytextbox.Text, second)
            Displaytextbox.Clear()
            Displaytextbox.Text = first + second
        End If
        If opper = "-" Then
            Decimal.TryParse(Displaytextbox.Text, second)
            Displaytextbox.Clear()
            Displaytextbox.Text = first - second

        End If
        If opper = "x" Then
            Decimal.TryParse(Displaytextbox.Text, second)
            Displaytextbox.Clear()
            Displaytextbox.Text = first * second
        End If
        If opper = "/" Then
            Decimal.TryParse(Displaytextbox.Text, second)
            Displaytextbox.Clear()
            Displaytextbox.Text = first / second

        End If
    End Sub

    Private Sub Buttonsubstract_Click(sender As Object, e As EventArgs) Handles Buttonsubstract.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Clear()

        opper = sender.text
    End Sub

    Private Sub Buttonx_Click(sender As Object, e As EventArgs) Handles Buttonx.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Clear()

        opper = sender.text
    End Sub

    Private Sub Buttondivide_Click(sender As Object, e As EventArgs) Handles Buttondivide.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Clear()

        opper = sender.text
    End Sub

    Private Sub Buttonsquareroot_Click(sender As Object, e As EventArgs) Handles Buttonsquareroot.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Text = Math.Sqrt(first)
    End Sub

    Private Sub Buttonsin_Click(sender As Object, e As EventArgs) Handles Buttonsin.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Text = Math.Sin(first)
    End Sub

    Private Sub Buttontan_Click(sender As Object, e As EventArgs) Handles Buttontan.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Text = Math.Tan(first)
    End Sub

    Private Sub Buttoncosin_Click(sender As Object, e As EventArgs) Handles Buttoncosin.Click
        Decimal.TryParse(Displaytextbox.Text, first)
        Displaytextbox.Text = Math.Cos(first)
    End Sub

    Private Sub Buttonpi_Click(sender As Object, e As EventArgs) Handles Buttonpi.Click
        Displaytextbox.Text = Math.PI
    End Sub

    Private Sub ButtonMplus_Click(sender As Object, e As EventArgs) Handles ButtonMplus.Click
        Decimal.TryParse(Displaytextbox.Text, mem)

    End Sub

    Private Sub ButtonMR_Click(sender As Object, e As EventArgs) Handles ButtonMR.Click
        Displaytextbox.Text = mem
    End Sub
End Class
