using System;
using System.Linq.Expressions;

namespace bashing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter City name: ");
                var input = Console.ReadLine();
                if(input=="exit") break;
                else
                {
                    Console.WriteLine($"http://api.openweathermap.org/data/2.5/weather?q={input}&APPID=19d6660a63ed6e4d36b2d6fdd9237042".Bashing());
                    Console.Read();
                }
                break;
                
            }
        }
        
    }
}
