/*

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].

source: https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
*/

namespace Puzzles.MissingInteger
{
    using System;

    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            var returnValue = 1;
            var previousValue = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] > previousValue)
                {
                    if (returnValue < A[i])
                        return returnValue;
                    else
                        returnValue++;
                    previousValue = A[i]; 
                }
            }
            return returnValue;
        }
        
    }
}
