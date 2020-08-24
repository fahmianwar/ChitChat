Imports System.Net
Imports System.Text
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Public Class Klien
    Dim t As New TcpClient

    Sub connect(ByVal ip As String, ByVal port As Integer)

        Try
            t.Connect(ip, port) 'Mencoba mengubungkan dengan server tersebut
            If t.Connected Then 'jika tersambung, menjalankan prosedur seterusnya
                t.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf doread, Nothing)
                login() 'Mengirimkan data login
            End If
        Catch ex As Exception
            System.Threading.Thread.Sleep(10000) 'Jika error dalam waktu 10 detik
            connect(ip, port) 'Mencoba mengubungkan dengan server kembali
        End Try
    End Sub
    Sub login()
        senddata("LOGIN|") 'Mengirimkan data login
    End Sub
    Sub senddata(ByVal message As String)
        Dim sw As New StreamWriter(t.GetStream) 'declare a new streamwriter
        sw.WriteLine(message) 'write the message
        sw.Flush()

    End Sub
    Sub messagerecieved(ByVal message As String)
        Dim msg() As String = message.Split("|") ' if a message is recieved, split it to process it
        'Kotak_Obrolan_Broadcast.Text &= "Server: " & message & vbNewLine
        Dim obrolan As String = msg(1)
        'Kotak_Obrolan_Broadcast.Items.Add("Kata-kata")

        Select Case msg(0) 'process it by the first element in the split array
            Case "CHAT"
                'MsgBox(msg(1))
                Me.Kotak_Obrolan_Broadcast.Items.Add("Coba")
        End Select

    End Sub
    Sub doread(ByVal ar As IAsyncResult)
        Try
            'connect(Kotak_Alamat_IP.Text, Kotak_Port.Text)
            t.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf doread, Nothing) 'continue to read
            Dim sr As New StreamReader(t.GetStream) 'declare a new streamreader to read fromt eh network stream
            Dim msg As String = sr.ReadLine() 'the msg is what is bing  
            messagerecieved(msg) 'start processing the message

            'MsgBox(msg)

        Catch ex As Exception
            System.Threading.Thread.Sleep(10000) 'if an error occurs, wait for 10 seconds
            connect(Kotak_Alamat_IP.Text, Kotak_Port.Text) 'try to reconnect
        End Try
    End Sub
    Private Sub Tombol_Koneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Koneksi.Click
        connect(Kotak_Alamat_IP.Text, Kotak_Port.Text) 'connect Kotak_Alamat_IP as ip and Kotak_Port as port
    End Sub

    Private Sub Tombol_Kirim_Obrolan_Broadcast_Baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Kirim_Obrolan_Broadcast_Baru.Click
        senddata("CHAT|" & Kotak_Obrolan_Broadcast_Baru.Text) 'send the data with CHAT| as header
        Kotak_Obrolan_Broadcast.Items.Add("You: " & " " & Kotak_Obrolan_Broadcast_Baru.Text.Split("|")(0) & vbNewLine)
    End Sub
End Class
