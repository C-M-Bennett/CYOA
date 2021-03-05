using System;


namespace CYOA
{
    class TitleScreen
    {
        public static void StartGame()
        {
            Console.WriteLine(@"
            /\_/\
            >^,^<  ,
             / \   /
            (___)_/
            ");
            Console.WriteLine("Welcome to Cat Your Own Adventure!");
            Console.WriteLine("\nTo make your choice, please type the highlighted word that indicates what you want to do at each stage.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
