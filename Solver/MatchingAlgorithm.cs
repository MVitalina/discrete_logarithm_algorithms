﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace discrete_logarithm_algorithms
{
    class MatchingAlgorithm
    {
        public static BigInteger Solve(BigInteger a, BigInteger b, BigInteger p)
        {
            BigInteger H = BigMath.Sqrt(p) + 1;
            
            //c = a^H mod p
            BigInteger c = BigMath.Pow(a, H);
            c = c % p;

            //TODO sorted needed + -> change
            Dictionary<BigInteger, BigInteger> table1 = new Dictionary<BigInteger, BigInteger>();
            for (BigInteger u = 1; u <= H; u++)
            {
                table1.Add(u, BigMath.Pow(c, u) % p);
            }

            Dictionary<BigInteger, BigInteger> table2 = new Dictionary<BigInteger, BigInteger>();
            for (BigInteger v = 0; v <= H; v++)
            {
                table2.Add(v, b * BigMath.Pow(a, v) % p);
                foreach (KeyValuePair<BigInteger, BigInteger> t1 in table1)
                {
                    if (table1[t1.Key] == table2[v])
                    {
                        return (H * t1.Key - v) % (p - 1);
                    }
                }
            }
            return -1;
        }
    }
}

