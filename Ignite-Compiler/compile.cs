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
    public partial class compile : Form
    {
        fileOption fo = new fileOption();

        public compile()
        {
            InitializeComponent();
            inputRichTextBox.Text = "/*\tAuther Name : " + Environment.UserName + "\n\tDate & Time " + DateTime.Now + " \t*/\n";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)        //Exit the Application
        {
            Application.Exit();
        }

        private void lexicalToolStripMenuItem_Click(object sender, EventArgs e)     //jump to lexical Analyser form
        {
            new LexicalAnalyser().Show();
            this.Hide();
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)  //ump to ignite Main Form
        {
            new ignite().Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)             //remove the editor of input text box
        {
            //inputRichTextBox.Text = "";
            inputRichTextBox.Text = "/*\tAuther Name : " + Environment.UserName + "\n\tDate & Time " + DateTime.Now + " \t*/\n";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)            //open save file from system in text format
        {
            inputRichTextBox.Text = fo.OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)            //save the code in text format
        {
            if (inputRichTextBox.Text == "")
            {
                MessageBox.Show("Please write some code to save it...");
            }
            else
            {
                fo.Save(inputRichTextBox.Text);

            }
        }

      
    }
}
