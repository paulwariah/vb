Public Class frmTempConverter
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles IBLHeader.Click
        End 'close the program
    End Sub

    Private Sub hsbScroller_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbScroller.Scroll
        Dim temp As Integer
        Dim celsius As Single

        temp = hsbScroller.Value
        txtFarenheit.Text = Format(temp, "##0.0")  'Set the value Of the farenheit text box To the scroll bar value
        celsius = (temp - 32) / 9 * 5 'convert the farenheit amount to celsius
        txtCelsius.Text = Format(celsius, "##0.0") 'set the value of the celsius text box as the answer from the equation above 




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
