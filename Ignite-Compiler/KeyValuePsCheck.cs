using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignite_Compiler
{
    class KeyValuePsCheck
    {
        public bool CheckWordBreak(char c)
        {
            if (c == ' ' || c == ';' || c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']' || c == '\'' || c == '/' || c == '+' || c == '-' || c == '*' || c == '`' || c == '`' || c == '%' || c == '.' || c == ',' || c == '?' || c == '\"' || c == '\r')
                return true;
            else
                return false;
        }

    }
}
