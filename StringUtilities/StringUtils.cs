// Malcom Myers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities
{
    public class StringUtils
    {
        public string Rev_String(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            return new string(str.ToCharArray().Reverse().ToArray());
        }

        public bool IsStringNullOrEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
