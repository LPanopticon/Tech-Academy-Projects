using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter an integer");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another integer");
            //int input2 = Convert.ToInt32(Console.ReadLine());

            DoAnotherThing doAnotherThing = new DoAnotherThing();
            DoAnotherThing.Math();
            Console.WriteLine(DoAnotherThing.Math());
            Console.ReadLine();
          
        }
    }
}
    

