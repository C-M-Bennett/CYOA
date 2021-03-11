using System;
using Pastel;
using Color = System.Drawing.Color;

// colour examples:
// Console.WriteLine("Yay colours!".Pastel("#cf2be9"));
// Console.WriteLine($"TEST! Press {"ENTER".Pastel(Color.FromArgb(165, 229, 250))} to continue");

//yellow = 207, 153, 6
//orange = 209, 85, 19

namespace CYOA
{
    class Choices
    {

//choice 1
        public static void Choice1()
        {
            Console.WriteLine($"\n\nYou can stay in the {"HOUSE".Pastel(Color.FromArgb(207, 153, 6))}, wander in the {"GARDEN ".Pastel(Color.FromArgb(207, 153, 6))}or head to the {"ROAD".Pastel(Color.FromArgb(207, 153, 6))}.");
            Console.WriteLine($"{"Where do you go?\n".Pastel(Color.FromArgb(209, 85, 19))}\n");

            string choice1 = Console.ReadLine().ToUpper();

            switch (choice1)
            {
                case "ROAD":
                    Console.WriteLine("\nYou head towards the busy road.");
                    Console.WriteLine($"Do you quickly {"RUN".Pastel(Color.FromArgb(207, 153, 6))} or carefully {"WALK".Pastel(Color.FromArgb(207, 153, 6))} across?");
                    break;

                case "GARDEN":
                    Console.WriteLine("\nYou head towards the sunny garden.");
                    Console.WriteLine($"Do you walk in the {"GRASS".Pastel(Color.FromArgb(207, 153, 6))} or explore the {"SHED".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                case "HOUSE":
                    Console.WriteLine("\nYou stay inside the cosy house and hear a noise...");
                    Console.WriteLine($"Do you ignore it and go to the {"WINDOW".Pastel(Color.FromArgb(207, 153, 6))} or do you {"INVESTIGATE".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice1();
                    break;
            }
        }

//choice 2
        public static void Choice2()
        {
            string choice2 = Console.ReadLine().ToUpper();

            switch (choice2)
            {
                case "RUN":
                case "WALK":
                    Console.WriteLine("\nYou run across the road and make it halfway.");
                    Console.WriteLine($"Do you quickly {"RUN".Pastel(Color.FromArgb(207, 153, 6))} the rest of the way or do you {"WALK".Pastel(Color.FromArgb(207, 153, 6))} carefully?");
                    break;

                case "GRASS":
                    Console.WriteLine("\nYou pad onto the freshly cut grass.");
                    Console.WriteLine($"Do you {"LIE".Pastel(Color.FromArgb(207, 153, 6))} down in the sun or do you watch for {"BIRDS".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                case "SHED":
                    Console.WriteLine("\nYou find yourself in a musty toolshed");
                    Console.WriteLine($"Do you have a good {"SCRATCH".Pastel(Color.FromArgb(207, 153, 6))} at the wood or do you {"SNEAK".Pastel(Color.FromArgb(207, 153, 6))} around?");
                    break;
//End condition
                case "WINDOW":
                    Console.WriteLine("\nThe windowsill is lovely and sunny.");
                    Console.WriteLine("You lie down in the sun and fall asleep as a cat is wont to do.");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.EndGame();
                    break;

                case "INVESTIGATE":
                    Console.WriteLine("\nYou see a parcel has been posted through the door.");
                    Console.WriteLine($"Do you {"SIT".Pastel(Color.FromArgb(207, 153, 6))} on it or do you {"TEAR".Pastel(Color.FromArgb(207, 153, 6))} at it?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice2();
                    break;
            }
        }



//choice 2
        public static void Choice3()
        {
            string choice3 = Console.ReadLine().ToUpper();

            switch (choice3)
            {

            }
        }

    }
}



                