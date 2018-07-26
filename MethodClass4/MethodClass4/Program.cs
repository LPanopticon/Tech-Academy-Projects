using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int input1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another integer");
            //int input2 = Convert.ToInt32(Console.ReadLine());

            DoAThing doAThing = new DoAThing();
            int result1 = doAThing.Math(input1);
            Console.WriteLine(result1);
            Console.ReadLine();
            // when the Writeline and input2 variable are commented out, then the 
            //optional second variable works and adds 2 to the input
        }
    }
}
