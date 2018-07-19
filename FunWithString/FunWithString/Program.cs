using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunWithString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Name Here");
            string Name = Console.ReadLine();
            string date = DateTime.Today.ToShortDateString();

          
            string Example = $"Hello {Name}. Today is {date}.";
            System.Console.WriteLine(Example);
            Console.WriteLine(Example = Example.ToUpper());
            Console.ReadLine();



            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, my name is "+ Name);
            sb.Append("I am learning how to use StringBuilder");
            sb.Append("So far I seem to be figuring it out.");
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
