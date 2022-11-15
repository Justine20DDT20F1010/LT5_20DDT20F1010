<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Substring = New System.Windows.Forms.Button()
        Me.Btn_Contains = New System.Windows.Forms.Button()
        Me.Btn_IndexOf = New System.Windows.Forms.Button()
        Me.Btn_Insert = New System.Windows.Forms.Button()
        Me.Btn_PadLeft = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Length = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Substring
        '
        Me.Btn_Substring.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Substring.Location = New System.Drawing.Point(24, 222)
        Me.Btn_Substring.Name = "Btn_Substring"
        Me.Btn_Substring.Size = New System.Drawing.Size(118, 30)
        Me.Btn_Substring.TabIndex = 13
        Me.Btn_Substring.Text = "Substring()"
        Me.Btn_Substring.UseVisualStyleBackColor = True
        '
        'Btn_Contains
        '
        Me.Btn_Contains.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Contains.Location = New System.Drawing.Point(24, 186)
        Me.Btn_Contains.Name = "Btn_Contains"
        Me.Btn_Contains.Size = New System.Drawing.Size(118, 30)
        Me.Btn_Contains.TabIndex = 12
        Me.Btn_Contains.Text = "Contains()"
        Me.Btn_Contains.UseVisualStyleBackColor = True
        '
        'Btn_IndexOf
        '
        Me.Btn_IndexOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_IndexOf.Location = New System.Drawing.Point(24, 150)
        Me.Btn_IndexOf.Name = "Btn_IndexOf"
        Me.Btn_IndexOf.Size = New System.Drawing.Size(118, 30)
        Me.Btn_IndexOf.TabIndex = 11
        Me.Btn_IndexOf.Text = "IndexOf()"
        Me.Btn_IndexOf.UseVisualStyleBackColor = True
        '
        'Btn_Insert
        '
        Me.Btn_Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Insert.Location = New System.Drawing.Point(24, 114)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.Size = New System.Drawing.Size(118, 30)
        Me.Btn_Insert.TabIndex = 10
        Me.Btn_Insert.Text = "Insert()"
        Me.Btn_Insert.UseVisualStyleBackColor = True
        '
        'Btn_PadLeft
        '
        Me.Btn_PadLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PadLeft.Location = New System.Drawing.Point(24, 78)
        Me.Btn_PadLeft.Name = "Btn_PadLeft"
        Me.Btn_PadLeft.Size = New System.Drawing.Size(118, 30)
        Me.Btn_PadLeft.TabIndex = 9
        Me.Btn_PadLeft.Text = "PadLeft()"
        Me.Btn_PadLeft.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Remove.Location = New System.Drawing.Point(24, 42)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(118, 30)
        Me.Btn_Remove.TabIndex = 8
        Me.Btn_Remove.Text = "Remove()"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Length
        '
        Me.Btn_Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Length.Location = New System.Drawing.Point(24, 6)
        Me.Btn_Length.Name = "Btn_Length"
        Me.Btn_Length.Size = New System.Drawing.Size(118, 30)
        Me.Btn_Length.TabIndex = 7
        Me.Btn_Length.Text = "Length()"
        Me.Btn_Length.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(167, 261)
        Me.Controls.Add(Me.Btn_Substring)
        Me.Controls.Add(Me.Btn_Contains)
        Me.Controls.Add(Me.Btn_IndexOf)
        Me.Controls.Add(Me.Btn_Insert)
        Me.Controls.Add(Me.Btn_PadLeft)
        Me.Controls.Add(Me.Btn_Remove)
        Me.Controls.Add(Me.Btn_Length)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Substring As Button
    Friend WithEvents Btn_Contains As Button
    Friend WithEvents Btn_IndexOf As Button
    Friend WithEvents Btn_Insert As Button
    Friend WithEvents Btn_PadLeft As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_Length As Button
End Class
