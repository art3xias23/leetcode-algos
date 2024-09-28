namespace Algos.SearchAndSort
{
    public class SelectionSort
    {
        public void Sort(int[] initial)
        {
            for (int i = 0; i < initial.Length; i++)
            {
                var minIndex = i;

                for (int j = i + 1; j < initial.Length; j++)
                {
                    if (initial[minIndex] > initial[j])
                        minIndex = j;
                }

                if (minIndex != i)
                    Swap(initial, i, minIndex);
            }
        }

        private void Swap(int[] init, int left, int right)
        {
            var temp = init[left];
            init[left] = init[right];
            init[right] = temp;
        }
    }
}
