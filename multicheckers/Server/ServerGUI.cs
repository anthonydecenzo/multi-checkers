using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using multicheckers.Server;

namespace multicheckers.Server
{
    public partial class ServerGUI : Form
    {
        public ServerGUI()
        {
            InitializeComponent();
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            CheckerServer server = new CheckerServer(Int32.Parse(txtServerPort.Text));

            server.startServer();
        }
    }
}
