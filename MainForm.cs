using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrete_logarithm_algorithms
{
    public partial class MainForm : Form
    {
        BigInteger A, B, P;

        public MainForm()
        {
            InitializeComponent();
            textBoxA.Text = "3";
            textBoxB.Text = "13";
            textBoxP.Text = "17";
        }

        private void buttonSF_Click(object sender, EventArgs e)
        {
            A = BigInteger.Parse(textBoxA.Text);
            B = BigInteger.Parse(textBoxB.Text);
            P = BigInteger.Parse(textBoxP.Text);

            SimpleFormula simpleFormula = new SimpleFormula();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BigInteger result = simpleFormula.doAlgo(P, A, B);
            watch.Stop();
            var elapseMs = watch.Elapsed.TotalMilliseconds;

            textBoxX.Text = result.ToString();
            labelSF.Text = "Time: " + elapseMs.ToString() + " ms";

            //Console.WriteLine("result of simple formula = " + simpleFormula.doAlgo(37, 2, 28));
            //Console.WriteLine("result of simple formula = " + simpleFormula.doAlgo(17, 3, 13));
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
        }

        private void buttonMA_Click(object sender, EventArgs e)
        {
            A = BigInteger.Parse(textBoxA.Text);
            B = BigInteger.Parse(textBoxB.Text);
            P = BigInteger.Parse(textBoxP.Text);

            MatchingAlgorithm matchingAlgorithm = new MatchingAlgorithm();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BigInteger result = matchingAlgorithm.doAlgo(P, A, B);
            watch.Stop();
            var elapseMs = watch.Elapsed.TotalMilliseconds;

            textBoxX.Text = result.ToString();
            labelMA.Text = "Time: " + elapseMs.ToString() + " ms";

            //MatchingAlgorithm matchingAlgorithm = new MatchingAlgorithm();
            //Console.WriteLine(matchingAlgorithm.doAlgo(17, 3, 13));
        }

        private void buttonPHA_Click(object sender, EventArgs e)
        {
            A = BigInteger.Parse(textBoxA.Text);
            B = BigInteger.Parse(textBoxB.Text);
            P = BigInteger.Parse(textBoxP.Text);

            PohligHellmanAlgorithm pohligHellmanAlgorithm = new PohligHellmanAlgorithm();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BigInteger result = pohligHellmanAlgorithm.doAlgo(P, A, B);
            watch.Stop();
            var elapseMs = watch.Elapsed.TotalMilliseconds;

            textBoxX.Text = result.ToString();
            labelPHA.Text = "Time: " + elapseMs.ToString() + " ms";
        }

        private void buttonRo_Click(object sender, EventArgs e)
        {
            A = BigInteger.Parse(textBoxA.Text);
            B = BigInteger.Parse(textBoxB.Text);
            P = BigInteger.Parse(textBoxP.Text);

            PollardRhoAlgorithm pollardRhoAlgorithm = new PollardRhoAlgorithm();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BigInteger result = pollardRhoAlgorithm.doAlgo(P, A, B);
            watch.Stop();
            var elapseMs = watch.Elapsed.TotalMilliseconds;

            textBoxX.Text = result.ToString();
            labelRo.Text = "Time: " + elapseMs.ToString() + " ms";

            //PollardRhoAlgorithm pollardRhoAlgorithm = new PollardRhoAlgorithm(); 

        }
    }
}
