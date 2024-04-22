namespace ComplexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Complex z1 = new Complex(5, 3),
                    z2 = new Complex(2, 5),
                    z3;

            z3 = z1 + z2 + new Complex(5.0) + Complex.Polar(7, 3.51);
            //z3 = z1.add(z2);

            Console.WriteLine($"z1:{z1} z2:{z2} z3:{z3}");
        }
    }
}
