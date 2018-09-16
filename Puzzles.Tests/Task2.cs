using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class Task2
    {
        private Puzzles.Task2.Solution _solution;

        public Task2()
        {
            this._solution = new Puzzles.Task2.Solution();
        }
        
        [Theory]
        [InlineData(new[] { 0, 3, 3, 7, 5, 3, 11, 1 }, 0)]
        [InlineData(new[] { 0, 3, 6, 9, 12, 14 }, 2)]
        [InlineData(new[] { -1 }, Puzzles.Task2.Solution.NoAdjacentIndex)]
        [InlineData(new[] { -100000000,100000000 }, Puzzles.Task2.Solution.MinimumDistanceExceeded)]
        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
