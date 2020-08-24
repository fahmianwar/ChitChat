<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Klien
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
        Me.Kotak_Obrolan_Broadcast_Baru = New System.Windows.Forms.TextBox()
        Me.Kotak_Port = New System.Windows.Forms.TextBox()
        Me.Kotak_Alamat_IP = New System.Windows.Forms.TextBox()
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru = New System.Windows.Forms.Button()
        Me.Tombol_Koneksi = New System.Windows.Forms.Button()
        Me.Tombol_Obrolan_Personal = New System.Windows.Forms.Button()
        Me.Kotak_Obrolan_Broadcast = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Kotak_Obrolan_Broadcast_Baru
        '
        Me.Kotak_Obrolan_Broadcast_Baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kotak_Obrolan_Broadcast_Baru.Location = New System.Drawing.Point(12, 229)
        Me.Kotak_Obrolan_Broadcast_Baru.Name = "Kotak_Obrolan_Broadcast_Baru"
        Me.Kotak_Obrolan_Broadcast_Baru.Size = New System.Drawing.Size(177, 26)
        Me.Kotak_Obrolan_Broadcast_Baru.TabIndex = 10
        '
        'Kotak_Port
        '
        Me.Kotak_Port.Location = New System.Drawing.Point(138, 13)
        Me.Kotak_Port.Name = "Kotak_Port"
        Me.Kotak_Port.Size = New System.Drawing.Size(51, 20)
        Me.Kotak_Port.TabIndex = 9
        Me.Kotak_Port.Text = "3460"
        '
        'Kotak_Alamat_IP
        '
        Me.Kotak_Alamat_IP.Location = New System.Drawing.Point(12, 12)
        Me.Kotak_Alamat_IP.Name = "Kotak_Alamat_IP"
        Me.Kotak_Alamat_IP.Size = New System.Drawing.Size(120, 20)
        Me.Kotak_Alamat_IP.TabIndex = 8
        Me.Kotak_Alamat_IP.Text = "127.0.0.1"
        '
        'Tombol_Kirim_Obrolan_Broadcast_Baru
        '
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Location = New System.Drawing.Point(204, 229)
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Name = "Tombol_Kirim_Obrolan_Broadcast_Baru"
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Size = New System.Drawing.Size(75, 26)
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.TabIndex = 7
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Text = "Kirim"
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.UseVisualStyleBackColor = True
        '
        'Tombol_Koneksi
        '
        Me.Tombol_Koneksi.Location = New System.Drawing.Point(204, 13)
        Me.Tombol_Koneksi.Name = "Tombol_Koneksi"
        Me.Tombol_Koneksi.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Koneksi.TabIndex = 6
        Me.Tombol_Koneksi.Text = "Hubungkan"
        Me.Tombol_Koneksi.UseVisualStyleBackColor = True
        '
        'Tombol_Obrolan_Personal
        '
        Me.Tombol_Obrolan_Personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tombol_Obrolan_Personal.Location = New System.Drawing.Point(306, 229)
        Me.Tombol_Obrolan_Personal.Name = "Tombol_Obrolan_Personal"
        Me.Tombol_Obrolan_Personal.Size = New System.Drawing.Size(144, 26)
        Me.Tombol_Obrolan_Personal.TabIndex = 13
        Me.Tombol_Obrolan_Personal.Text = "Obrolan Personal"
        Me.Tombol_Obrolan_Personal.UseVisualStyleBackColor = True
        '
        'Kotak_Obrolan_Broadcast
        '
        Me.Kotak_Obrolan_Broadcast.Location = New System.Drawing.Point(12, 55)
        Me.Kotak_Obrolan_Broadcast.Name = "Kotak_Obrolan_Broadcast"
        Me.Kotak_Obrolan_Broadcast.Size = New System.Drawing.Size(177, 158)
        Me.Kotak_Obrolan_Broadcast.TabIndex = 14
        Me.Kotak_Obrolan_Broadcast.UseCompatibleStateImageBehavior = False
        '
        'Klien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 277)
        Me.Controls.Add(Me.Kotak_Obrolan_Broadcast)
        Me.Controls.Add(Me.Tombol_Obrolan_Personal)
        Me.Controls.Add(Me.Tombol_Kirim_Obrolan_Broadcast_Baru)
        Me.Controls.Add(Me.Kotak_Obrolan_Broadcast_Baru)
        Me.Controls.Add(Me.Kotak_Port)
        Me.Controls.Add(Me.Kotak_Alamat_IP)
        Me.Controls.Add(Me.Tombol_Koneksi)
        Me.Name = "Klien"
        Me.Text = "ChitChat - Klien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kotak_Obrolan_Broadcast_Baru As TextBox
    Friend WithEvents Kotak_Port As TextBox
    Friend WithEvents Kotak_Alamat_IP As TextBox
    Friend WithEvents Tombol_Kirim_Obrolan_Broadcast_Baru As Button
    Friend WithEvents Tombol_Koneksi As Button
    Friend WithEvents Tombol_Obrolan_Personal As Button
    Friend WithEvents Kotak_Obrolan_Broadcast As ListView
End Class
