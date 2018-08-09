using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStuff
{
    class Program
    {

        static void Main(string[] args)
        {
            var empList = new List<Employee>()
            {
                new Employee("Logan", "Britadesco", 1),
                new Employee("Joe", "Smith", 2),
                new Employee("Joe", "Johnson", 3),
                new Employee("Big", "McLargeHuge", 4),
                new Employee("Rolf", "Fizzlebeef", 5),
                new Employee("Brock", "Hardcheese", 6),
                new Employee("Bobsun", "Dognut", 7),
                new Employee("Punch", "Sideiron", 8),
                new Employee("Butch", "Deadlift", 9),
                new Employee("Slab", "Bulkhead", 10)
            };

            //with a standard foreach
            List<Employee> tempList = new List<Employee>();
            foreach ( Employee Employee in empList)
            {
                if (Employee.FirstName == "Joe")
                {
                    tempList.Add(Employee);
                    Console.WriteLine(Employee.FirstName);
                }
                
            }
            Console.ReadLine();

            //lambda function doing the same thing
            List<Employee> empList2 = empList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee Employee in empList2)
            {
                Console.WriteLine(Employee.FirstName);
            }
            Console.ReadLine();

            // Id's greater than 5
            List<Employee> empList3 = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee Employee in empList3)
            {
                Console.WriteLine(Employee.Id);
            }
            Console.ReadLine();

        }

    }
}