using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet the user and collect their input
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Please provide your temperature in Fahrenheit, then press Enter.");
            string FInput = Console.ReadLine();

            //Convert input from String to Double, Establish 1 Decimal Place
            double Fahrenheit = Convert.ToDouble(FInput);
            //Math.Round(Fahrenheit, 1);

            //Perform the calculation
            double Celsius = (Fahrenheit - 32) * 5 /9;
            
           
           //Display the results
            Console.WriteLine($"{Fahrenheit} F is {Math.Round(Celsius,1)} C.");



        }
    }
}
