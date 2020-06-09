using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace discrete_logarithm_algorithms
{
    class PollardRhoAlgorithmNewModification
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
                    BigInteger m = (a - A).Mod(p - 1), 
                        n = (B - b).Mod(p - 1);

                    for (BigInteger i = 1; i < p; i++)
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
                }
            }

            return -1;
        }

        private static void RefreshValues(ref BigInteger x, ref BigInteger a, ref BigInteger b,
            BigInteger r, BigInteger q, BigInteger p)
        {
            int i = (int)x % 3;
            switch (i)
            {
                case 0:
                    x = r * x;
                    b++;
                    break;
                case 1:
                    x = q * x;
                    a++;
                    break;
                case 2:
                    x = x * x;
                    a = 2 * a;
                    b = 2 * b;
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
