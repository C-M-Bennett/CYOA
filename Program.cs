using System;
using Pastel;
using Color = System.Drawing.Color;

namespace CYOA
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Title = "Cat Your Own Adventure";
            Console.WindowHeight = 50;
            Console.WindowWidth = 140;
            TitleScreen.StartGame();
            Choices.Choice1();
            Choices.Choice2();
            Choices.Choice3();
            Choices.Choice4();
            Choices.Choice5();
            Choices.Choice6();
            Choices.Choice7();
         
        }


    }
}
