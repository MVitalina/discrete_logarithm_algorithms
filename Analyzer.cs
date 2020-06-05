using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class Analyzer
    {

        public static void Analyze(TypeOfAlgo _type, int _a_digits, int _b_digits, int _p_digits, int _numRuns)
        {
            Instance.PrivateAnalyze(_type, _a_digits, _b_digits, _p_digits, _numRuns);
        }

        private void PrivateAnalyze(TypeOfAlgo type, int a_digits, int b_digits, int p_digits, int numRuns)
        {
            BigInteger p, a, b;
            GenerateNumbers(a_digits, b_digits, out p, out a, out b);

            double allTimeForRuns = 0;
            bool first = true; //bad result
            for (int i = 0; i < numRuns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                BigInteger _ = Solver.Solve(type, a, b, p);
                watch.Stop();
                Console.WriteLine(watch.Elapsed.TotalMilliseconds);
                allTimeForRuns += first ? 0 : watch.Elapsed.TotalMilliseconds;
            }
            double averageTime = allTimeForRuns / numRuns;
            Console.WriteLine(averageTime);
        }

        private void GenerateNumbers(int a_digits, int b_digits, out BigInteger p, out BigInteger a, out BigInteger b)
        {
            do
            {
                p = BigMath.Random(a_digits);
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
