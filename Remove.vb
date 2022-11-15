'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class Remove
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        Dim input, output As String
        Dim index As Integer

        input = Tb_Input.Text
        index = Val(Tb_Index.Text)

        output = input.Remove(index)

        Tb_Output.Text = output

    End Sub

    Private Sub Remove_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class