using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void main(string[] args)
        {
            var localIP = IPAddress.Any;
            var localPort = 1308;
            var localEndpoint = new IPEndPoint(localIP, localPort);

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(localEndpoint);
            textBoxReceive.Text = "Kết nối thành công, chờ thông điệp.";

            var receiveBuffer = new byte[1024];

            while (true)
            {
                EndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
                var length = socket.ReceiveFrom(receiveBuffer, ref remoteEndpoint);
                var result = Encoding.ASCII.GetString(receiveBuffer, 0, length);
                textBoxReceive.Text += result;

                var sendBuffer = Encoding.ASCII.GetBytes(result);
                socket.SendTo(sendBuffer, remoteEndpoint);
                Array.Clear(receiveBuffer, 0, 1024);
            }
        }
    }
}