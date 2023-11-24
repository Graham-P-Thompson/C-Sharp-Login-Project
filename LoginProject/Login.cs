// Graham Thompson 28/02/23 Login Project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    internal class Login
    {
        public static string GetUsername()
        {
            // Methord to get username.

            Console.WriteLine("\nPlease enter your username: ");
            string username = Console.ReadLine();
            username = UserInputValidation.RemoveWhiteSpace(username);

            return username;
        }

        public static string GetPassword()
        {
            // Methord to get password.

            Console.WriteLine("\nPlease enter password: ");
            string password = Console.ReadLine();
            password = UserInputValidation.RemoveWhiteSpace(password);

            return password;
        }
        
        public static bool ValidateLogin()
        {
            // Methord to validate username and password with stored values in txt file.

            string user = GetUsername();
            string pass = GetPassword();
            string toValidate = user + " " + pass;
            string[] content = FileAccess.GetFileContent();
            bool result = false;
            foreach (string line in content)
            {
                if (toValidate == line)
                {
                    result = true;
                }
            }
            return result;
        } 
    }
}
