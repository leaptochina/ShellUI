using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = this.host.Text;
            int port = Convert.ToInt32(this.port.Text);
            string username = this.username.Text;
            string password = this.password.Text;

            MySshClient msc = new MySshClient(host, username, password, port);

        }
    }
}
