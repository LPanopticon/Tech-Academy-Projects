using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass5
{
    class DoAnotherThing
    {
        public static void Math(int _userInput1 = 2, int _userInput2 = 2, params int[] values)
        {
            int sum = 0;
            
            foreach (int value in values)
            {
                sum += value;            
                Console.WriteLine(sum + " is the sum variable in the loop");
                Console.WriteLine(value.ToString() + " is a value variable");
                Console.WriteLine(values + " is in values in the loop"); //doesn't print correctly
                values.ToList().ForEach(Console.WriteLine); //doesn't print anything (nothing is in values)
            }
            int total = sum + _userInput1;
            values.ToList().ForEach(i => Console.WriteLine(i.ToString())); //doesn't print anything (nothing is in values)
            Console.WriteLine(values + " doesn't print values (real values or the parameter)");
            Console.WriteLine(sum + " is the sum variable");
            Console.WriteLine(_userInput2 + " is _userInput2");
            Console.WriteLine(total + " is the math operation on the first input required");
        }

    }
}
