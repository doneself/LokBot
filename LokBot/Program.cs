using System;

namespace LokBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string myBirthTime = "2019/7/22 11:28:18";
            Console.WriteLine("My name is Lokbot.");
            Console.WriteLine($"I was both in {myBirthTime}");
            Console.WriteLine("What can I help you?");

            Console.WriteLine("Press the F12 key to quit:");
            Console.WriteLine("You can tell me something.");
            string result = string.Empty;
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        Console.WriteLine("You input noting.");
                    }
                    else
                    {
                        Console.WriteLine($"Your input is {result}.");
                    }
                    result = string.Empty;
                }
                else
                {
                    result += cki.KeyChar;
                }
            }
            while (cki.Key != ConsoleKey.F12);
            Console.WriteLine("Bye bye.");
        }
    }
}
