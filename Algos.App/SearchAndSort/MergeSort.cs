using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

namespace Algos.SearchAndSort
{
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            System.Diagnostics.Debug.WriteLine("Original Array: " + string.Join(", ", arr));

            MergeSrt(arr, 0, arr.Length - 1);

            System.Diagnostics.Debug.WriteLine("Sorted Array: " + string.Join(", ", arr));

            return arr;
        }
        //we initially pass arr.Length - 1 as right;

        //we initially pass arr.Length - 1 as right;

        private void MergeSrt(int[] arr, int left, int right)
        {
            if (right > left)
            {
                var mid = (left + right) / 2;
                MergeSrt(arr, left, mid);
                MergeSrt(arr, mid + 1, right);

                Merge(arr, left, right, mid);
                System.Diagnostics.Debug.WriteLine($"Arr:{string.Join(" ", arr)}");
            }
        }

        private void Merge(int[] arr, int left, int right, int mid)
        {
            //set size
            var leftSize = mid - left + 1;
            var rightSize = right - mid;


            //set arrays
            var leftArr = new int[leftSize];
            var rightArr = new int[rightSize];

            //populate arrays
            for (int i = 0; i < leftSize; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (int i = 0; i < rightSize; i++)
            {
                rightArr[i] = arr[mid + i + 1];
            }

            //set variables
            var iLeft = 0; var iRight = 0; var iMerged = left;

            //loop
            while (iLeft < leftSize && iRight < rightSize)
            {
                var leftItem = leftArr[iLeft];
                var rightItem = rightArr[iRight];

                if (leftItem < rightItem)
                {
                    arr[iMerged++] = leftArr[iLeft++];
                }
                else
                {
                    arr[iMerged++] = rightArr[iRight++];
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
            //loop leftovers
        }





    }
}
