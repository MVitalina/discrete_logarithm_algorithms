using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class Analyzer
    {

        public static List<Tuple<TypeOfAlgo, double>> Analyze(List<TypeOfAlgo> _types, int _a_digits, int _b_digits, int _p_digits, int _numRuns)
        {
            return Instance.PrivateAnalyze(_types, _a_digits, _b_digits, _p_digits, _numRuns);
        }

        private List<Tuple<TypeOfAlgo, double>> PrivateAnalyze(List<TypeOfAlgo> types, int a_digits, int b_digits, int p_digits, int numRuns)
        {
            List<Tuple<TypeOfAlgo, double>> result = new List<Tuple<TypeOfAlgo, double>>(); 

            GenerateNumbers(p_digits, a_digits, b_digits, 
                out BigInteger p, out BigInteger a, out BigInteger b);

            for (int iType = 0; iType < types.Count; iType++)
            {
                TypeOfAlgo type = types[iType];
                double allTimeForRuns = 0;
                bool first = true; //bad result
                for (int iRun = 0; iRun < numRuns; iRun++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    BigInteger _ = Solver.Solve(type, a, b, p);
                    watch.Stop();
                    allTimeForRuns += first ? 0 : watch.Elapsed.TotalMilliseconds;
                    first = false;
                }
                double averageTime = allTimeForRuns / (numRuns - 1);
                result.Add(new Tuple<TypeOfAlgo, double>(type, averageTime)); //+
                Console.WriteLine($"{type}: {averageTime}");
            }
            return result;
        }   

        private void GenerateNumbers(int p_digits, int a_digits, int b_digits, out BigInteger p, out BigInteger a, out BigInteger b)
        { 
            do
            {
                p = BigMath.Random(p_digits);
            }
            while (!IsPGood(p));

            do
            {
                a = BigMath.Random(a_digits);
            }
            while (!IsAGood(a, p));

            b = BigMath.Random(b_digits, p);
        }

        private bool IsAGood(BigInteger a, BigInteger p)
        {
            return BigMath.OrderOfMagnitude(a) == BigMath.OrderOfMagnitude(p - 1);
        }

        private bool IsPGood(BigInteger p) //needs to be prime
        {
            return BigMath.IsPrime(p);
        }

        private Analyzer() //needs to be private to construct only in Instance
        {
        }

        private static Analyzer Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested //instantiated lazily, because not marked with flag "BeforeFieldInit"
        {
            static Nested() //static ctor -> not marked with flag "BeforeFieldInit"
            {
            }

            internal static readonly Analyzer instance = new Analyzer(); //instantiated once when it's first referenced
        }
    }
}
