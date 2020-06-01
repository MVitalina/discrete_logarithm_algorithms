using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class SimpleFormula
    {
        public static BigInteger Solve(BigInteger a, BigInteger b, BigInteger p)
        {
            BigInteger result = 0;
            for (BigInteger j = 1; j <= p-2; j++)
            {
                BigInteger temp = BigMath.Pow(b, j);
                temp /= (BigMath.Pow(a, j) - 1);
                result += temp;
            }
            result %= (p - 1);
            return result;
        }
    }
}
