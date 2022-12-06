using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string
            string regexPattern = @"\s";
            string regexResult = Regex.Replace(s, regexPattern, "");

            List<char> characters = new List<char>();

            foreach(char character in regexResult)
            {
                if (!characters.Contains(character))
                {
                    characters.Append(character)
                }
                else
                {
                    return false;
                }
            }
            // check for duplicate letters

            return true;
        }
    }
}
