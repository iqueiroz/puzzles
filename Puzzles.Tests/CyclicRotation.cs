using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class CyclicRotation
    {
        private Puzzles.CyclicRotation.Solution _solution;

        public CyclicRotation()
        {
            this._solution = new Puzzles.CyclicRotation.Solution();
        }

        [Theory]
        [InlineData(new[] {3, 8, 9, 7, 6}, 3, new[]{ 9, 7, 6, 3, 8 })]
        [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        public void Examples(int[] input, int k, int[] expectedResult)
        {
            var result = this._solution.solution(input, k);
            Assert.Equal(expectedResult, result);
        }
    }
}
