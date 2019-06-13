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
            for (int q_index = 0; q_index < q_alpha.Count; q_index++)
            {
                q = q_alpha.ElementAt(q_index).Key;
                r[q_index] = new BigInteger[q];
                for (int j = 0; j < q; j++)
                {
                    r[q_index][j] = Functions.pow(a, (j * (p - 1) / q)) % p; // r +
                }
            }
            //3 system х
            Dictionary<BigInteger, BigInteger> q_x;
            for (int q_index = 0; q_index < q_alpha.Count; q_index++)
            {
                q = q_alpha.ElementAt(q_index).Key;
                int [] x = new int [q_alpha[q]];
                int x;
                BigInteger temp; // b^ = .. = in r
                for (int al = 0; al < q_alpha[q]; al++)
                {
                    if (al == 0)
                    {
                        temp = Functions.pow(b, (p - 1) / q) % p;
                        for (int j = 0; j < q; j++) 
                        {
                            if (r[q_index][j] == temp) //search in table r
                            {
                                x[al] = j; // x0 +
                                System.Diagnostics.Debug.WriteLine(x[al]);
                            }
                        }
                    }
                    else
                    {
                        BigInteger power = x[0];
                        for (int i = 1; i < al; i++) {
                            power += x[i] * Functions.pow(q, i);
                        }
                        temp = Functions.pow(b*Functions.pow(a, -power), (p-1)/(Functions.pow(q, al))) % p;
                        //x1 x2.....x al-1
                    }
                    //x += x[al];
                }
            }
            //4 solve system х by Chinese remainder Th
            //here
            return -1;
        }
    }
}
