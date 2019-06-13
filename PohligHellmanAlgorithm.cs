using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    public class PohligHellmanAlgorithm
    {
        public BigInteger doAlgo(BigInteger p, BigInteger a, BigInteger b)
        {
            //1 find dividers of (р-1)
            Dictionary<int, int> q_alpha = Functions.q_alpha(p - 1);


            //2 table r
            int q;
            // get index throught the loop
            BigInteger[][] r = new BigInteger[q_alpha.Count][];
            for (int iter = 0; iter < q_alpha.Count; iter++)
            {
                q = q_alpha.ElementAt(iter).Key;
                r[iter] = new BigInteger[q];
                for (int j = 0; j < q; j++)
                {
                    r[iter][j] = Functions.pow(a, (j * (p - 1) / q)) % p; // +
                }
            }
            //3 system х
            Dictionary<BigInteger, BigInteger> q_x;
            
            //4 solve system х by Chinese remainder Th
            //here
            return -1;
        }
    }
}
