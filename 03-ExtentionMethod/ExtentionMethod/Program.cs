using System.Threading.Channels;

namespace Lib
{
    class Fixed
    {
        public void Output(/* Fixed this, */ string msg) => Console.WriteLine(msg);
    }

    static class MetaFixed
    {
        public static void Output(this Fixed that, string msg, int value) => Console.WriteLine(msg + $"({value})");
    }

}
namespace ExtentionMethod
{
    using Lib;

    class Program
    {
        static void Main(string[] args)
        {
            var f = new Lib.Fixed();
            f.Output("simple Message");
     
        }
    }
}
