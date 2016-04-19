using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ignite_Compiler
{
    public partial class AboutDeveloper : Form
    {
        public AboutDeveloper()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)          //Close Developers form
        {
            this.Hide();
        }
    }
}
