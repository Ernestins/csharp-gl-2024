namespace stack.ado._
{
    partial class Stack
    {

        //metas
        //public static int  size()     { return 0; }
        //public static int  capacity() { return 0; }
        public static bool   isEmpty()  { return __pos == -1; }
        public static bool   isFull()   { return __pos == max-1; }


        //manips
        public static int  push(int e) => __data[++__pos] = e;
        //{
        //    Debug.Assert(!isFull());
        //    return __data[++__pos] = e;
        //}

        public static int  pop ()      => __data[__pos--];
        //{
        //    Debug.Assert(!isEmpty());
        //    return __data[__pos--]; 
        //}

    }
}
