using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            Action actionOne = new Action
            {
                Number = Convert.ToInt32(Console.ReadLine())
            };
            actionOne.Add = actionOne.Number + 2;
            //actionOne.Subtract = actionOne.Number - 2;
            //actionOne.Multiply = actionOne.Number * 2;
            Console.WriteLine(actionOne.Add);
            //Console.WriteLine(actionOne.Subtract);
            //Console.WriteLine(actionOne.Multiply);
            Console.ReadLine();
            Action actionTwo = new Action
            {
                Number = (actionOne.Number)
            };
            actionTwo.Subtract = actionTwo.Number - 2;
            Console.WriteLine(actionTwo.Subtract);
            Console.ReadLine();
        }   
       
 
          
    }
}
