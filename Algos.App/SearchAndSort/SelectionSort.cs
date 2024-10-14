namespace Algos.SearchAndSort
{
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var smallestIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    var jValue = arr[j];
                    var iValue = arr[smallestIndex];
                    if (jValue < iValue)
                        smallestIndex = j;
                }

                if (smallestIndex > i)
                    (arr[smallestIndex], arr[i]) = (arr[i], arr[smallestIndex]);
            }
        }
    }
}
