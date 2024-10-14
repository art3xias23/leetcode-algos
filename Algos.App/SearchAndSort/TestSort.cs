namespace Algos.SearchAndSort
{
    public class TestSort
    {
        public int[] Sort(int[] arr)
        {
            System.Diagnostics.Debug.WriteLine("Original Array: " + string.Join(", ", arr));

            MergeSrt(arr, 0, arr.Length - 1);

            System.Diagnostics.Debug.WriteLine("Sorted Array: " + string.Join(", ", arr));

            return arr;
        }
        public void MergeSrt(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var mid = (right + left) / 2;
                Console.WriteLine($"Left: {left} - Right:{right}");
                MergeSrt(arr, left, mid);
                MergeSrt(arr, mid + 1, right);
                Merge(arr, left, right, mid);
            }
        }

        public void Merge(int[] arr, int left, int right, int mid)
        {
            //get the size of the arrays
            var sizeOfLeft = mid - left + 1;
            var sizeOfRight = right - mid;

            //create arrays
            var leftArray = new int[sizeOfLeft];
            var rightArray = new int[sizeOfRight];

            //populate arrays
            for (int i = 0; i < sizeOfLeft; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int i = 0; i < sizeOfRight; i++)
            {
                rightArray[i] = arr[mid+ i + 1];
            }

            //loop

            var iLeft = 0; var iRight = 0; var iMerged = left;

            while (iLeft < sizeOfLeft && iRight < sizeOfRight)
            {
                var leftValue = leftArray[iLeft];
                var rightValue = rightArray[iRight];

                if (leftValue > rightValue)
                {
                    arr[iMerged++] = rightArray[iRight++];
                }
                else
                {

                    arr[iMerged++] = leftArray[iLeft++];
                }
            }

            while (iLeft < sizeOfLeft)
            {

                arr[iMerged++] = leftArray[iLeft++];
            }

            while (iRight < sizeOfRight)
            {

                arr[iMerged++] = rightArray[iRight++];
            }

        }
    }
}
