namespace Algos.Data
{
    public class ListNode<T>
    {
            public T Value { get;  }
        public ListNode<T> Next{get;}

        public ListNode(T val)
        {
           Value = val; 
           Next = null;
        }
    }
}
