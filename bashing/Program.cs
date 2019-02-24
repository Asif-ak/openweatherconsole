using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Mime;

namespace bashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var link =
                $"http://api.openweathermap.org/data/2.5/weather?q={input}&APPID=19d6660a63ed6e4d36b2d6fdd9237042";
            Console.WriteLine("Please enter City name or type 'exit' to close: ");
            input = Console.ReadLine();
            
            if (input == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(link.Bashing());
                Console.WriteLine("\n");
                Console.WriteLine("Do u want to continue[y/n]");
                
            }

        }
        
    }
}
