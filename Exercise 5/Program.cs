using System;

namespace Exercise_5
{
    class Program
    {
        static void Main()
        {
            //Hi James, You had several syntax errors in the code below. I added some comments to help you out.
            //You seem to be consistently missing the "Console." on operation in the Console class--for example Write should be Console.Write
            //You can find more info on that here: https://docs.microsoft.com/en-us/dotnet/api/system.console?view=net-5.0
            //You also got the formatting a little mixed up on your Convert.
            //I hope these comments are helpful -- let me know if you have questions.

            string name;
            //You're not using secondSting anywhere else -- do you need it?
            string firstString; //, secondSting;
            int first, second, product;
            //Syntax missing "Console." also missing a closing quotation.
            Console.Write("Enter your name >> ");
      
            //Syntax missing "Console." and Parentheses needed after ReadLine
            name = Console.ReadLine();
            
            //Syntax missing "Console."
            Console.Write("Hello, {0}! Enter an integer >> ", name);
           
            //Syntax missing "Console."
            firstString = Console.ReadLine();

            //Missing "." between Convert and ToInt32
            first = Convert.ToInt32(firstString); 

            //Missing "Console."
            Console.Write("Enter another integer >> ");
            
            //Missing "Console." Must declare data type for secondString. Line must have a capital L in "ReadLine"
            string secondString = Console.ReadLine();

            //"ToInt" is not a valid conversion. I changed it to ToInt32
            second = Convert.ToInt32(secondString);
            product = first * second;

            //Missing "Console." Also, you need to start your count with {0} rather than {1}
            Console.WriteLine("Thank you, {0}. The product of {1} and {2} is {3}.",
           name, first, second, product);
        }

    }
}
