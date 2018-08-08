using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> empName = new List<string>()
            {
                "Logan",
                "Britadesco"
            };
            foreach (string name in empName)
            {
                Console.WriteLine(name);
                Console.ReadLine();
                    
            }
       
            List<int> empId = new List<int>()
            {
                1,
                2,
                3,
                4
                
            };
            foreach (int num in empId)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
    }
}
