namespace stack.adt
{
    partial class Stack
    {

        //metas
        //public static int  size()     { return 0; }
        //public static int  capacity() { return 0; }
        public static bool isEmpty(StackRepresentation that)    { return that == null; }
        public static bool isFull (StackRepresentation that)    { return false; }


        //manips
        public static int push(ref StackRepresentation? that, int e) { that = new StackRepresentation(e, that); return e; }
        public static int pop (ref StackRepresentation? that)       
        {
            int e;

            (e, that) = that.pop();
            return e; 
        }

    }
}
