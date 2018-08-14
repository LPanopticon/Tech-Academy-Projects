using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarCon
{
    class Program
    {
       public static void Main(string[] args)
        {
            var Example = "Here is a string that var knows how to read.";
            const string exName = "Logan";
            Console.WriteLine("{0} And a constant just to show I can use it that says my name: {1}", Example, exName);

            //takes the name entered here, and the defaul value of "default words" entered on the class line.
            Chain chain = new Chain("Logan");
            Console.WriteLine(chain.Name);
                   
            Console.ReadLine();
        

        }
    }
}
