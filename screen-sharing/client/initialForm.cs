using System;
using System.Windows.Forms;

namespace client
{
    public partial class initialForm : Form
    {

        public initialForm()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            string port = nPort.Value.ToString();

            if (port.Length == 0)
            {
                MessageBox.Show("Campo: Porta, não pode ser vazio!");
                return;
            }

            watchForm watch = new watchForm(int.Parse(port));
            watch.Show();
            this.Hide();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            sobreBox box = new sobreBox();
            box.ShowDialog();
        }
    }
}
