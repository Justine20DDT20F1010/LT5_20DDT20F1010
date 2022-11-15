<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insert
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
        Me.Tb_InsertText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        'Tb_InsertText
        '
        Me.Tb_InsertText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_InsertText.Location = New System.Drawing.Point(102, 98)
        Me.Tb_InsertText.Name = "Tb_InsertText"
        Me.Tb_InsertText.Size = New System.Drawing.Size(175, 26)
        Me.Tb_InsertText.TabIndex = 25
        Me.Tb_InsertText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Insert Text:"
        '
        'Tb_Index
        '
        Me.Tb_Index.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Index.Location = New System.Drawing.Point(102, 130)
        Me.Tb_Index.Name = "Tb_Index"
        Me.Tb_Index.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Index.TabIndex = 23
        Me.Tb_Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Index:"
        '
        'Btn_GetOutput
        '
        Me.Btn_GetOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GetOutput.Location = New System.Drawing.Point(112, 210)
        Me.Btn_GetOutput.Name = "Btn_GetOutput"
        Me.Btn_GetOutput.Size = New System.Drawing.Size(122, 31)
        Me.Btn_GetOutput.TabIndex = 21
        Me.Btn_GetOutput.Text = "Get Output"
        Me.Btn_GetOutput.UseVisualStyleBackColor = True
        '
        'Tb_Output
        '
        Me.Tb_Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Output.Location = New System.Drawing.Point(102, 166)
        Me.Tb_Output.Name = "Tb_Output"
        Me.Tb_Output.ReadOnly = True
        Me.Tb_Output.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Output.TabIndex = 20
        Me.Tb_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Input
        '
        Me.Tb_Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Input.Location = New System.Drawing.Point(102, 66)
        Me.Tb_Input.Name = "Tb_Input"
        Me.Tb_Input.Size = New System.Drawing.Size(175, 26)
        Me.Tb_Input.TabIndex = 19
        Me.Tb_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Output: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Input: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert()"
        '
        'Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 261)
        Me.Controls.Add(Me.Tb_InsertText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tb_Index)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_GetOutput)
        Me.Controls.Add(Me.Tb_Output)
        Me.Controls.Add(Me.Tb_Input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Insert"
        Me.Text = "Insert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb_InsertText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tb_Index As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_GetOutput As Button
    Friend WithEvents Tb_Output As TextBox
    Friend WithEvents Tb_Input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
