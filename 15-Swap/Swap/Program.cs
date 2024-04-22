

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            var ia = new int[] { 3333, 11, 44444, 222 };

            Sort(ia);
            Console.WriteLine("Hello, World!");

            foreach (int i in ia) Console.Write($"{i} ");
            Console.WriteLine();

            DateTime dateTime = DateTime.Now;
            String x = "Anton";
            String y = "Berta";

            Console.WriteLine($"x:{x} y:{y}");
            Swap<String>(ref x, ref y);
            Console.WriteLine($"x:{x} y:{y}");
        }

        private static void Sort(int[] ia)
        {
            for(int a=0; a<ia.Length-1; ++a)
                for(int b=a+1; b<ia.Length; ++b)
                    if (ia[a] > ia[b])
                        Swap(ref ia[a], ref ia[b]);
        }

        //public static void Swap(ref int a, ref int b)
        //{
        //    (b, a) = (a, b);
        //}

        public static void Swap<T>(ref T a, ref T b)
        {
            (b, a) = (a, b);
        }

    }
}
