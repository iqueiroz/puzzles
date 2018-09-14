using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class FrogJmp
    {
        private Puzzles.FrogJmp.Solution _solution;

        public FrogJmp()
        {
            this._solution = new Puzzles.FrogJmp.Solution();
        }

        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void Examples(int x, int y, int d, int expectedResult)
        {
            var result = this._solution.solution(x, y, d);
            Assert.Equal(expectedResult, result);
        }

    }
}
