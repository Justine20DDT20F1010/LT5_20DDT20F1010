'Justine Nanggai
'LAB TASK 5
'20DDT20F1010
Public Class PadLeft
    Private Sub Btn_GetOutput_Click(sender As Object, e As EventArgs) Handles Btn_GetOutput.Click
        Dim input, output As String
        Dim Pad As Integer

        input = Tb_Input.Text
        Pad = Val(Tb_Pad.Text)
        output = input.PadLeft(Pad)

        Tb_Output.Text = output
    End Sub

    Private Sub PadLeft_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class