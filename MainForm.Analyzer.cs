using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrete_logarithm_algorithms
{
    partial class MainForm //Analyzer Tab
    {
        delegate void resultHandler(DataTable dt);
        private event resultHandler ResultReady;

        private const string AlgorithmCol = "Algorithm";
        private const string AvarageCol = "Avarage solving time";
        readonly int PATTERN_LENGTH = TypesOfAlgoDictypesDict.Count;
        string m_pattern = "11111";
        static readonly Dictionary<TypeOfAlgo, string> TypesOfAlgoDictypesDict = new Dictionary<TypeOfAlgo, string>()
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
                
            ResultReady += OnResultReady;
        }

        internal void OnResultReady(DataTable dataTable)
        {
            if (InvokeRequired)
            {
                Invoke(new resultHandler(OnResultReady), new object[] { dataTable });
            }
            else
            {
                ChangeDataSourceOfGrid(dataTable);
            }
        }

        public void ChangeDataSourceOfGrid(DataTable dataTable)
        {
            gridMain.DataSource = null;
            gridMain.DataSource = dataTable;
            SetColumnWidth();
        }

        private void SetColumnWidth()
        {
            if (gridMain.Columns.Contains(AlgorithmCol))
            {
                gridMain.Columns[AlgorithmCol].Width = 200;
            }
            
            if (gridMain.Columns.Contains(AvarageCol))
            {
                gridMain.Columns[AvarageCol].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private async void buttonAnalyze_Click(object sender, EventArgs e)
        {
            SetAlgoPatternFromUI();
            if (!m_pattern.Contains("1"))
            {
                MessageBox.Show("Please select at least one column to display!", "Error"); //icon
                return;
            }

            List<TypeOfAlgo> neededTypes = new List<TypeOfAlgo>();
            for (int i = 0; i < m_pattern.Length; i++)
            {
                if (m_pattern[i] == '1')
                {
                    neededTypes.Add((TypeOfAlgo)i);
                }
            }

            progressBar.Visible = true;
            buttonAnalyze.Enabled = false;

            await Task.Factory.StartNew(() =>
            {
                List<Tuple<TypeOfAlgo, double>> resultList = Analyzer.Analyze(neededTypes,
                    (int)numericUpDownA.Value, (int)numericUpDownB.Value, (int)numericUpDownP.Value, //a, b, p bytes
                    (int)numericNumRuns.Value); //number of runs

                DataTable dt = ToDataTable(resultList);

                ResultReady?.Invoke(dt);
            });

            progressBar.Visible = false;
            buttonAnalyze.Enabled = true;
        }

        private DataTable ToDataTable(List<Tuple<TypeOfAlgo, double>> items)
        {
            DataTable dataTable = new DataTable("Results");

            dataTable.Columns.Add(AlgorithmCol, typeof(string));
            dataTable.Columns.Add(AvarageCol, typeof(double));

            foreach (var item in items)
            {
                var values = new object[dataTable.Columns.Count];
                values[0] = TypesOfAlgoDictypesDict[item.Item1];
                values[1] = item.Item2;

                dataTable.Rows.Add(values);
            }

            return dataTable;
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
