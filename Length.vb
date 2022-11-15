'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class Length
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        Dim input, output As String

        input = Tb_Input.Text
        output = input.Length

        Tb_Output.Text = output
    End Sub


End Class