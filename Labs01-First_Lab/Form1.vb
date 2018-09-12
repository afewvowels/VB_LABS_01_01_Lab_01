' Project: Lab #001
' Author: Keith Smith
' Descripotion: Display 4 different sayings on screen via buttons

Public Class Form1

    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles Saying1Button.Click
        ' Sets main message label to the adage "Practice makes perfect" on user
        ' clicking button #1
        MainLabel.Text = "Practice makes perfect."
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles Saying2Button.Click
        ' Sets main message label to the adage "Measure twice, cut once" on user
        ' clicking button #2
        MainLabel.Text = "Measure twice, cut once."
    End Sub

    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        ' Sets main message label to the adage "Be prepared" on user
        ' clicking button #3
        MainLabel.Text = "Be prepared."
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        ' Sets main message label to the adage "Deeds not words" on user
        ' clicking button #4
        MainLabel.Text = "Deeds not words."
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Sets main message label to the adage "Printing" on user
        ' clicking "Print" button
        MainLabel.Text = "Printing"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Closes the application on user clicking the "Exit" button
        Me.Close()
    End Sub

End Class
