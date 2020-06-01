using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_logarithm_algorithms
{
    class TimeMeasurer
    {
        public static void Run()
        {
            Instance.PrivateRun();
        }

        private void PrivateRun()
        {
            //TODO later
        }

        private TimeMeasurer() //needs to be private to construct logger only in Instance
        {
        }

        private static TimeMeasurer Instance
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

            internal static readonly TimeMeasurer instance = new TimeMeasurer(); //instantiated once when it's first referenced
        }
    }
}
