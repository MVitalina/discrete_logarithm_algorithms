using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace discrete_logarithm_algorithms
{
    public class Functions
    {
        public static BigInteger sqrt(BigInteger number) {
            BigInteger t;
            BigInteger squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;                
            } while (BigInteger.Abs(t - squareRoot) > 1); //TODO is right
            return squareRoot;
        }

        public static BigInteger pow(BigInteger number, BigInteger power)
        {
            if (power == 0)
                return 1;
            BigInteger res = number;
            for (BigInteger i = 1; i < power; i++)
                res *= number;
            return res;
        }

        //Дільники (q) числа (number) і їх кількість (alpha)
        public static Dictionary<int, int> q_alpha(BigInteger number)
        {
            Dictionary<int, int> q_alpha = new Dictionary<int, int>();
            for (int i = 2; i <= number / 2; i++)
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
