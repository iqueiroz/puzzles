using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class TapeEquilibrium
    {
        private Puzzles.TapeEquilibrium.Solution _solution;

        public TapeEquilibrium()
        {
            this._solution = new Puzzles.TapeEquilibrium.Solution();
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
        [InlineData(new[] { 3, 1 }, 2)]

        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
