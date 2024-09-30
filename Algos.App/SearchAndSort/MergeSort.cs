using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

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
                var mid = (right + left) / 2;

                counter++;
                System.Diagnostics.Debug.WriteLine($"Left{counter}: {string.Join(" ", arr[left..(mid+1)])}");
                MergeSrt(arr, left, mid, counter);
                System.Diagnostics.Debug.WriteLine($"Right{counter}: {string.Join(" ", arr[(mid + 1)..(right + 1)])}");
                MergeSrt(arr, mid + 1, right, counter);

                Merge(arr, left, right, mid);
                System.Diagnostics.Debug.WriteLine($"{string.Join(" ", arr)}");
            }
        }

        private void Merge(int[] arr, int left, int right, int mid)
        {

            //Set size
            var leftSize = mid - left + 1;
            var rightSize = right - mid;

            var leftArr = new int[leftSize];
            var rightArr = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArr[i] = arr[i + left];
            }

            for (int i = 0; i < rightSize; i++)
            {
                rightArr[i] = arr[mid + 1 + i];
            }


            int iLeft = 0; int iRight = 0; int iMerged = left;

            while (iLeft < leftSize && iRight < rightSize)
            {
                var leftItem = leftArr[iLeft];
                var rightItem = rightArr[iRight];
                if (leftItem > rightItem)
                {
                    arr[iMerged++] = rightArr[iRight++];
                }
                else
                {

                    arr[iMerged++] = leftArr[iLeft++];
                }
            }

            while (iLeft < leftSize)
            {
                arr[iMerged++] = leftArr[iLeft++];
            }

            while (iRight < rightSize)
            {
                arr[iMerged++] = rightArr[iRight++];
            }
        }
    }
}
