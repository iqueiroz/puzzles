using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class Task1
    {
        private Puzzles.Task1.Solution _solution;

        public Task1()
        {
            this._solution = new Puzzles.Task1.Solution();
        }
        
        [Theory]
        [InlineData("00-44  48 5555 8361", "004-448-555-583-61")]
        [InlineData("0 - 22 1985--324", "022-198-53-24")]
        [InlineData("555372654", "555-372-654")]
        [InlineData("123456", "123-456")]
        [InlineData("123", "123")]
        [InlineData("12345", "123-45")]
        [InlineData("12", "12")]
        public void Examples(string s, string expectedResult)
        {
            var result = this._solution.solution(s);
            Assert.Equal(expectedResult, result);
        }

    }
}
