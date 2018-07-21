using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " Equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}




            List<int> dNum = new List<int>
            {
                5,
                10,
                14,
                20,
                22
            };

            try
            {
                Console.WriteLine("Enter a number.");
                int num = Convert.ToInt32(Console.ReadLine());

                foreach (int thing in dNum)
                {
                    Console.WriteLine(thing / num);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by zero isn't possible under the current universe' rules");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Expected a number, got a word instead.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong and I don't know whatm email the instructor!");
            }
            
            Console.ReadLine();


        }
        
    }
}
