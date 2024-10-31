using System.Net;
using System.Net.Sockets;

TcpListener listener = new TcpListener(IPAddress.Any, 1194);
listener.Start();

Console.WriteLine("Aguardando conexões...");

TcpClient client = listener.AcceptTcpClient();
Console.WriteLine("Cliente conectado.");

NetworkStream stream = client.GetStream();

while (client.Connected)
{
    try
    {
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        if (bytesRead > 0)
        {
            // Processa os dados recebidos
            string data = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Recebido do cliente: " + data);

            // Envia dados para o cliente
            string response = "Mensagem do servidor";
            byte[] responseBytes = System.Text.Encoding.ASCII.GetBytes(response);
            stream.Write(responseBytes, 0, responseBytes.Length);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro: " + ex.Message);
        break;
    }
}

stream.Close();
client.Close();
listener.Stop();
