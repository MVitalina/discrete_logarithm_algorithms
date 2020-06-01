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
        public static BigInteger Solve(BigInteger a, BigInteger b, BigInteger p)
        {
            //1 find dividers of (р-1)
            Dictionary<BigInteger, int> q_alpha = BigInteger_SimpleMath.Q_Alpha(p - 1);

            //2 table r
            BigInteger q;
            // get index throught the loop
            BigInteger[][] r = new BigInteger[q_alpha.Count][];
            for (int q_index = 0; q_index < q_alpha.Count; q_index++)
            {
                q = q_alpha.ElementAt(q_index).Key;
                r[q_index] = new BigInteger[(int)q]; //TODO what to do with it
                for (int j = 0; j < q; j++)
                {
                    r[q_index][j] = BigInteger_SimpleMath.Pow(a, (j * (p - 1) / q)) % p; // r +
                }
            }
            //3 system х
            Dictionary<BigInteger, BigInteger> q_x = new Dictionary<BigInteger, BigInteger>();
            for (int q_index = 0; q_index < q_alpha.Count; q_index++)
            {
                q = q_alpha.ElementAt(q_index).Key;
                BigInteger[] xi = new BigInteger[q_alpha[q]];
                BigInteger temp; // b^power OR b*a^power

                for (int al = 0; al < q_alpha[q]; al++)
                {
                    if (al == 0)
                    {
                        temp = BigInteger_SimpleMath.Pow(b, (p - 1) / q) % p;
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
                        BigInteger power = xi[0];
                        for (int i = 1; i < al; i++) {
                            power += xi[i] * (int)BigInteger_SimpleMath.Pow(q, i);
                        }

                        if (power == 1)
                        {
                            temp = b / a;
                        }
                        else
                        {
                            temp = b * BigInteger_SimpleMath.Pow(a, -power);//a^(-x0-x1..) TODO power < 0
                        }

                        //temp = b * temp; //b*a
                        temp = BigInteger_SimpleMath.Pow(temp, (p - 1) / (BigInteger_SimpleMath.Pow(q, al + 1))); //(b*a)^(...)
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
                    x += xi[i] * BigInteger_SimpleMath.Pow(q, i);
                }  

                x = x % (BigInteger_SimpleMath.Pow(q, q_alpha[q]));
                q_x.Add(q, x);
                System.Diagnostics.Debug.WriteLine($"x = {x}; q = {q}"); //OK
            }

            //4 solve system х by Chinese remainder Th
            BigInteger X = 0;
            BigInteger M0 = 1;
            BigInteger[] Mi = new BigInteger[q_x.Count];
            BigInteger[] Yi = new BigInteger[q_x.Count];
            BigInteger[] mi = new BigInteger[q_x.Count];

            int counter = 0;
            foreach (var qx in q_x)
            {
                mi[counter] = BigInteger_SimpleMath.Pow(qx.Key, q_alpha[qx.Key]);
                M0 *= mi[counter];
                counter++;
            }

            counter = 0;
            foreach (var qx in q_x)
            {
                Mi[counter] = M0 / mi[counter];
                counter++;
            } 

            counter = 0;
            foreach (var qx in q_x)
            {
                for (int i = 1; i < mi[counter]; i++)
                {
                    if ((Mi[counter] * i - qx.Value) % mi[counter] == 0 )
                    {
                        Yi[counter] = i;
                        break;
                    }
                }
                X += Mi[counter] * Yi[counter];
                counter++;
            } 
            return X;
        }
    }
}
