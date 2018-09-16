using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class Task3
    {
        private Puzzles.Task3.Solution _solution;

        public Task3()
        {
            this._solution = new Puzzles.Task3.Solution();
        }
        
        [Theory]
        [InlineData(new[] { 5, 5, 5, 5 }, 1)]
        [InlineData(new[] { 3, 4 }, 1)]
        [InlineData(new[] { 3, 4, 7, 7, 6, 6 }, 3)]
        [InlineData(new[] { 80, 80, 1000000000, 80, 80, 80, 80, 80, 80, 123456789 }, 3)]
        public void Examples(int[] a, int expectedResult)
        {
            var result = this._solution.solution(a);
            Assert.Equal(expectedResult, result);
        }

    }
}
