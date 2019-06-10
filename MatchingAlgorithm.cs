using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace discrete_logarithm_algorithms
{
    public class MatchingAlgorithm
    {
        public BigInteger doAlgo(BigInteger p, BigInteger a, BigInteger b)
        {
            BigInteger H = Functions.sqrt(p) + 1;
            //c = a^H mod p
            BigInteger c = Functions.pow(a, H);
            c = c % p;

            SortedDictionary<BigInteger, BigInteger> table1 = new SortedDictionary<BigInteger, BigInteger>();
            for (BigInteger u = 1; u <= H; u++)
                table1.Add(u, Functions.pow(c, u) % p);
            SortedDictionary<BigInteger, BigInteger> table2 = new SortedDictionary<BigInteger, BigInteger>();
            for (BigInteger v = 0; v <= H; v++)
            {
                table2.Add(v, b * Functions.pow(a, v) % p);
                foreach (KeyValuePair<BigInteger, BigInteger> t1 in table1)
                {
                    if (table1[t1.Key] == table2[v])
                        return (H * t1.Value - table2[v]) % (p - 1);
                }
            }
            return -1;
        }
    }
}

