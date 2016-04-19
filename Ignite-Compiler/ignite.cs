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
    public partial class ignite : Form
    {
        public ignite()
        {
            InitializeComponent();
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            new compile().Show();
            this.Hide();
        }

        private void lexicalButton_Click(object sender, EventArgs e)
        {
            new LexicalAnalyser().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
