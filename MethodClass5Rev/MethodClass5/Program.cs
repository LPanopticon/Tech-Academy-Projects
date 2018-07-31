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

     

            DoAnotherThing doAnotherThing = new DoAnotherThing();
            DoAnotherThing.Math(5, 86);
            DoAnotherThing.Math(5);
            Console.WriteLine("------------------------");
            DoAnotherThing.Math(6, 8, 9, 10, 11);  //Now there will be things in values
            Console.ReadLine();

        }
    }
}
    

