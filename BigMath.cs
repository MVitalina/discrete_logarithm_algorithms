﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace discrete_logarithm_algorithms
{
    public static class BigMath //TODO refactor 
    {
        public static BigInteger Sqrt(BigInteger number)
        {
            BigInteger t;
            BigInteger squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;  //TODO попытка деления на 0!        
            } while (BigInteger.Abs(t - squareRoot) > 1); //TODO is right

            return squareRoot;
        }

        public static BigInteger Pow(BigInteger number, BigInteger power)
        {
            if (power == -1)
                //return 1 / number;
                Console.WriteLine("POWER = -1");
            if (power == 0)
                return 1;
            BigInteger res = number;
            for (BigInteger i = 1; i < power; i++)
                res *= number;

            return res;
        }

        //extension
        public static BigInteger Mod(this BigInteger a, BigInteger p)
        {
            BigInteger result = a % p;
            if (result < 0)
            {
                result += p;
            }

            return result;
        }

        public static int OrderOfMagnitude(BigInteger number)
        {
            BigInteger num = number;
            int order = 0;
            while (num / 10 != 0)
            {
                num /= 10;
                order++;
            }
            return order;
        }

        public static BigInteger Random(BigInteger maxN)
        {
            byte[] bytes = maxN.ToByteArray();
            BigInteger R;
            Random random = new Random();
            do
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= 0x7F; //force sign bit to positive
                R = new BigInteger(bytes);
            } while (R >= maxN);

            return R;
        }

        public static BigInteger Random(int length, BigInteger maxN)
        {
            if (length <= 0)
                return -1;

            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            BigInteger R;
            byte[] randBytes = maxN.ToByteArray();
            do
            {
                rngCsp.GetBytes(randBytes);
                randBytes[randBytes.Length - 1] &= 0x7F; //force sign bit to positive
                R = new BigInteger(randBytes);
            } while (R >= maxN);
            rngCsp.Dispose();

            return BigInteger.Abs(new BigInteger(randBytes));
        }

        public static BigInteger Random(int length)
        {
            if (length <= 0)
                return -1;

            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] randBytes = new byte[length];
            rngCsp.GetBytes(randBytes);
            rngCsp.Dispose();

            return BigInteger.Abs(new BigInteger(randBytes));
        }

        public static bool IsPrime(BigInteger number)
        {
            if (number == 2 || number == 3)
            {
                return true;
            }
            for (int i = 5; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /*public BigInteger[] Primes = { 
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
            101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
            211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293,
            307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397,
            401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499,
            503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599,
            601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691,
            701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797,
            809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887,
            907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
        };

        public static bool IsPrime_Modification1(BigInteger number)
        {
            if (number == 2 || number == 3)
            {
                return true;
            }
            for (int i = 5; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }*/

        //TODO good comments
        //Дільники (q) числа (number) і їх кількість (alpha)
        public static Dictionary<BigInteger, int> Q_Alpha(BigInteger number)
        {
            Dictionary<BigInteger, int> q_alpha = new Dictionary<BigInteger, int>();
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    number /= i;
                    if (q_alpha.ContainsKey(i))
                        q_alpha[i]++;
                    else
                        q_alpha.Add(i, 1);
                    i--;
                }
            }

            return q_alpha;
        }

        //TODO which algo for GCD is better
        //НСД 
        public static BigInteger GCD_Euclidean(BigInteger n1, BigInteger n2)
        {
            /*
             якщо a = 0
                поверни b
             поки b ≠ 0
                 якщо a > b
                   a := a − b
                 інакше
                   b := b − a
             поверни a
             */

            BigInteger a = BigInteger.Abs(n1), 
                b = BigInteger.Abs(n2);

            if (a == 0)
            {
                return b;
            }

            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        public static BigInteger GCD_EuclideanExtended(BigInteger n1, BigInteger n2, ref BigInteger x, ref BigInteger y)
        {

            return -1;
            /*BigInteger a = BigInteger.Abs(n1),
                b = BigInteger.Abs(n2);

            if (b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int gcd = GCD_EuclideanExtended(b % a, a, ref x, out y);

            int newY = x;
            int newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;*/

        }

        /*public PohligHellmanAlgorithm.StructQAlX Set_q_alpha(out List< PohligHellmanAlgorithm.StructQAlX > q_al_List, BigInteger number)
        {
            for (BigInteger q = 2; q <= number / 2; q++) // can be less? (num/2) 
            {
                if (number % q == 0)
                {
                    number /= q;
                    if (q_al_List.Contains(st => st.q == q)) {
                        PohligHellmanAlgorithm.StructQAlX struc = q_al_List.Find(st => st.q == q);
                        struc.alpha++;
                    } else {
                        q_al_List.Add(new PohligHellmanAlgorithm.StructQAlX(q, 1));
                    }
                    q--;
                }
            }
        }*/
    }
}
