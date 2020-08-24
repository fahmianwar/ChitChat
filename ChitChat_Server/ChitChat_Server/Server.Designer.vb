<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kotak_Obrolan_Broadcast = New System.Windows.Forms.TextBox()
        Me.Kotak_Obrolan_Broadcast_Baru = New System.Windows.Forms.TextBox()
        Me.Kotak_Port = New System.Windows.Forms.TextBox()
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru = New System.Windows.Forms.Button()
        Me.Tombol_Mulai_Server = New System.Windows.Forms.Button()
        Me.Data_Klien = New System.Windows.Forms.GroupBox()
        Me.Data_Klien_Aktif = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Data_Klien.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.SendToolStripMenuItem})
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Enter Message..."
        '
        'SendToolStripMenuItem
        '
        Me.SendToolStripMenuItem.Name = "SendToolStripMenuItem"
        Me.SendToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SendToolStripMenuItem.Text = "Send!"
        '
        'Kotak_Obrolan_Broadcast
        '
        Me.Kotak_Obrolan_Broadcast.Location = New System.Drawing.Point(12, 39)
        Me.Kotak_Obrolan_Broadcast.Multiline = True
        Me.Kotak_Obrolan_Broadcast.Name = "Kotak_Obrolan_Broadcast"
        Me.Kotak_Obrolan_Broadcast.Size = New System.Drawing.Size(222, 194)
        Me.Kotak_Obrolan_Broadcast.TabIndex = 11
        '
        'Kotak_Obrolan_Broadcast_Baru
        '
        Me.Kotak_Obrolan_Broadcast_Baru.Location = New System.Drawing.Point(93, 253)
        Me.Kotak_Obrolan_Broadcast_Baru.Name = "Kotak_Obrolan_Broadcast_Baru"
        Me.Kotak_Obrolan_Broadcast_Baru.Size = New System.Drawing.Size(141, 20)
        Me.Kotak_Obrolan_Broadcast_Baru.TabIndex = 10
        '
        'Kotak_Port
        '
        Me.Kotak_Port.Location = New System.Drawing.Point(93, 12)
        Me.Kotak_Port.Name = "Kotak_Port"
        Me.Kotak_Port.Size = New System.Drawing.Size(141, 20)
        Me.Kotak_Port.TabIndex = 9
        Me.Kotak_Port.Text = "3460"
        '
        'Tombol_Kirim_Obrolan_Broadcast_Baru
        '
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Location = New System.Drawing.Point(12, 250)
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Name = "Tombol_Kirim_Obrolan_Broadcast_Baru"
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.TabIndex = 8
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.Text = "Send"
        Me.Tombol_Kirim_Obrolan_Broadcast_Baru.UseVisualStyleBackColor = True
        '
        'Tombol_Mulai_Server
        '
        Me.Tombol_Mulai_Server.Location = New System.Drawing.Point(12, 10)
        Me.Tombol_Mulai_Server.Name = "Tombol_Mulai_Server"
        Me.Tombol_Mulai_Server.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Mulai_Server.TabIndex = 7
        Me.Tombol_Mulai_Server.Text = "Listen"
        Me.Tombol_Mulai_Server.UseVisualStyleBackColor = True
        '
        'Data_Klien
        '
        Me.Data_Klien.Controls.Add(Me.Data_Klien_Aktif)
        Me.Data_Klien.Location = New System.Drawing.Point(258, 17)
        Me.Data_Klien.Name = "Data_Klien"
        Me.Data_Klien.Size = New System.Drawing.Size(257, 215)
        Me.Data_Klien.TabIndex = 12
        Me.Data_Klien.TabStop = False
        Me.Data_Klien.Text = "Data Klien yang Aktif"
        '
        'Data_Klien_Aktif
        '
        Me.Data_Klien_Aktif.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Data_Klien_Aktif.FormattingEnabled = True
        Me.Data_Klien_Aktif.Location = New System.Drawing.Point(6, 15)
        Me.Data_Klien_Aktif.MultiColumn = True
        Me.Data_Klien_Aktif.Name = "Data_Klien_Aktif"
        Me.Data_Klien_Aktif.Size = New System.Drawing.Size(245, 186)
        Me.Data_Klien_Aktif.TabIndex = 13
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 283)
        Me.Controls.Add(Me.Data_Klien)
        Me.Controls.Add(Me.Kotak_Obrolan_Broadcast)
        Me.Controls.Add(Me.Kotak_Obrolan_Broadcast_Baru)
        Me.Controls.Add(Me.Kotak_Port)
        Me.Controls.Add(Me.Tombol_Kirim_Obrolan_Broadcast_Baru)
        Me.Controls.Add(Me.Tombol_Mulai_Server)
        Me.Name = "Server"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Data_Klien.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Kotak_Obrolan_Broadcast As TextBox
    Friend WithEvents Kotak_Obrolan_Broadcast_Baru As TextBox
    Friend WithEvents Kotak_Port As TextBox
    Friend WithEvents Tombol_Kirim_Obrolan_Broadcast_Baru As Button
    Friend WithEvents Tombol_Mulai_Server As Button
    Friend WithEvents Data_Klien As GroupBox
    Friend WithEvents Data_Klien_Aktif As ListBox
End Class
