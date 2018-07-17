using System;


namespace Bool
{
    class Program
    {
        static void Main()
            
        {
            Console.WriteLine("Please enter a number from one to five");
            int number = Convert.ToInt32(Console.ReadLine());
            bool goal = number == 5;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine(number);
                        number = number + 1;
                        break;

                    case 2:
                        Console.WriteLine(number);
                        number = number + 1;
                        break;

                    case 3:
                        Console.WriteLine(number);
                        number = number + 1;
                        break;

                    case 4:
                        Console.WriteLine(number);
                        number = number + 1;
                        break;

                    case 5:
                        Console.WriteLine(number);
                        goal = true;
                        break;
                }

            }
            while (!goal);
            
            Console.Read();
            //int number = 1;
            //bool goal = number == 5;

            //while (!goal)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine(number);
            //            number = number + 1;
            //            break;

            //        case 2:
            //            Console.WriteLine(number);
            //            number = number + 1;
            //            break;

            //        case 3:
            //            Console.WriteLine(number);
            //            number = number + 1;
            //            break;

            //        case 4:
            //            Console.WriteLine(number);
            //            number = number + 1;
            //            break;

            //        case 5:
            //            Console.WriteLine(number);
            //            goal = true;
            //            break;
            //    }
            //}
            //Console.Read();



        }
    }
}
