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
            //test
            InitializeComponent();
            A = 0;
            B = 0;
            P = 0;

            textBoxA.Text = "3";
            textBoxB.Text = "13";
            textBoxP.Text = "17";
            ParseVariables();
        }

        //TODO disable X
        //TODO another thread
        //TODO Custom textBox control: coloring + validator (add yellow if computing longer than 5 sec) 
        //TODO logo

        private void ParseVariables()
        {
            //TODO try catch needed
            A = BigInteger.Parse(textBoxA.Text);
            B = BigInteger.Parse(textBoxB.Text);
            P = BigInteger.Parse(textBoxP.Text);
        }

        private void buttonSimpleFormula_Click(object sender, EventArgs e)
        {
            StartProcess(TypeOfAlgo.SimpleFormula, labelSF);
        }

        private void buttonBruteForce_Click(object sender, EventArgs e)
        {
            StartProcess(TypeOfAlgo.BruteForce, labelBF);
        }

        private void buttonMatching_Click(object sender, EventArgs e)
        {
            StartProcess(TypeOfAlgo.Matching, labelMA);
        }

        private void buttonPohligHellman_Click(object sender, EventArgs e)
        {
            StartProcess(TypeOfAlgo.PohligHellman, labelPHA);
        }

        private void buttonRhoPollard_Click(object sender, EventArgs e)
        {
            StartProcess(TypeOfAlgo.PollardRho, labelRho);
        }

        private void StartProcess(TypeOfAlgo type, Label label)
        {
            ParseVariables();

            //TODO measurer
            var watch = System.Diagnostics.Stopwatch.StartNew(); 
            BigInteger result = Solver.Solve(type, A, B, P);
            watch.Stop();
            double elapsedMs = watch.Elapsed.TotalMilliseconds;

            //TODO red background if -1  
            //TODO "Time: error"
            textBoxX.Text = result.ToString();
            label.Text = "Time: " + elapsedMs.ToString() + " ms";
        }
    }
}
