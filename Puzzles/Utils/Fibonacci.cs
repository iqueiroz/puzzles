using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Utils
{
    public class Fibonacci
    {
        public long Calculate(long n)
        {
            long[] start = new long[] { 0, 1, 1 };
            long[] sequence = new long[Math.Max(start.Length, n + 1)];
            Array.Copy(start, sequence, start.Length);
            for (long i = start.Length; i < sequence.Length; i++)
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            return sequence[n];
        }
    }
}
