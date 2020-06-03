using System;
using System.Collections.Generic;
using System.Linq;
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
            //TODO
        }

        private Analyzer() //needs to be private to construct logger only in Instance
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
