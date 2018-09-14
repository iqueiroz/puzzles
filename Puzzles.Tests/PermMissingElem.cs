using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class PermMissingElem
    {
        private Puzzles.PermMissingElem.Solution _solution;

        public PermMissingElem()
        {
            this._solution = new Puzzles.PermMissingElem.Solution();
        }

        [Theory]
        [InlineData(new[] { 2, 3, 1, 5 }, 4)]
        [InlineData(new[] { 2, 3, 1, 5, 6 }, 4)]
        [InlineData(new[] { 2 }, 1)]
        [InlineData(new int[0], 1)]
        [InlineData(new[] { 4, 2, 3, 5, 1, 6, 8, 9 }, 7)]
        [InlineData(new[] { 1, 2 }, 3)]
        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
