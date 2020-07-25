using System;
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

            screenSocket = new sendScreenSocket(new IPEndPoint(IPAddress.Parse("192.168.0.255"), int.Parse(port)), Convert.ToInt32(nQuality.Value));

            if (buttonText == "Compartilhar")
            {
                screenSocket.startSender();
                btnShare.Text = "Parar de compartilhar";
            } 
            else
            {
                screenSocket.stopSender();
                btnShare.Text = "Compartilhar";
            }
        }

        private void nQuality_ValueChanged(object sender, System.EventArgs e)
        {
            if (screenSocket != null)
            {
                if (screenSocket.getState() == true)
                {
                    screenSocket.setQuality(Convert.ToInt32(nQuality.Value));
                }
            }
        }

        private void initialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (screenSocket != null)
            {
                screenSocket.stopSender();
            }
        }
    }
}
