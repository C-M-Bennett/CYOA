using System;
using System.Collections.Generic;
using System.Text;

namespace CYOA
{
    class Choices
    {
//choice 1

        public static void Choice1()
        {
            Console.WriteLine("You are a cat. \nAnd it truly is a cat's life. \n\nYou can stay in the HOUSE, wander in the GARDEN or head to the ROAD.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Where do you go?\n");
            Console.ResetColor();

            string choice1 = Console.ReadLine().ToUpper();

            switch (choice1)
            {
                case "ROAD":
                    Console.WriteLine("You head towards the busy road.");
                    Console.WriteLine("Do you quickly RUN or carefully WALK across?");
                    Console.ReadLine();
                    break;

                case "GARDEN":
                    Console.WriteLine("You head towards the sunny garden.");
                    Console.WriteLine("Do you walk in the GRASS or explore the SHED?");
                    Console.ReadLine();
                    break;

                case "HOUSE":
                    Console.WriteLine("You stay inside the cosy house and hear a noise...");
                    Console.WriteLine("Do you ignore it and go to the WINDOW or do you INVESTIGATE?");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("That wasn't one of the options, try again!");
                    Console.ReadLine();
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
                    Console.WriteLine("You run across the road and make it halfway.");
                    Console.WriteLine("Do you quickly RUN the rest of the way or do you WALK carefully?");
                    Console.ReadLine();
                    break;

                case "WALK":
                    Console.WriteLine("You walk carefully to the middle of the road, watching for traffic.");
                    //repeat statement!
                    Console.WriteLine("Do you quickly RUN the rest of the way or do you WALK carefully?");
                    Console.ReadLine();
                    break;

                case "GRASS":
                    Console.WriteLine("You pad onto the freshly cut grass.");
                    Console.WriteLine("Do you LIE down in the sun or do you watch for BIRDS?");
                    Console.ReadLine();
                    break;

                case "SHED":
                    Console.WriteLine("You find yourself in a musty toolshed");
                    Console.WriteLine("Do you have a good SCRATCH at the wood or do you SNEAK around?");
                    Console.ReadLine();
                    break;

                case "WINDOW":
                    Console.WriteLine("The windowsill is lovely and sunny");
                    Console.WriteLine("You lie down in the sun and fall asleep as a cat is wont to do.");
                    //End condition
                    Console.WriteLine("The End");
                    break;

                case "INVESTIGATE":
                    Console.WriteLine("You see a parcel has been posted through the door.");
                    Console.WriteLine("Do you SIT on it or do you TEAR at it?");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("That wasn't one of the options, try again!");

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



                