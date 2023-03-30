using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var serverIP = IPAddress.Parse(textBoxIP.Text.Trim());
            var serverPort = int.Parse(textBoxPort.Text.Trim());
            var serverEndpoint = new IPEndPoint(serverIP, serverPort);
            var recieveBuffer = new byte[1024];


            while (true)
            {
                var socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                var sendBuffer = Encoding.ASCII.GetBytes(textBoxMessage.Text.Trim());
                socket.SendTo(sendBuffer, serverEndpoint);
                EndPoint dummyEndpoint = new IPEndPoint(IPAddress.Any, 0);

                var length = socket.ReceiveFrom(recieveBuffer, ref dummyEndpoint);
                var receive = Encoding.ASCII.GetString(recieveBuffer, 0, length);
                Array.Clear(recieveBuffer , 0, 1024);
                socket.Close();
                textBoxReceive.Text = "Đã nhận được tin nhắn: " + receive;
            }
        }
    }
}