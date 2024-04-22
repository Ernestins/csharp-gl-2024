namespace stack.adt
{
    partial class Stack
    {
        public class StackRepresentation
        {
            public int        data;
            public StackRepresentation? prev;

            public StackRepresentation(int data, StackRepresentation? prev)
            {
                this.data = data;
                this.prev = prev;
            }

            public (int item, StackRepresentation? prev) pop() =>  (this.data, this.prev);

        }


    }
}
