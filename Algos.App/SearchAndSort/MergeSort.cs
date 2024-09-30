namespace Algos.SearchAndSort
{
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            System.Diagnostics.Debug.WriteLine("Original Array: " + string.Join(", ", arr));

            // Call MergeSort on the array
            MergeSrt(arr, 0, arr.Length - 1);

            System.Diagnostics.Debug.WriteLine("Sorted Array: " + string.Join(", ", arr));

            return arr;
        }
        //we initially pass arr.Length - 1 as right;

        private void MergeSrt(int[] arr, int left, int right, int counter = 0)
        {
            if (left < right)
            {
                counter++;
                var middle = (left + right) / 2;

                var indent = new string('\t', counter);
                System.Diagnostics.Debug.WriteLine($"{indent}Left({counter}): {string.Join(" ", arr[left..(middle+1)])}");
                MergeSrt(arr, left, middle, counter);
                System.Diagnostics.Debug.WriteLine($"{indent}Right({counter}): {string.Join(" ", arr[(middle + 1)..(right + 1)])}");
                MergeSrt(arr, middle + 1, right, counter);

                Merge(arr, left, middle, right);

                System.Diagnostics.Debug.WriteLine($"{indent}Merged({counter}): {string.Join(" ", arr)}");
            }
        }

        //left is the first index of the left array;
        //right is the last index of the right array;
        private void Merge(int[] arr, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            var leftArray = new int[leftSize];
            var rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int i = 0; i < rightSize; i++)
            {
                rightArray[i] = arr[middle + 1 + i];
            }

            int iLeft = 0; int iRight = 0; int iMerge = left;

            while (iLeft < leftSize && iRight < rightSize)
            {
                var leftItem = leftArray[iLeft];
                var rightItem = rightArray[iRight];
                if (leftItem < rightItem)
                {
                    arr[iMerge++] = leftArray[iLeft++];
                }
                else
                {
                    arr[iMerge++] = rightArray[iRight++];
                }
            }

            while (iLeft < leftSize)
            {
                arr[iMerge++] = leftArray[iLeft++];
            }
            while (iRight < rightSize)
            {
                arr[iMerge++] = rightArray[iRight++];
            }
        }
    }
}
