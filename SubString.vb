'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class SubString
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        Dim input, output As String
        Dim Start_, End_ As Integer

        input = Tb_Input.Text
        Start_ = Val(Tb_Start.Text)
        End_ = Val(Tb_End.Text)

        output = input.Substring(Start_, End_)

        Tb_Output.Text = output
    End Sub

    Private Sub SubString_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class