using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

public struct TokenHolder
{
    public int LineNumber { get; set; }
    //public char[] ValuePart;
    public string ValuePart;
    public string ClassPart;
}


namespace Ignite_Compiler
{
    public class Compare
    {
        public static List<TokenHolder> Token = new List<TokenHolder>();
        public static int tn = 0;           //Token Number 
        public int vpa = 0;                 //Value Part Array Counter

        

        public void AssignAll(string ClassName, string ValuePart, int Ln)
        {
            var t = new TokenHolder();
            t.ClassPart = ClassName;
            t.ValuePart = ValuePart;
            t.LineNumber = Ln;
            Token.Add(t);
            tn++;
        }

        public void ForExcRemove()
        {
            var t = new TokenHolder();
            t.ClassPart = "";
            t.ValuePart = "";
            t.LineNumber = 5000;
            Token.Add(t);
        }
                                        //Azhar try
        public void WriteToken()
        {


            string FileName2 = @"C:\Users\Anas\Desktop\zzTokens.txt";
            if (!File.Exists(FileName2))
            {
                FileStream fs = File.Create(FileName2);
                fs.Dispose();
            }

            StreamWriter sw = new StreamWriter(FileName2);
            while (tn >= 0)
            {
                sw.WriteLine("(" + Token[tn].ClassPart + ",  " + Token[tn].ValuePart + ",  " + Token[tn].LineNumber + ")");
                tn--;
            }

            sw.Close();

        }

        //int count = 0;
        //int lineNo = 1;
        //string valuepart;
        //public static string classpart;
        //public static List<string> tokkens = new List<string>();
        //List<char> character = new List<char>();

        //public void read(string code)
        //{
        //    foreach (char chr in code)
        //    {
        //        character.Add(chr);
        //        if (chr == ' ')
        //        {
        //            foreach (char c in character)
        //            {
        //                valuepart = valuepart + Convert.ToString(c);
        //            }
        //            matchtoken(valuepart);
        //            string token = "(" + valuepart + " , " + classpart + " , " + lineNo+")";
        //            tokkens.Add(token);
        //            valuepart = null;
        //            classpart = null;
        //            count = 0;
        //            character.Clear();
        //        }
        //    }
        //}

        //public void matchtoken(string word)
        //{
        //    string a = word.ToLower();
        //    while (count != 1)
        //    {
        //        if (a.Equals("main "))
        //        {
        //            classpart = "MAIN";
        //            count = 1;
        //            a = null;
        //        }
        //        else if (a.Equals("void "))
        //        {
        //            classpart = "VOID";
        //            count = 1;
        //            a = null;
        //        }
            
        //        else
        //        {
        //            classpart = "Invalid";
        //            count = 1;
        //        }
        //    }
        //} 
                                                //Azhar try


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



        public int cn = 0;          //Character Number

        public char[] CodeArray;
        public string ValueP;
        public int LineNumber = 1;
        public int len;
        char[] Pun = { '`', '~', '@', '#', '$', '^', '(', ')', '{', '}', '[', ']', ',', '_', '.', '!', '?', '&', '|', '\\' };

                                  //Object of Class Assign 
        KeyValuePsCheck kwd = new KeyValuePsCheck();

        public void CompareMethod(string code)
        {
            code += " ";
            CodeArray = code.ToCharArray();


            len = CodeArray.Length;
            len--;
            //if (!(CodeArray[len] == ';'))
            //{
            //    MessageBox.Show("Terminator is Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            while (len > cn)
            {
                //if (char.Equals(CodeArray[cn], '\r') && char.Equals(CodeArray[cn + 1], '\n'))

                if (char.Equals(CodeArray[cn], '\r'))
                {
                    LineNumber++;
                    cn += 2;
                    continue;
                }

                if (CodeArray[cn] == '/')
                {
                    if (ComCommentCheck())
                        continue;
                }

                if (char.Equals(CodeArray[cn], ' '))
                {
                    cn++;
                    continue;
                }
                if ((CodeArray[cn] >= '0' && CodeArray[cn] <= '9') || (CodeArray[cn] == '.' && char.IsDigit(CodeArray[cn + 1])))
                {
                    if (!(CodeArray[cn] == '.'))
                        if (CheckIntConstant())
                        {
                            ComAssign("INT_CONSTANT");
                            continue;
                        }


                    CheckFloatConstant();
                    ComAssign("FLOAT_CONSTANT");
                    continue;

                }

                if (CodeArray[cn] == '_' && CodeArray[cn + 1] >= 'a' && CodeArray[cn + 1] <= 'z')
                {
                    ComIdCheck();
                    continue;
                }

                if (CodeArray[cn] == '\'')
                {
                    ComCharConsCheck();
                    continue;
                }

                if (CodeArray[cn] == '\"')
                {
                    ComStrConsCheck();
                    continue;

                }

                //if(char.IsPunctuation(CodeArray[cn]))
                // {
                //     ComPunCheck();
                //     continue;
                // }

                if (CodeArray[cn] == '&' && CodeArray[cn + 1] == '&')
                {
                    ComAssignVp(1, "AND");
                    continue;
                }

                if (CodeArray[cn] == '|' && CodeArray[cn + 1] == '|')
                {
                    ComAssignVp(1, "OR");
                    continue;
                }

                if (Pun.Contains(CodeArray[cn]))
                {
                    ValueP += CodeArray[cn];
                    ComAssign("Puncuators");
                    cn++;
                    continue;
                }

                if (CodeArray[cn] == ';')
                {
                    ValueP += CodeArray[cn];
                    ComAssign("SEMICOLON");
                    cn++;
                    continue;

                }

                if (CodeArray[cn] >= 'a' && CodeArray[cn] <= 'z')
                {
                    ComKeyWordsCheck();
                    continue;
                }



                if (CodeArray[cn] == '>' || CodeArray[cn] == '<' || ((CodeArray[cn] == '=' || CodeArray[cn] == '!') && CodeArray[cn + 1] == '='))
                {
                    ComRelOpCheck();
                    continue;
                }

                if (CodeArray[cn] == '+' || CodeArray[cn] == '-' || CodeArray[cn] == '*' || CodeArray[cn] == '/' || CodeArray[cn] == '%' || CodeArray[cn] == '=')
                {
                    ComOperatorCheck();
                    continue;
                }


                try
                {
                    ComIdCheck();
                }
                catch (IndexOutOfRangeException error)
                {
                    MessageBox.Show(error.Message);
                }


            }

            ForExcRemove();

        }
        public void ComKeyWordsCheck()
        {
            //if (CodeArray[cn] == 'm')
            //{
            //    ValueP += CodeArray[cn];
            //    cn++;
            //    if (CodeArray[cn] == 'a')
            //    {
            //        ValueP += CodeArray[cn];
            //        cn++;
            //        if (CodeArray[cn] == 'i')
            //        {
            //            ValueP += CodeArray[cn];
            //            cn++;

            //            if (CodeArray[cn] == 'n')
            //            {
            //                ValueP += CodeArray[cn];
            //                cn++;
            //                if (kwd.CheckWordBreak(CodeArray[cn]))
            //                {
            //                    ComAssign("MAIN");                  //Assign ClassPart, ValuePart, LineNumber

            //                    //if (ValueP.Equals("main"))
            //                    //    ComAssign("MAIN");
            //                    //else
            //                    //    ComAssign("ID");
            //                }
            //                else
            //                    ComIdCheck();
            //                return;
            //            }
            //        }
            //    }
            //}
            //KEYWORDS

            if (CodeArray[cn] == 'v' && CodeArray[cn + 1] == 'o' && CodeArray[cn + 2] == 'i' && CodeArray[cn + 3] == 'd' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "VOID");
                return;
            }

            if (CodeArray[cn] == 'm' && CodeArray[cn + 1] == 'a' && CodeArray[cn + 2] == 'i' && CodeArray[cn + 3] == 'n' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "MAIN");
                return;
            }
            if (CodeArray[cn] == 'r' && CodeArray[cn + 1] == 'e' && CodeArray[cn + 2] == 'a' && CodeArray[cn + 3] == 'd' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "READ");
                return;
            }
            if (CodeArray[cn] == 'w' && CodeArray[cn + 1] == 'r' && CodeArray[cn + 2] == 'i' && CodeArray[cn + 3] == 't' && CodeArray[cn + 4] == 'e' && kwd.CheckWordBreak(CodeArray[cn + 5]))
            {
                ComAssignVp(4, "WRITE");
                return;
            }
            if (CodeArray[cn] == 'r' && CodeArray[cn + 1] == 'e' && CodeArray[cn + 2] == 't' && CodeArray[cn + 3] == 'u' && CodeArray[cn + 4] == 'r' && CodeArray[cn + 5] == 'n' && kwd.CheckWordBreak(CodeArray[cn + 6]))
            {
                ComAssignVp(5, "RETURN");
                return;
            }

            //DATA TYPES

            if (CodeArray[cn] == 'n' && CodeArray[cn + 1] == 'u' && CodeArray[cn + 2] == 'm' && kwd.CheckWordBreak(CodeArray[cn + 3]))
            {
                ComAssignVp(2, "DT");
                return;
            }

            if (CodeArray[cn] == 'n' && CodeArray[cn + 1] == 'u' && CodeArray[cn + 2] == 'm' && CodeArray[cn + 3] == 'f' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "DT");
                return;
            }

            if (CodeArray[cn] == 'v' && CodeArray[cn + 1] == 'a' && CodeArray[cn + 2] == 'r' && kwd.CheckWordBreak(CodeArray[cn + 3]))
            {
                ComAssignVp(2, "DT");
                return;
            }

            if (CodeArray[cn] == 'v' && CodeArray[cn + 1] == 'a' && CodeArray[cn + 2] == 'r' && CodeArray[cn + 3] == 's' && CodeArray[cn + 4] == 't' && CodeArray[cn + 5] == 'r' && kwd.CheckWordBreak(CodeArray[cn + 6]))
            {
                ComAssignVp(5, "DT");
                return;
            }


            //LOOPS


            if (CodeArray[cn] == 'd' && CodeArray[cn + 1] == 'u' && CodeArray[cn + 2] == 'p' && kwd.CheckWordBreak(CodeArray[cn + 3]))
            {
                ComAssignVp(2, "LOOP_DUP");
                return;
            }

            if (CodeArray[cn] == 'd' && CodeArray[cn + 1] == 'o' && kwd.CheckWordBreak(CodeArray[cn + 2]))
            {
                ComAssignVp(1, "LOOP_DO_DUP");
                return;
            }
            if (CodeArray[cn] == 'a' && CodeArray[cn + 1] == 's' && kwd.CheckWordBreak(CodeArray[cn + 2]))
            {
                ComAssignVp(1, "LOOP_AS");
                return;
            }


            //CONDITIONAL STATEMENTS

            if (CodeArray[cn] == 'i' && CodeArray[cn + 1] == 'f' && kwd.CheckWordBreak(CodeArray[cn + 2]))
            {
                ComAssignVp(1, "CON_IF");
                return;
            }

            if (CodeArray[cn] == 'e' && CodeArray[cn + 1] == 'l' && CodeArray[cn + 2] == 's' && CodeArray[cn + 3] == 'e' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "CON_ELSE");
                return;
            }
            if (CodeArray[cn] == 's' && CodeArray[cn + 1] == 'w' && CodeArray[cn + 2] == 'i' && CodeArray[cn + 3] == 't' && CodeArray[cn + 4] == 'c' && CodeArray[cn + 5] == 'h' && kwd.CheckWordBreak(CodeArray[cn + 6]))
            {
                ComAssignVp(5, "CON_SWITCH");
                return;
            }
            if (CodeArray[cn] == 'd' && CodeArray[cn + 1] == 'e' && CodeArray[cn + 2] == 'f' && CodeArray[cn + 3] == 'a' && CodeArray[cn + 4] == 'u' && CodeArray[cn + 5] == 'l' && CodeArray[cn + 6] == 't' && kwd.CheckWordBreak(CodeArray[cn + 7]))
            {
                ComAssignVp(6, "CON_S_DEFAULT");
                return;
            }

            if (CodeArray[cn] == 'c' && CodeArray[cn + 1] == 'a' && CodeArray[cn + 2] == 's' && CodeArray[cn + 3] == 'e' && kwd.CheckWordBreak(CodeArray[cn + 4]))
            {
                ComAssignVp(3, "CON_S_CASE");
                return;
            }

            if (CodeArray[cn] == 'b' && CodeArray[cn + 1] == 'r' && CodeArray[cn + 2] == 'e' && CodeArray[cn + 3] == 'a' && CodeArray[cn + 4] == 'k' && kwd.CheckWordBreak(CodeArray[cn + 5]))
            {
                ComAssignVp(4, "BREAK");
                return;
            }

            //OOP


            if (CodeArray[cn] == 'i' && CodeArray[cn + 1] == 'n' && CodeArray[cn + 2] == 'h' && CodeArray[cn + 3] == 'e' && CodeArray[cn + 4] == 'r' && CodeArray[cn + 5] == 'i' && CodeArray[cn + 6] == 't' && kwd.CheckWordBreak(CodeArray[cn + 7]))
            {
                ComAssignVp(6, "OOP_INHERIT");
                return;
            }

            if (CodeArray[cn] == 'c' && CodeArray[cn + 1] == 'l' && CodeArray[cn + 2] == 'a' && CodeArray[cn + 3] == 's' && CodeArray[cn + 4] == 's' && kwd.CheckWordBreak(CodeArray[cn + 5]))
            {
                ComAssignVp(4, "CLASS");
                return;
            }

            //ACCESS MODIFIERS
            if (CodeArray[cn] == 'p' && CodeArray[cn + 1] == 'u' && CodeArray[cn + 2] == 'b' && CodeArray[cn + 3] == 'l' && CodeArray[cn + 4] == 'i' && CodeArray[cn + 5] == 'c' && kwd.CheckWordBreak(CodeArray[cn + 6]))
            {
                ComAssignVp(5, "ACCESS_MOD");
                return;
            }
            if (CodeArray[cn] == 'p' && CodeArray[cn + 1] == 'r' && CodeArray[cn + 2] == 'i' && CodeArray[cn + 3] == 'v' && CodeArray[cn + 4] == 'y' && kwd.CheckWordBreak(CodeArray[cn + 5]))
            {
                ComAssignVp(4, "ACCESS_MOD");
                return;
            }

            if (CodeArray[cn] == 'i' && CodeArray[cn + 1] == 'm' && CodeArray[cn + 2] == 'm' && CodeArray[cn + 3] == 'u' && CodeArray[cn + 4] == 'n' && CodeArray[cn + 5] == 'e' && kwd.CheckWordBreak(CodeArray[cn + 6]))
            {
                ComAssignVp(5, "ACCESS_MOD");
                return;
            }
            //if (CodeArray[cn] == 'i')
            //{
            //    ValueP += CodeArray[cn];
            //    cn++;
            //    if (CodeArray[cn] == 'f')
            //    {
            //        ValueP += CodeArray[cn];
            //        cn++;

            //        if (kwd.CheckWordBreak(CodeArray[cn]))
            //        {
            //            ComAssign("IF");
            //        }
            //        else
            //            ComIdCheck();
            //        return;
            //    }
            //}
            else
            {
                ComIdCheck();
            }


        }
        public void ComIdCheck()
        {
            //while (!(kwd.CheckWordBreakId(CodeArray[cn])))
            while ((CodeArray[cn] >= 'A' && CodeArray[cn] <= 'Z') || (CodeArray[cn] >= 'a' && CodeArray[cn] <= 'z') || CodeArray[cn] == '_')
            {
                ValueP += CodeArray[cn];
                cn++;
            }
            ComAssign("ID");
            //ComVerifyID(ValueP);
        }

        //public bool ComVerifyID(string ValueP)
        //{
        //    if (ValueP[0] >= 'a' && ValueP[0] <= 'z')
        //    {
        //        return true;
        //    }

        //    else if (ValueP[0] == '_' && ValueP[1] >= 'a' && ValueP[1] <= 'z')
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        string 
        //        string temp = ValueP.Remove(0, 0);
        //    }
        //    return false;
        //}
        public void ComAssignVp(int l, string Class)
        {
            while (l >= 0)
            {
                ValueP += CodeArray[cn];
                cn++;
                l--;
            }
            ComAssign(Class);
        }

        public void ComAssign(string ClassName)
        {
            AssignAll(ClassName, ValueP, LineNumber);
            ValueP = "";
        }

        //public void ComAssign(string ClassName)
        //{
        //    asg.AssignVp(ValueP);
        //    asg.AssignCp(ClassName);
        //    asg.AssignLn(LineNumber);
        //    ValueP = "";
        //    //cn++;
        //    //if (cn > len)

        //}


        //public void ComPunCheck()
        //{
        //    //if (new[] { '`', '~', '@', '#', '$', '^', '(', ')', '{', '}', '[', ']', ',' }.Contains(CodeArray[cn])) {}

        //    ComAssign("pun");
        //    char[] Pun = { '`', '~', '@', '#', '$', '^', '(', ')', '{', '}', '[', ']', ',', '_' };
        //    if (Pun.Contains(CodeArray[cn]))
        //    {
        //        ValueP += CodeArray[cn];
        //        ComAssign("Puncuators");
        //        cn++;
        //    }
        //    //else if (CodeArray[cn] == ';')
        //    //    {
        //    //        ValueP += CodeArray[cn];
        //    //        ComAssign("SemiColon");
        //    //        cn++;
        //    //    }
        //}

        public bool CheckIntConstant()
        {
            ValueP += CodeArray[cn];
            cn++;

            while (len > cn)
            {

                //if (CodeArray[cn] == '.' && CodeArray[cn + 1] < '0' || CodeArray[cn + 1] > '9')
                //    return true;
                if (CodeArray[cn] == '.' && (CodeArray[cn + 1] >= '0' && CodeArray[cn + 1] <= '9'))
                    return false;

                if (CodeArray[cn] < '0' || CodeArray[cn] > '9')
                    return true;

                ValueP += CodeArray[cn];
                cn++;
            }
            return true;

        }

        public void CheckFloatConstant()
        {

            do
            {
                ValueP += CodeArray[cn];
                cn++;

                if (CodeArray[cn] >= '0' && CodeArray[cn] <= '9')
                    continue;

                else break;

            } while (len > cn);
        }

        public void ComCharConsCheck()
        {
            char[] ChCons = { 'n', 't', 'r', 'f', 'b', '\'', '\"' };

            ValueP += CodeArray[cn];
            cn++;
            if (CodeArray[cn] == '\'')
            {
                ValueP += CodeArray[cn];
                cn++;
                ComAssign("CHAR_CONSTANT");
                return;

            }

            if (CodeArray[cn] == '\\' && ChCons.Contains(CodeArray[cn + 1]) && CodeArray[cn + 2] == '\'')
            {
                for (int i = 0; i < 3; i++)
                {
                    ValueP += CodeArray[cn];
                    cn++;
                }
                ComAssign("ESCAPE_CHARACTER");
                return;
            }

            if ((CodeArray[cn] >= ' ' && CodeArray[cn] <= '~') && (CodeArray.ElementAtOrDefault(cn + 1) == '\''))
            {
                for (int i = 0; i < 2; i++)
                {
                    ValueP += CodeArray[cn];
                    cn++;
                }
                ComAssign("CHAR_CONS");
                return;

                //ValueP += CodeArray[cn];
                //cn++;
                //if (CodeArray[cn] == '\'')
                //{
                //    ValueP += CodeArray[cn];
                //    cn++;
                //    ComAssign("CHAR_CONSTANT");
                //    return;
                //}
            }
            else
            {
                while (len > cn)
                {
                    ValueP += CodeArray[cn];
                    cn++;
                    if (CodeArray[cn] == '\r' || CodeArray[cn] == '\'')
                    {
                        if (CodeArray[cn] == '\'')
                        {
                            ValueP += CodeArray[cn];
                            cn++;
                        }

                        break;
                    }

                }

                ComAssign("INVALID_CHAR_CONS");
                return;

            }

        }

        public void ComStrConsCheck()
        {
            do
            {
                ValueP += CodeArray[cn];
                cn++;
                if (CodeArray[cn] == '\"')
                {
                    ValueP += CodeArray[cn];
                    cn++;
                    ComAssign("STR_CONS");
                    return;
                }
            }
            while (len > cn);

            ComAssign("INVALID_STR_CONS");
        }

        public void ComOperatorCheck()
        {
            ValueP += CodeArray[cn];
            cn++;

            if (CodeArray[cn - 1] == '=')
            {
                ComAssign("ASSIGN_OP");
                return;
            }
            else if (CodeArray[cn] == '=')
            {
                ValueP += CodeArray[cn];
                cn++;
                ComAssign("ASSIGN_OP");
                return;
            }

            if ((CodeArray[cn - 1] == '+' && CodeArray[cn] == '+') || (CodeArray[cn - 1] == '-' && CodeArray[cn] == '-'))
            {
                ValueP += CodeArray[cn];
                cn++;
                ComAssign("INC_DEC_OP");
                return;
            }

            else if (CodeArray[--cn] == '+' || CodeArray[cn] == '-')
            {
                ComAssign("ADD_SUB");
                cn++;
                return;
            }

            else if (CodeArray[cn] == '/' || CodeArray[cn] == '*' || CodeArray[cn] == '%')
            {
                ComAssign("DIV_MUL_MOD");
                cn++;
                return;
            }


        }
        public void ComRelOpCheck()
        {
            ValueP += CodeArray[cn];
            cn++;

            if (CodeArray[cn] == '=')
            {
                ValueP += CodeArray[cn];
                cn++;
            }

            ComAssign("REL_OPR");
        }

        public bool ComCommentCheck()
        {
            if (CodeArray[cn + 1] == '?')
            {
                while (len > cn)
                {
                    if (CodeArray[cn] != '\r')
                        cn++;
                    else return true;
                }
            }

            else if (CodeArray[cn + 1] == '$')
            {
                while (len > cn)
                {
                    if (CodeArray[cn] == '$' && CodeArray.ElementAtOrDefault(cn + 1) == '/')
                    {
                        cn = cn + 2;
                        return true;
                    }
                    cn++;
                }
            }
            return false;
        }
    }
}
