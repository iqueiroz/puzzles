using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class MissingInteger
    {
        private Puzzles.MissingInteger.Solution _solution;

        public MissingInteger()
        {
            this._solution = new Puzzles.MissingInteger.Solution();
        }
        
        [Theory]
        [InlineData(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new[] { -1, -3 }, 1)]
        [InlineData(new[] { -1 }, 1)]
        [InlineData(new[] { 2 }, 1)]
        [InlineData(new[] { 2, 3 }, 1)]
        [InlineData(new[] { 1, 2, 3 }, 4)]
        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
