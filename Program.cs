using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrete_logarithm_algorithms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


            /*var watch = System.Diagnostics.Stopwatch.StartNew();
            MatchingAlgorithm matchingAlgorithm = new MatchingAlgorithm();
            watch.Stop();
            var elapseMs = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine(matchingAlgorithm.doAlgo(17, 3, 13) );
            Console.WriteLine("Time = " + elapseMs + " ms");*/

            /*MatchingAlgorithm matchingAlgorithm = new MatchingAlgorithm();
            Console.WriteLine(matchingAlgorithm.doAlgo(17, 3, 13) ); */

            /*watch = System.Diagnostics.Stopwatch.StartNew();
            PohligHellmanAlgorithm pohligHellmanAlgorithm = new PohligHellmanAlgorithm();
            Console.WriteLine("result of Pol-Hel = " + pohligHellmanAlgorithm.doAlgo(37, 2, 28) );
            watch.Stop();
            elapseMs = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Time = " + elapseMs + " ms (not all)");*/

            /*SimpleFormula simpleFormula = new SimpleFormula();
            //Console.WriteLine("result of simple formula = " + simpleFormula.doAlgo(37, 2, 28));
            Console.WriteLine("result of simple formula = " + simpleFormula.doAlgo(17, 3, 13));*/

            /*PollardRhoAlgorithm pollardRhoAlgorithm = new PollardRhoAlgorithm(); dont work correctly
            Console.WriteLine("result of pollard Rho Algorithm = " + pollardRhoAlgorithm.doAlgo(17, 3, 13));*/

        }

    }
}
