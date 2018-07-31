using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass6
{
    class AndAnotherThing
    {
        public static void Math(int userInput)
        {
            int result = userInput / 2;
            Console.WriteLine(result);
            Console.ReadLine();

        }

      
        public static void Math(decimal userInput)
        {
            decimal result = userInput / 2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
