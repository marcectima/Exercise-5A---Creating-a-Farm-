using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {

        public static void Main(string[] args)
        {
            //System.Threading.Timer timer = new System.Threading.Timer(multiply, 10, 1, 1000);
            //Console.ReadLine();

            // Classes
            Cats cat = new Cats();
            Tools tool = new Tools();
            Cows cow = new Cows();
            Dogs dog = new Dogs();
            Farmer farmer = new Farmer();
            Horses horse = new Horses();
            Pigs pig = new Pigs();
         int x, y;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Nester's Farm");
            Console.ReadKey();
            MainMenu();
            Console.Clear();
            void MainMenu()
            {
                bool keeplooping = true;
                do
                {
                    int z;
                    Console.WriteLine("                " + " Nester's Farm \n" +
                        "\n" +
                        "Choose where your option \n" +
                        "1. Satus \n" +
                        "2. Animanls \n" +
                        "3. Farm \n" +
                        "3. Leave Nester's Farm");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (z == 1)
                    {
                        //Status();
                    }
                    else if (z == 2)
                    {
                        Animal();
                    }
                    else if (z == 3)
                    {
                        //TheFarm();
                    }
                    else if (z == 4)
                    {
                        Console.WriteLine("You decided to leave Nester's Farmer");
                        Console.ReadKey();
                        keeplooping = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }

            void Animal()
            {
                Console.WriteLine("                         " + " Animals \n" +
                    "\n" +
                    "Here in Nester's Farm we have the world's greatest animals. \n" +
                    "Choose the animals you would like to visit \n" +
                    "1. Cats\n" +
                    "2. Cows\n" +
                    "3. Dogs\n" +
                    "4. Horses\n" +
                    "5. Pigs \n" +
                    "6. Return to the Main Menu ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (x == 1)
                {
                    cat.Main();
                }
                else if (x == 2)
                {
                    cow.Main();
                }
                else if (x == 3)
                {
                    dog.Main();
                }
                else if (x == 4)
                {
                    horse.Main();
                }
                else if (x == 5)
                {
                    pig.Main();
                }
                else if (x == 6)
                {
                    MainMenu();
                }
                {
                    Console.WriteLine("Invalid Entry");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void oh()
            {
                int c;
                c = 10;
                while (c > 20)
                {
                    Console.WriteLine(c);
                    Console.ReadKey();
                    c--;
                }
            }
        }          
    }
}
    
         
