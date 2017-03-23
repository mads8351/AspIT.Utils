using AspIT.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.CommonBusinessRules
{
    public static class NameChecker
    {
        public static bool IsValidName(string name)         // Her erklæres en metode med navnet isValidName der returnere en bool.
        {

            string[] exceptions =  { "von", "di", "la" };   // Erklærer et string array under navnet exceptions.

            if(name.StartsWithUppercase())                  // En if sætning med betingelse om at parametren name skal starte med stort bogstav.
            {
                foreach(Char c in name)                     // Foreach løkke der iterere gennem string variablen name.
                {
                    if(!char.IsLetter(c) && c != '-')       // En if sætning med betingelse om at hvis c ikke kun består af bogstaver og bindestreger
                    {                                       // så hopper den ind i tuborg-parenteserne og returneres false.
                        return false;
                    }

                }
            }
            else                                            //  Hvis ikke name starter med stort bogstav hopper man videre til den nedestående foreach løkke.
            {
                foreach(string s in exceptions)             // Foreach løkke der iterere gennem array'et exceptions.
                {
                    if(name == s)                           // En if sætning med betingelse om at hvis ikke name parametren starter med stort bogstav,
                    {                                       // så skal det være en exception, også hopper den ned og returneres true.
                        return true;
                    }
                }
                return false;                               // Hvis name ikke starter med stort bogstav eller er en exception, så hopper den ud af foreach løkken
            }                                               // og returneres false.

            return true;                                    // Hvis name starter med stort bogstav, så springer den helt over else og returneres true.
        }
    }
}
                        