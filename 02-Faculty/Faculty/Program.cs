

namespace Faculty
{
    internal class Program
    {
        /*
        * fac(n) = 1 * 2 * 3 * 4 * 5 * .... * (n-1) * n = fac(n-1) * n
        * fac(5) = 1 * 2 * 3 * 4 * 5                    = fac(4) * 5
        * fac(4) = 1 * 2 * 3 * 4                        = fac(3) * 4
        * fac(3) = 1 * 2 * 3                            = fac(2) * 3
        * fac(2) = 1 * 2                                = fac(1) * 2
        * fac(1) = 1                                    = fac(0) * 1
        * fac(0) = 1                                    = 1
        */
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            for (ulong i = 0; i < 25; ++i) 
              Console.WriteLine("{1}! = fac({1}): {0}", fac_safe(i), i);
            var stop = DateTime.Now;
            var diff = stop - start;

            Console.WriteLine($"duration: {start} / {stop} / {diff.TotalSeconds}");
        }

        private static string fac_safe(ulong n)
        {
            try {
                return fac_it(n).ToString();
            } catch (OverflowException) {
                return "k.A.";
            }
        }

        private static ulong fac_it(ulong n)
        {
            var r = 1UL;
            while (n > 1) r *= n--;
            return r;
        }

        private static ulong fac(ulong n) => n<2 ? 1UL : fac(n-1)*n;


    }
}
