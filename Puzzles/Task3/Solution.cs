namespace Puzzles.Task3
{
    using System;

    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            int candyCounter = 1;
            int i = 1;
            while(firstHalf(A, candyCounter) && notOutOfbounds(A, i))
            {
                if (notSameCandy(A, i))
                    candyCounter++;
                i++;
            }
            return candyCounter;
        }

        private static bool notSameCandy(int[] A, int i)
        {
            return A[i] > A[i - 1];
        }

        private static bool firstHalf(int[] A, int counter)
        {
            return counter < A.Length / 2;
        }

        private static bool notOutOfbounds(int[] A, int i)
        {
            return i < A.Length;
        }
    }
}
