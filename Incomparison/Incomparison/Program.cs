using System;


namespace Incomparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person One");
            Console.WriteLine("Enter Person One Hourly Rate");
            string p1hour = Console.ReadLine();
            int PersonOneHourly = Convert.ToInt32(p1hour);

            Console.WriteLine("Enter Person One Hours Worked Per Week");
            string p1week = Console.ReadLine();
            int PersonOneWeekly = Convert.ToInt32(p1week);

            Console.WriteLine("Person Two");
            Console.WriteLine("Enter Person Two Hourly Rate");
            string p2hour = Console.ReadLine();
            int PersonTwoHourly = Convert.ToInt32(p2hour);

            Console.WriteLine("Enter Person Two Hours Worked Per Week");
            string p2week = Console.ReadLine();
            int PersonTwoWeekly = Convert.ToInt32(p1week);

            //The example instructions didn't actually result in a yearly salary, writing this so there is one now//
            int PersonOneYearly = PersonOneHourly * PersonOneWeekly * 52;
            Console.WriteLine("Persone One Yearly=" + PersonOneYearly);

            int PersonTwoYearly = PersonTwoHourly * PersonTwoWeekly * 52;
            Console.WriteLine("Person Two Yearly=" + PersonTwoYearly);

            Console.WriteLine("Does Person One Make More Money Than Person Two?");
            bool TrueFalse = PersonOneYearly > PersonTwoYearly;
            Console.WriteLine(TrueFalse);
            Console.Read();

            






        }
    }
}
