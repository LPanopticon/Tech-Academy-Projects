using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 500;
        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };
        //Console.WriteLine(numArray1[3]);
        //Console.ReadLine();

        string[] stringArray = { "Random", "Words", "For", "The", "Purpose", "Of", "This", "Exercise" };
        Console.WriteLine("Please enter a number from 0-7");
        int num = Convert.ToInt32(Console.ReadLine());
        bool entnum = num == 0 || num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 7;
        if (entnum)
        Console.WriteLine(stringArray[num]);

        else
            Console.WriteLine("That entry doesn't exist");
            Console.ReadLine();
        
       

        int[] intArray =  {1,3,5,7,11,13,17};
        Console.WriteLine("Please enter a number from 0-7");
        int entry = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray[entry]);
        Console.ReadLine();

        List<string> decks = new List<string>
        {
            "Mono-white",
            "Ghave",
            "Rainbow",
            "Dinosaurs",
            "Life-gain"
        };
        Console.WriteLine("Enter 0-5");
        int deck = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(decks[deck]);




    }
    }

