using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS
{
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "search")
                {
                    control.Enabled = true;
                }
            }
        }
    }
}
