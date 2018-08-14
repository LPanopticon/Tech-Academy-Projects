using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int entAge = Convert.ToInt32(Console.ReadLine());
                if (entAge < 1)
                {
                    throw new ArithmeticException();
                }
                else
                { 
                var DoB = DateTime.Now.AddYears(-entAge);
                Console.WriteLine("Your birth year is: " + DoB.Year);
                Console.ReadLine();
                }
            }
            
            catch (ArithmeticException)
            {
                Console.WriteLine("Please enter a positive number greater than zero");
                Console.ReadLine();
            }


           
            catch (Exception)
            {
                Console.WriteLine("There was a problem, it is a mystery what that is, go do something else for a while.");
                Console.ReadLine();
            }
        }
    }
}
