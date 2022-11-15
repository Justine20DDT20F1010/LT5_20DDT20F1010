<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remove
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tb_Index = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_GetOutput = New System.Windows.Forms.Button()
        Me.Tb_Output = New System.Windows.Forms.TextBox()
        Me.Tb_Input = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tb_Index
        '
        Me.Tb_Index.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Index.Location = New System.Drawing.Point(91, 117)
        Me.Tb_Index.Name = "Tb_Index"
        Me.Tb_Index.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Index.TabIndex = 21
        Me.Tb_Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Index:"
        '
        'Btn_GetOutput
        '
        Me.Btn_GetOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GetOutput.Location = New System.Drawing.Point(101, 193)
        Me.Btn_GetOutput.Name = "Btn_GetOutput"
        Me.Btn_GetOutput.Size = New System.Drawing.Size(122, 31)
        Me.Btn_GetOutput.TabIndex = 19
        Me.Btn_GetOutput.Text = "Get Output"
        Me.Btn_GetOutput.UseVisualStyleBackColor = True
        '
        'Tb_Output
        '
        Me.Tb_Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Output.Location = New System.Drawing.Point(91, 149)
        Me.Tb_Output.Name = "Tb_Output"
        Me.Tb_Output.ReadOnly = True
        Me.Tb_Output.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Output.TabIndex = 18
        Me.Tb_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Input
        '
        Me.Tb_Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Input.Location = New System.Drawing.Point(91, 85)
        Me.Tb_Input.Name = "Tb_Input"
        Me.Tb_Input.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Input.TabIndex = 17
        Me.Tb_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Output: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Input: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Remove()"
        '
        'Remove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Tb_Index)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_GetOutput)
        Me.Controls.Add(Me.Tb_Output)
        Me.Controls.Add(Me.Tb_Input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Remove"
        Me.Text = "Remove"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb_Index As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_GetOutput As Button
    Friend WithEvents Tb_Output As TextBox
    Friend WithEvents Tb_Input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
