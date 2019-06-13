using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    public class PohligHellmanAlgorithmTest
    {
        public BigInteger doAlgo(BigInteger p, BigInteger a, BigInteger b)
        {
            //1 find dividers of (р-1)
            //Dictionary<BigInteger, int> q_alpha = Functions.q_alpha(p - 1);
            List< StructQAlX > q_al_x_List = new List< StructQAlX >();
            Functions.Set_q_alpha(out q_al_x_List, p-1);
            foreach (var item in q_al_x_List)
	{
                Console.WriteLine(item.q);
                Console.WriteLine(item.alpha);
                Console.WriteLine(item.x);
	}


            //2 table r
            //Dictionary<BigInteger, Dictionary<BigInteger, BigInteger>> r;
            //BigInteger[][] r = new BigInteger[q_alpha.Count][];
            List<StructR> r_list = new List<StructR>();
            /*for (int qi = 0; qi < length; qi++)
			{

			}*/
            /*for (long q = 2; q < q_alpha.Count; q++) // r[q][j]
            {
                for (long j = 0; j < q; j++)
                {
                    r[q][j] = Functions.pow(a, (j * (p - 1) / q));
                }
            }*/

            //3 system х
            

            //4 solve system х by Chinese remainder Th
            //here
            return -1;
        }

        public struct StructR
        {
            public BigInteger q;
            public BigInteger j;
            public BigInteger result;
        }

        public struct StructQAlX
        {
            public BigInteger q;
            public int alpha;
            public BigInteger x;

            public StructQAlX(BigInteger _q, int _alpha, BigInteger _x)
            {
                q = _q;
                alpha = _alpha;
                x = _x;
            }

            public StructQAlX(BigInteger _q, int _alpha)
            {
                q = _q;
                alpha = _alpha;
            }
        }
        /*
        //3 система х
        OptionalInt max = Arrays.stream(q_alpha).max();
        int [] x = new int[q_alpha.length];
        int [] modX = new int[q_alpha.length];
        int [] xi = new int[max.getAsInt()];
        for(int q = 2; q < q_alpha.length; q++){
            if (q_alpha[q] > 0) {
                int temp = (int)(pow(b, (p-1)/q) % p);
                for (int j = 0; j < q; j++){
                    if (temp == r[q][j]) {
                        xi[0] = j;
                    }
                }
                //заповнимо xi
                for(int iter = 1; iter < q_alpha[q]; iter++) { // for xi
                    temp = -xi[0]; //степень а
                    for(int i = 0; i < iter-1; i++) {
                        temp -= xi[i]*pow(q, i);

                    }
                    temp = (int)(pow(((int)(b*pow(a, temp))), ((p-1)/(int)pow(q, q_alpha[q])))%p);
                    for (int j = 0; j <= q_alpha[q]; j++){
                        if (temp  == r[q][j] ) {
                            xi[iter] = j;
                        }
                    }
                }
                //х[q] остаточне
                //x[q] = 0;
                for (int i = 0; i < q_alpha[q]; i++){
                    x[q] += xi[i]*pow(q, i);
                }
                modX[q] = (int) pow(q, q_alpha[q]);
                System.out.println(x[q]);
                System.out.println(modX[q]);
                System.out.println("");
            }
        }
        
        return 0;
        */
    }
}
