using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethodsSummary
{
    public static class StringExtension
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            var words = str.Split(' ');

            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords should be equal or greater than 0.");
            }
            else if (numberOfWords == 0)
            {
                return "";
            }
            else if (words.Length <= numberOfWords)
            {
                return str;
            }
            else
            {
                return string.Join(" ", words.Take(numberOfWords)) + " ...";
            }
        }
    }
}
