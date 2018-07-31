using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass6
{
    class Program
    {
        static void Main(string[] args)       
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine().ToString();

            if (int.TryParse(input, out int temp1))
            {
                AndAnotherThing.Math(temp1);
            }
            else if (decimal.TryParse(input, out decimal temp2))
            {
                AndAnotherThing.Math(temp2);
            }
            else Console.WriteLine("This not an int or decimal");
            Console.ReadLine();


        }
    }
}
