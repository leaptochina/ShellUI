using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellUI.Shell
{
    class RunCommand
    {
        public string command = "";
        public RunCommand(SshClient sshclient, string command) {
            this.command = command;
        }
    }
}
