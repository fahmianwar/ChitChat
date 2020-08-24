<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Obrolan_Pribadi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Kotak_Obrolan_Pribadi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Kotak_Obrolan_Pribadi
        '
        Me.Kotak_Obrolan_Pribadi.Location = New System.Drawing.Point(102, 77)
        Me.Kotak_Obrolan_Pribadi.Multiline = True
        Me.Kotak_Obrolan_Pribadi.Name = "Kotak_Obrolan_Pribadi"
        Me.Kotak_Obrolan_Pribadi.Size = New System.Drawing.Size(100, 104)
        Me.Kotak_Obrolan_Pribadi.TabIndex = 0
        '
        'Obrolan_Pribadi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 261)
        Me.Controls.Add(Me.Kotak_Obrolan_Pribadi)
        Me.Name = "Obrolan_Pribadi"
        Me.Text = "Obrolan_Pribadi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kotak_Obrolan_Pribadi As TextBox
End Class
