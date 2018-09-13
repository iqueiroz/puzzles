using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class BinaryGap
    {
        private Puzzles.BinaryGap.Solution _solution;

        public BinaryGap()
        {
            this._solution = new Puzzles.BinaryGap.Solution();
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        public void Examples(int input, int expectedResult)
        {
            var result = this._solution.solution(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
