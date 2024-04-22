using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp01
{
    class App : Object
    {
        static void Main(string[] args)
        {
            App app = new App();
        }

        public App()
        {
            Console.WriteLine(this.ToString());
        }


        public override string ToString()
        {
            return "Hallo Willkommen in unserer App!";
        }

    }
}
