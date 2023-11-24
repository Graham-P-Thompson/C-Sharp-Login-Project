// Graham Thompson 28/02/23 Login Project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    internal class DisplayMenu
    {
        public static void Menu()
        {
            Console.WriteLine("\n\nMain menu");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.WriteLine("|                                  |");
            Console.WriteLine("|  1. Login                        |");
            Console.WriteLine("|  2. Register                     |");
            Console.WriteLine("|  3. View accounts                |");
            Console.WriteLine("|  4. Exit                         |");
            Console.WriteLine("|                                  |");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
        }
    }
}
