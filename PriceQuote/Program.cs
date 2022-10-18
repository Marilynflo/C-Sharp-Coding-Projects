using System;

namespace PriceQuote
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine(" Please enter the package weight:");

            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                System.Environment.Exit(0);

            }

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());


            int packageDimension = packageWidth + packageLength + packageHeight;

            if (packageDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                System.Environment.Exit(0);
            }
            else
            {

                float priceQuote = packageHeight * packageWidth * packageLength * packageWeight / 100;
                
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + priceQuote);
                Console.WriteLine("Thank you for your business!");
                Console.Read();

            }
        }
    }
}
