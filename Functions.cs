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
            BigInteger res = number;
            for (BigInteger i = 1; i < power; i++)
                res *= number;
            return res;
        }

        //Дільники (q) числа (number) і їх кількість (alpha)
        public static Dictionary<long, int> q_alpha(BigInteger number) //not BigInteger
        {
            Dictionary<BigInteger, int> q_alpha = new Dictionary<BigInteger, int>();
            for (BigInteger i = 2; i <= number / 2; i++)
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
    }
}
