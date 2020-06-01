using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    partial class Solver
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

            switch (type)
            {
                case TypeOfAlgo.BruteForce:
                    return BruteForceMethod.Solve(a, b, p);
                case TypeOfAlgo.SimpleFormula:
                    return SimpleFormula.Solve(a, b, p);
                case TypeOfAlgo.Matching:
                    return MatchingAlgorithm.Solve(a, b, p);
                case TypeOfAlgo.PohligHellman:
                    return PohligHellmanAlgorithm.Solve(a, b, p);
                case TypeOfAlgo.PollardRho:
                    return PollardRhoAlgorithm.Solve(a, b, p);
            }

            return -1;
        }

        private Solver() //needs to be private to construct logger only in Instance
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
    }
}
