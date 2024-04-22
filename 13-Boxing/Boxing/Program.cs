
namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int    i = 11;
            double d = 222.22;
            float  f = 3333.3F;
            string s = "Hello";

            object o;

            o = d;  // Boxing => implicite TypeCast

            Analyse(o.GetType(), d.GetTypeCode());
            //Analyse(typeof(int), TypeCode.Int32);


            if(o.GetType() == typeof(int)) {
                int iv = (int)o;  // Unboxing => explicite TypeCast
                Console.WriteLine("The Integer Value is: {0}", iv);
            } else if(o.GetType() == typeof(double)) {
               double dv = (double)o;
                Console.WriteLine("The Double Value is: {0}", dv);
            } else if (o.GetType() == typeof(float)) {
               float fv = (float)o;
                Console.WriteLine("The Float Value is: {0}", fv);
            } else if (o.GetType() == typeof (string)) {
               string sv = (string)o;
                Console.WriteLine("The String Value is: {0}", sv);
            } else {
                Console.Error.WriteLine("Unknown!!!");
            }
        }

        private static void Analyse(Type t, TypeCode tc)
        {
            Console.WriteLine($"Full: {t} Basisstyp: {tc}\n"); 
        }
    }
}
