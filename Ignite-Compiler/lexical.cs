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
    public partial class LexicalAnalyser : Form
    {

        fileOption fo = new fileOption();           //instance of fileoption class = fo
        Compare com = new Compare();                //instance of compare class = com

        public LexicalAnalyser()
        {
            InitializeComponent();
            //inputRichTextBox.Text = "/*\tAuther Name : " + Environment.UserName + "\n\tDate & Time " + DateTime.Now + " \t*/\n";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)            //Exit the application
        {
            Application.Exit();
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)         //jump to compile code form
        {
            new compile().Show();
            this.Hide();
        }

        private void lexicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)      //jump to ignite main form
        {
            new ignite().Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)             //remove the editor of input text box
        {
            //inputRichTextBox.Text = "";
            //inputRichTextBox.Text = "/*\tAuther Name : " + Environment.UserName+ "\n\tDate & Time "+DateTime.Now+" \t*/\n";
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

        private void generateTokensButton_Click(object sender, EventArgs e)             //Generate Tokens Buttons
        {
            outputRichTextBox.Text = "";
            //string lineNo = (com.compareMethod(inputRichTextBox.Text));
            //outputRichTextBox.Text = lineNo;
                                                //Azhar try
            //com.read(inputRichTextBox.ToString());
            //foreach (string element in Compare.tokkens)
            //{
            //    outputRichTextBox.Text = element;
            //}
                                                //Azhar try
            Compare.tn = 0;
            Compare.Token.Clear();
            com.CompareMethod(inputRichTextBox.Text);   // Use Saved File

            int tnlen = Compare.tn;
            int i = 0;
            //TokenHolder[] tok = Assign.Token;
            List<TokenHolder> tok = Compare.Token;

            while (tnlen > i)
            {
                outputRichTextBox.AppendText("( " + tok[i].ClassPart + ", " + tok[i].ValuePart + ", " + tok[i].LineNumber + " )" + "\n");
                i++;
            }
        }

        private void aboutIgniteToolStripMenuItem_Click(object sender, EventArgs e)         //Show About Ignite Form
        {
            new AboutIgnite().Show();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)          //Show About Developer Form
        {
            new AboutDeveloper().Show();
        }

        private void inputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(inputRichTextBox.Text))
            //{
            //    generateTokensButton.Enabled = false;
            //}
            //else 
            //{
            //    generateTokensButton.Enabled = true;
            //}
        }

    }
}
