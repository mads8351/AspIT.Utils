using System;
using System.Text.RegularExpressions;

namespace AspIT.Utils
{
    /// <summary>
    /// Provides extension methods for <see cref="System.String"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether or not the provided string starts with an upper case letter.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to test.</param>
        /// <returns>A <see cref="bool"/> indicating whether or not the provided <see cref="string"/> starts with an upper case letter.</returns>
        public static bool StartsWithUppercase(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            const string pattern = "^[A-Z]";
            return Regex.IsMatch(value, pattern);
        }
    }
}