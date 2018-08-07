using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() {FirstName = "Sample", LastName = "Student", Id = 2 };
                    
            Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 2 };
           


            if  (employee1 == employee2)
            {
                Console.WriteLine("Duplicate data detected");
            }
            else
            {
                Console.WriteLine("Cool");
            }
            Console.ReadLine();

        }


    }
}
//IQuittabl quittabl = new Employee();
//employee.Quit("Sample", "Student"); 