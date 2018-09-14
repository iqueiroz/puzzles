using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class OddOccurrencesInArray
    {
        private Puzzles.OddOccurrencesInArray.Solution _solution;

        public OddOccurrencesInArray()
        {
            this._solution = new Puzzles.OddOccurrencesInArray.Solution();
        }
        
        [Theory]
        [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        [InlineData(new[] { 4, 4, 3 }, 3)]
        [InlineData(new[] { 2, 2, 3, 3, 4 }, 4)]
        [InlineData(new[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 4 }, 4)]
        public void Examples(int[] input, int expectedResult)
        {
            var result = this._solution.solution(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
