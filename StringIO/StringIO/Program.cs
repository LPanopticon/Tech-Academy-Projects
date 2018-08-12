using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string number = string.Format(Console.ReadLine());
            File.WriteAllText(@"C:\Users\logan\Documents\GitHub\Class Work\StringIO\log.txt", number);
            string readlog = File.ReadAllText(@"C:\Users\logan\Documents\GitHub\Class Work\StringIO\log.txt");
            Console.WriteLine(readlog);
            Console.ReadLine();
        }
            
    }
}
