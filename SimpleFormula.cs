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
        public BigInteger doAlgo(BigInteger p, BigInteger a, BigInteger b)
        {
            BigInteger result = 0;
            for (BigInteger j = 1; j <= p-2; j++)
            {
                result = Functions.pow(b, j);
                result = result / (Functions.pow(a, j) - 1);
            }
            result = result % (p - 1);
            return result;
        }
    }
}
