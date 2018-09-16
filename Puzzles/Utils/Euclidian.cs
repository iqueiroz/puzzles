using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Utils
{
    public class Euclidian
    {
        public long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a == 0 ? b : a;
        }
        public long Gcd(long a, long b, long c)
        {
            return Gcd(a, Gcd(b, c));
        }

        public long Lcm(long a, long b)
        {
            return (a * b) / Gcd(a, b);
        }
        public long Lcm(long a, long b, long c)
        {
            return Lcm(a, Lcm(b, c));
        }
    }
}
