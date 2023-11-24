// Graham Thompson 28/02/23 Login Project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    internal class UserInputValidation 
    {
        public static string RemoveWhiteSpace(string userInput)
        {
            // Methord to remove whitespace from strings.

            string noWhiteSpace = "";

            foreach (char c in userInput)
            {
                if (!(c == ' ' || c == '\t' || c == '\n'))
                {
                    noWhiteSpace += c;
                }
            }

            return noWhiteSpace;

        }
    }
}