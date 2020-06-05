using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrete_logarithm_algorithms
{
    partial class MainForm //Analyzer Tab
    {
        int PATTERN_LENGTH = typesDict.Count;
        string m_pattern = "11111";
        static Dictionary<TypeOfAlgo, string> typesDict = new Dictionary<TypeOfAlgo, string>()
        {
            { TypeOfAlgo.BruteForce,
                "Brute Force" },
            { TypeOfAlgo.SimpleFormula,
                "Simple Formula" },
            { TypeOfAlgo.Matching,
                "Matching" },
            { TypeOfAlgo.PohligHellman,
                "Pohlig Hellman" },
            { TypeOfAlgo.PollardRho,
                "Pollard Rho" }
        };

        private void InitializeAnalyzer()
        {
            for (int i = 0; i < PATTERN_LENGTH; i++)
            {
                checkedListBox.SetItemChecked(i, m_pattern[i] == '1');
            }
        }

        private void checkedListBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is CheckedListBox listBox)
            {
                int itemHeight = 16;
                listBox.Height = itemHeight * PATTERN_LENGTH;
            }
        }

        private void checkedListBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is CheckedListBox listBox)
            {
                listBox.Height = 19;
            }
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            //progressBar.Visible = true;

            SetAlgoPatternFromUI();
            if (!m_pattern.Contains("1"))
            {
                MessageBox.Show("Помилка: виберіть хоча б одну колонку для відображення!");
                return;
            }
            for (int i = 0; i < m_pattern.Length; i++)
            {
                if (m_pattern[i] == '1')
                {
                    Console.WriteLine((TypeOfAlgo)i);

                    Analyzer.Analyze((TypeOfAlgo)i, 
                        (int)numericUpDownA.Value, (int)numericUpDownB.Value, (int)numericUpDownP.Value, 
                        (int)numericNumRuns.Value);
                }
            }

            //progressBar.Visible = false;
        }

        void SetAlgoPatternFromUI()
        {
            m_pattern = "";
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                    m_pattern += "1";
                else
                    m_pattern += "0";
            }
        }
    }
}
