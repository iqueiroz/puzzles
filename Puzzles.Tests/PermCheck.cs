using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class PermCheck
    {
        private Puzzles.PermCheck.Solution _solution;

        public PermCheck()
        {
            this._solution = new Puzzles.PermCheck.Solution();
        }

        [Theory]
        [InlineData(new[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new[] { 4, 1, 3 }, 0)]
        [InlineData(new[] { 2, 3 }, 0)]
        [InlineData(new[] { 2 }, 0)]
        [InlineData(new[] { 1 }, 1)]
        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
