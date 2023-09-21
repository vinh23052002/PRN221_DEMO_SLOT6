using System.Net.Sockets;

namespace DEMO30_28_NguyenQuangVinh_ClientApp
{
    internal class Program
    {
        static void ConnectServer(String server, int port)
        {
            string message, responseData;
            int bytes;
            try
            {
                TcpClient client = new TcpClient(server, port);
                Console.Title = "Client Application";
                NetworkStream stream = null;
                while (true)
                {
                    Console.Write("input message <press Enter to exit>");
                    message = Console.ReadLine();
                    if (message == string.Empty)
                    {
                        break;
                    }

                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Sent: " + message);

                    data = new byte[256];
                    bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    Console.WriteLine("Received: " + responseData);

                }
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 13000;
            ConnectServer(server, port);
        }
    }
}