﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundSharp {
    class mainClass {

        /* Integers: Usage for the attempt check system */
        public static int attempt = 1;
        public static int maxAttempts = 3;

        /* string: Returns name into the whole system */
        static string name;

        /* Easter egg: It's ya boi easter egg muhahaha... */
        private static void easterEgg() {
            while (true) {
                Console.WriteLine("It's ya boi easteregg.");
                Console.Clear();
                Random r = new Random();
                int i = r.Next(0, 16);
                switch (i) {
                    case 0:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;

                    case 1:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;

                    case 2:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;

                    case 3:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;

                    case 4:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;

                    case 5:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        break;

                    case 6:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;

                    case 7:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        break;

                    case 8:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        break;

                    case 9:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;

                    case 10:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;

                    case 11:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        break;

                    case 12:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;

                    case 13:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        break;

                    case 14:
                        Console.WriteLine("It's ya boi easter egg.");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;

                    case 15:
                        Console.WriteLine("It's ya boi easteregg.");
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        /* Function: Main, if user is logged in show menu and so on */
        public static void Main(string[] args) {
            Console.Title = "SoundSharp";
            Console.WriteLine("Vul je naam in:");
            name = Console.ReadLine();

            Boolean isLoggedIn;
            isLoggedIn = logIn();
            if (isLoggedIn == true) {
                showMenu();
                readKey();
            } else {
                Console.WriteLine("Je hebt geen pogingen meer! Druk op een toets om af te sluiten.");
            }
            Console.ReadKey();
        }

        /* Function: Login (name, attempts and password check) */
        static Boolean logIn() {
            Console.WriteLine("Hallo chef {0}, vul je wachtwoord in:", name);
            string input;

            do {
                input = Console.ReadLine();
                attempt++;

                if (input == "123") {
                    Console.Clear();
                    return true;
                } else if (attempt == maxAttempts) {
                    Console.WriteLine("Dit is je laatste poging:");
                } else if (attempt > 1 && attempt < maxAttempts) {
                    Console.WriteLine("Poging {0} van {1}:", attempt, maxAttempts);
                }
            } while (attempt < maxAttempts + 1);
            return false;
        }

        /* Function: Shows the menu */
        public static void showMenu() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("#################################### Welkom bij het SoundSharp hoofdmenu, {0}! ####################################", name);
            Console.WriteLine("#######################################################################################################################");
            Console.ResetColor();
            Console.WriteLine("1. MP3 spelers bekijken");
            Console.WriteLine("2. Voorraad bekijken");
            Console.WriteLine("3. Voorraad muteren");
            Console.WriteLine("4. menu-item");
            Console.WriteLine("5. menu-item");
            Console.WriteLine("6. menu-item");
            Console.WriteLine("7. menu-item");
            Console.WriteLine("8. Terug naar het menu");
            Console.WriteLine("9. Programma verlaten");
        }

        /* Function: Reads the key for the menu function described as above and goes to the function that is assigned to the key */
        static void readKey() {
            while (true) {
                ConsoleKeyInfo key = Console.ReadKey();
                char choice = Convert.ToChar(key.Key);
                
                switch (choice) {
                    case '0':
                        easterEgg();
                        break;

                    case '1':
                        Console.Clear();
                        MPShowList();
                        break;

                    case '2':
                        Console.Clear();
                        showStock();
                        break;

                    case '3':
                        Console.Clear();
                        changeStock();
                        break;

                    case '4':
                        Console.Clear();
                        showStatistics();
                        break;

                    case '5':
                        Console.Clear();
                        addMpPlayer();
                        break;

                    case '6':
                        Console.Clear();
                        Console.WriteLine("Dit doet niks, maar je kan het proberen...");
                        break;

                    case '7':
                        Console.Clear();
                        Console.WriteLine("Dit doet niks, maar je kan het proberen...");
                        break;

                    case '8':
                        Console.Clear();
                        showMenu();
                        break;

                    case '9':
                        Console.Clear();
                        Console.WriteLine("Het programma wordt afgesloten, druk op een toets om door te gaan!");
                        return;

                    default:
                        Console.Clear();
                        showMenu();
                        break;
                }
            }
        }

        /* List: Creates a list with items */
        public static List<MPlayers> MPlist = new List<MPlayers> {
        new MPlayers(1, 500, "GET technologies .inc", "HF 410", 4096, 129.95),
        new MPlayers(2, 500, "Far & Loud", "XM 600", 8192, 224.95),
        new MPlayers(3, 500, "Innotivative", "Z3", 512, 79.95),
        new MPlayers(4, 500, "Resistance S.A", "3001", 4096, 124.95),
        new MPlayers(5, 500, "CBA", "NXT volume", 2048, 159.05),
        };

        /* Function: Shows information from the list about the MP3 players */
        public static void MPShowList() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MP3 spelers die in het systeem staan:");
            Console.ResetColor();
            foreach (MPlayers item in MPlist) {
                Console.WriteLine("ID: " + item.PlayerID + "\nVoorraad: " + item.PlayerStock + " stuks\nMerk: " + item.PlayerMake + "\nModel: " + item.PlayerModel + "\nGrootte: " + item.PlayerMB + " MB \nPrijs: " + item.PlayerPrice + " euro \n");
            }
        }

        /* Struct: Well... as the name says a struct */
        public struct MPlayers {
            public int PlayerID;
            public int PlayerStock;
            public String PlayerMake;
            public String PlayerModel;
            public float PlayerMB;
            public double PlayerPrice;

            /* Constructor: Reads the struct and give it's directions */
            public MPlayers(int PlayerID, int PlayerStock, String PlayerMake, String PlayerModel, float PlayerMB, double PlayerPrice) {
                this.PlayerID = PlayerID;
                this.PlayerStock = PlayerStock;
                this.PlayerMake = PlayerMake;
                this.PlayerModel = PlayerModel;
                this.PlayerMB = PlayerMB;
                this.PlayerPrice = PlayerPrice;
            }
        }

        /* Function: Shows the stock (only ID and stock) */
        public static void showStock() {
            Console.WriteLine("Voorraad weergave");
            foreach (MPlayers item in MPlist) {
                Console.WriteLine("ID: " + item.PlayerID + "\nVoorraad: " + item.PlayerStock + " stuks\n");
            }
        }

        /* Function: Change the stock of available MP players */
        public static void changeStock() {

        }

        /* Function: Add a MP player to the system */
        public static void addMpPlayer() {
            /* Adds MP player function here */
        }

        /* Function: Show the statistics of all the available MP players ex. average of all MP players */
        public static void showStatistics() {
            Console.WriteLine("Totale statistieken:");
            

        }
    }
}