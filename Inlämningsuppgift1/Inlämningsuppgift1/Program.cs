using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomTal = generator.Next(1, 100);
            while (tal != randomTal)
            {
                Console.WriteLine("Skriv ett tal mellan 1 till 100: ");
                int tal = int.Parse(Console.ReadLine());
                if (tal > randomTal)
                    Console.WriteLine("Det gissade talet är för högt");
                if (tal < randomTal)
                    Console.WriteLine("Det gissade talet är för lågt");
            }



        }
    }
}