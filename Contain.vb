'Justine Nanggai
'LAB TASK 5
'20DDT20F1010

Public Class Contain
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        'declare variable
        Dim input, search, output As String

        ' input =input textbox
        ' search =input textbox
        input = Tb_Input.Text
        search = Tb_Search.Text

        output = CStr(input.Contains(search))

        Tb_Output.Text = output
    End Sub
End Class