
namespace SelOp
{
    internal class Program
    {
        //static void MainX(string[] args)
        //{
        //    var a = InputDbl("A");
        //    var b = InputDbl("B");
        //    var o = InputOps();
        //    Console.WriteLine($"{a} {b} {o}");
        //    switch (o) {
        //        case '-':  Console.WriteLine( a - b ); break;
        //        case '+':  Console.WriteLine( a + b ); break;
        //        default:   Console.WriteLine( "NoOp" ); break;
        //    }

        //    Console.WriteLine(o switch
        //    {
        //        '-' => a - b,
        //        '+' => a + b,
        //        _ => Double.NaN,
        //    });
        //}


        delegate double Ops(double x, double y);
        
        static void Main(string[] args)
        {
            var o = InputOps();

            Ops ops = o switch
                        {
                            '-' => sub,
                            '+' => add,
                            _ => noop,
                        };


            var a = InputDbl("A");
            var b = InputDbl("B");

            var r = ops(a, b);
            Console.WriteLine(r);
        }

        static double noop(double x, double y) => Double.NaN;
        static double add(double x, double y) => x + y;
        static double sub(double x, double y) => x - y;

        private static double InputDbl(string v)
        {
            Console.Write($"Bitte Wert Eingeben ({v}):");
            return Double.Parse(Console.ReadLine()??"0");
        }

        private static char InputOps()
        {
            Console.Write($"Bitte Operation (+-) Eingeben:");
            var ck = Console.ReadKey();
            Console.WriteLine();

            if (ck.KeyChar == '-' ||  ck.KeyChar == '+') return ck.KeyChar;
            return '?';
        }
    }
}
