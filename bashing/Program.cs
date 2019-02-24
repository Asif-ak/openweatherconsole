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
            while (true)
            {
                var input = string.Empty;
                
                Console.WriteLine("Please enter City name or type 'exit' to close: ");
                input = Console.ReadLine();
            
                if (input == "exit")
                {
                    Environment.Exit(0); 
                }
                else
                {
                    Console.WriteLine($"http://api.openweathermap.org/data/2.5/weather?q={input}&APPID=19d6660a63ed6e4d36b2d6fdd9237042".Bashing());
                    Console.WriteLine("\n");
                    Console.WriteLine("Do u want to continue[y/n]");
                    if(Console.ReadLine()=="n") break;
                
                }
                
            }

        }
        
    }
}
