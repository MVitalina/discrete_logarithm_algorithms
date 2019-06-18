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
            Dictionary<BigInteger, BigInteger> q_x = new Dictionary<BigInteger, BigInteger>();
            for (int q_index = 0; q_index < q_alpha.Count; q_index++)
            {
                q = q_alpha.ElementAt(q_index).Key;
                int[] xi = new int[q_alpha[q]];
                BigInteger temp; // b^power OR b*a^power

                for (int al = 0; al < q_alpha[q]; al++)
                {
                    if (al == 0)
                    {
                        temp = Functions.pow(b, (p - 1) / q) % p;
                        //System.Diagnostics.Debug.WriteLine("temp = " + temp);
                        for (int j = 0; j < q; j++) 
                        {
                            if (r[q_index][j] == temp) //search in table r
                            {
                                xi[al] = j; //x0 +
                            }
                        }
                    }
                    else 
                    {
                        int power = xi[0];
                        for (int i = 1; i < al; i++) {
                            power += xi[i] * (int)Functions.pow(q, i);
                        }

                        if (power == 1)
                        {
                            temp = b / a;
                        }
                        else
                        {
                            temp = b * Functions.pow(a, -power);//a^(-x0-x1..) TODO power < 0
                        }

                        //temp = b * temp; //b*a
                        temp = Functions.pow(temp, (p - 1) / (Functions.pow(q, al + 1))); //(b*a)^(...)
                        temp = temp % p; //(mod p)
                        //System.Diagnostics.Debug.WriteLine("temp = " + temp);
                        for (int j = 0; j < q; j++)
                        {
                            if (r[q_index][j] == temp) //search in table r
                            {
                                xi[al] = j; //xi + 
                            }
                        }
                    }
                    //x += x[al];
                }
                BigInteger x = xi[0];
                for (int i = 1; i < xi.Length; i++)
                {
                    x += xi[i] * Functions.pow(q, i);
                }  

                x = x % (Functions.pow(q, q_alpha[q]));
                q_x.Add(q, x);
                //System.Diagnostics.Debug.WriteLine("x = " + x);
            }
            //4 solve system х by Chinese remainder Th
            //Harner algo

            /*for (int i = 0; i < k; ++i)
            {
                x[i] = a[i];
                for (int j = 0; j < i; ++j)
                {
                    x[i] = r[j][i] * (x[i] - x[j]);

                    x[i] = x[i] % p[i];
                    if (x[i] < 0) x[i] += p[i];
                }
            }*/

            return -1;
        }
    }
}
