using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace HW4_1_C
{
    public partial class Form1 : Form
    {

        private int numVariables = 0;
        private List<int> subdivisions = new List<int>();
        private int numberElements = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateInputFields()
        {
            numVariables = int.Parse(numberVariablesTextBox.Text);

            if (numVariables <= 0)
            {
                MessageBox.Show("Please enter a valid number of variables.");
                return;
            }

            subdivisions = Enumerable.Repeat(0, numVariables).ToList();
            inputFieldsPanel.Controls.Clear();

            for (int i = 0; i < numVariables; i++)
            {
                if (i % 5 == 0)
                {
                    inputFieldsPanel.Controls.Add(new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        AutoSize = true
                    });
                }

                var inputFieldPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true
                };

                var label = new Label
                {
                    Text = $"Subdivisions Var {i + 1}:",
                    Size = new Size(243, 20)
                };

                var input = new NumericUpDown
                {
                    Minimum = 1,
                    Value = subdivisions[i] == 0 ? 1 : subdivisions[i],
                    Tag = i
                };

                input.ValueChanged += Input_ValueChanged;

                inputFieldPanel.Controls.Add(label);
                inputFieldPanel.Controls.Add(input);

                (inputFieldsPanel.Controls[inputFieldsPanel.Controls.Count - 1] as FlowLayoutPanel)?.Controls.Add(inputFieldPanel);
            }
        }

        private void Input_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            if (numericUpDown != null)
            {
                subdivisions[(int)numericUpDown.Tag] = (int)numericUpDown.Value;
            }
        }

        private void GenerateRandomData()
        {
            numVariables = int.Parse(numberVariablesTextBox.Text);
            numberElements = int.Parse(numberElementsTextBox.Text);

            var data = new List<List<double>>();
            var intervals = new List<int>();

            var dataWithIntervals = new List<List<string>>();

            for (int i = 0; i < numVariables; i++)
            {
                var tmp = new List<double>();
                var tmpWithIntervals = new List<string>();
                var numIntervals = subdivisions[i];

                var random = new Random();

                for (int c = 0; c < numberElements; c++)
                {
                    var randomNumber = random.NextDouble();
                    tmp.Add(randomNumber);
                }

                double max = tmp.Max();
                double min = tmp.Min();

                double dimension;

                if (numIntervals == 0)
                {
                    dimension = (max - min);
                }
                else
                {
                    dimension = (max - min) / numIntervals;
                }

                Debug.WriteLine(dimension);

                for (int c = 0; c < numberElements; c++)
                {
                    for (double j = min; j < max; j += dimension)
                    {
                        var start = j;
                        var end = start + dimension;

                        if (tmp[c] >= start && tmp[c] < end)
                        {
                            tmpWithIntervals.Add($"{start:F2}-{end:F2}");
                        }

                        if (end == max && tmp[c] == end)
                        {
                            tmpWithIntervals.Add($"{start:F2}-{end:F2}");
                        }
                    }
                }

                intervals.Add(numIntervals);
                data.Add(tmp);
                dataWithIntervals.Add(tmpWithIntervals);

            }

            JoinDistribution(dataWithIntervals);
        }

        Dictionary<string, int> jointDistribution = new Dictionary<string, int>();
        private void JoinDistribution(List<List<string>> dataWithIntervals)
        {

            Combinations(dataWithIntervals, 0, "", jointDistribution);

            for (var r = 0; r < dataWithIntervals[0].Count(); r++)
            {
                var key = "";
                for (var v = 0; v < dataWithIntervals.Count(); v++)
                {
                    key += dataWithIntervals[v][r] + "///";
                }
                jointDistribution[key] += 1;
            }

            var tableJoin = tableJOIN;

            tableJOIN.Columns.Add("Key", "Key");
            tableJOIN.Columns.Add("FrequenzaAssoluta", "Absolute frequency");
            tableJOIN.Columns.Add("FrequenzaRelativa", "Relative frequency");
            tableJOIN.Columns.Add("PercentualeFrequenza", "Percentage Frequency");

            for (int i = tableJoin.RowCount - 1; i > 0; i--)
            {
                tableJoin.Rows.RemoveAt(i);
            }

            foreach (var keyValue in jointDistribution)
            {
                var key = keyValue.Key;
                double value = keyValue.Value;

                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = key });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = value.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = ((double)(value / numberElements)).ToString("F5") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = (((double)(value / numberElements)) * 100).ToString("F2") });

                tableJoin.Rows.Add(row);
            }
        }

        private void Combinations(List<List<string>> arrays, int index, string currentCombination, Dictionary<string, int> result)
        {
            if (index == arrays.Count)
            {
                result[currentCombination] = 0;
                return;
            }

            for (int i = 0; i < arrays[index].Count; i++)
            {
                string newCombination = currentCombination + arrays[index][i] + "///";
                Combinations(arrays, index + 1, newCombination, result);
            }
        }

        private void generateInputButton_Click(object sender, EventArgs e)
        {
            GenerateInputFields();
        }

        private void generateDataButton_Click(object sender, EventArgs e)
        {
            GenerateRandomData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}