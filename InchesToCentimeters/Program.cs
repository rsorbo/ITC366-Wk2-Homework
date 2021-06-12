using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare constant that inches are 2.54cm
            //Establish variable for inches
            const double CENTIMETERSPERINCH = 2.54;
            double inch = 12;

            //Perform the calculation
            double convertInch = inch * CENTIMETERSPERINCH;

            //Display the output
            Console.WriteLine("Exercise 1");
            Console.WriteLine($"{inch} inches is {convertInch} centimeters.");

        }
    }
}
