using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class PollardRhoAlgorithm
    {
        //TODO REFACTOR!!!

        private static BigInteger a;
        private static BigInteger b;
        private static BigInteger p;

        public static BigInteger Solve(BigInteger _a, BigInteger _b, BigInteger _p)
        {
            a = _a;
            b = _b;
            p = _p;

            //maybe array [?]
            List<BigInteger> u = new List<BigInteger>();
            List<BigInteger> v = new List<BigInteger>();
            List<BigInteger> z = new List<BigInteger>();
            int i = 0;
            u.Add(0);
            v.Add(0);
            z.Add(1); //[0]
            fillList(ref u, ref v, ref z, i); // [1] 
            i++; //i = 1
            fillList(ref u, ref v, ref z, i); // [2]
            i++; //i = 2

            int stopCounter = 0;
            while (stopCounter < 1000)
            {
                //if (i % 2 == 0)
                //{
                //if (z[i] == z[i / 2])
                int foundIndex = z.FindIndex(el => el == z[i]);
                    if (foundIndex != i)
                    {
                    //Console.WriteLine("GCD: " + BigMath.GCD_Euclidean((u[i] - u[i / 2]), (p - 1)));
                    //if (BigMath.GCD_Euclidean((u[i] - u[i / 2]), (p - 1)) == 1)
                    Console.WriteLine("GCD: " + BigMath.GCD_Euclidean((u[i] - u[foundIndex]), (p - 1)));
                    Console.WriteLine($"i: {i}; found: {foundIndex}");
                    if (BigMath.GCD_Euclidean((u[i] - u[foundIndex]), (p - 1)) == 1)
                    {
                        BigInteger result = v[foundIndex] - v[i];
                        result = result % (p - 1);
                        return result;
                    }
                }
                //}
                fillList(ref u, ref v, ref z, i); 
                i++;
                Console.WriteLine(stopCounter);
                stopCounter++;
            }

            return -1;


            /* while (Functions.GCD_Euclidean((u[i] - u[i / 2]), (p - 1)) != 1)
             {
                 //i = doLoop(p, a, b, ref u, ref v, ref z, i);
                 while (u[i] != u[i / 2])
                 {
                     if ((0 <= z[i]) && (z[i] <= p / 3))
                     {
                         u.Add(u[i] + 1);
                         v.Add(v[i]);
                         /*u[i + 1] = u[i] + 1;
                         v[i + 1] = v[i];
                     }
                     else
                     {
                         if ((p / 3 < z[i]) && (z[i] <= 2 * p / 3))
                         {
                             u.Add(2 * u[i]);
                             v.Add(2 * v[i]);
                             /*u[i + 1] = 2 * u[i];
                             v[i + 1] = 2 * v[i];
                         }
                         else
                         {
                             if ((2 * p / 3 < z[i]) && (z[i] <= p))
                             {
                                 u.Add(u[i]);
                                 v.Add(v[i] + 1);
                                 /*u[i + 1] = u[i];
                                 v[i + 1] = v[i] + 1;
                             }
                         }
                     }
                     z.Add(Functions.pow(b, u[i + 1]) * Functions.pow(a, v[i + 1]));
                     //z[i + 1] = Functions.pow(b, u[i + 1]) * Functions.pow(a, v[i + 1]);
                     z[i + 1] = z[i + 1] % (p - 1);
                     System.Diagnostics.Debug.WriteLine("z = " + z[i+1]);
                     i++;
                 }
             } 
             BigInteger res = v[i / 2] - v[i];
             res = res % (p - 1);
             return res;*/
        }

        private static void fillList(ref List<BigInteger> u, ref List<BigInteger> v, ref List<BigInteger> z, int i) //i - previous
        {
            if ((0 <= z[i]) && (z[i] <= p / 3))
            {
                u.Add(u[i] + 1);
                v.Add(v[i]);
            }
            else if ((p / 3 < z[i]) && (z[i] <= 2 * p / 3))
            {
                u.Add(2 * u[i]);
                v.Add(2 * v[i]);
            }
            else if ((2 * p / 3 < z[i]) && (z[i] <= p))
            {
                u.Add(u[i]);
                v.Add(v[i] + 1);
            }

            z.Add(BigMath.Pow(b, u[i + 1]) * BigMath.Pow(a, v[i + 1]));
            z[i + 1] = z[i + 1] % (p - 1);

        }
    }
}
