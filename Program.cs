using System;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100) {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                bool fizzbuzz = fizz && buzz;
                if (fizzbuzz) {
                    Console.WriteLine("FizzBuzz");
                } else if (buzz) {
                    Console.WriteLine("Buzz");
                } else if (fizz) {
                    Console.WriteLine("Fizz");
                } else {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
