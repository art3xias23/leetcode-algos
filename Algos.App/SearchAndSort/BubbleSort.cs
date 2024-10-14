namespace Algos.SearchAndSort
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    var x = j + 1;
                    if (arr[j] > arr[x])
                    {
                        Swap(ref arr[j], ref arr[x]);
                    }
                }
            }
        }

        public void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

    }
}
