using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The time is now " + DateTime.Now);
            Console.WriteLine("Enter a number");
            int entTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + entTime + " Hours the time will be " + (DateTime.Now.AddHours(entTime)));
            Console.ReadLine();
          
        }
    }
}
