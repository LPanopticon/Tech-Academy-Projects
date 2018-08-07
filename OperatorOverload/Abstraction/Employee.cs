using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee : Person
    {
        
        //public override void SayName(string FirstName, string LastName, int Id)
        //{
         

        //}        
   
        //public override int ID(int Id)
        //{          
        //    return Id;
        //}

        public static bool operator ==(Employee employee1, Employee employee2)

        {
            if (employee1.Id == employee2.Id) return true;
            else return false;
          


        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id) return true;
            else return false;
            
        }
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }







        //public void Quit(string FirstName, string LastName)
        //{
        //    Console.WriteLine(FirstName + " " + LastName +" Has Quit");
        //    Console.ReadLine();
        //}
    }
}
