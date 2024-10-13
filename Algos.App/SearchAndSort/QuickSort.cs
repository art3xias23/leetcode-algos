namespace Algos.SearchAndSort
{
    public class QuickSort
    {

        public void Quicksort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
        }

        public void Swap(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }
    }
}
