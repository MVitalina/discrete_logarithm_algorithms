using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace discrete_logarithm_algorithms
{
    class MatchingAlgorithm
    {
        public static BigInteger Solve(BigInteger a, BigInteger b, BigInteger p)
        {
            BigInteger H = BigInteger_SimpleMath.Sqrt(p) + 1;
            
            //c = a^H mod p
            BigInteger c = BigInteger_SimpleMath.Pow(a, H);
            c = c % p;

            SortedDictionary<BigInteger, BigInteger> table1 = new SortedDictionary<BigInteger, BigInteger>();
            for (BigInteger u = 1; u <= H; u++)
            {
                table1.Add(u, BigInteger_SimpleMath.Pow(c, u) % p);
            }

            SortedDictionary<BigInteger, BigInteger> table2 = new SortedDictionary<BigInteger, BigInteger>();
            for (BigInteger v = 0; v <= H; v++)
            {
                table2.Add(v, b * BigInteger_SimpleMath.Pow(a, v) % p);
                foreach (KeyValuePair<BigInteger, BigInteger> t1 in table1)
                {
                    if (table1[t1.Key] == table2[v])
                    {
                        return (H * t1.Value - table2[v]) % (p - 1);
                    }
                }
            }
            return -1;
        }
    }
}

