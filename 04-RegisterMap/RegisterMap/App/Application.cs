using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterMap.App
{
    class Application
    {
        public string Name { get; set; }

        static Application()
        {
            Debug.WriteLine("Step 01");
            new Application("Main").register();
            new Application("Test").register();
        }

        static void Main(string[] args)
        {
            Debug.WriteLine("Step 02");
            {
                Debug.WriteLine("Step 03");
                var temp = Console.ForegroundColor;
                try {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bitte warten");
                    Thread.Sleep(5000);
                } finally {
                    Console.ForegroundColor = temp;
                }
            }
            Debug.WriteLine("Step 04");

            SYS.RegisterApp.lookup("Test").start();

        }

        public Application(string name)
        {
            Debug.WriteLine("Step 01a");
            Name = name;
        }

        public Application register()
        {
            Debug.WriteLine("Step 01b");
            SYS.RegisterApp.attach(this);
            return this;
        }

        public Application start()
        {
            Debug.WriteLine("Step 05");
            Console.Error.WriteLine("Output from: " + this.Name);
            SYS.RegisterApp.debugPrintAllReg();
            return this;
        }


    }
}
