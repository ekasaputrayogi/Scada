Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Public Class Form1

    Dim TCPClients As TcpClient
    Dim TCPClientstream As NetworkStream
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ReceiveMessages(state As Object)
        Dim toReceive(100000) As Byte
        Dim received As String = ""

        Try
            TCPClientstream = TCPClients.GetStream()
            While True
                If TCPClientstream.DataAvailable = True Then
                    TCPClientstream.Read(toReceive, 0, toReceive.Length)
                    received = System.Text.Encoding.ASCII.GetString(toReceive)
                    Dim Data As String = received
                    TextBox1.Text = Data
                    Dim Parsing = Regex.Matches(Data, "[\d]+")
                    TextBox2.Text = Parsing(0).Value
                    TextBox3.Text = Parsing(1).Value
                    TextBox4.Text = Parsing(2).Value
                    TextBox5.Text = Format(Parsing(0).Value * (100 / 4095), "0.00")
                    TextBox6.Text = Format(Parsing(1).Value * (100 / 4095), "0.00")
                    TextBox7.Text = Format(Parsing(2).Value * (100 / 4095), "0.00")

                End If
                '-----------------koordinat- manual----------------------------------

            End While
        Catch ex As Exception
            MsgBox("Failed to Receive : " + ex.Message, MessageBoxButtons.OK, "Attention!!!")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TCPClients = New TcpClient("172.26.0.1", 65432)
            If TCPClients.GetStream.CanRead = True Then
                CheckForIllegalCrossThreadCalls = False
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ReceiveMessages)

            End If
        Catch ex As Exception
            MsgBox("Sorry, Failed to Connect : " + ex.Message, MessageBoxButtons.OK, "Attention!!!")
        End Try

    End Sub


End Class
