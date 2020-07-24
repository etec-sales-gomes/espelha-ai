using System.Net;
using System.Windows.Forms;

namespace server
{
    public partial class initialForm : Form
    {
        public initialForm()
        {
            InitializeComponent();
        }

        sendScreenSocket screenSocket;

        private void btnShare_Click(object sender, System.EventArgs e)
        {
            string port = nPort.Value.ToString();

            string buttonText = btnShare.Text;
            if (buttonText == "Compartilhar")
            {

                screenSocket = new sendScreenSocket(new IPEndPoint(IPAddress.Parse("192.168.0.255"), int.Parse(port)));
                screenSocket.startSender();
                btnShare.Text = "Parar de compartilhar";
            } 
            else
            {
                screenSocket.stopSender();
                btnShare.Text = "Compartilhar";
            }
        }
    }
}
