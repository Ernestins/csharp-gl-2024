using stack.ado;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Leer? {Stack.isEmpty()} (true) oder Voll? {Stack.isFull()} (false)");

            for (int i = 0; i < 26; ++i)
                Console.Write( Stack.push(i * i) + " ");
            Console.WriteLine();

            Console.WriteLine($"Leer? {Stack.isEmpty()} (false) oder Voll? {Stack.isFull()} (true)");

            while (!Stack.isEmpty())
                Console.Write(Stack.pop() + " ");
            Console.WriteLine();

            Console.WriteLine($"Leer? {Stack.isEmpty()} (true) oder Voll? {Stack.isFull()} (false)");
        }
    }
}
