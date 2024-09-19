namespace Algos
{
    public class _202_Happy_Number
    {
        public bool IsHappy_HashSet(int n)
        {
            var hashSet = new HashSet<int>();
            while (!hashSet.Contains(n))
            {
                var sum = 0;
                if (n == 1) return true;
                hashSet.Add(n);

                while (n >= 10)
                {
                    var number = n % 10;
                    sum += number * number;
                    n = n / 10;
                }

                sum += n * n;


                n = sum;
            }
            return false;
        }

        public bool IsHappy_TwoPointers(int n)
        {
            var slow = n;
            var fast = GetNext(GetNext(n));
            while (slow != fast)
            {
                slow = GetNext(slow);
                fast = GetNext(GetNext(fast));
            }

            return slow == 1;


        }
        int GetNext(int n)
        {
            var sum = 0;
            while (n >= 10)
            {
                var num = n % 10;
                sum += num * num;
                n/=10;
            }
            sum += n * n;
            return sum;
        }
    }

}
