namespace Algos.SearchAndSort
{
    public class InsertionSort
    {
        public void Sort_TooMuchAssigns(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void Swap(int[] arr, int right, int left)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
