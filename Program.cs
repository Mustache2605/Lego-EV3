using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp
{
    class Program {
        static void Main(string[] args) {
            GetName();
            LogIn();
        }

        static void GetName() {
            Console.WriteLine("Wat is je naam?");

            Boolean setname = false;
            do {
                string name = Console.ReadLine();
                if (name == "") {
                    Console.WriteLine("Je hebt toch wel een naam chef? Voer op z'n minst iets in!");
                } else {
                    Console.WriteLine("Hallo chef " + name + ", wat is het wachtwoord?");
                    setname = true;
                }
            } while (setname == false);
        }

        static int attempts = 3;
        static void LogIn () {
            while (attempts > 0) {
                attempts--;

                string password = Console.ReadLine();
                if (password == "rip") {
                    Console.Clear();
                    Console.WriteLine("Welkom in SoundSharp, chef");
                } else if (attempts > 1) {
                    Console.WriteLine("Het ingevoerde wachtwoord is fout, je hebt nog {0} pogingen over!", attempts);
                }
            }

            
            if (attempts == 0) {
                Console.WriteLine("Je hebt geen pogingen meer, het programma wordt afgesloten!");
                Console.WriteLine("Druk op een toets om het programma af te sluiten.");
                Console.ReadKey();
            } else if (attempts == 0) {
                Console.WriteLine("Dit is je laatste poging! Anders wordt je /system32/ verwijderd.");
            }
        }
    }
}
