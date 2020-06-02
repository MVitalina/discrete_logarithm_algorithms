﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace discrete_logarithm_algorithms
{
    public class BigMath //TODO refactor 
    {
        public static BigInteger Sqrt(BigInteger number)
        {
            BigInteger t;
            BigInteger squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;                
            } while (BigInteger.Abs(t - squareRoot) > 1); //TODO is right

            return squareRoot;
        }

        public static BigInteger Pow(BigInteger number, BigInteger power)
        {
            if (power == -1)
                return 1 / number;
            if (power == 0)
                return 1;
            BigInteger res = number;
            for (BigInteger i = 1; i < power; i++)
                res *= number;

            return res;
        }

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
            //TODO refactor - don`t use 'in' vars

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

            if (n1 == 0)
            {
                return n2;
            }

            while (n2 != 0)
            {
                if (n1 > n2)
                {
                    n1 = n1 - n2;
                }
                else
                {
                    n2 = n2 - n1;
                }
            }

            return n1; // +
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