using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01.elements
{
    class ConcretItemA : BaseItem
    {
        public string Name { get; set; }
        public ConcretItemA(string name) => Name = name;

        public new void output(string msg)
        {
            Console.WriteLine($"Call output A({Name}) on {msg}.");
        }
        public override void print(string msg)
        {
            Console.WriteLine($"Call print A({Name}) with {msg}.");
        }
    }
}
