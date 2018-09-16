using Puzzles.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Puzzles.Tests
{
    public class UtilsTests
    {
        
        
        [Theory]
        [InlineData(24, 9, 3)]
        [InlineData(8, 40, 8)]
        [InlineData(8472934, 23494, 2)]
        public void Gcd(int a, int b, int expectedResult)
        {
            var result = new Euclidian().Gcd(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(45, 60, 75, 15)]
        public void Gcd_ThreeParameters(int a, int b, int c, int expectedResult)
        {
            var result = new Euclidian().Gcd(a, b, c);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 40, 40)]
        [InlineData(8, 40, 40)]
        [InlineData(10, 12, 60)]
        [InlineData(65, 10, 130)]
        public void Lcm(int a, int b, int expectedResult)
        {
            var result = new Euclidian().Lcm(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(65, 40, 10, 520)]
        public void Lcm_ThreeParameters(int a, int b, int c, int expectedResult)
        {
            var result = new Euclidian().Lcm(a, b, c);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(20, 6765)]
        [InlineData(70, 190392490709135L)]
        public void Fibonacci(long n, long expectedResult)
        {
            var result = new Fibonacci().Calculate(n);
            Assert.Equal(expectedResult, result);
        }
    }
}
