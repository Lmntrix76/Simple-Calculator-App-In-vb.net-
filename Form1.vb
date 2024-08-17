Public Class Form1
    Dim intNumber1 As Integer
    Dim intNumber2 As Integer
    Dim intAnswer As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables. We only going to use Integers because we are dealing with whole numbers.
        'Convert input numbers to Integer and add to variables.
        intNumber1 = CInt(txtNumber1.Text)
        intNumber2 = CInt(txtNumber2.Text)

        'Calculate answer and place variable
        intAnswer = intNumber1 + intNumber2

        'Place answer in Label property
        'Use Concentration to make the answer more readable
        lblAnswer.Text = "The Answer is " & intAnswer

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblAnswer.Text = ""
    End Sub
End Class
