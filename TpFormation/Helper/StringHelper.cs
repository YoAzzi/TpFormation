using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormation.Helper
{
    public static class StringHelper
    {
        public static string CleanString(this string str)
        {
            return str.Replace("\r\n", "\n").Replace("*", "");
        }
    }
}
