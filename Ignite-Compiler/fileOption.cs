using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ignite_Compiler
{
    public class fileOption
    {
        public string OpenFile()                    //open text file function
        {
            string text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File Name|*.txt";
            ofd.Title = "Choose File";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                StreamReader sr = new StreamReader(path);
                text = sr.ReadToEnd();
                sr.Dispose();
            }
            return text;
        }

        public void CreateFile(string path, string text)
        {
            if (!(File.Exists(path)))
            {
                FileStream fs = File.Create(path);
                fs.Dispose();
                StreamWriter sw = new StreamWriter(path);
                sw.Write(text);
                sw.Dispose();
            }
            else
            {

                SaveAsOrNewFile(text);
            }
        }

        public void Save(string Text)
        {
            string path = @"../project";
            CreateFile(path, Text);
        }

        public void SaveAsOrNewFile(string Text)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|* .txt";
            sfd.FileName = "Project";
            sfd.Title = "Save File";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CreateFile(sfd.FileName, Text);    
            }
        }
    }
}
