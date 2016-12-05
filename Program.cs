using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp
{
    class MainClass
    {
        public static int attempt = 1;
        public static int maxAttempts = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Vul je naam in:");
            string name = Console.ReadLine();

            Boolean isLoggedIn;
            isLoggedIn = LogIn(name);
            if (isLoggedIn == true)
            {
                Menu();
            }
            else {
                Console.WriteLine("Je hebt geen pogingen meer! Druk op een toets om af te sluiten.");
            }
            Console.ReadKey();
        }

        static Boolean LogIn(string name)
        {
            Console.WriteLine("Hallo chef {0}, vul je wachtwoord in:", name);
            string input;
            do
            {
                input = Console.ReadLine();
                attempt++;

                if (input == "123")
                {
                    Console.Clear();
                    return true;
                }
                else if (attempt == maxAttempts)
                {
                    Console.WriteLine("Dit is je laatste poging:");
                }
                else if (attempt > 1 && attempt < maxAttempts)
                {
                    Console.WriteLine("Poging {0} van {1}:", attempt, maxAttempts);
                }
            } while (attempt < maxAttempts + 1);
            return false;
        }

        static void Menu()
        {
            Console.WriteLine("1. menu-item");
            Console.WriteLine("2. menu-item");
            Console.WriteLine("3. menu-item");
            Console.WriteLine("4. menu-item");
            Console.WriteLine("5. menu-item");
            Console.WriteLine("6. menu-item");
            Console.WriteLine("7. menu-item");
            Console.WriteLine("8. menu-item");
            Console.WriteLine("9. Programma verlaten");
        }

        static void MenuChoices()
        {
            while {

            }
        }
    }
}
