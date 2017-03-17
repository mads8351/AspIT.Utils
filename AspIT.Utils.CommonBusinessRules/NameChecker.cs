using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessRules
{
    public static class NameChecker
    {
        public static bool IsValidName(string name)
        {

            string[] exceptions = { "von", "di", "la" };

            foreach(Char c in name)
            {

                if(!char.IsLetter(c) &&  c != '-')
                {
                    return false;
                }

            }

            return true;
        }
    }
}
