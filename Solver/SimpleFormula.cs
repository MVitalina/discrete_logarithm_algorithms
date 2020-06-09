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
            BigInteger counter = 0;
            BigInteger sum = 0;
            for (int j = 1; j <= p - 2; j++)
            {
                sum += BigInteger.Pow(b, j) / (BigInteger.Pow(a, j) - 1);
                counter++;
            }

            //sum <= (sum) < sum + counter, because / is about integer division
            for (BigInteger i = 0; i <= counter; i++)
            {
                BigInteger result = (sum + i) % (p - 1);

                if (BigMath.Pow(a, result) % p == b)
                {
                    return result;
                }
            }

            return -1;
        }

        
    }
}
