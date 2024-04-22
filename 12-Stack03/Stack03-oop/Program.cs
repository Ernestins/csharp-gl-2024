namespace stack
{
    using stack.oop;
    using stack.util;

    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Stack<int>(10);
            var s2 = new Stack<char>(26);
            var s3 = new Stack<string>(4);

            $"Leer? {s1.isEmpty()} (true) oder Voll? {s1.isFull()} (false)".println();

            for (int i = 0; i < 10; ++i)
                $"{s1.push(i * i),5:0} ".printcd(i == 9);

            for (char c = 'a'; c <= 'z'; ++c)
                $"{s2.push(c)} ".printcd(c == 'z');

            s3.push("Burkhard");
            s3.push("Felix");
            s3.push("Solmaz");
            s3.push("Robert");

            ($"\nLeer? {s1.isEmpty()} (false) oder Voll? {s1.isFull()} (true)" +
               "\n" +
              $"\nOberst Element ist: {s1.peek()} und Kapazität: {s1.capacity()} / Größe: {s1.size()}\n"
               ).println();

            while (!s1.isEmpty())
                (s1.pop() + " ").printcd(s1.isEmpty());

            while (!s2.isEmpty())
                (s2.pop() + " ").printcd(s2.isEmpty());


            while (!s3.isEmpty())
                (s3.pop() + " ").printcd(s3.isEmpty());

            $"Leer? {s1.isEmpty()} (true) oder Voll? {s1.isFull()} (false)".println();

        }
    }
}