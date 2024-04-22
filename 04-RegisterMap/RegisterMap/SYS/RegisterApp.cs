using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegisterMap.SYS
{
    static class RegisterApp
    {
        private static Dictionary<String, App.Application> dict = new Dictionary<String, App.Application>();

        public static void attach(App.Application app)    => dict[app.Name] = app;
        public static void dettach(string name)           => dict.Remove(name);
        public static App.Application lookup(string name) => dict[name];

        public static void debugPrintAllReg()
        {
#if DEBUG
            foreach (var key in dict.Keys)
                Console.WriteLine($"Mapping '{key}' => *");
#endif
        }
    }
}
