using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignite_Compiler
{
    public class Compare
    {
        
        int count = 0;
        int lineNo = 1;
        string valuepart;
        public static string classpart;
        public static List<string> tokkens = new List<string>();
        List<char> character = new List<char>();

        public void read(string code)
        {
            foreach (char chr in code)
            {
                character.Add(chr);
                if (chr == ' ')
                {
                    foreach (char c in character)
                    {
                        valuepart = valuepart + Convert.ToString(c);
                    }
                    matchtoken(valuepart);
                    string token = "(" + valuepart + " , " + classpart + " , " + lineNo+")";
                    tokkens.Add(token);
                    valuepart = null;
                    classpart = null;
                    count = 0;
                    character.Clear();
                }
            }
        }

        public void matchtoken(string word)
        {
            string a = word.ToLower();
            while (count != 1)
            {
                if (a.Equals("main "))
                {
                    classpart = "MAIN";
                    count = 1;
                    Console.WriteLine("IF part");

                }
            
                else
                {
                    classpart = "Invalid";
                    count = 1;
                }
            }
        } 



        //public string compareMethod(string code)
        //{
        //    codeArray = code.ToCharArray();
        //    length = codeArray.Length - 1;

        //    for (int i = 0; i <= length; i++)
        //    {
        //        if (codeArray[i] == ';')
        //        {
        //            lineNo++;
        //        }
        //    }
        //    return lineNo.ToString();
        //}
    }
}
