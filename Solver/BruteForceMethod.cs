using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

namespace discrete_logarithm_algorithms
{
    class BruteForceMethod
    {
        public static BigInteger Solve(BigInteger a, BigInteger b, BigInteger p)
        {
            BigInteger lastIteration = p^2;

            for (BigInteger i = 1; i <= lastIteration; i++)
            {
                if (BigMath.Pow(a, i) % p == b)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

