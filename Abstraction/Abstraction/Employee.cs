using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee : Person
    {
        public override void SayName(string FirstName, string LastName)
        {
            Person employee = new Employee();           
            Console.WriteLine("Name: " + FirstName + LastName);
            Console.ReadLine();

        }
    }
}
