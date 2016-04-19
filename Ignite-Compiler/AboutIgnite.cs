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
    public partial class AboutIgnite : Form
    {
        public AboutIgnite()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)      //close the About Ignite Form
        {
            this.Hide();
        }
    }
}
