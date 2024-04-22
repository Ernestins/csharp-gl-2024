namespace stack.ado
{
    partial class Stack
    {
        private class __Node
        {
            public int     data;
            public __Node? prev;

            public __Node(int data, __Node? prev)
            {
                this.data = data;
                this.prev = prev;
            }

            public (int item, __Node? prev) pop() =>  (this.data, this.prev);

        }

        private static __Node? __head = null;


    }
}
