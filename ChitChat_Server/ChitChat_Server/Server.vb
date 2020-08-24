Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class Server
    Delegate Sub MonDelegue(ByVal msg As String, ByVal client As ConnectedClient)
    Dim clients As New Hashtable 'new database (hashtable) to hold the clients
    Sub recieved(ByVal msg As String, ByVal client As ConnectedClient)
        Dim message() As String = msg.Split("|") 'make an array with elements of the message recieved
        Select Case message(0) 'process by the first element in the array
            Case "CHAT" 'if it's CHAT
                Kotak_Obrolan_Broadcast.Text &= client.name & " says: " & " " & message(1) & vbNewLine 'add the message to the chatbox
                sendallbutone(message(1), client.name) 'this will update all clients with the new message
                '                                       and it will not send the message to the client it recieved it from :)
            Case "LOGIN" 'A client has connected
                clients.Add(client, client.name) 'add the client to our database (a hashtable)
                Data_Klien_Aktif.Items.Add(client.name) 'add the client to the listbox to display the new user
        End Select

    End Sub
    Sub sendallbutone(ByVal message As String, ByVal exemptclientname As String) 'this sends to all clients except the one specified
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                If entry.Value <> exemptclientname Then 'if the entry IS NOT the exempt client name
                    Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                    cli.senddata(message) 'send the message to it
                End If
            Next
        Catch
        End Try
    End Sub
    Sub sendsingle(ByVal message As String, ByVal clientname As String)
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                If entry.Value = clientname Then 'if the entry is belongs to the client specified
                    Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                    cli.senddata(message) 'send the message to it
                End If
            Next
        Catch
        End Try

    End Sub
    Sub senddata(ByVal message As String) 'this sends a message to all connected clients
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                cli.senddata(message) 'send the message to it
            Next  'go to the next client
        Catch
        End Try

    End Sub
    Sub disconnected(ByVal client As ConnectedClient) 'if a client is disconnected, this is raised
        clients.Remove(client) 'remove the client from the hashtable
        Data_Klien_Aktif.Items.Remove(client.name) 'remove it from our listbox
    End Sub
    Sub listen(ByVal port As Integer)
        Try
            Dim t As New TcpListener(IPAddress.Any, port) 'declare a new tcplistener
            t.Start() 'start the listener
            Do

                Dim client As New ConnectedClient(t.AcceptTcpClient) 'initialize a new connected client
                AddHandler client.gotmessage, AddressOf recieved 'add the handler which will raise an event when a message is recieved
                AddHandler client.disconnected, AddressOf disconnected 'add the handler which will raise an event when the client disconnects

            Loop Until False
        Catch
        End Try

    End Sub
    Private Sub Tombol_Mulai_Server_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Mulai_Server.Click
        Dim listener As New System.Threading.Thread(AddressOf listen) 'initialize a new thread for the listener so our GUI doesn't lag
        listener.IsBackground = True
        listener.Start(Kotak_Port.Text) 'start the listener, with the port specified as a parameter (Kotak_Port is our port textbox)
        Tombol_Mulai_Server.Enabled = False 'disable our button so the user cannot try to make any further listeners which will result in errors
    End Sub

    Private Sub Tombol_Kirim_Obrolan_Broadcast_Baru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Kirim_Obrolan_Broadcast_Baru.Click
        senddata("CHAT|" & Kotak_Obrolan_Broadcast_Baru.Text) 'send teh data with CHAT as the header so the clietn knows to process the message as a chat message
        Kotak_Obrolan_Broadcast.Text &= "You Say: " & " " & Kotak_Obrolan_Broadcast_Baru.Text & vbNewLine 'add a message to the chat textbox showing we have sent a public message
    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click
        Try
            For Each cli As String In Data_Klien_Aktif.SelectedItems 'for each selected client in the selected listbox of our clients
                sendsingle("CHAT|" & ToolStripTextBox1.Text, cli) 'send a message to the only the selected client by providing it's name as a second parameter
                Kotak_Obrolan_Broadcast.Text &= "To " & cli & " :" & " " & ToolStripTextBox1.Text.Split("|")(1) & vbNewLine 'add a message on Kotak_Obrolan_Broadcast which suggests a private message 
            Next 'go to the next selected client if any
        Catch
        End Try

    End Sub

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
