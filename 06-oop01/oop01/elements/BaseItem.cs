namespace oop01.elements
{
    class BaseItem
    {
        public string Name { get; set; } = "Basis";


        public void output(string msg)
        {
            Console.WriteLine($"Upps Aufruf von {Name}::output, nicht vorgesehen!");
        }

        public virtual void print(string msg)
        {
            Console.WriteLine($"Upps Aufruf von {Name}::print, nicht vorgesehen!");
        }
    }
}
