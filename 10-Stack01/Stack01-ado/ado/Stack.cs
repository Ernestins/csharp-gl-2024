namespace stack.ado
{
    partial class Stack
    {

        //metas
        //public static int  size()     { return 0; }
        //public static int  capacity() { return 0; }
        public static bool isEmpty()    { return __head == null; }
        public static bool isFull()     { return false; }


        //manips
        public static int push(int e) { __head = new __Node(e, __head); return e; }
        public static int pop()       
        {
            int e;

            (e, __head) = __head.pop();
            return e; 
        }

    }
}
