namespace Puzzles.Task2
{
    using System;

    public class Solution
    {
        public const int MaxDistance = 100000000;
        public const int NoAdjacentIndex = -2;
        public const int MinimumDistanceExceeded = -1;

        public int solution(int[] A)
        {
            if(A.Length<2)
                return NoAdjacentIndex;
            Array.Sort(A);
            int currentDifference = A[0];
            int previousMinimum = 0;

            for (var i = 1; i < A.Length; i++)
            {
                currentDifference = Math.Abs(A[i-1]- A[i]);
                if (i == 1)
                    previousMinimum = currentDifference;
                else
                    previousMinimum = Math.Min(currentDifference, previousMinimum);
            }

            var result = Math.Min(currentDifference, previousMinimum);
            if (result > MaxDistance)
                return MinimumDistanceExceeded;
            return result;
        }
    }
}
