using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessRules
{
    public static class ZipCodeChecker
    {
        public static bool IsDanishZipCodeValid(string zipCode)
        {
            bool isValid = false;

            StreamReader sr = new StreamReader(@"C:/Kode/ZipCodes.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                if(line == zipCode)
                {
                    return true;
                }
            }

            return isValid;
        }
    }
}
