namespace stack
{
    using adt;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack.StackRepresentation? stack1 = null;
            Stack.StackRepresentation? stack2 = null;


            Console.WriteLine($"in1 => Leer? {Stack.isEmpty(stack1)} (true) oder Voll? {Stack.isFull(stack1)} (false)");
            Console.WriteLine($"in2 => Leer? {Stack.isEmpty(stack2)} (true) oder Voll? {Stack.isFull(stack2)} (false)");

            Console.Write("in1 => ");
            for (int i = 0; i < 26; ++i)
                Console.Write( Stack.push(ref stack1, i * i) + " ");
            Console.WriteLine();

            Console.WriteLine($"in1 => Leer? {Stack.isEmpty(stack1)} (false) oder Voll? {Stack.isFull(stack1)} (true)");
            Console.WriteLine($"in2 => Leer? {Stack.isEmpty(stack2)} (true!) oder Voll? {Stack.isFull(stack2)} (true)");

            Console.Write("in2 => ");
            Stack.push(ref stack2, 1);
            Stack.push(ref stack2, 2);
            Console.WriteLine("1 2");

            Console.Write("in1 => ");
            while (!Stack.isEmpty(stack1))
                Console.Write(Stack.pop(ref stack1) + " ");
            Console.WriteLine();

            Console.Write("in2 => ");
            while (!Stack.isEmpty(stack2))
                Console.Write(Stack.pop(ref stack2) + " ");
            Console.WriteLine();

            Console.WriteLine($"in1 => Leer? {Stack.isEmpty(stack1)} (true) oder Voll? {Stack.isFull(stack1)} (false)");
            Console.WriteLine($"in2 => Leer? {Stack.isEmpty(stack2)} (true) oder Voll? {Stack.isFull(stack2)} (false)");
        }
    }
}
