'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class Insert
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        'create a variable
        Dim input, insert, output As String
        Dim index As Integer

        input = Tb_Input.Text
        insert = Tb_InsertText.Text
        index = Val(Tb_Index.Text)
        output = input.Insert(index, insert)

        Tb_Output.Text = output
    End Sub


End Class