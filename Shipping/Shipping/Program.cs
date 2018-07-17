using System;


namespace Shipping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter package width");
            }
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter package height");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter package length");
            int length = Convert.ToInt32(Console.ReadLine());
            int totalsize = width + height + length;
            int quote = (totalsize * weight) / 100;

            if (totalsize > 50)
            {
                Console.WriteLine("Package is too large to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated shipping cost for this package is $" + quote);
            }
            Console.ReadLine();



        }
    }
}
