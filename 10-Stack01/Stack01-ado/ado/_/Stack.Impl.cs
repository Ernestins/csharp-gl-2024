namespace stack.ado._
{
    partial class Stack
    {
        public  static readonly int max = 10;
        private static int[] __data;
        private static int   __pos   = -1;

        static Stack()
        {
            __data = new int[max];
        }
    }
}
