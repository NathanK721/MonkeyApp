using System;
namespace MyMonkeyApp.Ui
{
    public static class DisplayHelper
    {
        // Show the header at startup
        public static void ShowHeader()
        {
            Console.WriteLine(AsciiArt.Header);
            Console.WriteLine("Welcome to MyMonkeyApp!");
            Console.WriteLine();
        }
        // Show monkey details with optional ASCII art
        public static void ShowMonkeyDetails(string name, int age, string favoriteFood, bool showArt = true)
        {
            if (showArt)
            {
                Console.WriteLine(AsciiArt.MonkeyDetail);
            }
            Console.WriteLine($"Monkey Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Favorite Food: {favoriteFood}");
            Console.WriteLine();
        }
    }
}
