using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet.Common;
using ShellUI.public_files;

namespace ShellUI
{
    class MySshClient
    {
        public string hostName = "";
        public string username = "";
        public string password = "";
        public int port = 22;
        public SshClient client = null;
        

        public MySshClient(string hostName, string username, string password, int port = 22) {

            client = new SshClient(hostName, port, username, password);
            client.HostKeyReceived += HostKeyReceived;
            client.Connect();
            执行登陆后脚本();
        }

        public void 执行登陆后脚本() {

            var cmd = client.CreateCommand("su").Execute();
            Log.d(cmd);



        }


        private void HostKeyReceived(object sender, HostKeyEventArgs e)
        {
            e.CanTrust = true;
        }
    }
}
