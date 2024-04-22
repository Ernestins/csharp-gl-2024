using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01.elements
{
    class ConcretItemB : BaseItem    
    {
        public string Name { get; set; }
        public ConcretItemB(string name) => Name = name;

        public new void output(string msg)
        {
            Console.WriteLine($"Call output B({Name}) with {msg}.");
        }
        public override void print(string msg)
        {
            Console.WriteLine($"Call print B({Name}) with {msg}.");
        }
    }
}
