using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class Solver
    {
        public static BigInteger Solve(TypeOfAlgo _type, BigInteger _a, BigInteger _b, BigInteger _p)
        {   
            return Instance.PrivateSolve(_type, _a, _b, _p);
        }

        private BigInteger PrivateSolve(TypeOfAlgo type, BigInteger a, BigInteger b, BigInteger p)
        {
            //TODO idea:
            //instance = switch -> class
            //instance.solve

            BigInteger result = -1;

            switch (type)
            {
                case TypeOfAlgo.BruteForce:
                    result = BruteForceMethod.Solve(a, b, p);
                    break;
                case TypeOfAlgo.SimpleFormula:
                    result = SimpleFormula.Solve(a, b, p);
                    break;
                case TypeOfAlgo.Matching:
                    result = MatchingAlgorithm.Solve(a, b, p);
                    break;
                case TypeOfAlgo.PohligHellman:
                    result = PohligHellmanAlgorithm.Solve(a, b, p);
                    break;
                case TypeOfAlgo.PollardRho:
                    result = PollardRhoAlgorithm.Solve(a, b, p);
                    break;
            }

            //Console.WriteLine(CheckResult(a, b, p, result) ? "____________________correct" : "wrong");

            return result;
        }

        public static bool CheckResult(BigInteger a, BigInteger b, BigInteger p, BigInteger x)
        {
            if (x < 0)
            {
                return false;
            }

            bool isSubstitutionCorrect = BigMath.Pow(a, x) % p == b;
            return isSubstitutionCorrect;
        }

        private Solver() //needs to be private to construct only in Instance
        {
        }

        private static Solver Instance
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

            internal static readonly Solver instance = new Solver(); //instantiated once when it's first referenced
        }

        //TODO needed
        public static BigInteger MaxValue(Type type)
        {
            if (type == typeof(Byte))
                return Byte.MaxValue;
            else if (type == typeof(UInt16))
                return UInt16.MaxValue;
            else if (type == typeof(UInt32))
                return UInt32.MaxValue;
            else if (type == typeof(UInt64))
                return UInt64.MaxValue;
            else if (type == typeof(BigInteger))
                return BigInteger.Parse("1" + new string('0', 100));
            else
                throw new ArgumentException("Invalid argument.", "type");
        }
    }
}
