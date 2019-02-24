using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();

        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                id = 34,
                name = "",
                age = 473,
                HasGills = true,
                HomeSea = ""
            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                id = 56,
                name = "",
                age = 473,
                Galaxy = ""
                
            };
        }



        static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();

            do
            {
                Console.Clear();
                DisplayHeader("menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("3) Edit Sea Monster");
                Console.WriteLine("4) Edit Space Monster");
                Console.WriteLine("2) Exit");
                Console.WriteLine();
                Console.WriteLine(" Enter Selection");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    case 3:
                        DisplayEditSeaMonster(mySeaMonster);
                        break;
                    case 4: DisplayEditSpaceMonster(mySpaceMonster);
                        break;
                    default:
                        Console.WriteLine("Please enter a proper selection");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!exitMenu);

        }

        private static void DisplayEditSpaceMonster(SpaceMonster mySpaceMonster)
        {
            DisplayHeader("edit sea monster");
            Console.WriteLine($"what name would like your space monster: {mySpaceMonster.name} to be?");
            mySpaceMonster.name = Console.ReadLine();
            Console.WriteLine($"your name is now changed to: {mySpaceMonster.name}");
            Console.WriteLine();
            Console.WriteLine($"what is your home galaxy?:{mySpaceMonster.Galaxy}");
            mySpaceMonster.Galaxy = Console.ReadLine();
            Console.WriteLine($"your home galaxy is the: {mySpaceMonster.Galaxy}");
            DisplayContinuePrompt();
        }

        private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
        {
            DisplayHeader("edit sea monster");
           Console.WriteLine($"what name would like your sea monster: {mySeaMonster.name} to be?");
            mySeaMonster.name = Console.ReadLine();
            Console.WriteLine($"your name is now changed to: {mySeaMonster.name}");
            Console.WriteLine();
            Console.WriteLine($"what is your home sea:{mySeaMonster.HomeSea}");
            mySeaMonster.HomeSea = Console.ReadLine();
            Console.WriteLine($"your home sea is the:{mySeaMonster.HomeSea}");
            DisplayContinuePrompt();
        }

        private static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Info");
            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seaMonster);

            Console.WriteLine();

            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            DisplayContinuePrompt();
        }

        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.id}");
            Console.WriteLine($"name: {spaceMonster.name}");
            Console.WriteLine($"age: {spaceMonster.age}");
            Console.WriteLine($"galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is happy: {(spaceMonster.IsHappy() ? "yes" : "no")}");

            Console.WriteLine($"you attacked {spaceMonster.name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.id}");
            Console.WriteLine($"name: {seaMonster.name}");
            Console.WriteLine($"age: {seaMonster.age}");
            Console.WriteLine($"home sea: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills?{(seaMonster.HasGills ? "yes" : "no")}");
            Console.WriteLine($"Is happy: {seaMonster.IsHappy()}");
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to My App");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank You For using My App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headText);
            Console.WriteLine();
        }

    }
}
