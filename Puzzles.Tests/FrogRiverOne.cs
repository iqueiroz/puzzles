using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class FrogRiverOne
    {
        private Puzzles.FrogRiverOne.Solution _solution;

        public FrogRiverOne()
        {
            this._solution = new Puzzles.FrogRiverOne.Solution();
        }
        
        [Theory]
        [InlineData(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [InlineData(2, new[] { 1, 1, 1, 1, 1, 3 }, -1)]
        [InlineData(2, new[] { 2 }, -1)]
        [InlineData(1, new[] { 1 }, 0)]
        [InlineData(3, new[] { 7, 7, 7, 7, 7, 7, 1, 2, 3 }, 8)]
        [InlineData(3, new[] { 1, 3, 1, 3, 2, 1, 3 }, 4)]
        public void Examples(int x, int[] a, int expectedResult)
        {
            var result = this._solution.solution(x, a);
            Assert.Equal(expectedResult, result);
        }

    }
}
