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

            string address = new hostnameFinder().hostname(txtHostname.Text);
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
