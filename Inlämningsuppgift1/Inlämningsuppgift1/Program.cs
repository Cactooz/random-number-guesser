using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomNumber = generator.Next(1, 100);
            int number = 0;
            Console.WriteLine(randomNumber);
            while (number != randomNumber)
            {
                Console.WriteLine("Skriv ett tal mellan 1 till 100: ");
                int number = int.Parse(Console.ReadLine());
                if (number > randomNumber)
                    Console.WriteLine("Det gissade talet är för högt");
                if (number < randomNumber)
                    Console.WriteLine("Det gissade talet är för lågt");
            }
        }
    }
}
