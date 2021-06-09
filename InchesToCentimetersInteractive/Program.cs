using System;

namespace InchesToCentimetersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gathering the input
            System.Console.WriteLine("Exercise 2");
            System.Console.WriteLine("Please provide your inches");
            string input = Console.ReadLine();

            //Declaring the constant and variable
            const double CENTIMETERSPERINCH = 2.54;
            double inch = Convert.ToDouble(input);

            //Convert the input to usable data
            double convertCM = inch * CENTIMETERSPERINCH;

            //Output
            Console.WriteLine($"{inch} inches is {convertCM} centimeters.");
        }
    }
}