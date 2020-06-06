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
            Console.WriteLine("ChangeDataSourceOfGrid");

            gridMain.DataSource = null;
            gridMain.DataSource = dataTable;
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

        private DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                Type t = Type.GetType(prop.PropertyType.FullName);
                dataTable.Columns.Add(prop.Name, t);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            //put a breakpoint here and check datatable
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
