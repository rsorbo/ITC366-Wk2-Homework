using System;

namespace Planet
{
    class Program
    {
        enum Planet
        {
            MERCURY, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE        }
        static void Main(string[] args)
        
        {
            //Greet the user, collect input
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter a number to see the planet at that position, then press Enter.");
            string selection = Console.ReadLine();
          

            //Output the result
            //I got a lot of help figuring out how to use the Enum.GetName from: https://www.c-sharpcorner.com/article/loop-through-enum-values-in-c-sharp/
            Console.WriteLine($"You entered {selection}");
            int planetNum = Convert.ToInt32(selection);
            Console.WriteLine($"{Enum.GetName(typeof(Planet), --planetNum)} is {selection} planet(s) from the sun. ");




        }
    }
}
