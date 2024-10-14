namespace Algos.SearchAndSort
{
    public class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j+1] = key;
            }
        }
    }
}
