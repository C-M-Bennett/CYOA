using System;
using Pastel;
using Color = System.Drawing.Color;
using Figgle;


// colour examples:
// Console.WriteLine("Yay colours!".Pastel("#cf2be9"));
// Console.WriteLine($"TEST! Press {"ENTER".Pastel(Color.FromArgb(165, 229, 250))} to continue");

//yellow = 207, 153, 6
//orange = 209, 85, 19
//teal = 9, 176, 148

namespace CYOA
{
    class TitleScreen
    {
        public static void StartGame()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Graceful . Render("Cat Your Own Adventure"));
            Console.WriteLine("\nWelcome to Cat Your Own Adventure!");
            Console.WriteLine($"\nTo make your choice, please type the {"HIGHLIGHTED".Pastel(Color.FromArgb(207, 153, 6))} word that indicates what you want to do at each stage followed by the 'enter' key.");
            Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"
            /\_/\
            >^,^<  ,
             / \   /
            (___)_/
            ".Pastel(Color.FromArgb(207, 153, 6)));
            Console.WriteLine("You are a cat. \nAnd it truly is a cat's life.");
            Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
            Console.ReadLine();
            Console.Clear();

        }


        public static void EndGame()
        {
            Console.Clear();
            Console.WriteLine(@"
/\_/\
>^,^<      Congratulations!
 / \   /   
(___)_/
            ".Pastel(Color.FromArgb(207, 153, 6)));
            NewGame();
        }


        public static void NewGame()
        {
            Console.WriteLine("Would you like to try another of your 9 lives?".Pastel(Color.FromArgb(209, 85, 19)));
            Console.WriteLine("Press 'Y' to have another go, Press 'N' to quit.".Pastel(Color.FromArgb(9, 176, 148)));
            string newGame = Console.ReadLine().ToUpper();

            switch (newGame)
            {
                case "Y":
                case "YES":
                    TitleScreen.StartGame();
                    break;

                case "N":
                case "NO":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Sorry, did you say something?");
                    NewGame();
                    break;
            }

        }
    }
}
