using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //    int[] testscores = { 99, 98, 94, 80, 100, 30, 44, 78, 99 };

        //    for (int i = 0; i < testscores.Length; i++)
        //    {
        //        if (testscores[i] > 85)
        //        {
        //        Console.WriteLine("Passing test score: " + testscores[i]);
        //        }
        //    }
        //Console.ReadLine();

        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Logan")
        //    {
        //    Console.WriteLine(names[j]);
        //    }

        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(78);
        //testScores.Add(4);
        //testScores.Add(100);
        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Logan", "Zena", "Whitney", "Karl" };

        //foreach (string name in names)

        //    {
        //        Console.WriteLine(name);
        //    }

        //Console.ReadLine();

        //ASSIGNMENTS START HERE
        //
        //
        //
        //



        //// string that askes for input, then prints all elements with that input added
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Type a word");
        //string input = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //    Console.WriteLine(names[j] + input);
        //Console.ReadLine();


        ////infinite loop and fix
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Type a word");
        //string input = Console.ReadLine();
        //while(true)//while loop without any ending makes infinite, deleting fixes
        //for (int j = 0; j < names.Length; j++)
        //    Console.WriteLine(names[j] + input);
        //Console.ReadLine();


        //// < is the operator
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Type a word");
        //string input = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //    Console.WriteLine(names[j] + input);
        //Console.ReadLine();


        //// <= is the operator, added -1 to the names.Length and it functions the same
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Type a word");
        //string input = Console.ReadLine();

        //for (int j = 0; j <= names.Length -1 ; j++)
        //    Console.WriteLine(names[j] + input);
        //Console.ReadLine();


        ////Returns the index of the name entered
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Enter a name");
        //string input = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //    if (names[j] == input)
        //    {
        //        Console.WriteLine(j);
        //    }
        //Console.ReadLine();


        //As above with a message if name doesn't match
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Enter a name");
        //string input = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //    if (names[j] == input)
        //    {
        //        Console.WriteLine(j);
        //    }
        //    else Console.WriteLine("That is not a correct name");
        //Console.ReadLine();


        //// Added Break to stop when a match is found
        //string[] names = { "Logan", "Zena", "Whitney", "Karl" };
        //Console.WriteLine("Enter a name");
        //string input = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //    if (names[j] == input)
        //    {
        //        Console.WriteLine(j);
        //        break;
        //    }
        //    else Console.WriteLine("That is not a correct name");
        //Console.ReadLine();


        //// List with names that displays count of names entered by user
        //List<string> names = new List<string>() { "Logan", "Zena", "Adam", "Whitney", "Karl", "Adam" };
        //List<string> match = new List<string>() { };
        //Console.WriteLine("Enter a name");
        //string entname = Console.ReadLine();

        //foreach (string name in names)
        //{
        //    if (name == entname)
        //    {
        //        match.Add(entname);
        //    }
        //}
        //Console.WriteLine(match.Count);
        //Console.ReadLine();

        ////Message if no match found with entered sring
        //List<string> names = new List<string>() { "Logan", "Zena", "Adam", "Whitney", "Karl", "Adam" };
        //List<string> match = new List<string>() { };
        //Console.WriteLine("Enter a name");
        //string entname = Console.ReadLine();

        //foreach (string name in names)
        //{
        //    if (name == entname)
        //    {
        //        match.Add(entname);
        //        Console.WriteLine(match.Count);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No match");
        //    }
        //}
        //Console.ReadLine();

        //Final thingy
        List<string> names = new List<string>() { "Logan", "Zena", "Adam", "Whitney", "Karl", "Adam" };
        List<string> match = new List<string>() { };
        Console.WriteLine("Enter a name");
        string entname = Console.ReadLine();

        foreach (string name in names)
        {
            if (name == entname)
            {
                match.Add(entname);
                if (match.Count > 1)
                    Console.WriteLine(entname + " This name shows multiple times");
                else
                    Console.WriteLine(entname);
            }
            else 
            {
                Console.WriteLine("No match");
            }
        
        }
        Console.ReadLine();

    }
}

