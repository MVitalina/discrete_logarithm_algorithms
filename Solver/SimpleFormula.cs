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
            Console.WriteLine(p);
            Console.WriteLine(a);
            Console.WriteLine(b);
            BigInteger result = 0;
            for (BigInteger j = 1; j <= p-2; j++)
            {
                BigInteger temp = BigInteger_SimpleMath.Pow(b, j);
                temp /= (BigInteger_SimpleMath.Pow(a, j) - 1);
                result += temp;
            }
            result %= (p - 1);
            Console.WriteLine(result);
            return result;
        }
    }
}
