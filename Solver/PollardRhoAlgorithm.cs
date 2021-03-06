﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace discrete_logarithm_algorithms
{
    class PollardRhoAlgorithm
    {   
        public static BigInteger Solve(BigInteger _a, BigInteger _b, BigInteger p)
        {
            BigInteger r = _a, q = _b;
            BigInteger x = 1, a = 0, b = 0;
            BigInteger X = x, A = a, B = b;

            for (int iterator = 1; iterator < p; iterator++)
            {
                RefreshValues(ref x, ref a, ref b, r, q, p);
                RefreshValues(ref X, ref A, ref B, r, q, p); //2i - 2
                RefreshValues(ref X, ref A, ref B, r, q, p);

                if (x == X)
                {
                    BigInteger m = (a - A).Mod(p - 1),  // + + 
                        n = (B - b).Mod(p - 1);

                    if (m == 0)
                    {
                        return -1;
                    }

                    BigInteger gcd = BigMath.GCD_EuclideanExtended(m, p - 1, out BigInteger mu, out BigInteger pu);

                    Console.WriteLine(gcd);
                    BigInteger temp =  (mu * n).Mod(p - 1);

                    for (BigInteger w = 0; w <= gcd; w++) 
                    {
                        BigInteger result = ((temp + w * (p - 1)) / gcd).Mod(p - 1);
                        if (BigMath.Pow(r, result) % p == q)
                        {
                            return result;
                        }
                        else if (w % 2 == 0 && BigMath.Pow(-r, result).Mod(p) == q)
                        {
                            return result;
                        }
                        //if (w % 2 == 0) //sqrt(x^2y) = abs(x^y) = (+-)x^y
                        //{
                        //    result = ((temp + w * (p - 1)) / gcd).Mod(p - 1);
                        //    Console.WriteLine(result);
                        //    if (BigMath.Pow(r, result) % p == q)
                        //    {
                        //        return result;
                        //    }
                        //}
                    }

                    return -1;
                }
            }

            return -1;
        }

        private static void RefreshValues(ref BigInteger x, ref BigInteger a, ref BigInteger b, 
            BigInteger r, BigInteger q, BigInteger p)
        {
            if ((0 <= x) && (x <= p / 3))
            {
                x = q * x;
                a++;
                //b = b;
            }
            else if ((p / 3 < x) && (x <= 2 * p / 3))
            {
                x = x * x;
                a = 2 * a;
                b = 2 * b;
            }
            else if ((2 * p / 3 < x) && (x <= p))
            {
                x = r * x;
                //a = a;
                b++;
            }

            x = x % (p); 
            a = a % (p - 1);
            b = b % (p - 1);
        }
    }
}
