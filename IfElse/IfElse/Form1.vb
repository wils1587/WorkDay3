Option Strict On

Public Class Form1
    Dim FirstNumber As Double
    Dim SecondNumber As Double


    Private Sub btnFindLarger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindLarger.Click


        FirstNumber = CDbl(txtFirstNum.Text)
        SecondNumber = CDbl(txtSecondNum.Text)

        If FirstNumber > SecondNumber Then
            txtResult.Text = "The larger number is" & txtFirstNum.Text
        ElseIf FirstNumber = SecondNumber Then
            txtResult.Text = "Both numbers are equal"

        Else
            txtResult.Text = "The larger number is" & txtSecondNum.Text


        End If
    End Sub


    Private Sub txtFirstNum_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstNum.TextChanged
        If (IsNumeric(txtFirstNum.Text) = False) Then
            txtFirstNum.Clear()
        End If

    End Sub


    Private Sub txtSecondNum_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecondNum.TextChanged
        If (IsNumeric(txtSecondNum.Text) = False) Then
            txtSecondNum.Clear()
        End If
    End Sub
End Class
