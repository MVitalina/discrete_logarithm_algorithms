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
            BigInteger lastIteration = p*p;

            BigInteger result = a;
            for (BigInteger i = 1; i <= lastIteration; i++)
            {
                if (result % p == b)
                {
                    return i;
                }

                result *= a;

                //if (i % 100 == 0)
                //    Console.WriteLine(i);
            }

            return -1;
        }
    }
}

