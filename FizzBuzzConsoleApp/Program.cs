using System;
using FizzBuzz.Library;
namespace FizzBuzzConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            foreach (var result in fizzBuzzService.GetFizzBuzz(100))
            {
                Console.WriteLine(result);
            }
        }
    }
}
