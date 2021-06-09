using System;

namespace Planet
{
    class Program
    {
        enum Planet
        {
            MERCURY, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
        }
        static void Main(string[] args)
        
        {
            //Greet the user, collect input
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter a number to see the planet at that position, then press Enter.");
            string selection = Console.ReadLine();
            Convert.ToInt32(selection);

            //
            Console.WriteLine($"You entered {selection}");
            


        }
    }
}
