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
            Employee employee = new Employee();
            employee.SayName("Sample", "Student");
            IQuittabl quittabl = new Employee();
            employee.Quit("Sample", "Student");

        }

    }
}
