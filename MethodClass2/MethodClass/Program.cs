using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass2
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            Action actionOne = new Action
            {
                Number = Console.Read()
            };
            Console.ReadLine();
            actionOne.Add = Convert.ToInt32(actionOne.Number + 2);
            actionOne.Subtract = Convert.ToDecimal(actionOne.Number - 2.5);
            actionOne.Multiply = Convert.ToInt32(actionOne.Number * 2);
            Console.WriteLine(actionOne.Add);
            Console.WriteLine(actionOne.Subtract);
            Console.WriteLine(actionOne.Multiply);
            Console.ReadLine();
        }
       

 
          
    }
}
