using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace client
{
    public partial class watchForm : Form
    {
        receiveScreenSocket receiveScreen;
        int Port;

        public watchForm(int port)
        {
            Port = port;

            InitializeComponent();
            this.Text = "Assistindo porta: " + port;
            notifyIcon.Visible = false;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Exit", Exit) });
        }

        private void watchForm_Load(object sender, EventArgs e)
        {
            receiveScreen = new receiveScreenSocket(Port, pbImageReceive);
            receiveScreen.startListening();
        }

        public void Exit(object sender, EventArgs e)
        {
            notifyIcon.Icon.Dispose();
            notifyIcon.Dispose();
            Process.GetCurrentProcess().Kill();
        }

        private void watchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            receiveScreen.pause();
            notifyIcon.Visible = true;
        }

        private void watchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            receiveScreen.stopListening();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            receiveScreen.resume();
            notifyIcon.Visible = false;
            Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
