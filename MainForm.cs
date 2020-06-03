using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrete_logarithm_algorithms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeCalculator();
            InitializeAnalyzer();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                bool isEverythingGood = BigInteger.TryParse(textBox.Text, out BigInteger number);

                //if (isEverythingGood && textBox == textBoxA)
                //{
                //    isEverythingGood = IsAGood(number);
                //}
                //else if (isEverythingGood && textBox == textBoxP)
                //{
                //    isEverythingGood = IsPGood(number);
                //}

                textBox.BackColor = isEverythingGood ?
                    SystemColors.Window : Color.FromArgb(255, 114, 111);
            }
        }

        private bool IsAGood(BigInteger a) 
        {
            return BigMath.OrderOfMagnitude(a) == BigMath.OrderOfMagnitude(P - 1);
        }

        private bool IsPGood(BigInteger p) //needs to be prime
        {
            return BigMath.IsPrime(p);
        }

        //TODO disable X
        //todo another thread
        //TODO Custom textBox control: coloring + validator (add yellow if computing longer than 5 sec) 
        //TODO logo
    }
}
