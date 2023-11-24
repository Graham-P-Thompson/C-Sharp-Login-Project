// Graham Thompson 28/02/23 Login Project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    internal class RegisterAccount
    {
        public static void RegisterNewAccount()
        {
            // gets new username and password then appends to accounts.txt.
            string newUser = Login.GetUsername();
            string newPassword =  "";

            Console.WriteLine("\nWould you like a password generated for you Y/N?");
            string generateChoice = Console.ReadLine().ToLower().Trim();

            while (generateChoice != "y" && generateChoice != "n")
            {
                Console.WriteLine("\nIncorrect input please enter Y/N.");
                generateChoice = Console.ReadLine().ToLower().Trim();
            }
            if (generateChoice == "n")
            {
                newPassword = Login.GetPassword();
            }
            else
            {
                newPassword = PasswordGenerator();
            }
            string userComplete = newUser + " " + newPassword;
            FileAccess.AppendToFile(userComplete);

            Console.WriteLine($"\nYour username is {newUser}");
            Console.WriteLine($"Your password is {newPassword}");
        }
        
        static string PasswordGenerator()
        {
            // Generates a random password from a list of characters and returns a string of specified length.
            // seperated password characters into strings containing the same type, this reads better and will
            // be easier to maintain
            int passLength = GetPasswordLength();
            int passType = GetPasswordType();
            string passNums = "0123456789";
            string passSymbols = "!@#$%^&*~?";
            string passLetters = "abcdefghijklmnopqrstuvwxyz";
            string typeChoice = passNums + passSymbols + passLetters;
            string generatedPassword = "";
            
            if (passType == 1)
            {
                typeChoice = passNums;
            }
            else if (passType == 2)
            {
                typeChoice = passSymbols;
            }
            else if (passType == 3)
            {
                typeChoice = passLetters;
            }

            Random ran = new Random();

            for (int i = 0; i < passLength; i++)
            {
                int c = ran.Next(0, typeChoice.Length);
                generatedPassword += typeChoice[c];
            }
            return generatedPassword;
        }

        static int GetPasswordLength()
        {
            // Gets password length and returns it.
            int lenChoice = 0;

            Console.WriteLine("\nPlease choose the password length or 0 for default length: ");
            string lengthChoice = Console.ReadLine().Trim();

            while (!(int.TryParse(lengthChoice, out lenChoice)))
            {
                Console.WriteLine("\nIncorrect input please enter a number: ");
                lengthChoice = Console.ReadLine();
            }
            if (lenChoice == 0)
            {
                lenChoice = 10;
            }
            return lenChoice;
        }

        static int GetPasswordType()
        {
            // Gets users choice for the type of generated password they want.
            int passwordType = 0;

            Console.WriteLine("\nPlease select 1 for numbers, 2 for symbols, 3 for Letters, 4 for mixed: ");
            int.TryParse(Console.ReadLine(), out passwordType);

            while (passwordType < 1 || passwordType > 4)
            {
                Console.WriteLine("\nIncorrect input please enter a numbers 1-4: ");
                int.TryParse(Console.ReadLine(), out passwordType);
            }
     
            return passwordType;
        }
    }
}