// Graham Thompson 28/02/23 Login Project.

using System.Reflection.Metadata;

namespace LoginProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu.Menu();

            while (true) 
            // Updated to while true and removed the last else clause for catching incorrect input
            // this works because if none of the conditions are met it will just keep looping.
            // Removed MainMenuReturn assignment to menuNumber
            {
                int menuNumber = MenuInput(); // moved inside loop

                if (menuNumber == 1)
                {
                    if (Login.ValidateLogin())
                    {
                        Console.WriteLine("\nLogin successful");
                    }
                    else
                    {
                        Console.WriteLine("\nLogin failed please check input and try again");
                    }
                    MainMenuReturn();
                }
                else if (menuNumber == 2)
                {
                    RegisterAccount.RegisterNewAccount();
                    MainMenuReturn();
                }
                else if (menuNumber == 3)
                {
                    Console.WriteLine("\nDisplay stored account information selected\n");
                    string[] content = FileAccess.GetFileContent();
                    foreach (string line in content)
                    {
                        if (line != null)
                        {
                            Console.WriteLine($"{line}");
                        }
                    }
                    MainMenuReturn();
                }
                else if (menuNumber == 4)
                {
                    Console.WriteLine("The application will now close after 2 seconds. Goodbye!");
                    Thread.Sleep(2000);
                    break;
                }
            }
        }

        public static int MenuInput()
        {
            int menuChoice = 0;

            Console.WriteLine("\nPlease choose a menu option by entering numbers 1 - 4: ");
            string menuNavi = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(menuNavi, out menuChoice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect input please enter numbers between 1 - 4: ");
                    menuNavi = Console.ReadLine();
                }
            }
            return menuChoice;
        }

        public static void MainMenuReturn() // removed return MenuInput and set to void
        {
            Console.WriteLine("\nNavigating back to main menu...");
            Thread.Sleep(500);
            DisplayMenu.Menu();
        }
    }
}