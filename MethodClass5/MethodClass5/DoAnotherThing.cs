using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass5
{
    class DoAnotherThing
    {
        public static int Math(int _userInput1 = 2, int _userInput2 = 2, params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return _userInput2;
        }




        //(int _userInput1 = 2, int userInput2 = 2)
        //{
        //    int result = userInput2;
        //    return result;
        //}
    }
}
