using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class MaxCounters
    {
        private Puzzles.MaxCounters.Solution _solution;

        public MaxCounters()
        {
            this._solution = new Puzzles.MaxCounters.Solution();
        }

        [Theory]
        [InlineData(5, new[] {3, 4, 4, 6, 1, 4, 4}, new[]{ 3, 2, 2, 4, 2 })]
        [InlineData(1, new[] { 1 }, new[] { 1 })]
        [InlineData(2, new[] { 1, 1, 1, 2 }, new[] { 3, 1 })]
        [InlineData(2, new[] { 1, 1, 1, 3 }, new[] { 3, 3 })]
        public void Examples(int n, int[] a, int[] expectedResult)
        {
            var result = this._solution.solution(n, a);
            Assert.Equal(expectedResult, result);
        }
    }
}
