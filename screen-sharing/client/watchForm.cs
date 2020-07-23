using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace client
{
    public partial class watchForm : Form
    {
        receiveScreenSocket receiveScreen;
        string Address;

        public watchForm(string address, string hostname)
        {
            Address = address;

            InitializeComponent();
            this.Text = "Assistindo tela de: " + hostname;
            notifyIcon.Visible = false;
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Exit", Exit) });
        }

        private void watchForm_Load(object sender, EventArgs e)
        {
            receiveScreen = new receiveScreenSocket(Address, 12345, pbImageReceive);
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
