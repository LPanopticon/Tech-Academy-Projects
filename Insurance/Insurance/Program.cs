using System;


namespace Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insurance Qualification Test");
            Console.WriteLine("What is your age?");
            string custage = Console.ReadLine();
            int Age = Convert.ToInt32(custage);

            Console.WriteLine("True or False, have you ever had a DUI?");
            string custdui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(custdui);

            Console.WriteLine("How many speeding tickets do you have?");
            string custtickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(custtickets);

            bool qualified = Age > 15 & DUI == false & Tickets < 3;
            Console.WriteLine(qualified);
            Console.ReadLine();






        }
    }
}
