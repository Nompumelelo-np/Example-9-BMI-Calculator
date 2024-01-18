Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Weight, Height, BMI As Double
        Weight = Val(TextBox1.Text)
        Height = Val(TextBox2.Text)
        BMI = Weight / (Height) ^ 2
        TextBox3.Text = BMI


        If BMI < 18.5 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= BMI And BMI < 24.9 Then
            TextBox4.Text = "You are normal"
        Else
            TextBox4.Text = "You are overweight"
        End If




    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
