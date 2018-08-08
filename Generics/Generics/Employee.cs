using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee<T> : Person
    {
       

        public List<T> Things { get; set; }
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)

            {
                if (employee1.Id == employee2.Id) return true;
                else return false;



            }
            public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
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
        }
}
//public override void SayName(string FirstName, string LastName, int Id)
//{


//}        

//public override int ID(int Id)
//{          
//    return Id;
//}