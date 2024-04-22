using oop01.elements;

namespace oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseItem[] items =
            {
                new ConcretItemA("A1"), new ConcretItemB("B"), new ConcretItemA("A2")
            };

            foreach (var item in items)
            {
                item.output("run1");
            }
            foreach (var item in items)
            {
                item.print("run2");  // VMT
            }
            foreach (var item in items)
            {
                if (item is ConcretItemA) {
                    Console.WriteLine("A is Calling ...");
                    (item as ConcretItemA)?.output("run3");
                } else if(item is ConcretItemB) {
                    Console.WriteLine("B is Calling ...");
                    (item as ConcretItemB)?.output("run3");
                } else if (item is BaseItem)
                {
                    Console.WriteLine("BaseItem is calling ...");
                    item.output("run3");
                }
            }
          
        }
    }
}
