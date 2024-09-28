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

        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {

                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = key;

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
