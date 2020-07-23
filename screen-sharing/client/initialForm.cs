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
            string input = txtHostname.Text.Replace(" ", "");

            if (input.Length == 0)
            {
                MessageBox.Show("Campo: nome do computador, não pode ser vazio!");
                return;
            }

            // HostnameFinder
            string address = new hostnameFinder().hostname(input);
            if (address == null)
            {
                MessageBox.Show("Computador não encontrado");
                return;
            }

            watchForm watch = new watchForm(address, txtHostname.Text);
            watch.Show();
            this.Hide();
        }
    }
}
