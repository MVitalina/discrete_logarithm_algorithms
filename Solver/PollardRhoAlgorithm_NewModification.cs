using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace discrete_logarithm_algorithms
{
    class PollardRhoAlgorithm_NewModification
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

                    //BigInteger d = BigMath.GCD_Euclidean(m, p - 1); //+
                    //Console.WriteLine("d: " + d);

                    //BigInteger result = ((a - A) / (B - b)).Mod(p);
                    for (BigInteger i = 0; i < p; i++)
                    {
                        BigInteger temp = m * i % (p - 1);
                        if (temp == n)
                        {
                            return i;
                        }

                        if (i % 100 == 0)
                            Console.WriteLine(i);
                    }

                    return -1;

                    //if ((BigMath.Pow(q, m) % p) != (BigMath.Pow(r, n) % p)) //just a check
                    //{
                    //    Console.WriteLine("(BigMath.Pow(q, m) % p) != (BigMath.Pow(r, n) % p)");
                    //    //return -1;
                    //}
                    //BigInteger d = BigMath.GCD_Euclidean(m, p - 1); //+

                    //for (int i = 0; i < d; i++)
                    //{
                    //    //if (BigMath.Pow(r, ))
                    //}
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
            else if ((p / 3 < x) && (x <= 2 * p / 3)) //TODO modification: порахувати зразу
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

        private static void RefreshValues_(ref BigInteger x, ref BigInteger a, ref BigInteger b,
            BigInteger r, BigInteger q, BigInteger p)
        {
            int i = (int)x % 3;
            switch (i)
            {
                case 0:
                    x = x * x;
                    a = 2 * a;
                    b = 2 * b;
                    break;
                case 1:
                    x = r * x;
                    a++;
                    break;
                case 2:
                    x = q * x;
                    b++;
                    break;
                default:
                    break;
            }

            x = x % (p);
            a = a % (p - 1);
            b = b % (p - 1);
        }
    }
}
