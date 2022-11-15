'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class IndexOf
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        'create a variable
        Dim input, output As String
        Dim Character As Char

        'input is variable = the name of the text box
        input = Tb_Input.Text
        Character = Tb_Char.Text

        output = input.IndexOf(Character)

        Tb_Output.Text = output
    End Sub

    Private Sub IndexOf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class