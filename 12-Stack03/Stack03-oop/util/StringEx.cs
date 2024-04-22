using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace stack.util
{
    static class StringEx
    {
        public static string fmt(this string that, params object[] o) => string.Format(that, o);

        public static string printcd(this string that, bool cond, params object[] o)
          => print(that + (cond ? "\n":""), o);
        public static string println(this string that, params object[] o) => print(that + "\n", o);
        public static string print(this string that, params object[] o)
        {
            var t = that.fmt(o);
            Console.Out.Write(t);
            return t;
        }
    }
}
