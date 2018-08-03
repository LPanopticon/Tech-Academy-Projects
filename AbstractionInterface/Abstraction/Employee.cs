using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee : Person, IQuittabl
    {
        public override void SayName(string FirstName, string LastName)
        {
            Person employee = new Employee();           
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();

        }

        public void Quit(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName +" Has Quit");
            Console.ReadLine();
        }
    }
}
