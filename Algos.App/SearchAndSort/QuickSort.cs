namespace Algos.SearchAndSort
{
    public class QuickSort
    {
        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var index = Partition(arr, left, right);
                Sort(arr, left, index - 1);
                Sort(arr, index + 1, right);
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            var val = arr[right];

            var i = left - 1;

            for (int j = left; j < right; j++)
            {
                var jValue = arr[j];

                if (jValue < val)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[right]);
            return i + 1;
        }

        public void Swap(ref int left, ref int right)
        {
            (left, right) = (right, left);
        }
    }
}
