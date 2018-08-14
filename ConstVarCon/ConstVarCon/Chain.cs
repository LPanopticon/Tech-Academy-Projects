using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarCon
{
    class Chain
    {
        public Chain(string name) : this(name, "Default words")
        {
        }

        public Chain(string name, string words)
        {
            Name = name;
            Words = words;
        }
        public string Name { get; set; }  
        public string Words { get; set; }
    }
}
